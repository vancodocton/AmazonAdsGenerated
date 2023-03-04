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
    /// SPCampaignOptimizationNotificationAPIResponse
    /// </summary>
    [DataContract(Name = "SPCampaignOptimizationNotificationAPIResponse")]
    public partial class SPCampaignOptimizationNotificationAPIResponse : IEquatable<SPCampaignOptimizationNotificationAPIResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPCampaignOptimizationNotificationAPIResponse" /> class.
        /// </summary>
        /// <param name="campaignOptimizationRecommendationsError">List of errors that occured when generating campaign optimization notifications..</param>
        /// <param name="campaignOptimizationNotifications">List of successful campaign optimization notifications for campaigns..</param>
        public SPCampaignOptimizationNotificationAPIResponse(List<RuleNotificationError> campaignOptimizationRecommendationsError = default(List<RuleNotificationError>), List<RuleNotification> campaignOptimizationNotifications = default(List<RuleNotification>))
        {
            this.CampaignOptimizationRecommendationsError = campaignOptimizationRecommendationsError;
            this.CampaignOptimizationNotifications = campaignOptimizationNotifications;
        }

        /// <summary>
        /// List of errors that occured when generating campaign optimization notifications.
        /// </summary>
        /// <value>List of errors that occured when generating campaign optimization notifications.</value>
        [DataMember(Name = "CampaignOptimizationRecommendationsError", EmitDefaultValue = false)]
        public List<RuleNotificationError> CampaignOptimizationRecommendationsError { get; set; }

        /// <summary>
        /// List of successful campaign optimization notifications for campaigns.
        /// </summary>
        /// <value>List of successful campaign optimization notifications for campaigns.</value>
        [DataMember(Name = "CampaignOptimizationNotifications", EmitDefaultValue = false)]
        public List<RuleNotification> CampaignOptimizationNotifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SPCampaignOptimizationNotificationAPIResponse {\n");
            sb.Append("  CampaignOptimizationRecommendationsError: ").Append(CampaignOptimizationRecommendationsError).Append("\n");
            sb.Append("  CampaignOptimizationNotifications: ").Append(CampaignOptimizationNotifications).Append("\n");
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
            return this.Equals(input as SPCampaignOptimizationNotificationAPIResponse);
        }

        /// <summary>
        /// Returns true if SPCampaignOptimizationNotificationAPIResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SPCampaignOptimizationNotificationAPIResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPCampaignOptimizationNotificationAPIResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampaignOptimizationRecommendationsError == input.CampaignOptimizationRecommendationsError ||
                    this.CampaignOptimizationRecommendationsError != null &&
                    input.CampaignOptimizationRecommendationsError != null &&
                    this.CampaignOptimizationRecommendationsError.SequenceEqual(input.CampaignOptimizationRecommendationsError)
                ) && 
                (
                    this.CampaignOptimizationNotifications == input.CampaignOptimizationNotifications ||
                    this.CampaignOptimizationNotifications != null &&
                    input.CampaignOptimizationNotifications != null &&
                    this.CampaignOptimizationNotifications.SequenceEqual(input.CampaignOptimizationNotifications)
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
                if (this.CampaignOptimizationRecommendationsError != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignOptimizationRecommendationsError.GetHashCode();
                }
                if (this.CampaignOptimizationNotifications != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignOptimizationNotifications.GetHashCode();
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
