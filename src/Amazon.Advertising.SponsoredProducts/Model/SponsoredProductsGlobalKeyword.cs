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
    /// SponsoredProductsGlobalKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalKeyword")]
    public partial class SponsoredProductsGlobalKeyword : IEquatable<SponsoredProductsGlobalKeyword>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MatchType
        /// </summary>
        [DataMember(Name = "matchType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsMatchType MatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalKeyword" /> class.
        /// </summary>
        /// <param name="keywordId">entity object identifier (required).</param>
        /// <param name="campaignId">entity object identifier (required).</param>
        /// <param name="matchType">matchType (required).</param>
        /// <param name="name">Name for the Keyword.</param>
        /// <param name="state">state (required).</param>
        /// <param name="bid">bid (required).</param>
        /// <param name="adGroupId">entity object identifier (required).</param>
        /// <param name="keywordText">keywordText (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsGlobalKeyword(string keywordId = default(string), string campaignId = default(string), SponsoredProductsMatchType matchType = default(SponsoredProductsMatchType), string name = default(string), SponsoredProductsGlobalEntityState state = default(SponsoredProductsGlobalEntityState), SponsoredProductsGlobalBid bid = default(SponsoredProductsGlobalBid), string adGroupId = default(string), SponsoredProductsGlobalKeywordText keywordText = default(SponsoredProductsGlobalKeywordText), SponsoredProductsGlobalKeywordExtendedData extendedData = default(SponsoredProductsGlobalKeywordExtendedData))
        {
            // to ensure "keywordId" is required (not null)
            if (keywordId == null)
            {
                throw new ArgumentNullException("keywordId is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.KeywordId = keywordId;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.CampaignId = campaignId;
            this.MatchType = matchType;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.State = state;
            // to ensure "bid" is required (not null)
            if (bid == null)
            {
                throw new ArgumentNullException("bid is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.Bid = bid;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.AdGroupId = adGroupId;
            // to ensure "keywordText" is required (not null)
            if (keywordText == null)
            {
                throw new ArgumentNullException("keywordText is a required property for SponsoredProductsGlobalKeyword and cannot be null");
            }
            this.KeywordText = keywordText;
            this.Name = name;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "keywordId", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordId { get; set; }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Name for the Keyword
        /// </summary>
        /// <value>Name for the Keyword</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets Bid
        /// </summary>
        [DataMember(Name = "bid", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalBid Bid { get; set; }

        /// <summary>
        /// entity object identifier
        /// </summary>
        /// <value>entity object identifier</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Gets or Sets KeywordText
        /// </summary>
        [DataMember(Name = "keywordText", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalKeywordText KeywordText { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsGlobalKeywordExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalKeyword {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
            sb.Append("  KeywordText: ").Append(KeywordText).Append("\n");
            sb.Append("  ExtendedData: ").Append(ExtendedData).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalKeyword input)
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
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) &&
                (
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
                ) &&
                (
                    this.KeywordText == input.KeywordText ||
                    (this.KeywordText != null &&
                    this.KeywordText.Equals(input.KeywordText))
                ) &&
                (
                    this.ExtendedData == input.ExtendedData ||
                    (this.ExtendedData != null &&
                    this.ExtendedData.Equals(input.ExtendedData))
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
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Bid != null)
                {
                    hashCode = (hashCode * 59) + this.Bid.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
                if (this.KeywordText != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordText.GetHashCode();
                }
                if (this.ExtendedData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedData.GetHashCode();
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
