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
    /// SevenDaysMissedOpportunities
    /// </summary>
    [DataContract(Name = "SevenDaysMissedOpportunities")]
    public partial class SevenDaysMissedOpportunities : IEquatable<SevenDaysMissedOpportunities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SevenDaysMissedOpportunities" /> class.
        /// </summary>
        /// <param name="estimatedMissedSalesLower">Lower bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency..</param>
        /// <param name="estimatedMissedSalesUpper">Upper bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency..</param>
        /// <param name="endDate">End date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time.</param>
        /// <param name="estimatedMissedImpressionsLower">Lower bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period..</param>
        /// <param name="estimatedMissedClicksLower">Lower bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period..</param>
        /// <param name="estimatedMissedClicksUpper">Upper bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period..</param>
        /// <param name="estimatedMissedImpressionsUpper">Upper bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period..</param>
        /// <param name="startDate">Starting date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time.</param>
        /// <param name="percentTimeInBudget">percentage of time the campaign is active with a budget. Provided as a decimal ranging from 0 to 1 (e.g. 0.76 means the campaign was in budget for 76% of the time between the startDate and endDate period).</param>
        public SevenDaysMissedOpportunities(decimal estimatedMissedSalesLower = default(decimal), decimal estimatedMissedSalesUpper = default(decimal), string endDate = default(string), int estimatedMissedImpressionsLower = default(int), int estimatedMissedClicksLower = default(int), int estimatedMissedClicksUpper = default(int), int estimatedMissedImpressionsUpper = default(int), string startDate = default(string), decimal percentTimeInBudget = default(decimal))
        {
            this.EstimatedMissedSalesLower = estimatedMissedSalesLower;
            this.EstimatedMissedSalesUpper = estimatedMissedSalesUpper;
            this.EndDate = endDate;
            this.EstimatedMissedImpressionsLower = estimatedMissedImpressionsLower;
            this.EstimatedMissedClicksLower = estimatedMissedClicksLower;
            this.EstimatedMissedClicksUpper = estimatedMissedClicksUpper;
            this.EstimatedMissedImpressionsUpper = estimatedMissedImpressionsUpper;
            this.StartDate = startDate;
            this.PercentTimeInBudget = percentTimeInBudget;
        }

        /// <summary>
        /// Lower bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency.
        /// </summary>
        /// <value>Lower bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency.</value>
        [DataMember(Name = "estimatedMissedSalesLower", EmitDefaultValue = false)]
        public decimal EstimatedMissedSalesLower { get; set; }

        /// <summary>
        /// Upper bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency.
        /// </summary>
        /// <value>Upper bound estimate of the additional sales the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period. Provided in local currency.</value>
        [DataMember(Name = "estimatedMissedSalesUpper", EmitDefaultValue = false)]
        public decimal EstimatedMissedSalesUpper { get; set; }

        /// <summary>
        /// End date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time
        /// </summary>
        /// <value>End date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Lower bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.
        /// </summary>
        /// <value>Lower bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.</value>
        [DataMember(Name = "estimatedMissedImpressionsLower", EmitDefaultValue = false)]
        public int EstimatedMissedImpressionsLower { get; set; }

        /// <summary>
        /// Lower bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.
        /// </summary>
        /// <value>Lower bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.</value>
        [DataMember(Name = "estimatedMissedClicksLower", EmitDefaultValue = false)]
        public int EstimatedMissedClicksLower { get; set; }

        /// <summary>
        /// Upper bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.
        /// </summary>
        /// <value>Upper bound estimate of the additional clicks the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.</value>
        [DataMember(Name = "estimatedMissedClicksUpper", EmitDefaultValue = false)]
        public int EstimatedMissedClicksUpper { get; set; }

        /// <summary>
        /// Upper bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.
        /// </summary>
        /// <value>Upper bound estimate of the additional impressions the campaign might have generated if it had not run out of budget during the {startDate} to {endDate} period.</value>
        [DataMember(Name = "estimatedMissedImpressionsUpper", EmitDefaultValue = false)]
        public int EstimatedMissedImpressionsUpper { get; set; }

        /// <summary>
        /// Starting date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time
        /// </summary>
        /// <value>Starting date of the date range for which missed opportunity metrics are provided (YYYYMMDD). Local time</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// percentage of time the campaign is active with a budget. Provided as a decimal ranging from 0 to 1 (e.g. 0.76 means the campaign was in budget for 76% of the time between the startDate and endDate period)
        /// </summary>
        /// <value>percentage of time the campaign is active with a budget. Provided as a decimal ranging from 0 to 1 (e.g. 0.76 means the campaign was in budget for 76% of the time between the startDate and endDate period)</value>
        [DataMember(Name = "percentTimeInBudget", EmitDefaultValue = false)]
        public decimal PercentTimeInBudget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SevenDaysMissedOpportunities {\n");
            sb.Append("  EstimatedMissedSalesLower: ").Append(EstimatedMissedSalesLower).Append("\n");
            sb.Append("  EstimatedMissedSalesUpper: ").Append(EstimatedMissedSalesUpper).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EstimatedMissedImpressionsLower: ").Append(EstimatedMissedImpressionsLower).Append("\n");
            sb.Append("  EstimatedMissedClicksLower: ").Append(EstimatedMissedClicksLower).Append("\n");
            sb.Append("  EstimatedMissedClicksUpper: ").Append(EstimatedMissedClicksUpper).Append("\n");
            sb.Append("  EstimatedMissedImpressionsUpper: ").Append(EstimatedMissedImpressionsUpper).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  PercentTimeInBudget: ").Append(PercentTimeInBudget).Append("\n");
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
            return this.Equals(input as SevenDaysMissedOpportunities);
        }

        /// <summary>
        /// Returns true if SevenDaysMissedOpportunities instances are equal
        /// </summary>
        /// <param name="input">Instance of SevenDaysMissedOpportunities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SevenDaysMissedOpportunities input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.EstimatedMissedSalesLower == input.EstimatedMissedSalesLower ||
                    this.EstimatedMissedSalesLower.Equals(input.EstimatedMissedSalesLower)
                ) &&
                (
                    this.EstimatedMissedSalesUpper == input.EstimatedMissedSalesUpper ||
                    this.EstimatedMissedSalesUpper.Equals(input.EstimatedMissedSalesUpper)
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.EstimatedMissedImpressionsLower == input.EstimatedMissedImpressionsLower ||
                    this.EstimatedMissedImpressionsLower.Equals(input.EstimatedMissedImpressionsLower)
                ) &&
                (
                    this.EstimatedMissedClicksLower == input.EstimatedMissedClicksLower ||
                    this.EstimatedMissedClicksLower.Equals(input.EstimatedMissedClicksLower)
                ) &&
                (
                    this.EstimatedMissedClicksUpper == input.EstimatedMissedClicksUpper ||
                    this.EstimatedMissedClicksUpper.Equals(input.EstimatedMissedClicksUpper)
                ) &&
                (
                    this.EstimatedMissedImpressionsUpper == input.EstimatedMissedImpressionsUpper ||
                    this.EstimatedMissedImpressionsUpper.Equals(input.EstimatedMissedImpressionsUpper)
                ) &&
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) &&
                (
                    this.PercentTimeInBudget == input.PercentTimeInBudget ||
                    this.PercentTimeInBudget.Equals(input.PercentTimeInBudget)
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
                hashCode = (hashCode * 59) + this.EstimatedMissedSalesLower.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedMissedSalesUpper.GetHashCode();
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EstimatedMissedImpressionsLower.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedMissedClicksLower.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedMissedClicksUpper.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedMissedImpressionsUpper.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PercentTimeInBudget.GetHashCode();
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
