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
    /// SponsoredProductsTargetingExpressionPredicateMarketValue
    /// </summary>
    [DataContract(Name = "SponsoredProductsTargetingExpressionPredicateMarketValue")]
    public partial class SponsoredProductsTargetingExpressionPredicateMarketValue : IEquatable<SponsoredProductsTargetingExpressionPredicateMarketValue>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsTargetingExpressionPredicateMarketValue" /> class.
        /// </summary>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="value">The expression value.</param>
        public SponsoredProductsTargetingExpressionPredicateMarketValue(SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), string value = default(string))
        {
            this.Marketplace = marketplace;
            this.Value = value;
        }

        /// <summary>
        /// The expression value
        /// </summary>
        /// <value>The expression value</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsTargetingExpressionPredicateMarketValue {\n");
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
            return this.Equals(input as SponsoredProductsTargetingExpressionPredicateMarketValue);
        }

        /// <summary>
        /// Returns true if SponsoredProductsTargetingExpressionPredicateMarketValue instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsTargetingExpressionPredicateMarketValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsTargetingExpressionPredicateMarketValue input)
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
