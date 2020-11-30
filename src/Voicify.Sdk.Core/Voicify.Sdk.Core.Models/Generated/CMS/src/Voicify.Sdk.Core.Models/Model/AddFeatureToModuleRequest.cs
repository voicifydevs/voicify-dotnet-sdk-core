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
    /// AddFeatureToModuleRequest
    /// </summary>
    [DataContract]
    public partial class AddFeatureToModuleRequest :  IEquatable<AddFeatureToModuleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFeatureToModuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddFeatureToModuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFeatureToModuleRequest" /> class.
        /// </summary>
        /// <param name="featureId">featureId.</param>
        /// <param name="name">name (required).</param>
        public AddFeatureToModuleRequest(string featureId = default(string), string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AddFeatureToModuleRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.FeatureId = featureId;
        }
        
        /// <summary>
        /// Gets or Sets FeatureId
        /// </summary>
        [DataMember(Name="featureId", EmitDefaultValue=false)]
        public string FeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFeatureToModuleRequest {\n");
            sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AddFeatureToModuleRequest);
        }

        /// <summary>
        /// Returns true if AddFeatureToModuleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFeatureToModuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFeatureToModuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureId == input.FeatureId ||
                    (this.FeatureId != null &&
                    this.FeatureId.Equals(input.FeatureId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.FeatureId != null)
                    hashCode = hashCode * 59 + this.FeatureId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}
