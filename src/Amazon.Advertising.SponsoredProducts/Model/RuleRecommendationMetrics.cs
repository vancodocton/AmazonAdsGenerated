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
    /// Performance Metrics supported by the rule recommendation
    /// </summary>
    [DataContract(Name = "RuleRecommendationMetrics")]
    public partial class RuleRecommendationMetrics : IEquatable<RuleRecommendationMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleRecommendationMetrics" /> class.
        /// </summary>
        /// <param name="roas">return on ad spend value.</param>
        public RuleRecommendationMetrics(double roas = default(double))
        {
            this.Roas = roas;
        }

        /// <summary>
        /// return on ad spend value
        /// </summary>
        /// <value>return on ad spend value</value>
        [DataMember(Name = "roas", EmitDefaultValue = false)]
        public double Roas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleRecommendationMetrics {\n");
            sb.Append("  Roas: ").Append(Roas).Append("\n");
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
            return this.Equals(input as RuleRecommendationMetrics);
        }

        /// <summary>
        /// Returns true if RuleRecommendationMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleRecommendationMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleRecommendationMetrics input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Roas == input.Roas ||
                    this.Roas.Equals(input.Roas)
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
                hashCode = (hashCode * 59) + this.Roas.GetHashCode();
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
