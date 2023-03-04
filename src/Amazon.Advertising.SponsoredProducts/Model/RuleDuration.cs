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
    /// RuleDuration
    /// </summary>
    [DataContract(Name = "RuleDuration")]
    public partial class RuleDuration : IEquatable<RuleDuration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleDuration" /> class.
        /// </summary>
        /// <param name="eventTypeRuleDuration">eventTypeRuleDuration.</param>
        /// <param name="dateRangeTypeRuleDuration">dateRangeTypeRuleDuration.</param>
        public RuleDuration(EventTypeRuleDuration eventTypeRuleDuration = default(EventTypeRuleDuration), DateRangeTypeRuleDuration dateRangeTypeRuleDuration = default(DateRangeTypeRuleDuration))
        {
            this.EventTypeRuleDuration = eventTypeRuleDuration;
            this.DateRangeTypeRuleDuration = dateRangeTypeRuleDuration;
        }

        /// <summary>
        /// Gets or Sets EventTypeRuleDuration
        /// </summary>
        [DataMember(Name = "eventTypeRuleDuration", EmitDefaultValue = false)]
        public EventTypeRuleDuration EventTypeRuleDuration { get; set; }

        /// <summary>
        /// Gets or Sets DateRangeTypeRuleDuration
        /// </summary>
        [DataMember(Name = "dateRangeTypeRuleDuration", EmitDefaultValue = false)]
        public DateRangeTypeRuleDuration DateRangeTypeRuleDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleDuration {\n");
            sb.Append("  EventTypeRuleDuration: ").Append(EventTypeRuleDuration).Append("\n");
            sb.Append("  DateRangeTypeRuleDuration: ").Append(DateRangeTypeRuleDuration).Append("\n");
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
            return this.Equals(input as RuleDuration);
        }

        /// <summary>
        /// Returns true if RuleDuration instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleDuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleDuration input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.EventTypeRuleDuration == input.EventTypeRuleDuration ||
                    (this.EventTypeRuleDuration != null &&
                    this.EventTypeRuleDuration.Equals(input.EventTypeRuleDuration))
                ) &&
                (
                    this.DateRangeTypeRuleDuration == input.DateRangeTypeRuleDuration ||
                    (this.DateRangeTypeRuleDuration != null &&
                    this.DateRangeTypeRuleDuration.Equals(input.DateRangeTypeRuleDuration))
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
                if (this.EventTypeRuleDuration != null)
                {
                    hashCode = (hashCode * 59) + this.EventTypeRuleDuration.GetHashCode();
                }
                if (this.DateRangeTypeRuleDuration != null)
                {
                    hashCode = (hashCode * 59) + this.DateRangeTypeRuleDuration.GetHashCode();
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
