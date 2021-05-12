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
    /// BasicDeviceTargetModel
    /// </summary>
    [DataContract]
        public partial class BasicDeviceTargetModel :  IEquatable<BasicDeviceTargetModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicDeviceTargetModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="assistant">assistant.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="supportsForegroundImages">supportsForegroundImages.</param>
        /// <param name="supportsRichAudio">supportsRichAudio.</param>
        /// <param name="supportsSsml">supportsSsml.</param>
        /// <param name="supportsVideo">supportsVideo.</param>
        /// <param name="supportsBackgroundImages">supportsBackgroundImages.</param>
        /// <param name="supportsDisplayTitle">supportsDisplayTitle.</param>
        /// <param name="supportsDisplayText">supportsDisplayText.</param>
        /// <param name="iconUrl">iconUrl.</param>
        public BasicDeviceTargetModel(string id = default(string), string assistant = default(string), string displayName = default(string), bool? supportsForegroundImages = default(bool?), bool? supportsRichAudio = default(bool?), bool? supportsSsml = default(bool?), bool? supportsVideo = default(bool?), bool? supportsBackgroundImages = default(bool?), bool? supportsDisplayTitle = default(bool?), bool? supportsDisplayText = default(bool?), string iconUrl = default(string))
        {
            this.Id = id;
            this.Assistant = assistant;
            this.DisplayName = displayName;
            this.SupportsForegroundImages = supportsForegroundImages;
            this.SupportsRichAudio = supportsRichAudio;
            this.SupportsSsml = supportsSsml;
            this.SupportsVideo = supportsVideo;
            this.SupportsBackgroundImages = supportsBackgroundImages;
            this.SupportsDisplayTitle = supportsDisplayTitle;
            this.SupportsDisplayText = supportsDisplayText;
            this.IconUrl = iconUrl;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Assistant
        /// </summary>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public string Assistant { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SupportsForegroundImages
        /// </summary>
        [DataMember(Name="supportsForegroundImages", EmitDefaultValue=false)]
        public bool? SupportsForegroundImages { get; set; }

        /// <summary>
        /// Gets or Sets SupportsRichAudio
        /// </summary>
        [DataMember(Name="supportsRichAudio", EmitDefaultValue=false)]
        public bool? SupportsRichAudio { get; set; }

        /// <summary>
        /// Gets or Sets SupportsSsml
        /// </summary>
        [DataMember(Name="supportsSsml", EmitDefaultValue=false)]
        public bool? SupportsSsml { get; set; }

        /// <summary>
        /// Gets or Sets SupportsVideo
        /// </summary>
        [DataMember(Name="supportsVideo", EmitDefaultValue=false)]
        public bool? SupportsVideo { get; set; }

        /// <summary>
        /// Gets or Sets SupportsBackgroundImages
        /// </summary>
        [DataMember(Name="supportsBackgroundImages", EmitDefaultValue=false)]
        public bool? SupportsBackgroundImages { get; set; }

        /// <summary>
        /// Gets or Sets SupportsDisplayTitle
        /// </summary>
        [DataMember(Name="supportsDisplayTitle", EmitDefaultValue=false)]
        public bool? SupportsDisplayTitle { get; set; }

        /// <summary>
        /// Gets or Sets SupportsDisplayText
        /// </summary>
        [DataMember(Name="supportsDisplayText", EmitDefaultValue=false)]
        public bool? SupportsDisplayText { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicDeviceTargetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SupportsForegroundImages: ").Append(SupportsForegroundImages).Append("\n");
            sb.Append("  SupportsRichAudio: ").Append(SupportsRichAudio).Append("\n");
            sb.Append("  SupportsSsml: ").Append(SupportsSsml).Append("\n");
            sb.Append("  SupportsVideo: ").Append(SupportsVideo).Append("\n");
            sb.Append("  SupportsBackgroundImages: ").Append(SupportsBackgroundImages).Append("\n");
            sb.Append("  SupportsDisplayTitle: ").Append(SupportsDisplayTitle).Append("\n");
            sb.Append("  SupportsDisplayText: ").Append(SupportsDisplayText).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return this.Equals(input as BasicDeviceTargetModel);
        }

        /// <summary>
        /// Returns true if BasicDeviceTargetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicDeviceTargetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicDeviceTargetModel input)
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
                    this.Assistant == input.Assistant ||
                    (this.Assistant != null &&
                    this.Assistant.Equals(input.Assistant))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.SupportsForegroundImages == input.SupportsForegroundImages ||
                    (this.SupportsForegroundImages != null &&
                    this.SupportsForegroundImages.Equals(input.SupportsForegroundImages))
                ) && 
                (
                    this.SupportsRichAudio == input.SupportsRichAudio ||
                    (this.SupportsRichAudio != null &&
                    this.SupportsRichAudio.Equals(input.SupportsRichAudio))
                ) && 
                (
                    this.SupportsSsml == input.SupportsSsml ||
                    (this.SupportsSsml != null &&
                    this.SupportsSsml.Equals(input.SupportsSsml))
                ) && 
                (
                    this.SupportsVideo == input.SupportsVideo ||
                    (this.SupportsVideo != null &&
                    this.SupportsVideo.Equals(input.SupportsVideo))
                ) && 
                (
                    this.SupportsBackgroundImages == input.SupportsBackgroundImages ||
                    (this.SupportsBackgroundImages != null &&
                    this.SupportsBackgroundImages.Equals(input.SupportsBackgroundImages))
                ) && 
                (
                    this.SupportsDisplayTitle == input.SupportsDisplayTitle ||
                    (this.SupportsDisplayTitle != null &&
                    this.SupportsDisplayTitle.Equals(input.SupportsDisplayTitle))
                ) && 
                (
                    this.SupportsDisplayText == input.SupportsDisplayText ||
                    (this.SupportsDisplayText != null &&
                    this.SupportsDisplayText.Equals(input.SupportsDisplayText))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
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
                if (this.Assistant != null)
                    hashCode = hashCode * 59 + this.Assistant.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SupportsForegroundImages != null)
                    hashCode = hashCode * 59 + this.SupportsForegroundImages.GetHashCode();
                if (this.SupportsRichAudio != null)
                    hashCode = hashCode * 59 + this.SupportsRichAudio.GetHashCode();
                if (this.SupportsSsml != null)
                    hashCode = hashCode * 59 + this.SupportsSsml.GetHashCode();
                if (this.SupportsVideo != null)
                    hashCode = hashCode * 59 + this.SupportsVideo.GetHashCode();
                if (this.SupportsBackgroundImages != null)
                    hashCode = hashCode * 59 + this.SupportsBackgroundImages.GetHashCode();
                if (this.SupportsDisplayTitle != null)
                    hashCode = hashCode * 59 + this.SupportsDisplayTitle.GetHashCode();
                if (this.SupportsDisplayText != null)
                    hashCode = hashCode * 59 + this.SupportsDisplayText.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                return hashCode;
            }
        }

    }
}
