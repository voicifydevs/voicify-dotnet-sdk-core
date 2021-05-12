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
    /// CustomRequestExportModel
    /// </summary>
    [DataContract]
        public partial class CustomRequestExportModel :  IEquatable<CustomRequestExportModel>
    {
        /// <summary>
        /// Gets or Sets WebhookChainingType
        /// </summary>
        [DataMember(Name="webhookChainingType", EmitDefaultValue=false)]
        public WebhookChainingType? WebhookChainingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRequestExportModel" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationFeatureId">applicationFeatureId.</param>
        /// <param name="title">title.</param>
        /// <param name="id">id.</param>
        /// <param name="isLive">isLive.</param>
        /// <param name="applicationModuleId">applicationModuleId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="responses">responses.</param>
        /// <param name="customRequestWebhooks">customRequestWebhooks.</param>
        /// <param name="hits">hits.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="requestTypes">requestTypes.</param>
        /// <param name="requestNames">requestNames.</param>
        /// <param name="platformFilter">platformFilter.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="languages">languages.</param>
        /// <param name="shouldNotSync">shouldNotSync.</param>
        /// <param name="webhookChainingType">webhookChainingType.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        /// <param name="sharedReferences">sharedReferences.</param>
        public CustomRequestExportModel(string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), string id = default(string), bool? isLive = default(bool?), string applicationModuleId = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<CustomRequestResponseModel> responses = default(List<CustomRequestResponseModel>), List<CustomRequestWebhookModel> customRequestWebhooks = default(List<CustomRequestWebhookModel>), int? hits = default(int?), DateTime? modifiedDate = default(DateTime?), DateTime? createdDate = default(DateTime?), string requestTypes = default(string), string requestNames = default(string), string platformFilter = default(string), bool? requiresParent = default(bool?), bool? isComplete = default(bool?), string createdFromId = default(string), List<LanguageModel> languages = default(List<LanguageModel>), bool? shouldNotSync = default(bool?), WebhookChainingType? webhookChainingType = default(WebhookChainingType?), string appliedApplicationTemplateFormId = default(string), SharedReferencesExportModel sharedReferences = default(SharedReferencesExportModel))
        {
            this.ApplicationId = applicationId;
            this.ApplicationFeatureId = applicationFeatureId;
            this.Title = title;
            this.Id = id;
            this.IsLive = isLive;
            this.ApplicationModuleId = applicationModuleId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Responses = responses;
            this.CustomRequestWebhooks = customRequestWebhooks;
            this.Hits = hits;
            this.ModifiedDate = modifiedDate;
            this.CreatedDate = createdDate;
            this.RequestTypes = requestTypes;
            this.RequestNames = requestNames;
            this.PlatformFilter = platformFilter;
            this.RequiresParent = requiresParent;
            this.IsComplete = isComplete;
            this.CreatedFromId = createdFromId;
            this.Languages = languages;
            this.ShouldNotSync = shouldNotSync;
            this.WebhookChainingType = webhookChainingType;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
            this.SharedReferences = sharedReferences;
        }
        
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<CustomRequestResponseModel> Responses { get; set; }

        /// <summary>
        /// Gets or Sets CustomRequestWebhooks
        /// </summary>
        [DataMember(Name="customRequestWebhooks", EmitDefaultValue=false)]
        public List<CustomRequestWebhookModel> CustomRequestWebhooks { get; set; }

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
        /// Gets or Sets RequestTypes
        /// </summary>
        [DataMember(Name="requestTypes", EmitDefaultValue=false)]
        public string RequestTypes { get; set; }

        /// <summary>
        /// Gets or Sets RequestNames
        /// </summary>
        [DataMember(Name="requestNames", EmitDefaultValue=false)]
        public string RequestNames { get; set; }

        /// <summary>
        /// Gets or Sets PlatformFilter
        /// </summary>
        [DataMember(Name="platformFilter", EmitDefaultValue=false)]
        public string PlatformFilter { get; set; }

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
        /// Gets or Sets SharedReferences
        /// </summary>
        [DataMember(Name="sharedReferences", EmitDefaultValue=false)]
        public SharedReferencesExportModel SharedReferences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomRequestExportModel {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsLive: ").Append(IsLive).Append("\n");
            sb.Append("  ApplicationModuleId: ").Append(ApplicationModuleId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  CustomRequestWebhooks: ").Append(CustomRequestWebhooks).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  RequestTypes: ").Append(RequestTypes).Append("\n");
            sb.Append("  RequestNames: ").Append(RequestNames).Append("\n");
            sb.Append("  PlatformFilter: ").Append(PlatformFilter).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  ShouldNotSync: ").Append(ShouldNotSync).Append("\n");
            sb.Append("  WebhookChainingType: ").Append(WebhookChainingType).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
            sb.Append("  SharedReferences: ").Append(SharedReferences).Append("\n");
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
            return this.Equals(input as CustomRequestExportModel);
        }

        /// <summary>
        /// Returns true if CustomRequestExportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomRequestExportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomRequestExportModel input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.CustomRequestWebhooks == input.CustomRequestWebhooks ||
                    this.CustomRequestWebhooks != null &&
                    input.CustomRequestWebhooks != null &&
                    this.CustomRequestWebhooks.SequenceEqual(input.CustomRequestWebhooks)
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
                    this.RequestTypes == input.RequestTypes ||
                    (this.RequestTypes != null &&
                    this.RequestTypes.Equals(input.RequestTypes))
                ) && 
                (
                    this.RequestNames == input.RequestNames ||
                    (this.RequestNames != null &&
                    this.RequestNames.Equals(input.RequestNames))
                ) && 
                (
                    this.PlatformFilter == input.PlatformFilter ||
                    (this.PlatformFilter != null &&
                    this.PlatformFilter.Equals(input.PlatformFilter))
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
                ) && 
                (
                    this.SharedReferences == input.SharedReferences ||
                    (this.SharedReferences != null &&
                    this.SharedReferences.Equals(input.SharedReferences))
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
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsLive != null)
                    hashCode = hashCode * 59 + this.IsLive.GetHashCode();
                if (this.ApplicationModuleId != null)
                    hashCode = hashCode * 59 + this.ApplicationModuleId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.CustomRequestWebhooks != null)
                    hashCode = hashCode * 59 + this.CustomRequestWebhooks.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.RequestTypes != null)
                    hashCode = hashCode * 59 + this.RequestTypes.GetHashCode();
                if (this.RequestNames != null)
                    hashCode = hashCode * 59 + this.RequestNames.GetHashCode();
                if (this.PlatformFilter != null)
                    hashCode = hashCode * 59 + this.PlatformFilter.GetHashCode();
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
                if (this.SharedReferences != null)
                    hashCode = hashCode * 59 + this.SharedReferences.GetHashCode();
                return hashCode;
            }
        }

    }
}
