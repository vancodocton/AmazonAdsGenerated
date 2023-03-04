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
    /// The type of targeting expression. You can specify values for the following predicates: | Predicate | Description | | - -- | - -- | | &#x60;QUERY_BROAD_REL_MATCHES&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Loose match&#x60; target type in the UI, this will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;QUERY_HIGH_REL_MATCHES&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Close match&#x60; target type in the UI, this will show your ad to shoppers who use search terms closely related to your products.| | &#x60;ASIN_ACCESSORY_RELATED&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Complements&#x60; target type in the UI, this will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;ASIN_SUBSTITUTE_RELATED&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Substitutes&#x60; target type in the UI, this will show your ad to shoppers who use detail pages of products similar to yours.| | &#x60;ASIN_CATEGORY_SAME_AS&#x60; | Negatively Target the same category as the category expressed. | | &#x60;ASIN_BRAND_SAME_AS&#x60; | Target the brand that is the same as the brand expressed. | | &#x60;ASIN_PRICE_LESS_THAN&#x60; | Target a price that is less than the price expressed. | | &#x60;ASIN_PRICE_BETWEEN&#x60; | Target a price that is between the prices expressed. | | &#x60;ASIN_PRICE_GREATER_THAN&#x60; | Target a price that is greater than the price expressed. | | &#x60;ASIN_REVIEW_RATING_LESS_THAN&#x60; | Target a review rating less than the review rating that is expressed. | | &#x60;ASIN_REVIEW_RATING_BETWEEN&#x60; | Target a review rating that is between the review ratings expressed. | | &#x60;ASIN_REVIEW_RATING_GREATER_THAN&#x60; | Target a review rating that is greater than the review rating expressed. | | &#x60;ASIN_SAME_AS&#x60; | Target an ASIN that is the same as the ASIN expressed. | | &#x60;ASIN_IS_PRIME_SHIPPING_ELIGIBLE&#x60; | Target products that are Prime Shipping Eligible. This refinement can be applied at a category or brand level only. | | &#x60;ASIN_AGE_RANGE_SAME_AS&#x60; | Target an age range that is in the expressed range. This refinement can be applied for toys and games categories only. | | &#x60;ASIN_GENRE_SAME_AS&#x60; | Target products related to the expressed genre. This refinement can be applied for Books and eBooks categories only.   | | &#x60;ASIN_EXPANDED_FROM&#x60; | Target products similar in performance to the ASIN expressed.   | | &#x60;OTHER&#x60; | Other Type.   |
    /// </summary>
    /// <value>The type of targeting expression. You can specify values for the following predicates: | Predicate | Description | | - -- | - -- | | &#x60;QUERY_BROAD_REL_MATCHES&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Loose match&#x60; target type in the UI, this will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;QUERY_HIGH_REL_MATCHES&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Close match&#x60; target type in the UI, this will show your ad to shoppers who use search terms closely related to your products.| | &#x60;ASIN_ACCESSORY_RELATED&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Complements&#x60; target type in the UI, this will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;ASIN_SUBSTITUTE_RELATED&#x60; | Auto Targeting - cannot be manually created - corresponds to the &#x60;Substitutes&#x60; target type in the UI, this will show your ad to shoppers who use detail pages of products similar to yours.| | &#x60;ASIN_CATEGORY_SAME_AS&#x60; | Negatively Target the same category as the category expressed. | | &#x60;ASIN_BRAND_SAME_AS&#x60; | Target the brand that is the same as the brand expressed. | | &#x60;ASIN_PRICE_LESS_THAN&#x60; | Target a price that is less than the price expressed. | | &#x60;ASIN_PRICE_BETWEEN&#x60; | Target a price that is between the prices expressed. | | &#x60;ASIN_PRICE_GREATER_THAN&#x60; | Target a price that is greater than the price expressed. | | &#x60;ASIN_REVIEW_RATING_LESS_THAN&#x60; | Target a review rating less than the review rating that is expressed. | | &#x60;ASIN_REVIEW_RATING_BETWEEN&#x60; | Target a review rating that is between the review ratings expressed. | | &#x60;ASIN_REVIEW_RATING_GREATER_THAN&#x60; | Target a review rating that is greater than the review rating expressed. | | &#x60;ASIN_SAME_AS&#x60; | Target an ASIN that is the same as the ASIN expressed. | | &#x60;ASIN_IS_PRIME_SHIPPING_ELIGIBLE&#x60; | Target products that are Prime Shipping Eligible. This refinement can be applied at a category or brand level only. | | &#x60;ASIN_AGE_RANGE_SAME_AS&#x60; | Target an age range that is in the expressed range. This refinement can be applied for toys and games categories only. | | &#x60;ASIN_GENRE_SAME_AS&#x60; | Target products related to the expressed genre. This refinement can be applied for Books and eBooks categories only.   | | &#x60;ASIN_EXPANDED_FROM&#x60; | Target products similar in performance to the ASIN expressed.   | | &#x60;OTHER&#x60; | Other Type.   |</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SponsoredProductsTargetingExpressionPredicateType
    {
        /// <summary>
        /// Enum ASINCATEGORYSAMEAS for value: ASIN_CATEGORY_SAME_AS
        /// </summary>
        [EnumMember(Value = "ASIN_CATEGORY_SAME_AS")]
        ASINCATEGORYSAMEAS = 1,

        /// <summary>
        /// Enum ASINBRANDSAMEAS for value: ASIN_BRAND_SAME_AS
        /// </summary>
        [EnumMember(Value = "ASIN_BRAND_SAME_AS")]
        ASINBRANDSAMEAS = 2,

        /// <summary>
        /// Enum ASINPRICELESSTHAN for value: ASIN_PRICE_LESS_THAN
        /// </summary>
        [EnumMember(Value = "ASIN_PRICE_LESS_THAN")]
        ASINPRICELESSTHAN = 3,

        /// <summary>
        /// Enum ASINPRICEBETWEEN for value: ASIN_PRICE_BETWEEN
        /// </summary>
        [EnumMember(Value = "ASIN_PRICE_BETWEEN")]
        ASINPRICEBETWEEN = 4,

        /// <summary>
        /// Enum ASINPRICEGREATERTHAN for value: ASIN_PRICE_GREATER_THAN
        /// </summary>
        [EnumMember(Value = "ASIN_PRICE_GREATER_THAN")]
        ASINPRICEGREATERTHAN = 5,

        /// <summary>
        /// Enum ASINREVIEWRATINGLESSTHAN for value: ASIN_REVIEW_RATING_LESS_THAN
        /// </summary>
        [EnumMember(Value = "ASIN_REVIEW_RATING_LESS_THAN")]
        ASINREVIEWRATINGLESSTHAN = 6,

        /// <summary>
        /// Enum ASINREVIEWRATINGBETWEEN for value: ASIN_REVIEW_RATING_BETWEEN
        /// </summary>
        [EnumMember(Value = "ASIN_REVIEW_RATING_BETWEEN")]
        ASINREVIEWRATINGBETWEEN = 7,

        /// <summary>
        /// Enum ASINREVIEWRATINGGREATERTHAN for value: ASIN_REVIEW_RATING_GREATER_THAN
        /// </summary>
        [EnumMember(Value = "ASIN_REVIEW_RATING_GREATER_THAN")]
        ASINREVIEWRATINGGREATERTHAN = 8,

        /// <summary>
        /// Enum ASINSAMEAS for value: ASIN_SAME_AS
        /// </summary>
        [EnumMember(Value = "ASIN_SAME_AS")]
        ASINSAMEAS = 9,

        /// <summary>
        /// Enum QUERYBROADRELMATCHES for value: QUERY_BROAD_REL_MATCHES
        /// </summary>
        [EnumMember(Value = "QUERY_BROAD_REL_MATCHES")]
        QUERYBROADRELMATCHES = 10,

        /// <summary>
        /// Enum QUERYHIGHRELMATCHES for value: QUERY_HIGH_REL_MATCHES
        /// </summary>
        [EnumMember(Value = "QUERY_HIGH_REL_MATCHES")]
        QUERYHIGHRELMATCHES = 11,

        /// <summary>
        /// Enum ASINSUBSTITUTERELATED for value: ASIN_SUBSTITUTE_RELATED
        /// </summary>
        [EnumMember(Value = "ASIN_SUBSTITUTE_RELATED")]
        ASINSUBSTITUTERELATED = 12,

        /// <summary>
        /// Enum ASINACCESSORYRELATED for value: ASIN_ACCESSORY_RELATED
        /// </summary>
        [EnumMember(Value = "ASIN_ACCESSORY_RELATED")]
        ASINACCESSORYRELATED = 13,

        /// <summary>
        /// Enum ASINAGERANGESAMEAS for value: ASIN_AGE_RANGE_SAME_AS
        /// </summary>
        [EnumMember(Value = "ASIN_AGE_RANGE_SAME_AS")]
        ASINAGERANGESAMEAS = 14,

        /// <summary>
        /// Enum ASINGENRESAMEAS for value: ASIN_GENRE_SAME_AS
        /// </summary>
        [EnumMember(Value = "ASIN_GENRE_SAME_AS")]
        ASINGENRESAMEAS = 15,

        /// <summary>
        /// Enum ASINISPRIMESHIPPINGELIGIBLE for value: ASIN_IS_PRIME_SHIPPING_ELIGIBLE
        /// </summary>
        [EnumMember(Value = "ASIN_IS_PRIME_SHIPPING_ELIGIBLE")]
        ASINISPRIMESHIPPINGELIGIBLE = 16,

        /// <summary>
        /// Enum ASINEXPANDEDFROM for value: ASIN_EXPANDED_FROM
        /// </summary>
        [EnumMember(Value = "ASIN_EXPANDED_FROM")]
        ASINEXPANDEDFROM = 17,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 18

    }

}
