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
    /// Recommended asin and related information.
    /// </summary>
    [DataContract(Name = "ProductRecommendation")]
    public partial class ProductRecommendation : IEquatable<ProductRecommendation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRecommendation" /> class.
        /// </summary>
        /// <param name="themes">List of themes associated with this recommended ASIN..</param>
        /// <param name="recommendedAsin">Recommended ASIN.</param>
        public ProductRecommendation(List<string> themes = default(List<string>), string recommendedAsin = default(string))
        {
            this.Themes = themes;
            this.RecommendedAsin = recommendedAsin;
        }

        /// <summary>
        /// List of themes associated with this recommended ASIN.
        /// </summary>
        /// <value>List of themes associated with this recommended ASIN.</value>
        [DataMember(Name = "themes", EmitDefaultValue = false)]
        public List<string> Themes { get; set; }

        /// <summary>
        /// Recommended ASIN
        /// </summary>
        /// <value>Recommended ASIN</value>
        [DataMember(Name = "recommendedAsin", EmitDefaultValue = false)]
        public string RecommendedAsin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductRecommendation {\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  RecommendedAsin: ").Append(RecommendedAsin).Append("\n");
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
            return this.Equals(input as ProductRecommendation);
        }

        /// <summary>
        /// Returns true if ProductRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
                ) && 
                (
                    this.RecommendedAsin == input.RecommendedAsin ||
                    (this.RecommendedAsin != null &&
                    this.RecommendedAsin.Equals(input.RecommendedAsin))
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
                if (this.Themes != null)
                {
                    hashCode = (hashCode * 59) + this.Themes.GetHashCode();
                }
                if (this.RecommendedAsin != null)
                {
                    hashCode = (hashCode * 59) + this.RecommendedAsin.GetHashCode();
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
            // RecommendedAsin (string) maxLength
            if (this.RecommendedAsin != null && this.RecommendedAsin.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecommendedAsin, length must be less than 10.", new [] { "RecommendedAsin" });
            }

            // RecommendedAsin (string) minLength
            if (this.RecommendedAsin != null && this.RecommendedAsin.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecommendedAsin, length must be greater than 10.", new [] { "RecommendedAsin" });
            }

            yield break;
        }
    }

}
