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
    /// Bidding control configuration for the campaign.
    /// </summary>
    [DataContract(Name = "AsinsThemeBasedBidRecommendationRequest_bidding")]
    public partial class AsinsThemeBasedBidRecommendationRequestBidding : IEquatable<AsinsThemeBasedBidRecommendationRequestBidding>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", IsRequired = true, EmitDefaultValue = true)]
        public BiddingStrategy Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsinsThemeBasedBidRecommendationRequestBidding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AsinsThemeBasedBidRecommendationRequestBidding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsinsThemeBasedBidRecommendationRequestBidding" /> class.
        /// </summary>
        /// <param name="adjustments">Placement adjustment configuration for the campaign..</param>
        /// <param name="strategy">strategy (required).</param>
        public AsinsThemeBasedBidRecommendationRequestBidding(List<PlacementAdjustment> adjustments = default(List<PlacementAdjustment>), BiddingStrategy strategy = default(BiddingStrategy))
        {
            this.Strategy = strategy;
            this.Adjustments = adjustments;
        }

        /// <summary>
        /// Placement adjustment configuration for the campaign.
        /// </summary>
        /// <value>Placement adjustment configuration for the campaign.</value>
        [DataMember(Name = "adjustments", EmitDefaultValue = false)]
        public List<PlacementAdjustment> Adjustments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsinsThemeBasedBidRecommendationRequestBidding {\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
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
            return this.Equals(input as AsinsThemeBasedBidRecommendationRequestBidding);
        }

        /// <summary>
        /// Returns true if AsinsThemeBasedBidRecommendationRequestBidding instances are equal
        /// </summary>
        /// <param name="input">Instance of AsinsThemeBasedBidRecommendationRequestBidding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsinsThemeBasedBidRecommendationRequestBidding input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Adjustments == input.Adjustments ||
                    this.Adjustments != null &&
                    input.Adjustments != null &&
                    this.Adjustments.SequenceEqual(input.Adjustments)
                ) &&
                (
                    this.Strategy == input.Strategy ||
                    this.Strategy.Equals(input.Strategy)
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
                if (this.Adjustments != null)
                {
                    hashCode = (hashCode * 59) + this.Adjustments.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
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
