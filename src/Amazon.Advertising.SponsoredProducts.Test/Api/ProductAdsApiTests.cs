/*
 * Sponsored Products
 *
 *  
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Amazon.Advertising.SponsoredProducts.Client;
using Amazon.Advertising.SponsoredProducts.Api;
// uncomment below to import models
//using Amazon.Advertising.SponsoredProducts.Model;

namespace Amazon.Advertising.SponsoredProducts.Test.Api
{
    /// <summary>
    ///  Class for testing ProductAdsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductAdsApiTests : IDisposable
    {
        private ProductAdsApi instance;

        public ProductAdsApiTests()
        {
            instance = new ProductAdsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductAdsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductAdsApi
            //Assert.IsType<ProductAdsApi>(instance);
        }

        /// <summary>
        /// Test CreateSponsoredProductsProductAds
        /// </summary>
        [Fact]
        public void CreateSponsoredProductsProductAdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsCreateSponsoredProductsProductAdsRequestContent sponsoredProductsCreateSponsoredProductsProductAdsRequestContent = null;
            //string? prefer = null;
            //var response = instance.CreateSponsoredProductsProductAds(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsProductAdsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsCreateSponsoredProductsProductAdsResponseContent>(response);
        }

        /// <summary>
        /// Test DeleteSponsoredProductsProductAds
        /// </summary>
        [Fact]
        public void DeleteSponsoredProductsProductAdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsDeleteSponsoredProductsProductAdsRequestContent sponsoredProductsDeleteSponsoredProductsProductAdsRequestContent = null;
            //var response = instance.DeleteSponsoredProductsProductAds(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsProductAdsRequestContent);
            //Assert.IsType<SponsoredProductsDeleteSponsoredProductsProductAdsResponseContent>(response);
        }

        /// <summary>
        /// Test ListSponsoredProductsProductAds
        /// </summary>
        [Fact]
        public void ListSponsoredProductsProductAdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsListSponsoredProductsProductAdsRequestContent? sponsoredProductsListSponsoredProductsProductAdsRequestContent = null;
            //var response = instance.ListSponsoredProductsProductAds(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsProductAdsRequestContent);
            //Assert.IsType<SponsoredProductsListSponsoredProductsProductAdsResponseContent>(response);
        }

        /// <summary>
        /// Test UpdateSponsoredProductsProductAds
        /// </summary>
        [Fact]
        public void UpdateSponsoredProductsProductAdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsUpdateSponsoredProductsProductAdsRequestContent sponsoredProductsUpdateSponsoredProductsProductAdsRequestContent = null;
            //string? prefer = null;
            //var response = instance.UpdateSponsoredProductsProductAds(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsProductAdsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsUpdateSponsoredProductsProductAdsResponseContent>(response);
        }
    }
}
