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
    /// The bidding strategy selected for the campaign. Use &#x60;LEGACY_FOR_SALES&#x60; to lower your bid in real time when your ad may be less likely to convert to a sale. Use &#x60;AUTO_FOR_SALES&#x60; to increase your bid in real time when your ad may be more likely to convert to a sale or lower your bid when less likely to convert to a sale. Use &#x60;MANUAL&#x60; to use your exact bid along with any manual adjustments.
    /// </summary>
    /// <value>The bidding strategy selected for the campaign. Use &#x60;LEGACY_FOR_SALES&#x60; to lower your bid in real time when your ad may be less likely to convert to a sale. Use &#x60;AUTO_FOR_SALES&#x60; to increase your bid in real time when your ad may be more likely to convert to a sale or lower your bid when less likely to convert to a sale. Use &#x60;MANUAL&#x60; to use your exact bid along with any manual adjustments.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BiddingStrategy
    {
        /// <summary>
        /// Enum LEGACYFORSALES for value: LEGACY_FOR_SALES
        /// </summary>
        [EnumMember(Value = "LEGACY_FOR_SALES")]
        LEGACYFORSALES = 1,

        /// <summary>
        /// Enum AUTOFORSALES for value: AUTO_FOR_SALES
        /// </summary>
        [EnumMember(Value = "AUTO_FOR_SALES")]
        AUTOFORSALES = 2,

        /// <summary>
        /// Enum MANUAL for value: MANUAL
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL = 3,

        /// <summary>
        /// Enum RULEBASED for value: RULE_BASED
        /// </summary>
        [EnumMember(Value = "RULE_BASED")]
        RULEBASED = 4

    }

}
