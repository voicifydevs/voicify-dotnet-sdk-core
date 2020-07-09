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
    /// SimpleChoiceExportModel
    /// </summary>
    [DataContract]
    public partial class SimpleChoiceExportModel :  IEquatable<SimpleChoiceExportModel>, IValidatableObject
    {
        /// <summary>
        /// Defines ChoiceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChoiceTypeEnum
        {
            
            /// <summary>
            /// Enum Yes for value: Yes
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes = 1,
            
            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 2,
            
            /// <summary>
            /// Enum Maybe for value: Maybe
            /// </summary>
            [EnumMember(Value = "Maybe")]
            Maybe = 3
        }

        /// <summary>
        /// Gets or Sets ChoiceType
        /// </summary>
        [DataMember(Name="choiceType", EmitDefaultValue=false)]
        public ChoiceTypeEnum? ChoiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleChoiceExportModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="responses">responses.</param>
        /// <param name="hits">hits.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="choiceType">choiceType.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="simpleChoiceWebhooks">simpleChoiceWebhooks.</param>
        /// <param name="languages">languages.</param>
        /// <param name="createdFromId">createdFromId.</param>
        public SimpleChoiceExportModel(string id = default(string), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), bool? isLive = default(bool?), string applicationModuleId = default(string), List<SimpleChoiceResponseModel> responses = default(List<SimpleChoiceResponseModel>), int? hits = default(int?), DateTime? modifiedDate = default(DateTime?), DateTime? createdDate = default(DateTime?), ChoiceTypeEnum? choiceType = default(ChoiceTypeEnum?), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), List<SimpleChoiceWebhookModel> simpleChoiceWebhooks = default(List<SimpleChoiceWebhookModel>), List<LanguageModel> languages = default(List<LanguageModel>), string createdFromId = default(string))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.IsLive = isLive;
            this.ApplicationModuleId = applicationModuleId;
            this.Responses = responses;
            this.Hits = hits;
            this.ModifiedDate = modifiedDate;
            this.CreatedDate = createdDate;
            this.ChoiceType = choiceType;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.SimpleChoiceWebhooks = simpleChoiceWebhooks;
            this.Languages = languages;
            this.CreatedFromId = createdFromId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFeatureId
        /// </summary>
        [DataMember(Name="applicationFeatureId", EmitDefaultValue=false)]
        public string ApplicationFeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets IsLive
        /// </summary>
        [DataMember(Name="isLive", EmitDefaultValue=false)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationModuleId
        /// </summary>
        [DataMember(Name="applicationModuleId", EmitDefaultValue=false)]
        public string ApplicationModuleId { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<SimpleChoiceResponseModel> Responses { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=false)]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Gets or Sets RequiresParent
        /// </summary>
        [DataMember(Name="requiresParent", EmitDefaultValue=false)]
        public bool? RequiresParent { get; set; }

        /// <summary>
        /// Gets or Sets IsComplete
        /// </summary>
        [DataMember(Name="isComplete", EmitDefaultValue=false)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or Sets SimpleChoiceWebhooks
        /// </summary>
        [DataMember(Name="simpleChoiceWebhooks", EmitDefaultValue=false)]
        public List<SimpleChoiceWebhookModel> SimpleChoiceWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleChoiceExportModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ChoiceType: ").Append(ChoiceType).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  SimpleChoiceWebhooks: ").Append(SimpleChoiceWebhooks).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
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
            return this.Equals(input as SimpleChoiceExportModel);
        }

        /// <summary>
        /// Returns true if SimpleChoiceExportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleChoiceExportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleChoiceExportModel input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationFeatureId == input.ApplicationFeatureId ||
                    (this.ApplicationFeatureId != null &&
                    this.ApplicationFeatureId.Equals(input.ApplicationFeatureId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.IsLive == input.IsLive ||
                    (this.IsLive != null &&
                    this.IsLive.Equals(input.IsLive))
                ) && 
                (
                    this.ApplicationModuleId == input.ApplicationModuleId ||
                    (this.ApplicationModuleId != null &&
                    this.ApplicationModuleId.Equals(input.ApplicationModuleId))
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ChoiceType == input.ChoiceType ||
                    (this.ChoiceType != null &&
                    this.ChoiceType.Equals(input.ChoiceType))
                ) && 
                (
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    (this.IsComplete != null &&
                    this.IsComplete.Equals(input.IsComplete))
                ) && 
                (
                    this.SimpleChoiceWebhooks == input.SimpleChoiceWebhooks ||
                    this.SimpleChoiceWebhooks != null &&
                    this.SimpleChoiceWebhooks.SequenceEqual(input.SimpleChoiceWebhooks)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.ApplicationModuleId != null)
                    hashCode = hashCode * 59 + this.ApplicationModuleId.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ChoiceType != null)
                    hashCode = hashCode * 59 + this.ChoiceType.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.SimpleChoiceWebhooks != null)
                    hashCode = hashCode * 59 + this.SimpleChoiceWebhooks.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
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
