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
    /// Defines ArchiveType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ArchiveType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,
        /// <summary>
        /// Enum BulkContent for value: BulkContent
        /// </summary>
        [EnumMember(Value = "BulkContent")]
        BulkContent = 2,
        /// <summary>
        /// Enum BulkWebhook for value: BulkWebhook
        /// </summary>
        [EnumMember(Value = "BulkWebhook")]
        BulkWebhook = 3,
        /// <summary>
        /// Enum InteractionModelChanges for value: InteractionModelChanges
        /// </summary>
        [EnumMember(Value = "InteractionModelChanges")]
        InteractionModelChanges = 4,
        /// <summary>
        /// Enum FullApplication for value: FullApplication
        /// </summary>
        [EnumMember(Value = "FullApplication")]
        FullApplication = 5    }
}
