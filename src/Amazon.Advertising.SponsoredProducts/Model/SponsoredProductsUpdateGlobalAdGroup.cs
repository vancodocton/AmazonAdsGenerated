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
    /// SponsoredProductsUpdateGlobalAdGroup
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateGlobalAdGroup")]
    public partial class SponsoredProductsUpdateGlobalAdGroup : IEquatable<SponsoredProductsUpdateGlobalAdGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalAdGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateGlobalAdGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalAdGroup" /> class.
        /// </summary>
        /// <param name="applicableMarketplaces">applicableMarketplaces.</param>
        /// <param name="name">The name of the ad group..</param>
        /// <param name="state">state.</param>
        /// <param name="adGroupId">The identifier of the keyword. (required).</param>
        /// <param name="defaultBid">defaultBid.</param>
        public SponsoredProductsUpdateGlobalAdGroup(List<string> applicableMarketplaces = default(List<string>), string name = default(string), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState), string adGroupId = default(string), SponsoredProductsGlobalBid defaultBid = default(SponsoredProductsGlobalBid))
        {
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsUpdateGlobalAdGroup and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.ApplicableMarketplaces = applicableMarketplaces;
            this.Name = name;
            this.State = state;
            this.DefaultBid = defaultBid;
        }

        /// <summary>
        /// Gets or Sets ApplicableMarketplaces
        /// </summary>
        [DataMember(Name = "applicableMarketplaces", EmitDefaultValue = false)]
        public List<string> ApplicableMarketplaces { get; set; }

        /// <summary>
        /// The name of the ad group.
        /// </summary>
        /// <value>The name of the ad group.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// The identifier of the keyword.
        /// </summary>
        /// <value>The identifier of the keyword.</value>
        [DataMember(Name = "adGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBid
        /// </summary>
        [DataMember(Name = "defaultBid", EmitDefaultValue = false)]
        public SponsoredProductsGlobalBid DefaultBid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateGlobalAdGroup {\n");
            sb.Append("  ApplicableMarketplaces: ").Append(ApplicableMarketplaces).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateGlobalAdGroup);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateGlobalAdGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateGlobalAdGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateGlobalAdGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ApplicableMarketplaces == input.ApplicableMarketplaces ||
                    this.ApplicableMarketplaces != null &&
                    input.ApplicableMarketplaces != null &&
                    this.ApplicableMarketplaces.SequenceEqual(input.ApplicableMarketplaces)
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
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
                ) &&
                (
                    this.DefaultBid == input.DefaultBid ||
                    (this.DefaultBid != null &&
                    this.DefaultBid.Equals(input.DefaultBid))
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
                if (this.ApplicableMarketplaces != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicableMarketplaces.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
                }
                if (this.DefaultBid != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultBid.GetHashCode();
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
