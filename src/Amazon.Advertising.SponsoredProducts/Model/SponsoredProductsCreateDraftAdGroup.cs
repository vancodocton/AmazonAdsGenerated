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
    /// SponsoredProductsCreateDraftAdGroup
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateDraftAdGroup")]
    public partial class SponsoredProductsCreateDraftAdGroup : IEquatable<SponsoredProductsCreateDraftAdGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateDraftAdGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateDraftAdGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateDraftAdGroup" /> class.
        /// </summary>
        /// <param name="campaignId">The identifier of the campaign to which the keyword is associated. (required).</param>
        /// <param name="name">The name of the ad group..</param>
        /// <param name="defaultBid">A bid value for use when no bid is specified for keywords in the ad group. (required).</param>
        public SponsoredProductsCreateDraftAdGroup(string campaignId = default(string), string name = default(string), double defaultBid = default(double))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for SponsoredProductsCreateDraftAdGroup and cannot be null");
            }
            this.CampaignId = campaignId;
            this.DefaultBid = defaultBid;
            this.Name = name;
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
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A bid value for use when no bid is specified for keywords in the ad group.
        /// </summary>
        /// <value>A bid value for use when no bid is specified for keywords in the ad group.</value>
        [DataMember(Name = "defaultBid", IsRequired = true, EmitDefaultValue = true)]
        public double DefaultBid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateDraftAdGroup {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultBid: ").Append(DefaultBid).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateDraftAdGroup);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateDraftAdGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateDraftAdGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateDraftAdGroup input)
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
                    this.DefaultBid == input.DefaultBid ||
                    this.DefaultBid.Equals(input.DefaultBid)
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
                hashCode = (hashCode * 59) + this.DefaultBid.GetHashCode();
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
