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
    /// SponsoredProductsCreateTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateTargetingClause")]
    public partial class SponsoredProductsCreateTargetingClause : IEquatable<SponsoredProductsCreateTargetingClause>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ExpressionType
        /// </summary>
        [DataMember(Name = "expressionType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateExpressionType ExpressionType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateEntityState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The targeting expression. (required).</param>
        /// <param name="campaignId">The identifier of the campaign to which this target is associated. (required).</param>
        /// <param name="expressionType">expressionType (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="bid">The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |.</param>
        /// <param name="adGroupId">The identifier of the ad group to which this target is associated. (required).</param>
        public SponsoredProductsCreateTargetingClause(List<SponsoredProductsCreateTargetingExpressionPredicate> expression = default(List<SponsoredProductsCreateTargetingExpressionPredicate>), string campaignId = default(string), SponsoredProductsCreateExpressionType expressionType = default(SponsoredProductsCreateExpressionType), SponsoredProductsCreateOrUpdateEntityState state = default(SponsoredProductsCreateOrUpdateEntityState), double? bid = default(double?), string adGroupId = default(string))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for SponsoredProductsCreateTargetingClause and cannot be null");
            }
            this.Expression = expression;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateTargetingClause and cannot be null");
            }
            this.CampaignId = campaignId;
            this.ExpressionType = expressionType;
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsCreateTargetingClause and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.Bid = bid;
        }

        /// <summary>
        /// The targeting expression.
        /// </summary>
        /// <value>The targeting expression.</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The identifier of the campaign to which this target is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which this target is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |
        /// </summary>
        /// <value>The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |</value>
        [DataMember(Name = "bid", EmitDefaultValue = true)]
        public double? Bid { get; set; }

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
            sb.Append("class SponsoredProductsCreateTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateTargetingClause input)
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
                    this.ExpressionType == input.ExpressionType ||
                    this.ExpressionType.Equals(input.ExpressionType)
                ) &&
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                hashCode = (hashCode * 59) + this.ExpressionType.GetHashCode();
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
