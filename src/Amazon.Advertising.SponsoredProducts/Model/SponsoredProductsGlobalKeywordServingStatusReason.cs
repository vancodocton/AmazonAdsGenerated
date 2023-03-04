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
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

using OpenAPIDateConverter = Amazon.Advertising.SponsoredProducts.Client.OpenAPIDateConverter;

namespace Amazon.Advertising.SponsoredProducts.Model
{
    /// <summary>
    /// Defines SponsoredProductsGlobalKeywordServingStatusReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsGlobalKeywordServingStatusReason
    {
        /// <summary>
        /// Enum TARGETINGCLAUSEDELIVERINGINALLMARKETPLACES for value: TARGETING_CLAUSE_DELIVERING_IN_ALL_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_DELIVERING_IN_ALL_MARKETPLACES")]
        TARGETINGCLAUSEDELIVERINGINALLMARKETPLACES = 1,

        /// <summary>
        /// Enum ADVERTISERPAYMENTFAILUREINATLEASTONEMARKETPLACE for value: ADVERTISER_PAYMENT_FAILURE_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAYMENT_FAILURE_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADVERTISERPAYMENTFAILUREINATLEASTONEMARKETPLACE = 2,

        /// <summary>
        /// Enum ACCOUNTOUTOFBUDGETINATLEASTONEMARKETPLACE for value: ACCOUNT_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "ACCOUNT_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE")]
        ACCOUNTOUTOFBUDGETINATLEASTONEMARKETPLACE = 3,

        /// <summary>
        /// Enum ADVERTISERPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACES for value: ADVERTISER_POLICING_PENDING_REVIEW_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_PENDING_REVIEW_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACES = 4,

        /// <summary>
        /// Enum ADVERTISERPOLICINGSUSPENDEDINATLEASTONEMARKETPLACES for value: ADVERTISER_POLICING_SUSPENDED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_SUSPENDED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPOLICINGSUSPENDEDINATLEASTONEMARKETPLACES = 5,

        /// <summary>
        /// Enum ADVERTISERPAUSEDINATLEASTONEMARKETPLACES for value: ADVERTISER_PAUSED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAUSED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERPAUSEDINATLEASTONEMARKETPLACES = 6,

        /// <summary>
        /// Enum ADVERTISERARCHIVEDINATLEASTONEMARKETPLACES for value: ADVERTISER_ARCHIVED_IN_ATLEAST_ONE_MARKETPLACES
        /// </summary>
        [EnumMember(Value = "ADVERTISER_ARCHIVED_IN_ATLEAST_ONE_MARKETPLACES")]
        ADVERTISERARCHIVEDINATLEASTONEMARKETPLACES = 7,

        /// <summary>
        /// Enum CAMPAIGNOUTOFBUDGETINATLEASTONEMARKETPLACE for value: CAMPAIGN_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_OUT_OF_BUDGET_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNOUTOFBUDGETINATLEASTONEMARKETPLACE = 8,

        /// <summary>
        /// Enum CAMPAIGNPAUSEDINATLEASTONEMARKETPLACE for value: CAMPAIGN_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNPAUSEDINATLEASTONEMARKETPLACE = 9,

        /// <summary>
        /// Enum CAMPAIGNARCHIVED for value: CAMPAIGN_ARCHIVED
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ARCHIVED")]
        CAMPAIGNARCHIVED = 10,

        /// <summary>
        /// Enum CAMPAIGNINCOMPLETEINATLEASTONEMARKETPLACE for value: CAMPAIGN_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNINCOMPLETEINATLEASTONEMARKETPLACE = 11,

        /// <summary>
        /// Enum CAMPAIGNCREATIONFAILEDINATLEASTONEMARKETPLACE for value: CAMPAIGN_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE")]
        CAMPAIGNCREATIONFAILEDINATLEASTONEMARKETPLACE = 12,

        /// <summary>
        /// Enum CAMPAIGNPENDINGSTARTDATE for value: CAMPAIGN_PENDING_START_DATE
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PENDING_START_DATE")]
        CAMPAIGNPENDINGSTARTDATE = 13,

        /// <summary>
        /// Enum CAMPAIGNENDED for value: CAMPAIGN_ENDED
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ENDED")]
        CAMPAIGNENDED = 14,

        /// <summary>
        /// Enum ADGROUPPAUSEDINATLEASTONEMARKETPLACE for value: AD_GROUP_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPPAUSEDINATLEASTONEMARKETPLACE = 15,

        /// <summary>
        /// Enum ADGROUPARCHIVED for value: AD_GROUP_ARCHIVED
        /// </summary>
        [EnumMember(Value = "AD_GROUP_ARCHIVED")]
        ADGROUPARCHIVED = 16,

        /// <summary>
        /// Enum ADGROUPINCOMPLETEINATLEASTONEMARKETPLACE for value: AD_GROUP_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_INCOMPLETE_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPINCOMPLETEINATLEASTONEMARKETPLACE = 17,

        /// <summary>
        /// Enum ADGROUPCREATIONINPROGRESSINATLEASTONEMARKETPLACE for value: AD_GROUP_CREATION_IN_PROGRESS_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_CREATION_IN_PROGRESS_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPCREATIONINPROGRESSINATLEASTONEMARKETPLACE = 18,

        /// <summary>
        /// Enum ADGROUPCREATIONFAILEDINATLEASTONEMARKETPLACE for value: AD_GROUP_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPCREATIONFAILEDINATLEASTONEMARKETPLACE = 19,

        /// <summary>
        /// Enum ADGROUPPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACE for value: AD_GROUP_POLICING_PENDING_REVIEW_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_PENDING_REVIEW_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPPOLICINGPENDINGREVIEWINATLEASTONEMARKETPLACE = 20,

        /// <summary>
        /// Enum ADGROUPPOLICINGCREATIVEREJECTEDINATLEASTONEMARKETPLACE for value: AD_GROUP_POLICING_CREATIVE_REJECTED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_CREATIVE_REJECTED_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPPOLICINGCREATIVEREJECTEDINATLEASTONEMARKETPLACE = 21,

        /// <summary>
        /// Enum ADGROUPLOWBIDINATLEASTONEMARKETPLACE for value: AD_GROUP_LOW_BID_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "AD_GROUP_LOW_BID_IN_AT_LEAST_ONE_MARKETPLACE")]
        ADGROUPLOWBIDINATLEASTONEMARKETPLACE = 22,

        /// <summary>
        /// Enum TARGETINGCLAUSEPAUSEDINATLEASTONEMARKETPLACE for value: TARGETING_CLAUSE_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_PAUSED_IN_AT_LEAST_ONE_MARKETPLACE")]
        TARGETINGCLAUSEPAUSEDINATLEASTONEMARKETPLACE = 23,

        /// <summary>
        /// Enum TARGETINGCLAUSEARCHIVED for value: TARGETING_CLAUSE_ARCHIVED
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_ARCHIVED")]
        TARGETINGCLAUSEARCHIVED = 24,

        /// <summary>
        /// Enum TARGETINGCLAUSEPOLICINGSUSPENDEDINATLEASTONEMARKETPLACE for value: TARGETING_CLAUSE_POLICING_SUSPENDED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_POLICING_SUSPENDED_IN_AT_LEAST_ONE_MARKETPLACE")]
        TARGETINGCLAUSEPOLICINGSUSPENDEDINATLEASTONEMARKETPLACE = 25,

        /// <summary>
        /// Enum TARGETINGCLAUSECREATIONFAILEDINATLEASTONEMARKETPLACE for value: TARGETING_CLAUSE_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_CREATION_FAILED_IN_AT_LEAST_ONE_MARKETPLACE")]
        TARGETINGCLAUSECREATIONFAILEDINATLEASTONEMARKETPLACE = 26,

        /// <summary>
        /// Enum TARGETINGCLAUSEBLOCKEDINATLEASTONEMARKETPLACE for value: TARGETING_CLAUSE_BLOCKED_IN_AT_LEAST_ONE_MARKETPLACE
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_BLOCKED_IN_AT_LEAST_ONE_MARKETPLACE")]
        TARGETINGCLAUSEBLOCKEDINATLEASTONEMARKETPLACE = 27

    }

}
