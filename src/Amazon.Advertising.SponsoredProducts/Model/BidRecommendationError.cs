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
    /// BidRecommendationError
    /// </summary>
    [DataContract(Name = "BidRecommendationError")]
    public partial class BidRecommendationError : IEquatable<BidRecommendationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BidRecommendationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BidRecommendationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BidRecommendationError" /> class.
        /// </summary>
        /// <param name="code">A machine-readable error code. (required).</param>
        /// <param name="details">A human-readable description of the response. (required).</param>
        public BidRecommendationError(string code = default(string), string details = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for BidRecommendationError and cannot be null");
            }
            this.Code = code;
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new ArgumentNullException("details is a required property for BidRecommendationError and cannot be null");
            }
            this.Details = details;
        }

        /// <summary>
        /// A machine-readable error code.
        /// </summary>
        /// <value>A machine-readable error code.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable description of the response.
        /// </summary>
        /// <value>A human-readable description of the response.</value>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BidRecommendationError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as BidRecommendationError);
        }

        /// <summary>
        /// Returns true if BidRecommendationError instances are equal
        /// </summary>
        /// <param name="input">Instance of BidRecommendationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidRecommendationError input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
