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
    /// Defines SponsoredProductsKeywordServingStatusReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsKeywordServingStatusReason
    {
        /// <summary>
        /// Enum TARGETINGCLAUSESTATUSLIVEDETAIL for value: TARGETING_CLAUSE_STATUS_LIVE_DETAIL
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_STATUS_LIVE_DETAIL")]
        TARGETINGCLAUSESTATUSLIVEDETAIL = 1,

        /// <summary>
        /// Enum TARGETINGCLAUSEPOLICINGSUSPENDEDDETAIL for value: TARGETING_CLAUSE_POLICING_SUSPENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_POLICING_SUSPENDED_DETAIL")]
        TARGETINGCLAUSEPOLICINGSUSPENDEDDETAIL = 2,

        /// <summary>
        /// Enum TARGETINGCLAUSEPAUSEDDETAIL for value: TARGETING_CLAUSE_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_PAUSED_DETAIL")]
        TARGETINGCLAUSEPAUSEDDETAIL = 3,

        /// <summary>
        /// Enum TARGETINGCLAUSEARCHIVEDDETAIL for value: TARGETING_CLAUSE_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_ARCHIVED_DETAIL")]
        TARGETINGCLAUSEARCHIVEDDETAIL = 4,

        /// <summary>
        /// Enum TARGETINGCLAUSEBLOCKEDDETAIL for value: TARGETING_CLAUSE_BLOCKED_DETAIL
        /// </summary>
        [EnumMember(Value = "TARGETING_CLAUSE_BLOCKED_DETAIL")]
        TARGETINGCLAUSEBLOCKEDDETAIL = 5,

        /// <summary>
        /// Enum ADGROUPSTATUSENABLEDDETAIL for value: AD_GROUP_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_STATUS_ENABLED_DETAIL")]
        ADGROUPSTATUSENABLEDDETAIL = 6,

        /// <summary>
        /// Enum ADGROUPPAUSEDDETAIL for value: AD_GROUP_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_PAUSED_DETAIL")]
        ADGROUPPAUSEDDETAIL = 7,

        /// <summary>
        /// Enum ADGROUPARCHIVEDDETAIL for value: AD_GROUP_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_ARCHIVED_DETAIL")]
        ADGROUPARCHIVEDDETAIL = 8,

        /// <summary>
        /// Enum ADGROUPINCOMPLETEDETAIL for value: AD_GROUP_INCOMPLETE_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_INCOMPLETE_DETAIL")]
        ADGROUPINCOMPLETEDETAIL = 9,

        /// <summary>
        /// Enum ADGROUPPOLICINGPENDINGREVIEWDETAIL for value: AD_GROUP_POLICING_PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_PENDING_REVIEW_DETAIL")]
        ADGROUPPOLICINGPENDINGREVIEWDETAIL = 10,

        /// <summary>
        /// Enum ADGROUPPOLICINGCREATIVEREJECTEDDETAIL for value: AD_GROUP_POLICING_CREATIVE_REJECTED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_CREATIVE_REJECTED_DETAIL")]
        ADGROUPPOLICINGCREATIVEREJECTEDDETAIL = 11,

        /// <summary>
        /// Enum ADGROUPLOWBIDDETAIL for value: AD_GROUP_LOW_BID_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_LOW_BID_DETAIL")]
        ADGROUPLOWBIDDETAIL = 12,

        /// <summary>
        /// Enum CAMPAIGNSTATUSENABLEDDETAIL for value: CAMPAIGN_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_STATUS_ENABLED_DETAIL")]
        CAMPAIGNSTATUSENABLEDDETAIL = 13,

        /// <summary>
        /// Enum CAMPAIGNPAUSEDDETAIL for value: CAMPAIGN_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PAUSED_DETAIL")]
        CAMPAIGNPAUSEDDETAIL = 14,

        /// <summary>
        /// Enum CAMPAIGNARCHIVEDDETAIL for value: CAMPAIGN_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ARCHIVED_DETAIL")]
        CAMPAIGNARCHIVEDDETAIL = 15,

        /// <summary>
        /// Enum PENDINGREVIEWDETAIL for value: PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW_DETAIL")]
        PENDINGREVIEWDETAIL = 16,

        /// <summary>
        /// Enum REJECTEDDETAIL for value: REJECTED_DETAIL
        /// </summary>
        [EnumMember(Value = "REJECTED_DETAIL")]
        REJECTEDDETAIL = 17,

        /// <summary>
        /// Enum PENDINGSTARTDATEDETAIL for value: PENDING_START_DATE_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_START_DATE_DETAIL")]
        PENDINGSTARTDATEDETAIL = 18,

        /// <summary>
        /// Enum ENDEDDETAIL for value: ENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ENDED_DETAIL")]
        ENDEDDETAIL = 19,

        /// <summary>
        /// Enum CAMPAIGNOUTOFBUDGETDETAIL for value: CAMPAIGN_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_OUT_OF_BUDGET_DETAIL")]
        CAMPAIGNOUTOFBUDGETDETAIL = 20,

        /// <summary>
        /// Enum CAMPAIGNINCOMPLETEDETAIL for value: CAMPAIGN_INCOMPLETE_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INCOMPLETE_DETAIL")]
        CAMPAIGNINCOMPLETEDETAIL = 21,

        /// <summary>
        /// Enum PORTFOLIOSTATUSENABLEDDETAIL for value: PORTFOLIO_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_STATUS_ENABLED_DETAIL")]
        PORTFOLIOSTATUSENABLEDDETAIL = 22,

        /// <summary>
        /// Enum PORTFOLIOPAUSEDDETAIL for value: PORTFOLIO_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_PAUSED_DETAIL")]
        PORTFOLIOPAUSEDDETAIL = 23,

        /// <summary>
        /// Enum PORTFOLIOARCHIVEDDETAIL for value: PORTFOLIO_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_ARCHIVED_DETAIL")]
        PORTFOLIOARCHIVEDDETAIL = 24,

        /// <summary>
        /// Enum PORTFOLIOOUTOFBUDGETDETAIL for value: PORTFOLIO_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_OUT_OF_BUDGET_DETAIL")]
        PORTFOLIOOUTOFBUDGETDETAIL = 25,

        /// <summary>
        /// Enum PORTFOLIOPENDINGSTARTDATEDETAIL for value: PORTFOLIO_PENDING_START_DATE_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_PENDING_START_DATE_DETAIL")]
        PORTFOLIOPENDINGSTARTDATEDETAIL = 26,

        /// <summary>
        /// Enum PORTFOLIOENDEDDETAIL for value: PORTFOLIO_ENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_ENDED_DETAIL")]
        PORTFOLIOENDEDDETAIL = 27,

        /// <summary>
        /// Enum ADVERTISERPOLICINGSUSPENDEDDETAIL for value: ADVERTISER_POLICING_SUSPENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_SUSPENDED_DETAIL")]
        ADVERTISERPOLICINGSUSPENDEDDETAIL = 28,

        /// <summary>
        /// Enum ADVERTISERPOLICINGPENDINGREVIEWDETAIL for value: ADVERTISER_POLICING_PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_PENDING_REVIEW_DETAIL")]
        ADVERTISERPOLICINGPENDINGREVIEWDETAIL = 29,

        /// <summary>
        /// Enum ADVERTISERARCHIVEDDETAIL for value: ADVERTISER_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_ARCHIVED_DETAIL")]
        ADVERTISERARCHIVEDDETAIL = 30,

        /// <summary>
        /// Enum ADVERTISERPAUSEDDETAIL for value: ADVERTISER_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAUSED_DETAIL")]
        ADVERTISERPAUSEDDETAIL = 31,

        /// <summary>
        /// Enum ADVERTISEROUTOFBUDGETDETAIL for value: ADVERTISER_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_OUT_OF_BUDGET_DETAIL")]
        ADVERTISEROUTOFBUDGETDETAIL = 32,

        /// <summary>
        /// Enum ADVERTISERPAYMENTFAILUREDETAIL for value: ADVERTISER_PAYMENT_FAILURE_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAYMENT_FAILURE_DETAIL")]
        ADVERTISERPAYMENTFAILUREDETAIL = 33,

        /// <summary>
        /// Enum ACCOUNTOUTOFBUDGETDETAIL for value: ACCOUNT_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "ACCOUNT_OUT_OF_BUDGET_DETAIL")]
        ACCOUNTOUTOFBUDGETDETAIL = 34,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 35

    }

}
