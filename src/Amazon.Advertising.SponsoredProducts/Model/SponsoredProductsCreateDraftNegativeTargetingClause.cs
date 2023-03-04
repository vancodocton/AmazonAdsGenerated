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
    /// SponsoredProductsCreateDraftNegativeTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateDraftNegativeTargetingClause")]
    public partial class SponsoredProductsCreateDraftNegativeTargetingClause : IEquatable<SponsoredProductsCreateDraftNegativeTargetingClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateDraftNegativeTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateDraftNegativeTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateDraftNegativeTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The DraftNegativeTargeting expression. (required).</param>
        /// <param name="campaignId">The identifier of the campaign to which this target is associated. (required).</param>
        /// <param name="adGroupId">The identifier of the ad group to which this target is associated. (required).</param>
        public SponsoredProductsCreateDraftNegativeTargetingClause(List<SponsoredProductsCreateOrUpdateNegativeTargetingExpressionPredicate> expression = default(List<SponsoredProductsCreateOrUpdateNegativeTargetingExpressionPredicate>), string campaignId = default(string), string adGroupId = default(string))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for SponsoredProductsCreateDraftNegativeTargetingClause and cannot be null");
            }
            this.Expression = expression;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateDraftNegativeTargetingClause and cannot be null");
            }
            this.CampaignId = campaignId;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsCreateDraftNegativeTargetingClause and cannot be null");
            }
            this.AdGroupId = adGroupId;
        }

        /// <summary>
        /// The DraftNegativeTargeting expression.
        /// </summary>
        /// <value>The DraftNegativeTargeting expression.</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateOrUpdateNegativeTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The identifier of the campaign to which this target is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which this target is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

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
            sb.Append("class SponsoredProductsCreateDraftNegativeTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateDraftNegativeTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateDraftNegativeTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateDraftNegativeTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateDraftNegativeTargetingClause input)
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
