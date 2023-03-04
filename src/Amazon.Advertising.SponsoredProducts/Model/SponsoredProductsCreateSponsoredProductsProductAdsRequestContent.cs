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
    /// SponsoredProductsCreateSponsoredProductsProductAdsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsProductAdsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsProductAdsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsProductAdsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsProductAdsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsProductAdsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsProductAdsRequestContent" /> class.
        /// </summary>
        /// <param name="productAds">productAds (required).</param>
        public SponsoredProductsCreateSponsoredProductsProductAdsRequestContent(List<SponsoredProductsCreateProductAd> productAds = default(List<SponsoredProductsCreateProductAd>))
        {
            // to ensure "productAds" is required (not null)
            if (productAds == null)
            {
                throw new ArgumentNullException("productAds is a required property for SponsoredProductsCreateSponsoredProductsProductAdsRequestContent and cannot be null");
            }
            this.ProductAds = productAds;
        }

        /// <summary>
        /// Gets or Sets ProductAds
        /// </summary>
        [DataMember(Name = "productAds", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateProductAd> ProductAds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsProductAdsRequestContent {\n");
            sb.Append("  ProductAds: ").Append(ProductAds).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsProductAdsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsProductAdsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsProductAdsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsProductAdsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ProductAds == input.ProductAds ||
                    this.ProductAds != null &&
                    input.ProductAds != null &&
                    this.ProductAds.SequenceEqual(input.ProductAds)
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
                if (this.ProductAds != null)
                {
                    hashCode = (hashCode * 59) + this.ProductAds.GetHashCode();
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
