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
    /// CategoryItem
    /// </summary>
    [DataContract(Name = "CategoryItem")]
    public partial class CategoryItem : IEquatable<CategoryItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryItem" /> class.
        /// </summary>
        /// <param name="parent">The category id of the parent node.</param>
        /// <param name="path">The path of the category, which contains the current category and all parent categories.</param>
        /// <param name="canBeTargeted">A flag which indicates if the current node may be targeted.</param>
        /// <param name="name">The name of the category.</param>
        /// <param name="id">The category id of the current node.</param>
        public CategoryItem(string parent = default(string), string path = default(string), bool canBeTargeted = default(bool), string name = default(string), string id = default(string))
        {
            this.Parent = parent;
            this.Path = path;
            this.CanBeTargeted = canBeTargeted;
            this.Name = name;
            this.Id = id;
        }

        /// <summary>
        /// The category id of the parent node
        /// </summary>
        /// <value>The category id of the parent node</value>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public string Parent { get; set; }

        /// <summary>
        /// The path of the category, which contains the current category and all parent categories
        /// </summary>
        /// <value>The path of the category, which contains the current category and all parent categories</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// A flag which indicates if the current node may be targeted
        /// </summary>
        /// <value>A flag which indicates if the current node may be targeted</value>
        [DataMember(Name = "canBeTargeted", EmitDefaultValue = true)]
        public bool CanBeTargeted { get; set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        /// <value>The name of the category</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The category id of the current node
        /// </summary>
        /// <value>The category id of the current node</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CategoryItem {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  CanBeTargeted: ").Append(CanBeTargeted).Append("\n");
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
            return this.Equals(input as CategoryItem);
        }

        /// <summary>
        /// Returns true if CategoryItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryItem input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) &&
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) &&
                (
                    this.CanBeTargeted == input.CanBeTargeted ||
                    this.CanBeTargeted.Equals(input.CanBeTargeted)
                ) &&
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
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CanBeTargeted.GetHashCode();
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
