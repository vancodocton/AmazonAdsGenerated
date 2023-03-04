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
    /// SponsoredProductsCopyCampaignResponse
    /// </summary>
    [DataContract(Name = "SponsoredProductsCopyCampaignResponse")]
    public partial class SponsoredProductsCopyCampaignResponse : IEquatable<SponsoredProductsCopyCampaignResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCopyCampaignResponse" /> class.
        /// </summary>
        /// <param name="requestId">Id of the request to be passed in GET /copy/{requestId}..</param>
        /// <param name="errorDetail">errorDetail.</param>
        /// <param name="copyCampaignItem">copyCampaignItem.</param>
        public SponsoredProductsCopyCampaignResponse(string requestId = default(string), SponsoredProductsCopyCampaignErrorDetail errorDetail = default(SponsoredProductsCopyCampaignErrorDetail), SponsoredProductsCopyCampaign copyCampaignItem = default(SponsoredProductsCopyCampaign))
        {
            this.RequestId = requestId;
            this.ErrorDetail = errorDetail;
            this.CopyCampaignItem = copyCampaignItem;
        }

        /// <summary>
        /// Id of the request to be passed in GET /copy/{requestId}.
        /// </summary>
        /// <value>Id of the request to be passed in GET /copy/{requestId}.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDetail
        /// </summary>
        [DataMember(Name = "errorDetail", EmitDefaultValue = false)]
        public SponsoredProductsCopyCampaignErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Gets or Sets CopyCampaignItem
        /// </summary>
        [DataMember(Name = "copyCampaignItem", EmitDefaultValue = false)]
        public SponsoredProductsCopyCampaign CopyCampaignItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCopyCampaignResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ErrorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("  CopyCampaignItem: ").Append(CopyCampaignItem).Append("\n");
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
            return this.Equals(input as SponsoredProductsCopyCampaignResponse);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCopyCampaignResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCopyCampaignResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCopyCampaignResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.ErrorDetail == input.ErrorDetail ||
                    (this.ErrorDetail != null &&
                    this.ErrorDetail.Equals(input.ErrorDetail))
                ) && 
                (
                    this.CopyCampaignItem == input.CopyCampaignItem ||
                    (this.CopyCampaignItem != null &&
                    this.CopyCampaignItem.Equals(input.CopyCampaignItem))
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
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.ErrorDetail != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDetail.GetHashCode();
                }
                if (this.CopyCampaignItem != null)
                {
                    hashCode = (hashCode * 59) + this.CopyCampaignItem.GetHashCode();
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