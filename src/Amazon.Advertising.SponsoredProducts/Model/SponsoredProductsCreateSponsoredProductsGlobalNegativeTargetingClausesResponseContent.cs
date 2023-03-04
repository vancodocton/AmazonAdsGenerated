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
    /// SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent")]
    public partial class SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent : IEquatable<SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent" /> class.
        /// </summary>
        /// <param name="negativeTargetingClauses">negativeTargetingClauses (required).</param>
        public SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent(SponsoredProductsBulkGlobalNegativeTargetingClauseOperationResponse negativeTargetingClauses = default(SponsoredProductsBulkGlobalNegativeTargetingClauseOperationResponse))
        {
            // to ensure "negativeTargetingClauses" is required (not null)
            if (negativeTargetingClauses == null)
            {
                throw new ArgumentNullException("negativeTargetingClauses is a required property for SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent and cannot be null");
            }
            this.NegativeTargetingClauses = negativeTargetingClauses;
        }

        /// <summary>
        /// Gets or Sets NegativeTargetingClauses
        /// </summary>
        [DataMember(Name = "negativeTargetingClauses", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBulkGlobalNegativeTargetingClauseOperationResponse NegativeTargetingClauses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent {\n");
            sb.Append("  NegativeTargetingClauses: ").Append(NegativeTargetingClauses).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsGlobalNegativeTargetingClausesResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NegativeTargetingClauses == input.NegativeTargetingClauses ||
                    (this.NegativeTargetingClauses != null &&
                    this.NegativeTargetingClauses.Equals(input.NegativeTargetingClauses))
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
                if (this.NegativeTargetingClauses != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeTargetingClauses.GetHashCode();
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
