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
    /// SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent")]
    public partial class SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent : IEquatable<SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent" /> class.
        /// </summary>
        /// <param name="negativeTargetIdFilter">negativeTargetIdFilter (required).</param>
        public SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent(SponsoredProductsObjectIdFilter negativeTargetIdFilter = default(SponsoredProductsObjectIdFilter))
        {
            // to ensure "negativeTargetIdFilter" is required (not null)
            if (negativeTargetIdFilter == null)
            {
                throw new ArgumentNullException("negativeTargetIdFilter is a required property for SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent and cannot be null");
            }
            this.NegativeTargetIdFilter = negativeTargetIdFilter;
        }

        /// <summary>
        /// Gets or Sets NegativeTargetIdFilter
        /// </summary>
        [DataMember(Name = "negativeTargetIdFilter", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsObjectIdFilter NegativeTargetIdFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent {\n");
            sb.Append("  NegativeTargetIdFilter: ").Append(NegativeTargetIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDeleteSponsoredProductsNegativeTargetingClausesRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NegativeTargetIdFilter == input.NegativeTargetIdFilter ||
                    (this.NegativeTargetIdFilter != null &&
                    this.NegativeTargetIdFilter.Equals(input.NegativeTargetIdFilter))
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
                if (this.NegativeTargetIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeTargetIdFilter.GetHashCode();
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
