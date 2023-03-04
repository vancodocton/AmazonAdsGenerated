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
    /// CreateSBBudgetRulesRequest
    /// </summary>
    [DataContract(Name = "CreateSBBudgetRulesRequest")]
    public partial class CreateSBBudgetRulesRequest : IEquatable<CreateSBBudgetRulesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSBBudgetRulesRequest" /> class.
        /// </summary>
        /// <param name="budgetRulesDetails">A list of budget rule details..</param>
        public CreateSBBudgetRulesRequest(List<SBBudgetRuleDetails> budgetRulesDetails = default(List<SBBudgetRuleDetails>))
        {
            this.BudgetRulesDetails = budgetRulesDetails;
        }

        /// <summary>
        /// A list of budget rule details.
        /// </summary>
        /// <value>A list of budget rule details.</value>
        [DataMember(Name = "budgetRulesDetails", EmitDefaultValue = false)]
        public List<SBBudgetRuleDetails> BudgetRulesDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSBBudgetRulesRequest {\n");
            sb.Append("  BudgetRulesDetails: ").Append(BudgetRulesDetails).Append("\n");
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
            return this.Equals(input as CreateSBBudgetRulesRequest);
        }

        /// <summary>
        /// Returns true if CreateSBBudgetRulesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSBBudgetRulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSBBudgetRulesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetRulesDetails == input.BudgetRulesDetails ||
                    this.BudgetRulesDetails != null &&
                    input.BudgetRulesDetails != null &&
                    this.BudgetRulesDetails.SequenceEqual(input.BudgetRulesDetails)
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
                if (this.BudgetRulesDetails != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetRulesDetails.GetHashCode();
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
