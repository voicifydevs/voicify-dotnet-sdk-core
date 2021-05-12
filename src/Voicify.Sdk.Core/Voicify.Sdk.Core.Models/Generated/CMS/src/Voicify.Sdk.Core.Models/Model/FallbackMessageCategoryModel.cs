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
    /// FallbackMessageCategoryModel
    /// </summary>
    [DataContract]
        public partial class FallbackMessageCategoryModel :  IEquatable<FallbackMessageCategoryModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackMessageCategoryModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="featureTypeId">featureTypeId.</param>
        /// <param name="name">name.</param>
        /// <param name="featureType">featureType.</param>
        public FallbackMessageCategoryModel(string id = default(string), string featureTypeId = default(string), string name = default(string), FeatureTypeModel featureType = default(FeatureTypeModel))
        {
            this.Id = id;
            this.FeatureTypeId = featureTypeId;
            this.Name = name;
            this.FeatureType = featureType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FeatureTypeId
        /// </summary>
        [DataMember(Name="featureTypeId", EmitDefaultValue=false)]
        public string FeatureTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FeatureType
        /// </summary>
        [DataMember(Name="featureType", EmitDefaultValue=false)]
        public FeatureTypeModel FeatureType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FallbackMessageCategoryModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FeatureTypeId: ").Append(FeatureTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FeatureType: ").Append(FeatureType).Append("\n");
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
            return this.Equals(input as FallbackMessageCategoryModel);
        }

        /// <summary>
        /// Returns true if FallbackMessageCategoryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of FallbackMessageCategoryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FallbackMessageCategoryModel input)
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
                    this.FeatureTypeId == input.FeatureTypeId ||
                    (this.FeatureTypeId != null &&
                    this.FeatureTypeId.Equals(input.FeatureTypeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FeatureType == input.FeatureType ||
                    (this.FeatureType != null &&
                    this.FeatureType.Equals(input.FeatureType))
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
                if (this.FeatureTypeId != null)
                    hashCode = hashCode * 59 + this.FeatureTypeId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FeatureType != null)
                    hashCode = hashCode * 59 + this.FeatureType.GetHashCode();
                return hashCode;
            }
        }

    }
}
