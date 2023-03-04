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
    /// Defines SponsoredProductsCampaignServingStatusReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsCampaignServingStatusReason
    {
        /// <summary>
        /// Enum CAMPAIGNSTATUSENABLEDDETAIL for value: CAMPAIGN_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_STATUS_ENABLED_DETAIL")]
        CAMPAIGNSTATUSENABLEDDETAIL = 1,

        /// <summary>
        /// Enum CAMPAIGNPAUSEDDETAIL for value: CAMPAIGN_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PAUSED_DETAIL")]
        CAMPAIGNPAUSEDDETAIL = 2,

        /// <summary>
        /// Enum CAMPAIGNARCHIVEDDETAIL for value: CAMPAIGN_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ARCHIVED_DETAIL")]
        CAMPAIGNARCHIVEDDETAIL = 3,

        /// <summary>
        /// Enum PENDINGREVIEWDETAIL for value: PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW_DETAIL")]
        PENDINGREVIEWDETAIL = 4,

        /// <summary>
        /// Enum REJECTEDDETAIL for value: REJECTED_DETAIL
        /// </summary>
        [EnumMember(Value = "REJECTED_DETAIL")]
        REJECTEDDETAIL = 5,

        /// <summary>
        /// Enum PENDINGSTARTDATEDETAIL for value: PENDING_START_DATE_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_START_DATE_DETAIL")]
        PENDINGSTARTDATEDETAIL = 6,

        /// <summary>
        /// Enum ENDEDDETAIL for value: ENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ENDED_DETAIL")]
        ENDEDDETAIL = 7,

        /// <summary>
        /// Enum CAMPAIGNOUTOFBUDGETDETAIL for value: CAMPAIGN_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_OUT_OF_BUDGET_DETAIL")]
        CAMPAIGNOUTOFBUDGETDETAIL = 8,

        /// <summary>
        /// Enum CAMPAIGNINCOMPLETEDETAIL for value: CAMPAIGN_INCOMPLETE_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INCOMPLETE_DETAIL")]
        CAMPAIGNINCOMPLETEDETAIL = 9,

        /// <summary>
        /// Enum PORTFOLIOSTATUSENABLEDDETAIL for value: PORTFOLIO_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_STATUS_ENABLED_DETAIL")]
        PORTFOLIOSTATUSENABLEDDETAIL = 10,

        /// <summary>
        /// Enum PORTFOLIOPAUSEDDETAIL for value: PORTFOLIO_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_PAUSED_DETAIL")]
        PORTFOLIOPAUSEDDETAIL = 11,

        /// <summary>
        /// Enum PORTFOLIOARCHIVEDDETAIL for value: PORTFOLIO_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_ARCHIVED_DETAIL")]
        PORTFOLIOARCHIVEDDETAIL = 12,

        /// <summary>
        /// Enum PORTFOLIOOUTOFBUDGETDETAIL for value: PORTFOLIO_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_OUT_OF_BUDGET_DETAIL")]
        PORTFOLIOOUTOFBUDGETDETAIL = 13,

        /// <summary>
        /// Enum PORTFOLIOPENDINGSTARTDATEDETAIL for value: PORTFOLIO_PENDING_START_DATE_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_PENDING_START_DATE_DETAIL")]
        PORTFOLIOPENDINGSTARTDATEDETAIL = 14,

        /// <summary>
        /// Enum PORTFOLIOENDEDDETAIL for value: PORTFOLIO_ENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "PORTFOLIO_ENDED_DETAIL")]
        PORTFOLIOENDEDDETAIL = 15,

        /// <summary>
        /// Enum ADVERTISERPOLICINGSUSPENDEDDETAIL for value: ADVERTISER_POLICING_SUSPENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_SUSPENDED_DETAIL")]
        ADVERTISERPOLICINGSUSPENDEDDETAIL = 16,

        /// <summary>
        /// Enum ADVERTISERPOLICINGPENDINGREVIEWDETAIL for value: ADVERTISER_POLICING_PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_PENDING_REVIEW_DETAIL")]
        ADVERTISERPOLICINGPENDINGREVIEWDETAIL = 17,

        /// <summary>
        /// Enum ADVERTISERARCHIVEDDETAIL for value: ADVERTISER_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_ARCHIVED_DETAIL")]
        ADVERTISERARCHIVEDDETAIL = 18,

        /// <summary>
        /// Enum ADVERTISERPAUSEDDETAIL for value: ADVERTISER_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAUSED_DETAIL")]
        ADVERTISERPAUSEDDETAIL = 19,

        /// <summary>
        /// Enum ADVERTISEROUTOFBUDGETDETAIL for value: ADVERTISER_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_OUT_OF_BUDGET_DETAIL")]
        ADVERTISEROUTOFBUDGETDETAIL = 20,

        /// <summary>
        /// Enum ADVERTISERPAYMENTFAILUREDETAIL for value: ADVERTISER_PAYMENT_FAILURE_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAYMENT_FAILURE_DETAIL")]
        ADVERTISERPAYMENTFAILUREDETAIL = 21,

        /// <summary>
        /// Enum ACCOUNTOUTOFBUDGETDETAIL for value: ACCOUNT_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "ACCOUNT_OUT_OF_BUDGET_DETAIL")]
        ACCOUNTOUTOFBUDGETDETAIL = 22,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 23

    }

}