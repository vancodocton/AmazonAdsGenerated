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
    /// SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent")]
    public partial class SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent : IEquatable<SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent" /> class.
        /// </summary>
        /// <param name="keywordIdFilter">keywordIdFilter (required).</param>
        public SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent(SponsoredProductsObjectIdFilter keywordIdFilter = default(SponsoredProductsObjectIdFilter))
        {
            // to ensure "keywordIdFilter" is required (not null)
            if (keywordIdFilter == null)
            {
                throw new ArgumentNullException("keywordIdFilter is a required property for SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent and cannot be null");
            }
            this.KeywordIdFilter = keywordIdFilter;
        }

        /// <summary>
        /// Gets or Sets KeywordIdFilter
        /// </summary>
        [DataMember(Name = "keywordIdFilter", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsObjectIdFilter KeywordIdFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent {\n");
            sb.Append("  KeywordIdFilter: ").Append(KeywordIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDeleteSponsoredProductsDraftKeywordsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeywordIdFilter == input.KeywordIdFilter ||
                    (this.KeywordIdFilter != null &&
                    this.KeywordIdFilter.Equals(input.KeywordIdFilter))
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
                if (this.KeywordIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordIdFilter.GetHashCode();
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