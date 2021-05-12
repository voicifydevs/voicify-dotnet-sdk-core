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
    /// UpdateNumberRangeResponseRequest
    /// </summary>
    [DataContract]
        public partial class UpdateNumberRangeResponseRequest :  IEquatable<UpdateNumberRangeResponseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNumberRangeResponseRequest" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        /// <param name="responseId">responseId.</param>
        public UpdateNumberRangeResponseRequest(string content = default(string), string responseId = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for UpdateNumberRangeResponseRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.ResponseId = responseId;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets ResponseId
        /// </summary>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNumberRangeResponseRequest {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
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
            return this.Equals(input as UpdateNumberRangeResponseRequest);
        }

        /// <summary>
        /// Returns true if UpdateNumberRangeResponseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateNumberRangeResponseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNumberRangeResponseRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                return hashCode;
            }
        }

    }
}
