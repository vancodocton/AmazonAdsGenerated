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
    /// The bid recommendation theme.
    /// </summary>
    /// <value>The bid recommendation theme.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Theme
    {
        /// <summary>
        /// Enum CONVERSIONOPPORTUNITIES for value: CONVERSION_OPPORTUNITIES
        /// </summary>
        [EnumMember(Value = "CONVERSION_OPPORTUNITIES")]
        CONVERSIONOPPORTUNITIES = 1,

        /// <summary>
        /// Enum PRIMEDAY for value: PRIME_DAY
        /// </summary>
        [EnumMember(Value = "PRIME_DAY")]
        PRIMEDAY = 2,

        /// <summary>
        /// Enum FALLPRIMEDEALEVENT for value: FALL_PRIME_DEAL_EVENT
        /// </summary>
        [EnumMember(Value = "FALL_PRIME_DEAL_EVENT")]
        FALLPRIMEDEALEVENT = 3,

        /// <summary>
        /// Enum VALENTINESDAY for value: VALENTINES_DAY
        /// </summary>
        [EnumMember(Value = "VALENTINES_DAY")]
        VALENTINESDAY = 4,

        /// <summary>
        /// Enum BACKTOSCHOOL for value: BACK_TO_SCHOOL
        /// </summary>
        [EnumMember(Value = "BACK_TO_SCHOOL")]
        BACKTOSCHOOL = 5,

        /// <summary>
        /// Enum BFCMHOLIDAY for value: BFCM_HOLIDAY
        /// </summary>
        [EnumMember(Value = "BFCM_HOLIDAY")]
        BFCMHOLIDAY = 6,

        /// <summary>
        /// Enum TIMESALEFESTIVAL for value: TIME_SALE_FESTIVAL
        /// </summary>
        [EnumMember(Value = "TIME_SALE_FESTIVAL")]
        TIMESALEFESTIVAL = 7,

        /// <summary>
        /// Enum FASHIONTIMESALEFESTIVAL for value: FASHION_TIME_SALE_FESTIVAL
        /// </summary>
        [EnumMember(Value = "FASHION_TIME_SALE_FESTIVAL")]
        FASHIONTIMESALEFESTIVAL = 8,

        /// <summary>
        /// Enum GREATREPUBLICDAYSALE for value: GREAT_REPUBLIC_DAY_SALE
        /// </summary>
        [EnumMember(Value = "GREAT_REPUBLIC_DAY_SALE")]
        GREATREPUBLICDAYSALE = 9,

        /// <summary>
        /// Enum GREATINDIANFESTIVAL for value: GREAT_INDIAN_FESTIVAL
        /// </summary>
        [EnumMember(Value = "GREAT_INDIAN_FESTIVAL")]
        GREATINDIANFESTIVAL = 10,

        /// <summary>
        /// Enum SPRINGSALEEVENT for value: SPRING_SALE_EVENT
        /// </summary>
        [EnumMember(Value = "SPRING_SALE_EVENT")]
        SPRINGSALEEVENT = 11

    }

}
