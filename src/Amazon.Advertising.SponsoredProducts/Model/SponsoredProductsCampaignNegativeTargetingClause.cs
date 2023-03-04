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
    /// SponsoredProductsCampaignNegativeTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsCampaignNegativeTargetingClause")]
    public partial class SponsoredProductsCampaignNegativeTargetingClause : IEquatable<SponsoredProductsCampaignNegativeTargetingClause>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsEntityState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCampaignNegativeTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The CampaignNegativeTargetingClause expression. (required).</param>
        /// <param name="targetId">The target identifier (required).</param>
        /// <param name="resolvedExpression">The resolved CampaignNegativeTargetingClause expression. (required).</param>
        /// <param name="campaignId">The identifier of the campaign to which this target is associated. (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsCampaignNegativeTargetingClause(List<SponsoredProductsNegativeTargetingExpressionPredicate> expression = default(List<SponsoredProductsNegativeTargetingExpressionPredicate>), string targetId = default(string), List<SponsoredProductsNegativeTargetingExpressionPredicate> resolvedExpression = default(List<SponsoredProductsNegativeTargetingExpressionPredicate>), string campaignId = default(string), SponsoredProductsEntityState state = default(SponsoredProductsEntityState), SponsoredProductsCampaignNegativeTargetingClauseExtendedData extendedData = default(SponsoredProductsCampaignNegativeTargetingClauseExtendedData))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for SponsoredProductsCampaignNegativeTargetingClause and cannot be null");
            }
            this.Expression = expression;
            // to ensure "targetId" is required (not null)
            if (targetId == null)
            {
                throw new ArgumentNullException("targetId is a required property for SponsoredProductsCampaignNegativeTargetingClause and cannot be null");
            }
            this.TargetId = targetId;
            // to ensure "resolvedExpression" is required (not null)
            if (resolvedExpression == null)
            {
                throw new ArgumentNullException("resolvedExpression is a required property for SponsoredProductsCampaignNegativeTargetingClause and cannot be null");
            }
            this.ResolvedExpression = resolvedExpression;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCampaignNegativeTargetingClause and cannot be null");
            }
            this.CampaignId = campaignId;
            this.State = state;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// The CampaignNegativeTargetingClause expression.
        /// </summary>
        /// <value>The CampaignNegativeTargetingClause expression.</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsNegativeTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The target identifier
        /// </summary>
        /// <value>The target identifier</value>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// The resolved CampaignNegativeTargetingClause expression.
        /// </summary>
        /// <value>The resolved CampaignNegativeTargetingClause expression.</value>
        [DataMember(Name = "resolvedExpression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsNegativeTargetingExpressionPredicate> ResolvedExpression { get; set; }

        /// <summary>
        /// The identifier of the campaign to which this target is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which this target is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsCampaignNegativeTargetingClauseExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCampaignNegativeTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  ResolvedExpression: ").Append(ResolvedExpression).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExtendedData: ").Append(ExtendedData).Append("\n");
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
            return this.Equals(input as SponsoredProductsCampaignNegativeTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCampaignNegativeTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCampaignNegativeTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCampaignNegativeTargetingClause input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Expression == input.Expression ||
                    this.Expression != null &&
                    input.Expression != null &&
                    this.Expression.SequenceEqual(input.Expression)
                ) &&
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) &&
                (
                    this.ResolvedExpression == input.ResolvedExpression ||
                    this.ResolvedExpression != null &&
                    input.ResolvedExpression != null &&
                    this.ResolvedExpression.SequenceEqual(input.ResolvedExpression)
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) &&
                (
                    this.ExtendedData == input.ExtendedData ||
                    (this.ExtendedData != null &&
                    this.ExtendedData.Equals(input.ExtendedData))
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
                if (this.Expression != null)
                {
                    hashCode = (hashCode * 59) + this.Expression.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.ResolvedExpression != null)
                {
                    hashCode = (hashCode * 59) + this.ResolvedExpression.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.ExtendedData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedData.GetHashCode();
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
