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
    /// SponsoredProductsListSponsoredProductsAdGroupsResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsAdGroupsResponseContent")]
    public partial class SponsoredProductsListSponsoredProductsAdGroupsResponseContent : IEquatable<SponsoredProductsListSponsoredProductsAdGroupsResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsAdGroupsResponseContent" /> class.
        /// </summary>
        /// <param name="totalResults">The total number of entities.</param>
        /// <param name="adGroups">adGroups.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        public SponsoredProductsListSponsoredProductsAdGroupsResponseContent(long totalResults = default(long), List<SponsoredProductsAdGroup> adGroups = default(List<SponsoredProductsAdGroup>), string nextToken = default(string))
        {
            this.TotalResults = totalResults;
            this.AdGroups = adGroups;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// The total number of entities
        /// </summary>
        /// <value>The total number of entities</value>
        [DataMember(Name = "totalResults", EmitDefaultValue = false)]
        public long TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets AdGroups
        /// </summary>
        [DataMember(Name = "adGroups", EmitDefaultValue = false)]
        public List<SponsoredProductsAdGroup> AdGroups { get; set; }

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
            sb.Append("class SponsoredProductsListSponsoredProductsAdGroupsResponseContent {\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  AdGroups: ").Append(AdGroups).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsAdGroupsResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsAdGroupsResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsAdGroupsResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsAdGroupsResponseContent input)
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
                    this.AdGroups == input.AdGroups ||
                    this.AdGroups != null &&
                    input.AdGroups != null &&
                    this.AdGroups.SequenceEqual(input.AdGroups)
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
                hashCode = (hashCode * 59) + this.TotalResults.GetHashCode();
                if (this.AdGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroups.GetHashCode();
                }
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
