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
    /// SponsoredProductsAdServingStatusDetail
    /// </summary>
    [DataContract(Name = "SponsoredProductsAdServingStatusDetail")]
    public partial class SponsoredProductsAdServingStatusDetail : IEquatable<SponsoredProductsAdServingStatusDetail>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public SponsoredProductsAdServingStatusReason? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsAdServingStatusDetail" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="helpUrl">A URL with additional information about the status identifier..</param>
        /// <param name="message">A human-readable description of the status identifier specified in the name field..</param>
        public SponsoredProductsAdServingStatusDetail(SponsoredProductsAdServingStatusReason? name = default(SponsoredProductsAdServingStatusReason?), string helpUrl = default(string), string message = default(string))
        {
            this.Name = name;
            this.HelpUrl = helpUrl;
            this.Message = message;
        }

        /// <summary>
        /// A URL with additional information about the status identifier.
        /// </summary>
        /// <value>A URL with additional information about the status identifier.</value>
        [DataMember(Name = "helpUrl", EmitDefaultValue = false)]
        public string HelpUrl { get; set; }

        /// <summary>
        /// A human-readable description of the status identifier specified in the name field.
        /// </summary>
        /// <value>A human-readable description of the status identifier specified in the name field.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsAdServingStatusDetail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HelpUrl: ").Append(HelpUrl).Append("\n");
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
            return this.Equals(input as SponsoredProductsAdServingStatusDetail);
        }

        /// <summary>
        /// Returns true if SponsoredProductsAdServingStatusDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsAdServingStatusDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsAdServingStatusDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.HelpUrl == input.HelpUrl ||
                    (this.HelpUrl != null &&
                    this.HelpUrl.Equals(input.HelpUrl))
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
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                if (this.HelpUrl != null)
                {
                    hashCode = (hashCode * 59) + this.HelpUrl.GetHashCode();
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
