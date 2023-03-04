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
    /// SponsoredProductsUpdateAdGroup
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateAdGroup")]
    public partial class SponsoredProductsUpdateAdGroup : IEquatable<SponsoredProductsUpdateAdGroup>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateEntityState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateAdGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateAdGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateAdGroup" /> class.
        /// </summary>
        /// <param name="name">The name of the ad group. (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="adGroupId">The identifier of the keyword. (required).</param>
        /// <param name="defaultBid">A bid value for use when no bid is specified for keywords in the ad group. (required).</param>
        public SponsoredProductsUpdateAdGroup(string name = default(string), SponsoredProductsCreateOrUpdateEntityState state = default(SponsoredProductsCreateOrUpdateEntityState), string adGroupId = default(string), double defaultBid = default(double))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SponsoredProductsUpdateAdGroup and cannot be null");
            }
            this.Name = name;
            this.State = state;
            // to ensure "adGroupId" is required (not null)
            if (adGroupId == null)
            {
                throw new ArgumentNullException("adGroupId is a required property for SponsoredProductsUpdateAdGroup and cannot be null");
            }
            this.AdGroupId = adGroupId;
            this.DefaultBid = defaultBid;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateAdGroup {\n");
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
            return this.Equals(input as SponsoredProductsUpdateAdGroup);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateAdGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateAdGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateAdGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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
