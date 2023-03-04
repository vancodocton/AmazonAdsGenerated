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
    /// SponsoredProductsCampaignNegativeKeywordSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsCampaignNegativeKeywordSuccessResponseItem")]
    public partial class SponsoredProductsCampaignNegativeKeywordSuccessResponseItem : IEquatable<SponsoredProductsCampaignNegativeKeywordSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeKeywordSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCampaignNegativeKeywordSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCampaignNegativeKeywordSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="campaignNegativeKeyword">campaignNegativeKeyword.</param>
        /// <param name="campaignNegativeKeywordId">the campaignNegativeKeyword ID.</param>
        /// <param name="index">the index of the campaign in the array from the request body (required).</param>
        public SponsoredProductsCampaignNegativeKeywordSuccessResponseItem(SponsoredProductsCampaignNegativeKeyword campaignNegativeKeyword = default(SponsoredProductsCampaignNegativeKeyword), string campaignNegativeKeywordId = default(string), int index = default(int))
        {
            this.Index = index;
            this.CampaignNegativeKeyword = campaignNegativeKeyword;
            this.CampaignNegativeKeywordId = campaignNegativeKeywordId;
        }

        /// <summary>
        /// Gets or Sets CampaignNegativeKeyword
        /// </summary>
        [DataMember(Name = "campaignNegativeKeyword", EmitDefaultValue = false)]
        public SponsoredProductsCampaignNegativeKeyword CampaignNegativeKeyword { get; set; }

        /// <summary>
        /// the campaignNegativeKeyword ID
        /// </summary>
        /// <value>the campaignNegativeKeyword ID</value>
        [DataMember(Name = "campaignNegativeKeywordId", EmitDefaultValue = false)]
        public string CampaignNegativeKeywordId { get; set; }

        /// <summary>
        /// the index of the campaign in the array from the request body
        /// </summary>
        /// <value>the index of the campaign in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCampaignNegativeKeywordSuccessResponseItem {\n");
            sb.Append("  CampaignNegativeKeyword: ").Append(CampaignNegativeKeyword).Append("\n");
            sb.Append("  CampaignNegativeKeywordId: ").Append(CampaignNegativeKeywordId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as SponsoredProductsCampaignNegativeKeywordSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCampaignNegativeKeywordSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCampaignNegativeKeywordSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCampaignNegativeKeywordSuccessResponseItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampaignNegativeKeyword == input.CampaignNegativeKeyword ||
                    (this.CampaignNegativeKeyword != null &&
                    this.CampaignNegativeKeyword.Equals(input.CampaignNegativeKeyword))
                ) && 
                (
                    this.CampaignNegativeKeywordId == input.CampaignNegativeKeywordId ||
                    (this.CampaignNegativeKeywordId != null &&
                    this.CampaignNegativeKeywordId.Equals(input.CampaignNegativeKeywordId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                if (this.CampaignNegativeKeyword != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignNegativeKeyword.GetHashCode();
                }
                if (this.CampaignNegativeKeywordId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignNegativeKeywordId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
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
            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            yield break;
        }
    }

}
