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
    /// InitialBudgetRecommendationResponse
    /// </summary>
    [DataContract(Name = "InitialBudgetRecommendationResponse")]
    public partial class InitialBudgetRecommendationResponse : IEquatable<InitialBudgetRecommendationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialBudgetRecommendationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitialBudgetRecommendationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialBudgetRecommendationResponse" /> class.
        /// </summary>
        /// <param name="specialEvents">A list of special events around the start and end date of the campaign. (required).</param>
        /// <param name="dailyBudget">Recommended daily budget for the new campaign. (required).</param>
        /// <param name="recommendationId">Unique identifier for each recommendation..</param>
        /// <param name="benchmark">benchmark (required).</param>
        public InitialBudgetRecommendationResponse(List<SpecialEvent> specialEvents = default(List<SpecialEvent>), decimal dailyBudget = default(decimal), string recommendationId = default(string), Benchmark benchmark = default(Benchmark))
        {
            // to ensure "specialEvents" is required (not null)
            if (specialEvents == null)
            {
                throw new ArgumentNullException("specialEvents is a required property for InitialBudgetRecommendationResponse and cannot be null");
            }
            this.SpecialEvents = specialEvents;
            this.DailyBudget = dailyBudget;
            // to ensure "benchmark" is required (not null)
            if (benchmark == null)
            {
                throw new ArgumentNullException("benchmark is a required property for InitialBudgetRecommendationResponse and cannot be null");
            }
            this.Benchmark = benchmark;
            this.RecommendationId = recommendationId;
        }

        /// <summary>
        /// A list of special events around the start and end date of the campaign.
        /// </summary>
        /// <value>A list of special events around the start and end date of the campaign.</value>
        [DataMember(Name = "specialEvents", IsRequired = true, EmitDefaultValue = true)]
        public List<SpecialEvent> SpecialEvents { get; set; }

        /// <summary>
        /// Recommended daily budget for the new campaign.
        /// </summary>
        /// <value>Recommended daily budget for the new campaign.</value>
        [DataMember(Name = "dailyBudget", IsRequired = true, EmitDefaultValue = true)]
        public decimal DailyBudget { get; set; }

        /// <summary>
        /// Unique identifier for each recommendation.
        /// </summary>
        /// <value>Unique identifier for each recommendation.</value>
        [DataMember(Name = "recommendationId", EmitDefaultValue = false)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Gets or Sets Benchmark
        /// </summary>
        [DataMember(Name = "benchmark", IsRequired = true, EmitDefaultValue = true)]
        public Benchmark Benchmark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InitialBudgetRecommendationResponse {\n");
            sb.Append("  SpecialEvents: ").Append(SpecialEvents).Append("\n");
            sb.Append("  DailyBudget: ").Append(DailyBudget).Append("\n");
            sb.Append("  RecommendationId: ").Append(RecommendationId).Append("\n");
            sb.Append("  Benchmark: ").Append(Benchmark).Append("\n");
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
            return this.Equals(input as InitialBudgetRecommendationResponse);
        }

        /// <summary>
        /// Returns true if InitialBudgetRecommendationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InitialBudgetRecommendationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialBudgetRecommendationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SpecialEvents == input.SpecialEvents ||
                    this.SpecialEvents != null &&
                    input.SpecialEvents != null &&
                    this.SpecialEvents.SequenceEqual(input.SpecialEvents)
                ) &&
                (
                    this.DailyBudget == input.DailyBudget ||
                    this.DailyBudget.Equals(input.DailyBudget)
                ) &&
                (
                    this.RecommendationId == input.RecommendationId ||
                    (this.RecommendationId != null &&
                    this.RecommendationId.Equals(input.RecommendationId))
                ) &&
                (
                    this.Benchmark == input.Benchmark ||
                    (this.Benchmark != null &&
                    this.Benchmark.Equals(input.Benchmark))
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
                if (this.SpecialEvents != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialEvents.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DailyBudget.GetHashCode();
                if (this.RecommendationId != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendationId.GetHashCode();
                }
                if (this.Benchmark != null)
                {
                    hashCode = (hashCode * 59) + this.Benchmark.GetHashCode();
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
