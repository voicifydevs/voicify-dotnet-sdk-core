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
    /// BulkUpdateSimpleChoiceStubRequest
    /// </summary>
    [DataContract]
        public partial class BulkUpdateSimpleChoiceStubRequest :  IEquatable<BulkUpdateSimpleChoiceStubRequest>
    {
        /// <summary>
        /// Gets or Sets ChoiceType
        /// </summary>
        [DataMember(Name="choiceType", EmitDefaultValue=false)]
        public SimpleChoiceType? ChoiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSimpleChoiceStubRequest" /> class.
        /// </summary>
        /// <param name="choiceType">choiceType.</param>
        /// <param name="title">title.</param>
        /// <param name="responses">responses.</param>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="imageItemId">imageItemId.</param>
        /// <param name="backgroundImageItemId">backgroundImageItemId.</param>
        /// <param name="audioItemId">audioItemId.</param>
        /// <param name="videoItemId">videoItemId.</param>
        /// <param name="followUpId">followUpId.</param>
        /// <param name="repromptId">repromptId.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="languageIds">languageIds.</param>
        public BulkUpdateSimpleChoiceStubRequest(SimpleChoiceType? choiceType = default(SimpleChoiceType?), string title = default(string), List<UpdateSimpleChoiceResponseRequest> responses = default(List<UpdateSimpleChoiceResponseRequest>), string applicationId = default(string), string imageItemId = default(string), string backgroundImageItemId = default(string), string audioItemId = default(string), string videoItemId = default(string), string followUpId = default(string), string repromptId = default(string), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), List<string> languageIds = default(List<string>))
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for BulkUpdateSimpleChoiceStubRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            this.ChoiceType = choiceType;
            this.Title = title;
            this.Responses = responses;
            this.ImageItemId = imageItemId;
            this.BackgroundImageItemId = backgroundImageItemId;
            this.AudioItemId = audioItemId;
            this.VideoItemId = videoItemId;
            this.FollowUpId = followUpId;
            this.RepromptId = repromptId;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.LanguageIds = languageIds;
        }
        

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<UpdateSimpleChoiceResponseRequest> Responses { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ImageItemId
        /// </summary>
        [DataMember(Name="imageItemId", EmitDefaultValue=false)]
        public string ImageItemId { get; set; }

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
        /// Gets or Sets FollowUpId
        /// </summary>
        [DataMember(Name="followUpId", EmitDefaultValue=false)]
        public string FollowUpId { get; set; }

        /// <summary>
        /// Gets or Sets RepromptId
        /// </summary>
        [DataMember(Name="repromptId", EmitDefaultValue=false)]
        public string RepromptId { get; set; }

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
        /// Gets or Sets LanguageIds
        /// </summary>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateSimpleChoiceStubRequest {\n");
            sb.Append("  ChoiceType: ").Append(ChoiceType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ImageItemId: ").Append(ImageItemId).Append("\n");
            sb.Append("  BackgroundImageItemId: ").Append(BackgroundImageItemId).Append("\n");
            sb.Append("  AudioItemId: ").Append(AudioItemId).Append("\n");
            sb.Append("  VideoItemId: ").Append(VideoItemId).Append("\n");
            sb.Append("  FollowUpId: ").Append(FollowUpId).Append("\n");
            sb.Append("  RepromptId: ").Append(RepromptId).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
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
            return this.Equals(input as BulkUpdateSimpleChoiceStubRequest);
        }

        /// <summary>
        /// Returns true if BulkUpdateSimpleChoiceStubRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkUpdateSimpleChoiceStubRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateSimpleChoiceStubRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChoiceType == input.ChoiceType ||
                    (this.ChoiceType != null &&
                    this.ChoiceType.Equals(input.ChoiceType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ImageItemId == input.ImageItemId ||
                    (this.ImageItemId != null &&
                    this.ImageItemId.Equals(input.ImageItemId))
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
                    this.FollowUpId == input.FollowUpId ||
                    (this.FollowUpId != null &&
                    this.FollowUpId.Equals(input.FollowUpId))
                ) && 
                (
                    this.RepromptId == input.RepromptId ||
                    (this.RepromptId != null &&
                    this.RepromptId.Equals(input.RepromptId))
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
                    this.LanguageIds == input.LanguageIds ||
                    this.LanguageIds != null &&
                    input.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(input.LanguageIds)
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
                if (this.ChoiceType != null)
                    hashCode = hashCode * 59 + this.ChoiceType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ImageItemId != null)
                    hashCode = hashCode * 59 + this.ImageItemId.GetHashCode();
                if (this.BackgroundImageItemId != null)
                    hashCode = hashCode * 59 + this.BackgroundImageItemId.GetHashCode();
                if (this.AudioItemId != null)
                    hashCode = hashCode * 59 + this.AudioItemId.GetHashCode();
                if (this.VideoItemId != null)
                    hashCode = hashCode * 59 + this.VideoItemId.GetHashCode();
                if (this.FollowUpId != null)
                    hashCode = hashCode * 59 + this.FollowUpId.GetHashCode();
                if (this.RepromptId != null)
                    hashCode = hashCode * 59 + this.RepromptId.GetHashCode();
                if (this.MediaResponseContainerId != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainerId.GetHashCode();
                if (this.DisplayTextOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTextOverride.GetHashCode();
                if (this.DisplayTitleOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTitleOverride.GetHashCode();
                if (this.LanguageIds != null)
                    hashCode = hashCode * 59 + this.LanguageIds.GetHashCode();
                return hashCode;
            }
        }

    }
}
