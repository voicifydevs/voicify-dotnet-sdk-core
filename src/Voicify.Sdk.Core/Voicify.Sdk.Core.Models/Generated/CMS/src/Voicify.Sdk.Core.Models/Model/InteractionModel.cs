/* 
 * Voicify CMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace Voicify.Sdk.Core.Models.Model
{
    /// <summary>
    /// InteractionModel
    /// </summary>
    [DataContract]
    public partial class InteractionModel :  IEquatable<InteractionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionModel" /> class.
        /// </summary>
        /// <param name="validAsOf">validAsOf.</param>
        /// <param name="locale">locale.</param>
        /// <param name="intents">intents.</param>
        /// <param name="disabledIntents">disabledIntents.</param>
        public InteractionModel(long? validAsOf = default(long?), string locale = default(string), List<Intent> intents = default(List<Intent>), List<DisabledIntent> disabledIntents = default(List<DisabledIntent>))
        {
            this.ValidAsOf = validAsOf;
            this.Locale = locale;
            this.Intents = intents;
            this.DisabledIntents = disabledIntents;
        }
        
        /// <summary>
        /// Gets or Sets ValidAsOf
        /// </summary>
        [DataMember(Name="validAsOf", EmitDefaultValue=false)]
        public long? ValidAsOf { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Intents
        /// </summary>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public List<Intent> Intents { get; set; }

        /// <summary>
        /// Gets or Sets DisabledIntents
        /// </summary>
        [DataMember(Name="disabledIntents", EmitDefaultValue=false)]
        public List<DisabledIntent> DisabledIntents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionModel {\n");
            sb.Append("  ValidAsOf: ").Append(ValidAsOf).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Intents: ").Append(Intents).Append("\n");
            sb.Append("  DisabledIntents: ").Append(DisabledIntents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InteractionModel);
        }

        /// <summary>
        /// Returns true if InteractionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InteractionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidAsOf == input.ValidAsOf ||
                    (this.ValidAsOf != null &&
                    this.ValidAsOf.Equals(input.ValidAsOf))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Intents == input.Intents ||
                    this.Intents != null &&
                    this.Intents.SequenceEqual(input.Intents)
                ) && 
                (
                    this.DisabledIntents == input.DisabledIntents ||
                    this.DisabledIntents != null &&
                    this.DisabledIntents.SequenceEqual(input.DisabledIntents)
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
                if (this.ValidAsOf != null)
                    hashCode = hashCode * 59 + this.ValidAsOf.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Intents != null)
                    hashCode = hashCode * 59 + this.Intents.GetHashCode();
                if (this.DisabledIntents != null)
                    hashCode = hashCode * 59 + this.DisabledIntents.GetHashCode();
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

}