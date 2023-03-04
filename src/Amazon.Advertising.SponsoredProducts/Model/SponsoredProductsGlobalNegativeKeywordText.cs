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
    /// SponsoredProductsGlobalNegativeKeywordText
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalNegativeKeywordText")]
    public partial class SponsoredProductsGlobalNegativeKeywordText : IEquatable<SponsoredProductsGlobalNegativeKeywordText>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeKeywordText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalNegativeKeywordText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeKeywordText" /> class.
        /// </summary>
        /// <param name="marketplaceSettings">The marketplace settings for keyword text to be overridden for marketplace..</param>
        /// <param name="value">value (required).</param>
        public SponsoredProductsGlobalNegativeKeywordText(List<SponsoredProductsKeywordTextMarketplaceSettings> marketplaceSettings = default(List<SponsoredProductsKeywordTextMarketplaceSettings>), string value = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for SponsoredProductsGlobalNegativeKeywordText and cannot be null");
            }
            this.Value = value;
            this.MarketplaceSettings = marketplaceSettings;
        }

        /// <summary>
        /// The marketplace settings for keyword text to be overridden for marketplace.
        /// </summary>
        /// <value>The marketplace settings for keyword text to be overridden for marketplace.</value>
        [DataMember(Name = "marketplaceSettings", EmitDefaultValue = false)]
        public List<SponsoredProductsKeywordTextMarketplaceSettings> MarketplaceSettings { get; set; }

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
            sb.Append("class SponsoredProductsGlobalNegativeKeywordText {\n");
            sb.Append("  MarketplaceSettings: ").Append(MarketplaceSettings).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalNegativeKeywordText);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalNegativeKeywordText instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalNegativeKeywordText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalNegativeKeywordText input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MarketplaceSettings == input.MarketplaceSettings ||
                    this.MarketplaceSettings != null &&
                    input.MarketplaceSettings != null &&
                    this.MarketplaceSettings.SequenceEqual(input.MarketplaceSettings)
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
                if (this.MarketplaceSettings != null)
                {
                    hashCode = (hashCode * 59) + this.MarketplaceSettings.GetHashCode();
                }
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