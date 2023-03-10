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
    /// SponsoredProductsUpdateKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateKeyword")]
    public partial class SponsoredProductsUpdateKeyword : IEquatable<SponsoredProductsUpdateKeyword>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateKeyword" /> class.
        /// </summary>
        /// <param name="keywordId">entity object identifier (required).</param>
        /// <param name="state">state.</param>
        /// <param name="bid">Bid associated with this keyword. Applicable to biddable match types only.</param>
        public SponsoredProductsUpdateKeyword(string keywordId = default(string), SponsoredProductsCreateOrUpdateEntityState? state = default(SponsoredProductsCreateOrUpdateEntityState?), double? bid = default(double?))
        {
            // to ensure "keywordId" is required (not null)
            if (keywordId == null)
            {
                throw new ArgumentNullException("keywordId is a required property for SponsoredProductsUpdateKeyword and cannot be null");
            }
            this.KeywordId = keywordId;
            this.State = state;
            this.Bid = bid;
        }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "keywordId", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordId { get; set; }

        /// <summary>
        /// Bid associated with this keyword. Applicable to biddable match types only
        /// </summary>
        /// <value>Bid associated with this keyword. Applicable to biddable match types only</value>
        [DataMember(Name = "bid", EmitDefaultValue = true)]
        public double? Bid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateKeyword {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateKeyword input)
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
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) &&
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Bid != null)
                {
                    hashCode = (hashCode * 59) + this.Bid.GetHashCode();
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
            // Bid (double?) minimum
            if (this.Bid < (double?)0.02)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bid, must be a value greater than or equal to 0.02.", new[] { "Bid" });
            }

            yield break;
        }
    }

}
