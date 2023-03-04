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
    /// SponsoredProductsCampaignNegativeTargetsMutationErrorSelector
    /// </summary>
    [DataContract(Name = "SponsoredProductsCampaignNegativeTargetsMutationErrorSelector")]
    public partial class SponsoredProductsCampaignNegativeTargetsMutationErrorSelector : IEquatable<SponsoredProductsCampaignNegativeTargetsMutationErrorSelector>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeTargetsMutationErrorSelector" /> class.
        /// </summary>
        /// <param name="entityStateError">entityStateError.</param>
        /// <param name="missingValueError">missingValueError.</param>
        /// <param name="duplicateValueError">duplicateValueError.</param>
        /// <param name="rangeError">rangeError.</param>
        /// <param name="parentEntityError">parentEntityError.</param>
        /// <param name="otherError">otherError.</param>
        /// <param name="throttledError">throttledError.</param>
        /// <param name="entityNotFoundError">entityNotFoundError.</param>
        /// <param name="targetingClauseSetupError">targetingClauseSetupError.</param>
        /// <param name="malformedValueError">malformedValueError.</param>
        /// <param name="billingError">billingError.</param>
        /// <param name="entityQuotaError">entityQuotaError.</param>
        /// <param name="internalServerError">internalServerError.</param>
        public SponsoredProductsCampaignNegativeTargetsMutationErrorSelector(SponsoredProductsEntityStateError entityStateError = default(SponsoredProductsEntityStateError), SponsoredProductsMissingValueError missingValueError = default(SponsoredProductsMissingValueError), SponsoredProductsDuplicateValueError duplicateValueError = default(SponsoredProductsDuplicateValueError), SponsoredProductsRangeError rangeError = default(SponsoredProductsRangeError), SponsoredProductsParentEntityError parentEntityError = default(SponsoredProductsParentEntityError), SponsoredProductsOtherError otherError = default(SponsoredProductsOtherError), SponsoredProductsThrottledError throttledError = default(SponsoredProductsThrottledError), SponsoredProductsEntityNotFoundError entityNotFoundError = default(SponsoredProductsEntityNotFoundError), SponsoredProductsTargetingClauseSetupError targetingClauseSetupError = default(SponsoredProductsTargetingClauseSetupError), SponsoredProductsMalformedValueError malformedValueError = default(SponsoredProductsMalformedValueError), SponsoredProductsBillingError billingError = default(SponsoredProductsBillingError), SponsoredProductsEntityQuotaError entityQuotaError = default(SponsoredProductsEntityQuotaError), SponsoredProductsInternalServerError internalServerError = default(SponsoredProductsInternalServerError))
        {
            this.EntityStateError = entityStateError;
            this.MissingValueError = missingValueError;
            this.DuplicateValueError = duplicateValueError;
            this.RangeError = rangeError;
            this.ParentEntityError = parentEntityError;
            this.OtherError = otherError;
            this.ThrottledError = throttledError;
            this.EntityNotFoundError = entityNotFoundError;
            this.TargetingClauseSetupError = targetingClauseSetupError;
            this.MalformedValueError = malformedValueError;
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
        /// Gets or Sets TargetingClauseSetupError
        /// </summary>
        [DataMember(Name = "targetingClauseSetupError", EmitDefaultValue = false)]
        public SponsoredProductsTargetingClauseSetupError TargetingClauseSetupError { get; set; }

        /// <summary>
        /// Gets or Sets MalformedValueError
        /// </summary>
        [DataMember(Name = "malformedValueError", EmitDefaultValue = false)]
        public SponsoredProductsMalformedValueError MalformedValueError { get; set; }

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
            sb.Append("class SponsoredProductsCampaignNegativeTargetsMutationErrorSelector {\n");
            sb.Append("  EntityStateError: ").Append(EntityStateError).Append("\n");
            sb.Append("  MissingValueError: ").Append(MissingValueError).Append("\n");
            sb.Append("  DuplicateValueError: ").Append(DuplicateValueError).Append("\n");
            sb.Append("  RangeError: ").Append(RangeError).Append("\n");
            sb.Append("  ParentEntityError: ").Append(ParentEntityError).Append("\n");
            sb.Append("  OtherError: ").Append(OtherError).Append("\n");
            sb.Append("  ThrottledError: ").Append(ThrottledError).Append("\n");
            sb.Append("  EntityNotFoundError: ").Append(EntityNotFoundError).Append("\n");
            sb.Append("  TargetingClauseSetupError: ").Append(TargetingClauseSetupError).Append("\n");
            sb.Append("  MalformedValueError: ").Append(MalformedValueError).Append("\n");
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
            return this.Equals(input as SponsoredProductsCampaignNegativeTargetsMutationErrorSelector);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCampaignNegativeTargetsMutationErrorSelector instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCampaignNegativeTargetsMutationErrorSelector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCampaignNegativeTargetsMutationErrorSelector input)
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
                    this.TargetingClauseSetupError == input.TargetingClauseSetupError ||
                    (this.TargetingClauseSetupError != null &&
                    this.TargetingClauseSetupError.Equals(input.TargetingClauseSetupError))
                ) && 
                (
                    this.MalformedValueError == input.MalformedValueError ||
                    (this.MalformedValueError != null &&
                    this.MalformedValueError.Equals(input.MalformedValueError))
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
                if (this.DuplicateValueError != null)
                {
                    hashCode = (hashCode * 59) + this.DuplicateValueError.GetHashCode();
                }
                if (this.RangeError != null)
                {
                    hashCode = (hashCode * 59) + this.RangeError.GetHashCode();
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
                if (this.TargetingClauseSetupError != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingClauseSetupError.GetHashCode();
                }
                if (this.MalformedValueError != null)
                {
                    hashCode = (hashCode * 59) + this.MalformedValueError.GetHashCode();
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
