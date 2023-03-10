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
    /// SponsoredProductsUpdateCampaignNegativeKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateCampaignNegativeKeyword")]
    public partial class SponsoredProductsUpdateCampaignNegativeKeyword : IEquatable<SponsoredProductsUpdateCampaignNegativeKeyword>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateCampaignNegativeKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateCampaignNegativeKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateCampaignNegativeKeyword" /> class.
        /// </summary>
        /// <param name="keywordId">entity object identifier (required).</param>
        /// <param name="state">state.</param>
        public SponsoredProductsUpdateCampaignNegativeKeyword(string keywordId = default(string), SponsoredProductsCreateOrUpdateEntityState? state = default(SponsoredProductsCreateOrUpdateEntityState?))
        {
            // to ensure "keywordId" is required (not null)
            if (keywordId == null)
            {
                throw new ArgumentNullException("keywordId is a required property for SponsoredProductsUpdateCampaignNegativeKeyword and cannot be null");
            }
            this.KeywordId = keywordId;
            this.State = state;
        }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "keywordId", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateCampaignNegativeKeyword {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateCampaignNegativeKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateCampaignNegativeKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateCampaignNegativeKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateCampaignNegativeKeyword input)
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
