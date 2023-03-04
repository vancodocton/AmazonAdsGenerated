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
    /// SponsoredProductsDynamicBidding
    /// </summary>
    [DataContract(Name = "SponsoredProductsDynamicBidding")]
    public partial class SponsoredProductsDynamicBidding : IEquatable<SponsoredProductsDynamicBidding>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBiddingStrategy Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDynamicBidding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDynamicBidding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDynamicBidding" /> class.
        /// </summary>
        /// <param name="placementBidding">placementBidding.</param>
        /// <param name="strategy">strategy (required).</param>
        public SponsoredProductsDynamicBidding(List<SponsoredProductsPlacementBidding> placementBidding = default(List<SponsoredProductsPlacementBidding>), SponsoredProductsBiddingStrategy strategy = default(SponsoredProductsBiddingStrategy))
        {
            this.Strategy = strategy;
            this.PlacementBidding = placementBidding;
        }

        /// <summary>
        /// Gets or Sets PlacementBidding
        /// </summary>
        [DataMember(Name = "placementBidding", EmitDefaultValue = false)]
        public List<SponsoredProductsPlacementBidding> PlacementBidding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDynamicBidding {\n");
            sb.Append("  PlacementBidding: ").Append(PlacementBidding).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
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
            return this.Equals(input as SponsoredProductsDynamicBidding);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDynamicBidding instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDynamicBidding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDynamicBidding input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.PlacementBidding == input.PlacementBidding ||
                    this.PlacementBidding != null &&
                    input.PlacementBidding != null &&
                    this.PlacementBidding.SequenceEqual(input.PlacementBidding)
                ) &&
                (
                    this.Strategy == input.Strategy ||
                    this.Strategy.Equals(input.Strategy)
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
                if (this.PlacementBidding != null)
                {
                    hashCode = (hashCode * 59) + this.PlacementBidding.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
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
