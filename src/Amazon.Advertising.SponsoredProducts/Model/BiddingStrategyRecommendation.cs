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
    /// Contains suggested recommendation for the campaign bidding strategy.
    /// </summary>
    [DataContract(Name = "BiddingStrategyRecommendation")]
    public partial class BiddingStrategyRecommendation : IEquatable<BiddingStrategyRecommendation>, IValidatableObject
    {
        /// <summary>
        /// The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. |
        /// </summary>
        /// <value>The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. |</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SuggestedBiddingStrategyEnum
        {
            /// <summary>
            /// Enum LEGACYFORSALES for value: LEGACY_FOR_SALES
            /// </summary>
            [EnumMember(Value = "LEGACY_FOR_SALES")]
            LEGACYFORSALES = 1,

            /// <summary>
            /// Enum AUTOFORSALES for value: AUTO_FOR_SALES
            /// </summary>
            [EnumMember(Value = "AUTO_FOR_SALES")]
            AUTOFORSALES = 2,

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 3

        }


        /// <summary>
        /// The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. |
        /// </summary>
        /// <value>The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. |</value>
        [DataMember(Name = "suggestedBiddingStrategy", EmitDefaultValue = false)]
        public SuggestedBiddingStrategyEnum? SuggestedBiddingStrategy { get; set; }
        /// <summary>
        /// Type of suggested action.
        /// </summary>
        /// <value>Type of suggested action.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            UPDATE = 1

        }


        /// <summary>
        /// Type of suggested action.
        /// </summary>
        /// <value>Type of suggested action.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BiddingStrategyRecommendation" /> class.
        /// </summary>
        /// <param name="suggestedBiddingStrategy">The suggested bidding strategy value for the campaign. | Value | Strategy name | Description | |- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- -- -- -- --| | &#x60;LEGACY_FOR_SALES&#x60; | Dynamic bids - down only | Lowers your bids in real time when your ad may be less likely to convert to a sale. Campaigns created before the release of the bidding controls feature used this setting by default. | | &#x60;AUTO_FOR_SALES&#x60; | Dynamic bids - up and down | Increases or decreases your bids in real time by a maximum of 100%. With this setting bids increase when your ad is more likely to convert to a sale, and bids decrease when less likely to convert to a sale. | | &#x60;MANUAL&#x60; | Fixed bid | Uses your exact bid and any placement adjustments you set, and is not subject to dynamic bidding. |.</param>
        /// <param name="action">Type of suggested action..</param>
        public BiddingStrategyRecommendation(SuggestedBiddingStrategyEnum? suggestedBiddingStrategy = default(SuggestedBiddingStrategyEnum?), ActionEnum? action = default(ActionEnum?))
        {
            this.SuggestedBiddingStrategy = suggestedBiddingStrategy;
            this.Action = action;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BiddingStrategyRecommendation {\n");
            sb.Append("  SuggestedBiddingStrategy: ").Append(SuggestedBiddingStrategy).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as BiddingStrategyRecommendation);
        }

        /// <summary>
        /// Returns true if BiddingStrategyRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of BiddingStrategyRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiddingStrategyRecommendation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SuggestedBiddingStrategy == input.SuggestedBiddingStrategy ||
                    this.SuggestedBiddingStrategy.Equals(input.SuggestedBiddingStrategy)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                hashCode = (hashCode * 59) + this.SuggestedBiddingStrategy.GetHashCode();
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
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
