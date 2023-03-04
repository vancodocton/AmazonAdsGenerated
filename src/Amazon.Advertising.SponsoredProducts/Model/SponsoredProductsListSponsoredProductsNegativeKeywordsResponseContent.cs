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
    /// SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent")]
    public partial class SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent : IEquatable<SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent" /> class.
        /// </summary>
        /// <param name="negativeKeywords">negativeKeywords.</param>
        /// <param name="totalResults">The total number of entities.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        public SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent(List<SponsoredProductsNegativeKeyword> negativeKeywords = default(List<SponsoredProductsNegativeKeyword>), long totalResults = default(long), string nextToken = default(string))
        {
            this.NegativeKeywords = negativeKeywords;
            this.TotalResults = totalResults;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Gets or Sets NegativeKeywords
        /// </summary>
        [DataMember(Name = "negativeKeywords", EmitDefaultValue = false)]
        public List<SponsoredProductsNegativeKeyword> NegativeKeywords { get; set; }

        /// <summary>
        /// The total number of entities
        /// </summary>
        /// <value>The total number of entities</value>
        [DataMember(Name = "totalResults", EmitDefaultValue = false)]
        public long TotalResults { get; set; }

        /// <summary>
        /// token value allowing to navigate to the next response page
        /// </summary>
        /// <value>token value allowing to navigate to the next response page</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent {\n");
            sb.Append("  NegativeKeywords: ").Append(NegativeKeywords).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsNegativeKeywordsResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NegativeKeywords == input.NegativeKeywords ||
                    this.NegativeKeywords != null &&
                    input.NegativeKeywords != null &&
                    this.NegativeKeywords.SequenceEqual(input.NegativeKeywords)
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    this.TotalResults.Equals(input.TotalResults)
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                hashCode = (hashCode * 59) + this.TotalResults.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
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
