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
    /// SponsoredProductsGlobalCampaignNegativeKeywordExtendedData
    /// </summary>
    [DataContract(Name = "SponsoredProductsGlobalCampaignNegativeKeywordExtendedData")]
    public partial class SponsoredProductsGlobalCampaignNegativeKeywordExtendedData : IEquatable<SponsoredProductsGlobalCampaignNegativeKeywordExtendedData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsGlobalCampaignNegativeKeywordExtendedData" /> class.
        /// </summary>
        /// <param name="servingStatus">servingStatus.</param>
        public SponsoredProductsGlobalCampaignNegativeKeywordExtendedData(SponsoredProductsGlobalKeywordServingStatus servingStatus = default(SponsoredProductsGlobalKeywordServingStatus))
        {
            this.ServingStatus = servingStatus;
        }

        /// <summary>
        /// Gets or Sets ServingStatus
        /// </summary>
        [DataMember(Name = "servingStatus", EmitDefaultValue = false)]
        public SponsoredProductsGlobalKeywordServingStatus ServingStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsGlobalCampaignNegativeKeywordExtendedData {\n");
            sb.Append("  ServingStatus: ").Append(ServingStatus).Append("\n");
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
            return this.Equals(input as SponsoredProductsGlobalCampaignNegativeKeywordExtendedData);
        }

        /// <summary>
        /// Returns true if SponsoredProductsGlobalCampaignNegativeKeywordExtendedData instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsGlobalCampaignNegativeKeywordExtendedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsGlobalCampaignNegativeKeywordExtendedData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ServingStatus == input.ServingStatus ||
                    (this.ServingStatus != null &&
                    this.ServingStatus.Equals(input.ServingStatus))
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
                if (this.ServingStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ServingStatus.GetHashCode();
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
