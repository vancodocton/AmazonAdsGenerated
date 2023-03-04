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
    /// Errors related to range constraints violations
    /// </summary>
    [DataContract(Name = "SponsoredProductsRangeError")]
    public partial class SponsoredProductsRangeError : IEquatable<SponsoredProductsRangeError>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsValueLimitErrorReason Reason { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsRangeError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsRangeError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsRangeError" /> class.
        /// </summary>
        /// <param name="reason">reason (required).</param>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="allowed">allowed values.</param>
        /// <param name="cause">cause.</param>
        /// <param name="upperLimit">optional upper limit.</param>
        /// <param name="lowerLimit">optional lower limit.</param>
        /// <param name="message">Human readable error message (required).</param>
        public SponsoredProductsRangeError(SponsoredProductsValueLimitErrorReason reason = default(SponsoredProductsValueLimitErrorReason), SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), List<string> allowed = default(List<string>), SponsoredProductsErrorCause cause = default(SponsoredProductsErrorCause), string upperLimit = default(string), string lowerLimit = default(string), string message = default(string))
        {
            this.Reason = reason;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SponsoredProductsRangeError and cannot be null");
            }
            this.Message = message;
            this.Marketplace = marketplace;
            this.Allowed = allowed;
            this.Cause = cause;
            this.UpperLimit = upperLimit;
            this.LowerLimit = lowerLimit;
        }

        /// <summary>
        /// allowed values
        /// </summary>
        /// <value>allowed values</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public List<string> Allowed { get; set; }

        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name = "cause", EmitDefaultValue = false)]
        public SponsoredProductsErrorCause Cause { get; set; }

        /// <summary>
        /// optional upper limit
        /// </summary>
        /// <value>optional upper limit</value>
        [DataMember(Name = "upperLimit", EmitDefaultValue = false)]
        public string UpperLimit { get; set; }

        /// <summary>
        /// optional lower limit
        /// </summary>
        /// <value>optional lower limit</value>
        [DataMember(Name = "lowerLimit", EmitDefaultValue = false)]
        public string LowerLimit { get; set; }

        /// <summary>
        /// Human readable error message
        /// </summary>
        /// <value>Human readable error message</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsRangeError {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
            sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as SponsoredProductsRangeError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsRangeError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsRangeError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsRangeError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.Marketplace == input.Marketplace ||
                    this.Marketplace.Equals(input.Marketplace)
                ) && 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed != null &&
                    input.Allowed != null &&
                    this.Allowed.SequenceEqual(input.Allowed)
                ) && 
                (
                    this.Cause == input.Cause ||
                    (this.Cause != null &&
                    this.Cause.Equals(input.Cause))
                ) && 
                (
                    this.UpperLimit == input.UpperLimit ||
                    (this.UpperLimit != null &&
                    this.UpperLimit.Equals(input.UpperLimit))
                ) && 
                (
                    this.LowerLimit == input.LowerLimit ||
                    (this.LowerLimit != null &&
                    this.LowerLimit.Equals(input.LowerLimit))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                if (this.Allowed != null)
                {
                    hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                }
                if (this.Cause != null)
                {
                    hashCode = (hashCode * 59) + this.Cause.GetHashCode();
                }
                if (this.UpperLimit != null)
                {
                    hashCode = (hashCode * 59) + this.UpperLimit.GetHashCode();
                }
                if (this.LowerLimit != null)
                {
                    hashCode = (hashCode * 59) + this.LowerLimit.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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