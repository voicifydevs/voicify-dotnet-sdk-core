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
    /// BulkUpdateEventRequest
    /// </summary>
    [DataContract]
        public partial class BulkUpdateEventRequest :  IEquatable<BulkUpdateEventRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateEventRequest" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="description">description.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="categoryNames">categoryNames.</param>
        /// <param name="ownerName">ownerName.</param>
        /// <param name="address">address.</param>
        /// <param name="status">status.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="imageItemId">imageItemId.</param>
        /// <param name="backgroundImageItemId">backgroundImageItemId.</param>
        /// <param name="audioItemId">audioItemId.</param>
        /// <param name="videoItemId">videoItemId.</param>
        /// <param name="followUpId">followUpId.</param>
        /// <param name="repromptId">repromptId.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="languageIds">languageIds.</param>
        /// <param name="eventName">eventName (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="responses">responses (required).</param>
        public BulkUpdateEventRequest(string title = default(string), string description = default(string), string locationName = default(string), List<string> categoryNames = default(List<string>), string ownerName = default(string), string address = default(string), string status = default(string), DateTime? endDate = default(DateTime?), string imageItemId = default(string), string backgroundImageItemId = default(string), string audioItemId = default(string), string videoItemId = default(string), string followUpId = default(string), string repromptId = default(string), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), bool? requiresParent = default(bool?), List<string> languageIds = default(List<string>), string eventName = default(string), DateTime? startDate = default(DateTime?), List<UpdateEventResponseRequest> responses = default(List<UpdateEventResponseRequest>))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for BulkUpdateEventRequest and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "eventName" is required (not null)
            if (eventName == null)
            {
                throw new InvalidDataException("eventName is a required property for BulkUpdateEventRequest and cannot be null");
            }
            else
            {
                this.EventName = eventName;
            }
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for BulkUpdateEventRequest and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "responses" is required (not null)
            if (responses == null)
            {
                throw new InvalidDataException("responses is a required property for BulkUpdateEventRequest and cannot be null");
            }
            else
            {
                this.Responses = responses;
            }
            this.Description = description;
            this.LocationName = locationName;
            this.CategoryNames = categoryNames;
            this.OwnerName = ownerName;
            this.Address = address;
            this.Status = status;
            this.EndDate = endDate;
            this.ImageItemId = imageItemId;
            this.BackgroundImageItemId = backgroundImageItemId;
            this.AudioItemId = audioItemId;
            this.VideoItemId = videoItemId;
            this.FollowUpId = followUpId;
            this.RepromptId = repromptId;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.RequiresParent = requiresParent;
            this.LanguageIds = languageIds;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="locationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryNames
        /// </summary>
        [DataMember(Name="categoryNames", EmitDefaultValue=false)]
        public List<string> CategoryNames { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        [DataMember(Name="ownerName", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

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
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public List<UpdateEventResponseRequest> Responses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateEventRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  CategoryNames: ").Append(CategoryNames).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ImageItemId: ").Append(ImageItemId).Append("\n");
            sb.Append("  BackgroundImageItemId: ").Append(BackgroundImageItemId).Append("\n");
            sb.Append("  AudioItemId: ").Append(AudioItemId).Append("\n");
            sb.Append("  VideoItemId: ").Append(VideoItemId).Append("\n");
            sb.Append("  FollowUpId: ").Append(FollowUpId).Append("\n");
            sb.Append("  RepromptId: ").Append(RepromptId).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
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
            return this.Equals(input as BulkUpdateEventRequest);
        }

        /// <summary>
        /// Returns true if BulkUpdateEventRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkUpdateEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateEventRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.CategoryNames == input.CategoryNames ||
                    this.CategoryNames != null &&
                    input.CategoryNames != null &&
                    this.CategoryNames.SequenceEqual(input.CategoryNames)
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.LanguageIds == input.LanguageIds ||
                    this.LanguageIds != null &&
                    input.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(input.LanguageIds)
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.CategoryNames != null)
                    hashCode = hashCode * 59 + this.CategoryNames.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.LanguageIds != null)
                    hashCode = hashCode * 59 + this.LanguageIds.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                return hashCode;
            }
        }

    }
}
