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
    /// SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent")]
    public partial class SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent : IEquatable<SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent" /> class.
        /// </summary>
        /// <param name="campaignNegativeTargetingClauses">campaignNegativeTargetingClauses (required).</param>
        public SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent(SponsoredProductsBulkCampaignNegativeTargetingClauseOperationResponse campaignNegativeTargetingClauses = default(SponsoredProductsBulkCampaignNegativeTargetingClauseOperationResponse))
        {
            // to ensure "campaignNegativeTargetingClauses" is required (not null)
            if (campaignNegativeTargetingClauses == null)
            {
                throw new ArgumentNullException("campaignNegativeTargetingClauses is a required property for SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent and cannot be null");
            }
            this.CampaignNegativeTargetingClauses = campaignNegativeTargetingClauses;
        }

        /// <summary>
        /// Gets or Sets CampaignNegativeTargetingClauses
        /// </summary>
        [DataMember(Name = "campaignNegativeTargetingClauses", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBulkCampaignNegativeTargetingClauseOperationResponse CampaignNegativeTargetingClauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent {\n");
            sb.Append("  CampaignNegativeTargetingClauses: ").Append(CampaignNegativeTargetingClauses).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsCampaignNegativeTargetingClausesResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CampaignNegativeTargetingClauses == input.CampaignNegativeTargetingClauses ||
                    (this.CampaignNegativeTargetingClauses != null &&
                    this.CampaignNegativeTargetingClauses.Equals(input.CampaignNegativeTargetingClauses))
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
                if (this.CampaignNegativeTargetingClauses != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignNegativeTargetingClauses.GetHashCode();
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
