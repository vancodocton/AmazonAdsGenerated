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
    /// SponsoredProductsCreateSponsoredProductsKeywordsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsKeywordsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsKeywordsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsKeywordsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsKeywordsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsKeywordsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsKeywordsRequestContent" /> class.
        /// </summary>
        /// <param name="keywords">keywords (required).</param>
        public SponsoredProductsCreateSponsoredProductsKeywordsRequestContent(List<SponsoredProductsCreateKeyword> keywords = default(List<SponsoredProductsCreateKeyword>))
        {
            // to ensure "keywords" is required (not null)
            if (keywords == null)
            {
                throw new ArgumentNullException("keywords is a required property for SponsoredProductsCreateSponsoredProductsKeywordsRequestContent and cannot be null");
            }
            this.Keywords = keywords;
        }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateKeyword> Keywords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsKeywordsRequestContent {\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsKeywordsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsKeywordsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsKeywordsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsKeywordsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
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
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
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
