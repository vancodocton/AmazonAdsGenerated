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
    /// CreateSPCampaignOptimizationRulesResponse
    /// </summary>
    [DataContract(Name = "CreateSPCampaignOptimizationRulesResponse")]
    public partial class CreateSPCampaignOptimizationRulesResponse : IEquatable<CreateSPCampaignOptimizationRulesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSPCampaignOptimizationRulesResponse" /> class.
        /// </summary>
        /// <param name="campaignOptimizationId">The persistent rule identifier..</param>
        /// <param name="code">An enumerated success or error code for machine use..</param>
        /// <param name="details">A human-readable description of the error, if unsuccessful.</param>
        public CreateSPCampaignOptimizationRulesResponse(string campaignOptimizationId = default(string), string code = default(string), string details = default(string))
        {
            this.CampaignOptimizationId = campaignOptimizationId;
            this.Code = code;
            this.Details = details;
        }

        /// <summary>
        /// The persistent rule identifier.
        /// </summary>
        /// <value>The persistent rule identifier.</value>
        [DataMember(Name = "campaignOptimizationId", EmitDefaultValue = false)]
        public string CampaignOptimizationId { get; set; }

        /// <summary>
        /// An enumerated success or error code for machine use.
        /// </summary>
        /// <value>An enumerated success or error code for machine use.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable description of the error, if unsuccessful
        /// </summary>
        /// <value>A human-readable description of the error, if unsuccessful</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSPCampaignOptimizationRulesResponse {\n");
            sb.Append("  CampaignOptimizationId: ").Append(CampaignOptimizationId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as CreateSPCampaignOptimizationRulesResponse);
        }

        /// <summary>
        /// Returns true if CreateSPCampaignOptimizationRulesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSPCampaignOptimizationRulesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSPCampaignOptimizationRulesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampaignOptimizationId == input.CampaignOptimizationId ||
                    (this.CampaignOptimizationId != null &&
                    this.CampaignOptimizationId.Equals(input.CampaignOptimizationId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.CampaignOptimizationId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignOptimizationId.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignOptimizationId, length must be less than 355.", new [] { "CampaignOptimizationId" });
            }

            yield break;
        }
    }

}
