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
    /// SponsoredProductsBulkDraftKeywordOperationResponse
    /// </summary>
    [DataContract(Name = "SponsoredProductsBulkDraftKeywordOperationResponse")]
    public partial class SponsoredProductsBulkDraftKeywordOperationResponse : IEquatable<SponsoredProductsBulkDraftKeywordOperationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsBulkDraftKeywordOperationResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        public SponsoredProductsBulkDraftKeywordOperationResponse(List<SponsoredProductsDraftKeywordSuccessResponseItem> success = default(List<SponsoredProductsDraftKeywordSuccessResponseItem>), List<SponsoredProductsDraftKeywordFailureResponseItem> error = default(List<SponsoredProductsDraftKeywordFailureResponseItem>))
        {
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public List<SponsoredProductsDraftKeywordSuccessResponseItem> Success { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public List<SponsoredProductsDraftKeywordFailureResponseItem> Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsBulkDraftKeywordOperationResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as SponsoredProductsBulkDraftKeywordOperationResponse);
        }

        /// <summary>
        /// Returns true if SponsoredProductsBulkDraftKeywordOperationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsBulkDraftKeywordOperationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsBulkDraftKeywordOperationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Success == input.Success ||
                    this.Success != null &&
                    input.Success != null &&
                    this.Success.SequenceEqual(input.Success)
                ) && 
                (
                    this.Error == input.Error ||
                    this.Error != null &&
                    input.Error != null &&
                    this.Error.SequenceEqual(input.Error)
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
                if (this.Success != null)
                {
                    hashCode = (hashCode * 59) + this.Success.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
