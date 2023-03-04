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
    /// SponsoredProductsGlobalNegativeTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalNegativeTargetingClause")]
    public partial class SponsoredProductsGlobalNegativeTargetingClause : IEquatable<SponsoredProductsGlobalNegativeTargetingClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalNegativeTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The NegativeTargeting expression. (required).</param>
        /// <param name="targetId">The target identifier (required).</param>
        /// <param name="resolvedExpression">The resolved NegativeTargeting expression. (required).</param>
        /// <param name="campaignId">The identifier of the campaign to which this target is associated. (required).</param>
        /// <param name="name">Name for the negative targeting clause (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="adGroupId">The identifier of the ad group to which this target is associated. (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsGlobalNegativeTargetingClause(List<SponsoredProductsGlobalTargetingExpressionPredicate> expression = default(List<SponsoredProductsGlobalTargetingExpressionPredicate>), string targetId = default(string), List<SponsoredProductsGlobalTargetingExpressionPredicate> resolvedExpression = default(List<SponsoredProductsGlobalTargetingExpressionPredicate>), string campaignId = default(string), string name = default(string), SponsoredProductsGlobalEntityState state = default(SponsoredProductsGlobalEntityState), string adGroupId = default(string), SponsoredProductsGlobalNegativeTargetingClauseExtendedData extendedData = default(SponsoredProductsGlobalNegativeTargetingClauseExtendedData))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.Expression = expression;
            // to ensure "targetId" is required (not null)
            if (targetId == null)
            {
                throw new ArgumentNullException("targetId is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.TargetId = targetId;
            // to ensure "resolvedExpression" is required (not null)
            if (resolvedExpression == null)
            {
                throw new ArgumentNullException("resolvedExpression is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.ResolvedExpression = resolvedExpression;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.CampaignId = campaignId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.Name = name;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsGlobalNegativeTargetingClause and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// The NegativeTargeting expression.
        /// </summary>
        /// <value>The NegativeTargeting expression.</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsGlobalTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The target identifier
        /// </summary>
        /// <value>The target identifier</value>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// The resolved NegativeTargeting expression.
        /// </summary>
        /// <value>The resolved NegativeTargeting expression.</value>
        [DataMember(Name = "resolvedExpression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsGlobalTargetingExpressionPredicate> ResolvedExpression { get; set; }

        /// <summary>
        /// The identifier of the campaign to which this target is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which this target is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Name for the negative targeting clause
        /// </summary>
        /// <value>Name for the negative targeting clause</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalEntityState State { get; set; }

        /// <summary>
        /// The identifier of the ad group to which this target is associated.
        /// </summary>
        /// <value>The identifier of the ad group to which this target is associated.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsGlobalNegativeTargetingClauseExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalNegativeTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  ResolvedExpression: ").Append(ResolvedExpression).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalNegativeTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalNegativeTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalNegativeTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalNegativeTargetingClause input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
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
