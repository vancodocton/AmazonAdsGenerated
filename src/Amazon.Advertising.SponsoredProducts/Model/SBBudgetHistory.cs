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
    /// SBBudgetHistory
    /// </summary>
    [DataContract(Name = "SBBudgetHistory")]
    public partial class SBBudgetHistory : IEquatable<SBBudgetHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SBBudgetHistory" /> class.
        /// </summary>
        /// <param name="nextToken">To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results..</param>
        /// <param name="history">history.</param>
        public SBBudgetHistory(string nextToken = default(string), List<SBRuleBasedBudget> history = default(List<SBRuleBasedBudget>))
        {
            this.NextToken = nextToken;
            this.History = history;
        }

        /// <summary>
        /// To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results.
        /// </summary>
        /// <value>To retrieve the next page of results, call the same operation and specify this token in the request. If the &#x60;nextToken&#x60; field is empty, there are no further results.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name = "history", EmitDefaultValue = false)]
        public List<SBRuleBasedBudget> History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SBBudgetHistory {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as SBBudgetHistory);
        }

        /// <summary>
        /// Returns true if SBBudgetHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of SBBudgetHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SBBudgetHistory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    input.History != null &&
                    this.History.SequenceEqual(input.History)
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
                if (this.NextToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextToken.GetHashCode();
                }
                if (this.History != null)
                {
                    hashCode = (hashCode * 59) + this.History.GetHashCode();
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