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
    /// Request object for SearchBrands API.
    /// </summary>
    [DataContract(Name = "SearchBrandsRequest")]
    public partial class SearchBrandsRequest : IEquatable<SearchBrandsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBrandsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchBrandsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBrandsRequest" /> class.
        /// </summary>
        /// <param name="keyword">keyword (required).</param>
        public SearchBrandsRequest(string keyword = default(string))
        {
            // to ensure "keyword" is required (not null)
            if (keyword == null)
            {
                throw new ArgumentNullException("keyword is a required property for SearchBrandsRequest and cannot be null");
            }
            this.Keyword = keyword;
        }

        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name = "keyword", IsRequired = true, EmitDefaultValue = true)]
        public string Keyword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBrandsRequest {\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
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
            return this.Equals(input as SearchBrandsRequest);
        }

        /// <summary>
        /// Returns true if SearchBrandsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBrandsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBrandsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
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
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
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
