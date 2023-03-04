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
    /// SponsoredProductsDraftTargetingClauseSuccessResponseItem
    /// </summary>
    [DataContract(Name = "SponsoredProductsDraftTargetingClauseSuccessResponseItem")]
    public partial class SponsoredProductsDraftTargetingClauseSuccessResponseItem : IEquatable<SponsoredProductsDraftTargetingClauseSuccessResponseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftTargetingClauseSuccessResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDraftTargetingClauseSuccessResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDraftTargetingClauseSuccessResponseItem" /> class.
        /// </summary>
        /// <param name="targetingClause">targetingClause.</param>
        /// <param name="targetId">the draftTargetingClause ID.</param>
        /// <param name="index">the index of the draftTargetingClause in the array from the request body (required).</param>
        public SponsoredProductsDraftTargetingClauseSuccessResponseItem(SponsoredProductsDraftTargetingClause targetingClause = default(SponsoredProductsDraftTargetingClause), string targetId = default(string), int index = default(int))
        {
            this.Index = index;
            this.TargetingClause = targetingClause;
            this.TargetId = targetId;
        }

        /// <summary>
        /// Gets or Sets TargetingClause
        /// </summary>
        [DataMember(Name = "targetingClause", EmitDefaultValue = false)]
        public SponsoredProductsDraftTargetingClause TargetingClause { get; set; }

        /// <summary>
        /// the draftTargetingClause ID
        /// </summary>
        /// <value>the draftTargetingClause ID</value>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// the index of the draftTargetingClause in the array from the request body
        /// </summary>
        /// <value>the index of the draftTargetingClause in the array from the request body</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDraftTargetingClauseSuccessResponseItem {\n");
            sb.Append("  TargetingClause: ").Append(TargetingClause).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as SponsoredProductsDraftTargetingClauseSuccessResponseItem);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDraftTargetingClauseSuccessResponseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDraftTargetingClauseSuccessResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDraftTargetingClauseSuccessResponseItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TargetingClause == input.TargetingClause ||
                    (this.TargetingClause != null &&
                    this.TargetingClause.Equals(input.TargetingClause))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                if (this.TargetingClause != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingClause.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
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
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            yield break;
        }
    }

}
