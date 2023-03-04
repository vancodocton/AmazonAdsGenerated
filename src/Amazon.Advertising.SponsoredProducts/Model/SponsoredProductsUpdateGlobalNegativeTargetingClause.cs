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
    /// SponsoredProductsUpdateGlobalNegativeTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateGlobalNegativeTargetingClause")]
    public partial class SponsoredProductsUpdateGlobalNegativeTargetingClause : IEquatable<SponsoredProductsUpdateGlobalNegativeTargetingClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalNegativeTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateGlobalNegativeTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateGlobalNegativeTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The NegativeTargeting expression..</param>
        /// <param name="targetId">The target identifier (required).</param>
        /// <param name="name">Name for the negative targeting clause.</param>
        /// <param name="state">state.</param>
        public SponsoredProductsUpdateGlobalNegativeTargetingClause(List<SponsoredProductsGlobalTargetingExpressionPredicate> expression = default(List<SponsoredProductsGlobalTargetingExpressionPredicate>), string targetId = default(string), string name = default(string), SponsoredProductsCreateOrUpdateGlobalEntityState state = default(SponsoredProductsCreateOrUpdateGlobalEntityState))
        {
            // to ensure "targetId" is required (not null)
            if (targetId == null)
            {
                throw new ArgumentNullException("targetId is a required property for SponsoredProductsUpdateGlobalNegativeTargetingClause and cannot be null");
            }
            this.TargetId = targetId;
            this.Expression = expression;
            this.Name = name;
            this.State = state;
        }

        /// <summary>
        /// The NegativeTargeting expression.
        /// </summary>
        /// <value>The NegativeTargeting expression.</value>
        [DataMember(Name = "expression", EmitDefaultValue = false)]
        public List<SponsoredProductsGlobalTargetingExpressionPredicate> Expression { get; set; }

        /// <summary>
        /// The target identifier
        /// </summary>
        /// <value>The target identifier</value>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Name for the negative targeting clause
        /// </summary>
        /// <value>Name for the negative targeting clause</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateGlobalEntityState State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateGlobalNegativeTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateGlobalNegativeTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateGlobalNegativeTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateGlobalNegativeTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateGlobalNegativeTargetingClause input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Expression == input.Expression ||
                    this.Expression != null &&
                    input.Expression != null &&
                    this.Expression.SequenceEqual(input.Expression)
                ) &&
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Expression != null)
                {
                    hashCode = (hashCode * 59) + this.Expression.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
