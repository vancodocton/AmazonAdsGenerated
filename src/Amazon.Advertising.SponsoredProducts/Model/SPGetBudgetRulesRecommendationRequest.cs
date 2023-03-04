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
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

using JsonSubTypes;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

using OpenAPIDateConverter = Amazon.Advertising.SponsoredProducts.Client.OpenAPIDateConverter;

namespace Amazon.Advertising.SponsoredProducts.Model
{
    /// <summary>
    /// SPGetBudgetRulesRecommendationRequest
    /// </summary>
    [JsonConverter(typeof(SPGetBudgetRulesRecommendationRequestJsonConverter))]
    [DataContract(Name = "SPGetBudgetRulesRecommendation_request")]
    public partial class SPGetBudgetRulesRecommendationRequest : AbstractOpenAPISchema, IEquatable<SPGetBudgetRulesRecommendationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPGetBudgetRulesRecommendationRequest" /> class
        /// with the <see cref="SPBudgetRulesRecommendationEventRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SPBudgetRulesRecommendationEventRequest.</param>
        public SPGetBudgetRulesRecommendationRequest(SPBudgetRulesRecommendationEventRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType = "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(SPBudgetRulesRecommendationEventRequest))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: SPBudgetRulesRecommendationEventRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `SPBudgetRulesRecommendationEventRequest`. If the actual instance is not `SPBudgetRulesRecommendationEventRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SPBudgetRulesRecommendationEventRequest</returns>
        public SPBudgetRulesRecommendationEventRequest GetSPBudgetRulesRecommendationEventRequest()
        {
            return (SPBudgetRulesRecommendationEventRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPGetBudgetRulesRecommendationRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, SPGetBudgetRulesRecommendationRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SPGetBudgetRulesRecommendationRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SPGetBudgetRulesRecommendationRequest</returns>
        public static SPGetBudgetRulesRecommendationRequest FromJson(string jsonString)
        {
            SPGetBudgetRulesRecommendationRequest newSPGetBudgetRulesRecommendationRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSPGetBudgetRulesRecommendationRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SPBudgetRulesRecommendationEventRequest).GetProperty("AdditionalProperties") == null)
                {
                    newSPGetBudgetRulesRecommendationRequest = new SPGetBudgetRulesRecommendationRequest(JsonConvert.DeserializeObject<SPBudgetRulesRecommendationEventRequest>(jsonString, SPGetBudgetRulesRecommendationRequest.SerializerSettings));
                }
                else
                {
                    newSPGetBudgetRulesRecommendationRequest = new SPGetBudgetRulesRecommendationRequest(JsonConvert.DeserializeObject<SPBudgetRulesRecommendationEventRequest>(jsonString, SPGetBudgetRulesRecommendationRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SPBudgetRulesRecommendationEventRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SPBudgetRulesRecommendationEventRequest: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newSPGetBudgetRulesRecommendationRequest;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SPGetBudgetRulesRecommendationRequest);
        }

        /// <summary>
        /// Returns true if SPGetBudgetRulesRecommendationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SPGetBudgetRulesRecommendationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPGetBudgetRulesRecommendationRequest input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for SPGetBudgetRulesRecommendationRequest
    /// </summary>
    public class SPGetBudgetRulesRecommendationRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SPGetBudgetRulesRecommendationRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Null)
            {
                return SPGetBudgetRulesRecommendationRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
