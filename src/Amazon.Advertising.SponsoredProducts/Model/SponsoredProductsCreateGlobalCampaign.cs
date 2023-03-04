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
    /// SponsoredProductsCreateGlobalCampaign
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateGlobalCampaign")]
    public partial class SponsoredProductsCreateGlobalCampaign : IEquatable<SponsoredProductsCreateGlobalCampaign>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TargetingType
        /// </summary>
        [DataMember(Name = "targetingType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsTargetingType TargetingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateGlobalCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalCampaign" /> class.
        /// </summary>
        /// <param name="endDate">The format of the date is YYYY-MM-DD..</param>
        /// <param name="name">name (required).</param>
        /// <param name="targetingType">targetingType (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="dynamicBidding">dynamicBidding.</param>
        /// <param name="startDate">The format of the date is YYYY-MM-DD..</param>
        /// <param name="budget">budget (required).</param>
        /// <param name="tags">A list of advertiser-specified custom identifiers for the campaign. Each customer identifier is a key-value pair. You can specify a maximum of 50 identifiers..</param>
        public SponsoredProductsCreateGlobalCampaign(DateTime endDate = default(DateTime), string name = default(string), SponsoredProductsTargetingType targetingType = default(SponsoredProductsTargetingType), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsCreateOrUpdateDynamicBidding dynamicBidding = default(SponsoredProductsCreateOrUpdateDynamicBidding), DateTime startDate = default(DateTime), SponsoredProductsGlobalBudget budget = default(SponsoredProductsGlobalBudget), Dictionary<string, string> tags = default(Dictionary<string, string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SponsoredProductsCreateGlobalCampaign and cannot be null");
            }
            this.Name = name;
            this.TargetingType = targetingType;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsCreateGlobalCampaign and cannot be null");
            }
            this.State = state;
            // to ensure "budget" is required (not null)
            if (budget == null)
            {
                throw new ArgumentNullException("budget is a required property for SponsoredProductsCreateGlobalCampaign and cannot be null");
            }
            this.Budget = budget;
            this.EndDate = endDate;
            this.DynamicBidding = dynamicBidding;
            this.StartDate = startDate;
            this.Tags = tags;
        }

        /// <summary>
        /// The format of the date is YYYY-MM-DD.
        /// </summary>
        /// <value>The format of the date is YYYY-MM-DD.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

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
        [DataMember(Name = "budget", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalBudget Budget { get; set; }

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
            sb.Append("class SponsoredProductsCreateGlobalCampaign {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateGlobalCampaign);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateGlobalCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateGlobalCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateGlobalCampaign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TargetingType.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
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
