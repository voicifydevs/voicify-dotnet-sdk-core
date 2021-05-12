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
    /// MediaResponseModel
    /// </summary>
    [DataContract]
        public partial class MediaResponseModel :  IEquatable<MediaResponseModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaResponseModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="responseTemplateTypeId">responseTemplateTypeId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="displayTitle">displayTitle.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="readoutOverride">readoutOverride.</param>
        /// <param name="foregroundImageItemId">foregroundImageItemId.</param>
        /// <param name="backgroundImageItemId">backgroundImageItemId.</param>
        /// <param name="audioItemId">audioItemId.</param>
        /// <param name="videoItemId">videoItemId.</param>
        /// <param name="deviceTargetId">deviceTargetId.</param>
        /// <param name="customMarkup">customMarkup.</param>
        /// <param name="createdFromId">createdFromId.</param>
        /// <param name="responseTemplateType">responseTemplateType.</param>
        /// <param name="foregroundImageItem">foregroundImageItem.</param>
        /// <param name="backgroundImageItem">backgroundImageItem.</param>
        /// <param name="audioItem">audioItem.</param>
        /// <param name="videoItem">videoItem.</param>
        /// <param name="deviceTarget">deviceTarget.</param>
        /// <param name="appliedApplicationTemplateFormId">appliedApplicationTemplateFormId.</param>
        public MediaResponseModel(string id = default(string), string responseTemplateTypeId = default(string), string applicationId = default(string), string displayTitle = default(string), string displayText = default(string), string readoutOverride = default(string), string foregroundImageItemId = default(string), string backgroundImageItemId = default(string), string audioItemId = default(string), string videoItemId = default(string), string deviceTargetId = default(string), string customMarkup = default(string), string createdFromId = default(string), ResponseTemplateTypeModel responseTemplateType = default(ResponseTemplateTypeModel), MediaItemModel foregroundImageItem = default(MediaItemModel), MediaItemModel backgroundImageItem = default(MediaItemModel), MediaItemModel audioItem = default(MediaItemModel), MediaItemModel videoItem = default(MediaItemModel), BasicDeviceTargetModel deviceTarget = default(BasicDeviceTargetModel), string appliedApplicationTemplateFormId = default(string))
        {
            this.Id = id;
            this.ResponseTemplateTypeId = responseTemplateTypeId;
            this.ApplicationId = applicationId;
            this.DisplayTitle = displayTitle;
            this.DisplayText = displayText;
            this.ReadoutOverride = readoutOverride;
            this.ForegroundImageItemId = foregroundImageItemId;
            this.BackgroundImageItemId = backgroundImageItemId;
            this.AudioItemId = audioItemId;
            this.VideoItemId = videoItemId;
            this.DeviceTargetId = deviceTargetId;
            this.CustomMarkup = customMarkup;
            this.CreatedFromId = createdFromId;
            this.ResponseTemplateType = responseTemplateType;
            this.ForegroundImageItem = foregroundImageItem;
            this.BackgroundImageItem = backgroundImageItem;
            this.AudioItem = audioItem;
            this.VideoItem = videoItem;
            this.DeviceTarget = deviceTarget;
            this.AppliedApplicationTemplateFormId = appliedApplicationTemplateFormId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTemplateTypeId
        /// </summary>
        [DataMember(Name="responseTemplateTypeId", EmitDefaultValue=false)]
        public string ResponseTemplateTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitle
        /// </summary>
        [DataMember(Name="displayTitle", EmitDefaultValue=false)]
        public string DisplayTitle { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets ReadoutOverride
        /// </summary>
        [DataMember(Name="readoutOverride", EmitDefaultValue=false)]
        public string ReadoutOverride { get; set; }

        /// <summary>
        /// Gets or Sets ForegroundImageItemId
        /// </summary>
        [DataMember(Name="foregroundImageItemId", EmitDefaultValue=false)]
        public string ForegroundImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImageItemId
        /// </summary>
        [DataMember(Name="backgroundImageItemId", EmitDefaultValue=false)]
        public string BackgroundImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets AudioItemId
        /// </summary>
        [DataMember(Name="audioItemId", EmitDefaultValue=false)]
        public string AudioItemId { get; set; }

        /// <summary>
        /// Gets or Sets VideoItemId
        /// </summary>
        [DataMember(Name="videoItemId", EmitDefaultValue=false)]
        public string VideoItemId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceTargetId
        /// </summary>
        [DataMember(Name="deviceTargetId", EmitDefaultValue=false)]
        public string DeviceTargetId { get; set; }

        /// <summary>
        /// Gets or Sets CustomMarkup
        /// </summary>
        [DataMember(Name="customMarkup", EmitDefaultValue=false)]
        public string CustomMarkup { get; set; }

        /// <summary>
        /// Gets or Sets CreatedFromId
        /// </summary>
        [DataMember(Name="createdFromId", EmitDefaultValue=false)]
        public string CreatedFromId { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTemplateType
        /// </summary>
        [DataMember(Name="responseTemplateType", EmitDefaultValue=false)]
        public ResponseTemplateTypeModel ResponseTemplateType { get; set; }

        /// <summary>
        /// Gets or Sets ForegroundImageItem
        /// </summary>
        [DataMember(Name="foregroundImageItem", EmitDefaultValue=false)]
        public MediaItemModel ForegroundImageItem { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImageItem
        /// </summary>
        [DataMember(Name="backgroundImageItem", EmitDefaultValue=false)]
        public MediaItemModel BackgroundImageItem { get; set; }

        /// <summary>
        /// Gets or Sets AudioItem
        /// </summary>
        [DataMember(Name="audioItem", EmitDefaultValue=false)]
        public MediaItemModel AudioItem { get; set; }

        /// <summary>
        /// Gets or Sets VideoItem
        /// </summary>
        [DataMember(Name="videoItem", EmitDefaultValue=false)]
        public MediaItemModel VideoItem { get; set; }

        /// <summary>
        /// Gets or Sets DeviceTarget
        /// </summary>
        [DataMember(Name="deviceTarget", EmitDefaultValue=false)]
        public BasicDeviceTargetModel DeviceTarget { get; set; }

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
            sb.Append("class MediaResponseModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResponseTemplateTypeId: ").Append(ResponseTemplateTypeId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  DisplayTitle: ").Append(DisplayTitle).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  ReadoutOverride: ").Append(ReadoutOverride).Append("\n");
            sb.Append("  ForegroundImageItemId: ").Append(ForegroundImageItemId).Append("\n");
            sb.Append("  BackgroundImageItemId: ").Append(BackgroundImageItemId).Append("\n");
            sb.Append("  AudioItemId: ").Append(AudioItemId).Append("\n");
            sb.Append("  VideoItemId: ").Append(VideoItemId).Append("\n");
            sb.Append("  DeviceTargetId: ").Append(DeviceTargetId).Append("\n");
            sb.Append("  CustomMarkup: ").Append(CustomMarkup).Append("\n");
            sb.Append("  CreatedFromId: ").Append(CreatedFromId).Append("\n");
            sb.Append("  ResponseTemplateType: ").Append(ResponseTemplateType).Append("\n");
            sb.Append("  ForegroundImageItem: ").Append(ForegroundImageItem).Append("\n");
            sb.Append("  BackgroundImageItem: ").Append(BackgroundImageItem).Append("\n");
            sb.Append("  AudioItem: ").Append(AudioItem).Append("\n");
            sb.Append("  VideoItem: ").Append(VideoItem).Append("\n");
            sb.Append("  DeviceTarget: ").Append(DeviceTarget).Append("\n");
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
            return this.Equals(input as MediaResponseModel);
        }

        /// <summary>
        /// Returns true if MediaResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaResponseModel input)
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
                    this.ResponseTemplateTypeId == input.ResponseTemplateTypeId ||
                    (this.ResponseTemplateTypeId != null &&
                    this.ResponseTemplateTypeId.Equals(input.ResponseTemplateTypeId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.DisplayTitle == input.DisplayTitle ||
                    (this.DisplayTitle != null &&
                    this.DisplayTitle.Equals(input.DisplayTitle))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.ReadoutOverride == input.ReadoutOverride ||
                    (this.ReadoutOverride != null &&
                    this.ReadoutOverride.Equals(input.ReadoutOverride))
                ) && 
                (
                    this.ForegroundImageItemId == input.ForegroundImageItemId ||
                    (this.ForegroundImageItemId != null &&
                    this.ForegroundImageItemId.Equals(input.ForegroundImageItemId))
                ) && 
                (
                    this.BackgroundImageItemId == input.BackgroundImageItemId ||
                    (this.BackgroundImageItemId != null &&
                    this.BackgroundImageItemId.Equals(input.BackgroundImageItemId))
                ) && 
                (
                    this.AudioItemId == input.AudioItemId ||
                    (this.AudioItemId != null &&
                    this.AudioItemId.Equals(input.AudioItemId))
                ) && 
                (
                    this.VideoItemId == input.VideoItemId ||
                    (this.VideoItemId != null &&
                    this.VideoItemId.Equals(input.VideoItemId))
                ) && 
                (
                    this.DeviceTargetId == input.DeviceTargetId ||
                    (this.DeviceTargetId != null &&
                    this.DeviceTargetId.Equals(input.DeviceTargetId))
                ) && 
                (
                    this.CustomMarkup == input.CustomMarkup ||
                    (this.CustomMarkup != null &&
                    this.CustomMarkup.Equals(input.CustomMarkup))
                ) && 
                (
                    this.CreatedFromId == input.CreatedFromId ||
                    (this.CreatedFromId != null &&
                    this.CreatedFromId.Equals(input.CreatedFromId))
                ) && 
                (
                    this.ResponseTemplateType == input.ResponseTemplateType ||
                    (this.ResponseTemplateType != null &&
                    this.ResponseTemplateType.Equals(input.ResponseTemplateType))
                ) && 
                (
                    this.ForegroundImageItem == input.ForegroundImageItem ||
                    (this.ForegroundImageItem != null &&
                    this.ForegroundImageItem.Equals(input.ForegroundImageItem))
                ) && 
                (
                    this.BackgroundImageItem == input.BackgroundImageItem ||
                    (this.BackgroundImageItem != null &&
                    this.BackgroundImageItem.Equals(input.BackgroundImageItem))
                ) && 
                (
                    this.AudioItem == input.AudioItem ||
                    (this.AudioItem != null &&
                    this.AudioItem.Equals(input.AudioItem))
                ) && 
                (
                    this.VideoItem == input.VideoItem ||
                    (this.VideoItem != null &&
                    this.VideoItem.Equals(input.VideoItem))
                ) && 
                (
                    this.DeviceTarget == input.DeviceTarget ||
                    (this.DeviceTarget != null &&
                    this.DeviceTarget.Equals(input.DeviceTarget))
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
                if (this.ResponseTemplateTypeId != null)
                    hashCode = hashCode * 59 + this.ResponseTemplateTypeId.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.DisplayTitle != null)
                    hashCode = hashCode * 59 + this.DisplayTitle.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.ReadoutOverride != null)
                    hashCode = hashCode * 59 + this.ReadoutOverride.GetHashCode();
                if (this.ForegroundImageItemId != null)
                    hashCode = hashCode * 59 + this.ForegroundImageItemId.GetHashCode();
                if (this.BackgroundImageItemId != null)
                    hashCode = hashCode * 59 + this.BackgroundImageItemId.GetHashCode();
                if (this.AudioItemId != null)
                    hashCode = hashCode * 59 + this.AudioItemId.GetHashCode();
                if (this.VideoItemId != null)
                    hashCode = hashCode * 59 + this.VideoItemId.GetHashCode();
                if (this.DeviceTargetId != null)
                    hashCode = hashCode * 59 + this.DeviceTargetId.GetHashCode();
                if (this.CustomMarkup != null)
                    hashCode = hashCode * 59 + this.CustomMarkup.GetHashCode();
                if (this.CreatedFromId != null)
                    hashCode = hashCode * 59 + this.CreatedFromId.GetHashCode();
                if (this.ResponseTemplateType != null)
                    hashCode = hashCode * 59 + this.ResponseTemplateType.GetHashCode();
                if (this.ForegroundImageItem != null)
                    hashCode = hashCode * 59 + this.ForegroundImageItem.GetHashCode();
                if (this.BackgroundImageItem != null)
                    hashCode = hashCode * 59 + this.BackgroundImageItem.GetHashCode();
                if (this.AudioItem != null)
                    hashCode = hashCode * 59 + this.AudioItem.GetHashCode();
                if (this.VideoItem != null)
                    hashCode = hashCode * 59 + this.VideoItem.GetHashCode();
                if (this.DeviceTarget != null)
                    hashCode = hashCode * 59 + this.DeviceTarget.GetHashCode();
                if (this.AppliedApplicationTemplateFormId != null)
                    hashCode = hashCode * 59 + this.AppliedApplicationTemplateFormId.GetHashCode();
                return hashCode;
            }
        }

    }
}
