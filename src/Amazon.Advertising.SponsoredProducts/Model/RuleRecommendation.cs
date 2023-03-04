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
    /// RuleRecommendation
    /// </summary>
    [DataContract(Name = "RuleRecommendation")]
    public partial class RuleRecommendation : IEquatable<RuleRecommendation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleRecommendation" /> class.
        /// </summary>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="performanceMetrics">performanceMetrics.</param>
        public RuleRecommendation(string campaignId = default(string), RuleRecommendationMetrics performanceMetrics = default(RuleRecommendationMetrics))
        {
            this.CampaignId = campaignId;
            this.PerformanceMetrics = performanceMetrics;
        }

        /// <summary>
        /// campaignId
        /// </summary>
        /// <value>campaignId</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceMetrics
        /// </summary>
        [DataMember(Name = "performanceMetrics", EmitDefaultValue = false)]
        public RuleRecommendationMetrics PerformanceMetrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleRecommendation {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  PerformanceMetrics: ").Append(PerformanceMetrics).Append("\n");
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
            return this.Equals(input as RuleRecommendation);
        }

        /// <summary>
        /// Returns true if RuleRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.PerformanceMetrics == input.PerformanceMetrics ||
                    (this.PerformanceMetrics != null &&
                    this.PerformanceMetrics.Equals(input.PerformanceMetrics))
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
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.PerformanceMetrics != null)
                {
                    hashCode = (hashCode * 59) + this.PerformanceMetrics.GetHashCode();
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
