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
    /// This request type is used to retrieve recommended keyword targets for an existing ad group. Set the recommendationType to KEYWORD_FOR_ADGROUP to use this request type.
    /// </summary>
    [DataContract(Name = "RankedKeywordTargetsForAdGroupRequest")]
    public partial class RankedKeywordTargetsForAdGroupRequest : IEquatable<RankedKeywordTargetsForAdGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// The recommendationType to retrieve recommended keyword targets for an existing ad group.
        /// </summary>
        /// <value>The recommendationType to retrieve recommended keyword targets for an existing ad group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecommendationTypeEnum
        {
            /// <summary>
            /// Enum KEYWORDSFORADGROUP for value: KEYWORDS_FOR_ADGROUP
            /// </summary>
            [EnumMember(Value = "KEYWORDS_FOR_ADGROUP")]
            KEYWORDSFORADGROUP = 1

        }


        /// <summary>
        /// The recommendationType to retrieve recommended keyword targets for an existing ad group.
        /// </summary>
        /// <value>The recommendationType to retrieve recommended keyword targets for an existing ad group.</value>
        [DataMember(Name = "recommendationType", IsRequired = true, EmitDefaultValue = true)]
        public RecommendationTypeEnum RecommendationType { get; set; }
        /// <summary>
        /// The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in.
        /// </summary>
        /// <value>The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortDimensionEnum
        {
            /// <summary>
            /// Enum CLICKS for value: CLICKS
            /// </summary>
            [EnumMember(Value = "CLICKS")]
            CLICKS = 1,

            /// <summary>
            /// Enum CONVERSIONS for value: CONVERSIONS
            /// </summary>
            [EnumMember(Value = "CONVERSIONS")]
            CONVERSIONS = 2,

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 3

        }


        /// <summary>
        /// The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in.
        /// </summary>
        /// <value>The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in.</value>
        [DataMember(Name = "sortDimension", EmitDefaultValue = false)]
        public SortDimensionEnum? SortDimension { get; set; }
        /// <summary>
        /// Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported.
        /// </summary>
        /// <value>Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocaleEnum
        {
            /// <summary>
            /// Enum ArEG for value: ar_EG
            /// </summary>
            [EnumMember(Value = "ar_EG")]
            ArEG = 1,

            /// <summary>
            /// Enum DeDE for value: de_DE
            /// </summary>
            [EnumMember(Value = "de_DE")]
            DeDE = 2,

            /// <summary>
            /// Enum EnAE for value: en_AE
            /// </summary>
            [EnumMember(Value = "en_AE")]
            EnAE = 3,

            /// <summary>
            /// Enum EnAU for value: en_AU
            /// </summary>
            [EnumMember(Value = "en_AU")]
            EnAU = 4,

            /// <summary>
            /// Enum EnCA for value: en_CA
            /// </summary>
            [EnumMember(Value = "en_CA")]
            EnCA = 5,

            /// <summary>
            /// Enum EnGB for value: en_GB
            /// </summary>
            [EnumMember(Value = "en_GB")]
            EnGB = 6,

            /// <summary>
            /// Enum EnIN for value: en_IN
            /// </summary>
            [EnumMember(Value = "en_IN")]
            EnIN = 7,

            /// <summary>
            /// Enum EnSA for value: en_SA
            /// </summary>
            [EnumMember(Value = "en_SA")]
            EnSA = 8,

            /// <summary>
            /// Enum EnSG for value: en_SG
            /// </summary>
            [EnumMember(Value = "en_SG")]
            EnSG = 9,

            /// <summary>
            /// Enum EnUS for value: en_US
            /// </summary>
            [EnumMember(Value = "en_US")]
            EnUS = 10,

            /// <summary>
            /// Enum EsES for value: es_ES
            /// </summary>
            [EnumMember(Value = "es_ES")]
            EsES = 11,

            /// <summary>
            /// Enum EsMX for value: es_MX
            /// </summary>
            [EnumMember(Value = "es_MX")]
            EsMX = 12,

            /// <summary>
            /// Enum FrFR for value: fr_FR
            /// </summary>
            [EnumMember(Value = "fr_FR")]
            FrFR = 13,

            /// <summary>
            /// Enum ItIT for value: it_IT
            /// </summary>
            [EnumMember(Value = "it_IT")]
            ItIT = 14,

            /// <summary>
            /// Enum JaJP for value: ja_JP
            /// </summary>
            [EnumMember(Value = "ja_JP")]
            JaJP = 15,

            /// <summary>
            /// Enum NlNL for value: nl_NL
            /// </summary>
            [EnumMember(Value = "nl_NL")]
            NlNL = 16,

            /// <summary>
            /// Enum PlPL for value: pl_PL
            /// </summary>
            [EnumMember(Value = "pl_PL")]
            PlPL = 17,

            /// <summary>
            /// Enum PtBR for value: pt_BR
            /// </summary>
            [EnumMember(Value = "pt_BR")]
            PtBR = 18,

            /// <summary>
            /// Enum SvSE for value: sv_SE
            /// </summary>
            [EnumMember(Value = "sv_SE")]
            SvSE = 19,

            /// <summary>
            /// Enum TrTR for value: tr_TR
            /// </summary>
            [EnumMember(Value = "tr_TR")]
            TrTR = 20,

            /// <summary>
            /// Enum ZhCN for value: zh_CN
            /// </summary>
            [EnumMember(Value = "zh_CN")]
            ZhCN = 21

        }


        /// <summary>
        /// Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported.
        /// </summary>
        /// <value>Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public LocaleEnum? Locale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedKeywordTargetsForAdGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RankedKeywordTargetsForAdGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedKeywordTargetsForAdGroupRequest" /> class.
        /// </summary>
        /// <param name="campaignId">The identifier of the campaign (required).</param>
        /// <param name="recommendationType">The recommendationType to retrieve recommended keyword targets for an existing ad group. (required).</param>
        /// <param name="bidsEnabled">Set this parameter to false if you do not want to retrieve bid suggestions for your keyword targets. Defaults to true. (default to true).</param>
        /// <param name="adGroupId">The identifier of the ad group (required).</param>
        /// <param name="maxRecommendations">The max size of recommended target. Set it to 0 if you only want to rank user-defined keywords. (default to 200M).</param>
        /// <param name="sortDimension">The ranking metric value. Supported values: CLICKS, CONVERSIONS, DEFAULT. DEFAULT will be applied if no value passed in..</param>
        /// <param name="locale">Translations are for readability and do not affect the targeting of ads. Supported marketplace to locale mappings can be found at the &lt;a href&#x3D;&#39;https://advertising.amazon.com/API/docs/en-us/localization/#/Keyword%20Localization&#39;&gt;POST /keywords/localize&lt;/a&gt; endpoint. Note: Translations will be null if locale is unsupported..</param>
        public RankedKeywordTargetsForAdGroupRequest(string campaignId = default(string), RecommendationTypeEnum recommendationType = default(RecommendationTypeEnum), bool bidsEnabled = true, string adGroupId = default(string), decimal maxRecommendations = 200M, SortDimensionEnum? sortDimension = default(SortDimensionEnum?), LocaleEnum? locale = default(LocaleEnum?))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for RankedKeywordTargetsForAdGroupRequest and cannot be null");
            }
            this.CampaignId = campaignId;
            this.RecommendationType = recommendationType;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for RankedKeywordTargetsForAdGroupRequest and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.BidsEnabled = bidsEnabled;
            this.MaxRecommendations = maxRecommendations;
            this.SortDimension = sortDimension;
            this.Locale = locale;
        }

        /// <summary>
        /// The identifier of the campaign
        /// </summary>
        /// <value>The identifier of the campaign</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Set this parameter to false if you do not want to retrieve bid suggestions for your keyword targets. Defaults to true.
        /// </summary>
        /// <value>Set this parameter to false if you do not want to retrieve bid suggestions for your keyword targets. Defaults to true.</value>
        [DataMember(Name = "bidsEnabled", EmitDefaultValue = true)]
        public bool BidsEnabled { get; set; }

        /// <summary>
        /// The identifier of the ad group
        /// </summary>
        /// <value>The identifier of the ad group</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// The max size of recommended target. Set it to 0 if you only want to rank user-defined keywords.
        /// </summary>
        /// <value>The max size of recommended target. Set it to 0 if you only want to rank user-defined keywords.</value>
        [DataMember(Name = "maxRecommendations", EmitDefaultValue = false)]
        public decimal MaxRecommendations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RankedKeywordTargetsForAdGroupRequest {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  RecommendationType: ").Append(RecommendationType).Append("\n");
            sb.Append("  BidsEnabled: ").Append(BidsEnabled).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
            sb.Append("  MaxRecommendations: ").Append(MaxRecommendations).Append("\n");
            sb.Append("  SortDimension: ").Append(SortDimension).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as RankedKeywordTargetsForAdGroupRequest);
        }

        /// <summary>
        /// Returns true if RankedKeywordTargetsForAdGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RankedKeywordTargetsForAdGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankedKeywordTargetsForAdGroupRequest input)
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
                    this.RecommendationType == input.RecommendationType ||
                    this.RecommendationType.Equals(input.RecommendationType)
                ) &&
                (
                    this.BidsEnabled == input.BidsEnabled ||
                    this.BidsEnabled.Equals(input.BidsEnabled)
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
                ) &&
                (
                    this.MaxRecommendations == input.MaxRecommendations ||
                    this.MaxRecommendations.Equals(input.MaxRecommendations)
                ) &&
                (
                    this.SortDimension == input.SortDimension ||
                    this.SortDimension.Equals(input.SortDimension)
                ) &&
                (
                    this.Locale == input.Locale ||
                    this.Locale.Equals(input.Locale)
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
                hashCode = (hashCode * 59) + this.RecommendationType.GetHashCode();
                hashCode = (hashCode * 59) + this.BidsEnabled.GetHashCode();
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxRecommendations.GetHashCode();
                hashCode = (hashCode * 59) + this.SortDimension.GetHashCode();
                hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
            // MaxRecommendations (decimal) maximum
            if (this.MaxRecommendations > (decimal)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxRecommendations, must be a value less than or equal to 200.", new[] { "MaxRecommendations" });
            }

            // MaxRecommendations (decimal) minimum
            if (this.MaxRecommendations < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxRecommendations, must be a value greater than or equal to 0.", new[] { "MaxRecommendations" });
            }

            yield break;
        }
    }

}
