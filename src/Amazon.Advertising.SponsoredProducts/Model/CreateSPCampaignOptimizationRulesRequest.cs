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
    /// CreateSPCampaignOptimizationRulesRequest
    /// </summary>
    [DataContract(Name = "CreateSPCampaignOptimizationRulesRequest")]
    public partial class CreateSPCampaignOptimizationRulesRequest : IEquatable<CreateSPCampaignOptimizationRulesRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name = "recurrence", IsRequired = true, EmitDefaultValue = true)]
        public RecurrenceType Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets RuleAction
        /// </summary>
        [DataMember(Name = "ruleAction", IsRequired = true, EmitDefaultValue = true)]
        public RuleAction RuleAction { get; set; }

        /// <summary>
        /// Gets or Sets RuleType
        /// </summary>
        [DataMember(Name = "ruleType", IsRequired = true, EmitDefaultValue = true)]
        public RuleType RuleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSPCampaignOptimizationRulesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSPCampaignOptimizationRulesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSPCampaignOptimizationRulesRequest" /> class.
        /// </summary>
        /// <param name="recurrence">recurrence (required).</param>
        /// <param name="ruleAction">ruleAction (required).</param>
        /// <param name="ruleCondition">ruleCondition (required).</param>
        /// <param name="ruleType">ruleType (required).</param>
        /// <param name="ruleName">The campaign optimization rule name..</param>
        /// <param name="campaignIds">A list of campaign ids (required).</param>
        public CreateSPCampaignOptimizationRulesRequest(RecurrenceType recurrence = default(RecurrenceType), RuleAction ruleAction = default(RuleAction), List<RuleCondition> ruleCondition = default(List<RuleCondition>), RuleType ruleType = default(RuleType), string ruleName = default(string), List<string> campaignIds = default(List<string>))
        {
            this.Recurrence = recurrence;
            this.RuleAction = ruleAction;
            // to ensure "ruleCondition" is required (not null)
            if (ruleCondition == null)
            {
                throw new ArgumentNullException("ruleCondition is a required property for CreateSPCampaignOptimizationRulesRequest and cannot be null");
            }
            this.RuleCondition = ruleCondition;
            this.RuleType = ruleType;
            // to ensure "campaignIds" is required (not null)
            if (campaignIds == null)
            {
                throw new ArgumentNullException("campaignIds is a required property for CreateSPCampaignOptimizationRulesRequest and cannot be null");
            }
            this.CampaignIds = campaignIds;
            this.RuleName = ruleName;
        }

        /// <summary>
        /// Gets or Sets RuleCondition
        /// </summary>
        [DataMember(Name = "ruleCondition", IsRequired = true, EmitDefaultValue = true)]
        public List<RuleCondition> RuleCondition { get; set; }

        /// <summary>
        /// The campaign optimization rule name.
        /// </summary>
        /// <value>The campaign optimization rule name.</value>
        [DataMember(Name = "ruleName", EmitDefaultValue = false)]
        public string RuleName { get; set; }

        /// <summary>
        /// A list of campaign ids
        /// </summary>
        /// <value>A list of campaign ids</value>
        [DataMember(Name = "campaignIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> CampaignIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSPCampaignOptimizationRulesRequest {\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  RuleAction: ").Append(RuleAction).Append("\n");
            sb.Append("  RuleCondition: ").Append(RuleCondition).Append("\n");
            sb.Append("  RuleType: ").Append(RuleType).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  CampaignIds: ").Append(CampaignIds).Append("\n");
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
            return this.Equals(input as CreateSPCampaignOptimizationRulesRequest);
        }

        /// <summary>
        /// Returns true if CreateSPCampaignOptimizationRulesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSPCampaignOptimizationRulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSPCampaignOptimizationRulesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Recurrence == input.Recurrence ||
                    this.Recurrence.Equals(input.Recurrence)
                ) && 
                (
                    this.RuleAction == input.RuleAction ||
                    this.RuleAction.Equals(input.RuleAction)
                ) && 
                (
                    this.RuleCondition == input.RuleCondition ||
                    this.RuleCondition != null &&
                    input.RuleCondition != null &&
                    this.RuleCondition.SequenceEqual(input.RuleCondition)
                ) && 
                (
                    this.RuleType == input.RuleType ||
                    this.RuleType.Equals(input.RuleType)
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.CampaignIds == input.CampaignIds ||
                    this.CampaignIds != null &&
                    input.CampaignIds != null &&
                    this.CampaignIds.SequenceEqual(input.CampaignIds)
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
                hashCode = (hashCode * 59) + this.Recurrence.GetHashCode();
                hashCode = (hashCode * 59) + this.RuleAction.GetHashCode();
                if (this.RuleCondition != null)
                {
                    hashCode = (hashCode * 59) + this.RuleCondition.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RuleType.GetHashCode();
                if (this.RuleName != null)
                {
                    hashCode = (hashCode * 59) + this.RuleName.GetHashCode();
                }
                if (this.CampaignIds != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIds.GetHashCode();
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
            // RuleName (string) maxLength
            if (this.RuleName != null && this.RuleName.Length > 355)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RuleName, length must be less than 355.", new [] { "RuleName" });
            }

            yield break;
        }
    }

}