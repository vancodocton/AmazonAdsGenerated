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
    /// GetCampaignRecommendationsResponse
    /// </summary>
    [DataContract(Name = "GetCampaignRecommendationsResponse")]
    public partial class GetCampaignRecommendationsResponse : IEquatable<GetCampaignRecommendationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignRecommendationsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCampaignRecommendationsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignRecommendationsResponse" /> class.
        /// </summary>
        /// <param name="nextToken">An identifier to fetch next set of campaign recommendations records in the result set if available. This will be null when at the end of result set..</param>
        /// <param name="recommendations">List of campaign recommendations. (required).</param>
        public GetCampaignRecommendationsResponse(string nextToken = default(string), List<CampaignRecommendation> recommendations = default(List<CampaignRecommendation>))
        {
            // to ensure "recommendations" is required (not null)
            if (recommendations == null)
            {
                throw new ArgumentNullException("recommendations is a required property for GetCampaignRecommendationsResponse and cannot be null");
            }
            this.Recommendations = recommendations;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// An identifier to fetch next set of campaign recommendations records in the result set if available. This will be null when at the end of result set.
        /// </summary>
        /// <value>An identifier to fetch next set of campaign recommendations records in the result set if available. This will be null when at the end of result set.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// List of campaign recommendations.
        /// </summary>
        /// <value>List of campaign recommendations.</value>
        [DataMember(Name = "recommendations", IsRequired = true, EmitDefaultValue = true)]
        public List<CampaignRecommendation> Recommendations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetCampaignRecommendationsResponse {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  Recommendations: ").Append(Recommendations).Append("\n");
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
            return this.Equals(input as GetCampaignRecommendationsResponse);
        }

        /// <summary>
        /// Returns true if GetCampaignRecommendationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCampaignRecommendationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCampaignRecommendationsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) && 
                (
                    this.Recommendations == input.Recommendations ||
                    this.Recommendations != null &&
                    input.Recommendations != null &&
                    this.Recommendations.SequenceEqual(input.Recommendations)
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
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                if (this.Recommendations != null)
                {
                    hashCode = (hashCode * 59) + this.Recommendations.GetHashCode();
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