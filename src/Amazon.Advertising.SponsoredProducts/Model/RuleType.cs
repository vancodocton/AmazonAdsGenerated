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
    /// The type of the campaign optimization rule. Only Support BID as of now
    /// </summary>
    /// <value>The type of the campaign optimization rule. Only Support BID as of now</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleType
    {
        /// <summary>
        /// Enum BID for value: BID
        /// </summary>
        [EnumMember(Value = "BID")]
        BID = 1,

        /// <summary>
        /// Enum KEYWORD for value: KEYWORD
        /// </summary>
        [EnumMember(Value = "KEYWORD")]
        KEYWORD = 2,

        /// <summary>
        /// Enum PRODUCT for value: PRODUCT
        /// </summary>
        [EnumMember(Value = "PRODUCT")]
        PRODUCT = 3

    }

}
