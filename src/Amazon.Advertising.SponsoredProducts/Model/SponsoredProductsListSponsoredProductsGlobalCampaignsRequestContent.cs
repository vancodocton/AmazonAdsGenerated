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
    /// SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent")]
    public partial class SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent : IEquatable<SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent" /> class.
        /// </summary>
        /// <param name="campaignIdFilter">campaignIdFilter.</param>
        /// <param name="maxResults">Number of records to include in the paginated response. Defaults to max page size for given API.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        /// <param name="includeExtendedDataFields">Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus.</param>
        public SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent(SponsoredProductsObjectIdFilter campaignIdFilter = default(SponsoredProductsObjectIdFilter), int maxResults = default(int), string nextToken = default(string), bool includeExtendedDataFields = default(bool))
        {
            this.CampaignIdFilter = campaignIdFilter;
            this.MaxResults = maxResults;
            this.NextToken = nextToken;
            this.IncludeExtendedDataFields = includeExtendedDataFields;
        }

        /// <summary>
        /// Gets or Sets CampaignIdFilter
        /// </summary>
        [DataMember(Name = "campaignIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsObjectIdFilter CampaignIdFilter { get; set; }

        /// <summary>
        /// Number of records to include in the paginated response. Defaults to max page size for given API
        /// </summary>
        /// <value>Number of records to include in the paginated response. Defaults to max page size for given API</value>
        [DataMember(Name = "maxResults", EmitDefaultValue = false)]
        public int MaxResults { get; set; }

        /// <summary>
        /// token value allowing to navigate to the next response page
        /// </summary>
        /// <value>token value allowing to navigate to the next response page</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus
        /// </summary>
        /// <value>Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus</value>
        [DataMember(Name = "includeExtendedDataFields", EmitDefaultValue = true)]
        public bool IncludeExtendedDataFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent {\n");
            sb.Append("  CampaignIdFilter: ").Append(CampaignIdFilter).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  IncludeExtendedDataFields: ").Append(IncludeExtendedDataFields).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsGlobalCampaignsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CampaignIdFilter == input.CampaignIdFilter ||
                    (this.CampaignIdFilter != null &&
                    this.CampaignIdFilter.Equals(input.CampaignIdFilter))
                ) &&
                (
                    this.MaxResults == input.MaxResults ||
                    this.MaxResults.Equals(input.MaxResults)
                ) &&
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) &&
                (
                    this.IncludeExtendedDataFields == input.IncludeExtendedDataFields ||
                    this.IncludeExtendedDataFields.Equals(input.IncludeExtendedDataFields)
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
                if (this.CampaignIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIdFilter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxResults.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeExtendedDataFields.GetHashCode();
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
