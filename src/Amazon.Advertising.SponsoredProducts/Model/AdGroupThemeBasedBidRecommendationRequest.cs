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
    /// AdGroupThemeBasedBidRecommendationRequest
    /// </summary>
    [DataContract(Name = "AdGroupThemeBasedBidRecommendationRequest")]
    public partial class AdGroupThemeBasedBidRecommendationRequest : IEquatable<AdGroupThemeBasedBidRecommendationRequest>, IValidatableObject
    {
        /// <summary>
        /// The bid recommendation type.
        /// </summary>
        /// <value>The bid recommendation type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecommendationTypeEnum
        {
            /// <summary>
            /// Enum BIDSFOREXISTINGADGROUP for value: BIDS_FOR_EXISTING_AD_GROUP
            /// </summary>
            [EnumMember(Value = "BIDS_FOR_EXISTING_AD_GROUP")]
            BIDSFOREXISTINGADGROUP = 1

        }


        /// <summary>
        /// The bid recommendation type.
        /// </summary>
        /// <value>The bid recommendation type.</value>
        [DataMember(Name = "recommendationType", IsRequired = true, EmitDefaultValue = true)]
        public RecommendationTypeEnum RecommendationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdGroupThemeBasedBidRecommendationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdGroupThemeBasedBidRecommendationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdGroupThemeBasedBidRecommendationRequest" /> class.
        /// </summary>
        /// <param name="targetingExpressions">The list of targeting expressions. Maximum of 100 per request, use pagination for more if needed. (required).</param>
        /// <param name="campaignId">The campaign identifier. (required).</param>
        /// <param name="recommendationType">The bid recommendation type. (required).</param>
        /// <param name="adGroupId">The ad group identifier. (required).</param>
        public AdGroupThemeBasedBidRecommendationRequest(List<TargetingExpression> targetingExpressions = default(List<TargetingExpression>), string campaignId = default(string), RecommendationTypeEnum recommendationType = default(RecommendationTypeEnum), string adGroupId = default(string))
        {
            // to ensure "targetingExpressions" is required (not null)
            if (targetingExpressions == null)
            {
                throw new ArgumentNullException("targetingExpressions is a required property for AdGroupThemeBasedBidRecommendationRequest and cannot be null");
            }
            this.TargetingExpressions = targetingExpressions;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for AdGroupThemeBasedBidRecommendationRequest and cannot be null");
            }
            this.CampaignId = campaignId;
            this.RecommendationType = recommendationType;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for AdGroupThemeBasedBidRecommendationRequest and cannot be null");
            }
            this.AdGroupId = adGroupId;
        }

        /// <summary>
        /// The list of targeting expressions. Maximum of 100 per request, use pagination for more if needed.
        /// </summary>
        /// <value>The list of targeting expressions. Maximum of 100 per request, use pagination for more if needed.</value>
        [DataMember(Name = "targetingExpressions", IsRequired = true, EmitDefaultValue = true)]
        public List<TargetingExpression> TargetingExpressions { get; set; }

        /// <summary>
        /// The campaign identifier.
        /// </summary>
        /// <value>The campaign identifier.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The ad group identifier.
        /// </summary>
        /// <value>The ad group identifier.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdGroupThemeBasedBidRecommendationRequest {\n");
            sb.Append("  TargetingExpressions: ").Append(TargetingExpressions).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  RecommendationType: ").Append(RecommendationType).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as AdGroupThemeBasedBidRecommendationRequest);
        }

        /// <summary>
        /// Returns true if AdGroupThemeBasedBidRecommendationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdGroupThemeBasedBidRecommendationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdGroupThemeBasedBidRecommendationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TargetingExpressions == input.TargetingExpressions ||
                    this.TargetingExpressions != null &&
                    input.TargetingExpressions != null &&
                    this.TargetingExpressions.SequenceEqual(input.TargetingExpressions)
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.RecommendationType == input.RecommendationType ||
                    this.RecommendationType.Equals(input.RecommendationType)
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                if (this.TargetingExpressions != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingExpressions.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecommendationType.GetHashCode();
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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
