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
    /// RankedTargetWithThemedBids
    /// </summary>
    [DataContract(Name = "RankedTargetWithThemedBids")]
    public partial class RankedTargetWithThemedBids : IEquatable<RankedTargetWithThemedBids>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedTargetWithThemedBids" /> class.
        /// </summary>
        /// <param name="searchTermImpressionShare">The account-level ad-attributed impression share for the search-term/keyword. Provides percentage share of all ad impressions the advertiser has for the keyword in the last 30 days. This metric helps advertisers identify potential opportunities based on their share on relevant keywords. This information is only available for keywords the advertiser targeted with ad impressions..</param>
        /// <param name="translation">The translation of keyword if a locale is passed in.</param>
        /// <param name="bidInfo">A list of keyword bid info.</param>
        /// <param name="searchTermImpressionRank">The account-level ad-attributed impression rank for the search-term/keyword. Provides [1:N] place the advertiser ranks among all advertisers for the keyword by ad impressions in a marketplace in the last 30 days. It tells an advertiser how many advertisers had higher share of ad impressions. This information is only available for keywords the advertiser targeted with ad impressions..</param>
        /// <param name="keyword">The keyword value.</param>
        /// <param name="userSelectedKeyword">Flag that tells if keyword was selected by the user or was recommended by KRS.</param>
        /// <param name="recId">The recommended keyword target id.</param>
        public RankedTargetWithThemedBids(decimal searchTermImpressionShare = default(decimal), string translation = default(string), List<RankedTargetWithThemedBidsBidInfoInner> bidInfo = default(List<RankedTargetWithThemedBidsBidInfoInner>), decimal searchTermImpressionRank = default(decimal), string keyword = default(string), bool userSelectedKeyword = default(bool), string recId = default(string))
        {
            this.SearchTermImpressionShare = searchTermImpressionShare;
            this.Translation = translation;
            this.BidInfo = bidInfo;
            this.SearchTermImpressionRank = searchTermImpressionRank;
            this.Keyword = keyword;
            this.UserSelectedKeyword = userSelectedKeyword;
            this.RecId = recId;
        }

        /// <summary>
        /// The account-level ad-attributed impression share for the search-term/keyword. Provides percentage share of all ad impressions the advertiser has for the keyword in the last 30 days. This metric helps advertisers identify potential opportunities based on their share on relevant keywords. This information is only available for keywords the advertiser targeted with ad impressions.
        /// </summary>
        /// <value>The account-level ad-attributed impression share for the search-term/keyword. Provides percentage share of all ad impressions the advertiser has for the keyword in the last 30 days. This metric helps advertisers identify potential opportunities based on their share on relevant keywords. This information is only available for keywords the advertiser targeted with ad impressions.</value>
        [DataMember(Name = "searchTermImpressionShare", EmitDefaultValue = false)]
        public decimal SearchTermImpressionShare { get; set; }

        /// <summary>
        /// The translation of keyword if a locale is passed in
        /// </summary>
        /// <value>The translation of keyword if a locale is passed in</value>
        [DataMember(Name = "translation", EmitDefaultValue = false)]
        public string Translation { get; set; }

        /// <summary>
        /// A list of keyword bid info
        /// </summary>
        /// <value>A list of keyword bid info</value>
        [DataMember(Name = "bidInfo", EmitDefaultValue = false)]
        public List<RankedTargetWithThemedBidsBidInfoInner> BidInfo { get; set; }

        /// <summary>
        /// The account-level ad-attributed impression rank for the search-term/keyword. Provides [1:N] place the advertiser ranks among all advertisers for the keyword by ad impressions in a marketplace in the last 30 days. It tells an advertiser how many advertisers had higher share of ad impressions. This information is only available for keywords the advertiser targeted with ad impressions.
        /// </summary>
        /// <value>The account-level ad-attributed impression rank for the search-term/keyword. Provides [1:N] place the advertiser ranks among all advertisers for the keyword by ad impressions in a marketplace in the last 30 days. It tells an advertiser how many advertisers had higher share of ad impressions. This information is only available for keywords the advertiser targeted with ad impressions.</value>
        [DataMember(Name = "searchTermImpressionRank", EmitDefaultValue = false)]
        public decimal SearchTermImpressionRank { get; set; }

        /// <summary>
        /// The keyword value
        /// </summary>
        /// <value>The keyword value</value>
        [DataMember(Name = "keyword", EmitDefaultValue = false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Flag that tells if keyword was selected by the user or was recommended by KRS
        /// </summary>
        /// <value>Flag that tells if keyword was selected by the user or was recommended by KRS</value>
        [DataMember(Name = "userSelectedKeyword", EmitDefaultValue = true)]
        public bool UserSelectedKeyword { get; set; }

        /// <summary>
        /// The recommended keyword target id
        /// </summary>
        /// <value>The recommended keyword target id</value>
        [DataMember(Name = "recId", EmitDefaultValue = false)]
        public string RecId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RankedTargetWithThemedBids {\n");
            sb.Append("  SearchTermImpressionShare: ").Append(SearchTermImpressionShare).Append("\n");
            sb.Append("  Translation: ").Append(Translation).Append("\n");
            sb.Append("  BidInfo: ").Append(BidInfo).Append("\n");
            sb.Append("  SearchTermImpressionRank: ").Append(SearchTermImpressionRank).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  UserSelectedKeyword: ").Append(UserSelectedKeyword).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RankedTargetWithThemedBids);
        }

        /// <summary>
        /// Returns true if RankedTargetWithThemedBids instances are equal
        /// </summary>
        /// <param name="input">Instance of RankedTargetWithThemedBids to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankedTargetWithThemedBids input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SearchTermImpressionShare == input.SearchTermImpressionShare ||
                    this.SearchTermImpressionShare.Equals(input.SearchTermImpressionShare)
                ) && 
                (
                    this.Translation == input.Translation ||
                    (this.Translation != null &&
                    this.Translation.Equals(input.Translation))
                ) && 
                (
                    this.BidInfo == input.BidInfo ||
                    this.BidInfo != null &&
                    input.BidInfo != null &&
                    this.BidInfo.SequenceEqual(input.BidInfo)
                ) && 
                (
                    this.SearchTermImpressionRank == input.SearchTermImpressionRank ||
                    this.SearchTermImpressionRank.Equals(input.SearchTermImpressionRank)
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.UserSelectedKeyword == input.UserSelectedKeyword ||
                    this.UserSelectedKeyword.Equals(input.UserSelectedKeyword)
                ) && 
                (
                    this.RecId == input.RecId ||
                    (this.RecId != null &&
                    this.RecId.Equals(input.RecId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.SearchTermImpressionShare.GetHashCode();
                if (this.Translation != null)
                {
                    hashCode = (hashCode * 59) + this.Translation.GetHashCode();
                }
                if (this.BidInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BidInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SearchTermImpressionRank.GetHashCode();
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserSelectedKeyword.GetHashCode();
                if (this.RecId != null)
                {
                    hashCode = (hashCode * 59) + this.RecId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
