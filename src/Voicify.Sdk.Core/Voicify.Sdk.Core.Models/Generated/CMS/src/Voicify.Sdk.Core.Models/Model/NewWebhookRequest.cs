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
    /// NewWebhookRequest
    /// </summary>
    [DataContract]
    public partial class NewWebhookRequest :  IEquatable<NewWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewWebhookRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewWebhookRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewWebhookRequest" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="webhookTypeId">webhookTypeId (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="accessToken">accessToken.</param>
        public NewWebhookRequest(string title = default(string), string description = default(string), string webhookTypeId = default(string), string url = default(string), string accessToken = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for NewWebhookRequest and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for NewWebhookRequest and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "webhookTypeId" is required (not null)
            if (webhookTypeId == null)
            {
                throw new InvalidDataException("webhookTypeId is a required property for NewWebhookRequest and cannot be null");
            }
            else
            {
                this.WebhookTypeId = webhookTypeId;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for NewWebhookRequest and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            this.AccessToken = accessToken;
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
        /// Gets or Sets WebhookTypeId
        /// </summary>
        [DataMember(Name="webhookTypeId", EmitDefaultValue=false)]
        public string WebhookTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewWebhookRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WebhookTypeId: ").Append(WebhookTypeId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
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
            return this.Equals(input as NewWebhookRequest);
        }

        /// <summary>
        /// Returns true if NewWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewWebhookRequest input)
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
                    this.WebhookTypeId == input.WebhookTypeId ||
                    (this.WebhookTypeId != null &&
                    this.WebhookTypeId.Equals(input.WebhookTypeId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
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
                if (this.WebhookTypeId != null)
                    hashCode = hashCode * 59 + this.WebhookTypeId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
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