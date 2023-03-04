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
    /// Defines SponsoredProductsUnsupportedMediaTypeErrorCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsUnsupportedMediaTypeErrorCode
    {
        /// <summary>
        /// Enum UNSUPPORTEDMEDIATYPE for value: UNSUPPORTED_MEDIA_TYPE
        /// </summary>
        [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
        UNSUPPORTEDMEDIATYPE = 1

    }

}
