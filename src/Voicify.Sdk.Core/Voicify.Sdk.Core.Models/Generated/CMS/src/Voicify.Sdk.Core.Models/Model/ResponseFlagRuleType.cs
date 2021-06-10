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
    /// Defines ResponseFlagRuleType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseFlagRuleType
    {
        /// <summary>
        /// Enum Add for value: Add
        /// </summary>
        [EnumMember(Value = "Add")]
        Add = 1,
        /// <summary>
        /// Enum Remove for value: Remove
        /// </summary>
        [EnumMember(Value = "Remove")]
        Remove = 2    }
}
