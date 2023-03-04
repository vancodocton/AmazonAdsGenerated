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
    /// Special events with date range and suggested budget increase.
    /// </summary>
    [DataContract(Name = "SPBudgetRulesRecommendationEventResponse")]
    public partial class SPBudgetRulesRecommendationEventResponse : IEquatable<SPBudgetRulesRecommendationEventResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPBudgetRulesRecommendationEventResponse" /> class.
        /// </summary>
        /// <param name="recommendedBudgetRuleEvents">A list of recommended special events with date range and suggested budget increase..</param>
        public SPBudgetRulesRecommendationEventResponse(List<SPBudgetRulesRecommendationEvent> recommendedBudgetRuleEvents = default(List<SPBudgetRulesRecommendationEvent>))
        {
            this.RecommendedBudgetRuleEvents = recommendedBudgetRuleEvents;
        }

        /// <summary>
        /// A list of recommended special events with date range and suggested budget increase.
        /// </summary>
        /// <value>A list of recommended special events with date range and suggested budget increase.</value>
        [DataMember(Name = "recommendedBudgetRuleEvents", EmitDefaultValue = false)]
        public List<SPBudgetRulesRecommendationEvent> RecommendedBudgetRuleEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SPBudgetRulesRecommendationEventResponse {\n");
            sb.Append("  RecommendedBudgetRuleEvents: ").Append(RecommendedBudgetRuleEvents).Append("\n");
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
            return this.Equals(input as SPBudgetRulesRecommendationEventResponse);
        }

        /// <summary>
        /// Returns true if SPBudgetRulesRecommendationEventResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SPBudgetRulesRecommendationEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPBudgetRulesRecommendationEventResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecommendedBudgetRuleEvents == input.RecommendedBudgetRuleEvents ||
                    this.RecommendedBudgetRuleEvents != null &&
                    input.RecommendedBudgetRuleEvents != null &&
                    this.RecommendedBudgetRuleEvents.SequenceEqual(input.RecommendedBudgetRuleEvents)
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
                if (this.RecommendedBudgetRuleEvents != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendedBudgetRuleEvents.GetHashCode();
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
