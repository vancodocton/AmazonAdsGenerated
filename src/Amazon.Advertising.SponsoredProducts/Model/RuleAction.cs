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
    /// The action taken when the campaign optimization rule is enabled. Defaults to adopt
    /// </summary>
    /// <value>The action taken when the campaign optimization rule is enabled. Defaults to adopt</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleAction
    {
        /// <summary>
        /// Enum ADOPT for value: ADOPT
        /// </summary>
        [EnumMember(Value = "ADOPT")]
        ADOPT = 1

    }

}
