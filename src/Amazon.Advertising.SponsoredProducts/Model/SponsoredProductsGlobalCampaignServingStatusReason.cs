/*
 * Sponsored Products
 *
 *  
 *
 * The version of the OpenAPI document: 3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Amazon.Advertising.SponsoredProducts.Client.OpenAPIDateConverter;

namespace Amazon.Advertising.SponsoredProducts.Model
{
    /// <summary>
    /// Defines SponsoredProductsGlobalCampaignServingStatusReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsGlobalCampaignServingStatusReason
    {
        /// <summary>
        /// Enum CAMPAIGNDELIVERINGINALLMARKETPLACES for value: CAMPAIGN_DELIVERING_IN_ALL_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_DELIVERING_IN_ALL_MARKETPLACES")]
        CAMPAIGNDELIVERINGINALLMARKETPLACES = 1,

        /// <summary>
        /// Enum ADVERTISERPAYMENTFAILUREINATLEASTONEMARKETPLACE for value: ADVERTISER_PAYMENT_FAILURE_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAYMENT_FAILURE_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADVERTISERPAYMENTFAILUREINATLEASTONEMARKETPLACE = 2,

        /// <summary>
        /// Enum ADVERTISERPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACES for value: ADVERTISER_POLICING_PENDING_REVIEW_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_PENDING_REVIEW_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACES = 3,

        /// <summary>
        /// Enum ADVERTISERPOLICINGSUSPENDEDINATLEASTONEMARKETPLACES for value: ADVERTISER_POLICING_SUSPENDED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_SUSPENDED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPOLICINGSUSPENDEDINATLEASTONEMARKETPLACES = 4,

        /// <summary>
        /// Enum ADVERTISERPAUSEDINATLEASTONEMARKETPLACES for value: ADVERTISER_PAUSED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAUSED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPAUSEDINATLEASTONEMARKETPLACES = 5,

        /// <summary>
        /// Enum ADVERTISERARCHIVEDINATLEASTONEMARKETPLACES for value: ADVERTISER_ARCHIVED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_ARCHIVED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERARCHIVEDINATLEASTONEMARKETPLACES = 6,

        /// <summary>
        /// Enum CAMPAIGNOUTOFBUDGETINATLEASTONEMARKETPLACE for value: CAMPAIGN_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNOUTOFBUDGETINATLEASTONEMARKETPLACE = 7,

        /// <summary>
        /// Enum CAMPAIGNPAUSEDINATLEASTONEMARKETPLACE for value: CAMPAIGN_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNPAUSEDINATLEASTONEMARKETPLACE = 8,

        /// <summary>
        /// Enum CAMPAIGNARCHIVED for value: CAMPAIGN_ARCHIVED
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ARCHIVED")]
        CAMPAIGNARCHIVED = 9,

        /// <summary>
        /// Enum CAMPAIGNINCOMPLETEINATLEASTONEMARKETPLACE for value: CAMPAIGN_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNINCOMPLETEINATLEASTONEMARKETPLACE = 10,

        /// <summary>
        /// Enum CAMPAIGNPENDINGSTARTDATE for value: CAMPAIGN_PENDING_START_DATE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PENDING_START_DATE")]
        CAMPAIGNPENDINGSTARTDATE = 11,

        /// <summary>
        /// Enum CAMPAIGNENDED for value: CAMPAIGN_ENDED
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ENDED")]
        CAMPAIGNENDED = 12

    }

}
