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
    ///  Class for testing NegativeTargetingClausesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NegativeTargetingClausesApiTests : IDisposable
    {
        private NegativeTargetingClausesApi instance;

        public NegativeTargetingClausesApiTests()
        {
            instance = new NegativeTargetingClausesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NegativeTargetingClausesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NegativeTargetingClausesApi
            //Assert.IsType<NegativeTargetingClausesApi>(instance);
        }

        /// <summary>
        /// Test CreateSponsoredProductsNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void CreateSponsoredProductsNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent = null;
            //string? prefer = null;
            //var response = instance.CreateSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsCreateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
            //Assert.IsType<SponsoredProductsCreateSponsoredProductsNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test DeleteSponsoredProductsNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void DeleteSponsoredProductsNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent = null;
            //var response = instance.DeleteSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent);
            //Assert.IsType<SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test ListSponsoredProductsNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void ListSponsoredProductsNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent? sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent = null;
            //var response = instance.ListSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsListSponsoredProductsNegativeTargetingClausesRequestContent);
            //Assert.IsType<SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent>(response);
        }

        /// <summary>
        /// Test UpdateSponsoredProductsNegativeTargetingClauses
        /// </summary>
        [Fact]
        public void UpdateSponsoredProductsNegativeTargetingClausesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent = null;
            //string? prefer = null;
            //var response = instance.UpdateSponsoredProductsNegativeTargetingClauses(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesRequestContent, prefer);
            //Assert.IsType<SponsoredProductsUpdateSponsoredProductsNegativeTargetingClausesResponseContent>(response);
        }
    }
}