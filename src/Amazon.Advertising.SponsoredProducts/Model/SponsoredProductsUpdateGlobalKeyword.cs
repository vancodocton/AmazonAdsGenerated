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
    /// SponsoredProductsUpdateGlobalKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateGlobalKeyword")]
    public partial class SponsoredProductsUpdateGlobalKeyword : IEquatable<SponsoredProductsUpdateGlobalKeyword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateGlobalKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalKeyword" /> class.
        /// </summary>
        /// <param name="keywordId">entity object identifier (required).</param>
        /// <param name="name">Name for the Keyword.</param>
        /// <param name="state">state.</param>
        /// <param name="bid">bid.</param>
        /// <param name="keywordText">keywordText.</param>
        public SponsoredProductsUpdateGlobalKeyword(string keywordId = default(string), string name = default(string), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsGlobalBid bid = default(SponsoredProductsGlobalBid), SponsoredProductsGlobalKeywordText keywordText = default(SponsoredProductsGlobalKeywordText))
        {
            // to ensure "keywordId" is required (not null)
            if (keywordId == null)
            {
                throw new ArgumentNullException("keywordId is a required property for SponsoredProductsUpdateGlobalKeyword and cannot be null");
            }
            this.KeywordId = keywordId;
            this.Name = name;
            this.State = state;
            this.Bid = bid;
            this.KeywordText = keywordText;
        }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "keywordId", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordId { get; set; }

        /// <summary>
        /// Name for the Keyword
        /// </summary>
        /// <value>Name for the Keyword</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets Bid
        /// </summary>
        [DataMember(Name = "bid", EmitDefaultValue = false)]
        public SponsoredProductsGlobalBid Bid { get; set; }

        /// <summary>
        /// Gets or Sets KeywordText
        /// </summary>
        [DataMember(Name = "keywordText", EmitDefaultValue = false)]
        public SponsoredProductsGlobalKeywordText KeywordText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateGlobalKeyword {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  KeywordText: ").Append(KeywordText).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateGlobalKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateGlobalKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateGlobalKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateGlobalKeyword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeywordId == input.KeywordId ||
                    (this.KeywordId != null &&
                    this.KeywordId.Equals(input.KeywordId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
                ) && 
                (
                    this.KeywordText == input.KeywordText ||
                    (this.KeywordText != null &&
                    this.KeywordText.Equals(input.KeywordText))
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
                if (this.KeywordId != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Bid != null)
                {
                    hashCode = (hashCode * 59) + this.Bid.GetHashCode();
                }
                if (this.KeywordText != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordText.GetHashCode();
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