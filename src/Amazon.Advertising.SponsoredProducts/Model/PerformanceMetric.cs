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
    /// The advertising performance metric.
    /// </summary>
    /// <value>The advertising performance metric.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PerformanceMetric
    {
        /// <summary>
        /// Enum ACOS for value: ACOS
        /// </summary>
        [EnumMember(Value = "ACOS")]
        ACOS = 1,

        /// <summary>
        /// Enum CTR for value: CTR
        /// </summary>
        [EnumMember(Value = "CTR")]
        CTR = 2,

        /// <summary>
        /// Enum CVR for value: CVR
        /// </summary>
        [EnumMember(Value = "CVR")]
        CVR = 3,

        /// <summary>
        /// Enum ROAS for value: ROAS
        /// </summary>
        [EnumMember(Value = "ROAS")]
        ROAS = 4

    }

}
