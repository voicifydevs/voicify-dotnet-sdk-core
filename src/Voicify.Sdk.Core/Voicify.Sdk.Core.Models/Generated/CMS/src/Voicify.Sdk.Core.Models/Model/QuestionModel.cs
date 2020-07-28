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
    /// QuestionModel
    /// </summary>
    [DataContract]
    public partial class QuestionModel :  IEquatable<QuestionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="content">content.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="questionAnswerId">questionAnswerId.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="languageIds">languageIds.</param>
        /// <param name="requiredPhrases">requiredPhrases.</param>
        public QuestionModel(string id = default(string), string content = default(string), string applicationId = default(string), string applicationModuleId = default(string), string questionAnswerId = default(string), bool? isLive = default(bool?), bool? isComplete = default(bool?), bool? requiresParent = default(bool?), List<string> languageIds = default(List<string>), List<string> requiredPhrases = default(List<string>))
        {
            this.Id = id;
            this.Content = content;
            this.ApplicationId = applicationId;
            this.ApplicationModuleId = applicationModuleId;
            this.QuestionAnswerId = questionAnswerId;
            this.IsLive = isLive;
            this.IsComplete = isComplete;
            this.RequiresParent = requiresParent;
            this.LanguageIds = languageIds;
            this.RequiredPhrases = requiredPhrases;
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
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationModuleId
        /// </summary>
        [DataMember(Name="applicationModuleId", EmitDefaultValue=false)]
        public string ApplicationModuleId { get; set; }

        /// <summary>
        /// Gets or Sets QuestionAnswerId
        /// </summary>
        [DataMember(Name="questionAnswerId", EmitDefaultValue=false)]
        public string QuestionAnswerId { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name="isComplete", EmitDefaultValue=false)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets RequiresParent
        /// </summary>
        [DataMember(Name="requiresParent", EmitDefaultValue=false)]
        public bool? RequiresParent { get; set; }

        /// <summary>
        /// Gets or Sets LanguageIds
        /// </summary>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }

        /// <summary>
        /// Gets or Sets RequiredPhrases
        /// </summary>
        [DataMember(Name="requiredPhrases", EmitDefaultValue=false)]
        public List<string> RequiredPhrases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  QuestionAnswerId: ").Append(QuestionAnswerId).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            sb.Append("  RequiredPhrases: ").Append(RequiredPhrases).Append("\n");
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
            return this.Equals(input as QuestionModel);
        }

        /// <summary>
        /// Returns true if QuestionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of QuestionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionModel input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationModuleId == input.ApplicationModuleId ||
                    (this.ApplicationModuleId != null &&
                    this.ApplicationModuleId.Equals(input.ApplicationModuleId))
                ) && 
                (
                    this.QuestionAnswerId == input.QuestionAnswerId ||
                    (this.QuestionAnswerId != null &&
                    this.QuestionAnswerId.Equals(input.QuestionAnswerId))
                ) && 
                (
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    (this.IsComplete != null &&
                    this.IsComplete.Equals(input.IsComplete))
                ) && 
                (
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.LanguageIds == input.LanguageIds ||
                    this.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(input.LanguageIds)
                ) && 
                (
                    this.RequiredPhrases == input.RequiredPhrases ||
                    this.RequiredPhrases != null &&
                    this.RequiredPhrases.SequenceEqual(input.RequiredPhrases)
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationModuleId != null)
                    hashCode = hashCode * 59 + this.ApplicationModuleId.GetHashCode();
                if (this.QuestionAnswerId != null)
                    hashCode = hashCode * 59 + this.QuestionAnswerId.GetHashCode();
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.LanguageIds != null)
                    hashCode = hashCode * 59 + this.LanguageIds.GetHashCode();
                if (this.RequiredPhrases != null)
                    hashCode = hashCode * 59 + this.RequiredPhrases.GetHashCode();
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