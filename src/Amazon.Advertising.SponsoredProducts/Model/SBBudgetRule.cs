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
    /// SBBudgetRule
    /// </summary>
    [DataContract(Name = "SBBudgetRule")]
    public partial class SBBudgetRule : IEquatable<SBBudgetRule>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RuleState
        /// </summary>
        [DataMember(Name = "ruleState", EmitDefaultValue = false)]
        public State? RuleState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SBBudgetRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SBBudgetRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SBBudgetRule" /> class.
        /// </summary>
        /// <param name="ruleState">ruleState.</param>
        /// <param name="lastUpdatedDate">Epoch time of budget rule update. Read-only..</param>
        /// <param name="createdDate">Epoch time of budget rule creation. Read-only..</param>
        /// <param name="ruleDetails">ruleDetails.</param>
        /// <param name="ruleId">The budget rule identifier. (required).</param>
        /// <param name="ruleStatus">The budget rule status. Read-only..</param>
        public SBBudgetRule(State? ruleState = default(State?), decimal lastUpdatedDate = default(decimal), decimal createdDate = default(decimal), SBBudgetRuleDetails ruleDetails = default(SBBudgetRuleDetails), string ruleId = default(string), string ruleStatus = default(string))
        {
            // to ensure "ruleId" is required (not null)
            if (ruleId == null)
            {
                throw new ArgumentNullException("ruleId is a required property for SBBudgetRule and cannot be null");
            }
            this.RuleId = ruleId;
            this.RuleState = ruleState;
            this.LastUpdatedDate = lastUpdatedDate;
            this.CreatedDate = createdDate;
            this.RuleDetails = ruleDetails;
            this.RuleStatus = ruleStatus;
        }

        /// <summary>
        /// Epoch time of budget rule update. Read-only.
        /// </summary>
        /// <value>Epoch time of budget rule update. Read-only.</value>
        [DataMember(Name = "lastUpdatedDate", EmitDefaultValue = false)]
        public decimal LastUpdatedDate { get; set; }

        /// <summary>
        /// Epoch time of budget rule creation. Read-only.
        /// </summary>
        /// <value>Epoch time of budget rule creation. Read-only.</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public decimal CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets RuleDetails
        /// </summary>
        [DataMember(Name = "ruleDetails", EmitDefaultValue = false)]
        public SBBudgetRuleDetails RuleDetails { get; set; }

        /// <summary>
        /// The budget rule identifier.
        /// </summary>
        /// <value>The budget rule identifier.</value>
        [DataMember(Name = "ruleId", IsRequired = true, EmitDefaultValue = true)]
        public string RuleId { get; set; }

        /// <summary>
        /// The budget rule status. Read-only.
        /// </summary>
        /// <value>The budget rule status. Read-only.</value>
        [DataMember(Name = "ruleStatus", EmitDefaultValue = false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SBBudgetRule {\n");
            sb.Append("  RuleState: ").Append(RuleState).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  RuleDetails: ").Append(RuleDetails).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  RuleStatus: ").Append(RuleStatus).Append("\n");
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
            return this.Equals(input as SBBudgetRule);
        }

        /// <summary>
        /// Returns true if SBBudgetRule instances are equal
        /// </summary>
        /// <param name="input">Instance of SBBudgetRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SBBudgetRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RuleState == input.RuleState ||
                    this.RuleState.Equals(input.RuleState)
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    this.CreatedDate.Equals(input.CreatedDate)
                ) && 
                (
                    this.RuleDetails == input.RuleDetails ||
                    (this.RuleDetails != null &&
                    this.RuleDetails.Equals(input.RuleDetails))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.RuleStatus == input.RuleStatus ||
                    (this.RuleStatus != null &&
                    this.RuleStatus.Equals(input.RuleStatus))
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
                hashCode = (hashCode * 59) + this.RuleState.GetHashCode();
                hashCode = (hashCode * 59) + this.LastUpdatedDate.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                if (this.RuleDetails != null)
                {
                    hashCode = (hashCode * 59) + this.RuleDetails.GetHashCode();
                }
                if (this.RuleId != null)
                {
                    hashCode = (hashCode * 59) + this.RuleId.GetHashCode();
                }
                if (this.RuleStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RuleStatus.GetHashCode();
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
