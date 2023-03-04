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
    /// SponsoredProductsProductAdSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsProductAdSuccessResponseItem")]
    public partial class SponsoredProductsProductAdSuccessResponseItem : IEquatable<SponsoredProductsProductAdSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsProductAdSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="adId">the ProductAd ID.</param>
        /// <param name="index">The index in the original list from the request. (required).</param>
        /// <param name="productAd">productAd.</param>
        public SponsoredProductsProductAdSuccessResponseItem(string adId = default(string), int index = default(int), SponsoredProductsProductAd productAd = default(SponsoredProductsProductAd))
        {
            this.Index = index;
            this.AdId = adId;
            this.ProductAd = productAd;
        }

        /// <summary>
        /// the ProductAd ID
        /// </summary>
        /// <value>the ProductAd ID</value>
        [DataMember(Name = "adId", EmitDefaultValue = false)]
        public string AdId { get; set; }

        /// <summary>
        /// The index in the original list from the request.
        /// </summary>
        /// <value>The index in the original list from the request.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets ProductAd
        /// </summary>
        [DataMember(Name = "productAd", EmitDefaultValue = false)]
        public SponsoredProductsProductAd ProductAd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsProductAdSuccessResponseItem {\n");
            sb.Append("  AdId: ").Append(AdId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  ProductAd: ").Append(ProductAd).Append("\n");
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
            return this.Equals(input as SponsoredProductsProductAdSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsProductAdSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsProductAdSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsProductAdSuccessResponseItem input)
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
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) &&
                (
                    this.ProductAd == input.ProductAd ||
                    (this.ProductAd != null &&
                    this.ProductAd.Equals(input.ProductAd))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.ProductAd != null)
                {
                    hashCode = (hashCode * 59) + this.ProductAd.GetHashCode();
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
            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new[] { "Index" });
            }

            yield break;
        }
    }

}
