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
    /// SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent")]
    public partial class SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent : IEquatable<SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent" /> class.
        /// </summary>
        /// <param name="targetingClauses">targetingClauses (required).</param>
        public SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent(List<SponsoredProductsUpdateGlobalTargetingClause> targetingClauses = default(List<SponsoredProductsUpdateGlobalTargetingClause>))
        {
            // to ensure "targetingClauses" is required (not null)
            if (targetingClauses == null)
            {
                throw new ArgumentNullException("targetingClauses is a required property for SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent and cannot be null");
            }
            this.TargetingClauses = targetingClauses;
        }

        /// <summary>
        /// Gets or Sets TargetingClauses
        /// </summary>
        [DataMember(Name = "targetingClauses", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsUpdateGlobalTargetingClause> TargetingClauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent {\n");
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
            return this.Equals(input as SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateSponsoredProductsGlobalTargetingClausesRequestContent input)
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
