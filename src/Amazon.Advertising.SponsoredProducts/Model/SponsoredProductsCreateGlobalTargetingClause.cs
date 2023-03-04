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
    /// SponsoredProductsCreateGlobalTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateGlobalTargetingClause")]
    public partial class SponsoredProductsCreateGlobalTargetingClause : IEquatable<SponsoredProductsCreateGlobalTargetingClause>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ExpressionType
        /// </summary>
        [DataMember(Name = "expressionType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateExpressionType ExpressionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateGlobalTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The targeting expression. (required).</param>
        /// <param name="campaignId">The identifier of the campaign to which this target is associated. (required).</param>
        /// <param name="name">Name for the targeting clause.</param>
        /// <param name="expressionType">expressionType (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="bid">bid.</param>
        /// <param name="adGroupId">The identifier of the ad group to which this target is associated. (required).</param>
        public SponsoredProductsCreateGlobalTargetingClause(List<SponsoredProductsGlobalTargetingExpressionPredicate> expression = default(List<SponsoredProductsGlobalTargetingExpressionPredicate>), string campaignId = default(string), string name = default(string), SponsoredProductsCreateExpressionType expressionType = default(SponsoredProductsCreateExpressionType), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsGlobalBid bid = default(SponsoredProductsGlobalBid), string adGroupId = default(string))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for SponsoredProductsCreateGlobalTargetingClause and cannot be null");
            }
            this.Expression = expression;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateGlobalTargetingClause and cannot be null");
            }
            this.CampaignId = campaignId;
            this.ExpressionType = expressionType;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsCreateGlobalTargetingClause and cannot be null");
            }
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsCreateGlobalTargetingClause and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.Name = name;
            this.Bid = bid;
        }

        /// <summary>
        /// The targeting expression.
        /// </summary>
        /// <value>The targeting expression.</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsGlobalTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The identifier of the campaign to which this target is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which this target is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Name for the targeting clause
        /// </summary>
        /// <value>Name for the targeting clause</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets Bid
        /// </summary>
        [DataMember(Name = "bid", EmitDefaultValue = false)]
        public SponsoredProductsGlobalBid Bid { get; set; }

        /// <summary>
        /// The identifier of the ad group to which this target is associated.
        /// </summary>
        /// <value>The identifier of the ad group to which this target is associated.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateGlobalTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExpressionType: ").Append(ExpressionType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateGlobalTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateGlobalTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateGlobalTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateGlobalTargetingClause input)
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
                    this.ExpressionType == input.ExpressionType ||
                    this.ExpressionType.Equals(input.ExpressionType)
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpressionType.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Bid != null)
                {
                    hashCode = (hashCode * 59) + this.Bid.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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
