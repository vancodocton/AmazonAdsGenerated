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
    /// SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent" /> class.
        /// </summary>
        /// <param name="adGroups">adGroups (required).</param>
        public SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent(List<SponsoredProductsCreateAdGroup> adGroups = default(List<SponsoredProductsCreateAdGroup>))
        {
            // to ensure "adGroups" is required (not null)
            if (adGroups == null)
            {
                throw new ArgumentNullException("adGroups is a required property for SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent and cannot be null");
            }
            this.AdGroups = adGroups;
        }

        /// <summary>
        /// Gets or Sets AdGroups
        /// </summary>
        [DataMember(Name = "adGroups", IsRequired = true, EmitDefaultValue = true)]
        public List<SponsoredProductsCreateAdGroup> AdGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent {\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsAdGroupsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AdGroups == input.AdGroups ||
                    this.AdGroups != null &&
                    input.AdGroups != null &&
                    this.AdGroups.SequenceEqual(input.AdGroups)
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
