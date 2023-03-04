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
    ///  Class for testing BudgetRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BudgetRulesApiTests : IDisposable
    {
        private BudgetRulesApi instance;

        public BudgetRulesApiTests()
        {
            instance = new BudgetRulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BudgetRulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BudgetRulesApi
            //Assert.IsType<BudgetRulesApi>(instance);
        }

        /// <summary>
        /// Test CreateAssociatedBudgetRulesForSPCampaigns
        /// </summary>
        [Fact]
        public void CreateAssociatedBudgetRulesForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //decimal campaignId = null;
            //CreateAssociatedBudgetRulesRequest createAssociatedBudgetRulesRequest = null;
            //var response = instance.CreateAssociatedBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, createAssociatedBudgetRulesRequest);
            //Assert.IsType<CreateAssociatedBudgetRulesResponse>(response);
        }

        /// <summary>
        /// Test CreateBudgetRulesForSPCampaigns
        /// </summary>
        [Fact]
        public void CreateBudgetRulesForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //CreateSPBudgetRulesRequest createSPBudgetRulesRequest = null;
            //var response = instance.CreateBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, createSPBudgetRulesRequest);
            //Assert.IsType<CreateBudgetRulesResponse>(response);
        }

        /// <summary>
        /// Test DisassociateAssociatedBudgetRuleForSPCampaigns
        /// </summary>
        [Fact]
        public void DisassociateAssociatedBudgetRuleForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //decimal campaignId = null;
            //string budgetRuleId = null;
            //var response = instance.DisassociateAssociatedBudgetRuleForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, budgetRuleId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetBudgetRuleByRuleIdForSPCampaigns
        /// </summary>
        [Fact]
        public void GetBudgetRuleByRuleIdForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //string budgetRuleId = null;
            //var response = instance.GetBudgetRuleByRuleIdForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId);
            //Assert.IsType<GetSPBudgetRuleResponse>(response);
        }

        /// <summary>
        /// Test GetCampaignsAssociatedWithSPBudgetRule
        /// </summary>
        [Fact]
        public void GetCampaignsAssociatedWithSPBudgetRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //string budgetRuleId = null;
            //decimal pageSize = null;
            //string? nextToken = null;
            //var response = instance.GetCampaignsAssociatedWithSPBudgetRule(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, budgetRuleId, pageSize, nextToken);
            //Assert.IsType<SPGetAssociatedCampaignsResponse>(response);
        }

        /// <summary>
        /// Test GetRuleBasedBudgetHistoryForSPCampaigns
        /// </summary>
        [Fact]
        public void GetRuleBasedBudgetHistoryForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //decimal campaignId = null;
            //decimal pageSize = null;
            //string startDate = null;
            //string endDate = null;
            //string? nextToken = null;
            //var response = instance.GetRuleBasedBudgetHistoryForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId, pageSize, startDate, endDate, nextToken);
            //Assert.IsType<SPBudgetHistory>(response);
        }

        /// <summary>
        /// Test GetSPBudgetRulesForAdvertiser
        /// </summary>
        [Fact]
        public void GetSPBudgetRulesForAdvertiserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //decimal pageSize = null;
            //string? nextToken = null;
            //var response = instance.GetSPBudgetRulesForAdvertiser(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, pageSize, nextToken);
            //Assert.IsType<GetSPBudgetRulesForAdvertiserResponse>(response);
        }

        /// <summary>
        /// Test ListAssociatedBudgetRulesForSPCampaigns
        /// </summary>
        [Fact]
        public void ListAssociatedBudgetRulesForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //decimal campaignId = null;
            //var response = instance.ListAssociatedBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, campaignId);
            //Assert.IsType<SPListAssociatedBudgetRulesResponse>(response);
        }

        /// <summary>
        /// Test UpdateBudgetRulesForSPCampaigns
        /// </summary>
        [Fact]
        public void UpdateBudgetRulesForSPCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonAdvertisingAPIClientId = null;
            //string amazonAdvertisingAPIScope = null;
            //UpdateSPBudgetRulesRequest updateSPBudgetRulesRequest = null;
            //var response = instance.UpdateBudgetRulesForSPCampaigns(amazonAdvertisingAPIClientId, amazonAdvertisingAPIScope, updateSPBudgetRulesRequest);
            //Assert.IsType<UpdateBudgetRulesResponse>(response);
        }
    }
}
