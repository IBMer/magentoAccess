﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetOpenAuth.Messaging;
using MagentoAccess.Models.Credentials;
using MagentoAccess.Models.GetOrders;
using MagentoAccess.Models.GetProducts;
using MagentoAccess.Models.PutStockItems;
using MagentoAccess.Services;
using Netco.Extensions;

namespace MagentoAccess
{
	public class MagentoService : IMagentoService
	{
		public virtual IMagentoServiceLowLevel MagentoServiceLowLevel { get; set; }

		public delegate void SaveAccessToken( string token, string secret );

		public SaveAccessToken AfterGettingToken { get; set; }

		public MagentoService( MagentoAuthenticatedUserCredentials magentoAuthenticatedUserCredentials )
		{
			this.MagentoServiceLowLevel = new MagentoServiceLowLevel(
				magentoAuthenticatedUserCredentials.ConsumerKey,
				magentoAuthenticatedUserCredentials.ConsumerSckretKey,
				magentoAuthenticatedUserCredentials.BaseMagentoUrl,
				magentoAuthenticatedUserCredentials.AccessToken,
				magentoAuthenticatedUserCredentials.AccessTokenSecret
				);
		}

		public MagentoService( MagentoNonAuthenticatedUserCredentials magentoUserCredentials )
		{
			this.MagentoServiceLowLevel = new MagentoServiceLowLevel(
				magentoUserCredentials.ConsumerKey,
				magentoUserCredentials.ConsumerSckretKey,
				magentoUserCredentials.BaseMagentoUrl,
				magentoUserCredentials.RequestTokenUrl,
				magentoUserCredentials.AuthorizeUrl,
				magentoUserCredentials.AccessTokenUrl
				);
		}

		public async Task< IEnumerable< Order > > GetOrdersAsync( DateTime dateFrom, DateTime dateTo )
		{
			this.Authorize();

			var res = await this.MagentoServiceLowLevel.GetOrdersAsync( dateFrom, dateTo ).ConfigureAwait( false );
			return res.Orders;
		}

		public async Task< IEnumerable< Order > > GetOrdersAsync()
		{
			this.Authorize();

			var res = await this.MagentoServiceLowLevel.GetOrdersAsync().ConfigureAwait( false );
			return res.Orders;
		}

		public async Task<IEnumerable<Product>> GetProductsAsync()
		{
			this.Authorize();

			int page = 1;
			const int itemsPerPage = 100;

			var getProductsResponse = await this.MagentoServiceLowLevel.GetProductsAsync(page, itemsPerPage).ConfigureAwait(false);

			var productsChunk = getProductsResponse.Products;
			if (productsChunk.Count() < itemsPerPage)
				return productsChunk;

			var receivedProducts = new List<Product>();

			var lastReceiveProducts = productsChunk;

			bool isLastAndCurrentResponsesHaveTheSameProducts;

			do
			{
				receivedProducts.AddRange(productsChunk);

				var getProductsTask = this.MagentoServiceLowLevel.GetProductsAsync(++page, itemsPerPage);
				getProductsTask.Wait();
				productsChunk = getProductsTask.Result.Products;

				//var repeatedItems = from l in lastReceiveProducts join c in productsChunk on l.EntityId equals c.EntityId select l;
				var repeatedItems = from c in productsChunk join l in lastReceiveProducts on c.EntityId equals l.EntityId select l;

				lastReceiveProducts = productsChunk;

				isLastAndCurrentResponsesHaveTheSameProducts = repeatedItems.Any();

				// try to get items that was added before last iteration
				if (isLastAndCurrentResponsesHaveTheSameProducts)
				{
					var notRrepeatedItems = productsChunk.Where(x => !repeatedItems.Exists(r => r.EntityId == x.EntityId));
					receivedProducts.AddRange(notRrepeatedItems);
				}


			} while (!isLastAndCurrentResponsesHaveTheSameProducts);

			return receivedProducts;
		}

		public async Task UpdateProductsAsync( IEnumerable< InventoryItem > products )
		{
			this.Authorize();

			await this.MagentoServiceLowLevel.PutInventoryAsync( products ).ConfigureAwait( false );
		}

		private void Authorize()
		{
			if( string.IsNullOrWhiteSpace( this.MagentoServiceLowLevel.AccessToken ) )
			{
				var authorizeTask = this.MagentoServiceLowLevel.PopulateAccessToken();
				authorizeTask.Wait();

				if( this.AfterGettingToken != null )
					this.AfterGettingToken.Invoke( this.MagentoServiceLowLevel.AccessToken, this.MagentoServiceLowLevel.AccessTokenSecret );
			}
		}
	}
}