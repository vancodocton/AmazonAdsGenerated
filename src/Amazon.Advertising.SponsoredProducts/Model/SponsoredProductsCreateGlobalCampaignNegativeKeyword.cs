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
    /// SponsoredProductsCreateGlobalCampaignNegativeKeyword
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateGlobalCampaignNegativeKeyword")]
    public partial class SponsoredProductsCreateGlobalCampaignNegativeKeyword : IEquatable<SponsoredProductsCreateGlobalCampaignNegativeKeyword>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MatchType
        /// </summary>
        [DataMember(Name = "matchType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateNegativeMatchType MatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalCampaignNegativeKeyword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateGlobalCampaignNegativeKeyword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateGlobalCampaignNegativeKeyword" /> class.
        /// </summary>
        /// <param name="campaignId">The identifier of the campaign to which the keyword is associated. (required).</param>
        /// <param name="matchType">matchType (required).</param>
        /// <param name="name">Name for the keyword.</param>
        /// <param name="state">state (required).</param>
        /// <param name="keywordText">keywordText (required).</param>
        public SponsoredProductsCreateGlobalCampaignNegativeKeyword(string campaignId = default(string), SponsoredProductsCreateOrUpdateNegativeMatchType matchType = default(SponsoredProductsCreateOrUpdateNegativeMatchType), string name = default(string), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), SponsoredProductsGlobalNegativeKeywordText keywordText = default(SponsoredProductsGlobalNegativeKeywordText))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateGlobalCampaignNegativeKeyword and cannot be null");
            }
            this.CampaignId = campaignId;
            this.MatchType = matchType;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SponsoredProductsCreateGlobalCampaignNegativeKeyword and cannot be null");
            }
            this.State = state;
            // to ensure "keywordText" is required (not null)
            if (keywordText == null)
            {
                throw new ArgumentNullException("keywordText is a required property for SponsoredProductsCreateGlobalCampaignNegativeKeyword and cannot be null");
            }
            this.KeywordText = keywordText;
            this.Name = name;
        }

        /// <summary>
        /// The identifier of the campaign to which the keyword is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which the keyword is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Name for the keyword
        /// </summary>
        /// <value>Name for the keyword</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Gets or Sets KeywordText
        /// </summary>
        [DataMember(Name = "keywordText", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsGlobalNegativeKeywordText KeywordText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateGlobalCampaignNegativeKeyword {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  KeywordText: ").Append(KeywordText).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateGlobalCampaignNegativeKeyword);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateGlobalCampaignNegativeKeyword instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateGlobalCampaignNegativeKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateGlobalCampaignNegativeKeyword input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.KeywordText == input.KeywordText ||
                    (this.KeywordText != null &&
                    this.KeywordText.Equals(input.KeywordText))
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
                if (this.KeywordText != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordText.GetHashCode();
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
