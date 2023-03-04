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
    /// SponsoredProductsProductAd
    /// </summary>
    [DataContract(Name = "SponsoredProductsProductAd")]
    public partial class SponsoredProductsProductAd : IEquatable<SponsoredProductsProductAd>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsEntityState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsProductAd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAd" /> class.
        /// </summary>
        /// <param name="adId">The product ad identifier. (required).</param>
        /// <param name="campaignId">The campaign identifier. (required).</param>
        /// <param name="customText">The custom text that is associated with this ad. Defined for custom text ads only..</param>
        /// <param name="asin">The ASIN associated with the product. Defined for vendors only..</param>
        /// <param name="state">state (required).</param>
        /// <param name="sku">The SKU associated with the product. Defined for seller accounts only..</param>
        /// <param name="adGroupId">The ad group identifier. (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsProductAd(string adId = default(string), string campaignId = default(string), string customText = default(string), string asin = default(string), SponsoredProductsEntityState state = default(SponsoredProductsEntityState), string sku = default(string), string adGroupId = default(string), SponsoredProductsProductAdExtendedData extendedData = default(SponsoredProductsProductAdExtendedData))
        {
            // to ensure "adId" is required (not null)
            if (adId == null)
            {
                throw new ArgumentNullException("adId is a required property for SponsoredProductsProductAd and cannot be null");
            }
            this.AdId = adId;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsProductAd and cannot be null");
            }
            this.CampaignId = campaignId;
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsProductAd and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.CustomText = customText;
            this.Asin = asin;
            this.Sku = sku;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// The product ad identifier.
        /// </summary>
        /// <value>The product ad identifier.</value>
        [DataMember(Name = "adId", IsRequired = true, EmitDefaultValue = true)]
        public string AdId { get; set; }

        /// <summary>
        /// The campaign identifier.
        /// </summary>
        /// <value>The campaign identifier.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The custom text that is associated with this ad. Defined for custom text ads only.
        /// </summary>
        /// <value>The custom text that is associated with this ad. Defined for custom text ads only.</value>
        [DataMember(Name = "customText", EmitDefaultValue = false)]
        public string CustomText { get; set; }

        /// <summary>
        /// The ASIN associated with the product. Defined for vendors only.
        /// </summary>
        /// <value>The ASIN associated with the product. Defined for vendors only.</value>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public string Asin { get; set; }

        /// <summary>
        /// The SKU associated with the product. Defined for seller accounts only.
        /// </summary>
        /// <value>The SKU associated with the product. Defined for seller accounts only.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// The ad group identifier.
        /// </summary>
        /// <value>The ad group identifier.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsProductAdExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsProductAd {\n");
            sb.Append("  AdId: ").Append(AdId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CustomText: ").Append(CustomText).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
            sb.Append("  ExtendedData: ").Append(ExtendedData).Append("\n");
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
            return this.Equals(input as SponsoredProductsProductAd);
        }

        /// <summary>
        /// Returns true if SponsoredProductsProductAd instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsProductAd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsProductAd input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AdId == input.AdId ||
                    (this.AdId != null &&
                    this.AdId.Equals(input.AdId))
                ) &&
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.CustomText == input.CustomText ||
                    (this.CustomText != null &&
                    this.CustomText.Equals(input.CustomText))
                ) &&
                (
                    this.Asin == input.Asin ||
                    (this.Asin != null &&
                    this.Asin.Equals(input.Asin))
                ) &&
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) &&
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
                ) &&
                (
                    this.ExtendedData == input.ExtendedData ||
                    (this.ExtendedData != null &&
                    this.ExtendedData.Equals(input.ExtendedData))
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
                if (this.AdId != null)
                {
                    hashCode = (hashCode * 59) + this.AdId.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.CustomText != null)
                {
                    hashCode = (hashCode * 59) + this.CustomText.GetHashCode();
                }
                if (this.Asin != null)
                {
                    hashCode = (hashCode * 59) + this.Asin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
                if (this.ExtendedData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedData.GetHashCode();
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
