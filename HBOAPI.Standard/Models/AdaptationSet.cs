// <copyright file="AdaptationSet.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace HBOAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using HBOAPI.Standard;
    using HBOAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// AdaptationSet.
    /// </summary>
    [XmlRootAttribute("AdaptationSet")]
    public class AdaptationSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptationSet"/> class.
        /// </summary>
        public AdaptationSet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptationSet"/> class.
        /// </summary>
        /// <param name="contentProtection">ContentProtection.</param>
        /// <param name="representation">Representation.</param>
        /// <param name="subsegmentAlignment">subsegmentAlignment.</param>
        /// <param name="subsegmentStartsWithSAP">subsegmentStartsWithSAP.</param>
        /// <param name="id">id.</param>
        /// <param name="lang">lang.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="role">Role.</param>
        /// <param name="accessibility">Accessibility.</param>
        /// <param name="frameRate">frameRate.</param>
        /// <param name="par">par.</param>
        /// <param name="maxWidth">maxWidth.</param>
        /// <param name="maxHeight">maxHeight.</param>
        /// <param name="supplementalProperty">SupplementalProperty.</param>
        public AdaptationSet(
            List<Models.ContentProtection> contentProtection,
            Models.Representation representation,
            bool? subsegmentAlignment = null,
            int? subsegmentStartsWithSAP = null,
            int? id = null,
            string lang = null,
            string contentType = null,
            Models.Role role = null,
            Models.Accessibility accessibility = null,
            string frameRate = null,
            string par = null,
            int? maxWidth = null,
            int? maxHeight = null,
            Models.SupplementalProperty supplementalProperty = null)
        {
            this.SubsegmentAlignment = subsegmentAlignment;
            this.SubsegmentStartsWithSAP = subsegmentStartsWithSAP;
            this.Id = id;
            this.Lang = lang;
            this.ContentType = contentType;
            this.ContentProtection = contentProtection;
            this.Representation = representation;
            this.Role = role;
            this.Accessibility = accessibility;
            this.FrameRate = frameRate;
            this.Par = par;
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight;
            this.SupplementalProperty = supplementalProperty;
        }

        /// <summary>
        /// Gets or sets SubsegmentAlignment.
        /// </summary>
        [JsonProperty("subsegmentAlignment", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("subsegmentAlignment")]
        public bool? SubsegmentAlignment { get; set; }

        /// <summary>
        /// Gets or sets SubsegmentStartsWithSAP.
        /// </summary>
        [JsonProperty("subsegmentStartsWithSAP", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("subsegmentStartsWithSAP")]
        public int? SubsegmentStartsWithSAP { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Lang.
        /// </summary>
        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets ContentProtection.
        /// </summary>
        [JsonProperty("ContentProtection")]
        [XmlElement("ContentProtection")]
        public List<Models.ContentProtection> ContentProtection { get; set; }

        /// <summary>
        /// Gets or sets Representation.
        /// </summary>
        [JsonProperty("Representation")]
        [XmlElement("Representation")]
        public Models.Representation Representation { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("Role", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Role")]
        public Models.Role Role { get; set; }

        /// <summary>
        /// Gets or sets Accessibility.
        /// </summary>
        [JsonProperty("Accessibility", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Accessibility")]
        public Models.Accessibility Accessibility { get; set; }

        /// <summary>
        /// Gets or sets FrameRate.
        /// </summary>
        [JsonProperty("frameRate", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("frameRate")]
        public string FrameRate { get; set; }

        /// <summary>
        /// Gets or sets Par.
        /// </summary>
        [JsonProperty("par", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("par")]
        public string Par { get; set; }

        /// <summary>
        /// Gets or sets MaxWidth.
        /// </summary>
        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("maxWidth")]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets MaxHeight.
        /// </summary>
        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("maxHeight")]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets SupplementalProperty.
        /// </summary>
        [JsonProperty("SupplementalProperty", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SupplementalProperty")]
        public Models.SupplementalProperty SupplementalProperty { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdaptationSet : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is AdaptationSet other &&
                ((this.SubsegmentAlignment == null && other.SubsegmentAlignment == null) || (this.SubsegmentAlignment?.Equals(other.SubsegmentAlignment) == true)) &&
                ((this.SubsegmentStartsWithSAP == null && other.SubsegmentStartsWithSAP == null) || (this.SubsegmentStartsWithSAP?.Equals(other.SubsegmentStartsWithSAP) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Lang == null && other.Lang == null) || (this.Lang?.Equals(other.Lang) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true)) &&
                ((this.ContentProtection == null && other.ContentProtection == null) || (this.ContentProtection?.Equals(other.ContentProtection) == true)) &&
                ((this.Representation == null && other.Representation == null) || (this.Representation?.Equals(other.Representation) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.Accessibility == null && other.Accessibility == null) || (this.Accessibility?.Equals(other.Accessibility) == true)) &&
                ((this.FrameRate == null && other.FrameRate == null) || (this.FrameRate?.Equals(other.FrameRate) == true)) &&
                ((this.Par == null && other.Par == null) || (this.Par?.Equals(other.Par) == true)) &&
                ((this.MaxWidth == null && other.MaxWidth == null) || (this.MaxWidth?.Equals(other.MaxWidth) == true)) &&
                ((this.MaxHeight == null && other.MaxHeight == null) || (this.MaxHeight?.Equals(other.MaxHeight) == true)) &&
                ((this.SupplementalProperty == null && other.SupplementalProperty == null) || (this.SupplementalProperty?.Equals(other.SupplementalProperty) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubsegmentAlignment = {(this.SubsegmentAlignment == null ? "null" : this.SubsegmentAlignment.ToString())}");
            toStringOutput.Add($"this.SubsegmentStartsWithSAP = {(this.SubsegmentStartsWithSAP == null ? "null" : this.SubsegmentStartsWithSAP.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Lang = {(this.Lang == null ? "null" : this.Lang == string.Empty ? "" : this.Lang)}");
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType == string.Empty ? "" : this.ContentType)}");
            toStringOutput.Add($"this.ContentProtection = {(this.ContentProtection == null ? "null" : $"[{string.Join(", ", this.ContentProtection)} ]")}");
            toStringOutput.Add($"this.Representation = {(this.Representation == null ? "null" : this.Representation.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"this.Accessibility = {(this.Accessibility == null ? "null" : this.Accessibility.ToString())}");
            toStringOutput.Add($"this.FrameRate = {(this.FrameRate == null ? "null" : this.FrameRate == string.Empty ? "" : this.FrameRate)}");
            toStringOutput.Add($"this.Par = {(this.Par == null ? "null" : this.Par == string.Empty ? "" : this.Par)}");
            toStringOutput.Add($"this.MaxWidth = {(this.MaxWidth == null ? "null" : this.MaxWidth.ToString())}");
            toStringOutput.Add($"this.MaxHeight = {(this.MaxHeight == null ? "null" : this.MaxHeight.ToString())}");
            toStringOutput.Add($"this.SupplementalProperty = {(this.SupplementalProperty == null ? "null" : this.SupplementalProperty.ToString())}");
        }
    }
}