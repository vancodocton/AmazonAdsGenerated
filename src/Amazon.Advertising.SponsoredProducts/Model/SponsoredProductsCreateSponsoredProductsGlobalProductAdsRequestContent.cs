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
    /// SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent" /> class.
        /// </summary>
        /// <param name="productAds">An array of ads..</param>
        public SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent(List<SponsoredProductsCreateGlobalProductAd> productAds = default(List<SponsoredProductsCreateGlobalProductAd>))
        {
            this.ProductAds = productAds;
        }

        /// <summary>
        /// An array of ads.
        /// </summary>
        /// <value>An array of ads.</value>
        [DataMember(Name = "productAds", EmitDefaultValue = false)]
        public List<SponsoredProductsCreateGlobalProductAd> ProductAds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent {\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsGlobalProductAdsRequestContent input)
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
