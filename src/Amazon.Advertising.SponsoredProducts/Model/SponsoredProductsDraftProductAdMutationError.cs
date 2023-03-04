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
    /// SponsoredProductsDraftProductAdMutationError
    /// </summary>
    [DataContract(Name = "SponsoredProductsDraftProductAdMutationError")]
    public partial class SponsoredProductsDraftProductAdMutationError : IEquatable<SponsoredProductsDraftProductAdMutationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftProductAdMutationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDraftProductAdMutationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftProductAdMutationError" /> class.
        /// </summary>
        /// <param name="errorType">The type of the error (required).</param>
        /// <param name="errorValue">errorValue (required).</param>
        public SponsoredProductsDraftProductAdMutationError(string errorType = default(string), SponsoredProductsDraftProductAdMutationErrorSelector errorValue = default(SponsoredProductsDraftProductAdMutationErrorSelector))
        {
            // to ensure "errorType" is required (not null)
            if (errorType == null)
            {
                throw new ArgumentNullException("errorType is a required property for SponsoredProductsDraftProductAdMutationError and cannot be null");
            }
            this.ErrorType = errorType;
            // to ensure "errorValue" is required (not null)
            if (errorValue == null)
            {
                throw new ArgumentNullException("errorValue is a required property for SponsoredProductsDraftProductAdMutationError and cannot be null");
            }
            this.ErrorValue = errorValue;
        }

        /// <summary>
        /// The type of the error
        /// </summary>
        /// <value>The type of the error</value>
        [DataMember(Name = "errorType", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Gets or Sets ErrorValue
        /// </summary>
        [DataMember(Name = "errorValue", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsDraftProductAdMutationErrorSelector ErrorValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDraftProductAdMutationError {\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  ErrorValue: ").Append(ErrorValue).Append("\n");
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
            return this.Equals(input as SponsoredProductsDraftProductAdMutationError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDraftProductAdMutationError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDraftProductAdMutationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDraftProductAdMutationError input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ErrorType == input.ErrorType ||
                    (this.ErrorType != null &&
                    this.ErrorType.Equals(input.ErrorType))
                ) &&
                (
                    this.ErrorValue == input.ErrorValue ||
                    (this.ErrorValue != null &&
                    this.ErrorValue.Equals(input.ErrorValue))
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
                if (this.ErrorType != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorType.GetHashCode();
                }
                if (this.ErrorValue != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorValue.GetHashCode();
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
