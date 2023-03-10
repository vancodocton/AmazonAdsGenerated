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
    /// SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent" /> class.
        /// </summary>
        /// <param name="campaigns">An array of campaigns. (required).</param>
        public SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent(List<SponsoredProductsCreateGlobalCampaign> campaigns = default(List<SponsoredProductsCreateGlobalCampaign>))
        {
            // to ensure "campaigns" is required (not null)
            if (campaigns == null)
            {
                throw new ArgumentNullException("campaigns is a required property for SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent and cannot be null");
            }
            this.Campaigns = campaigns;
        }

        /// <summary>
        /// An array of campaigns.
        /// </summary>
        /// <value>An array of campaigns.</value>
        [DataMember(Name = "campaigns", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateGlobalCampaign> Campaigns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent {\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsGlobalCampaignsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Campaigns == input.Campaigns ||
                    this.Campaigns != null &&
                    input.Campaigns != null &&
                    this.Campaigns.SequenceEqual(input.Campaigns)
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
                if (this.Campaigns != null)
                {
                    hashCode = (hashCode * 59) + this.Campaigns.GetHashCode();
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
