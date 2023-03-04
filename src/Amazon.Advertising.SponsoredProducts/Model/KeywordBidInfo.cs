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
    /// KeywordBidInfo
    /// </summary>
    [DataContract(Name = "KeywordBidInfo")]
    public partial class KeywordBidInfo : IEquatable<KeywordBidInfo>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="KeywordBidInfo" /> class.
        /// </summary>
        /// <param name="suggestedBid">suggestedBid.</param>
        /// <param name="matchType">Keyword match type. The default value will be BROAD..</param>
        /// <param name="rank">The keyword target rank.</param>
        /// <param name="bid">The bid value for the keyword. The default value will be the suggested bid..</param>
        public KeywordBidInfo(BidSuggestion suggestedBid = default(BidSuggestion), MatchTypeEnum? matchType = default(MatchTypeEnum?), decimal rank = default(decimal), decimal bid = default(decimal))
        {
            this.SuggestedBid = suggestedBid;
            this.MatchType = matchType;
            this.Rank = rank;
            this.Bid = bid;
        }

        /// <summary>
        /// Gets or Sets SuggestedBid
        /// </summary>
        [DataMember(Name = "suggestedBid", EmitDefaultValue = false)]
        public BidSuggestion SuggestedBid { get; set; }

        /// <summary>
        /// The keyword target rank
        /// </summary>
        /// <value>The keyword target rank</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public decimal Rank { get; set; }

        /// <summary>
        /// The bid value for the keyword. The default value will be the suggested bid.
        /// </summary>
        /// <value>The bid value for the keyword. The default value will be the suggested bid.</value>
        [DataMember(Name = "bid", EmitDefaultValue = false)]
        public decimal Bid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KeywordBidInfo {\n");
            sb.Append("  SuggestedBid: ").Append(SuggestedBid).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
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
            return this.Equals(input as KeywordBidInfo);
        }

        /// <summary>
        /// Returns true if KeywordBidInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of KeywordBidInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeywordBidInfo input)
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
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) &&
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) &&
                (
                    this.Bid == input.Bid ||
                    this.Bid.Equals(input.Bid)
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
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                hashCode = (hashCode * 59) + this.Bid.GetHashCode();
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
