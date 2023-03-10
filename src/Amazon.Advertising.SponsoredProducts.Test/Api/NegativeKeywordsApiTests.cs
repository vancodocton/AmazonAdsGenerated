/*
 * Sponsored Products
 *
 *  
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;

using Amazon.Advertising.SponsoredProducts.Api;
using Amazon.Advertising.SponsoredProducts.Client;

using RestSharp;

using Xunit;
// uncomment below to import models
//using Amazon.Advertising.SponsoredProducts.Model;

namespace Amazon.Advertising.SponsoredProducts.Test.Api
{
    /// <summary>
    ///  Class for testing NegativeKeywordsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NegativeKeywordsApiTests : IDisposable
    {
        private readonly NegativeKeywordsApi instance;

        public NegativeKeywordsApiTests()
        {
            instance = new NegativeKeywordsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NegativeKeywordsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NegativeKeywordsApi
            //Assert.IsType<NegativeKeywordsApi>(instance);
        }

        /// <summary>
        /// Test CreateSponsoredProductsNegativeKeywords
        /// </summary>
        [Fact]
        public void CreateSponsoredProductsNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent = null;
            //string? prefer = null;
            //var response = instance.CreateSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeKeywordsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsCreateSponsoredProductsNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test DeleteSponsoredProductsNegativeKeywords
        /// </summary>
        [Fact]
        public void DeleteSponsoredProductsNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent = null;
            //var response = instance.DeleteSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeKeywordsRequestContent);
            //Assert.IsType<SponsoredProductsDeleteSponsoredProductsNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test ListSponsoredProductsNegativeKeywords
        /// </summary>
        [Fact]
        public void ListSponsoredProductsNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent? sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent = null;
            //var response = instance.ListSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeKeywordsRequestContent);
            //Assert.IsType<SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test UpdateSponsoredProductsNegativeKeywords
        /// </summary>
        [Fact]
        public void UpdateSponsoredProductsNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent = null;
            //string? prefer = null;
            //var response = instance.UpdateSponsoredProductsNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeKeywordsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsUpdateSponsoredProductsNegativeKeywordsResponseContent>(response);
        }
    }
}
