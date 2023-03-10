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
    /// SponsoredProductsDraftCampaignNegativeKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsDraftCampaignNegativeKeyword")]
    public partial class SponsoredProductsDraftCampaignNegativeKeyword : IEquatable<SponsoredProductsDraftCampaignNegativeKeyword>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MatchType
        /// </summary>
        [DataMember(Name = "matchType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsNegativeMatchType MatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftCampaignNegativeKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDraftCampaignNegativeKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftCampaignNegativeKeyword" /> class.
        /// </summary>
        /// <param name="keywordId">The identifier of the keyword. (required).</param>
        /// <param name="campaignId">The identifier of the draft to which the keyword is associated. (required).</param>
        /// <param name="matchType">matchType (required).</param>
        /// <param name="keywordText">The keyword text. (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsDraftCampaignNegativeKeyword(string keywordId = default(string), string campaignId = default(string), SponsoredProductsNegativeMatchType matchType = default(SponsoredProductsNegativeMatchType), string keywordText = default(string), SponsoredProductsDraftCampaignNegativeKeywordExtendedData extendedData = default(SponsoredProductsDraftCampaignNegativeKeywordExtendedData))
        {
            // to ensure "keywordId" is required (not null)
            if (keywordId == null)
            {
                throw new ArgumentNullException("keywordId is a required property for SponsoredProductsDraftCampaignNegativeKeyword and cannot be null");
            }
            this.KeywordId = keywordId;
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsDraftCampaignNegativeKeyword and cannot be null");
            }
            this.CampaignId = campaignId;
            this.MatchType = matchType;
            // to ensure "keywordText" is required (not null)
            if (keywordText == null)
            {
                throw new ArgumentNullException("keywordText is a required property for SponsoredProductsDraftCampaignNegativeKeyword and cannot be null");
            }
            this.KeywordText = keywordText;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// The identifier of the keyword.
        /// </summary>
        /// <value>The identifier of the keyword.</value>
        [DataMember(Name = "keywordId", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordId { get; set; }

        /// <summary>
        /// The identifier of the draft to which the keyword is associated.
        /// </summary>
        /// <value>The identifier of the draft to which the keyword is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The keyword text.
        /// </summary>
        /// <value>The keyword text.</value>
        [DataMember(Name = "keywordText", IsRequired = true, EmitDefaultValue = true)]
        public string KeywordText { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsDraftCampaignNegativeKeywordExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDraftCampaignNegativeKeyword {\n");
            sb.Append("  KeywordId: ").Append(KeywordId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
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
            return this.Equals(input as SponsoredProductsDraftCampaignNegativeKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDraftCampaignNegativeKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDraftCampaignNegativeKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDraftCampaignNegativeKeyword input)
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
