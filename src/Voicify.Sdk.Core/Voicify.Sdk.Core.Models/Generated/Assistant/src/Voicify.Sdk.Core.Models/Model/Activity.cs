/* 
 * Voicify Assistant API
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
    /// Activity
    /// </summary>
    [DataContract]
    public partial class Activity : Dictionary<String, Object>,  IEquatable<Activity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="localTimestamp">localTimestamp.</param>
        /// <param name="localTimezone">localTimezone.</param>
        /// <param name="serviceUrl">serviceUrl.</param>
        /// <param name="channelId">channelId.</param>
        /// <param name="from">from.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="textFormat">textFormat.</param>
        /// <param name="attachmentLayout">attachmentLayout.</param>
        /// <param name="membersAdded">membersAdded.</param>
        /// <param name="membersRemoved">membersRemoved.</param>
        /// <param name="reactionsAdded">reactionsAdded.</param>
        /// <param name="reactionsRemoved">reactionsRemoved.</param>
        /// <param name="topicName">topicName.</param>
        /// <param name="historyDisclosed">historyDisclosed.</param>
        /// <param name="locale">locale.</param>
        /// <param name="text">text.</param>
        /// <param name="speak">speak.</param>
        /// <param name="inputHint">inputHint.</param>
        /// <param name="summary">summary.</param>
        /// <param name="suggestedActions">suggestedActions.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="entities">entities.</param>
        /// <param name="channelData">channelData.</param>
        /// <param name="action">action.</param>
        /// <param name="replyToId">replyToId.</param>
        /// <param name="label">label.</param>
        /// <param name="valueType">valueType.</param>
        /// <param name="value">value.</param>
        /// <param name="name">name.</param>
        /// <param name="relatesTo">relatesTo.</param>
        /// <param name="code">code.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="importance">importance.</param>
        /// <param name="deliveryMode">deliveryMode.</param>
        /// <param name="listenFor">listenFor.</param>
        /// <param name="textHighlights">textHighlights.</param>
        /// <param name="semanticAction">semanticAction.</param>
        public Activity(string type = default(string), string id = default(string), DateTime? timestamp = default(DateTime?), DateTime? localTimestamp = default(DateTime?), string localTimezone = default(string), string serviceUrl = default(string), string channelId = default(string), ChannelAccount from = default(ChannelAccount), ConversationAccount conversation = default(ConversationAccount), ChannelAccount recipient = default(ChannelAccount), string textFormat = default(string), string attachmentLayout = default(string), List<ChannelAccount> membersAdded = default(List<ChannelAccount>), List<ChannelAccount> membersRemoved = default(List<ChannelAccount>), List<MessageReaction> reactionsAdded = default(List<MessageReaction>), List<MessageReaction> reactionsRemoved = default(List<MessageReaction>), string topicName = default(string), bool? historyDisclosed = default(bool?), string locale = default(string), string text = default(string), string speak = default(string), string inputHint = default(string), string summary = default(string), SuggestedActions suggestedActions = default(SuggestedActions), List<Attachment> attachments = default(List<Attachment>), List<Entity> entities = default(List<Entity>), Object channelData = default(Object), string action = default(string), string replyToId = default(string), string label = default(string), string valueType = default(string), Object value = default(Object), string name = default(string), ConversationReference relatesTo = default(ConversationReference), string code = default(string), DateTime? expiration = default(DateTime?), string importance = default(string), string deliveryMode = default(string), List<string> listenFor = default(List<string>), List<TextHighlight> textHighlights = default(List<TextHighlight>), SemanticAction semanticAction = default(SemanticAction)) : base()
        {
            this.Type = type;
            this.Id = id;
            this.Timestamp = timestamp;
            this.LocalTimestamp = localTimestamp;
            this.LocalTimezone = localTimezone;
            this.ServiceUrl = serviceUrl;
            this.ChannelId = channelId;
            this.From = from;
            this.Conversation = conversation;
            this.Recipient = recipient;
            this.TextFormat = textFormat;
            this.AttachmentLayout = attachmentLayout;
            this.MembersAdded = membersAdded;
            this.MembersRemoved = membersRemoved;
            this.ReactionsAdded = reactionsAdded;
            this.ReactionsRemoved = reactionsRemoved;
            this.TopicName = topicName;
            this.HistoryDisclosed = historyDisclosed;
            this.Locale = locale;
            this.Text = text;
            this.Speak = speak;
            this.InputHint = inputHint;
            this.Summary = summary;
            this.SuggestedActions = suggestedActions;
            this.Attachments = attachments;
            this.Entities = entities;
            this.ChannelData = channelData;
            this.Action = action;
            this.ReplyToId = replyToId;
            this.Label = label;
            this.ValueType = valueType;
            this.Value = value;
            this.Name = name;
            this.RelatesTo = relatesTo;
            this.Code = code;
            this.Expiration = expiration;
            this.Importance = importance;
            this.DeliveryMode = deliveryMode;
            this.ListenFor = listenFor;
            this.TextHighlights = textHighlights;
            this.SemanticAction = semanticAction;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets LocalTimestamp
        /// </summary>
        [DataMember(Name="localTimestamp", EmitDefaultValue=false)]
        public DateTime? LocalTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets LocalTimezone
        /// </summary>
        [DataMember(Name="localTimezone", EmitDefaultValue=false)]
        public string LocalTimezone { get; set; }

        /// <summary>
        /// Gets or Sets ServiceUrl
        /// </summary>
        [DataMember(Name="serviceUrl", EmitDefaultValue=false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public ChannelAccount From { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public ChannelAccount Recipient { get; set; }

        /// <summary>
        /// Gets or Sets TextFormat
        /// </summary>
        [DataMember(Name="textFormat", EmitDefaultValue=false)]
        public string TextFormat { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentLayout
        /// </summary>
        [DataMember(Name="attachmentLayout", EmitDefaultValue=false)]
        public string AttachmentLayout { get; set; }

        /// <summary>
        /// Gets or Sets MembersAdded
        /// </summary>
        [DataMember(Name="membersAdded", EmitDefaultValue=false)]
        public List<ChannelAccount> MembersAdded { get; set; }

        /// <summary>
        /// Gets or Sets MembersRemoved
        /// </summary>
        [DataMember(Name="membersRemoved", EmitDefaultValue=false)]
        public List<ChannelAccount> MembersRemoved { get; set; }

        /// <summary>
        /// Gets or Sets ReactionsAdded
        /// </summary>
        [DataMember(Name="reactionsAdded", EmitDefaultValue=false)]
        public List<MessageReaction> ReactionsAdded { get; set; }

        /// <summary>
        /// Gets or Sets ReactionsRemoved
        /// </summary>
        [DataMember(Name="reactionsRemoved", EmitDefaultValue=false)]
        public List<MessageReaction> ReactionsRemoved { get; set; }

        /// <summary>
        /// Gets or Sets TopicName
        /// </summary>
        [DataMember(Name="topicName", EmitDefaultValue=false)]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or Sets HistoryDisclosed
        /// </summary>
        [DataMember(Name="historyDisclosed", EmitDefaultValue=false)]
        public bool? HistoryDisclosed { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Speak
        /// </summary>
        [DataMember(Name="speak", EmitDefaultValue=false)]
        public string Speak { get; set; }

        /// <summary>
        /// Gets or Sets InputHint
        /// </summary>
        [DataMember(Name="inputHint", EmitDefaultValue=false)]
        public string InputHint { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets SuggestedActions
        /// </summary>
        [DataMember(Name="suggestedActions", EmitDefaultValue=false)]
        public SuggestedActions SuggestedActions { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or Sets ChannelData
        /// </summary>
        [DataMember(Name="channelData", EmitDefaultValue=false)]
        public Object ChannelData { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToId
        /// </summary>
        [DataMember(Name="replyToId", EmitDefaultValue=false)]
        public string ReplyToId { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RelatesTo
        /// </summary>
        [DataMember(Name="relatesTo", EmitDefaultValue=false)]
        public ConversationReference RelatesTo { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Importance
        /// </summary>
        [DataMember(Name="importance", EmitDefaultValue=false)]
        public string Importance { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryMode
        /// </summary>
        [DataMember(Name="deliveryMode", EmitDefaultValue=false)]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// Gets or Sets ListenFor
        /// </summary>
        [DataMember(Name="listenFor", EmitDefaultValue=false)]
        public List<string> ListenFor { get; set; }

        /// <summary>
        /// Gets or Sets TextHighlights
        /// </summary>
        [DataMember(Name="textHighlights", EmitDefaultValue=false)]
        public List<TextHighlight> TextHighlights { get; set; }

        /// <summary>
        /// Gets or Sets SemanticAction
        /// </summary>
        [DataMember(Name="semanticAction", EmitDefaultValue=false)]
        public SemanticAction SemanticAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  LocalTimestamp: ").Append(LocalTimestamp).Append("\n");
            sb.Append("  LocalTimezone: ").Append(LocalTimezone).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  TextFormat: ").Append(TextFormat).Append("\n");
            sb.Append("  AttachmentLayout: ").Append(AttachmentLayout).Append("\n");
            sb.Append("  MembersAdded: ").Append(MembersAdded).Append("\n");
            sb.Append("  MembersRemoved: ").Append(MembersRemoved).Append("\n");
            sb.Append("  ReactionsAdded: ").Append(ReactionsAdded).Append("\n");
            sb.Append("  ReactionsRemoved: ").Append(ReactionsRemoved).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  HistoryDisclosed: ").Append(HistoryDisclosed).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Speak: ").Append(Speak).Append("\n");
            sb.Append("  InputHint: ").Append(InputHint).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  SuggestedActions: ").Append(SuggestedActions).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  ChannelData: ").Append(ChannelData).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RelatesTo: ").Append(RelatesTo).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Importance: ").Append(Importance).Append("\n");
            sb.Append("  DeliveryMode: ").Append(DeliveryMode).Append("\n");
            sb.Append("  ListenFor: ").Append(ListenFor).Append("\n");
            sb.Append("  TextHighlights: ").Append(TextHighlights).Append("\n");
            sb.Append("  SemanticAction: ").Append(SemanticAction).Append("\n");
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
            return this.Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && base.Equals(input) && 
                (
                    this.LocalTimestamp == input.LocalTimestamp ||
                    (this.LocalTimestamp != null &&
                    this.LocalTimestamp.Equals(input.LocalTimestamp))
                ) && base.Equals(input) && 
                (
                    this.LocalTimezone == input.LocalTimezone ||
                    (this.LocalTimezone != null &&
                    this.LocalTimezone.Equals(input.LocalTimezone))
                ) && base.Equals(input) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
                ) && base.Equals(input) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && base.Equals(input) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && base.Equals(input) && 
                (
                    this.Conversation == input.Conversation ||
                    (this.Conversation != null &&
                    this.Conversation.Equals(input.Conversation))
                ) && base.Equals(input) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && base.Equals(input) && 
                (
                    this.TextFormat == input.TextFormat ||
                    (this.TextFormat != null &&
                    this.TextFormat.Equals(input.TextFormat))
                ) && base.Equals(input) && 
                (
                    this.AttachmentLayout == input.AttachmentLayout ||
                    (this.AttachmentLayout != null &&
                    this.AttachmentLayout.Equals(input.AttachmentLayout))
                ) && base.Equals(input) && 
                (
                    this.MembersAdded == input.MembersAdded ||
                    this.MembersAdded != null &&
                    this.MembersAdded.SequenceEqual(input.MembersAdded)
                ) && base.Equals(input) && 
                (
                    this.MembersRemoved == input.MembersRemoved ||
                    this.MembersRemoved != null &&
                    this.MembersRemoved.SequenceEqual(input.MembersRemoved)
                ) && base.Equals(input) && 
                (
                    this.ReactionsAdded == input.ReactionsAdded ||
                    this.ReactionsAdded != null &&
                    this.ReactionsAdded.SequenceEqual(input.ReactionsAdded)
                ) && base.Equals(input) && 
                (
                    this.ReactionsRemoved == input.ReactionsRemoved ||
                    this.ReactionsRemoved != null &&
                    this.ReactionsRemoved.SequenceEqual(input.ReactionsRemoved)
                ) && base.Equals(input) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && base.Equals(input) && 
                (
                    this.HistoryDisclosed == input.HistoryDisclosed ||
                    (this.HistoryDisclosed != null &&
                    this.HistoryDisclosed.Equals(input.HistoryDisclosed))
                ) && base.Equals(input) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && base.Equals(input) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && base.Equals(input) && 
                (
                    this.Speak == input.Speak ||
                    (this.Speak != null &&
                    this.Speak.Equals(input.Speak))
                ) && base.Equals(input) && 
                (
                    this.InputHint == input.InputHint ||
                    (this.InputHint != null &&
                    this.InputHint.Equals(input.InputHint))
                ) && base.Equals(input) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && base.Equals(input) && 
                (
                    this.SuggestedActions == input.SuggestedActions ||
                    (this.SuggestedActions != null &&
                    this.SuggestedActions.Equals(input.SuggestedActions))
                ) && base.Equals(input) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && base.Equals(input) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && base.Equals(input) && 
                (
                    this.ChannelData == input.ChannelData ||
                    (this.ChannelData != null &&
                    this.ChannelData.Equals(input.ChannelData))
                ) && base.Equals(input) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && base.Equals(input) && 
                (
                    this.ReplyToId == input.ReplyToId ||
                    (this.ReplyToId != null &&
                    this.ReplyToId.Equals(input.ReplyToId))
                ) && base.Equals(input) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && base.Equals(input) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.RelatesTo == input.RelatesTo ||
                    (this.RelatesTo != null &&
                    this.RelatesTo.Equals(input.RelatesTo))
                ) && base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && base.Equals(input) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && base.Equals(input) && 
                (
                    this.Importance == input.Importance ||
                    (this.Importance != null &&
                    this.Importance.Equals(input.Importance))
                ) && base.Equals(input) && 
                (
                    this.DeliveryMode == input.DeliveryMode ||
                    (this.DeliveryMode != null &&
                    this.DeliveryMode.Equals(input.DeliveryMode))
                ) && base.Equals(input) && 
                (
                    this.ListenFor == input.ListenFor ||
                    this.ListenFor != null &&
                    this.ListenFor.SequenceEqual(input.ListenFor)
                ) && base.Equals(input) && 
                (
                    this.TextHighlights == input.TextHighlights ||
                    this.TextHighlights != null &&
                    this.TextHighlights.SequenceEqual(input.TextHighlights)
                ) && base.Equals(input) && 
                (
                    this.SemanticAction == input.SemanticAction ||
                    (this.SemanticAction != null &&
                    this.SemanticAction.Equals(input.SemanticAction))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.LocalTimestamp != null)
                    hashCode = hashCode * 59 + this.LocalTimestamp.GetHashCode();
                if (this.LocalTimezone != null)
                    hashCode = hashCode * 59 + this.LocalTimezone.GetHashCode();
                if (this.ServiceUrl != null)
                    hashCode = hashCode * 59 + this.ServiceUrl.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Conversation != null)
                    hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.TextFormat != null)
                    hashCode = hashCode * 59 + this.TextFormat.GetHashCode();
                if (this.AttachmentLayout != null)
                    hashCode = hashCode * 59 + this.AttachmentLayout.GetHashCode();
                if (this.MembersAdded != null)
                    hashCode = hashCode * 59 + this.MembersAdded.GetHashCode();
                if (this.MembersRemoved != null)
                    hashCode = hashCode * 59 + this.MembersRemoved.GetHashCode();
                if (this.ReactionsAdded != null)
                    hashCode = hashCode * 59 + this.ReactionsAdded.GetHashCode();
                if (this.ReactionsRemoved != null)
                    hashCode = hashCode * 59 + this.ReactionsRemoved.GetHashCode();
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.HistoryDisclosed != null)
                    hashCode = hashCode * 59 + this.HistoryDisclosed.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Speak != null)
                    hashCode = hashCode * 59 + this.Speak.GetHashCode();
                if (this.InputHint != null)
                    hashCode = hashCode * 59 + this.InputHint.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.SuggestedActions != null)
                    hashCode = hashCode * 59 + this.SuggestedActions.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.ChannelData != null)
                    hashCode = hashCode * 59 + this.ChannelData.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ReplyToId != null)
                    hashCode = hashCode * 59 + this.ReplyToId.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RelatesTo != null)
                    hashCode = hashCode * 59 + this.RelatesTo.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.Importance != null)
                    hashCode = hashCode * 59 + this.Importance.GetHashCode();
                if (this.DeliveryMode != null)
                    hashCode = hashCode * 59 + this.DeliveryMode.GetHashCode();
                if (this.ListenFor != null)
                    hashCode = hashCode * 59 + this.ListenFor.GetHashCode();
                if (this.TextHighlights != null)
                    hashCode = hashCode * 59 + this.TextHighlights.GetHashCode();
                if (this.SemanticAction != null)
                    hashCode = hashCode * 59 + this.SemanticAction.GetHashCode();
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