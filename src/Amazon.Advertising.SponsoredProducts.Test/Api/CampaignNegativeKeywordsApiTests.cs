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
    ///  Class for testing CampaignNegativeKeywordsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CampaignNegativeKeywordsApiTests : IDisposable
    {
        private readonly CampaignNegativeKeywordsApi instance;

        public CampaignNegativeKeywordsApiTests()
        {
            instance = new CampaignNegativeKeywordsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignNegativeKeywordsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CampaignNegativeKeywordsApi
            //Assert.IsType<CampaignNegativeKeywordsApi>(instance);
        }

        /// <summary>
        /// Test CreateSponsoredProductsCampaignNegativeKeywords
        /// </summary>
        [Fact]
        public void CreateSponsoredProductsCampaignNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent = null;
            //string? prefer = null;
            //var response = instance.CreateSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsCreateSponsoredProductsCampaignNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test DeleteSponsoredProductsCampaignNegativeKeywords
        /// </summary>
        [Fact]
        public void DeleteSponsoredProductsCampaignNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent = null;
            //var response = instance.DeleteSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsRequestContent);
            //Assert.IsType<SponsoredProductsDeleteSponsoredProductsCampaignNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test ListSponsoredProductsCampaignNegativeKeywords
        /// </summary>
        [Fact]
        public void ListSponsoredProductsCampaignNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent? sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent = null;
            //var response = instance.ListSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeKeywordsRequestContent);
            //Assert.IsType<SponsoredProductsListSponsoredProductsCampaignNegativeKeywordsResponseContent>(response);
        }

        /// <summary>
        /// Test UpdateSponsoredProductsCampaignNegativeKeywords
        /// </summary>
        [Fact]
        public void UpdateSponsoredProductsCampaignNegativeKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent = null;
            //string? prefer = null;
            //var response = instance.UpdateSponsoredProductsCampaignNegativeKeywords(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsRequestContent, prefer);
            //Assert.IsType<SponsoredProductsUpdateSponsoredProductsCampaignNegativeKeywordsResponseContent>(response);
        }
    }
}
