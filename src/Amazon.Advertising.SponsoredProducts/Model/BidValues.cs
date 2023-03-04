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
    /// Suggested bid range
    /// </summary>
    [DataContract(Name = "BidValues")]
    public partial class BidValues : IEquatable<BidValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BidValues" /> class.
        /// </summary>
        /// <param name="suggested">The suggested bid.</param>
        /// <param name="rangeStart">The bid range start.</param>
        /// <param name="rangeEnd">The bid range end.</param>
        public BidValues(double suggested = default(double), double rangeStart = default(double), double rangeEnd = default(double))
        {
            this.Suggested = suggested;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        /// <summary>
        /// The suggested bid
        /// </summary>
        /// <value>The suggested bid</value>
        [DataMember(Name = "suggested", EmitDefaultValue = false)]
        public double Suggested { get; set; }

        /// <summary>
        /// The bid range start
        /// </summary>
        /// <value>The bid range start</value>
        [DataMember(Name = "rangeStart", EmitDefaultValue = false)]
        public double RangeStart { get; set; }

        /// <summary>
        /// The bid range end
        /// </summary>
        /// <value>The bid range end</value>
        [DataMember(Name = "rangeEnd", EmitDefaultValue = false)]
        public double RangeEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BidValues {\n");
            sb.Append("  Suggested: ").Append(Suggested).Append("\n");
            sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
            sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
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
            return this.Equals(input as BidValues);
        }

        /// <summary>
        /// Returns true if BidValues instances are equal
        /// </summary>
        /// <param name="input">Instance of BidValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidValues input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Suggested == input.Suggested ||
                    this.Suggested.Equals(input.Suggested)
                ) &&
                (
                    this.RangeStart == input.RangeStart ||
                    this.RangeStart.Equals(input.RangeStart)
                ) &&
                (
                    this.RangeEnd == input.RangeEnd ||
                    this.RangeEnd.Equals(input.RangeEnd)
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
                hashCode = (hashCode * 59) + this.Suggested.GetHashCode();
                hashCode = (hashCode * 59) + this.RangeStart.GetHashCode();
                hashCode = (hashCode * 59) + this.RangeEnd.GetHashCode();
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
