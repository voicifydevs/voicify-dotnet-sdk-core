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
    /// BulkUpdateRecipeStubRequest
    /// </summary>
    [DataContract]
        public partial class BulkUpdateRecipeStubRequest :  IEquatable<BulkUpdateRecipeStubRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateRecipeStubRequest" /> class.
        /// </summary>
        /// <param name="recipeName">recipeName.</param>
        /// <param name="steps">steps.</param>
        /// <param name="ingredients">ingredients.</param>
        /// <param name="title">title (required).</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="description">description.</param>
        /// <param name="mealType">mealType.</param>
        /// <param name="servings">servings.</param>
        /// <param name="totalTime">totalTime.</param>
        /// <param name="calories">calories.</param>
        /// <param name="videoItemId">videoItemId.</param>
        /// <param name="smallImageItemId">smallImageItemId.</param>
        /// <param name="largeImageItemId">largeImageItemId.</param>
        /// <param name="backgroundImageItemId">backgroundImageItemId.</param>
        /// <param name="audioItemId">audioItemId.</param>
        /// <param name="content">content.</param>
        /// <param name="mediaResponseContainerId">mediaResponseContainerId.</param>
        /// <param name="displayTextOverride">displayTextOverride.</param>
        /// <param name="displayTitleOverride">displayTitleOverride.</param>
        /// <param name="requiresParent">requiresParent.</param>
        /// <param name="languageIds">languageIds.</param>
        public BulkUpdateRecipeStubRequest(string recipeName = default(string), List<UpdateStepRequest> steps = default(List<UpdateStepRequest>), List<UpdateIngredientRequest> ingredients = default(List<UpdateIngredientRequest>), string title = default(string), string keywords = default(string), string description = default(string), string mealType = default(string), string servings = default(string), TimeSpan totalTime = default(TimeSpan), int? calories = default(int?), string videoItemId = default(string), string smallImageItemId = default(string), string largeImageItemId = default(string), string backgroundImageItemId = default(string), string audioItemId = default(string), string content = default(string), string mediaResponseContainerId = default(string), string displayTextOverride = default(string), string displayTitleOverride = default(string), bool? requiresParent = default(bool?), List<string> languageIds = default(List<string>))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for BulkUpdateRecipeStubRequest and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.RecipeName = recipeName;
            this.Steps = steps;
            this.Ingredients = ingredients;
            this.Keywords = keywords;
            this.Description = description;
            this.MealType = mealType;
            this.Servings = servings;
            this.TotalTime = totalTime;
            this.Calories = calories;
            this.VideoItemId = videoItemId;
            this.SmallImageItemId = smallImageItemId;
            this.LargeImageItemId = largeImageItemId;
            this.BackgroundImageItemId = backgroundImageItemId;
            this.AudioItemId = audioItemId;
            this.Content = content;
            this.MediaResponseContainerId = mediaResponseContainerId;
            this.DisplayTextOverride = displayTextOverride;
            this.DisplayTitleOverride = displayTitleOverride;
            this.RequiresParent = requiresParent;
            this.LanguageIds = languageIds;
        }
        
        /// <summary>
        /// Gets or Sets RecipeName
        /// </summary>
        [DataMember(Name="recipeName", EmitDefaultValue=false)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<UpdateStepRequest> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public List<UpdateIngredientRequest> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MealType
        /// </summary>
        [DataMember(Name="mealType", EmitDefaultValue=false)]
        public string MealType { get; set; }

        /// <summary>
        /// Gets or Sets Servings
        /// </summary>
        [DataMember(Name="servings", EmitDefaultValue=false)]
        public string Servings { get; set; }

        /// <summary>
        /// Gets or Sets TotalTime
        /// </summary>
        [DataMember(Name="totalTime", EmitDefaultValue=false)]
        public TimeSpan TotalTime { get; set; }

        /// <summary>
        /// Gets or Sets Calories
        /// </summary>
        [DataMember(Name="calories", EmitDefaultValue=false)]
        public int? Calories { get; set; }

        /// <summary>
        /// Gets or Sets VideoItemId
        /// </summary>
        [DataMember(Name="videoItemId", EmitDefaultValue=false)]
        public string VideoItemId { get; set; }

        /// <summary>
        /// Gets or Sets SmallImageItemId
        /// </summary>
        [DataMember(Name="smallImageItemId", EmitDefaultValue=false)]
        public string SmallImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets LargeImageItemId
        /// </summary>
        [DataMember(Name="largeImageItemId", EmitDefaultValue=false)]
        public string LargeImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImageItemId
        /// </summary>
        [DataMember(Name="backgroundImageItemId", EmitDefaultValue=false)]
        public string BackgroundImageItemId { get; set; }

        /// <summary>
        /// Gets or Sets AudioItemId
        /// </summary>
        [DataMember(Name="audioItemId", EmitDefaultValue=false)]
        public string AudioItemId { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets MediaResponseContainerId
        /// </summary>
        [DataMember(Name="mediaResponseContainerId", EmitDefaultValue=false)]
        public string MediaResponseContainerId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTextOverride
        /// </summary>
        [DataMember(Name="displayTextOverride", EmitDefaultValue=false)]
        public string DisplayTextOverride { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTitleOverride
        /// </summary>
        [DataMember(Name="displayTitleOverride", EmitDefaultValue=false)]
        public string DisplayTitleOverride { get; set; }

        /// <summary>
        /// Gets or Sets RequiresParent
        /// </summary>
        [DataMember(Name="requiresParent", EmitDefaultValue=false)]
        public bool? RequiresParent { get; set; }

        /// <summary>
        /// Gets or Sets LanguageIds
        /// </summary>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateRecipeStubRequest {\n");
            sb.Append("  RecipeName: ").Append(RecipeName).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MealType: ").Append(MealType).Append("\n");
            sb.Append("  Servings: ").Append(Servings).Append("\n");
            sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  Calories: ").Append(Calories).Append("\n");
            sb.Append("  VideoItemId: ").Append(VideoItemId).Append("\n");
            sb.Append("  SmallImageItemId: ").Append(SmallImageItemId).Append("\n");
            sb.Append("  LargeImageItemId: ").Append(LargeImageItemId).Append("\n");
            sb.Append("  BackgroundImageItemId: ").Append(BackgroundImageItemId).Append("\n");
            sb.Append("  AudioItemId: ").Append(AudioItemId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  MediaResponseContainerId: ").Append(MediaResponseContainerId).Append("\n");
            sb.Append("  DisplayTextOverride: ").Append(DisplayTextOverride).Append("\n");
            sb.Append("  DisplayTitleOverride: ").Append(DisplayTitleOverride).Append("\n");
            sb.Append("  RequiresParent: ").Append(RequiresParent).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
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
            return this.Equals(input as BulkUpdateRecipeStubRequest);
        }

        /// <summary>
        /// Returns true if BulkUpdateRecipeStubRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkUpdateRecipeStubRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateRecipeStubRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipeName == input.RecipeName ||
                    (this.RecipeName != null &&
                    this.RecipeName.Equals(input.RecipeName))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    this.Ingredients != null &&
                    input.Ingredients != null &&
                    this.Ingredients.SequenceEqual(input.Ingredients)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MealType == input.MealType ||
                    (this.MealType != null &&
                    this.MealType.Equals(input.MealType))
                ) && 
                (
                    this.Servings == input.Servings ||
                    (this.Servings != null &&
                    this.Servings.Equals(input.Servings))
                ) && 
                (
                    this.TotalTime == input.TotalTime ||
                    (this.TotalTime != null &&
                    this.TotalTime.Equals(input.TotalTime))
                ) && 
                (
                    this.Calories == input.Calories ||
                    (this.Calories != null &&
                    this.Calories.Equals(input.Calories))
                ) && 
                (
                    this.VideoItemId == input.VideoItemId ||
                    (this.VideoItemId != null &&
                    this.VideoItemId.Equals(input.VideoItemId))
                ) && 
                (
                    this.SmallImageItemId == input.SmallImageItemId ||
                    (this.SmallImageItemId != null &&
                    this.SmallImageItemId.Equals(input.SmallImageItemId))
                ) && 
                (
                    this.LargeImageItemId == input.LargeImageItemId ||
                    (this.LargeImageItemId != null &&
                    this.LargeImageItemId.Equals(input.LargeImageItemId))
                ) && 
                (
                    this.BackgroundImageItemId == input.BackgroundImageItemId ||
                    (this.BackgroundImageItemId != null &&
                    this.BackgroundImageItemId.Equals(input.BackgroundImageItemId))
                ) && 
                (
                    this.AudioItemId == input.AudioItemId ||
                    (this.AudioItemId != null &&
                    this.AudioItemId.Equals(input.AudioItemId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.MediaResponseContainerId == input.MediaResponseContainerId ||
                    (this.MediaResponseContainerId != null &&
                    this.MediaResponseContainerId.Equals(input.MediaResponseContainerId))
                ) && 
                (
                    this.DisplayTextOverride == input.DisplayTextOverride ||
                    (this.DisplayTextOverride != null &&
                    this.DisplayTextOverride.Equals(input.DisplayTextOverride))
                ) && 
                (
                    this.DisplayTitleOverride == input.DisplayTitleOverride ||
                    (this.DisplayTitleOverride != null &&
                    this.DisplayTitleOverride.Equals(input.DisplayTitleOverride))
                ) && 
                (
                    this.RequiresParent == input.RequiresParent ||
                    (this.RequiresParent != null &&
                    this.RequiresParent.Equals(input.RequiresParent))
                ) && 
                (
                    this.LanguageIds == input.LanguageIds ||
                    this.LanguageIds != null &&
                    input.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(input.LanguageIds)
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
                if (this.RecipeName != null)
                    hashCode = hashCode * 59 + this.RecipeName.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MealType != null)
                    hashCode = hashCode * 59 + this.MealType.GetHashCode();
                if (this.Servings != null)
                    hashCode = hashCode * 59 + this.Servings.GetHashCode();
                if (this.TotalTime != null)
                    hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.Calories != null)
                    hashCode = hashCode * 59 + this.Calories.GetHashCode();
                if (this.VideoItemId != null)
                    hashCode = hashCode * 59 + this.VideoItemId.GetHashCode();
                if (this.SmallImageItemId != null)
                    hashCode = hashCode * 59 + this.SmallImageItemId.GetHashCode();
                if (this.LargeImageItemId != null)
                    hashCode = hashCode * 59 + this.LargeImageItemId.GetHashCode();
                if (this.BackgroundImageItemId != null)
                    hashCode = hashCode * 59 + this.BackgroundImageItemId.GetHashCode();
                if (this.AudioItemId != null)
                    hashCode = hashCode * 59 + this.AudioItemId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.MediaResponseContainerId != null)
                    hashCode = hashCode * 59 + this.MediaResponseContainerId.GetHashCode();
                if (this.DisplayTextOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTextOverride.GetHashCode();
                if (this.DisplayTitleOverride != null)
                    hashCode = hashCode * 59 + this.DisplayTitleOverride.GetHashCode();
                if (this.RequiresParent != null)
                    hashCode = hashCode * 59 + this.RequiresParent.GetHashCode();
                if (this.LanguageIds != null)
                    hashCode = hashCode * 59 + this.LanguageIds.GetHashCode();
                return hashCode;
            }
        }

    }
}
