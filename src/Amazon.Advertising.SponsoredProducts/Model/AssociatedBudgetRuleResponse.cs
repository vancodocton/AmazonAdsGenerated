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
    /// AssociatedBudgetRuleResponse
    /// </summary>
    [DataContract(Name = "AssociatedBudgetRuleResponse")]
    public partial class AssociatedBudgetRuleResponse : IEquatable<AssociatedBudgetRuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedBudgetRuleResponse" /> class.
        /// </summary>
        /// <param name="code">An enumerated success or error code for machine use..</param>
        /// <param name="details">A human-readable description of the error, if unsuccessful.</param>
        /// <param name="ruleId">The budget rule identifier..</param>
        public AssociatedBudgetRuleResponse(string code = default(string), string details = default(string), string ruleId = default(string))
        {
            this.Code = code;
            this.Details = details;
            this.RuleId = ruleId;
        }

        /// <summary>
        /// An enumerated success or error code for machine use.
        /// </summary>
        /// <value>An enumerated success or error code for machine use.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable description of the error, if unsuccessful
        /// </summary>
        /// <value>A human-readable description of the error, if unsuccessful</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// The budget rule identifier.
        /// </summary>
        /// <value>The budget rule identifier.</value>
        [DataMember(Name = "ruleId", EmitDefaultValue = false)]
        public string RuleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociatedBudgetRuleResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
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
            return this.Equals(input as AssociatedBudgetRuleResponse);
        }

        /// <summary>
        /// Returns true if AssociatedBudgetRuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociatedBudgetRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedBudgetRuleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) &&
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.RuleId != null)
                {
                    hashCode = (hashCode * 59) + this.RuleId.GetHashCode();
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
