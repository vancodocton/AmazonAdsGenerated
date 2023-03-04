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
    /// SponsoredProductsProductAdMutationErrorSelector
    /// </summary>
    [DataContract(Name = "SponsoredProductsProductAdMutationErrorSelector")]
    public partial class SponsoredProductsProductAdMutationErrorSelector : IEquatable<SponsoredProductsProductAdMutationErrorSelector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdMutationErrorSelector" /> class.
        /// </summary>
        /// <param name="entityStateError">entityStateError.</param>
        /// <param name="missingValueError">missingValueError.</param>
        /// <param name="asinOwnershipError">asinOwnershipError.</param>
        /// <param name="duplicateValueError">duplicateValueError.</param>
        /// <param name="rangeError">rangeError.</param>
        /// <param name="unsupportedOperationError">unsupportedOperationError.</param>
        /// <param name="parentEntityError">parentEntityError.</param>
        /// <param name="otherError">otherError.</param>
        /// <param name="throttledError">throttledError.</param>
        /// <param name="entityNotFoundError">entityNotFoundError.</param>
        /// <param name="malformedValueError">malformedValueError.</param>
        /// <param name="productIdentifierError">productIdentifierError.</param>
        /// <param name="adEligibilityError">adEligibilityError.</param>
        /// <param name="billingError">billingError.</param>
        /// <param name="entityQuotaError">entityQuotaError.</param>
        /// <param name="internalServerError">internalServerError.</param>
        public SponsoredProductsProductAdMutationErrorSelector(SponsoredProductsEntityStateError entityStateError = default(SponsoredProductsEntityStateError), SponsoredProductsMissingValueError missingValueError = default(SponsoredProductsMissingValueError), SponsoredProductsAsinOwnershipError asinOwnershipError = default(SponsoredProductsAsinOwnershipError), SponsoredProductsDuplicateValueError duplicateValueError = default(SponsoredProductsDuplicateValueError), SponsoredProductsRangeError rangeError = default(SponsoredProductsRangeError), SponsoredProductsUnsupportedOperationError unsupportedOperationError = default(SponsoredProductsUnsupportedOperationError), SponsoredProductsParentEntityError parentEntityError = default(SponsoredProductsParentEntityError), SponsoredProductsOtherError otherError = default(SponsoredProductsOtherError), SponsoredProductsThrottledError throttledError = default(SponsoredProductsThrottledError), SponsoredProductsEntityNotFoundError entityNotFoundError = default(SponsoredProductsEntityNotFoundError), SponsoredProductsMalformedValueError malformedValueError = default(SponsoredProductsMalformedValueError), SponsoredProductsProductIdentifierError productIdentifierError = default(SponsoredProductsProductIdentifierError), SponsoredProductsAdEligibilityError adEligibilityError = default(SponsoredProductsAdEligibilityError), SponsoredProductsBillingError billingError = default(SponsoredProductsBillingError), SponsoredProductsEntityQuotaError entityQuotaError = default(SponsoredProductsEntityQuotaError), SponsoredProductsInternalServerError internalServerError = default(SponsoredProductsInternalServerError))
        {
            this.EntityStateError = entityStateError;
            this.MissingValueError = missingValueError;
            this.AsinOwnershipError = asinOwnershipError;
            this.DuplicateValueError = duplicateValueError;
            this.RangeError = rangeError;
            this.UnsupportedOperationError = unsupportedOperationError;
            this.ParentEntityError = parentEntityError;
            this.OtherError = otherError;
            this.ThrottledError = throttledError;
            this.EntityNotFoundError = entityNotFoundError;
            this.MalformedValueError = malformedValueError;
            this.ProductIdentifierError = productIdentifierError;
            this.AdEligibilityError = adEligibilityError;
            this.BillingError = billingError;
            this.EntityQuotaError = entityQuotaError;
            this.InternalServerError = internalServerError;
        }

        /// <summary>
        /// Gets or Sets EntityStateError
        /// </summary>
        [DataMember(Name = "entityStateError", EmitDefaultValue = false)]
        public SponsoredProductsEntityStateError EntityStateError { get; set; }

        /// <summary>
        /// Gets or Sets MissingValueError
        /// </summary>
        [DataMember(Name = "missingValueError", EmitDefaultValue = false)]
        public SponsoredProductsMissingValueError MissingValueError { get; set; }

        /// <summary>
        /// Gets or Sets AsinOwnershipError
        /// </summary>
        [DataMember(Name = "asinOwnershipError", EmitDefaultValue = false)]
        public SponsoredProductsAsinOwnershipError AsinOwnershipError { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateValueError
        /// </summary>
        [DataMember(Name = "duplicateValueError", EmitDefaultValue = false)]
        public SponsoredProductsDuplicateValueError DuplicateValueError { get; set; }

        /// <summary>
        /// Gets or Sets RangeError
        /// </summary>
        [DataMember(Name = "rangeError", EmitDefaultValue = false)]
        public SponsoredProductsRangeError RangeError { get; set; }

        /// <summary>
        /// Gets or Sets UnsupportedOperationError
        /// </summary>
        [DataMember(Name = "unsupportedOperationError", EmitDefaultValue = false)]
        public SponsoredProductsUnsupportedOperationError UnsupportedOperationError { get; set; }

        /// <summary>
        /// Gets or Sets ParentEntityError
        /// </summary>
        [DataMember(Name = "parentEntityError", EmitDefaultValue = false)]
        public SponsoredProductsParentEntityError ParentEntityError { get; set; }

        /// <summary>
        /// Gets or Sets OtherError
        /// </summary>
        [DataMember(Name = "otherError", EmitDefaultValue = false)]
        public SponsoredProductsOtherError OtherError { get; set; }

        /// <summary>
        /// Gets or Sets ThrottledError
        /// </summary>
        [DataMember(Name = "throttledError", EmitDefaultValue = false)]
        public SponsoredProductsThrottledError ThrottledError { get; set; }

        /// <summary>
        /// Gets or Sets EntityNotFoundError
        /// </summary>
        [DataMember(Name = "entityNotFoundError", EmitDefaultValue = false)]
        public SponsoredProductsEntityNotFoundError EntityNotFoundError { get; set; }

        /// <summary>
        /// Gets or Sets MalformedValueError
        /// </summary>
        [DataMember(Name = "malformedValueError", EmitDefaultValue = false)]
        public SponsoredProductsMalformedValueError MalformedValueError { get; set; }

        /// <summary>
        /// Gets or Sets ProductIdentifierError
        /// </summary>
        [DataMember(Name = "productIdentifierError", EmitDefaultValue = false)]
        public SponsoredProductsProductIdentifierError ProductIdentifierError { get; set; }

        /// <summary>
        /// Gets or Sets AdEligibilityError
        /// </summary>
        [DataMember(Name = "adEligibilityError", EmitDefaultValue = false)]
        public SponsoredProductsAdEligibilityError AdEligibilityError { get; set; }

        /// <summary>
        /// Gets or Sets BillingError
        /// </summary>
        [DataMember(Name = "billingError", EmitDefaultValue = false)]
        public SponsoredProductsBillingError BillingError { get; set; }

        /// <summary>
        /// Gets or Sets EntityQuotaError
        /// </summary>
        [DataMember(Name = "entityQuotaError", EmitDefaultValue = false)]
        public SponsoredProductsEntityQuotaError EntityQuotaError { get; set; }

        /// <summary>
        /// Gets or Sets InternalServerError
        /// </summary>
        [DataMember(Name = "internalServerError", EmitDefaultValue = false)]
        public SponsoredProductsInternalServerError InternalServerError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsProductAdMutationErrorSelector {\n");
            sb.Append("  EntityStateError: ").Append(EntityStateError).Append("\n");
            sb.Append("  MissingValueError: ").Append(MissingValueError).Append("\n");
            sb.Append("  AsinOwnershipError: ").Append(AsinOwnershipError).Append("\n");
            sb.Append("  DuplicateValueError: ").Append(DuplicateValueError).Append("\n");
            sb.Append("  RangeError: ").Append(RangeError).Append("\n");
            sb.Append("  UnsupportedOperationError: ").Append(UnsupportedOperationError).Append("\n");
            sb.Append("  ParentEntityError: ").Append(ParentEntityError).Append("\n");
            sb.Append("  OtherError: ").Append(OtherError).Append("\n");
            sb.Append("  ThrottledError: ").Append(ThrottledError).Append("\n");
            sb.Append("  EntityNotFoundError: ").Append(EntityNotFoundError).Append("\n");
            sb.Append("  MalformedValueError: ").Append(MalformedValueError).Append("\n");
            sb.Append("  ProductIdentifierError: ").Append(ProductIdentifierError).Append("\n");
            sb.Append("  AdEligibilityError: ").Append(AdEligibilityError).Append("\n");
            sb.Append("  BillingError: ").Append(BillingError).Append("\n");
            sb.Append("  EntityQuotaError: ").Append(EntityQuotaError).Append("\n");
            sb.Append("  InternalServerError: ").Append(InternalServerError).Append("\n");
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
            return this.Equals(input as SponsoredProductsProductAdMutationErrorSelector);
        }

        /// <summary>
        /// Returns true if SponsoredProductsProductAdMutationErrorSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsProductAdMutationErrorSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsProductAdMutationErrorSelector input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityStateError == input.EntityStateError ||
                    (this.EntityStateError != null &&
                    this.EntityStateError.Equals(input.EntityStateError))
                ) && 
                (
                    this.MissingValueError == input.MissingValueError ||
                    (this.MissingValueError != null &&
                    this.MissingValueError.Equals(input.MissingValueError))
                ) && 
                (
                    this.AsinOwnershipError == input.AsinOwnershipError ||
                    (this.AsinOwnershipError != null &&
                    this.AsinOwnershipError.Equals(input.AsinOwnershipError))
                ) && 
                (
                    this.DuplicateValueError == input.DuplicateValueError ||
                    (this.DuplicateValueError != null &&
                    this.DuplicateValueError.Equals(input.DuplicateValueError))
                ) && 
                (
                    this.RangeError == input.RangeError ||
                    (this.RangeError != null &&
                    this.RangeError.Equals(input.RangeError))
                ) && 
                (
                    this.UnsupportedOperationError == input.UnsupportedOperationError ||
                    (this.UnsupportedOperationError != null &&
                    this.UnsupportedOperationError.Equals(input.UnsupportedOperationError))
                ) && 
                (
                    this.ParentEntityError == input.ParentEntityError ||
                    (this.ParentEntityError != null &&
                    this.ParentEntityError.Equals(input.ParentEntityError))
                ) && 
                (
                    this.OtherError == input.OtherError ||
                    (this.OtherError != null &&
                    this.OtherError.Equals(input.OtherError))
                ) && 
                (
                    this.ThrottledError == input.ThrottledError ||
                    (this.ThrottledError != null &&
                    this.ThrottledError.Equals(input.ThrottledError))
                ) && 
                (
                    this.EntityNotFoundError == input.EntityNotFoundError ||
                    (this.EntityNotFoundError != null &&
                    this.EntityNotFoundError.Equals(input.EntityNotFoundError))
                ) && 
                (
                    this.MalformedValueError == input.MalformedValueError ||
                    (this.MalformedValueError != null &&
                    this.MalformedValueError.Equals(input.MalformedValueError))
                ) && 
                (
                    this.ProductIdentifierError == input.ProductIdentifierError ||
                    (this.ProductIdentifierError != null &&
                    this.ProductIdentifierError.Equals(input.ProductIdentifierError))
                ) && 
                (
                    this.AdEligibilityError == input.AdEligibilityError ||
                    (this.AdEligibilityError != null &&
                    this.AdEligibilityError.Equals(input.AdEligibilityError))
                ) && 
                (
                    this.BillingError == input.BillingError ||
                    (this.BillingError != null &&
                    this.BillingError.Equals(input.BillingError))
                ) && 
                (
                    this.EntityQuotaError == input.EntityQuotaError ||
                    (this.EntityQuotaError != null &&
                    this.EntityQuotaError.Equals(input.EntityQuotaError))
                ) && 
                (
                    this.InternalServerError == input.InternalServerError ||
                    (this.InternalServerError != null &&
                    this.InternalServerError.Equals(input.InternalServerError))
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
                if (this.EntityStateError != null)
                {
                    hashCode = (hashCode * 59) + this.EntityStateError.GetHashCode();
                }
                if (this.MissingValueError != null)
                {
                    hashCode = (hashCode * 59) + this.MissingValueError.GetHashCode();
                }
                if (this.AsinOwnershipError != null)
                {
                    hashCode = (hashCode * 59) + this.AsinOwnershipError.GetHashCode();
                }
                if (this.DuplicateValueError != null)
                {
                    hashCode = (hashCode * 59) + this.DuplicateValueError.GetHashCode();
                }
                if (this.RangeError != null)
                {
                    hashCode = (hashCode * 59) + this.RangeError.GetHashCode();
                }
                if (this.UnsupportedOperationError != null)
                {
                    hashCode = (hashCode * 59) + this.UnsupportedOperationError.GetHashCode();
                }
                if (this.ParentEntityError != null)
                {
                    hashCode = (hashCode * 59) + this.ParentEntityError.GetHashCode();
                }
                if (this.OtherError != null)
                {
                    hashCode = (hashCode * 59) + this.OtherError.GetHashCode();
                }
                if (this.ThrottledError != null)
                {
                    hashCode = (hashCode * 59) + this.ThrottledError.GetHashCode();
                }
                if (this.EntityNotFoundError != null)
                {
                    hashCode = (hashCode * 59) + this.EntityNotFoundError.GetHashCode();
                }
                if (this.MalformedValueError != null)
                {
                    hashCode = (hashCode * 59) + this.MalformedValueError.GetHashCode();
                }
                if (this.ProductIdentifierError != null)
                {
                    hashCode = (hashCode * 59) + this.ProductIdentifierError.GetHashCode();
                }
                if (this.AdEligibilityError != null)
                {
                    hashCode = (hashCode * 59) + this.AdEligibilityError.GetHashCode();
                }
                if (this.BillingError != null)
                {
                    hashCode = (hashCode * 59) + this.BillingError.GetHashCode();
                }
                if (this.EntityQuotaError != null)
                {
                    hashCode = (hashCode * 59) + this.EntityQuotaError.GetHashCode();
                }
                if (this.InternalServerError != null)
                {
                    hashCode = (hashCode * 59) + this.InternalServerError.GetHashCode();
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
