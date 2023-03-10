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
    /// ThemeBasedBidRecommendation
    /// </summary>
    [DataContract(Name = "ThemeBasedBidRecommendation")]
    public partial class ThemeBasedBidRecommendation : IEquatable<ThemeBasedBidRecommendation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", IsRequired = true, EmitDefaultValue = true)]
        public Theme Theme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeBasedBidRecommendation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThemeBasedBidRecommendation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeBasedBidRecommendation" /> class.
        /// </summary>
        /// <param name="theme">theme (required).</param>
        /// <param name="bidRecommendationsForTargetingExpressions">The bid recommendations for targeting expressions listed in the request. (required).</param>
        /// <param name="impactMetrics">impactMetrics.</param>
        public ThemeBasedBidRecommendation(Theme theme = default(Theme), List<BidRecommendationPerTargetingExpression> bidRecommendationsForTargetingExpressions = default(List<BidRecommendationPerTargetingExpression>), ImpactMetrics impactMetrics = default(ImpactMetrics))
        {
            this.Theme = theme;
            // to ensure "bidRecommendationsForTargetingExpressions" is required (not null)
            if (bidRecommendationsForTargetingExpressions == null)
            {
                throw new ArgumentNullException("bidRecommendationsForTargetingExpressions is a required property for ThemeBasedBidRecommendation and cannot be null");
            }
            this.BidRecommendationsForTargetingExpressions = bidRecommendationsForTargetingExpressions;
            this.ImpactMetrics = impactMetrics;
        }

        /// <summary>
        /// The bid recommendations for targeting expressions listed in the request.
        /// </summary>
        /// <value>The bid recommendations for targeting expressions listed in the request.</value>
        [DataMember(Name = "bidRecommendationsForTargetingExpressions", IsRequired = true, EmitDefaultValue = true)]
        public List<BidRecommendationPerTargetingExpression> BidRecommendationsForTargetingExpressions { get; set; }

        /// <summary>
        /// Gets or Sets ImpactMetrics
        /// </summary>
        [DataMember(Name = "impactMetrics", EmitDefaultValue = false)]
        public ImpactMetrics ImpactMetrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThemeBasedBidRecommendation {\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  BidRecommendationsForTargetingExpressions: ").Append(BidRecommendationsForTargetingExpressions).Append("\n");
            sb.Append("  ImpactMetrics: ").Append(ImpactMetrics).Append("\n");
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
            return this.Equals(input as ThemeBasedBidRecommendation);
        }

        /// <summary>
        /// Returns true if ThemeBasedBidRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of ThemeBasedBidRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThemeBasedBidRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Theme == input.Theme ||
                    this.Theme.Equals(input.Theme)
                ) &&
                (
                    this.BidRecommendationsForTargetingExpressions == input.BidRecommendationsForTargetingExpressions ||
                    this.BidRecommendationsForTargetingExpressions != null &&
                    input.BidRecommendationsForTargetingExpressions != null &&
                    this.BidRecommendationsForTargetingExpressions.SequenceEqual(input.BidRecommendationsForTargetingExpressions)
                ) &&
                (
                    this.ImpactMetrics == input.ImpactMetrics ||
                    (this.ImpactMetrics != null &&
                    this.ImpactMetrics.Equals(input.ImpactMetrics))
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
                hashCode = (hashCode * 59) + this.Theme.GetHashCode();
                if (this.BidRecommendationsForTargetingExpressions != null)
                {
                    hashCode = (hashCode * 59) + this.BidRecommendationsForTargetingExpressions.GetHashCode();
                }
                if (this.ImpactMetrics != null)
                {
                    hashCode = (hashCode * 59) + this.ImpactMetrics.GetHashCode();
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
