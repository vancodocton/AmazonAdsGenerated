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
    /// SPBudgetRulesRecommendationEvent
    /// </summary>
    [DataContract(Name = "SPBudgetRulesRecommendationEvent")]
    public partial class SPBudgetRulesRecommendationEvent : IEquatable<SPBudgetRulesRecommendationEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPBudgetRulesRecommendationEvent" /> class.
        /// </summary>
        /// <param name="eventId">The event identifier..</param>
        /// <param name="endDate">The end date in YYYYMMDD format..</param>
        /// <param name="suggestedBudgetIncreasePercent">The suggested budget increase expressed as a percent..</param>
        /// <param name="eventName">The event name..</param>
        /// <param name="startDate">The start date in YYYYMMDD format..</param>
        public SPBudgetRulesRecommendationEvent(string eventId = default(string), string endDate = default(string), decimal suggestedBudgetIncreasePercent = default(decimal), string eventName = default(string), string startDate = default(string))
        {
            this.EventId = eventId;
            this.EndDate = endDate;
            this.SuggestedBudgetIncreasePercent = suggestedBudgetIncreasePercent;
            this.EventName = eventName;
            this.StartDate = startDate;
        }

        /// <summary>
        /// The event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// The end date in YYYYMMDD format.
        /// </summary>
        /// <value>The end date in YYYYMMDD format.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The suggested budget increase expressed as a percent.
        /// </summary>
        /// <value>The suggested budget increase expressed as a percent.</value>
        [DataMember(Name = "suggestedBudgetIncreasePercent", EmitDefaultValue = false)]
        public decimal SuggestedBudgetIncreasePercent { get; set; }

        /// <summary>
        /// The event name.
        /// </summary>
        /// <value>The event name.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// The start date in YYYYMMDD format.
        /// </summary>
        /// <value>The start date in YYYYMMDD format.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SPBudgetRulesRecommendationEvent {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SuggestedBudgetIncreasePercent: ").Append(SuggestedBudgetIncreasePercent).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as SPBudgetRulesRecommendationEvent);
        }

        /// <summary>
        /// Returns true if SPBudgetRulesRecommendationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SPBudgetRulesRecommendationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPBudgetRulesRecommendationEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.SuggestedBudgetIncreasePercent == input.SuggestedBudgetIncreasePercent ||
                    this.SuggestedBudgetIncreasePercent.Equals(input.SuggestedBudgetIncreasePercent)
                ) &&
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) &&
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SuggestedBudgetIncreasePercent.GetHashCode();
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
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
