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
    /// Genre
    /// </summary>
    [DataContract(Name = "Genre")]
    public partial class Genre : IEquatable<Genre>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre" /> class.
        /// </summary>
        /// <param name="name">Name of Genre. This field is OPTIONAL if the Genre object is being used as an input..</param>
        /// <param name="id">Id of Genre. This field is REQUIRED if the Genre object is being used as an input. Use the GetRefinementsForCategory to retrieve Genre Node IDs..</param>
        public Genre(string name = default(string), string id = default(string))
        {
            this.Name = name;
            this.Id = id;
        }

        /// <summary>
        /// Name of Genre. This field is OPTIONAL if the Genre object is being used as an input.
        /// </summary>
        /// <value>Name of Genre. This field is OPTIONAL if the Genre object is being used as an input.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Id of Genre. This field is REQUIRED if the Genre object is being used as an input. Use the GetRefinementsForCategory to retrieve Genre Node IDs.
        /// </summary>
        /// <value>Id of Genre. This field is REQUIRED if the Genre object is being used as an input. Use the GetRefinementsForCategory to retrieve Genre Node IDs.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Genre {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as Genre);
        }

        /// <summary>
        /// Returns true if Genre instances are equal
        /// </summary>
        /// <param name="input">Instance of Genre to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Genre input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
