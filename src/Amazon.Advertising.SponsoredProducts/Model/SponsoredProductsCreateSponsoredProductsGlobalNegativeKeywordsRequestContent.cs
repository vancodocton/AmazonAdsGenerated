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
    /// SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent")]
    public partial class SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent : IEquatable<SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent" /> class.
        /// </summary>
        /// <param name="negativeKeywords">An array of negativeKeywords..</param>
        public SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent(List<SponsoredProductsCreateGlobalNegativeKeyword> negativeKeywords = default(List<SponsoredProductsCreateGlobalNegativeKeyword>))
        {
            this.NegativeKeywords = negativeKeywords;
        }

        /// <summary>
        /// An array of negativeKeywords.
        /// </summary>
        /// <value>An array of negativeKeywords.</value>
        [DataMember(Name = "negativeKeywords", EmitDefaultValue = false)]
        public List<SponsoredProductsCreateGlobalNegativeKeyword> NegativeKeywords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent {\n");
            sb.Append("  NegativeKeywords: ").Append(NegativeKeywords).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateSponsoredProductsGlobalNegativeKeywordsRequestContent input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NegativeKeywords == input.NegativeKeywords ||
                    this.NegativeKeywords != null &&
                    input.NegativeKeywords != null &&
                    this.NegativeKeywords.SequenceEqual(input.NegativeKeywords)
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
                if (this.NegativeKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.NegativeKeywords.GetHashCode();
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
