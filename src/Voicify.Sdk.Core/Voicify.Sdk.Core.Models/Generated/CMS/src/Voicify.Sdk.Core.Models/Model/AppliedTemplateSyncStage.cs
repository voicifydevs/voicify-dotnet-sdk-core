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
    /// Defines AppliedTemplateSyncStage
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppliedTemplateSyncStage
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum Queued for value: Queued
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued = 2,
        /// <summary>
        /// Enum Processing for value: Processing
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing = 3,
        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete = 4    }
}
