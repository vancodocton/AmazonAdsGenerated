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
    /// Defines SponsoredProductsGlobalAdGroupMarketplaceServingReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsGlobalAdGroupMarketplaceServingReason
    {
        /// <summary>
        /// Enum ADGROUPSTATUSENABLEDDETAIL for value: AD_GROUP_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_STATUS_ENABLED_DETAIL")]
        ADGROUPSTATUSENABLEDDETAIL = 1,

        /// <summary>
        /// Enum ADGROUPPAUSEDDETAIL for value: AD_GROUP_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_PAUSED_DETAIL")]
        ADGROUPPAUSEDDETAIL = 2,

        /// <summary>
        /// Enum ADGROUPARCHIVEDDETAIL for value: AD_GROUP_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_ARCHIVED_DETAIL")]
        ADGROUPARCHIVEDDETAIL = 3,

        /// <summary>
        /// Enum ADGROUPINCOMPLETEDETAIL for value: AD_GROUP_INCOMPLETE_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_INCOMPLETE_DETAIL")]
        ADGROUPINCOMPLETEDETAIL = 4,

        /// <summary>
        /// Enum ADGROUPPOLICINGPENDINGREVIEWDETAIL for value: AD_GROUP_POLICING_PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_PENDING_REVIEW_DETAIL")]
        ADGROUPPOLICINGPENDINGREVIEWDETAIL = 5,

        /// <summary>
        /// Enum ADGROUPPOLICINGCREATIVEREJECTEDDETAIL for value: AD_GROUP_POLICING_CREATIVE_REJECTED_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_POLICING_CREATIVE_REJECTED_DETAIL")]
        ADGROUPPOLICINGCREATIVEREJECTEDDETAIL = 6,

        /// <summary>
        /// Enum ADGROUPLOWBIDDETAIL for value: AD_GROUP_LOW_BID_DETAIL
        /// </summary>
        [EnumMember(Value = "AD_GROUP_LOW_BID_DETAIL")]
        ADGROUPLOWBIDDETAIL = 7,

        /// <summary>
        /// Enum CAMPAIGNSTATUSENABLEDDETAIL for value: CAMPAIGN_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_STATUS_ENABLED_DETAIL")]
        CAMPAIGNSTATUSENABLEDDETAIL = 8,

        /// <summary>
        /// Enum CAMPAIGNPAUSEDDETAIL for value: CAMPAIGN_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_PAUSED_DETAIL")]
        CAMPAIGNPAUSEDDETAIL = 9,

        /// <summary>
        /// Enum CAMPAIGNARCHIVEDDETAIL for value: CAMPAIGN_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_ARCHIVED_DETAIL")]
        CAMPAIGNARCHIVEDDETAIL = 10,

        /// <summary>
        /// Enum PENDINGREVIEWDETAIL for value: PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW_DETAIL")]
        PENDINGREVIEWDETAIL = 11,

        /// <summary>
        /// Enum REJECTEDDETAIL for value: REJECTED_DETAIL
        /// </summary>
        [EnumMember(Value = "REJECTED_DETAIL")]
        REJECTEDDETAIL = 12,

        /// <summary>
        /// Enum PENDINGSTARTDATEDETAIL for value: PENDING_START_DATE_DETAIL
        /// </summary>
        [EnumMember(Value = "PENDING_START_DATE_DETAIL")]
        PENDINGSTARTDATEDETAIL = 13,

        /// <summary>
        /// Enum ENDEDDETAIL for value: ENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ENDED_DETAIL")]
        ENDEDDETAIL = 14,

        /// <summary>
        /// Enum CAMPAIGNOUTOFBUDGETDETAIL for value: CAMPAIGN_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_OUT_OF_BUDGET_DETAIL")]
        CAMPAIGNOUTOFBUDGETDETAIL = 15,

        /// <summary>
        /// Enum CAMPAIGNINCOMPLETEDETAIL for value: CAMPAIGN_INCOMPLETE_DETAIL
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INCOMPLETE_DETAIL")]
        CAMPAIGNINCOMPLETEDETAIL = 16,

        /// <summary>
        /// Enum ADVERTISERPOLICINGSUSPENDEDDETAIL for value: ADVERTISER_POLICING_SUSPENDED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_SUSPENDED_DETAIL")]
        ADVERTISERPOLICINGSUSPENDEDDETAIL = 17,

        /// <summary>
        /// Enum ADVERTISERPOLICINGPENDINGREVIEWDETAIL for value: ADVERTISER_POLICING_PENDING_REVIEW_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_POLICING_PENDING_REVIEW_DETAIL")]
        ADVERTISERPOLICINGPENDINGREVIEWDETAIL = 18,

        /// <summary>
        /// Enum ADVERTISERARCHIVEDDETAIL for value: ADVERTISER_ARCHIVED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_ARCHIVED_DETAIL")]
        ADVERTISERARCHIVEDDETAIL = 19,

        /// <summary>
        /// Enum ADVERTISERPAUSEDDETAIL for value: ADVERTISER_PAUSED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAUSED_DETAIL")]
        ADVERTISERPAUSEDDETAIL = 20,

        /// <summary>
        /// Enum ADVERTISEROUTOFBUDGETDETAIL for value: ADVERTISER_OUT_OF_BUDGET_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_OUT_OF_BUDGET_DETAIL")]
        ADVERTISEROUTOFBUDGETDETAIL = 21,

        /// <summary>
        /// Enum ADVERTISERPAYMENTFAILUREDETAIL for value: ADVERTISER_PAYMENT_FAILURE_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_PAYMENT_FAILURE_DETAIL")]
        ADVERTISERPAYMENTFAILUREDETAIL = 22,

        /// <summary>
        /// Enum ADVERTISERSTATUSENABLEDDETAIL for value: ADVERTISER_STATUS_ENABLED_DETAIL
        /// </summary>
        [EnumMember(Value = "ADVERTISER_STATUS_ENABLED_DETAIL")]
        ADVERTISERSTATUSENABLEDDETAIL = 23

    }

}
