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
    /// Defines SponsoredProductsValueLimitErrorReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsValueLimitErrorReason
    {
        /// <summary>
        /// Enum TOOLOW for value: TOO_LOW
        /// </summary>
        [EnumMember(Value = "TOO_LOW")]
        TOOLOW = 1,

        /// <summary>
        /// Enum TOOHIGH for value: TOO_HIGH
        /// </summary>
        [EnumMember(Value = "TOO_HIGH")]
        TOOHIGH = 2,

        /// <summary>
        /// Enum INVALIDENUMVALUE for value: INVALID_ENUM_VALUE
        /// </summary>
        [EnumMember(Value = "INVALID_ENUM_VALUE")]
        INVALIDENUMVALUE = 3,

        /// <summary>
        /// Enum NOTINLIST for value: NOT_IN_LIST
        /// </summary>
        [EnumMember(Value = "NOT_IN_LIST")]
        NOTINLIST = 4

    }

}
