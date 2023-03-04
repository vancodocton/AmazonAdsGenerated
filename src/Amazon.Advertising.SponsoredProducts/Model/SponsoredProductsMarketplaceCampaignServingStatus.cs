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
    /// SponsoredProductsMarketplaceCampaignServingStatus
    /// </summary>
    [DataContract(Name = "SponsoredProductsMarketplaceCampaignServingStatus")]
    public partial class SponsoredProductsMarketplaceCampaignServingStatus : IEquatable<SponsoredProductsMarketplaceCampaignServingStatus>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets ServingStatus
        /// </summary>
        [DataMember(Name = "servingStatus", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalCampaignMarketplaceServingStatus ServingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceCampaignServingStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsMarketplaceCampaignServingStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsMarketplaceCampaignServingStatus" /> class.
        /// </summary>
        /// <param name="statusReasons">statusReasons.</param>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="servingStatus">servingStatus (required).</param>
        public SponsoredProductsMarketplaceCampaignServingStatus(List<SponsoredProductsGlobalCampaignMarketplaceServingReason> statusReasons = default(List<SponsoredProductsGlobalCampaignMarketplaceServingReason>), SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), SponsoredProductsGlobalCampaignMarketplaceServingStatus servingStatus = default(SponsoredProductsGlobalCampaignMarketplaceServingStatus))
        {
            this.ServingStatus = servingStatus;
            this.StatusReasons = statusReasons;
            this.Marketplace = marketplace;
        }

        /// <summary>
        /// Gets or Sets StatusReasons
        /// </summary>
        [DataMember(Name = "statusReasons", EmitDefaultValue = false)]
        public List<SponsoredProductsGlobalCampaignMarketplaceServingReason> StatusReasons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsMarketplaceCampaignServingStatus {\n");
            sb.Append("  StatusReasons: ").Append(StatusReasons).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  ServingStatus: ").Append(ServingStatus).Append("\n");
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
            return this.Equals(input as SponsoredProductsMarketplaceCampaignServingStatus);
        }

        /// <summary>
        /// Returns true if SponsoredProductsMarketplaceCampaignServingStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsMarketplaceCampaignServingStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsMarketplaceCampaignServingStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusReasons == input.StatusReasons ||
                    this.StatusReasons != null &&
                    input.StatusReasons != null &&
                    this.StatusReasons.SequenceEqual(input.StatusReasons)
                ) && 
                (
                    this.Marketplace == input.Marketplace ||
                    this.Marketplace.Equals(input.Marketplace)
                ) && 
                (
                    this.ServingStatus == input.ServingStatus ||
                    this.ServingStatus.Equals(input.ServingStatus)
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
                if (this.StatusReasons != null)
                {
                    hashCode = (hashCode * 59) + this.StatusReasons.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                hashCode = (hashCode * 59) + this.ServingStatus.GetHashCode();
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
