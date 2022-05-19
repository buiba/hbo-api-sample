// <copyright file="Headers1.cs" company="APIMatic">
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
    /// Headers1.
    /// </summary>
    [XmlRootAttribute("Headers1")]
    public class Headers1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Headers1"/> class.
        /// </summary>
        public Headers1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Headers1"/> class.
        /// </summary>
        /// <param name="xHboDesiredBitrate">x-hbo-desired-bitrate.</param>
        /// <param name="xHboDeviceModel">x-hbo-device-model.</param>
        /// <param name="xHboDownloadQuality">x-hbo-download-quality.</param>
        /// <param name="xHboVideoFeatures">x-hbo-video-features.</param>
        /// <param name="xHboSessionId">x-hbo-session-id.</param>
        /// <param name="xHboVideoInitiatedTime">x-hbo-video-initiated-time.</param>
        /// <param name="xHboVideoPlayerVersion">x-hbo-video-player-version.</param>
        /// <param name="xHboDeviceLocalTime">x-hbo-device-local-time.</param>
        /// <param name="xHboDeviceWidth">x-hbo-device-width.</param>
        /// <param name="xHboDeviceHeight">x-hbo-device-height.</param>
        /// <param name="xHboPlayerWidth">x-hbo-player-width.</param>
        /// <param name="xHboPlayerHeight">x-hbo-player-height.</param>
        /// <param name="xHboDeviceCodeOverride">x-hbo-device-code-override.</param>
        /// <param name="xHboVideoEncodes">x-hbo-video-encodes.</param>
        /// <param name="xHboIsLat">x-hbo-is-lat.</param>
        public Headers1(
            int xHboDesiredBitrate,
            string xHboDeviceModel,
            string xHboDownloadQuality,
            string xHboVideoFeatures,
            string xHboSessionId,
            double xHboVideoInitiatedTime,
            string xHboVideoPlayerVersion,
            string xHboDeviceLocalTime,
            int xHboDeviceWidth,
            int xHboDeviceHeight,
            int xHboPlayerWidth,
            int xHboPlayerHeight,
            string xHboDeviceCodeOverride,
            string xHboVideoEncodes,
            bool xHboIsLat)
        {
            this.XHboDesiredBitrate = xHboDesiredBitrate;
            this.XHboDeviceModel = xHboDeviceModel;
            this.XHboDownloadQuality = xHboDownloadQuality;
            this.XHboVideoFeatures = xHboVideoFeatures;
            this.XHboSessionId = xHboSessionId;
            this.XHboVideoInitiatedTime = xHboVideoInitiatedTime;
            this.XHboVideoPlayerVersion = xHboVideoPlayerVersion;
            this.XHboDeviceLocalTime = xHboDeviceLocalTime;
            this.XHboDeviceWidth = xHboDeviceWidth;
            this.XHboDeviceHeight = xHboDeviceHeight;
            this.XHboPlayerWidth = xHboPlayerWidth;
            this.XHboPlayerHeight = xHboPlayerHeight;
            this.XHboDeviceCodeOverride = xHboDeviceCodeOverride;
            this.XHboVideoEncodes = xHboVideoEncodes;
            this.XHboIsLat = xHboIsLat;
        }

        /// <summary>
        /// Gets or sets XHboDesiredBitrate.
        /// </summary>
        [JsonProperty("x-hbo-desired-bitrate")]
        [XmlElement("x-hbo-desired-bitrate")]
        public int XHboDesiredBitrate { get; set; }

        /// <summary>
        /// Gets or sets XHboDeviceModel.
        /// </summary>
        [JsonProperty("x-hbo-device-model")]
        [XmlElement("x-hbo-device-model")]
        public string XHboDeviceModel { get; set; }

        /// <summary>
        /// Gets or sets XHboDownloadQuality.
        /// </summary>
        [JsonProperty("x-hbo-download-quality")]
        [XmlElement("x-hbo-download-quality")]
        public string XHboDownloadQuality { get; set; }

        /// <summary>
        /// Gets or sets XHboVideoFeatures.
        /// </summary>
        [JsonProperty("x-hbo-video-features")]
        [XmlElement("x-hbo-video-features")]
        public string XHboVideoFeatures { get; set; }

        /// <summary>
        /// Gets or sets XHboSessionId.
        /// </summary>
        [JsonProperty("x-hbo-session-id")]
        [XmlElement("x-hbo-session-id")]
        public string XHboSessionId { get; set; }

        /// <summary>
        /// Gets or sets XHboVideoInitiatedTime.
        /// </summary>
        [JsonProperty("x-hbo-video-initiated-time")]
        [XmlElement("x-hbo-video-initiated-time")]
        public double XHboVideoInitiatedTime { get; set; }

        /// <summary>
        /// Gets or sets XHboVideoPlayerVersion.
        /// </summary>
        [JsonProperty("x-hbo-video-player-version")]
        [XmlElement("x-hbo-video-player-version")]
        public string XHboVideoPlayerVersion { get; set; }

        /// <summary>
        /// Gets or sets XHboDeviceLocalTime.
        /// </summary>
        [JsonProperty("x-hbo-device-local-time")]
        [XmlElement("x-hbo-device-local-time")]
        public string XHboDeviceLocalTime { get; set; }

        /// <summary>
        /// Gets or sets XHboDeviceWidth.
        /// </summary>
        [JsonProperty("x-hbo-device-width")]
        [XmlElement("x-hbo-device-width")]
        public int XHboDeviceWidth { get; set; }

        /// <summary>
        /// Gets or sets XHboDeviceHeight.
        /// </summary>
        [JsonProperty("x-hbo-device-height")]
        [XmlElement("x-hbo-device-height")]
        public int XHboDeviceHeight { get; set; }

        /// <summary>
        /// Gets or sets XHboPlayerWidth.
        /// </summary>
        [JsonProperty("x-hbo-player-width")]
        [XmlElement("x-hbo-player-width")]
        public int XHboPlayerWidth { get; set; }

        /// <summary>
        /// Gets or sets XHboPlayerHeight.
        /// </summary>
        [JsonProperty("x-hbo-player-height")]
        [XmlElement("x-hbo-player-height")]
        public int XHboPlayerHeight { get; set; }

        /// <summary>
        /// Gets or sets XHboDeviceCodeOverride.
        /// </summary>
        [JsonProperty("x-hbo-device-code-override")]
        [XmlElement("x-hbo-device-code-override")]
        public string XHboDeviceCodeOverride { get; set; }

        /// <summary>
        /// Gets or sets XHboVideoEncodes.
        /// </summary>
        [JsonProperty("x-hbo-video-encodes")]
        [XmlElement("x-hbo-video-encodes")]
        public string XHboVideoEncodes { get; set; }

        /// <summary>
        /// Gets or sets XHboIsLat.
        /// </summary>
        [JsonProperty("x-hbo-is-lat")]
        [XmlElement("x-hbo-is-lat")]
        public bool XHboIsLat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Headers1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Headers1 other &&
                this.XHboDesiredBitrate.Equals(other.XHboDesiredBitrate) &&
                ((this.XHboDeviceModel == null && other.XHboDeviceModel == null) || (this.XHboDeviceModel?.Equals(other.XHboDeviceModel) == true)) &&
                ((this.XHboDownloadQuality == null && other.XHboDownloadQuality == null) || (this.XHboDownloadQuality?.Equals(other.XHboDownloadQuality) == true)) &&
                ((this.XHboVideoFeatures == null && other.XHboVideoFeatures == null) || (this.XHboVideoFeatures?.Equals(other.XHboVideoFeatures) == true)) &&
                ((this.XHboSessionId == null && other.XHboSessionId == null) || (this.XHboSessionId?.Equals(other.XHboSessionId) == true)) &&
                this.XHboVideoInitiatedTime.Equals(other.XHboVideoInitiatedTime) &&
                ((this.XHboVideoPlayerVersion == null && other.XHboVideoPlayerVersion == null) || (this.XHboVideoPlayerVersion?.Equals(other.XHboVideoPlayerVersion) == true)) &&
                ((this.XHboDeviceLocalTime == null && other.XHboDeviceLocalTime == null) || (this.XHboDeviceLocalTime?.Equals(other.XHboDeviceLocalTime) == true)) &&
                this.XHboDeviceWidth.Equals(other.XHboDeviceWidth) &&
                this.XHboDeviceHeight.Equals(other.XHboDeviceHeight) &&
                this.XHboPlayerWidth.Equals(other.XHboPlayerWidth) &&
                this.XHboPlayerHeight.Equals(other.XHboPlayerHeight) &&
                ((this.XHboDeviceCodeOverride == null && other.XHboDeviceCodeOverride == null) || (this.XHboDeviceCodeOverride?.Equals(other.XHboDeviceCodeOverride) == true)) &&
                ((this.XHboVideoEncodes == null && other.XHboVideoEncodes == null) || (this.XHboVideoEncodes?.Equals(other.XHboVideoEncodes) == true)) &&
                this.XHboIsLat.Equals(other.XHboIsLat);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.XHboDesiredBitrate = {this.XHboDesiredBitrate}");
            toStringOutput.Add($"this.XHboDeviceModel = {(this.XHboDeviceModel == null ? "null" : this.XHboDeviceModel == string.Empty ? "" : this.XHboDeviceModel)}");
            toStringOutput.Add($"this.XHboDownloadQuality = {(this.XHboDownloadQuality == null ? "null" : this.XHboDownloadQuality == string.Empty ? "" : this.XHboDownloadQuality)}");
            toStringOutput.Add($"this.XHboVideoFeatures = {(this.XHboVideoFeatures == null ? "null" : this.XHboVideoFeatures == string.Empty ? "" : this.XHboVideoFeatures)}");
            toStringOutput.Add($"this.XHboSessionId = {(this.XHboSessionId == null ? "null" : this.XHboSessionId == string.Empty ? "" : this.XHboSessionId)}");
            toStringOutput.Add($"this.XHboVideoInitiatedTime = {this.XHboVideoInitiatedTime}");
            toStringOutput.Add($"this.XHboVideoPlayerVersion = {(this.XHboVideoPlayerVersion == null ? "null" : this.XHboVideoPlayerVersion == string.Empty ? "" : this.XHboVideoPlayerVersion)}");
            toStringOutput.Add($"this.XHboDeviceLocalTime = {(this.XHboDeviceLocalTime == null ? "null" : this.XHboDeviceLocalTime == string.Empty ? "" : this.XHboDeviceLocalTime)}");
            toStringOutput.Add($"this.XHboDeviceWidth = {this.XHboDeviceWidth}");
            toStringOutput.Add($"this.XHboDeviceHeight = {this.XHboDeviceHeight}");
            toStringOutput.Add($"this.XHboPlayerWidth = {this.XHboPlayerWidth}");
            toStringOutput.Add($"this.XHboPlayerHeight = {this.XHboPlayerHeight}");
            toStringOutput.Add($"this.XHboDeviceCodeOverride = {(this.XHboDeviceCodeOverride == null ? "null" : this.XHboDeviceCodeOverride == string.Empty ? "" : this.XHboDeviceCodeOverride)}");
            toStringOutput.Add($"this.XHboVideoEncodes = {(this.XHboVideoEncodes == null ? "null" : this.XHboVideoEncodes == string.Empty ? "" : this.XHboVideoEncodes)}");
            toStringOutput.Add($"this.XHboIsLat = {this.XHboIsLat}");
        }
    }
}