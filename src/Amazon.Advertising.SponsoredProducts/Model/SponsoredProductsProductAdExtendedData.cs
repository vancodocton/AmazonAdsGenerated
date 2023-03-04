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
    /// SponsoredProductsProductAdExtendedData
    /// </summary>
    [DataContract(Name = "SponsoredProductsProductAdExtendedData")]
    public partial class SponsoredProductsProductAdExtendedData : IEquatable<SponsoredProductsProductAdExtendedData>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ServingStatus
        /// </summary>
        [DataMember(Name = "servingStatus", EmitDefaultValue = false)]
        public SponsoredProductsAdServingStatus? ServingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsProductAdExtendedData" /> class.
        /// </summary>
        /// <param name="lastUpdateDateTime">Last updated date in ISO 8601..</param>
        /// <param name="servingStatus">servingStatus.</param>
        /// <param name="servingStatusDetails">The serving status reasons of the Ad.</param>
        /// <param name="creationDateTime">Creation date in ISO 8601..</param>
        public SponsoredProductsProductAdExtendedData(DateTime lastUpdateDateTime = default(DateTime), SponsoredProductsAdServingStatus? servingStatus = default(SponsoredProductsAdServingStatus?), List<SponsoredProductsAdServingStatusDetail> servingStatusDetails = default(List<SponsoredProductsAdServingStatusDetail>), DateTime creationDateTime = default(DateTime))
        {
            this.LastUpdateDateTime = lastUpdateDateTime;
            this.ServingStatus = servingStatus;
            this.ServingStatusDetails = servingStatusDetails;
            this.CreationDateTime = creationDateTime;
        }

        /// <summary>
        /// Last updated date in ISO 8601.
        /// </summary>
        /// <value>Last updated date in ISO 8601.</value>
        [DataMember(Name = "lastUpdateDateTime", EmitDefaultValue = false)]
        public DateTime LastUpdateDateTime { get; set; }

        /// <summary>
        /// The serving status reasons of the Ad
        /// </summary>
        /// <value>The serving status reasons of the Ad</value>
        [DataMember(Name = "servingStatusDetails", EmitDefaultValue = false)]
        public List<SponsoredProductsAdServingStatusDetail> ServingStatusDetails { get; set; }

        /// <summary>
        /// Creation date in ISO 8601.
        /// </summary>
        /// <value>Creation date in ISO 8601.</value>
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsProductAdExtendedData {\n");
            sb.Append("  LastUpdateDateTime: ").Append(LastUpdateDateTime).Append("\n");
            sb.Append("  ServingStatus: ").Append(ServingStatus).Append("\n");
            sb.Append("  ServingStatusDetails: ").Append(ServingStatusDetails).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
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
            return this.Equals(input as SponsoredProductsProductAdExtendedData);
        }

        /// <summary>
        /// Returns true if SponsoredProductsProductAdExtendedData instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsProductAdExtendedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsProductAdExtendedData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.LastUpdateDateTime == input.LastUpdateDateTime ||
                    (this.LastUpdateDateTime != null &&
                    this.LastUpdateDateTime.Equals(input.LastUpdateDateTime))
                ) &&
                (
                    this.ServingStatus == input.ServingStatus ||
                    this.ServingStatus.Equals(input.ServingStatus)
                ) &&
                (
                    this.ServingStatusDetails == input.ServingStatusDetails ||
                    this.ServingStatusDetails != null &&
                    input.ServingStatusDetails != null &&
                    this.ServingStatusDetails.SequenceEqual(input.ServingStatusDetails)
                ) &&
                (
                    this.CreationDateTime == input.CreationDateTime ||
                    (this.CreationDateTime != null &&
                    this.CreationDateTime.Equals(input.CreationDateTime))
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
                if (this.LastUpdateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdateDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServingStatus.GetHashCode();
                if (this.ServingStatusDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ServingStatusDetails.GetHashCode();
                }
                if (this.CreationDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDateTime.GetHashCode();
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
