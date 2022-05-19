// <copyright file="Representation.cs" company="APIMatic">
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
    /// Representation.
    /// </summary>
    [XmlRootAttribute("Representation")]
    public class Representation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Representation"/> class.
        /// </summary>
        public Representation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Representation"/> class.
        /// </summary>
        /// <param name="baseURL">BaseURL.</param>
        /// <param name="segmentBase">SegmentBase.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="audioSamplingRate">audioSamplingRate.</param>
        /// <param name="bandwidth">bandwidth.</param>
        /// <param name="codecs">codecs.</param>
        /// <param name="id">id.</param>
        /// <param name="audioChannelConfiguration">AudioChannelConfiguration.</param>
        /// <param name="sar">sar.</param>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        public Representation(
            string baseURL,
            Models.SegmentBase segmentBase,
            string mimeType = null,
            int? audioSamplingRate = null,
            int? bandwidth = null,
            string codecs = null,
            string id = null,
            Models.AudioChannelConfiguration audioChannelConfiguration = null,
            string sar = null,
            int? height = null,
            int? width = null)
        {
            this.MimeType = mimeType;
            this.AudioSamplingRate = audioSamplingRate;
            this.Bandwidth = bandwidth;
            this.Codecs = codecs;
            this.Id = id;
            this.AudioChannelConfiguration = audioChannelConfiguration;
            this.BaseURL = baseURL;
            this.SegmentBase = segmentBase;
            this.Sar = sar;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Gets or sets MimeType.
        /// </summary>
        [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets AudioSamplingRate.
        /// </summary>
        [JsonProperty("audioSamplingRate", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("audioSamplingRate")]
        public int? AudioSamplingRate { get; set; }

        /// <summary>
        /// Gets or sets Bandwidth.
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("bandwidth")]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// Gets or sets Codecs.
        /// </summary>
        [JsonProperty("codecs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("codecs")]
        public string Codecs { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets AudioChannelConfiguration.
        /// </summary>
        [JsonProperty("AudioChannelConfiguration", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("AudioChannelConfiguration")]
        public Models.AudioChannelConfiguration AudioChannelConfiguration { get; set; }

        /// <summary>
        /// Gets or sets BaseURL.
        /// </summary>
        [JsonProperty("BaseURL")]
        [XmlElement("BaseURL")]
        public string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets SegmentBase.
        /// </summary>
        [JsonProperty("SegmentBase")]
        [XmlElement("SegmentBase")]
        public Models.SegmentBase SegmentBase { get; set; }

        /// <summary>
        /// Gets or sets Sar.
        /// </summary>
        [JsonProperty("sar", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("sar")]
        public string Sar { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("width")]
        public int? Width { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Representation : ({string.Join(", ", toStringOutput)})";
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

            return obj is Representation other &&
                ((this.MimeType == null && other.MimeType == null) || (this.MimeType?.Equals(other.MimeType) == true)) &&
                ((this.AudioSamplingRate == null && other.AudioSamplingRate == null) || (this.AudioSamplingRate?.Equals(other.AudioSamplingRate) == true)) &&
                ((this.Bandwidth == null && other.Bandwidth == null) || (this.Bandwidth?.Equals(other.Bandwidth) == true)) &&
                ((this.Codecs == null && other.Codecs == null) || (this.Codecs?.Equals(other.Codecs) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AudioChannelConfiguration == null && other.AudioChannelConfiguration == null) || (this.AudioChannelConfiguration?.Equals(other.AudioChannelConfiguration) == true)) &&
                ((this.BaseURL == null && other.BaseURL == null) || (this.BaseURL?.Equals(other.BaseURL) == true)) &&
                ((this.SegmentBase == null && other.SegmentBase == null) || (this.SegmentBase?.Equals(other.SegmentBase) == true)) &&
                ((this.Sar == null && other.Sar == null) || (this.Sar?.Equals(other.Sar) == true)) &&
                ((this.Height == null && other.Height == null) || (this.Height?.Equals(other.Height) == true)) &&
                ((this.Width == null && other.Width == null) || (this.Width?.Equals(other.Width) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MimeType = {(this.MimeType == null ? "null" : this.MimeType == string.Empty ? "" : this.MimeType)}");
            toStringOutput.Add($"this.AudioSamplingRate = {(this.AudioSamplingRate == null ? "null" : this.AudioSamplingRate.ToString())}");
            toStringOutput.Add($"this.Bandwidth = {(this.Bandwidth == null ? "null" : this.Bandwidth.ToString())}");
            toStringOutput.Add($"this.Codecs = {(this.Codecs == null ? "null" : this.Codecs == string.Empty ? "" : this.Codecs)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.AudioChannelConfiguration = {(this.AudioChannelConfiguration == null ? "null" : this.AudioChannelConfiguration.ToString())}");
            toStringOutput.Add($"this.BaseURL = {(this.BaseURL == null ? "null" : this.BaseURL == string.Empty ? "" : this.BaseURL)}");
            toStringOutput.Add($"this.SegmentBase = {(this.SegmentBase == null ? "null" : this.SegmentBase.ToString())}");
            toStringOutput.Add($"this.Sar = {(this.Sar == null ? "null" : this.Sar == string.Empty ? "" : this.Sar)}");
            toStringOutput.Add($"this.Height = {(this.Height == null ? "null" : this.Height.ToString())}");
            toStringOutput.Add($"this.Width = {(this.Width == null ? "null" : this.Width.ToString())}");
        }
    }
}