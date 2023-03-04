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
    /// The current resource state.
    /// </summary>
    /// <value>The current resource state.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsEntityState
    {
        /// <summary>
        /// Enum ENABLED for value: ENABLED
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED = 1,

        /// <summary>
        /// Enum PAUSED for value: PAUSED
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        PAUSED = 2,

        /// <summary>
        /// Enum ARCHIVED for value: ARCHIVED
        /// </summary>
        [EnumMember(Value = "ARCHIVED")]
        ARCHIVED = 3,

        /// <summary>
        /// Enum ENABLING for value: ENABLING
        /// </summary>
        [EnumMember(Value = "ENABLING")]
        ENABLING = 4,

        /// <summary>
        /// Enum USERDELETED for value: USER_DELETED
        /// </summary>
        [EnumMember(Value = "USER_DELETED")]
        USERDELETED = 5,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 6

    }

}
