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
    /// SponsoredProductsNegativeTargetAccessErrorSelector
    /// </summary>
    [DataContract(Name = "SponsoredProductsNegativeTargetAccessErrorSelector")]
    public partial class SponsoredProductsNegativeTargetAccessErrorSelector : IEquatable<SponsoredProductsNegativeTargetAccessErrorSelector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsNegativeTargetAccessErrorSelector" /> class.
        /// </summary>
        /// <param name="entityNotFoundError">entityNotFoundError.</param>
        /// <param name="missingValueError">missingValueError.</param>
        /// <param name="malformedValueError">malformedValueError.</param>
        /// <param name="internalServerError">internalServerError.</param>
        /// <param name="rangeError">rangeError.</param>
        /// <param name="otherError">otherError.</param>
        /// <param name="invalidInputError">invalidInputError.</param>
        /// <param name="throttledError">throttledError.</param>
        public SponsoredProductsNegativeTargetAccessErrorSelector(SponsoredProductsEntityNotFoundError entityNotFoundError = default(SponsoredProductsEntityNotFoundError), SponsoredProductsMissingValueError missingValueError = default(SponsoredProductsMissingValueError), SponsoredProductsMalformedValueError malformedValueError = default(SponsoredProductsMalformedValueError), SponsoredProductsInternalServerError internalServerError = default(SponsoredProductsInternalServerError), SponsoredProductsRangeError rangeError = default(SponsoredProductsRangeError), SponsoredProductsOtherError otherError = default(SponsoredProductsOtherError), SponsoredProductsInvalidInputError invalidInputError = default(SponsoredProductsInvalidInputError), SponsoredProductsThrottledError throttledError = default(SponsoredProductsThrottledError))
        {
            this.EntityNotFoundError = entityNotFoundError;
            this.MissingValueError = missingValueError;
            this.MalformedValueError = malformedValueError;
            this.InternalServerError = internalServerError;
            this.RangeError = rangeError;
            this.OtherError = otherError;
            this.InvalidInputError = invalidInputError;
            this.ThrottledError = throttledError;
        }

        /// <summary>
        /// Gets or Sets EntityNotFoundError
        /// </summary>
        [DataMember(Name = "entityNotFoundError", EmitDefaultValue = false)]
        public SponsoredProductsEntityNotFoundError EntityNotFoundError { get; set; }

        /// <summary>
        /// Gets or Sets MissingValueError
        /// </summary>
        [DataMember(Name = "missingValueError", EmitDefaultValue = false)]
        public SponsoredProductsMissingValueError MissingValueError { get; set; }

        /// <summary>
        /// Gets or Sets MalformedValueError
        /// </summary>
        [DataMember(Name = "malformedValueError", EmitDefaultValue = false)]
        public SponsoredProductsMalformedValueError MalformedValueError { get; set; }

        /// <summary>
        /// Gets or Sets InternalServerError
        /// </summary>
        [DataMember(Name = "internalServerError", EmitDefaultValue = false)]
        public SponsoredProductsInternalServerError InternalServerError { get; set; }

        /// <summary>
        /// Gets or Sets RangeError
        /// </summary>
        [DataMember(Name = "rangeError", EmitDefaultValue = false)]
        public SponsoredProductsRangeError RangeError { get; set; }

        /// <summary>
        /// Gets or Sets OtherError
        /// </summary>
        [DataMember(Name = "otherError", EmitDefaultValue = false)]
        public SponsoredProductsOtherError OtherError { get; set; }

        /// <summary>
        /// Gets or Sets InvalidInputError
        /// </summary>
        [DataMember(Name = "invalidInputError", EmitDefaultValue = false)]
        public SponsoredProductsInvalidInputError InvalidInputError { get; set; }

        /// <summary>
        /// Gets or Sets ThrottledError
        /// </summary>
        [DataMember(Name = "throttledError", EmitDefaultValue = false)]
        public SponsoredProductsThrottledError ThrottledError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsNegativeTargetAccessErrorSelector {\n");
            sb.Append("  EntityNotFoundError: ").Append(EntityNotFoundError).Append("\n");
            sb.Append("  MissingValueError: ").Append(MissingValueError).Append("\n");
            sb.Append("  MalformedValueError: ").Append(MalformedValueError).Append("\n");
            sb.Append("  InternalServerError: ").Append(InternalServerError).Append("\n");
            sb.Append("  RangeError: ").Append(RangeError).Append("\n");
            sb.Append("  OtherError: ").Append(OtherError).Append("\n");
            sb.Append("  InvalidInputError: ").Append(InvalidInputError).Append("\n");
            sb.Append("  ThrottledError: ").Append(ThrottledError).Append("\n");
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
            return this.Equals(input as SponsoredProductsNegativeTargetAccessErrorSelector);
        }

        /// <summary>
        /// Returns true if SponsoredProductsNegativeTargetAccessErrorSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsNegativeTargetAccessErrorSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsNegativeTargetAccessErrorSelector input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityNotFoundError == input.EntityNotFoundError ||
                    (this.EntityNotFoundError != null &&
                    this.EntityNotFoundError.Equals(input.EntityNotFoundError))
                ) && 
                (
                    this.MissingValueError == input.MissingValueError ||
                    (this.MissingValueError != null &&
                    this.MissingValueError.Equals(input.MissingValueError))
                ) && 
                (
                    this.MalformedValueError == input.MalformedValueError ||
                    (this.MalformedValueError != null &&
                    this.MalformedValueError.Equals(input.MalformedValueError))
                ) && 
                (
                    this.InternalServerError == input.InternalServerError ||
                    (this.InternalServerError != null &&
                    this.InternalServerError.Equals(input.InternalServerError))
                ) && 
                (
                    this.RangeError == input.RangeError ||
                    (this.RangeError != null &&
                    this.RangeError.Equals(input.RangeError))
                ) && 
                (
                    this.OtherError == input.OtherError ||
                    (this.OtherError != null &&
                    this.OtherError.Equals(input.OtherError))
                ) && 
                (
                    this.InvalidInputError == input.InvalidInputError ||
                    (this.InvalidInputError != null &&
                    this.InvalidInputError.Equals(input.InvalidInputError))
                ) && 
                (
                    this.ThrottledError == input.ThrottledError ||
                    (this.ThrottledError != null &&
                    this.ThrottledError.Equals(input.ThrottledError))
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
                if (this.EntityNotFoundError != null)
                {
                    hashCode = (hashCode * 59) + this.EntityNotFoundError.GetHashCode();
                }
                if (this.MissingValueError != null)
                {
                    hashCode = (hashCode * 59) + this.MissingValueError.GetHashCode();
                }
                if (this.MalformedValueError != null)
                {
                    hashCode = (hashCode * 59) + this.MalformedValueError.GetHashCode();
                }
                if (this.InternalServerError != null)
                {
                    hashCode = (hashCode * 59) + this.InternalServerError.GetHashCode();
                }
                if (this.RangeError != null)
                {
                    hashCode = (hashCode * 59) + this.RangeError.GetHashCode();
                }
                if (this.OtherError != null)
                {
                    hashCode = (hashCode * 59) + this.OtherError.GetHashCode();
                }
                if (this.InvalidInputError != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidInputError.GetHashCode();
                }
                if (this.ThrottledError != null)
                {
                    hashCode = (hashCode * 59) + this.ThrottledError.GetHashCode();
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
