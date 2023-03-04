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
    /// SponsoredProductsUpdateProductAd
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateProductAd")]
    public partial class SponsoredProductsUpdateProductAd : IEquatable<SponsoredProductsUpdateProductAd>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateProductAd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateProductAd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateProductAd" /> class.
        /// </summary>
        /// <param name="adId">The product ad identifier. (required).</param>
        /// <param name="state">state.</param>
        public SponsoredProductsUpdateProductAd(string adId = default(string), SponsoredProductsCreateOrUpdateEntityState? state = default(SponsoredProductsCreateOrUpdateEntityState?))
        {
            // to ensure "adId" is required (not null)
            if (adId == null)
            {
                throw new ArgumentNullException("adId is a required property for SponsoredProductsUpdateProductAd and cannot be null");
            }
            this.AdId = adId;
            this.State = state;
        }

        /// <summary>
        /// The product ad identifier.
        /// </summary>
        /// <value>The product ad identifier.</value>
        [DataMember(Name = "adId", IsRequired = true, EmitDefaultValue = true)]
        public string AdId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateProductAd {\n");
            sb.Append("  AdId: ").Append(AdId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateProductAd);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateProductAd instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateProductAd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateProductAd input)
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
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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
