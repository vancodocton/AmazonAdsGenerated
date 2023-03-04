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
    /// RankedTargetWithThemedBidsResponse
    /// </summary>
    [DataContract(Name = "RankedTargetWithThemedBidsResponse")]
    public partial class RankedTargetWithThemedBidsResponse : IEquatable<RankedTargetWithThemedBidsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedTargetWithThemedBidsResponse" /> class.
        /// </summary>
        /// <param name="keywordTargetList">keywordTargetList.</param>
        /// <param name="impactMetrics">A list of impact metrics which anticipates the number of clicks and orders you will receive if you target all targeting expressions using the low, medium, and high suggested bid..</param>
        public RankedTargetWithThemedBidsResponse(List<RankedTargetWithThemedBids> keywordTargetList = default(List<RankedTargetWithThemedBids>), List<ImpactMetrics> impactMetrics = default(List<ImpactMetrics>))
        {
            this.KeywordTargetList = keywordTargetList;
            this.ImpactMetrics = impactMetrics;
        }

        /// <summary>
        /// Gets or Sets KeywordTargetList
        /// </summary>
        [DataMember(Name = "keywordTargetList", EmitDefaultValue = false)]
        public List<RankedTargetWithThemedBids> KeywordTargetList { get; set; }

        /// <summary>
        /// A list of impact metrics which anticipates the number of clicks and orders you will receive if you target all targeting expressions using the low, medium, and high suggested bid.
        /// </summary>
        /// <value>A list of impact metrics which anticipates the number of clicks and orders you will receive if you target all targeting expressions using the low, medium, and high suggested bid.</value>
        [DataMember(Name = "impactMetrics", EmitDefaultValue = false)]
        public List<ImpactMetrics> ImpactMetrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RankedTargetWithThemedBidsResponse {\n");
            sb.Append("  KeywordTargetList: ").Append(KeywordTargetList).Append("\n");
            sb.Append("  ImpactMetrics: ").Append(ImpactMetrics).Append("\n");
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
            return this.Equals(input as RankedTargetWithThemedBidsResponse);
        }

        /// <summary>
        /// Returns true if RankedTargetWithThemedBidsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RankedTargetWithThemedBidsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankedTargetWithThemedBidsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeywordTargetList == input.KeywordTargetList ||
                    this.KeywordTargetList != null &&
                    input.KeywordTargetList != null &&
                    this.KeywordTargetList.SequenceEqual(input.KeywordTargetList)
                ) && 
                (
                    this.ImpactMetrics == input.ImpactMetrics ||
                    this.ImpactMetrics != null &&
                    input.ImpactMetrics != null &&
                    this.ImpactMetrics.SequenceEqual(input.ImpactMetrics)
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
                if (this.KeywordTargetList != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordTargetList.GetHashCode();
                }
                if (this.ImpactMetrics != null)
                {
                    hashCode = (hashCode * 59) + this.ImpactMetrics.GetHashCode();
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