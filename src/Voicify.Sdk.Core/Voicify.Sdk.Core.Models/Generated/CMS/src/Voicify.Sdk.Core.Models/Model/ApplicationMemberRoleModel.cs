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
    /// ApplicationMemberRoleModel
    /// </summary>
    [DataContract]
        public partial class ApplicationMemberRoleModel :  IEquatable<ApplicationMemberRoleModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMemberRoleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="roleId">roleId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="isAdmin">isAdmin.</param>
        /// <param name="canEdit">canEdit.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="applicationImageUrl">applicationImageUrl.</param>
        public ApplicationMemberRoleModel(string id = default(string), string roleId = default(string), string userId = default(string), bool? isAdmin = default(bool?), bool? canEdit = default(bool?), string applicationId = default(string), string applicationName = default(string), string applicationImageUrl = default(string))
        {
            this.Id = id;
            this.RoleId = roleId;
            this.UserId = userId;
            this.IsAdmin = isAdmin;
            this.CanEdit = canEdit;
            this.ApplicationId = applicationId;
            this.ApplicationName = applicationName;
            this.ApplicationImageUrl = applicationImageUrl;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="isAdmin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets CanEdit
        /// </summary>
        [DataMember(Name="canEdit", EmitDefaultValue=false)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationImageUrl
        /// </summary>
        [DataMember(Name="applicationImageUrl", EmitDefaultValue=false)]
        public string ApplicationImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationMemberRoleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  CanEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationImageUrl: ").Append(ApplicationImageUrl).Append("\n");
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
            return this.Equals(input as ApplicationMemberRoleModel);
        }

        /// <summary>
        /// Returns true if ApplicationMemberRoleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationMemberRoleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationMemberRoleModel input)
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
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.CanEdit == input.CanEdit ||
                    (this.CanEdit != null &&
                    this.CanEdit.Equals(input.CanEdit))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.ApplicationImageUrl == input.ApplicationImageUrl ||
                    (this.ApplicationImageUrl != null &&
                    this.ApplicationImageUrl.Equals(input.ApplicationImageUrl))
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
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.CanEdit != null)
                    hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationImageUrl != null)
                    hashCode = hashCode * 59 + this.ApplicationImageUrl.GetHashCode();
                return hashCode;
            }
        }

    }
}
