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
    ///  Class for testing BudgetUsageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BudgetUsageApiTests : IDisposable
    {
        private BudgetUsageApi instance;

        public BudgetUsageApiTests()
        {
            instance = new BudgetUsageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BudgetUsageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BudgetUsageApi
            //Assert.IsType<BudgetUsageApi>(instance);
        }

        /// <summary>
        /// Test SpCampaignsBudgetUsage
        /// </summary>
        [Fact]
        public void SpCampaignsBudgetUsageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object amazonAdvertisingAPIClientId = null;
            //Object amazonAdvertisingAPIScope = null;
            //BudgetUsageCampaignRequest budgetUsageCampaignRequest = null;
            //var response = instance.SpCampaignsBudgetUsage(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetUsageCampaignRequest);
            //Assert.IsType<BudgetUsageCampaignResponse>(response);
        }
    }
}
