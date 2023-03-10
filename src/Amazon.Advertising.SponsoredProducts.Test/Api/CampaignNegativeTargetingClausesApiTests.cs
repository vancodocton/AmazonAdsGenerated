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
    ///  Class for testing CampaignNegativeTargetingClausesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CampaignNegativeTargetingClausesApiTests : IDisposable
    {
        private readonly CampaignNegativeTargetingClausesApi instance;

        public CampaignNegativeTargetingClausesApiTests()
        {
            instance = new CampaignNegativeTargetingClausesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignNegativeTargetingClausesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CampaignNegativeTargetingClausesApi
            //Assert.IsType<CampaignNegativeTargetingClausesApi>(instance);
        }

        /// <summary>
        /// Test CreateSponsoredProductsCampaignNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void CreateSponsoredProductsCampaignNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent = null;
            //string? prefer = null;
            //var response = instance.CreateSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
            //Assert.IsType<SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test DeleteSponsoredProductsCampaignNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void DeleteSponsoredProductsCampaignNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent = null;
            //var response = instance.DeleteSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
            //Assert.IsType<SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test ListSponsoredProductsCampaignNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void ListSponsoredProductsCampaignNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent? sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent = null;
            //var response = instance.ListSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
            //Assert.IsType<SponsoredProductsListSponsoredProductsCampaignNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test UpdateSponsoredProductsCampaignNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void UpdateSponsoredProductsCampaignNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent = null;
            //string? prefer = null;
            //var response = instance.UpdateSponsoredProductsCampaignNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesRequestContent, prefer);
            //Assert.IsType<SponsoredProductsUpdateSponsoredProductsCampaignNegativeTargetingClausesResponseContent>(response);
        }
    }
}
