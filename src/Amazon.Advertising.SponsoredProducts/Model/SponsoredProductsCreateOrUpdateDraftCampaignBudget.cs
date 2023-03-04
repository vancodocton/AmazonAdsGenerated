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
    /// SponsoredProductsCreateOrUpdateDraftCampaignBudget
    /// </summary>
    [DataContract(Name = "SponsoredProductsCreateOrUpdateDraftCampaignBudget")]
    public partial class SponsoredProductsCreateOrUpdateDraftCampaignBudget : IEquatable<SponsoredProductsCreateOrUpdateDraftCampaignBudget>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BudgetType
        /// </summary>
        [DataMember(Name = "budgetType", IsRequired = true, EmitDefaultValue = true)]
        public SponsoredProductsCreateOrUpdateDraftCampaignBudgetType BudgetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateOrUpdateDraftCampaignBudget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SponsoredProductsCreateOrUpdateDraftCampaignBudget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SponsoredProductsCreateOrUpdateDraftCampaignBudget" /> class.
        /// </summary>
        /// <param name="budgetType">budgetType (required).</param>
        /// <param name="budget">Monetary value (required).</param>
        public SponsoredProductsCreateOrUpdateDraftCampaignBudget(SponsoredProductsCreateOrUpdateDraftCampaignBudgetType budgetType = default(SponsoredProductsCreateOrUpdateDraftCampaignBudgetType), double budget = default(double))
        {
            this.BudgetType = budgetType;
            this.Budget = budget;
        }

        /// <summary>
        /// Monetary value
        /// </summary>
        /// <value>Monetary value</value>
        [DataMember(Name = "budget", IsRequired = true, EmitDefaultValue = true)]
        public double Budget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SponsoredProductsCreateOrUpdateDraftCampaignBudget {\n");
            sb.Append("  BudgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
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
            return this.Equals(input as SponsoredProductsCreateOrUpdateDraftCampaignBudget);
        }

        /// <summary>
        /// Returns true if SponsoredProductsCreateOrUpdateDraftCampaignBudget instances are equal
        /// </summary>
        /// <param name="input">Instance of SponsoredProductsCreateOrUpdateDraftCampaignBudget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SponsoredProductsCreateOrUpdateDraftCampaignBudget input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetType == input.BudgetType ||
                    this.BudgetType.Equals(input.BudgetType)
                ) && 
                (
                    this.Budget == input.Budget ||
                    this.Budget.Equals(input.Budget)
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
                hashCode = (hashCode * 59) + this.BudgetType.GetHashCode();
                hashCode = (hashCode * 59) + this.Budget.GetHashCode();
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