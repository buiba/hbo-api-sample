// <copyright file="References.cs" company="APIMatic">
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
    /// References.
    /// </summary>
    [XmlRootAttribute("References")]
    public class References
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="References"/> class.
        /// </summary>
        public References()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="References"/> class.
        /// </summary>
        /// <param name="edits">edits.</param>
        /// <param name="extras">extras.</param>
        /// <param name="previews">previews.</param>
        /// <param name="series">series.</param>
        /// <param name="season">season.</param>
        /// <param name="next">next.</param>
        /// <param name="viewable">viewable.</param>
        /// <param name="video">video.</param>
        /// <param name="previous">previous.</param>
        public References(
            List<string> edits = null,
            List<string> extras = null,
            List<string> previews = null,
            string series = null,
            string season = null,
            string next = null,
            string viewable = null,
            string video = null,
            string previous = null)
        {
            this.Edits = edits;
            this.Extras = extras;
            this.Previews = previews;
            this.Series = series;
            this.Season = season;
            this.Next = next;
            this.Viewable = viewable;
            this.Video = video;
            this.Previous = previous;
        }

        /// <summary>
        /// Gets or sets Edits.
        /// </summary>
        [JsonProperty("edits", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("edits")]
        public List<string> Edits { get; set; }

        /// <summary>
        /// Gets or sets Extras.
        /// </summary>
        [JsonProperty("extras", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("extras")]
        public List<string> Extras { get; set; }

        /// <summary>
        /// Gets or sets Previews.
        /// </summary>
        [JsonProperty("previews", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("previews")]
        public List<string> Previews { get; set; }

        /// <summary>
        /// Gets or sets Series.
        /// </summary>
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("series")]
        public string Series { get; set; }

        /// <summary>
        /// Gets or sets Season.
        /// </summary>
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or sets Next.
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("next")]
        public string Next { get; set; }

        /// <summary>
        /// Gets or sets Viewable.
        /// </summary>
        [JsonProperty("viewable", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("viewable")]
        public string Viewable { get; set; }

        /// <summary>
        /// Gets or sets Video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("video")]
        public string Video { get; set; }

        /// <summary>
        /// Gets or sets Previous.
        /// </summary>
        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("previous")]
        public string Previous { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"References : ({string.Join(", ", toStringOutput)})";
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

            return obj is References other &&
                ((this.Edits == null && other.Edits == null) || (this.Edits?.Equals(other.Edits) == true)) &&
                ((this.Extras == null && other.Extras == null) || (this.Extras?.Equals(other.Extras) == true)) &&
                ((this.Previews == null && other.Previews == null) || (this.Previews?.Equals(other.Previews) == true)) &&
                ((this.Series == null && other.Series == null) || (this.Series?.Equals(other.Series) == true)) &&
                ((this.Season == null && other.Season == null) || (this.Season?.Equals(other.Season) == true)) &&
                ((this.Next == null && other.Next == null) || (this.Next?.Equals(other.Next) == true)) &&
                ((this.Viewable == null && other.Viewable == null) || (this.Viewable?.Equals(other.Viewable) == true)) &&
                ((this.Video == null && other.Video == null) || (this.Video?.Equals(other.Video) == true)) &&
                ((this.Previous == null && other.Previous == null) || (this.Previous?.Equals(other.Previous) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Edits = {(this.Edits == null ? "null" : $"[{string.Join(", ", this.Edits)} ]")}");
            toStringOutput.Add($"this.Extras = {(this.Extras == null ? "null" : $"[{string.Join(", ", this.Extras)} ]")}");
            toStringOutput.Add($"this.Previews = {(this.Previews == null ? "null" : $"[{string.Join(", ", this.Previews)} ]")}");
            toStringOutput.Add($"this.Series = {(this.Series == null ? "null" : this.Series == string.Empty ? "" : this.Series)}");
            toStringOutput.Add($"this.Season = {(this.Season == null ? "null" : this.Season == string.Empty ? "" : this.Season)}");
            toStringOutput.Add($"this.Next = {(this.Next == null ? "null" : this.Next == string.Empty ? "" : this.Next)}");
            toStringOutput.Add($"this.Viewable = {(this.Viewable == null ? "null" : this.Viewable == string.Empty ? "" : this.Viewable)}");
            toStringOutput.Add($"this.Video = {(this.Video == null ? "null" : this.Video == string.Empty ? "" : this.Video)}");
            toStringOutput.Add($"this.Previous = {(this.Previous == null ? "null" : this.Previous == string.Empty ? "" : this.Previous)}");
        }
    }
}