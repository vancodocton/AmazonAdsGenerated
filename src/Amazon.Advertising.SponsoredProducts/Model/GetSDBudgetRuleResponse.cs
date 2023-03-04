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
    /// GetSDBudgetRuleResponse
    /// </summary>
    [DataContract(Name = "GetSDBudgetRuleResponse")]
    public partial class GetSDBudgetRuleResponse : IEquatable<GetSDBudgetRuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSDBudgetRuleResponse" /> class.
        /// </summary>
        /// <param name="budgetRule">budgetRule.</param>
        public GetSDBudgetRuleResponse(SDBudgetRule budgetRule = default(SDBudgetRule))
        {
            this.BudgetRule = budgetRule;
        }

        /// <summary>
        /// Gets or Sets BudgetRule
        /// </summary>
        [DataMember(Name = "budgetRule", EmitDefaultValue = false)]
        public SDBudgetRule BudgetRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSDBudgetRuleResponse {\n");
            sb.Append("  BudgetRule: ").Append(BudgetRule).Append("\n");
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
            return this.Equals(input as GetSDBudgetRuleResponse);
        }

        /// <summary>
        /// Returns true if GetSDBudgetRuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSDBudgetRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSDBudgetRuleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BudgetRule == input.BudgetRule ||
                    (this.BudgetRule != null &&
                    this.BudgetRule.Equals(input.BudgetRule))
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
                if (this.BudgetRule != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetRule.GetHashCode();
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
