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
    /// For the CONVERSION_OPPORTUNITIES theme, the impact metrics are weekly clicks and orders received for similar products. For other event-based themes, the impact metrics are clicks and orders received for similar products during the event days
    /// </summary>
    [DataContract(Name = "ImpactMetrics")]
    public partial class ImpactMetrics : IEquatable<ImpactMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImpactMetrics" /> class.
        /// </summary>
        /// <param name="clicks">clicks.</param>
        /// <param name="orders">orders.</param>
        public ImpactMetrics(ImpactMetric clicks = default(ImpactMetric), ImpactMetric orders = default(ImpactMetric))
        {
            this.Clicks = clicks;
            this.Orders = orders;
        }

        /// <summary>
        /// Gets or Sets Clicks
        /// </summary>
        [DataMember(Name = "clicks", EmitDefaultValue = false)]
        public ImpactMetric Clicks { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public ImpactMetric Orders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImpactMetrics {\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
            return this.Equals(input as ImpactMetrics);
        }

        /// <summary>
        /// Returns true if ImpactMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of ImpactMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImpactMetrics input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Clicks == input.Clicks ||
                    (this.Clicks != null &&
                    this.Clicks.Equals(input.Clicks))
                ) &&
                (
                    this.Orders == input.Orders ||
                    (this.Orders != null &&
                    this.Orders.Equals(input.Orders))
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
                if (this.Clicks != null)
                {
                    hashCode = (hashCode * 59) + this.Clicks.GetHashCode();
                }
                if (this.Orders != null)
                {
                    hashCode = (hashCode * 59) + this.Orders.GetHashCode();
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
