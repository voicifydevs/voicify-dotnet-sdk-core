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
    /// NewApplicationMemberRequest
    /// </summary>
    [DataContract]
    public partial class NewApplicationMemberRequest :  IEquatable<NewApplicationMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplicationMemberRequest" /> class.
        /// </summary>
        /// <param name="organizationMemberId">organizationMemberId.</param>
        /// <param name="roleId">roleId.</param>
        public NewApplicationMemberRequest(string organizationMemberId = default(string), string roleId = default(string))
        {
            this.OrganizationMemberId = organizationMemberId;
            this.RoleId = roleId;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationMemberId
        /// </summary>
        [DataMember(Name="organizationMemberId", EmitDefaultValue=false)]
        public string OrganizationMemberId { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewApplicationMemberRequest {\n");
            sb.Append("  OrganizationMemberId: ").Append(OrganizationMemberId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
            return this.Equals(input as NewApplicationMemberRequest);
        }

        /// <summary>
        /// Returns true if NewApplicationMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NewApplicationMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewApplicationMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationMemberId == input.OrganizationMemberId ||
                    (this.OrganizationMemberId != null &&
                    this.OrganizationMemberId.Equals(input.OrganizationMemberId))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
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
                if (this.OrganizationMemberId != null)
                    hashCode = hashCode * 59 + this.OrganizationMemberId.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
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
