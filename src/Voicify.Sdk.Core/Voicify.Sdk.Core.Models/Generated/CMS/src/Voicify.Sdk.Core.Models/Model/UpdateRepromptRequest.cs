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
    /// UpdateRepromptRequest
    /// </summary>
    [DataContract]
    public partial class UpdateRepromptRequest :  IEquatable<UpdateRepromptRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRepromptRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateRepromptRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRepromptRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="content">content (required).</param>
        /// <param name="name">name.</param>
        /// <param name="includeFollowUp">includeFollowUp.</param>
        public UpdateRepromptRequest(string id = default(string), string content = default(string), string name = default(string), bool? includeFollowUp = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UpdateRepromptRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for UpdateRepromptRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.Name = name;
            this.IncludeFollowUp = includeFollowUp;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IncludeFollowUp
        /// </summary>
        [DataMember(Name="includeFollowUp", EmitDefaultValue=false)]
        public bool? IncludeFollowUp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepromptRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IncludeFollowUp: ").Append(IncludeFollowUp).Append("\n");
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
            return this.Equals(input as UpdateRepromptRequest);
        }

        /// <summary>
        /// Returns true if UpdateRepromptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRepromptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRepromptRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IncludeFollowUp == input.IncludeFollowUp ||
                    (this.IncludeFollowUp != null &&
                    this.IncludeFollowUp.Equals(input.IncludeFollowUp))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IncludeFollowUp != null)
                    hashCode = hashCode * 59 + this.IncludeFollowUp.GetHashCode();
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