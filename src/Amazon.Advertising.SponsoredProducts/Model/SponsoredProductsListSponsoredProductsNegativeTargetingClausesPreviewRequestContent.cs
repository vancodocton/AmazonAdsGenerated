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
    /// SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent")]
    public partial class SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent : IEquatable<SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent" /> class.
        /// </summary>
        /// <param name="negativeTargetIdFilter">negativeTargetIdFilter.</param>
        /// <param name="campaignIdFilter">campaignIdFilter.</param>
        /// <param name="stateFilter">stateFilter.</param>
        /// <param name="maxResults">Number of records to include in the paginated response. Defaults to max page size for given API.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        /// <param name="asinFilter">asinFilter.</param>
        /// <param name="adGroupIdFilter">adGroupIdFilter.</param>
        /// <param name="includeExtendedDataFields">Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus.</param>
        public SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent(SponsoredProductsObjectIdFilter negativeTargetIdFilter = default(SponsoredProductsObjectIdFilter), SponsoredProductsReducedObjectIdFilter campaignIdFilter = default(SponsoredProductsReducedObjectIdFilter), SponsoredProductsEntityStateFilter stateFilter = default(SponsoredProductsEntityStateFilter), int maxResults = default(int), string nextToken = default(string), SponsoredProductsAsinFilter asinFilter = default(SponsoredProductsAsinFilter), SponsoredProductsReducedObjectIdFilter adGroupIdFilter = default(SponsoredProductsReducedObjectIdFilter), bool includeExtendedDataFields = default(bool))
        {
            this.NegativeTargetIdFilter = negativeTargetIdFilter;
            this.CampaignIdFilter = campaignIdFilter;
            this.StateFilter = stateFilter;
            this.MaxResults = maxResults;
            this.NextToken = nextToken;
            this.AsinFilter = asinFilter;
            this.AdGroupIdFilter = adGroupIdFilter;
            this.IncludeExtendedDataFields = includeExtendedDataFields;
        }

        /// <summary>
        /// Gets or Sets NegativeTargetIdFilter
        /// </summary>
        [DataMember(Name = "negativeTargetIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsObjectIdFilter NegativeTargetIdFilter { get; set; }

        /// <summary>
        /// Gets or Sets CampaignIdFilter
        /// </summary>
        [DataMember(Name = "campaignIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsReducedObjectIdFilter CampaignIdFilter { get; set; }

        /// <summary>
        /// Gets or Sets StateFilter
        /// </summary>
        [DataMember(Name = "stateFilter", EmitDefaultValue = false)]
        public SponsoredProductsEntityStateFilter StateFilter { get; set; }

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
        /// Gets or Sets AsinFilter
        /// </summary>
        [DataMember(Name = "asinFilter", EmitDefaultValue = false)]
        public SponsoredProductsAsinFilter AsinFilter { get; set; }

        /// <summary>
        /// Gets or Sets AdGroupIdFilter
        /// </summary>
        [DataMember(Name = "adGroupIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsReducedObjectIdFilter AdGroupIdFilter { get; set; }

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
            sb.Append("class SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent {\n");
            sb.Append("  NegativeTargetIdFilter: ").Append(NegativeTargetIdFilter).Append("\n");
            sb.Append("  CampaignIdFilter: ").Append(CampaignIdFilter).Append("\n");
            sb.Append("  StateFilter: ").Append(StateFilter).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  AsinFilter: ").Append(AsinFilter).Append("\n");
            sb.Append("  AdGroupIdFilter: ").Append(AdGroupIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsNegativeTargetingClausesPreviewRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NegativeTargetIdFilter == input.NegativeTargetIdFilter ||
                    (this.NegativeTargetIdFilter != null &&
                    this.NegativeTargetIdFilter.Equals(input.NegativeTargetIdFilter))
                ) &&
                (
                    this.CampaignIdFilter == input.CampaignIdFilter ||
                    (this.CampaignIdFilter != null &&
                    this.CampaignIdFilter.Equals(input.CampaignIdFilter))
                ) &&
                (
                    this.StateFilter == input.StateFilter ||
                    (this.StateFilter != null &&
                    this.StateFilter.Equals(input.StateFilter))
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
                    this.AsinFilter == input.AsinFilter ||
                    (this.AsinFilter != null &&
                    this.AsinFilter.Equals(input.AsinFilter))
                ) &&
                (
                    this.AdGroupIdFilter == input.AdGroupIdFilter ||
                    (this.AdGroupIdFilter != null &&
                    this.AdGroupIdFilter.Equals(input.AdGroupIdFilter))
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
                if (this.NegativeTargetIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeTargetIdFilter.GetHashCode();
                }
                if (this.CampaignIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIdFilter.GetHashCode();
                }
                if (this.StateFilter != null)
                {
                    hashCode = (hashCode * 59) + this.StateFilter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxResults.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                if (this.AsinFilter != null)
                {
                    hashCode = (hashCode * 59) + this.AsinFilter.GetHashCode();
                }
                if (this.AdGroupIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupIdFilter.GetHashCode();
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
