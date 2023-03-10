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
    /// SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent")]
    public partial class SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent : IEquatable<SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent" /> class.
        /// </summary>
        /// <param name="campaignIdFilter">campaignIdFilter (required).</param>
        public SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent(SponsoredProductsObjectIdFilter campaignIdFilter = default(SponsoredProductsObjectIdFilter))
        {
            // to ensure "campaignIdFilter" is required (not null)
            if (campaignIdFilter == null)
            {
                throw new ArgumentNullException("campaignIdFilter is a required property for SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent and cannot be null");
            }
            this.CampaignIdFilter = campaignIdFilter;
        }

        /// <summary>
        /// Gets or Sets CampaignIdFilter
        /// </summary>
        [DataMember(Name = "campaignIdFilter", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsObjectIdFilter CampaignIdFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent {\n");
            sb.Append("  CampaignIdFilter: ").Append(CampaignIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDeleteSponsoredProductsCampaignsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CampaignIdFilter == input.CampaignIdFilter ||
                    (this.CampaignIdFilter != null &&
                    this.CampaignIdFilter.Equals(input.CampaignIdFilter))
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
                if (this.CampaignIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIdFilter.GetHashCode();
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
