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
    /// BudgetRecommendationError
    /// </summary>
    [DataContract(Name = "BudgetRecommendationError")]
    public partial class BudgetRecommendationError : IEquatable<BudgetRecommendationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetRecommendationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetRecommendationError" /> class.
        /// </summary>
        /// <param name="campaignId">encrypted campaignId (required).</param>
        /// <param name="index">Correlate the recommendation to the campaign index in the request. Zero-based (required).</param>
        /// <param name="error">error (required).</param>
        public BudgetRecommendationError(string campaignId = default(string), int index = default(int), SPTORBudgetRecommendationError error = default(SPTORBudgetRecommendationError))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for BudgetRecommendationError and cannot be null");
            }
            this.CampaignId = campaignId;
            this.Index = index;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for BudgetRecommendationError and cannot be null");
            }
            this.Error = error;
        }

        /// <summary>
        /// encrypted campaignId
        /// </summary>
        /// <value>encrypted campaignId</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Correlate the recommendation to the campaign index in the request. Zero-based
        /// </summary>
        /// <value>Correlate the recommendation to the campaign index in the request. Zero-based</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "Error", IsRequired = true, EmitDefaultValue = true)]
        public SPTORBudgetRecommendationError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetRecommendationError {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as BudgetRecommendationError);
        }

        /// <summary>
        /// Returns true if BudgetRecommendationError instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetRecommendationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetRecommendationError input)
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
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
