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
    /// Specifies bid adjustments based on the placement location. Use &#x60;PLACEMENT_TOP&#x60; for the top of the search page. Use &#x60;PLACEMENT_PRODUCT_PAGE&#x60; for a product page.
    /// </summary>
    [DataContract(Name = "PlacementAdjustment")]
    public partial class PlacementAdjustment : IEquatable<PlacementAdjustment>, IValidatableObject
    {
        /// <summary>
        /// Defines Predicate
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PredicateEnum
        {
            /// <summary>
            /// Enum TOP for value: PLACEMENT_TOP
            /// </summary>
            [EnumMember(Value = "PLACEMENT_TOP")]
            TOP = 1,

            /// <summary>
            /// Enum PRODUCTPAGE for value: PLACEMENT_PRODUCT_PAGE
            /// </summary>
            [EnumMember(Value = "PLACEMENT_PRODUCT_PAGE")]
            PRODUCTPAGE = 2

        }


        /// <summary>
        /// Gets or Sets Predicate
        /// </summary>
        [DataMember(Name = "predicate", EmitDefaultValue = false)]
        public PredicateEnum? Predicate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementAdjustment" /> class.
        /// </summary>
        /// <param name="predicate">predicate.</param>
        /// <param name="percentage">percentage.</param>
        public PlacementAdjustment(PredicateEnum? predicate = default(PredicateEnum?), int percentage = default(int))
        {
            this.Predicate = predicate;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public int Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlacementAdjustment {\n");
            sb.Append("  Predicate: ").Append(Predicate).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as PlacementAdjustment);
        }

        /// <summary>
        /// Returns true if PlacementAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of PlacementAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlacementAdjustment input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Predicate == input.Predicate ||
                    this.Predicate.Equals(input.Predicate)
                ) &&
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
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
                hashCode = (hashCode * 59) + this.Predicate.GetHashCode();
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
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
            // Percentage (int) maximum
            if (this.Percentage > (int)900)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value less than or equal to 900.", new[] { "Percentage" });
            }

            // Percentage (int) minimum
            if (this.Percentage < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value greater than or equal to 0.", new[] { "Percentage" });
            }

            yield break;
        }
    }

}
