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
    /// Filter by keywordText
    /// </summary>
    [DataContract(Name = "SponsoredProductsKeywordTextFilter")]
    public partial class SponsoredProductsKeywordTextFilter : IEquatable<SponsoredProductsKeywordTextFilter>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets QueryTermMatchType
        /// </summary>
        [DataMember(Name = "queryTermMatchType", EmitDefaultValue = false)]
        public SponsoredProductsQueryTermMatchType? QueryTermMatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsKeywordTextFilter" /> class.
        /// </summary>
        /// <param name="queryTermMatchType">queryTermMatchType.</param>
        /// <param name="include">include.</param>
        public SponsoredProductsKeywordTextFilter(SponsoredProductsQueryTermMatchType? queryTermMatchType = default(SponsoredProductsQueryTermMatchType?), List<string> include = default(List<string>))
        {
            this.QueryTermMatchType = queryTermMatchType;
            this.Include = include;
        }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", EmitDefaultValue = false)]
        public List<string> Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsKeywordTextFilter {\n");
            sb.Append("  QueryTermMatchType: ").Append(QueryTermMatchType).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
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
            return this.Equals(input as SponsoredProductsKeywordTextFilter);
        }

        /// <summary>
        /// Returns true if SponsoredProductsKeywordTextFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsKeywordTextFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsKeywordTextFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QueryTermMatchType == input.QueryTermMatchType ||
                    this.QueryTermMatchType.Equals(input.QueryTermMatchType)
                ) && 
                (
                    this.Include == input.Include ||
                    this.Include != null &&
                    input.Include != null &&
                    this.Include.SequenceEqual(input.Include)
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
                hashCode = (hashCode * 59) + this.QueryTermMatchType.GetHashCode();
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
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
