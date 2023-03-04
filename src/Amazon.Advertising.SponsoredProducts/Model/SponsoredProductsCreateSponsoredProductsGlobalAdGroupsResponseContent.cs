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
    /// SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent")]
    public partial class SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent : IEquatable<SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent" /> class.
        /// </summary>
        /// <param name="adGroups">adGroups (required).</param>
        public SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent(SponsoredProductsBulkGlobalAdGroupOperationResponse adGroups = default(SponsoredProductsBulkGlobalAdGroupOperationResponse))
        {
            // to ensure "adGroups" is required (not null)
            if (adGroups == null)
            {
                throw new ArgumentNullException("adGroups is a required property for SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent and cannot be null");
            }
            this.AdGroups = adGroups;
        }

        /// <summary>
        /// Gets or Sets AdGroups
        /// </summary>
        [DataMember(Name = "adGroups", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsBulkGlobalAdGroupOperationResponse AdGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent {\n");
            sb.Append("  AdGroups: ").Append(AdGroups).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsGlobalAdGroupsResponseContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AdGroups == input.AdGroups ||
                    (this.AdGroups != null &&
                    this.AdGroups.Equals(input.AdGroups))
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
                if (this.AdGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroups.GetHashCode();
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
