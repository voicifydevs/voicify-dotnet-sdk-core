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
    /// SsmlRequest
    /// </summary>
    [DataContract]
        public partial class SsmlRequest :  IEquatable<SsmlRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsmlRequest" /> class.
        /// </summary>
        /// <param name="ssml">ssml (required).</param>
        /// <param name="locale">locale.</param>
        public SsmlRequest(string ssml = default(string), string locale = default(string))
        {
            // to ensure "ssml" is required (not null)
            if (ssml == null)
            {
                throw new InvalidDataException("ssml is a required property for SsmlRequest and cannot be null");
            }
            else
            {
                this.Ssml = ssml;
            }
            this.Locale = locale;
        }
        
        /// <summary>
        /// Gets or Sets Ssml
        /// </summary>
        [DataMember(Name="ssml", EmitDefaultValue=false)]
        public string Ssml { get; set; }

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
            sb.Append("class SsmlRequest {\n");
            sb.Append("  Ssml: ").Append(Ssml).Append("\n");
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
            return this.Equals(input as SsmlRequest);
        }

        /// <summary>
        /// Returns true if SsmlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SsmlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsmlRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ssml == input.Ssml ||
                    (this.Ssml != null &&
                    this.Ssml.Equals(input.Ssml))
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
                if (this.Ssml != null)
                    hashCode = hashCode * 59 + this.Ssml.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                return hashCode;
            }
        }

    }
}
