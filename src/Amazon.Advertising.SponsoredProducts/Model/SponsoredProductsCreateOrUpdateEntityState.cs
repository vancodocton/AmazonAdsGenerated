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
    /// Entity state for create or update operation
    /// </summary>
    /// <value>Entity state for create or update operation</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsCreateOrUpdateEntityState
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
        PAUSED = 2

    }

}
