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
    /// CreateNewPasswordRequest
    /// </summary>
    [DataContract]
    public partial class CreateNewPasswordRequest :  IEquatable<CreateNewPasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewPasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateNewPasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewPasswordRequest" /> class.
        /// </summary>
        /// <param name="resetCode">resetCode (required).</param>
        /// <param name="newPassword">newPassword (required).</param>
        /// <param name="confirmNewPassword">confirmNewPassword (required).</param>
        public CreateNewPasswordRequest(string resetCode = default(string), string newPassword = default(string), string confirmNewPassword = default(string))
        {
            // to ensure "resetCode" is required (not null)
            if (resetCode == null)
            {
                throw new InvalidDataException("resetCode is a required property for CreateNewPasswordRequest and cannot be null");
            }
            else
            {
                this.ResetCode = resetCode;
            }
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new InvalidDataException("newPassword is a required property for CreateNewPasswordRequest and cannot be null");
            }
            else
            {
                this.NewPassword = newPassword;
            }
            // to ensure "confirmNewPassword" is required (not null)
            if (confirmNewPassword == null)
            {
                throw new InvalidDataException("confirmNewPassword is a required property for CreateNewPasswordRequest and cannot be null");
            }
            else
            {
                this.ConfirmNewPassword = confirmNewPassword;
            }
        }
        
        /// <summary>
        /// Gets or Sets ResetCode
        /// </summary>
        [DataMember(Name="resetCode", EmitDefaultValue=false)]
        public string ResetCode { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmNewPassword
        /// </summary>
        [DataMember(Name="confirmNewPassword", EmitDefaultValue=false)]
        public string ConfirmNewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNewPasswordRequest {\n");
            sb.Append("  ResetCode: ").Append(ResetCode).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  ConfirmNewPassword: ").Append(ConfirmNewPassword).Append("\n");
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
            return this.Equals(input as CreateNewPasswordRequest);
        }

        /// <summary>
        /// Returns true if CreateNewPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewPasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResetCode == input.ResetCode ||
                    (this.ResetCode != null &&
                    this.ResetCode.Equals(input.ResetCode))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.ConfirmNewPassword == input.ConfirmNewPassword ||
                    (this.ConfirmNewPassword != null &&
                    this.ConfirmNewPassword.Equals(input.ConfirmNewPassword))
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
                if (this.ResetCode != null)
                    hashCode = hashCode * 59 + this.ResetCode.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.ConfirmNewPassword != null)
                    hashCode = hashCode * 59 + this.ConfirmNewPassword.GetHashCode();
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
            // NewPassword (string) minLength
            if(this.NewPassword != null && this.NewPassword.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewPassword, length must be greater than 6.", new [] { "NewPassword" });
            }

            // ConfirmNewPassword (string) minLength
            if(this.ConfirmNewPassword != null && this.ConfirmNewPassword.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConfirmNewPassword, length must be greater than 6.", new [] { "ConfirmNewPassword" });
            }

            yield break;
        }
    }

}
