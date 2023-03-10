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
    /// SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent")]
    public partial class SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent : IEquatable<SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent" /> class.
        /// </summary>
        /// <param name="adGroupIdFilter">adGroupIdFilter (required).</param>
        public SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent(SponsoredProductsObjectIdFilter adGroupIdFilter = default(SponsoredProductsObjectIdFilter))
        {
            // to ensure "adGroupIdFilter" is required (not null)
            if (adGroupIdFilter == null)
            {
                throw new ArgumentNullException("adGroupIdFilter is a required property for SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent and cannot be null");
            }
            this.AdGroupIdFilter = adGroupIdFilter;
        }

        /// <summary>
        /// Gets or Sets AdGroupIdFilter
        /// </summary>
        [DataMember(Name = "adGroupIdFilter", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsObjectIdFilter AdGroupIdFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent {\n");
            sb.Append("  AdGroupIdFilter: ").Append(AdGroupIdFilter).Append("\n");
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
            return this.Equals(input as SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsDeleteSponsoredProductsAdGroupsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AdGroupIdFilter == input.AdGroupIdFilter ||
                    (this.AdGroupIdFilter != null &&
                    this.AdGroupIdFilter.Equals(input.AdGroupIdFilter))
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
                if (this.AdGroupIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupIdFilter.GetHashCode();
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
