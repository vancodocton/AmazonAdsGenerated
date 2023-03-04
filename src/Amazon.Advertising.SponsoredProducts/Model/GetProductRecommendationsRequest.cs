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
    /// Request structure to get ASIN recommendations for a set of input ASINs.
    /// </summary>
    [DataContract(Name = "GetProductRecommendationsRequest")]
    public partial class GetProductRecommendationsRequest : IEquatable<GetProductRecommendationsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductRecommendationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProductRecommendationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductRecommendationsRequest" /> class.
        /// </summary>
        /// <param name="cursor">A optional cursor value that can be used to fetch next or previous set of records..</param>
        /// <param name="adAsins">List of input ASINs. (required).</param>
        /// <param name="count">Count of objects requested in the response. The count will be applied on the objects returned under &#x60;recommendations&#x60; array in response body.  &lt;ul&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.themes.v3+json&#x60; mediatype applies the count on &#x60;ThemeRecommendation&#x60; objects.If no count value is passed a default of &#x60;5&#x60; is assumed. The API will return a maximum of &#x60;10&#x60; themes irrespective of how large the count is set. &lt;/li&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.asins.v3+json&#x60; mediatype applies count on the &#x60;ProductRecommendation&#x60; objects in response body.If no count value is passed a default of &#x60;100&#x60; is assumed. The API will return a maximum of &#x60;1000&#x60; recommendations irrespective of how large the count is set. &lt;/li&gt; &lt;/ul&gt; Please refer the response Schemas for more info..</param>
        /// <param name="locale">Theme names and descriptions will be provided in the language for your supported locale. Available options are en_US (U.S. English), en_GB (UK English), zh_CN (Chinese), es_ES (Spanish), jp_JP (Japanese), de_DE (German), fr_FR (French), it_IT(Italian). If locale is not provided or unsupported, the theme names and descriptions will be returned in U.S. English (en_US)..</param>
        public GetProductRecommendationsRequest(string cursor = default(string), List<string> adAsins = default(List<string>), int count = default(int), string locale = default(string))
        {
            // to ensure "adAsins" is required (not null)
            if (adAsins == null)
            {
                throw new ArgumentNullException("adAsins is a required property for GetProductRecommendationsRequest and cannot be null");
            }
            this.AdAsins = adAsins;
            this.Cursor = cursor;
            this.Count = count;
            this.Locale = locale;
        }

        /// <summary>
        /// A optional cursor value that can be used to fetch next or previous set of records.
        /// </summary>
        /// <value>A optional cursor value that can be used to fetch next or previous set of records.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// List of input ASINs.
        /// </summary>
        /// <value>List of input ASINs.</value>
        [DataMember(Name = "adAsins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AdAsins { get; set; }

        /// <summary>
        /// Count of objects requested in the response. The count will be applied on the objects returned under &#x60;recommendations&#x60; array in response body.  &lt;ul&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.themes.v3+json&#x60; mediatype applies the count on &#x60;ThemeRecommendation&#x60; objects.If no count value is passed a default of &#x60;5&#x60; is assumed. The API will return a maximum of &#x60;10&#x60; themes irrespective of how large the count is set. &lt;/li&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.asins.v3+json&#x60; mediatype applies count on the &#x60;ProductRecommendation&#x60; objects in response body.If no count value is passed a default of &#x60;100&#x60; is assumed. The API will return a maximum of &#x60;1000&#x60; recommendations irrespective of how large the count is set. &lt;/li&gt; &lt;/ul&gt; Please refer the response Schemas for more info.
        /// </summary>
        /// <value>Count of objects requested in the response. The count will be applied on the objects returned under &#x60;recommendations&#x60; array in response body.  &lt;ul&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.themes.v3+json&#x60; mediatype applies the count on &#x60;ThemeRecommendation&#x60; objects.If no count value is passed a default of &#x60;5&#x60; is assumed. The API will return a maximum of &#x60;10&#x60; themes irrespective of how large the count is set. &lt;/li&gt; &lt;li&gt;Requesting &#x60;application/vnd.spproductrecommendationresponse.asins.v3+json&#x60; mediatype applies count on the &#x60;ProductRecommendation&#x60; objects in response body.If no count value is passed a default of &#x60;100&#x60; is assumed. The API will return a maximum of &#x60;1000&#x60; recommendations irrespective of how large the count is set. &lt;/li&gt; &lt;/ul&gt; Please refer the response Schemas for more info.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Theme names and descriptions will be provided in the language for your supported locale. Available options are en_US (U.S. English), en_GB (UK English), zh_CN (Chinese), es_ES (Spanish), jp_JP (Japanese), de_DE (German), fr_FR (French), it_IT(Italian). If locale is not provided or unsupported, the theme names and descriptions will be returned in U.S. English (en_US).
        /// </summary>
        /// <value>Theme names and descriptions will be provided in the language for your supported locale. Available options are en_US (U.S. English), en_GB (UK English), zh_CN (Chinese), es_ES (Spanish), jp_JP (Japanese), de_DE (German), fr_FR (French), it_IT(Italian). If locale is not provided or unsupported, the theme names and descriptions will be returned in U.S. English (en_US).</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProductRecommendationsRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  AdAsins: ").Append(AdAsins).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as GetProductRecommendationsRequest);
        }

        /// <summary>
        /// Returns true if GetProductRecommendationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProductRecommendationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductRecommendationsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.AdAsins == input.AdAsins ||
                    this.AdAsins != null &&
                    input.AdAsins != null &&
                    this.AdAsins.SequenceEqual(input.AdAsins)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Cursor != null)
                {
                    hashCode = (hashCode * 59) + this.Cursor.GetHashCode();
                }
                if (this.AdAsins != null)
                {
                    hashCode = (hashCode * 59) + this.AdAsins.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
            // Count (int) minimum
            if (this.Count < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 1.", new [] { "Count" });
            }

            yield break;
        }
    }

}