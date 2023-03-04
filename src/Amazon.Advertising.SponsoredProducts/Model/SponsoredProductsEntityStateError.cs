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
    /// entity state update errors
    /// </summary>
    [DataContract(Name = "SponsoredProductsEntityStateError")]
    public partial class SponsoredProductsEntityStateError : IEquatable<SponsoredProductsEntityStateError>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsEntityStateErrorReason Reason { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "marketplace", EmitDefaultValue = false)]
        public SponsoredProductsMarketplace? Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entityType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsEntityType EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsEntityStateError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsEntityStateError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsEntityStateError" /> class.
        /// </summary>
        /// <param name="reason">reason (required).</param>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="entityType">entityType (required).</param>
        /// <param name="cause">cause.</param>
        /// <param name="message">Human readable error message (required).</param>
        public SponsoredProductsEntityStateError(SponsoredProductsEntityStateErrorReason reason = default(SponsoredProductsEntityStateErrorReason), SponsoredProductsMarketplace? marketplace = default(SponsoredProductsMarketplace?), SponsoredProductsEntityType entityType = default(SponsoredProductsEntityType), SponsoredProductsErrorCause cause = default(SponsoredProductsErrorCause), string message = default(string))
        {
            this.Reason = reason;
            this.EntityType = entityType;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SponsoredProductsEntityStateError and cannot be null");
            }
            this.Message = message;
            this.Marketplace = marketplace;
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
            sb.Append("class SponsoredProductsEntityStateError {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(input as SponsoredProductsEntityStateError);
        }

        /// <summary>
        /// Returns true if SponsoredProductsEntityStateError instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsEntityStateError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsEntityStateError input)
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
                    this.EntityType == input.EntityType ||
                    this.EntityType.Equals(input.EntityType)
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
                hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
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
