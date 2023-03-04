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
    /// SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent")]
    public partial class SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent : IEquatable<SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent" /> class.
        /// </summary>
        /// <param name="negativeKeywords">negativeKeywords (required).</param>
        public SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent(SponsoredProductsBulkDraftNegativeKeywordOperationResponse negativeKeywords = default(SponsoredProductsBulkDraftNegativeKeywordOperationResponse))
        {
            // to ensure "negativeKeywords" is required (not null)
            if (negativeKeywords == null)
            {
                throw new ArgumentNullException("negativeKeywords is a required property for SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent and cannot be null");
            }
            this.NegativeKeywords = negativeKeywords;
        }

        /// <summary>
        /// Gets or Sets NegativeKeywords
        /// </summary>
        [DataMember(Name = "negativeKeywords", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBulkDraftNegativeKeywordOperationResponse NegativeKeywords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent {\n");
            sb.Append("  NegativeKeywords: ").Append(NegativeKeywords).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsDraftNegativeKeywordsResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NegativeKeywords == input.NegativeKeywords ||
                    (this.NegativeKeywords != null &&
                    this.NegativeKeywords.Equals(input.NegativeKeywords))
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
                if (this.NegativeKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeywords.GetHashCode();
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