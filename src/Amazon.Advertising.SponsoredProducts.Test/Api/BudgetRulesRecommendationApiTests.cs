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
    ///  Class for testing BudgetRulesRecommendationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BudgetRulesRecommendationApiTests : IDisposable
    {
        private readonly BudgetRulesRecommendationApi instance;

        public BudgetRulesRecommendationApiTests()
        {
            instance = new BudgetRulesRecommendationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BudgetRulesRecommendationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BudgetRulesRecommendationApi
            //Assert.IsType<BudgetRulesRecommendationApi>(instance);
        }

        /// <summary>
        /// Test SPGetBudgetRulesRecommendation
        /// </summary>
        [Fact]
        public void SPGetBudgetRulesRecommendationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SPGetBudgetRulesRecommendationRequest? sPGetBudgetRulesRecommendationRequest = null;
            //var response = instance.SPGetBudgetRulesRecommendation(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPGetBudgetRulesRecommendationRequest);
            //Assert.IsType<SPBudgetRulesRecommendationEventResponse>(response);
        }
    }
}
