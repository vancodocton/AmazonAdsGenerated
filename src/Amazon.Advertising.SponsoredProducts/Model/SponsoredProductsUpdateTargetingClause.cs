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
    /// SponsoredProductsUpdateTargetingClause
    /// </summary>
    [DataContract(Name = "SponsoredProductsUpdateTargetingClause")]
    public partial class SponsoredProductsUpdateTargetingClause : IEquatable<SponsoredProductsUpdateTargetingClause>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ExpressionType
        /// </summary>
        [DataMember(Name = "expressionType", EmitDefaultValue = false)]
        public SponsoredProductsExpressionTypeWithoutOther? ExpressionType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SponsoredProductsCreateOrUpdateEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateTargetingClause" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsUpdateTargetingClause() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsUpdateTargetingClause" /> class.
        /// </summary>
        /// <param name="expression">The targeting expression..</param>
        /// <param name="targetId">The target identifier (required).</param>
        /// <param name="expressionType">expressionType.</param>
        /// <param name="state">state.</param>
        /// <param name="bid">The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |.</param>
        public SponsoredProductsUpdateTargetingClause(List<SponsoredProductsTargetingExpressionPredicateWithoutOther> expression = default(List<SponsoredProductsTargetingExpressionPredicateWithoutOther>), string targetId = default(string), SponsoredProductsExpressionTypeWithoutOther? expressionType = default(SponsoredProductsExpressionTypeWithoutOther?), SponsoredProductsCreateOrUpdateEntityState? state = default(SponsoredProductsCreateOrUpdateEntityState?), double? bid = default(double?))
        {
            // to ensure "targetId" is required (not null)
            if (targetId == null)
            {
                throw new ArgumentNullException("targetId is a required property for SponsoredProductsUpdateTargetingClause and cannot be null");
            }
            this.TargetId = targetId;
            this.Expression = expression;
            this.ExpressionType = expressionType;
            this.State = state;
            this.Bid = bid;
        }

        /// <summary>
        /// The targeting expression.
        /// </summary>
        /// <value>The targeting expression.</value>
        [DataMember(Name = "expression", EmitDefaultValue = false)]
        public List<SponsoredProductsTargetingExpressionPredicateWithoutOther> Expression { get; set; }

        /// <summary>
        /// The target identifier
        /// </summary>
        /// <value>The target identifier</value>
        [DataMember(Name = "targetId", IsRequired = true, EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |
        /// </summary>
        /// <value>The bid for ads sourced using the target. Targets that do not have bid values in listTargetingClauses will inherit the defaultBid from the adGroup level. This table details the maximum allowable bid (in local currency) for keywords by marketplace: | Marketplace | Currency | Min / Max bid for SP | | - -- | - -- | - -- | | US | USD | 0.02 / 1000 | | CA | CAD | 0.02 / 1000 | | UK | GBP | 0.02 / 1000 | | DE | EUR | 0.02 / 1000 | | FR | EUR | 0.02 / 1000 | | ES | EUR | 0.02 / 1000 | | IT | EUR | 0.02 / 1000 | | JP | JPY | 2.0 / 100000 | | AU | AUD | 0.10 / 1410 | | AE | AED | 0.24 / 184.0 |</value>
        [DataMember(Name = "bid", EmitDefaultValue = true)]
        public double? Bid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsUpdateTargetingClause {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  ExpressionType: ").Append(ExpressionType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
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
            return this.Equals(input as SponsoredProductsUpdateTargetingClause);
        }

        /// <summary>
        /// Returns true if SponsoredProductsUpdateTargetingClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsUpdateTargetingClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsUpdateTargetingClause input)
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
                    this.ExpressionType == input.ExpressionType ||
                    this.ExpressionType.Equals(input.ExpressionType)
                ) &&
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) &&
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
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
                hashCode = (hashCode * 59) + this.ExpressionType.GetHashCode();
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Bid != null)
                {
                    hashCode = (hashCode * 59) + this.Bid.GetHashCode();
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
