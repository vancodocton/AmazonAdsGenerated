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
    /// SponsoredProductsCreateGlobalProductAd
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateGlobalProductAd")]
    public partial class SponsoredProductsCreateGlobalProductAd : IEquatable<SponsoredProductsCreateGlobalProductAd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalProductAd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateGlobalProductAd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalProductAd" /> class.
        /// </summary>
        /// <param name="campaignId">The campaign identifier. (required).</param>
        /// <param name="customText">The custom text to use for creating a custom text ad for the associated ASIN. Defined for only KDP Authors and Book Vendors.</param>
        /// <param name="name">Name for the product Ad.</param>
        /// <param name="asin">asin.</param>
        /// <param name="state">state (required).</param>
        /// <param name="sku">sku.</param>
        /// <param name="adGroupId">The ad group identifier. (required).</param>
        public SponsoredProductsCreateGlobalProductAd(string campaignId = default(string), string customText = default(string), string name = default(string), SponsoredProductsGlobalProductIdentifiers asin = default(SponsoredProductsGlobalProductIdentifiers), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsGlobalProductIdentifiers sku = default(SponsoredProductsGlobalProductIdentifiers), string adGroupId = default(string))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateGlobalProductAd and cannot be null");
            }
            this.CampaignId = campaignId;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsCreateGlobalProductAd and cannot be null");
            }
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsCreateGlobalProductAd and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.CustomText = customText;
            this.Name = name;
            this.Asin = asin;
            this.Sku = sku;
        }

        /// <summary>
        /// The campaign identifier.
        /// </summary>
        /// <value>The campaign identifier.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The custom text to use for creating a custom text ad for the associated ASIN. Defined for only KDP Authors and Book Vendors
        /// </summary>
        /// <value>The custom text to use for creating a custom text ad for the associated ASIN. Defined for only KDP Authors and Book Vendors</value>
        [DataMember(Name = "customText", EmitDefaultValue = false)]
        public string CustomText { get; set; }

        /// <summary>
        /// Name for the product Ad
        /// </summary>
        /// <value>Name for the product Ad</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Asin
        /// </summary>
        [DataMember(Name = "asin", EmitDefaultValue = false)]
        public SponsoredProductsGlobalProductIdentifiers Asin { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public SponsoredProductsGlobalProductIdentifiers Sku { get; set; }

        /// <summary>
        /// The ad group identifier.
        /// </summary>
        /// <value>The ad group identifier.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateGlobalProductAd {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CustomText: ").Append(CustomText).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateGlobalProductAd);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateGlobalProductAd instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateGlobalProductAd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateGlobalProductAd input)
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
                    this.CustomText == input.CustomText ||
                    (this.CustomText != null &&
                    this.CustomText.Equals(input.CustomText))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Asin == input.Asin ||
                    (this.Asin != null &&
                    this.Asin.Equals(input.Asin))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.CustomText != null)
                {
                    hashCode = (hashCode * 59) + this.CustomText.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Asin != null)
                {
                    hashCode = (hashCode * 59) + this.Asin.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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
            // CustomText (string) maxLength
            if (this.CustomText != null && this.CustomText.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomText, length must be less than 150.", new[] { "CustomText" });
            }

            // CustomText (string) minLength
            if (this.CustomText != null && this.CustomText.Length < 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomText, length must be greater than 50.", new[] { "CustomText" });
            }

            // CustomText (string) pattern
            Regex regexCustomText = new Regex(@"^[A-Z][^<>\\^]+", RegexOptions.CultureInvariant);
            if (false == regexCustomText.Match(this.CustomText).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomText, must match a pattern of " + regexCustomText, new[] { "CustomText" });
            }

            yield break;
        }
    }

}
