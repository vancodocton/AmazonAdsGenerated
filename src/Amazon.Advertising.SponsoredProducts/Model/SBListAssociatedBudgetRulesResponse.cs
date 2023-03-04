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
    /// SBListAssociatedBudgetRulesResponse
    /// </summary>
    [DataContract(Name = "SBListAssociatedBudgetRulesResponse")]
    public partial class SBListAssociatedBudgetRulesResponse : IEquatable<SBListAssociatedBudgetRulesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SBListAssociatedBudgetRulesResponse" /> class.
        /// </summary>
        /// <param name="associatedRules">A list of associated budget rules..</param>
        public SBListAssociatedBudgetRulesResponse(List<SBCampaignBudgetRule> associatedRules = default(List<SBCampaignBudgetRule>))
        {
            this.AssociatedRules = associatedRules;
        }

        /// <summary>
        /// A list of associated budget rules.
        /// </summary>
        /// <value>A list of associated budget rules.</value>
        [DataMember(Name = "associatedRules", EmitDefaultValue = false)]
        public List<SBCampaignBudgetRule> AssociatedRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SBListAssociatedBudgetRulesResponse {\n");
            sb.Append("  AssociatedRules: ").Append(AssociatedRules).Append("\n");
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
            return this.Equals(input as SBListAssociatedBudgetRulesResponse);
        }

        /// <summary>
        /// Returns true if SBListAssociatedBudgetRulesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SBListAssociatedBudgetRulesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SBListAssociatedBudgetRulesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AssociatedRules == input.AssociatedRules ||
                    this.AssociatedRules != null &&
                    input.AssociatedRules != null &&
                    this.AssociatedRules.SequenceEqual(input.AssociatedRules)
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
                if (this.AssociatedRules != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedRules.GetHashCode();
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
