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
    /// Clicks benchmark.
    /// </summary>
    [DataContract(Name = "Clicks")]
    public partial class Clicks : IEquatable<Clicks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clicks" /> class.
        /// </summary>
        /// <param name="lower">lower bound..</param>
        /// <param name="upper">upper bound..</param>
        public Clicks(int lower = default(int), int upper = default(int))
        {
            this.Lower = lower;
            this.Upper = upper;
        }

        /// <summary>
        /// lower bound.
        /// </summary>
        /// <value>lower bound.</value>
        [DataMember(Name = "lower", EmitDefaultValue = false)]
        public int Lower { get; set; }

        /// <summary>
        /// upper bound.
        /// </summary>
        /// <value>upper bound.</value>
        [DataMember(Name = "upper", EmitDefaultValue = false)]
        public int Upper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Clicks {\n");
            sb.Append("  Lower: ").Append(Lower).Append("\n");
            sb.Append("  Upper: ").Append(Upper).Append("\n");
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
            return this.Equals(input as Clicks);
        }

        /// <summary>
        /// Returns true if Clicks instances are equal
        /// </summary>
        /// <param name="input">Instance of Clicks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Clicks input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Lower == input.Lower ||
                    this.Lower.Equals(input.Lower)
                ) &&
                (
                    this.Upper == input.Upper ||
                    this.Upper.Equals(input.Upper)
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
                hashCode = (hashCode * 59) + this.Lower.GetHashCode();
                hashCode = (hashCode * 59) + this.Upper.GetHashCode();
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
