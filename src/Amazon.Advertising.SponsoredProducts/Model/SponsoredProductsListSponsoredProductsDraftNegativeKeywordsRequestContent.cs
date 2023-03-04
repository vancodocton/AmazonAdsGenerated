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
    /// SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent")]
    public partial class SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent : IEquatable<SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent" /> class.
        /// </summary>
        /// <param name="campaignIdFilter">campaignIdFilter.</param>
        /// <param name="negativeKeywordTextFilter">negativeKeywordTextFilter.</param>
        /// <param name="maxResults">Number of records to include in the paginated response. Defaults to max page size for given API.</param>
        /// <param name="nextToken">token value allowing to navigate to the next response page.</param>
        /// <param name="adGroupIdFilter">adGroupIdFilter.</param>
        /// <param name="includeExtendedDataFields">Whether to get entity with extended data fields such as creationDate, lastUpdateDate, servingStatus.</param>
        /// <param name="locale">The locale preference of the advertiser..</param>
        /// <param name="negativeKeywordIdFilter">negativeKeywordIdFilter.</param>
        /// <param name="matchTypeFilter">Restricts results to resources with the selected matchType.</param>
        public SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent(SponsoredProductsReducedObjectIdFilter campaignIdFilter = default(SponsoredProductsReducedObjectIdFilter), SponsoredProductsKeywordTextFilter negativeKeywordTextFilter = default(SponsoredProductsKeywordTextFilter), int maxResults = default(int), string nextToken = default(string), SponsoredProductsReducedObjectIdFilter adGroupIdFilter = default(SponsoredProductsReducedObjectIdFilter), bool includeExtendedDataFields = default(bool), string locale = default(string), SponsoredProductsObjectIdFilter negativeKeywordIdFilter = default(SponsoredProductsObjectIdFilter), List<SponsoredProductsNegativeMatchType> matchTypeFilter = default(List<SponsoredProductsNegativeMatchType>))
        {
            this.CampaignIdFilter = campaignIdFilter;
            this.NegativeKeywordTextFilter = negativeKeywordTextFilter;
            this.MaxResults = maxResults;
            this.NextToken = nextToken;
            this.AdGroupIdFilter = adGroupIdFilter;
            this.IncludeExtendedDataFields = includeExtendedDataFields;
            this.Locale = locale;
            this.NegativeKeywordIdFilter = negativeKeywordIdFilter;
            this.MatchTypeFilter = matchTypeFilter;
        }

        /// <summary>
        /// Gets or Sets CampaignIdFilter
        /// </summary>
        [DataMember(Name = "campaignIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsReducedObjectIdFilter CampaignIdFilter { get; set; }

        /// <summary>
        /// Gets or Sets NegativeKeywordTextFilter
        /// </summary>
        [DataMember(Name = "negativeKeywordTextFilter", EmitDefaultValue = false)]
        public SponsoredProductsKeywordTextFilter NegativeKeywordTextFilter { get; set; }

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
        /// The locale preference of the advertiser.
        /// </summary>
        /// <value>The locale preference of the advertiser.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets NegativeKeywordIdFilter
        /// </summary>
        [DataMember(Name = "negativeKeywordIdFilter", EmitDefaultValue = false)]
        public SponsoredProductsObjectIdFilter NegativeKeywordIdFilter { get; set; }

        /// <summary>
        /// Restricts results to resources with the selected matchType
        /// </summary>
        /// <value>Restricts results to resources with the selected matchType</value>
        [DataMember(Name = "matchTypeFilter", EmitDefaultValue = false)]
        public List<SponsoredProductsNegativeMatchType> MatchTypeFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent {\n");
            sb.Append("  CampaignIdFilter: ").Append(CampaignIdFilter).Append("\n");
            sb.Append("  NegativeKeywordTextFilter: ").Append(NegativeKeywordTextFilter).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  AdGroupIdFilter: ").Append(AdGroupIdFilter).Append("\n");
            sb.Append("  IncludeExtendedDataFields: ").Append(IncludeExtendedDataFields).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  NegativeKeywordIdFilter: ").Append(NegativeKeywordIdFilter).Append("\n");
            sb.Append("  MatchTypeFilter: ").Append(MatchTypeFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsListSponsoredProductsDraftNegativeKeywordsRequestContent input)
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
                    this.NegativeKeywordTextFilter == input.NegativeKeywordTextFilter ||
                    (this.NegativeKeywordTextFilter != null &&
                    this.NegativeKeywordTextFilter.Equals(input.NegativeKeywordTextFilter))
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
                    this.AdGroupIdFilter == input.AdGroupIdFilter ||
                    (this.AdGroupIdFilter != null &&
                    this.AdGroupIdFilter.Equals(input.AdGroupIdFilter))
                ) &&
                (
                    this.IncludeExtendedDataFields == input.IncludeExtendedDataFields ||
                    this.IncludeExtendedDataFields.Equals(input.IncludeExtendedDataFields)
                ) &&
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) &&
                (
                    this.NegativeKeywordIdFilter == input.NegativeKeywordIdFilter ||
                    (this.NegativeKeywordIdFilter != null &&
                    this.NegativeKeywordIdFilter.Equals(input.NegativeKeywordIdFilter))
                ) &&
                (
                    this.MatchTypeFilter == input.MatchTypeFilter ||
                    this.MatchTypeFilter != null &&
                    input.MatchTypeFilter != null &&
                    this.MatchTypeFilter.SequenceEqual(input.MatchTypeFilter)
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
                if (this.NegativeKeywordTextFilter != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeywordTextFilter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxResults.GetHashCode();
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                if (this.AdGroupIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupIdFilter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeExtendedDataFields.GetHashCode();
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                if (this.NegativeKeywordIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeywordIdFilter.GetHashCode();
                }
                if (this.MatchTypeFilter != null)
                {
                    hashCode = (hashCode * 59) + this.MatchTypeFilter.GetHashCode();
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
