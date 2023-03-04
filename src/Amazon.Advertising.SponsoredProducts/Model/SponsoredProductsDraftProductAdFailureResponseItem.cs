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
    /// SponsoredProductsDraftProductAdFailureResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsDraftProductAdFailureResponseItem")]
    public partial class SponsoredProductsDraftProductAdFailureResponseItem : IEquatable<SponsoredProductsDraftProductAdFailureResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftProductAdFailureResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDraftProductAdFailureResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftProductAdFailureResponseItem" /> class.
        /// </summary>
        /// <param name="index">the index of the campaign in the array from the request body (required).</param>
        /// <param name="errors">A list of validation errors.</param>
        public SponsoredProductsDraftProductAdFailureResponseItem(int index = default(int), List<SponsoredProductsDraftProductAdMutationError> errors = default(List<SponsoredProductsDraftProductAdMutationError>))
        {
            this.Index = index;
            this.Errors = errors;
        }

        /// <summary>
        /// the index of the campaign in the array from the request body
        /// </summary>
        /// <value>the index of the campaign in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// A list of validation errors
        /// </summary>
        /// <value>A list of validation errors</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<SponsoredProductsDraftProductAdMutationError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDraftProductAdFailureResponseItem {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as SponsoredProductsDraftProductAdFailureResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDraftProductAdFailureResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDraftProductAdFailureResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDraftProductAdFailureResponseItem input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
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
            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new[] { "Index" });
            }

            yield break;
        }
    }

}
