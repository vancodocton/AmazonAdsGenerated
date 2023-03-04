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
    /// SponsoredProductsDraftAdGroup
    /// </summary>
    [DataContract(Name = "SponsoredProductsDraftAdGroup")]
    public partial class SponsoredProductsDraftAdGroup : IEquatable<SponsoredProductsDraftAdGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftAdGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDraftAdGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftAdGroup" /> class.
        /// </summary>
        /// <param name="campaignId">The identifier of the campaign to which the keyword is associated. (required).</param>
        /// <param name="name">The name of the ad group. (required).</param>
        /// <param name="adGroupId">The identifier of the keyword. (required).</param>
        /// <param name="defaultBid">A bid value for use when no bid is specified for keywords in the ad group. (required).</param>
        /// <param name="extendedData">extendedData.</param>
        public SponsoredProductsDraftAdGroup(string campaignId = default(string), string name = default(string), string adGroupId = default(string), double defaultBid = default(double), SponsoredProductsDraftAdGroupExtendedData extendedData = default(SponsoredProductsDraftAdGroupExtendedData))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsDraftAdGroup and cannot be null");
            }
            this.CampaignId = campaignId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SponsoredProductsDraftAdGroup and cannot be null");
            }
            this.Name = name;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsDraftAdGroup and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.DefaultBid = defaultBid;
            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// The identifier of the campaign to which the keyword is associated.
        /// </summary>
        /// <value>The identifier of the campaign to which the keyword is associated.</value>
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The name of the ad group.
        /// </summary>
        /// <value>The name of the ad group.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The identifier of the keyword.
        /// </summary>
        /// <value>The identifier of the keyword.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// A bid value for use when no bid is specified for keywords in the ad group.
        /// </summary>
        /// <value>A bid value for use when no bid is specified for keywords in the ad group.</value>
        [DataMember(Name = "defaultBid", IsRequired = true, EmitDefaultValue = true)]
        public double DefaultBid { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name = "extendedData", EmitDefaultValue = false)]
        public SponsoredProductsDraftAdGroupExtendedData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDraftAdGroup {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
            sb.Append("  DefaultBid: ").Append(DefaultBid).Append("\n");
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
            return this.Equals(input as SponsoredProductsDraftAdGroup);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDraftAdGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDraftAdGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDraftAdGroup input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
                ) &&
                (
                    this.DefaultBid == input.DefaultBid ||
                    this.DefaultBid.Equals(input.DefaultBid)
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
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultBid.GetHashCode();
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
