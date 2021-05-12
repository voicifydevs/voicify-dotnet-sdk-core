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
    /// DialogflowAgentInformation
    /// </summary>
    [DataContract]
        public partial class DialogflowAgentInformation :  IEquatable<DialogflowAgentInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogflowAgentInformation" /> class.
        /// </summary>
        /// <param name="parent">parent.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="defaultLanguageCode">defaultLanguageCode.</param>
        public DialogflowAgentInformation(string parent = default(string), string displayName = default(string), string defaultLanguageCode = default(string))
        {
            this.Parent = parent;
            this.DisplayName = displayName;
            this.DefaultLanguageCode = defaultLanguageCode;
        }
        
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DefaultLanguageCode
        /// </summary>
        [DataMember(Name="defaultLanguageCode", EmitDefaultValue=false)]
        public string DefaultLanguageCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialogflowAgentInformation {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DefaultLanguageCode: ").Append(DefaultLanguageCode).Append("\n");
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
            return this.Equals(input as DialogflowAgentInformation);
        }

        /// <summary>
        /// Returns true if DialogflowAgentInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of DialogflowAgentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialogflowAgentInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DefaultLanguageCode == input.DefaultLanguageCode ||
                    (this.DefaultLanguageCode != null &&
                    this.DefaultLanguageCode.Equals(input.DefaultLanguageCode))
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
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DefaultLanguageCode != null)
                    hashCode = hashCode * 59 + this.DefaultLanguageCode.GetHashCode();
                return hashCode;
            }
        }

    }
}
