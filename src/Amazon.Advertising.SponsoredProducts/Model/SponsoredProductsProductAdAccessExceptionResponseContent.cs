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
    /// Exception resulting in accessing campaign management entities
    /// </summary>
    [DataContract(Name = "SponsoredProductsProductAdAccessExceptionResponseContent")]
    public partial class SponsoredProductsProductAdAccessExceptionResponseContent : IEquatable<SponsoredProductsProductAdAccessExceptionResponseContent>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsInvalidArgumentErrorCode Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdAccessExceptionResponseContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsProductAdAccessExceptionResponseContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdAccessExceptionResponseContent" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="message">Human readable error message (required).</param>
        /// <param name="errors">errors.</param>
        public SponsoredProductsProductAdAccessExceptionResponseContent(SponsoredProductsInvalidArgumentErrorCode code = default(SponsoredProductsInvalidArgumentErrorCode), string message = default(string), List<SponsoredProductsProductAdAccessError> errors = default(List<SponsoredProductsProductAdAccessError>))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SponsoredProductsProductAdAccessExceptionResponseContent and cannot be null");
            }
            this.Message = message;
            this.Errors = errors;
        }

        /// <summary>
        /// Human readable error message
        /// </summary>
        /// <value>Human readable error message</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<SponsoredProductsProductAdAccessError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsProductAdAccessExceptionResponseContent {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as SponsoredProductsProductAdAccessExceptionResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsProductAdAccessExceptionResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsProductAdAccessExceptionResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsProductAdAccessExceptionResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) &&
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) &&
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
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
