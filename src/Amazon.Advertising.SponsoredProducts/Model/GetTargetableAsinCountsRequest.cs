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
    /// GetTargetableAsinCountsRequest
    /// </summary>
    [DataContract(Name = "GetTargetableAsinCountsRequest")]
    public partial class GetTargetableAsinCountsRequest : IEquatable<GetTargetableAsinCountsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTargetableAsinCountsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTargetableAsinCountsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTargetableAsinCountsRequest" /> class.
        /// </summary>
        /// <param name="ageRanges">List of Age Ranges. Use the GetRefinementsForCategory to retrieve Age Ranges. Age Ranges are only available for categories related to children&#39;s toys and games..</param>
        /// <param name="brands">List of Brands..</param>
        /// <param name="genres">List of Genres. Use the GetRefinementsForCategory to retrieve Genre Node IDs. Genres are only available for categories related to books..</param>
        /// <param name="isPrimeShipping">Indicates if products have prime shipping.</param>
        /// <param name="ratingRange">ratingRange.</param>
        /// <param name="category">The category node id. Please use the GetTargetableCategories API or GetCategoryRecommendationsForASINs API to retrieve category IDs. (required).</param>
        /// <param name="priceRange">priceRange.</param>
        public GetTargetableAsinCountsRequest(List<AgeRange> ageRanges = default(List<AgeRange>), List<Brand> brands = default(List<Brand>), List<Genre> genres = default(List<Genre>), bool isPrimeShipping = default(bool), RatingRange ratingRange = default(RatingRange), string category = default(string), PriceRange priceRange = default(PriceRange))
        {
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for GetTargetableAsinCountsRequest and cannot be null");
            }
            this.Category = category;
            this.AgeRanges = ageRanges;
            this.Brands = brands;
            this.Genres = genres;
            this.IsPrimeShipping = isPrimeShipping;
            this.RatingRange = ratingRange;
            this.PriceRange = priceRange;
        }

        /// <summary>
        /// List of Age Ranges. Use the GetRefinementsForCategory to retrieve Age Ranges. Age Ranges are only available for categories related to children&#39;s toys and games.
        /// </summary>
        /// <value>List of Age Ranges. Use the GetRefinementsForCategory to retrieve Age Ranges. Age Ranges are only available for categories related to children&#39;s toys and games.</value>
        [DataMember(Name = "ageRanges", EmitDefaultValue = false)]
        public List<AgeRange> AgeRanges { get; set; }

        /// <summary>
        /// List of Brands.
        /// </summary>
        /// <value>List of Brands.</value>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        public List<Brand> Brands { get; set; }

        /// <summary>
        /// List of Genres. Use the GetRefinementsForCategory to retrieve Genre Node IDs. Genres are only available for categories related to books.
        /// </summary>
        /// <value>List of Genres. Use the GetRefinementsForCategory to retrieve Genre Node IDs. Genres are only available for categories related to books.</value>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<Genre> Genres { get; set; }

        /// <summary>
        /// Indicates if products have prime shipping
        /// </summary>
        /// <value>Indicates if products have prime shipping</value>
        [DataMember(Name = "isPrimeShipping", EmitDefaultValue = true)]
        public bool IsPrimeShipping { get; set; }

        /// <summary>
        /// Gets or Sets RatingRange
        /// </summary>
        [DataMember(Name = "ratingRange", EmitDefaultValue = false)]
        public RatingRange RatingRange { get; set; }

        /// <summary>
        /// The category node id. Please use the GetTargetableCategories API or GetCategoryRecommendationsForASINs API to retrieve category IDs.
        /// </summary>
        /// <value>The category node id. Please use the GetTargetableCategories API or GetCategoryRecommendationsForASINs API to retrieve category IDs.</value>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets PriceRange
        /// </summary>
        [DataMember(Name = "priceRange", EmitDefaultValue = false)]
        public PriceRange PriceRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTargetableAsinCountsRequest {\n");
            sb.Append("  AgeRanges: ").Append(AgeRanges).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  IsPrimeShipping: ").Append(IsPrimeShipping).Append("\n");
            sb.Append("  RatingRange: ").Append(RatingRange).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  PriceRange: ").Append(PriceRange).Append("\n");
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
            return this.Equals(input as GetTargetableAsinCountsRequest);
        }

        /// <summary>
        /// Returns true if GetTargetableAsinCountsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTargetableAsinCountsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTargetableAsinCountsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AgeRanges == input.AgeRanges ||
                    this.AgeRanges != null &&
                    input.AgeRanges != null &&
                    this.AgeRanges.SequenceEqual(input.AgeRanges)
                ) &&
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    input.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) &&
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) &&
                (
                    this.IsPrimeShipping == input.IsPrimeShipping ||
                    this.IsPrimeShipping.Equals(input.IsPrimeShipping)
                ) &&
                (
                    this.RatingRange == input.RatingRange ||
                    (this.RatingRange != null &&
                    this.RatingRange.Equals(input.RatingRange))
                ) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
                (
                    this.PriceRange == input.PriceRange ||
                    (this.PriceRange != null &&
                    this.PriceRange.Equals(input.PriceRange))
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
                if (this.AgeRanges != null)
                {
                    hashCode = (hashCode * 59) + this.AgeRanges.GetHashCode();
                }
                if (this.Brands != null)
                {
                    hashCode = (hashCode * 59) + this.Brands.GetHashCode();
                }
                if (this.Genres != null)
                {
                    hashCode = (hashCode * 59) + this.Genres.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPrimeShipping.GetHashCode();
                if (this.RatingRange != null)
                {
                    hashCode = (hashCode * 59) + this.RatingRange.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.PriceRange != null)
                {
                    hashCode = (hashCode * 59) + this.PriceRange.GetHashCode();
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
