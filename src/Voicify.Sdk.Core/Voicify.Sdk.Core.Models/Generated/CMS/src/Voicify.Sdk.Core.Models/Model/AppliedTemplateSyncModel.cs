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
    /// AppliedTemplateSyncModel
    /// </summary>
    [DataContract]
        public partial class AppliedTemplateSyncModel :  IEquatable<AppliedTemplateSyncModel>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public AppliedTemplateSyncType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public AppliedTemplateSyncStage? Stage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedTemplateSyncModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="requestStorageUrl">requestStorageUrl.</param>
        /// <param name="error">error.</param>
        /// <param name="type">type.</param>
        /// <param name="stage">stage.</param>
        public AppliedTemplateSyncModel(string id = default(string), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), string appliedApplicationTemplateFormId = default(string), string applicationId = default(string), string createdByUserId = default(string), string requestStorageUrl = default(string), string error = default(string), AppliedTemplateSyncType? type = default(AppliedTemplateSyncType?), AppliedTemplateSyncStage? stage = default(AppliedTemplateSyncStage?))
        {
            this.Id = id;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
            this.ApplicationId = applicationId;
            this.CreatedByUserId = createdByUserId;
            this.RequestStorageUrl = requestStorageUrl;
            this.Error = error;
            this.Type = type;
            this.Stage = stage;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets AppliedApplicationTemplateFormId
        /// </summary>
        [DataMember(Name="appliedApplicationTemplateFormId", EmitDefaultValue=false)]
        public string AppliedApplicationTemplateFormId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets RequestStorageUrl
        /// </summary>
        [DataMember(Name="requestStorageUrl", EmitDefaultValue=false)]
        public string RequestStorageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppliedTemplateSyncModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  AppliedApplicationTemplateFormId: ").Append(AppliedApplicationTemplateFormId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  RequestStorageUrl: ").Append(RequestStorageUrl).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
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
            return this.Equals(input as AppliedTemplateSyncModel);
        }

        /// <summary>
        /// Returns true if AppliedTemplateSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AppliedTemplateSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppliedTemplateSyncModel input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.AppliedApplicationTemplateFormId == input.AppliedApplicationTemplateFormId ||
                    (this.AppliedApplicationTemplateFormId != null &&
                    this.AppliedApplicationTemplateFormId.Equals(input.AppliedApplicationTemplateFormId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.RequestStorageUrl == input.RequestStorageUrl ||
                    (this.RequestStorageUrl != null &&
                    this.RequestStorageUrl.Equals(input.RequestStorageUrl))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.RequestStorageUrl != null)
                    hashCode = hashCode * 59 + this.RequestStorageUrl.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                return hashCode;
            }
        }

    }
}