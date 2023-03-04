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
    /// Defines SponsoredProductsAsinOwnershipErrorReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsAsinOwnershipErrorReason
    {
        /// <summary>
        /// Enum ASINNOTOWNEDBYAUTHOR for value: ASIN_NOT_OWNED_BY_AUTHOR
        /// </summary>
        [EnumMember(Value = "ASIN_NOT_OWNED_BY_AUTHOR")]
        ASINNOTOWNEDBYAUTHOR = 1

    }

}
