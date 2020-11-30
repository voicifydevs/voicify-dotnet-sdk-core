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
    /// LatestMessageResponseModel
    /// </summary>
    [DataContract]
    public partial class LatestMessageResponseModel :  IEquatable<LatestMessageResponseModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestMessageResponseModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="content">content.</param>
        /// <param name="latestMessageId">latestMessageId.</param>
        /// <param name="smallImage">smallImage.</param>
        /// <param name="largeImage">largeImage.</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="audio">audio.</param>
        /// <param name="video">video.</param>
        /// <param name="repromptId">repromptId.</param>
        /// <param name="reprompt">reprompt.</param>
        /// <param name="mediaResponseContainer">mediaResponseContainer.</param>
        /// <param name="followUp">followUp.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="followUpId">followUpId.</param>
        public LatestMessageResponseModel(string id = default(string), string content = default(string), string latestMessageId = default(string), MediaItemModel smallImage = default(MediaItemModel), MediaItemModel largeImage = default(MediaItemModel), MediaItemModel backgroundImage = default(MediaItemModel), MediaItemModel audio = default(MediaItemModel), MediaItemModel video = default(MediaItemModel), string repromptId = default(string), RepromptModel reprompt = default(RepromptModel), MediaResponseContainerModel mediaResponseContainer = default(MediaResponseContainerModel), FollowUpModel followUp = default(FollowUpModel), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), string followUpId = default(string))
        {
            this.Id = id;
            this.Content = content;
            this.LatestMessageId = latestMessageId;
            this.SmallImage = smallImage;
            this.LargeImage = largeImage;
            this.BackgroundImage = backgroundImage;
            this.Audio = audio;
            this.Video = video;
            this.RepromptId = repromptId;
            this.Reprompt = reprompt;
            this.MediaResponseContainer = mediaResponseContainer;
            this.FollowUp = followUp;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.FollowUpId = followUpId;
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
        /// Gets or Sets LatestMessageId
        /// </summary>
        [DataMember(Name="latestMessageId", EmitDefaultValue=false)]
        public string LatestMessageId { get; set; }

        /// <summary>
        /// Gets or Sets SmallImage
        /// </summary>
        [DataMember(Name="smallImage", EmitDefaultValue=false)]
        public MediaItemModel SmallImage { get; set; }

        /// <summary>
        /// Gets or Sets LargeImage
        /// </summary>
        [DataMember(Name="largeImage", EmitDefaultValue=false)]
        public MediaItemModel LargeImage { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public MediaItemModel BackgroundImage { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public MediaItemModel Audio { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public MediaItemModel Video { get; set; }

        /// <summary>
        /// Gets or Sets RepromptId
        /// </summary>
        [DataMember(Name="repromptId", EmitDefaultValue=false)]
        public string RepromptId { get; set; }

        /// <summary>
        /// Gets or Sets Reprompt
        /// </summary>
        [DataMember(Name="reprompt", EmitDefaultValue=false)]
        public RepromptModel Reprompt { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainer
        /// </summary>
        [DataMember(Name="mediaResponseContainer", EmitDefaultValue=false)]
        public MediaResponseContainerModel MediaResponseContainer { get; set; }

        /// <summary>
        /// Gets or Sets FollowUp
        /// </summary>
        [DataMember(Name="followUp", EmitDefaultValue=false)]
        public FollowUpModel FollowUp { get; set; }

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
        /// Gets or Sets MediaResponseContainerId
        /// </summary>
        [DataMember(Name="mediaResponseContainerId", EmitDefaultValue=false)]
        public string MediaResponseContainerId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTextOverride
        /// </summary>
        [DataMember(Name="displayTextOverride", EmitDefaultValue=false)]
        public string DisplayTextOverride { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitleOverride
        /// </summary>
        [DataMember(Name="displayTitleOverride", EmitDefaultValue=false)]
        public string DisplayTitleOverride { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpId
        /// </summary>
        [DataMember(Name="followUpId", EmitDefaultValue=false)]
        public string FollowUpId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatestMessageResponseModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  LatestMessageId: ").Append(LatestMessageId).Append("\n");
            sb.Append("  SmallImage: ").Append(SmallImage).Append("\n");
            sb.Append("  LargeImage: ").Append(LargeImage).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  RepromptId: ").Append(RepromptId).Append("\n");
            sb.Append("  Reprompt: ").Append(Reprompt).Append("\n");
            sb.Append("  MediaResponseContainer: ").Append(MediaResponseContainer).Append("\n");
            sb.Append("  FollowUp: ").Append(FollowUp).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  FollowUpId: ").Append(FollowUpId).Append("\n");
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
            return this.Equals(input as LatestMessageResponseModel);
        }

        /// <summary>
        /// Returns true if LatestMessageResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestMessageResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestMessageResponseModel input)
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
                    this.LatestMessageId == input.LatestMessageId ||
                    (this.LatestMessageId != null &&
                    this.LatestMessageId.Equals(input.LatestMessageId))
                ) && 
                (
                    this.SmallImage == input.SmallImage ||
                    (this.SmallImage != null &&
                    this.SmallImage.Equals(input.SmallImage))
                ) && 
                (
                    this.LargeImage == input.LargeImage ||
                    (this.LargeImage != null &&
                    this.LargeImage.Equals(input.LargeImage))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.RepromptId == input.RepromptId ||
                    (this.RepromptId != null &&
                    this.RepromptId.Equals(input.RepromptId))
                ) && 
                (
                    this.Reprompt == input.Reprompt ||
                    (this.Reprompt != null &&
                    this.Reprompt.Equals(input.Reprompt))
                ) && 
                (
                    this.MediaResponseContainer == input.MediaResponseContainer ||
                    (this.MediaResponseContainer != null &&
                    this.MediaResponseContainer.Equals(input.MediaResponseContainer))
                ) && 
                (
                    this.FollowUp == input.FollowUp ||
                    (this.FollowUp != null &&
                    this.FollowUp.Equals(input.FollowUp))
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
                    this.MediaResponseContainerId == input.MediaResponseContainerId ||
                    (this.MediaResponseContainerId != null &&
                    this.MediaResponseContainerId.Equals(input.MediaResponseContainerId))
                ) && 
                (
                    this.DisplayTextOverride == input.DisplayTextOverride ||
                    (this.DisplayTextOverride != null &&
                    this.DisplayTextOverride.Equals(input.DisplayTextOverride))
                ) && 
                (
                    this.DisplayTitleOverride == input.DisplayTitleOverride ||
                    (this.DisplayTitleOverride != null &&
                    this.DisplayTitleOverride.Equals(input.DisplayTitleOverride))
                ) && 
                (
                    this.FollowUpId == input.FollowUpId ||
                    (this.FollowUpId != null &&
                    this.FollowUpId.Equals(input.FollowUpId))
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
                if (this.LatestMessageId != null)
                    hashCode = hashCode * 59 + this.LatestMessageId.GetHashCode();
                if (this.SmallImage != null)
                    hashCode = hashCode * 59 + this.SmallImage.GetHashCode();
                if (this.LargeImage != null)
                    hashCode = hashCode * 59 + this.LargeImage.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.RepromptId != null)
                    hashCode = hashCode * 59 + this.RepromptId.GetHashCode();
                if (this.Reprompt != null)
                    hashCode = hashCode * 59 + this.Reprompt.GetHashCode();
                if (this.MediaResponseContainer != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainer.GetHashCode();
                if (this.FollowUp != null)
                    hashCode = hashCode * 59 + this.FollowUp.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.MediaResponseContainerId != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainerId.GetHashCode();
                if (this.DisplayTextOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTextOverride.GetHashCode();
                if (this.DisplayTitleOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTitleOverride.GetHashCode();
                if (this.FollowUpId != null)
                    hashCode = hashCode * 59 + this.FollowUpId.GetHashCode();
                return hashCode;
            }
        }

    }

}
