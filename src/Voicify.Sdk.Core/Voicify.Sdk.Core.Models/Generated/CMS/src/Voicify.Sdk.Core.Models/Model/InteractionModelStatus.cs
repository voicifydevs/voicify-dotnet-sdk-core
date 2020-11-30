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
    /// InteractionModelStatus
    /// </summary>
    [DataContract]
    public partial class InteractionModelStatus :  IEquatable<InteractionModelStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionModelStatus" /> class.
        /// </summary>
        /// <param name="latestDeploymentResults">latestDeploymentResults.</param>
        /// <param name="queuedForDeploymentToPlatforms">queuedForDeploymentToPlatforms.</param>
        public InteractionModelStatus(List<InteractionModelDeploymentResultModel> latestDeploymentResults = default(List<InteractionModelDeploymentResultModel>), List<QueuedInteractionModelUpdate> queuedForDeploymentToPlatforms = default(List<QueuedInteractionModelUpdate>))
        {
            this.LatestDeploymentResults = latestDeploymentResults;
            this.QueuedForDeploymentToPlatforms = queuedForDeploymentToPlatforms;
        }
        
        /// <summary>
        /// Gets or Sets LatestDeploymentResults
        /// </summary>
        [DataMember(Name="latestDeploymentResults", EmitDefaultValue=false)]
        public List<InteractionModelDeploymentResultModel> LatestDeploymentResults { get; set; }

        /// <summary>
        /// Gets or Sets QueuedForDeploymentToPlatforms
        /// </summary>
        [DataMember(Name="queuedForDeploymentToPlatforms", EmitDefaultValue=false)]
        public List<QueuedInteractionModelUpdate> QueuedForDeploymentToPlatforms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractionModelStatus {\n");
            sb.Append("  LatestDeploymentResults: ").Append(LatestDeploymentResults).Append("\n");
            sb.Append("  QueuedForDeploymentToPlatforms: ").Append(QueuedForDeploymentToPlatforms).Append("\n");
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
            return this.Equals(input as InteractionModelStatus);
        }

        /// <summary>
        /// Returns true if InteractionModelStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of InteractionModelStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractionModelStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestDeploymentResults == input.LatestDeploymentResults ||
                    this.LatestDeploymentResults != null &&
                    this.LatestDeploymentResults.SequenceEqual(input.LatestDeploymentResults)
                ) && 
                (
                    this.QueuedForDeploymentToPlatforms == input.QueuedForDeploymentToPlatforms ||
                    this.QueuedForDeploymentToPlatforms != null &&
                    this.QueuedForDeploymentToPlatforms.SequenceEqual(input.QueuedForDeploymentToPlatforms)
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
                if (this.LatestDeploymentResults != null)
                    hashCode = hashCode * 59 + this.LatestDeploymentResults.GetHashCode();
                if (this.QueuedForDeploymentToPlatforms != null)
                    hashCode = hashCode * 59 + this.QueuedForDeploymentToPlatforms.GetHashCode();
                return hashCode;
            }
        }

    }

}
