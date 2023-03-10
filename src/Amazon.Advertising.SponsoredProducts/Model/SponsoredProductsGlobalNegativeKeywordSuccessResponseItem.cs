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
    /// SponsoredProductsGlobalNegativeKeywordSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalNegativeKeywordSuccessResponseItem")]
    public partial class SponsoredProductsGlobalNegativeKeywordSuccessResponseItem : IEquatable<SponsoredProductsGlobalNegativeKeywordSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeKeywordSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalNegativeKeywordSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeKeywordSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="index">the index of the negativeKeyword in the array from the request body (required).</param>
        /// <param name="negativeKeyword">negativeKeyword.</param>
        /// <param name="negativeKeywordId">the negativeKeyword ID.</param>
        public SponsoredProductsGlobalNegativeKeywordSuccessResponseItem(int index = default(int), SponsoredProductsGlobalNegativeKeyword negativeKeyword = default(SponsoredProductsGlobalNegativeKeyword), string negativeKeywordId = default(string))
        {
            this.Index = index;
            this.NegativeKeyword = negativeKeyword;
            this.NegativeKeywordId = negativeKeywordId;
        }

        /// <summary>
        /// the index of the negativeKeyword in the array from the request body
        /// </summary>
        /// <value>the index of the negativeKeyword in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets NegativeKeyword
        /// </summary>
        [DataMember(Name = "negativeKeyword", EmitDefaultValue = false)]
        public SponsoredProductsGlobalNegativeKeyword NegativeKeyword { get; set; }

        /// <summary>
        /// the negativeKeyword ID
        /// </summary>
        /// <value>the negativeKeyword ID</value>
        [DataMember(Name = "negativeKeywordId", EmitDefaultValue = false)]
        public string NegativeKeywordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalNegativeKeywordSuccessResponseItem {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  NegativeKeyword: ").Append(NegativeKeyword).Append("\n");
            sb.Append("  NegativeKeywordId: ").Append(NegativeKeywordId).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalNegativeKeywordSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalNegativeKeywordSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalNegativeKeywordSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalNegativeKeywordSuccessResponseItem input)
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
                    this.NegativeKeyword == input.NegativeKeyword ||
                    (this.NegativeKeyword != null &&
                    this.NegativeKeyword.Equals(input.NegativeKeyword))
                ) &&
                (
                    this.NegativeKeywordId == input.NegativeKeywordId ||
                    (this.NegativeKeywordId != null &&
                    this.NegativeKeywordId.Equals(input.NegativeKeywordId))
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
                if (this.NegativeKeyword != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeyword.GetHashCode();
                }
                if (this.NegativeKeywordId != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeywordId.GetHashCode();
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
