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
    ///  Class for testing CampaignOptimizationRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CampaignOptimizationRulesApiTests : IDisposable
    {
        private CampaignOptimizationRulesApi instance;

        public CampaignOptimizationRulesApiTests()
        {
            instance = new CampaignOptimizationRulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CampaignOptimizationRulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CampaignOptimizationRulesApi
            //Assert.IsType<CampaignOptimizationRulesApi>(instance);
        }

        /// <summary>
        /// Test CreateOptimizationRule
        /// </summary>
        [Fact]
        public void CreateOptimizationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //CreateSPCampaignOptimizationRulesRequest createSPCampaignOptimizationRulesRequest = null;
            //var response = instance.CreateOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPCampaignOptimizationRulesRequest);
            //Assert.IsType<CreateSPCampaignOptimizationRulesResponse>(response);
        }

        /// <summary>
        /// Test DeleteCampaignOptimizationRule
        /// </summary>
        [Fact]
        public void DeleteCampaignOptimizationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //string campaignOptimizationId = null;
            //var response = instance.DeleteCampaignOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
            //Assert.IsType<DeleteSPCampaignOptimizationRuleResponse>(response);
        }

        /// <summary>
        /// Test GetCampaignOptimizationRule
        /// </summary>
        [Fact]
        public void GetCampaignOptimizationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //string campaignOptimizationId = null;
            //var response = instance.GetCampaignOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignOptimizationId);
            //Assert.IsType<GetSPCampaignOptimizationRuleResponse>(response);
        }

        /// <summary>
        /// Test GetOptimizationRuleEligibility
        /// </summary>
        [Fact]
        public void GetOptimizationRuleEligibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SPCampaignOptimizationRecommendationsAPIRequest sPCampaignOptimizationRecommendationsAPIRequest = null;
            //var response = instance.GetOptimizationRuleEligibility(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationRecommendationsAPIRequest);
            //Assert.IsType<SPCampaignOptimizationRecommendationAPIResponse>(response);
        }

        /// <summary>
        /// Test GetRuleNotification
        /// </summary>
        [Fact]
        public void GetRuleNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //SPCampaignOptimizationNotificationAPIRequest sPCampaignOptimizationNotificationAPIRequest = null;
            //var response = instance.GetRuleNotification(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, sPCampaignOptimizationNotificationAPIRequest);
            //Assert.IsType<SPCampaignOptimizationNotificationAPIResponse>(response);
        }

        /// <summary>
        /// Test UpdateOptimizationRule
        /// </summary>
        [Fact]
        public void UpdateOptimizationRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //UpdateSPCampaignOptimizationRulesRequest updateSPCampaignOptimizationRulesRequest = null;
            //var response = instance.UpdateOptimizationRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPCampaignOptimizationRulesRequest);
            //Assert.IsType<UpdateSPCampaignOptimizationRuleResponse>(response);
        }
    }
}
