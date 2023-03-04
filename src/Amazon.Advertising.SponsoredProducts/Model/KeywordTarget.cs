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
    /// KeywordTarget
    /// </summary>
    [DataContract(Name = "KeywordTarget")]
    public partial class KeywordTarget : IEquatable<KeywordTarget>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="KeywordTarget" /> class.
        /// </summary>
        /// <param name="matchType">Keyword match type. The default value will be BROAD..</param>
        /// <param name="keyword">The keyword value.</param>
        /// <param name="bid">The bid value for the keyword. The default value will be the suggested bid..</param>
        /// <param name="userSelectedKeyword">Flag that tells if keyword was selected by the user or was recommended by KRS.</param>
        public KeywordTarget(MatchTypeEnum? matchType = default(MatchTypeEnum?), string keyword = default(string), double bid = default(double), bool userSelectedKeyword = default(bool))
        {
            this.MatchType = matchType;
            this.Keyword = keyword;
            this.Bid = bid;
            this.UserSelectedKeyword = userSelectedKeyword;
        }

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
            sb.Append("class KeywordTarget {\n");
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
            return this.Equals(input as KeywordTarget);
        }

        /// <summary>
        /// Returns true if KeywordTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of KeywordTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeywordTarget input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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