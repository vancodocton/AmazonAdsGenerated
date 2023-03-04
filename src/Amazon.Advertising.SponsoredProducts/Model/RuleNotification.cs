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
    /// RuleNotification
    /// </summary>
    [DataContract(Name = "RuleNotification")]
    public partial class RuleNotification : IEquatable<RuleNotification>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RuleState
        /// </summary>
        [DataMember(Name = "ruleState", EmitDefaultValue = false)]
        public RuleState? RuleState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleNotification" /> class.
        /// </summary>
        /// <param name="ruleState">ruleState.</param>
        /// <param name="campaignOptimizationId">The persistent rule identifier..</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="notificationString">Explains why the rule state is disabled.</param>
        public RuleNotification(RuleState? ruleState = default(RuleState?), string campaignOptimizationId = default(string), string campaignId = default(string), string notificationString = default(string))
        {
            this.RuleState = ruleState;
            this.CampaignOptimizationId = campaignOptimizationId;
            this.CampaignId = campaignId;
            this.NotificationString = notificationString;
        }

        /// <summary>
        /// The persistent rule identifier.
        /// </summary>
        /// <value>The persistent rule identifier.</value>
        [DataMember(Name = "campaignOptimizationId", EmitDefaultValue = false)]
        public string CampaignOptimizationId { get; set; }

        /// <summary>
        /// campaignId
        /// </summary>
        /// <value>campaignId</value>
        [DataMember(Name = "campaignId", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Explains why the rule state is disabled
        /// </summary>
        /// <value>Explains why the rule state is disabled</value>
        [DataMember(Name = "notificationString", EmitDefaultValue = false)]
        public string NotificationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleNotification {\n");
            sb.Append("  RuleState: ").Append(RuleState).Append("\n");
            sb.Append("  CampaignOptimizationId: ").Append(CampaignOptimizationId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  NotificationString: ").Append(NotificationString).Append("\n");
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
            return this.Equals(input as RuleNotification);
        }

        /// <summary>
        /// Returns true if RuleNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RuleState == input.RuleState ||
                    this.RuleState.Equals(input.RuleState)
                ) &&
                (
                    this.CampaignOptimizationId == input.CampaignOptimizationId ||
                    (this.CampaignOptimizationId != null &&
                    this.CampaignOptimizationId.Equals(input.CampaignOptimizationId))
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.NotificationString == input.NotificationString ||
                    (this.NotificationString != null &&
                    this.NotificationString.Equals(input.NotificationString))
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
                hashCode = (hashCode * 59) + this.RuleState.GetHashCode();
                if (this.CampaignOptimizationId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignOptimizationId.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.NotificationString != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationString.GetHashCode();
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
            // CampaignOptimizationId (string) maxLength
            if (this.CampaignOptimizationId != null && this.CampaignOptimizationId.Length > 355)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignOptimizationId, length must be less than 355.", new[] { "CampaignOptimizationId" });
            }

            yield break;
        }
    }

}
