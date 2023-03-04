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
    /// Defines SponsoredProductsMarketplace
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsMarketplace
    {
        /// <summary>
        /// Enum US for value: US
        /// </summary>
        [EnumMember(Value = "US")]
        US = 1,

        /// <summary>
        /// Enum CA for value: CA
        /// </summary>
        [EnumMember(Value = "CA")]
        CA = 2,

        /// <summary>
        /// Enum MX for value: MX
        /// </summary>
        [EnumMember(Value = "MX")]
        MX = 3,

        /// <summary>
        /// Enum BR for value: BR
        /// </summary>
        [EnumMember(Value = "BR")]
        BR = 4,

        /// <summary>
        /// Enum UK for value: UK
        /// </summary>
        [EnumMember(Value = "UK")]
        UK = 5,

        /// <summary>
        /// Enum DE for value: DE
        /// </summary>
        [EnumMember(Value = "DE")]
        DE = 6,

        /// <summary>
        /// Enum FR for value: FR
        /// </summary>
        [EnumMember(Value = "FR")]
        FR = 7,

        /// <summary>
        /// Enum ES for value: ES
        /// </summary>
        [EnumMember(Value = "ES")]
        ES = 8,

        /// <summary>
        /// Enum IT for value: IT
        /// </summary>
        [EnumMember(Value = "IT")]
        IT = 9,

        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 10,

        /// <summary>
        /// Enum AE for value: AE
        /// </summary>
        [EnumMember(Value = "AE")]
        AE = 11,

        /// <summary>
        /// Enum SA for value: SA
        /// </summary>
        [EnumMember(Value = "SA")]
        SA = 12,

        /// <summary>
        /// Enum NL for value: NL
        /// </summary>
        [EnumMember(Value = "NL")]
        NL = 13,

        /// <summary>
        /// Enum PL for value: PL
        /// </summary>
        [EnumMember(Value = "PL")]
        PL = 14,

        /// <summary>
        /// Enum SE for value: SE
        /// </summary>
        [EnumMember(Value = "SE")]
        SE = 15,

        /// <summary>
        /// Enum TR for value: TR
        /// </summary>
        [EnumMember(Value = "TR")]
        TR = 16,

        /// <summary>
        /// Enum EG for value: EG
        /// </summary>
        [EnumMember(Value = "EG")]
        EG = 17,

        /// <summary>
        /// Enum JP for value: JP
        /// </summary>
        [EnumMember(Value = "JP")]
        JP = 18,

        /// <summary>
        /// Enum AU for value: AU
        /// </summary>
        [EnumMember(Value = "AU")]
        AU = 19,

        /// <summary>
        /// Enum SG for value: SG
        /// </summary>
        [EnumMember(Value = "SG")]
        SG = 20

    }

}
