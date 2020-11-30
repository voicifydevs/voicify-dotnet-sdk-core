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
    /// BulkContentRequest
    /// </summary>
    [DataContract]
    public partial class BulkContentRequest :  IEquatable<BulkContentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkContentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkContentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkContentRequest" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="content">content.</param>
        /// <param name="applicationFeatures">applicationFeatures.</param>
        public BulkContentRequest(string applicationId = default(string), List<ContentRequestItem> content = default(List<ContentRequestItem>), List<ApplicationFeatureRequestItem> applicationFeatures = default(List<ApplicationFeatureRequestItem>))
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for BulkContentRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            this.Content = content;
            this.ApplicationFeatures = applicationFeatures;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<ContentRequestItem> Content { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFeatures
        /// </summary>
        [DataMember(Name="applicationFeatures", EmitDefaultValue=false)]
        public List<ApplicationFeatureRequestItem> ApplicationFeatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkContentRequest {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ApplicationFeatures: ").Append(ApplicationFeatures).Append("\n");
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
            return this.Equals(input as BulkContentRequest);
        }

        /// <summary>
        /// Returns true if BulkContentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkContentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkContentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.ApplicationFeatures == input.ApplicationFeatures ||
                    this.ApplicationFeatures != null &&
                    this.ApplicationFeatures.SequenceEqual(input.ApplicationFeatures)
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ApplicationFeatures != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatures.GetHashCode();
                return hashCode;
            }
        }

    }

}
