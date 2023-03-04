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
    /// SponsoredProductsTargetingExpressionPredicateWithoutOther
    /// </summary>
    [DataContract(Name = "SponsoredProductsTargetingExpressionPredicateWithoutOther")]
    public partial class SponsoredProductsTargetingExpressionPredicateWithoutOther : IEquatable<SponsoredProductsTargetingExpressionPredicateWithoutOther>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsTargetingExpressionPredicateTypeWithoutOther Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsTargetingExpressionPredicateWithoutOther" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsTargetingExpressionPredicateWithoutOther() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsTargetingExpressionPredicateWithoutOther" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="value">The expression value.</param>
        public SponsoredProductsTargetingExpressionPredicateWithoutOther(SponsoredProductsTargetingExpressionPredicateTypeWithoutOther type = default(SponsoredProductsTargetingExpressionPredicateTypeWithoutOther), string value = default(string))
        {
            this.Type = type;
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
            sb.Append("class SponsoredProductsTargetingExpressionPredicateWithoutOther {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SponsoredProductsTargetingExpressionPredicateWithoutOther);
        }

        /// <summary>
        /// Returns true if SponsoredProductsTargetingExpressionPredicateWithoutOther instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsTargetingExpressionPredicateWithoutOther to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsTargetingExpressionPredicateWithoutOther input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
