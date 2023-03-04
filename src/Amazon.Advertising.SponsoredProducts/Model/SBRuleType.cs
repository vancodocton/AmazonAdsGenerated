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
    /// The type of budget rule. SCHEDULE: A budget rule based on a start and end date. PERFORMANCE: A budget rule based on advertising performance criteria.
    /// </summary>
    /// <value>The type of budget rule. SCHEDULE: A budget rule based on a start and end date. PERFORMANCE: A budget rule based on advertising performance criteria.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SBRuleType
    {
        /// <summary>
        /// Enum SCHEDULE for value: SCHEDULE
        /// </summary>
        [EnumMember(Value = "SCHEDULE")]
        SCHEDULE = 1,

        /// <summary>
        /// Enum PERFORMANCE for value: PERFORMANCE
        /// </summary>
        [EnumMember(Value = "PERFORMANCE")]
        PERFORMANCE = 2

    }

}
