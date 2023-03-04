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
    /// SponsoredProductsUpdateGlobalProductAd
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateGlobalProductAd")]
    public partial class SponsoredProductsUpdateGlobalProductAd : IEquatable<SponsoredProductsUpdateGlobalProductAd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalProductAd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateGlobalProductAd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalProductAd" /> class.
        /// </summary>
        /// <param name="adId">The product ad identifier. (required).</param>
        /// <param name="name">Name for the product Ad.</param>
        /// <param name="asin">asin.</param>
        /// <param name="state">state.</param>
        /// <param name="sku">sku.</param>
        public SponsoredProductsUpdateGlobalProductAd(string adId = default(string), string name = default(string), SponsoredProductsGlobalProductIdentifiers asin = default(SponsoredProductsGlobalProductIdentifiers), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsGlobalProductIdentifiers sku = default(SponsoredProductsGlobalProductIdentifiers))
        {
            // to ensure "adId" is required (not null)
            if (adId == null)
            {
                throw new ArgumentNullException("adId is a required property for SponsoredProductsUpdateGlobalProductAd and cannot be null");
            }
            this.AdId = adId;
            this.Name = name;
            this.Asin = asin;
            this.State = state;
            this.Sku = sku;
        }

        /// <summary>
        /// The product ad identifier.
        /// </summary>
        /// <value>The product ad identifier.</value>
        [DataMember(Name = "adId", IsRequired = true, EmitDefaultValue = true)]
        public string AdId { get; set; }

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
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public SponsoredProductsGlobalProductIdentifiers Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateGlobalProductAd {\n");
            sb.Append("  AdId: ").Append(AdId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateGlobalProductAd);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateGlobalProductAd instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateGlobalProductAd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateGlobalProductAd input)
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