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
    /// SponsoredProductsBudgetError
    /// </summary>
    [DataContract(Name = "SponsoredProductsBudgetError")]
    public partial class SponsoredProductsBudgetError : IEquatable<SponsoredProductsBudgetError>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBudgetErrorReason Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsBudgetError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsBudgetError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsBudgetError" /> class.
        /// </summary>
        /// <param name="reason">reason (required).</param>
        /// <param name="cause">cause.</param>
        /// <param name="upperLimit">upperLimit.</param>
        /// <param name="lowerLimit">lowerLimit.</param>
        /// <param name="message">Human readable error message (required).</param>
        public SponsoredProductsBudgetError(SponsoredProductsBudgetErrorReason reason = default(SponsoredProductsBudgetErrorReason), SponsoredProductsErrorCause cause = default(SponsoredProductsErrorCause), string upperLimit = default(string), string lowerLimit = default(string), string message = default(string))
        {
            this.Reason = reason;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SponsoredProductsBudgetError and cannot be null");
            }
            this.Message = message;
            this.Cause = cause;
            this.UpperLimit = upperLimit;
            this.LowerLimit = lowerLimit;
        }

        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name = "cause", EmitDefaultValue = false)]
        public SponsoredProductsErrorCause Cause { get; set; }

        /// <summary>
        /// Gets or Sets UpperLimit
        /// </summary>
        [DataMember(Name = "upperLimit", EmitDefaultValue = false)]
        public string UpperLimit { get; set; }

        /// <summary>
        /// Gets or Sets LowerLimit
        /// </summary>
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
            sb.Append("class SponsoredProductsBudgetError {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as SponsoredProductsBudgetError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsBudgetError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsBudgetError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsBudgetError input)
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
