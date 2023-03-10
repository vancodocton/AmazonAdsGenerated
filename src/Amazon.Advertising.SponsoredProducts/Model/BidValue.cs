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
    /// Bid value of the bid recommendations
    /// </summary>
    [DataContract(Name = "BidValue")]
    public partial class BidValue : IEquatable<BidValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BidValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BidValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BidValue" /> class.
        /// </summary>
        /// <param name="suggestedBid">The suggested bid. (required).</param>
        public BidValue(double suggestedBid = default(double))
        {
            this.SuggestedBid = suggestedBid;
        }

        /// <summary>
        /// The suggested bid.
        /// </summary>
        /// <value>The suggested bid.</value>
        [DataMember(Name = "suggestedBid", IsRequired = true, EmitDefaultValue = true)]
        public double SuggestedBid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BidValue {\n");
            sb.Append("  SuggestedBid: ").Append(SuggestedBid).Append("\n");
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
            return this.Equals(input as BidValue);
        }

        /// <summary>
        /// Returns true if BidValue instances are equal
        /// </summary>
        /// <param name="input">Instance of BidValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidValue input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SuggestedBid == input.SuggestedBid ||
                    this.SuggestedBid.Equals(input.SuggestedBid)
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
                hashCode = (hashCode * 59) + this.SuggestedBid.GetHashCode();
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
            // SuggestedBid (double) minimum
            if (this.SuggestedBid < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SuggestedBid, must be a value greater than or equal to 0.", new[] { "SuggestedBid" });
            }

            yield break;
        }
    }

}
