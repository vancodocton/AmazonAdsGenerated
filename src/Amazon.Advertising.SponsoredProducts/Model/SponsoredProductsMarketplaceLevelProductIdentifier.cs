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
    /// SponsoredProductsMarketplaceLevelProductIdentifier
    /// </summary>
    [DataContract(Name = "SponsoredProductsMarketplaceLevelProductIdentifier")]
    public partial class SponsoredProductsMarketplaceLevelProductIdentifier : IEquatable<SponsoredProductsMarketplaceLevelProductIdentifier>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceLevelProductIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsMarketplaceLevelProductIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceLevelProductIdentifier" /> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="marketplace">marketplace.</param>
        public SponsoredProductsMarketplaceLevelProductIdentifier(string identifier = default(string), SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for SponsoredProductsMarketplaceLevelProductIdentifier and cannot be null");
            }
            this.Identifier = identifier;
            this.Marketplace = marketplace;
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsMarketplaceLevelProductIdentifier {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
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
            return this.Equals(input as SponsoredProductsMarketplaceLevelProductIdentifier);
        }

        /// <summary>
        /// Returns true if SponsoredProductsMarketplaceLevelProductIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsMarketplaceLevelProductIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsMarketplaceLevelProductIdentifier input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) &&
                (
                    this.Marketplace == input.Marketplace ||
                    this.Marketplace.Equals(input.Marketplace)
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
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
