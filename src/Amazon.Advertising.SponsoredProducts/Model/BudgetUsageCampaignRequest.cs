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
    /// BudgetUsageCampaignRequest
    /// </summary>
    [DataContract(Name = "BudgetUsageCampaignRequest")]
    public partial class BudgetUsageCampaignRequest : IEquatable<BudgetUsageCampaignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetUsageCampaignRequest" /> class.
        /// </summary>
        /// <param name="campaignIds">A list of campaign IDs.</param>
        public BudgetUsageCampaignRequest(List<string> campaignIds = default(List<string>))
        {
            this.CampaignIds = campaignIds;
        }

        /// <summary>
        /// A list of campaign IDs
        /// </summary>
        /// <value>A list of campaign IDs</value>
        [DataMember(Name = "campaignIds", EmitDefaultValue = false)]
        public List<string> CampaignIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetUsageCampaignRequest {\n");
            sb.Append("  CampaignIds: ").Append(CampaignIds).Append("\n");
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
            return this.Equals(input as BudgetUsageCampaignRequest);
        }

        /// <summary>
        /// Returns true if BudgetUsageCampaignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetUsageCampaignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetUsageCampaignRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CampaignIds == input.CampaignIds ||
                    this.CampaignIds != null &&
                    input.CampaignIds != null &&
                    this.CampaignIds.SequenceEqual(input.CampaignIds)
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
                if (this.CampaignIds != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIds.GetHashCode();
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
