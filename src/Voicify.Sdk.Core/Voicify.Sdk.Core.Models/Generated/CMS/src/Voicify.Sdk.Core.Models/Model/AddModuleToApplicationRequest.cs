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
    /// AddModuleToApplicationRequest
    /// </summary>
    [DataContract]
    public partial class AddModuleToApplicationRequest :  IEquatable<AddModuleToApplicationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddModuleToApplicationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddModuleToApplicationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddModuleToApplicationRequest" /> class.
        /// </summary>
        /// <param name="moduleId">moduleId (required).</param>
        public AddModuleToApplicationRequest(string moduleId = default(string))
        {
            // to ensure "moduleId" is required (not null)
            if (moduleId == null)
            {
                throw new InvalidDataException("moduleId is a required property for AddModuleToApplicationRequest and cannot be null");
            }
            else
            {
                this.ModuleId = moduleId;
            }
        }
        
        /// <summary>
        /// Gets or Sets ModuleId
        /// </summary>
        [DataMember(Name="moduleId", EmitDefaultValue=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddModuleToApplicationRequest {\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
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
            return this.Equals(input as AddModuleToApplicationRequest);
        }

        /// <summary>
        /// Returns true if AddModuleToApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddModuleToApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddModuleToApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
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
                if (this.ModuleId != null)
                    hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                return hashCode;
            }
        }

    }

}
