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
    /// This object contains a set of recommendations for a campaign across bid, budget, targeting.
    /// </summary>
    [DataContract(Name = "CampaignRecommendation")]
    public partial class CampaignRecommendation : IEquatable<CampaignRecommendation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRecommendation" /> class.
        /// </summary>
        /// <param name="sevenDaysEstimatedOpportunities">sevenDaysEstimatedOpportunities.</param>
        /// <param name="biddingStrategyRecommendation">biddingStrategyRecommendation.</param>
        /// <param name="campaignId">The identifier of the campaign..</param>
        /// <param name="keywordTargetingRecommendations">keywordTargetingRecommendations.</param>
        /// <param name="budgetRecommendation">budgetRecommendation.</param>
        /// <param name="targetingGroupBidRecommendations">targetingGroupBidRecommendations.</param>
        public CampaignRecommendation(SevenDaysEstimatedOpportunities sevenDaysEstimatedOpportunities = default(SevenDaysEstimatedOpportunities), BiddingStrategyRecommendation biddingStrategyRecommendation = default(BiddingStrategyRecommendation), string campaignId = default(string), List<KeywordTargetingRecommendation> keywordTargetingRecommendations = default(List<KeywordTargetingRecommendation>), BudgetRecommendation budgetRecommendation = default(BudgetRecommendation), List<TargetingGroupBidRecommendation> targetingGroupBidRecommendations = default(List<TargetingGroupBidRecommendation>))
        {
            this.SevenDaysEstimatedOpportunities = sevenDaysEstimatedOpportunities;
            this.BiddingStrategyRecommendation = biddingStrategyRecommendation;
            this.CampaignId = campaignId;
            this.KeywordTargetingRecommendations = keywordTargetingRecommendations;
            this.BudgetRecommendation = budgetRecommendation;
            this.TargetingGroupBidRecommendations = targetingGroupBidRecommendations;
        }

        /// <summary>
        /// Gets or Sets SevenDaysEstimatedOpportunities
        /// </summary>
        [DataMember(Name = "sevenDaysEstimatedOpportunities", EmitDefaultValue = false)]
        public SevenDaysEstimatedOpportunities SevenDaysEstimatedOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets BiddingStrategyRecommendation
        /// </summary>
        [DataMember(Name = "biddingStrategyRecommendation", EmitDefaultValue = false)]
        public BiddingStrategyRecommendation BiddingStrategyRecommendation { get; set; }

        /// <summary>
        /// The identifier of the campaign.
        /// </summary>
        /// <value>The identifier of the campaign.</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets KeywordTargetingRecommendations
        /// </summary>
        [DataMember(Name = "keywordTargetingRecommendations", EmitDefaultValue = false)]
        public List<KeywordTargetingRecommendation> KeywordTargetingRecommendations { get; set; }

        /// <summary>
        /// Gets or Sets BudgetRecommendation
        /// </summary>
        [DataMember(Name = "budgetRecommendation", EmitDefaultValue = false)]
        public BudgetRecommendation BudgetRecommendation { get; set; }

        /// <summary>
        /// Gets or Sets TargetingGroupBidRecommendations
        /// </summary>
        [DataMember(Name = "targetingGroupBidRecommendations", EmitDefaultValue = false)]
        public List<TargetingGroupBidRecommendation> TargetingGroupBidRecommendations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CampaignRecommendation {\n");
            sb.Append("  SevenDaysEstimatedOpportunities: ").Append(SevenDaysEstimatedOpportunities).Append("\n");
            sb.Append("  BiddingStrategyRecommendation: ").Append(BiddingStrategyRecommendation).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  KeywordTargetingRecommendations: ").Append(KeywordTargetingRecommendations).Append("\n");
            sb.Append("  BudgetRecommendation: ").Append(BudgetRecommendation).Append("\n");
            sb.Append("  TargetingGroupBidRecommendations: ").Append(TargetingGroupBidRecommendations).Append("\n");
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
            return this.Equals(input as CampaignRecommendation);
        }

        /// <summary>
        /// Returns true if CampaignRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SevenDaysEstimatedOpportunities == input.SevenDaysEstimatedOpportunities ||
                    (this.SevenDaysEstimatedOpportunities != null &&
                    this.SevenDaysEstimatedOpportunities.Equals(input.SevenDaysEstimatedOpportunities))
                ) &&
                (
                    this.BiddingStrategyRecommendation == input.BiddingStrategyRecommendation ||
                    (this.BiddingStrategyRecommendation != null &&
                    this.BiddingStrategyRecommendation.Equals(input.BiddingStrategyRecommendation))
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.KeywordTargetingRecommendations == input.KeywordTargetingRecommendations ||
                    this.KeywordTargetingRecommendations != null &&
                    input.KeywordTargetingRecommendations != null &&
                    this.KeywordTargetingRecommendations.SequenceEqual(input.KeywordTargetingRecommendations)
                ) &&
                (
                    this.BudgetRecommendation == input.BudgetRecommendation ||
                    (this.BudgetRecommendation != null &&
                    this.BudgetRecommendation.Equals(input.BudgetRecommendation))
                ) &&
                (
                    this.TargetingGroupBidRecommendations == input.TargetingGroupBidRecommendations ||
                    this.TargetingGroupBidRecommendations != null &&
                    input.TargetingGroupBidRecommendations != null &&
                    this.TargetingGroupBidRecommendations.SequenceEqual(input.TargetingGroupBidRecommendations)
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
                if (this.SevenDaysEstimatedOpportunities != null)
                {
                    hashCode = (hashCode * 59) + this.SevenDaysEstimatedOpportunities.GetHashCode();
                }
                if (this.BiddingStrategyRecommendation != null)
                {
                    hashCode = (hashCode * 59) + this.BiddingStrategyRecommendation.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.KeywordTargetingRecommendations != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordTargetingRecommendations.GetHashCode();
                }
                if (this.BudgetRecommendation != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetRecommendation.GetHashCode();
                }
                if (this.TargetingGroupBidRecommendations != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingGroupBidRecommendations.GetHashCode();
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
