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
    /// SponsoredProductsUpdateCampaign
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateCampaign")]
    public partial class SponsoredProductsUpdateCampaign : IEquatable<SponsoredProductsUpdateCampaign>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TargetingType
        /// </summary>
        [DataMember(Name = "targetingType", EmitDefaultValue = false)]
        public SponsoredProductsTargetingType? TargetingType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateCampaign" /> class.
        /// </summary>
        /// <param name="portfolioId">The identifier of an existing portfolio to which the campaign is associated..</param>
        /// <param name="endDate">The format of the date is YYYY-MM-DD..</param>
        /// <param name="campaignId">entity object identifier (required).</param>
        /// <param name="name">The name of the campaign..</param>
        /// <param name="targetingType">targetingType.</param>
        /// <param name="state">state.</param>
        /// <param name="dynamicBidding">dynamicBidding.</param>
        /// <param name="startDate">The format of the date is YYYY-MM-DD..</param>
        /// <param name="budget">budget.</param>
        /// <param name="tags">A list of advertiser-specified custom identifiers for the campaign. Each customer identifier is a key-value pair. You can specify a maximum of 50 identifiers..</param>
        public SponsoredProductsUpdateCampaign(string portfolioId = default(string), DateTime? endDate = default(DateTime?), string campaignId = default(string), string name = default(string), SponsoredProductsTargetingType? targetingType = default(SponsoredProductsTargetingType?), SponsoredProductsCreateOrUpdateEntityState? state = default(SponsoredProductsCreateOrUpdateEntityState?), SponsoredProductsCreateOrUpdateDynamicBidding dynamicBidding = default(SponsoredProductsCreateOrUpdateDynamicBidding), DateTime startDate = default(DateTime), SponsoredProductsCreateOrUpdateBudget budget = default(SponsoredProductsCreateOrUpdateBudget), Dictionary<string, string> tags = default(Dictionary<string, string>))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsUpdateCampaign and cannot be null");
            }
            this.CampaignId = campaignId;
            this.PortfolioId = portfolioId;
            this.EndDate = endDate;
            this.Name = name;
            this.TargetingType = targetingType;
            this.State = state;
            this.DynamicBidding = dynamicBidding;
            this.StartDate = startDate;
            this.Budget = budget;
            this.Tags = tags;
        }

        /// <summary>
        /// The identifier of an existing portfolio to which the campaign is associated.
        /// </summary>
        /// <value>The identifier of an existing portfolio to which the campaign is associated.</value>
        [DataMember(Name = "portfolioId", EmitDefaultValue = true)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The format of the date is YYYY-MM-DD.
        /// </summary>
        /// <value>The format of the date is YYYY-MM-DD.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DynamicBidding
        /// </summary>
        [DataMember(Name = "dynamicBidding", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateDynamicBidding DynamicBidding { get; set; }

        /// <summary>
        /// The format of the date is YYYY-MM-DD.
        /// </summary>
        /// <value>The format of the date is YYYY-MM-DD.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Budget
        /// </summary>
        [DataMember(Name = "budget", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateBudget Budget { get; set; }

        /// <summary>
        /// A list of advertiser-specified custom identifiers for the campaign. Each customer identifier is a key-value pair. You can specify a maximum of 50 identifiers.
        /// </summary>
        /// <value>A list of advertiser-specified custom identifiers for the campaign. Each customer identifier is a key-value pair. You can specify a maximum of 50 identifiers.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateCampaign {\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TargetingType: ").Append(TargetingType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DynamicBidding: ").Append(DynamicBidding).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateCampaign);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateCampaign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TargetingType == input.TargetingType ||
                    this.TargetingType.Equals(input.TargetingType)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.DynamicBidding == input.DynamicBidding ||
                    (this.DynamicBidding != null &&
                    this.DynamicBidding.Equals(input.DynamicBidding))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Budget == input.Budget ||
                    (this.Budget != null &&
                    this.Budget.Equals(input.Budget))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.PortfolioId != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioId.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TargetingType.GetHashCode();
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.DynamicBidding != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicBidding.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.Budget != null)
                {
                    hashCode = (hashCode * 59) + this.Budget.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
