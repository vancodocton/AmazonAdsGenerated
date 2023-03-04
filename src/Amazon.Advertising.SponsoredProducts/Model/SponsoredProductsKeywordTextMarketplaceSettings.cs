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
    /// SponsoredProductsKeywordTextMarketplaceSettings
    /// </summary>
    [DataContract(Name = "SponsoredProductsKeywordTextMarketplaceSettings")]
    public partial class SponsoredProductsKeywordTextMarketplaceSettings : IEquatable<SponsoredProductsKeywordTextMarketplaceSettings>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsKeywordTextMarketplaceSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsKeywordTextMarketplaceSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsKeywordTextMarketplaceSettings" /> class.
        /// </summary>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="value">value (required).</param>
        public SponsoredProductsKeywordTextMarketplaceSettings(SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), string value = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for SponsoredProductsKeywordTextMarketplaceSettings and cannot be null");
            }
            this.Value = value;
            this.Marketplace = marketplace;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsKeywordTextMarketplaceSettings {\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SponsoredProductsKeywordTextMarketplaceSettings);
        }

        /// <summary>
        /// Returns true if SponsoredProductsKeywordTextMarketplaceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsKeywordTextMarketplaceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsKeywordTextMarketplaceSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Marketplace == input.Marketplace ||
                    this.Marketplace.Equals(input.Marketplace)
                ) &&
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
