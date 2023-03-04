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
    /// SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem")]
    public partial class SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem : IEquatable<SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="targetId">the NegativeTargetingClause ID.</param>
        /// <param name="index">the index of the NegativeTargetingClause in the array from the request body (required).</param>
        /// <param name="negativeTargetingClause">negativeTargetingClause.</param>
        public SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem(string targetId = default(string), int index = default(int), SponsoredProductsGlobalNegativeTargetingClause negativeTargetingClause = default(SponsoredProductsGlobalNegativeTargetingClause))
        {
            this.Index = index;
            this.TargetId = targetId;
            this.NegativeTargetingClause = negativeTargetingClause;
        }

        /// <summary>
        /// the NegativeTargetingClause ID
        /// </summary>
        /// <value>the NegativeTargetingClause ID</value>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// the index of the NegativeTargetingClause in the array from the request body
        /// </summary>
        /// <value>the index of the NegativeTargetingClause in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets NegativeTargetingClause
        /// </summary>
        [DataMember(Name = "negativeTargetingClause", EmitDefaultValue = false)]
        public SponsoredProductsGlobalNegativeTargetingClause NegativeTargetingClause { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem {\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  NegativeTargetingClause: ").Append(NegativeTargetingClause).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalNegativeTargetingClauseSuccessResponseItem input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) &&
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) &&
                (
                    this.NegativeTargetingClause == input.NegativeTargetingClause ||
                    (this.NegativeTargetingClause != null &&
                    this.NegativeTargetingClause.Equals(input.NegativeTargetingClause))
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
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.NegativeTargetingClause != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeTargetingClause.GetHashCode();
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
