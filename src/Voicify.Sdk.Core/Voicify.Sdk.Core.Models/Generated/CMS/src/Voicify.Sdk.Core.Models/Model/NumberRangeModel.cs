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
    /// NumberRangeModel
    /// </summary>
    [DataContract]
        public partial class NumberRangeModel :  IEquatable<NumberRangeModel>
    {
        /// <summary>
        /// Gets or Sets WebhookChainingType
        /// </summary>
        [DataMember(Name="webhookChainingType", EmitDefaultValue=false)]
        public WebhookChainingType? WebhookChainingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberRangeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="responses">responses.</param>
        /// <param name="numberRangeWebhooks">numberRangeWebhooks.</param>
        /// <param name="hits">hits.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="minimumValue">minimumValue.</param>
        /// <param name="maximumValue">maximumValue.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="languages">languages.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        /// <param name="webhookChainingType">webhookChainingType.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        public NumberRangeModel(string id = default(string), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), bool? isLive = default(bool?), string applicationModuleId = default(string), List<NumberRangeResponseModel> responses = default(List<NumberRangeResponseModel>), List<NumberRangeWebhookModel> numberRangeWebhooks = default(List<NumberRangeWebhookModel>), int? hits = default(int?), DateTime? modifiedDate = default(DateTime?), DateTime? createdDate = default(DateTime?), double? minimumValue = default(double?), double? maximumValue = default(double?), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), string createdFromId = default(string), List<LanguageModel> languages = default(List<LanguageModel>), bool? shouldNotSync = default(bool?), WebhookChainingType? webhookChainingType = default(WebhookChainingType?), string appliedApplicationTemplateFormId = default(string))
        {
            this.Id = id;
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.IsLive = isLive;
            this.ApplicationModuleId = applicationModuleId;
            this.Responses = responses;
            this.NumberRangeWebhooks = numberRangeWebhooks;
            this.Hits = hits;
            this.ModifiedDate = modifiedDate;
            this.CreatedDate = createdDate;
            this.MinimumValue = minimumValue;
            this.MaximumValue = maximumValue;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.CreatedFromId = createdFromId;
            this.Languages = languages;
            this.ShouldNotSync = shouldNotSync;
            this.WebhookChainingType = webhookChainingType;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
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
        public List<NumberRangeResponseModel> Responses { get; set; }

        /// <summary>
        /// Gets or Sets NumberRangeWebhooks
        /// </summary>
        [DataMember(Name="numberRangeWebhooks", EmitDefaultValue=false)]
        public List<NumberRangeWebhookModel> NumberRangeWebhooks { get; set; }

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
        /// Gets or Sets MinimumValue
        /// </summary>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }

        /// <summary>
        /// Gets or Sets MaximumValue
        /// </summary>
        [DataMember(Name="maximumValue", EmitDefaultValue=false)]
        public double? MaximumValue { get; set; }

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
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageModel> Languages { get; set; }

        /// <summary>
        /// Gets or Sets ShouldNotSync
        /// </summary>
        [DataMember(Name="shouldNotSync", EmitDefaultValue=false)]
        public bool? ShouldNotSync { get; set; }


        /// <summary>
        /// Gets or Sets AppliedApplicationTemplateFormId
        /// </summary>
        [DataMember(Name="appliedApplicationTemplateFormId", EmitDefaultValue=false)]
        public string AppliedApplicationTemplateFormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberRangeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  NumberRangeWebhooks: ").Append(NumberRangeWebhooks).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
            sb.Append("  WebhookChainingType: ").Append(WebhookChainingType).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
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
            return this.Equals(input as NumberRangeModel);
        }

        /// <summary>
        /// Returns true if NumberRangeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NumberRangeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberRangeModel input)
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
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.NumberRangeWebhooks == input.NumberRangeWebhooks ||
                    this.NumberRangeWebhooks != null &&
                    input.NumberRangeWebhooks != null &&
                    this.NumberRangeWebhooks.SequenceEqual(input.NumberRangeWebhooks)
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
                    this.MinimumValue == input.MinimumValue ||
                    (this.MinimumValue != null &&
                    this.MinimumValue.Equals(input.MinimumValue))
                ) && 
                (
                    this.MaximumValue == input.MaximumValue ||
                    (this.MaximumValue != null &&
                    this.MaximumValue.Equals(input.MaximumValue))
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
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.ShouldNotSync == input.ShouldNotSync ||
                    (this.ShouldNotSync != null &&
                    this.ShouldNotSync.Equals(input.ShouldNotSync))
                ) && 
                (
                    this.WebhookChainingType == input.WebhookChainingType ||
                    (this.WebhookChainingType != null &&
                    this.WebhookChainingType.Equals(input.WebhookChainingType))
                ) && 
                (
                    this.AppliedApplicationTemplateFormId == input.AppliedApplicationTemplateFormId ||
                    (this.AppliedApplicationTemplateFormId != null &&
                    this.AppliedApplicationTemplateFormId.Equals(input.AppliedApplicationTemplateFormId))
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
                if (this.NumberRangeWebhooks != null)
                    hashCode = hashCode * 59 + this.NumberRangeWebhooks.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.MinimumValue != null)
                    hashCode = hashCode * 59 + this.MinimumValue.GetHashCode();
                if (this.MaximumValue != null)
                    hashCode = hashCode * 59 + this.MaximumValue.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.IsComplete != null)
                    hashCode = hashCode * 59 + this.IsComplete.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.ShouldNotSync != null)
                    hashCode = hashCode * 59 + this.ShouldNotSync.GetHashCode();
                if (this.WebhookChainingType != null)
                    hashCode = hashCode * 59 + this.WebhookChainingType.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                return hashCode;
            }
        }

    }
}
