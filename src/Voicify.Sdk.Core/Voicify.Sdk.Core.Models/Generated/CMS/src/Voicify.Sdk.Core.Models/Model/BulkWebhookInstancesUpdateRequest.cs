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
    /// BulkWebhookInstancesUpdateRequest
    /// </summary>
    [DataContract]
        public partial class BulkWebhookInstancesUpdateRequest :  IEquatable<BulkWebhookInstancesUpdateRequest>
    {
        /// <summary>
        /// Gets or Sets WebhookChainingType
        /// </summary>
        [DataMember(Name="webhookChainingType", EmitDefaultValue=false)]
        public WebhookChainingType? WebhookChainingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkWebhookInstancesUpdateRequest" /> class.
        /// </summary>
        /// <param name="webhookInstances">webhookInstances.</param>
        /// <param name="webhookChainingType">webhookChainingType.</param>
        public BulkWebhookInstancesUpdateRequest(List<WebhookInstanceRequest> webhookInstances = default(List<WebhookInstanceRequest>), WebhookChainingType? webhookChainingType = default(WebhookChainingType?))
        {
            this.WebhookInstances = webhookInstances;
            this.WebhookChainingType = webhookChainingType;
        }
        
        /// <summary>
        /// Gets or Sets WebhookInstances
        /// </summary>
        [DataMember(Name="webhookInstances", EmitDefaultValue=false)]
        public List<WebhookInstanceRequest> WebhookInstances { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkWebhookInstancesUpdateRequest {\n");
            sb.Append("  WebhookInstances: ").Append(WebhookInstances).Append("\n");
            sb.Append("  WebhookChainingType: ").Append(WebhookChainingType).Append("\n");
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
            return this.Equals(input as BulkWebhookInstancesUpdateRequest);
        }

        /// <summary>
        /// Returns true if BulkWebhookInstancesUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkWebhookInstancesUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkWebhookInstancesUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebhookInstances == input.WebhookInstances ||
                    this.WebhookInstances != null &&
                    input.WebhookInstances != null &&
                    this.WebhookInstances.SequenceEqual(input.WebhookInstances)
                ) && 
                (
                    this.WebhookChainingType == input.WebhookChainingType ||
                    (this.WebhookChainingType != null &&
                    this.WebhookChainingType.Equals(input.WebhookChainingType))
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
                if (this.WebhookInstances != null)
                    hashCode = hashCode * 59 + this.WebhookInstances.GetHashCode();
                if (this.WebhookChainingType != null)
                    hashCode = hashCode * 59 + this.WebhookChainingType.GetHashCode();
                return hashCode;
            }
        }

    }
}
