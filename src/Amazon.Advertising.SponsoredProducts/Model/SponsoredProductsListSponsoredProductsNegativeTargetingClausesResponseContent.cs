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
    /// SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent")]
    public partial class SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent : IEquatable<SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent" /> class.
        /// </summary>
        /// <param name="totalResults">The total number of entities.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        /// <param name="negativeTargetingClauses">negativeTargetingClauses.</param>
        public SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent(long totalResults = default(long), string nextToken = default(string), List<SponsoredProductsNegativeTargetingClause> negativeTargetingClauses = default(List<SponsoredProductsNegativeTargetingClause>))
        {
            this.TotalResults = totalResults;
            this.NextToken = nextToken;
            this.NegativeTargetingClauses = negativeTargetingClauses;
        }

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
        /// Gets or Sets NegativeTargetingClauses
        /// </summary>
        [DataMember(Name = "negativeTargetingClauses", EmitDefaultValue = false)]
        public List<SponsoredProductsNegativeTargetingClause> NegativeTargetingClauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent {\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  NegativeTargetingClauses: ").Append(NegativeTargetingClauses).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsNegativeTargetingClausesResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalResults == input.TotalResults ||
                    this.TotalResults.Equals(input.TotalResults)
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) && 
                (
                    this.NegativeTargetingClauses == input.NegativeTargetingClauses ||
                    this.NegativeTargetingClauses != null &&
                    input.NegativeTargetingClauses != null &&
                    this.NegativeTargetingClauses.SequenceEqual(input.NegativeTargetingClauses)
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
                hashCode = (hashCode * 59) + this.TotalResults.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                if (this.NegativeTargetingClauses != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeTargetingClauses.GetHashCode();
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
