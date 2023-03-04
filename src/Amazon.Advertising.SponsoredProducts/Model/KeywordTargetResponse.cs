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
    /// KeywordTargetResponse
    /// </summary>
    [DataContract(Name = "KeywordTargetResponse")]
    public partial class KeywordTargetResponse : IEquatable<KeywordTargetResponse>, IValidatableObject
    {
        /// <summary>
        /// Keyword match type. The default value will be BROAD.
        /// </summary>
        /// <value>Keyword match type. The default value will be BROAD.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchTypeEnum
        {
            /// <summary>
            /// Enum BROAD for value: BROAD
            /// </summary>
            [EnumMember(Value = "BROAD")]
            BROAD = 1,

            /// <summary>
            /// Enum EXACT for value: EXACT
            /// </summary>
            [EnumMember(Value = "EXACT")]
            EXACT = 2,

            /// <summary>
            /// Enum PHRASE for value: PHRASE
            /// </summary>
            [EnumMember(Value = "PHRASE")]
            PHRASE = 3

        }


        /// <summary>
        /// Keyword match type. The default value will be BROAD.
        /// </summary>
        /// <value>Keyword match type. The default value will be BROAD.</value>
        [DataMember(Name = "matchType", EmitDefaultValue = false)]
        public MatchTypeEnum? MatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordTargetResponse" /> class.
        /// </summary>
        /// <param name="suggestedBid">suggestedBid.</param>
        /// <param name="translation">The translation of keyword if a locale is passed in.</param>
        /// <param name="rank">The keyword target rank.</param>
        /// <param name="matchType">Keyword match type. The default value will be BROAD..</param>
        /// <param name="keyword">The keyword value.</param>
        /// <param name="bid">The bid value for the keyword. The default value will be the suggested bid..</param>
        /// <param name="userSelectedKeyword">Flag that tells if keyword was selected by the user or was recommended by KRS.</param>
        public KeywordTargetResponse(BidSuggestion suggestedBid = default(BidSuggestion), string translation = default(string), decimal rank = default(decimal), MatchTypeEnum? matchType = default(MatchTypeEnum?), string keyword = default(string), double bid = default(double), bool userSelectedKeyword = default(bool))
        {
            this.SuggestedBid = suggestedBid;
            this.Translation = translation;
            this.Rank = rank;
            this.MatchType = matchType;
            this.Keyword = keyword;
            this.Bid = bid;
            this.UserSelectedKeyword = userSelectedKeyword;
        }

        /// <summary>
        /// Gets or Sets SuggestedBid
        /// </summary>
        [DataMember(Name = "suggestedBid", EmitDefaultValue = false)]
        public BidSuggestion SuggestedBid { get; set; }

        /// <summary>
        /// The translation of keyword if a locale is passed in
        /// </summary>
        /// <value>The translation of keyword if a locale is passed in</value>
        [DataMember(Name = "translation", EmitDefaultValue = false)]
        public string Translation { get; set; }

        /// <summary>
        /// The keyword target rank
        /// </summary>
        /// <value>The keyword target rank</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public decimal Rank { get; set; }

        /// <summary>
        /// The keyword value
        /// </summary>
        /// <value>The keyword value</value>
        [DataMember(Name = "keyword", EmitDefaultValue = false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The bid value for the keyword. The default value will be the suggested bid.
        /// </summary>
        /// <value>The bid value for the keyword. The default value will be the suggested bid.</value>
        [DataMember(Name = "bid", EmitDefaultValue = false)]
        public double Bid { get; set; }

        /// <summary>
        /// Flag that tells if keyword was selected by the user or was recommended by KRS
        /// </summary>
        /// <value>Flag that tells if keyword was selected by the user or was recommended by KRS</value>
        [DataMember(Name = "userSelectedKeyword", EmitDefaultValue = true)]
        public bool UserSelectedKeyword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KeywordTargetResponse {\n");
            sb.Append("  SuggestedBid: ").Append(SuggestedBid).Append("\n");
            sb.Append("  Translation: ").Append(Translation).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  UserSelectedKeyword: ").Append(UserSelectedKeyword).Append("\n");
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
            return this.Equals(input as KeywordTargetResponse);
        }

        /// <summary>
        /// Returns true if KeywordTargetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KeywordTargetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeywordTargetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SuggestedBid == input.SuggestedBid ||
                    (this.SuggestedBid != null &&
                    this.SuggestedBid.Equals(input.SuggestedBid))
                ) &&
                (
                    this.Translation == input.Translation ||
                    (this.Translation != null &&
                    this.Translation.Equals(input.Translation))
                ) &&
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) &&
                (
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) &&
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) &&
                (
                    this.Bid == input.Bid ||
                    this.Bid.Equals(input.Bid)
                ) &&
                (
                    this.UserSelectedKeyword == input.UserSelectedKeyword ||
                    this.UserSelectedKeyword.Equals(input.UserSelectedKeyword)
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
                if (this.SuggestedBid != null)
                {
                    hashCode = (hashCode * 59) + this.SuggestedBid.GetHashCode();
                }
                if (this.Translation != null)
                {
                    hashCode = (hashCode * 59) + this.Translation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bid.GetHashCode();
                hashCode = (hashCode * 59) + this.UserSelectedKeyword.GetHashCode();
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
