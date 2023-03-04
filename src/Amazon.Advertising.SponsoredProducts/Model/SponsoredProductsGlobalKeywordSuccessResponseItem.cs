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
    /// SponsoredProductsGlobalKeywordSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalKeywordSuccessResponseItem")]
    public partial class SponsoredProductsGlobalKeywordSuccessResponseItem : IEquatable<SponsoredProductsGlobalKeywordSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalKeywordSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalKeywordSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalKeywordSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="keywordId">the keyword ID.</param>
        /// <param name="index">the index of the keyword in the array from the request body (required).</param>
        /// <param name="keyword">keyword.</param>
        public SponsoredProductsGlobalKeywordSuccessResponseItem(string keywordId = default(string), int index = default(int), SponsoredProductsGlobalKeyword keyword = default(SponsoredProductsGlobalKeyword))
        {
            this.Index = index;
            this.KeywordId = keywordId;
            this.Keyword = keyword;
        }

        /// <summary>
        /// the keyword ID
        /// </summary>
        /// <value>the keyword ID</value>
        [DataMember(Name = "keywordId", EmitDefaultValue = false)]
        public string KeywordId { get; set; }

        /// <summary>
        /// the index of the keyword in the array from the request body
        /// </summary>
        /// <value>the index of the keyword in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Keyword
        /// </summary>
        [DataMember(Name = "keyword", EmitDefaultValue = false)]
        public SponsoredProductsGlobalKeyword Keyword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalKeywordSuccessResponseItem {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalKeywordSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalKeywordSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalKeywordSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalKeywordSuccessResponseItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeywordId == input.KeywordId ||
                    (this.KeywordId != null &&
                    this.KeywordId.Equals(input.KeywordId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
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
                if (this.KeywordId != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
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
            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            yield break;
        }
    }

}
