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
    /// InteractionModelUpdate
    /// </summary>
    [DataContract]
        public partial class InteractionModelUpdate :  IEquatable<InteractionModelUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionModelUpdate" /> class.
        /// </summary>
        /// <param name="effectiveAsOf">effectiveAsOf.</param>
        /// <param name="intents">intents.</param>
        /// <param name="disableIntents">disableIntents.</param>
        /// <param name="enableIntents">enableIntents.</param>
        /// <param name="isBaseUpdate">isBaseUpdate.</param>
        /// <param name="locale">locale.</param>
        public InteractionModelUpdate(long? effectiveAsOf = default(long?), Dictionary<string, IntentUpdate> intents = default(Dictionary<string, IntentUpdate>), List<IntentStatusUpdate> disableIntents = default(List<IntentStatusUpdate>), List<IntentStatusUpdate> enableIntents = default(List<IntentStatusUpdate>), bool? isBaseUpdate = default(bool?), string locale = default(string))
        {
            this.EffectiveAsOf = effectiveAsOf;
            this.Intents = intents;
            this.DisableIntents = disableIntents;
            this.EnableIntents = enableIntents;
            this.IsBaseUpdate = isBaseUpdate;
            this.Locale = locale;
        }
        
        /// <summary>
        /// Gets or Sets EffectiveAsOf
        /// </summary>
        [DataMember(Name="effectiveAsOf", EmitDefaultValue=false)]
        public long? EffectiveAsOf { get; set; }

        /// <summary>
        /// Gets or Sets Intents
        /// </summary>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public Dictionary<string, IntentUpdate> Intents { get; set; }

        /// <summary>
        /// Gets or Sets DisableIntents
        /// </summary>
        [DataMember(Name="disableIntents", EmitDefaultValue=false)]
        public List<IntentStatusUpdate> DisableIntents { get; set; }

        /// <summary>
        /// Gets or Sets EnableIntents
        /// </summary>
        [DataMember(Name="enableIntents", EmitDefaultValue=false)]
        public List<IntentStatusUpdate> EnableIntents { get; set; }

        /// <summary>
        /// Gets or Sets IsBaseUpdate
        /// </summary>
        [DataMember(Name="isBaseUpdate", EmitDefaultValue=false)]
        public bool? IsBaseUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionModelUpdate {\n");
            sb.Append("  EffectiveAsOf: ").Append(EffectiveAsOf).Append("\n");
            sb.Append("  Intents: ").Append(Intents).Append("\n");
            sb.Append("  DisableIntents: ").Append(DisableIntents).Append("\n");
            sb.Append("  EnableIntents: ").Append(EnableIntents).Append("\n");
            sb.Append("  IsBaseUpdate: ").Append(IsBaseUpdate).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InteractionModelUpdate);
        }

        /// <summary>
        /// Returns true if InteractionModelUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of InteractionModelUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionModelUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EffectiveAsOf == input.EffectiveAsOf ||
                    (this.EffectiveAsOf != null &&
                    this.EffectiveAsOf.Equals(input.EffectiveAsOf))
                ) && 
                (
                    this.Intents == input.Intents ||
                    this.Intents != null &&
                    input.Intents != null &&
                    this.Intents.SequenceEqual(input.Intents)
                ) && 
                (
                    this.DisableIntents == input.DisableIntents ||
                    this.DisableIntents != null &&
                    input.DisableIntents != null &&
                    this.DisableIntents.SequenceEqual(input.DisableIntents)
                ) && 
                (
                    this.EnableIntents == input.EnableIntents ||
                    this.EnableIntents != null &&
                    input.EnableIntents != null &&
                    this.EnableIntents.SequenceEqual(input.EnableIntents)
                ) && 
                (
                    this.IsBaseUpdate == input.IsBaseUpdate ||
                    (this.IsBaseUpdate != null &&
                    this.IsBaseUpdate.Equals(input.IsBaseUpdate))
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
                if (this.EffectiveAsOf != null)
                    hashCode = hashCode * 59 + this.EffectiveAsOf.GetHashCode();
                if (this.Intents != null)
                    hashCode = hashCode * 59 + this.Intents.GetHashCode();
                if (this.DisableIntents != null)
                    hashCode = hashCode * 59 + this.DisableIntents.GetHashCode();
                if (this.EnableIntents != null)
                    hashCode = hashCode * 59 + this.EnableIntents.GetHashCode();
                if (this.IsBaseUpdate != null)
                    hashCode = hashCode * 59 + this.IsBaseUpdate.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                return hashCode;
            }
        }

    }
}
