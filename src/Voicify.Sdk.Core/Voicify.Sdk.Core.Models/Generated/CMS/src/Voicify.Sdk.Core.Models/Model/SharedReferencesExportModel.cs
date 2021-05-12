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
    /// SharedReferencesExportModel
    /// </summary>
    [DataContract]
        public partial class SharedReferencesExportModel :  IEquatable<SharedReferencesExportModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedReferencesExportModel" /> class.
        /// </summary>
        /// <param name="mediaItems">mediaItems.</param>
        /// <param name="mediaResponses">mediaResponses.</param>
        /// <param name="mediaResponseContainers">mediaResponseContainers.</param>
        /// <param name="followUps">followUps.</param>
        /// <param name="reprompts">reprompts.</param>
        /// <param name="webhookParameters">webhookParameters.</param>
        /// <param name="webhooks">webhooks.</param>
        /// <param name="webhookFolders">webhookFolders.</param>
        public SharedReferencesExportModel(List<MediaItemModel> mediaItems = default(List<MediaItemModel>), List<MediaResponseModel> mediaResponses = default(List<MediaResponseModel>), List<MediaResponseContainerModel> mediaResponseContainers = default(List<MediaResponseContainerModel>), List<FollowUpModel> followUps = default(List<FollowUpModel>), List<RepromptModel> reprompts = default(List<RepromptModel>), List<WebhookParameterModel> webhookParameters = default(List<WebhookParameterModel>), List<WebhookModel> webhooks = default(List<WebhookModel>), List<WebhookFolderExportModel> webhookFolders = default(List<WebhookFolderExportModel>))
        {
            this.MediaItems = mediaItems;
            this.MediaResponses = mediaResponses;
            this.MediaResponseContainers = mediaResponseContainers;
            this.FollowUps = followUps;
            this.Reprompts = reprompts;
            this.WebhookParameters = webhookParameters;
            this.Webhooks = webhooks;
            this.WebhookFolders = webhookFolders;
        }
        
        /// <summary>
        /// Gets or Sets MediaItems
        /// </summary>
        [DataMember(Name="mediaItems", EmitDefaultValue=false)]
        public List<MediaItemModel> MediaItems { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponses
        /// </summary>
        [DataMember(Name="mediaResponses", EmitDefaultValue=false)]
        public List<MediaResponseModel> MediaResponses { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainers
        /// </summary>
        [DataMember(Name="mediaResponseContainers", EmitDefaultValue=false)]
        public List<MediaResponseContainerModel> MediaResponseContainers { get; set; }

        /// <summary>
        /// Gets or Sets FollowUps
        /// </summary>
        [DataMember(Name="followUps", EmitDefaultValue=false)]
        public List<FollowUpModel> FollowUps { get; set; }

        /// <summary>
        /// Gets or Sets Reprompts
        /// </summary>
        [DataMember(Name="reprompts", EmitDefaultValue=false)]
        public List<RepromptModel> Reprompts { get; set; }

        /// <summary>
        /// Gets or Sets WebhookParameters
        /// </summary>
        [DataMember(Name="webhookParameters", EmitDefaultValue=false)]
        public List<WebhookParameterModel> WebhookParameters { get; set; }

        /// <summary>
        /// Gets or Sets Webhooks
        /// </summary>
        [DataMember(Name="webhooks", EmitDefaultValue=false)]
        public List<WebhookModel> Webhooks { get; set; }

        /// <summary>
        /// Gets or Sets WebhookFolders
        /// </summary>
        [DataMember(Name="webhookFolders", EmitDefaultValue=false)]
        public List<WebhookFolderExportModel> WebhookFolders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedReferencesExportModel {\n");
            sb.Append("  MediaItems: ").Append(MediaItems).Append("\n");
            sb.Append("  MediaResponses: ").Append(MediaResponses).Append("\n");
            sb.Append("  MediaResponseContainers: ").Append(MediaResponseContainers).Append("\n");
            sb.Append("  FollowUps: ").Append(FollowUps).Append("\n");
            sb.Append("  Reprompts: ").Append(Reprompts).Append("\n");
            sb.Append("  WebhookParameters: ").Append(WebhookParameters).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
            sb.Append("  WebhookFolders: ").Append(WebhookFolders).Append("\n");
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
            return this.Equals(input as SharedReferencesExportModel);
        }

        /// <summary>
        /// Returns true if SharedReferencesExportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedReferencesExportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedReferencesExportModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MediaItems == input.MediaItems ||
                    this.MediaItems != null &&
                    input.MediaItems != null &&
                    this.MediaItems.SequenceEqual(input.MediaItems)
                ) && 
                (
                    this.MediaResponses == input.MediaResponses ||
                    this.MediaResponses != null &&
                    input.MediaResponses != null &&
                    this.MediaResponses.SequenceEqual(input.MediaResponses)
                ) && 
                (
                    this.MediaResponseContainers == input.MediaResponseContainers ||
                    this.MediaResponseContainers != null &&
                    input.MediaResponseContainers != null &&
                    this.MediaResponseContainers.SequenceEqual(input.MediaResponseContainers)
                ) && 
                (
                    this.FollowUps == input.FollowUps ||
                    this.FollowUps != null &&
                    input.FollowUps != null &&
                    this.FollowUps.SequenceEqual(input.FollowUps)
                ) && 
                (
                    this.Reprompts == input.Reprompts ||
                    this.Reprompts != null &&
                    input.Reprompts != null &&
                    this.Reprompts.SequenceEqual(input.Reprompts)
                ) && 
                (
                    this.WebhookParameters == input.WebhookParameters ||
                    this.WebhookParameters != null &&
                    input.WebhookParameters != null &&
                    this.WebhookParameters.SequenceEqual(input.WebhookParameters)
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks != null &&
                    input.Webhooks != null &&
                    this.Webhooks.SequenceEqual(input.Webhooks)
                ) && 
                (
                    this.WebhookFolders == input.WebhookFolders ||
                    this.WebhookFolders != null &&
                    input.WebhookFolders != null &&
                    this.WebhookFolders.SequenceEqual(input.WebhookFolders)
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
                if (this.MediaItems != null)
                    hashCode = hashCode * 59 + this.MediaItems.GetHashCode();
                if (this.MediaResponses != null)
                    hashCode = hashCode * 59 + this.MediaResponses.GetHashCode();
                if (this.MediaResponseContainers != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainers.GetHashCode();
                if (this.FollowUps != null)
                    hashCode = hashCode * 59 + this.FollowUps.GetHashCode();
                if (this.Reprompts != null)
                    hashCode = hashCode * 59 + this.Reprompts.GetHashCode();
                if (this.WebhookParameters != null)
                    hashCode = hashCode * 59 + this.WebhookParameters.GetHashCode();
                if (this.Webhooks != null)
                    hashCode = hashCode * 59 + this.Webhooks.GetHashCode();
                if (this.WebhookFolders != null)
                    hashCode = hashCode * 59 + this.WebhookFolders.GetHashCode();
                return hashCode;
            }
        }

    }
}
