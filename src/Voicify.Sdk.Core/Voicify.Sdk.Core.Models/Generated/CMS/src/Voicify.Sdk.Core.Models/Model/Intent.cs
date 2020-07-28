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
    /// Intent
    /// </summary>
    [DataContract]
    public partial class Intent :  IEquatable<Intent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Intent" /> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="name">name.</param>
        /// <param name="utterances">utterances.</param>
        /// <param name="slots">slots.</param>
        /// <param name="isUserEditable">isUserEditable.</param>
        /// <param name="platformsToIgnoreUtterances">platformsToIgnoreUtterances.</param>
        public Intent(string displayName = default(string), Dictionary<string, string> name = default(Dictionary<string, string>), List<string> utterances = default(List<string>), List<Slot> slots = default(List<Slot>), bool? isUserEditable = default(bool?), List<string> platformsToIgnoreUtterances = default(List<string>))
        {
            this.DisplayName = displayName;
            this.Name = name;
            this.Utterances = utterances;
            this.Slots = slots;
            this.IsUserEditable = isUserEditable;
            this.PlatformsToIgnoreUtterances = platformsToIgnoreUtterances;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Gets or Sets Utterances
        /// </summary>
        [DataMember(Name="utterances", EmitDefaultValue=false)]
        public List<string> Utterances { get; set; }

        /// <summary>
        /// Gets or Sets Slots
        /// </summary>
        [DataMember(Name="slots", EmitDefaultValue=false)]
        public List<Slot> Slots { get; set; }

        /// <summary>
        /// Gets or Sets IsUserEditable
        /// </summary>
        [DataMember(Name="isUserEditable", EmitDefaultValue=false)]
        public bool? IsUserEditable { get; set; }

        /// <summary>
        /// Gets or Sets PlatformsToIgnoreUtterances
        /// </summary>
        [DataMember(Name="platformsToIgnoreUtterances", EmitDefaultValue=false)]
        public List<string> PlatformsToIgnoreUtterances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Intent {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Utterances: ").Append(Utterances).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
            sb.Append("  IsUserEditable: ").Append(IsUserEditable).Append("\n");
            sb.Append("  PlatformsToIgnoreUtterances: ").Append(PlatformsToIgnoreUtterances).Append("\n");
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
            return this.Equals(input as Intent);
        }

        /// <summary>
        /// Returns true if Intent instances are equal
        /// </summary>
        /// <param name="input">Instance of Intent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Intent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Utterances == input.Utterances ||
                    this.Utterances != null &&
                    this.Utterances.SequenceEqual(input.Utterances)
                ) && 
                (
                    this.Slots == input.Slots ||
                    this.Slots != null &&
                    this.Slots.SequenceEqual(input.Slots)
                ) && 
                (
                    this.IsUserEditable == input.IsUserEditable ||
                    (this.IsUserEditable != null &&
                    this.IsUserEditable.Equals(input.IsUserEditable))
                ) && 
                (
                    this.PlatformsToIgnoreUtterances == input.PlatformsToIgnoreUtterances ||
                    this.PlatformsToIgnoreUtterances != null &&
                    this.PlatformsToIgnoreUtterances.SequenceEqual(input.PlatformsToIgnoreUtterances)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Utterances != null)
                    hashCode = hashCode * 59 + this.Utterances.GetHashCode();
                if (this.Slots != null)
                    hashCode = hashCode * 59 + this.Slots.GetHashCode();
                if (this.IsUserEditable != null)
                    hashCode = hashCode * 59 + this.IsUserEditable.GetHashCode();
                if (this.PlatformsToIgnoreUtterances != null)
                    hashCode = hashCode * 59 + this.PlatformsToIgnoreUtterances.GetHashCode();
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