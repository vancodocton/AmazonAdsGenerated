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
    /// SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent")]
    public partial class SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent : IEquatable<SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent" /> class.
        /// </summary>
        /// <param name="campaignNegativeTargetIdFilter">campaignNegativeTargetIdFilter (required).</param>
        public SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent(SponsoredProductsObjectIdFilter campaignNegativeTargetIdFilter = default(SponsoredProductsObjectIdFilter))
        {
            // to ensure "campaignNegativeTargetIdFilter" is required (not null)
            if (campaignNegativeTargetIdFilter == null)
            {
                throw new ArgumentNullException("campaignNegativeTargetIdFilter is a required property for SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent and cannot be null");
            }
            this.CampaignNegativeTargetIdFilter = campaignNegativeTargetIdFilter;
        }

        /// <summary>
        /// Gets or Sets CampaignNegativeTargetIdFilter
        /// </summary>
        [DataMember(Name = "campaignNegativeTargetIdFilter", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsObjectIdFilter CampaignNegativeTargetIdFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent {\n");
            sb.Append("  CampaignNegativeTargetIdFilter: ").Append(CampaignNegativeTargetIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDeleteSponsoredProductsCampaignNegativeTargetingClausesRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CampaignNegativeTargetIdFilter == input.CampaignNegativeTargetIdFilter ||
                    (this.CampaignNegativeTargetIdFilter != null &&
                    this.CampaignNegativeTargetIdFilter.Equals(input.CampaignNegativeTargetIdFilter))
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
                if (this.CampaignNegativeTargetIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignNegativeTargetIdFilter.GetHashCode();
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
