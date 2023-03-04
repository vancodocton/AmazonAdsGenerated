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
    /// Errors being used to represent an unsupported operation e.g. Seller are not supported to create custom text product ads.
    /// </summary>
    [DataContract(Name = "SponsoredProductsUnsupportedOperationError")]
    public partial class SponsoredProductsUnsupportedOperationError : IEquatable<SponsoredProductsUnsupportedOperationError>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsUnsupportedOperationErrorReason Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUnsupportedOperationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUnsupportedOperationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUnsupportedOperationError" /> class.
        /// </summary>
        /// <param name="reason">reason (required).</param>
        /// <param name="cause">cause.</param>
        /// <param name="message">Human readable error message (required).</param>
        public SponsoredProductsUnsupportedOperationError(SponsoredProductsUnsupportedOperationErrorReason reason = default(SponsoredProductsUnsupportedOperationErrorReason), SponsoredProductsErrorCause cause = default(SponsoredProductsErrorCause), string message = default(string))
        {
            this.Reason = reason;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SponsoredProductsUnsupportedOperationError and cannot be null");
            }
            this.Message = message;
            this.Cause = cause;
        }

        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name = "cause", EmitDefaultValue = false)]
        public SponsoredProductsErrorCause Cause { get; set; }

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
            sb.Append("class SponsoredProductsUnsupportedOperationError {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
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
            return this.Equals(input as SponsoredProductsUnsupportedOperationError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUnsupportedOperationError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUnsupportedOperationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUnsupportedOperationError input)
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
