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
    /// SponsoredProductsMarketplaceBudget
    /// </summary>
    [DataContract(Name = "SponsoredProductsMarketplaceBudget")]
    public partial class SponsoredProductsMarketplaceBudget : IEquatable<SponsoredProductsMarketplaceBudget>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceBudget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsMarketplaceBudget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceBudget" /> class.
        /// </summary>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="budget">Monetary value (required).</param>
        public SponsoredProductsMarketplaceBudget(SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), double budget = default(double))
        {
            this.Budget = budget;
            this.Marketplace = marketplace;
        }

        /// <summary>
        /// Monetary value
        /// </summary>
        /// <value>Monetary value</value>
        [DataMember(Name = "budget", IsRequired = true, EmitDefaultValue = true)]
        public double Budget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsMarketplaceBudget {\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
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
            return this.Equals(input as SponsoredProductsMarketplaceBudget);
        }

        /// <summary>
        /// Returns true if SponsoredProductsMarketplaceBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsMarketplaceBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsMarketplaceBudget input)
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
                    this.Budget == input.Budget ||
                    this.Budget.Equals(input.Budget)
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
                hashCode = (hashCode * 59) + this.Budget.GetHashCode();
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