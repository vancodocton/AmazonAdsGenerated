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
    /// BudgetUsageCampaign
    /// </summary>
    [DataContract(Name = "BudgetUsageCampaign")]
    public partial class BudgetUsageCampaign : IEquatable<BudgetUsageCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetUsageCampaign" /> class.
        /// </summary>
        /// <param name="budgetUsagePercent">Budget usage percentage (spend / available budget) for the given budget policy..</param>
        /// <param name="campaignId">ID of requested resource.</param>
        /// <param name="usageUpdatedTimestamp">Last evaluation time for budget usage.</param>
        /// <param name="index">An index to maintain order of the campaignIds.</param>
        /// <param name="budget">Budget amount of resource requested.</param>
        public BudgetUsageCampaign(decimal budgetUsagePercent = default(decimal), string campaignId = default(string), DateTime usageUpdatedTimestamp = default(DateTime), decimal index = default(decimal), decimal budget = default(decimal))
        {
            this.BudgetUsagePercent = budgetUsagePercent;
            this.CampaignId = campaignId;
            this.UsageUpdatedTimestamp = usageUpdatedTimestamp;
            this.Index = index;
            this.Budget = budget;
        }

        /// <summary>
        /// Budget usage percentage (spend / available budget) for the given budget policy.
        /// </summary>
        /// <value>Budget usage percentage (spend / available budget) for the given budget policy.</value>
        [DataMember(Name = "budgetUsagePercent", EmitDefaultValue = false)]
        public decimal BudgetUsagePercent { get; set; }

        /// <summary>
        /// ID of requested resource
        /// </summary>
        /// <value>ID of requested resource</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Last evaluation time for budget usage
        /// </summary>
        /// <value>Last evaluation time for budget usage</value>
        [DataMember(Name = "usageUpdatedTimestamp", EmitDefaultValue = false)]
        public DateTime UsageUpdatedTimestamp { get; set; }

        /// <summary>
        /// An index to maintain order of the campaignIds
        /// </summary>
        /// <value>An index to maintain order of the campaignIds</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public decimal Index { get; set; }

        /// <summary>
        /// Budget amount of resource requested
        /// </summary>
        /// <value>Budget amount of resource requested</value>
        [DataMember(Name = "budget", EmitDefaultValue = false)]
        public decimal Budget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetUsageCampaign {\n");
            sb.Append("  BudgetUsagePercent: ").Append(BudgetUsagePercent).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  UsageUpdatedTimestamp: ").Append(UsageUpdatedTimestamp).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
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
            return this.Equals(input as BudgetUsageCampaign);
        }

        /// <summary>
        /// Returns true if BudgetUsageCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetUsageCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetUsageCampaign input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BudgetUsagePercent == input.BudgetUsagePercent ||
                    this.BudgetUsagePercent.Equals(input.BudgetUsagePercent)
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.UsageUpdatedTimestamp == input.UsageUpdatedTimestamp ||
                    (this.UsageUpdatedTimestamp != null &&
                    this.UsageUpdatedTimestamp.Equals(input.UsageUpdatedTimestamp))
                ) &&
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) &&
                (
                    this.Budget == input.Budget ||
                    this.Budget.Equals(input.Budget)
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
                hashCode = (hashCode * 59) + this.BudgetUsagePercent.GetHashCode();
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.UsageUpdatedTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.UsageUpdatedTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Budget.GetHashCode();
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
