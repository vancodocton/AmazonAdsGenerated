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
    /// SDRuleBasedBudget
    /// </summary>
    [DataContract(Name = "SDRuleBasedBudget")]
    public partial class SDRuleBasedBudget : IEquatable<SDRuleBasedBudget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDRuleBasedBudget" /> class.
        /// </summary>
        /// <param name="executionTime">Epoch time of budget rule execution..</param>
        /// <param name="appliedRule">appliedRule.</param>
        /// <param name="ruleBasedBudgetValue">The budget value..</param>
        /// <param name="dailyBudgetValue">The daily budget value..</param>
        /// <param name="performanceMetric">performanceMetric.</param>
        public SDRuleBasedBudget(decimal executionTime = default(decimal), SDBudgetRule appliedRule = default(SDBudgetRule), decimal ruleBasedBudgetValue = default(decimal), decimal dailyBudgetValue = default(decimal), PerformanceMetricValue performanceMetric = default(PerformanceMetricValue))
        {
            this.ExecutionTime = executionTime;
            this.AppliedRule = appliedRule;
            this.RuleBasedBudgetValue = ruleBasedBudgetValue;
            this.DailyBudgetValue = dailyBudgetValue;
            this.PerformanceMetric = performanceMetric;
        }

        /// <summary>
        /// Epoch time of budget rule execution.
        /// </summary>
        /// <value>Epoch time of budget rule execution.</value>
        [DataMember(Name = "executionTime", EmitDefaultValue = false)]
        public decimal ExecutionTime { get; set; }

        /// <summary>
        /// Gets or Sets AppliedRule
        /// </summary>
        [DataMember(Name = "appliedRule", EmitDefaultValue = false)]
        public SDBudgetRule AppliedRule { get; set; }

        /// <summary>
        /// The budget value.
        /// </summary>
        /// <value>The budget value.</value>
        [DataMember(Name = "ruleBasedBudgetValue", EmitDefaultValue = false)]
        public decimal RuleBasedBudgetValue { get; set; }

        /// <summary>
        /// The daily budget value.
        /// </summary>
        /// <value>The daily budget value.</value>
        [DataMember(Name = "dailyBudgetValue", EmitDefaultValue = false)]
        public decimal DailyBudgetValue { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceMetric
        /// </summary>
        [DataMember(Name = "performanceMetric", EmitDefaultValue = false)]
        public PerformanceMetricValue PerformanceMetric { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SDRuleBasedBudget {\n");
            sb.Append("  ExecutionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  AppliedRule: ").Append(AppliedRule).Append("\n");
            sb.Append("  RuleBasedBudgetValue: ").Append(RuleBasedBudgetValue).Append("\n");
            sb.Append("  DailyBudgetValue: ").Append(DailyBudgetValue).Append("\n");
            sb.Append("  PerformanceMetric: ").Append(PerformanceMetric).Append("\n");
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
            return this.Equals(input as SDRuleBasedBudget);
        }

        /// <summary>
        /// Returns true if SDRuleBasedBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of SDRuleBasedBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDRuleBasedBudget input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ExecutionTime == input.ExecutionTime ||
                    this.ExecutionTime.Equals(input.ExecutionTime)
                ) &&
                (
                    this.AppliedRule == input.AppliedRule ||
                    (this.AppliedRule != null &&
                    this.AppliedRule.Equals(input.AppliedRule))
                ) &&
                (
                    this.RuleBasedBudgetValue == input.RuleBasedBudgetValue ||
                    this.RuleBasedBudgetValue.Equals(input.RuleBasedBudgetValue)
                ) &&
                (
                    this.DailyBudgetValue == input.DailyBudgetValue ||
                    this.DailyBudgetValue.Equals(input.DailyBudgetValue)
                ) &&
                (
                    this.PerformanceMetric == input.PerformanceMetric ||
                    (this.PerformanceMetric != null &&
                    this.PerformanceMetric.Equals(input.PerformanceMetric))
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
                hashCode = (hashCode * 59) + this.ExecutionTime.GetHashCode();
                if (this.AppliedRule != null)
                {
                    hashCode = (hashCode * 59) + this.AppliedRule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RuleBasedBudgetValue.GetHashCode();
                hashCode = (hashCode * 59) + this.DailyBudgetValue.GetHashCode();
                if (this.PerformanceMetric != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceMetric.GetHashCode();
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
