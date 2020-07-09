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
    /// NewSimpleChoiceRequest
    /// </summary>
    [DataContract]
    public partial class NewSimpleChoiceRequest :  IEquatable<NewSimpleChoiceRequest>, IValidatableObject
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
        public ChoiceTypeEnum ChoiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSimpleChoiceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewSimpleChoiceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewSimpleChoiceRequest" /> class.
        /// </summary>
        /// <param name="responses">responses (required).</param>
        /// <param name="choiceType">choiceType (required).</param>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="applicationFeatureId">applicationFeatureId (required).</param>
        /// <param name="title">title (required).</param>
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
        public NewSimpleChoiceRequest(List<NewSimpleChoiceResponseRequest> responses = default(List<NewSimpleChoiceResponseRequest>), ChoiceTypeEnum choiceType = default(ChoiceTypeEnum), string applicationId = default(string), string applicationFeatureId = default(string), string title = default(string), string imageItemId = default(string), string backgroundImageItemId = default(string), string audioItemId = default(string), string videoItemId = default(string), string followUpId = default(string), string repromptId = default(string), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), List<string> languageIds = default(List<string>))
        {
            // to ensure "responses" is required (not null)
            if (responses == null)
            {
                throw new InvalidDataException("responses is a required property for NewSimpleChoiceRequest and cannot be null");
            }
            else
            {
                this.Responses = responses;
            }
            // to ensure "choiceType" is required (not null)
            if (choiceType == null)
            {
                throw new InvalidDataException("choiceType is a required property for NewSimpleChoiceRequest and cannot be null");
            }
            else
            {
                this.ChoiceType = choiceType;
            }
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for NewSimpleChoiceRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            // to ensure "applicationFeatureId" is required (not null)
            if (applicationFeatureId == null)
            {
                throw new InvalidDataException("applicationFeatureId is a required property for NewSimpleChoiceRequest and cannot be null");
            }
            else
            {
                this.ApplicationFeatureId = applicationFeatureId;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for NewSimpleChoiceRequest and cannot be null");
            }
            else
            {
                this.Title = title;
            }
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
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<NewSimpleChoiceResponseRequest> Responses { get; set; }


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
            sb.Append("class NewSimpleChoiceRequest {\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  ChoiceType: ").Append(ChoiceType).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationFeatureId: ").Append(ApplicationFeatureId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as NewSimpleChoiceRequest);
        }

        /// <summary>
        /// Returns true if NewSimpleChoiceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewSimpleChoiceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewSimpleChoiceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.ChoiceType == input.ChoiceType ||
                    (this.ChoiceType != null &&
                    this.ChoiceType.Equals(input.ChoiceType))
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
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.ChoiceType != null)
                    hashCode = hashCode * 59 + this.ChoiceType.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationFeatureId != null)
                    hashCode = hashCode * 59 + this.ApplicationFeatureId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
