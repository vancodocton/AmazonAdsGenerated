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
    /// AdGroup
    /// </summary>
    [DataContract(Name = "AdGroup")]
    public partial class AdGroup : IEquatable<AdGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdGroup" /> class.
        /// </summary>
        /// <param name="targetingExpressions">The list of targeting expressions. Maximum of 100 per request. (required).</param>
        /// <param name="asins">The list of ad ASINs in the ad group. (required).</param>
        /// <param name="adGroupId">The ad group identifier..</param>
        public AdGroup(List<TargetingExpression> targetingExpressions = default(List<TargetingExpression>), List<string> asins = default(List<string>), string adGroupId = default(string))
        {
            // to ensure "targetingExpressions" is required (not null)
            if (targetingExpressions == null)
            {
                throw new ArgumentNullException("targetingExpressions is a required property for AdGroup and cannot be null");
            }
            this.TargetingExpressions = targetingExpressions;
            // to ensure "asins" is required (not null)
            if (asins == null)
            {
                throw new ArgumentNullException("asins is a required property for AdGroup and cannot be null");
            }
            this.Asins = asins;
            this.AdGroupId = adGroupId;
        }

        /// <summary>
        /// The list of targeting expressions. Maximum of 100 per request.
        /// </summary>
        /// <value>The list of targeting expressions. Maximum of 100 per request.</value>
        [DataMember(Name = "targetingExpressions", IsRequired = true, EmitDefaultValue = true)]
        public List<TargetingExpression> TargetingExpressions { get; set; }

        /// <summary>
        /// The list of ad ASINs in the ad group.
        /// </summary>
        /// <value>The list of ad ASINs in the ad group.</value>
        [DataMember(Name = "asins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Asins { get; set; }

        /// <summary>
        /// The ad group identifier.
        /// </summary>
        /// <value>The ad group identifier.</value>
        [DataMember(Name = "adGroupId", EmitDefaultValue = false)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdGroup {\n");
            sb.Append("  TargetingExpressions: ").Append(TargetingExpressions).Append("\n");
            sb.Append("  Asins: ").Append(Asins).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as AdGroup);
        }

        /// <summary>
        /// Returns true if AdGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AdGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TargetingExpressions == input.TargetingExpressions ||
                    this.TargetingExpressions != null &&
                    input.TargetingExpressions != null &&
                    this.TargetingExpressions.SequenceEqual(input.TargetingExpressions)
                ) &&
                (
                    this.Asins == input.Asins ||
                    this.Asins != null &&
                    input.Asins != null &&
                    this.Asins.SequenceEqual(input.Asins)
                ) &&
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                if (this.TargetingExpressions != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingExpressions.GetHashCode();
                }
                if (this.Asins != null)
                {
                    hashCode = (hashCode * 59) + this.Asins.GetHashCode();
                }
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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
