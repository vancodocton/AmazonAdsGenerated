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
    /// Contains suggested recommendation for the auto targeting group.
    /// </summary>
    [DataContract(Name = "TargetingGroupBidRecommendation")]
    public partial class TargetingGroupBidRecommendation : IEquatable<TargetingGroupBidRecommendation>, IValidatableObject
    {
        /// <summary>
        /// The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.|
        /// </summary>
        /// <value>The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.|</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetingGroupExpressionEnum
        {
            /// <summary>
            /// Enum CLOSEMATCH for value: CLOSE_MATCH
            /// </summary>
            [EnumMember(Value = "CLOSE_MATCH")]
            CLOSEMATCH = 1,

            /// <summary>
            /// Enum LOOSEMATCH for value: LOOSE_MATCH
            /// </summary>
            [EnumMember(Value = "LOOSE_MATCH")]
            LOOSEMATCH = 2,

            /// <summary>
            /// Enum SUBSTITUTES for value: SUBSTITUTES
            /// </summary>
            [EnumMember(Value = "SUBSTITUTES")]
            SUBSTITUTES = 3,

            /// <summary>
            /// Enum COMPLEMENTS for value: COMPLEMENTS
            /// </summary>
            [EnumMember(Value = "COMPLEMENTS")]
            COMPLEMENTS = 4

        }


        /// <summary>
        /// The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.|
        /// </summary>
        /// <value>The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.|</value>
        [DataMember(Name = "targetingGroupExpression", EmitDefaultValue = false)]
        public TargetingGroupExpressionEnum? TargetingGroupExpression { get; set; }
        /// <summary>
        /// Type of suggested action.
        /// </summary>
        /// <value>Type of suggested action.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            [EnumMember(Value = "ADD")]
            ADD = 1,

            /// <summary>
            /// Enum REMOVE for value: REMOVE
            /// </summary>
            [EnumMember(Value = "REMOVE")]
            REMOVE = 2,

            /// <summary>
            /// Enum INCREASE for value: INCREASE
            /// </summary>
            [EnumMember(Value = "INCREASE")]
            INCREASE = 3,

            /// <summary>
            /// Enum DECREASE for value: DECREASE
            /// </summary>
            [EnumMember(Value = "DECREASE")]
            DECREASE = 4

        }


        /// <summary>
        /// Type of suggested action.
        /// </summary>
        /// <value>Type of suggested action.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetingGroupBidRecommendation" /> class.
        /// </summary>
        /// <param name="suggestedBid">The suggested bid value associated with this targeting..</param>
        /// <param name="targetId">The target identifier..</param>
        /// <param name="targetingGroupExpression">The type of targeting group expression. | Value | Description | | - -- | - -- | | &#x60;LOOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms loosely related to your products.| | &#x60;CLOSE_MATCH&#x60; | This will show your ad to shoppers who use search terms closely related to your products.| | &#x60;COMPLEMENTS&#x60; | This will show your ad to shoppers who view the detail pages of products that complement your product.| | &#x60;SUBSTITUTES&#x60; | This will show your ad to shoppers who use detail pages of products similar to yours.|.</param>
        /// <param name="action">Type of suggested action..</param>
        /// <param name="adGroupId">The ad group identifier..</param>
        public TargetingGroupBidRecommendation(double suggestedBid = default(double), string targetId = default(string), TargetingGroupExpressionEnum? targetingGroupExpression = default(TargetingGroupExpressionEnum?), ActionEnum? action = default(ActionEnum?), string adGroupId = default(string))
        {
            this.SuggestedBid = suggestedBid;
            this.TargetId = targetId;
            this.TargetingGroupExpression = targetingGroupExpression;
            this.Action = action;
            this.AdGroupId = adGroupId;
        }

        /// <summary>
        /// The suggested bid value associated with this targeting.
        /// </summary>
        /// <value>The suggested bid value associated with this targeting.</value>
        [DataMember(Name = "suggestedBid", EmitDefaultValue = false)]
        public double SuggestedBid { get; set; }

        /// <summary>
        /// The target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The ad group identifier.
        /// </summary>
        /// <value>The ad group identifier.</value>
        [DataMember(Name = "adGroupId", EmitDefaultValue = false)]
        public string AdGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetingGroupBidRecommendation {\n");
            sb.Append("  SuggestedBid: ").Append(SuggestedBid).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetingGroupExpression: ").Append(TargetingGroupExpression).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AdGroupId: ").Append(AdGroupId).Append("\n");
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
            return this.Equals(input as TargetingGroupBidRecommendation);
        }

        /// <summary>
        /// Returns true if TargetingGroupBidRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetingGroupBidRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetingGroupBidRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SuggestedBid == input.SuggestedBid ||
                    this.SuggestedBid.Equals(input.SuggestedBid)
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetingGroupExpression == input.TargetingGroupExpression ||
                    this.TargetingGroupExpression.Equals(input.TargetingGroupExpression)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.AdGroupId == input.AdGroupId ||
                    (this.AdGroupId != null &&
                    this.AdGroupId.Equals(input.AdGroupId))
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
                hashCode = (hashCode * 59) + this.SuggestedBid.GetHashCode();
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TargetingGroupExpression.GetHashCode();
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.AdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.AdGroupId.GetHashCode();
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