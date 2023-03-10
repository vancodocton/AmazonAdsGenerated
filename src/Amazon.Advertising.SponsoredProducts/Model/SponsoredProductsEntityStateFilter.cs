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
    /// Filter entities by state
    /// </summary>
    [DataContract(Name = "SponsoredProductsEntityStateFilter")]
    public partial class SponsoredProductsEntityStateFilter : IEquatable<SponsoredProductsEntityStateFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsEntityStateFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsEntityStateFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsEntityStateFilter" /> class.
        /// </summary>
        /// <param name="include">include (required).</param>
        public SponsoredProductsEntityStateFilter(List<SponsoredProductsEntityState> include = default(List<SponsoredProductsEntityState>))
        {
            // to ensure "include" is required (not null)
            if (include == null)
            {
                throw new ArgumentNullException("include is a required property for SponsoredProductsEntityStateFilter and cannot be null");
            }
            this.Include = include;
        }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsEntityState> Include { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsEntityStateFilter {\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
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
            return this.Equals(input as SponsoredProductsEntityStateFilter);
        }

        /// <summary>
        /// Returns true if SponsoredProductsEntityStateFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsEntityStateFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsEntityStateFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Include == input.Include ||
                    this.Include != null &&
                    input.Include != null &&
                    this.Include.SequenceEqual(input.Include)
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
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
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
