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
    /// SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent" /> class.
        /// </summary>
        /// <param name="targetingClauses">targetingClauses (required).</param>
        public SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent(List<SponsoredProductsCreateDraftTargetingClause> targetingClauses = default(List<SponsoredProductsCreateDraftTargetingClause>))
        {
            // to ensure "targetingClauses" is required (not null)
            if (targetingClauses == null)
            {
                throw new ArgumentNullException("targetingClauses is a required property for SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent and cannot be null");
            }
            this.TargetingClauses = targetingClauses;
        }

        /// <summary>
        /// Gets or Sets TargetingClauses
        /// </summary>
        [DataMember(Name = "targetingClauses", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateDraftTargetingClause> TargetingClauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent {\n");
            sb.Append("  TargetingClauses: ").Append(TargetingClauses).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsDraftTargetingClausesRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TargetingClauses == input.TargetingClauses ||
                    this.TargetingClauses != null &&
                    input.TargetingClauses != null &&
                    this.TargetingClauses.SequenceEqual(input.TargetingClauses)
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
                if (this.TargetingClauses != null)
                {
                    hashCode = (hashCode * 59) + this.TargetingClauses.GetHashCode();
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
