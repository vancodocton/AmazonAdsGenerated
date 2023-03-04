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
    /// SponsoredProductsCampaignNegativeKeywordMutationError
    /// </summary>
    [DataContract(Name = "SponsoredProductsCampaignNegativeKeywordMutationError")]
    public partial class SponsoredProductsCampaignNegativeKeywordMutationError : IEquatable<SponsoredProductsCampaignNegativeKeywordMutationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeKeywordMutationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCampaignNegativeKeywordMutationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeKeywordMutationError" /> class.
        /// </summary>
        /// <param name="errorType">The type of the error (required).</param>
        /// <param name="errorValue">errorValue (required).</param>
        public SponsoredProductsCampaignNegativeKeywordMutationError(string errorType = default(string), SponsoredProductsCampaignNegativeKeywordMutationErrorSelector errorValue = default(SponsoredProductsCampaignNegativeKeywordMutationErrorSelector))
        {
            // to ensure "errorType" is required (not null)
            if (errorType == null)
            {
                throw new ArgumentNullException("errorType is a required property for SponsoredProductsCampaignNegativeKeywordMutationError and cannot be null");
            }
            this.ErrorType = errorType;
            // to ensure "errorValue" is required (not null)
            if (errorValue == null)
            {
                throw new ArgumentNullException("errorValue is a required property for SponsoredProductsCampaignNegativeKeywordMutationError and cannot be null");
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
        public SponsoredProductsCampaignNegativeKeywordMutationErrorSelector ErrorValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCampaignNegativeKeywordMutationError {\n");
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
            return this.Equals(input as SponsoredProductsCampaignNegativeKeywordMutationError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCampaignNegativeKeywordMutationError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCampaignNegativeKeywordMutationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCampaignNegativeKeywordMutationError input)
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
