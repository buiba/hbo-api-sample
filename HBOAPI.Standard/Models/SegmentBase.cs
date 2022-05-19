// <copyright file="SegmentBase.cs" company="APIMatic">
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
    /// SegmentBase.
    /// </summary>
    [XmlRootAttribute("SegmentBase")]
    public class SegmentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentBase"/> class.
        /// </summary>
        public SegmentBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentBase"/> class.
        /// </summary>
        /// <param name="initialization">Initialization.</param>
        /// <param name="timescale">timescale.</param>
        /// <param name="indexRange">indexRange.</param>
        public SegmentBase(
            Models.Initialization initialization,
            int? timescale = null,
            string indexRange = null)
        {
            this.Timescale = timescale;
            this.IndexRange = indexRange;
            this.Initialization = initialization;
        }

        /// <summary>
        /// Gets or sets Timescale.
        /// </summary>
        [JsonProperty("timescale", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("timescale")]
        public int? Timescale { get; set; }

        /// <summary>
        /// Gets or sets IndexRange.
        /// </summary>
        [JsonProperty("indexRange", NullValueHandling = NullValueHandling.Ignore)]
        [XmlAttribute("indexRange")]
        public string IndexRange { get; set; }

        /// <summary>
        /// Gets or sets Initialization.
        /// </summary>
        [JsonProperty("Initialization")]
        [XmlElement("Initialization")]
        public Models.Initialization Initialization { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SegmentBase : ({string.Join(", ", toStringOutput)})";
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

            return obj is SegmentBase other &&
                ((this.Timescale == null && other.Timescale == null) || (this.Timescale?.Equals(other.Timescale) == true)) &&
                ((this.IndexRange == null && other.IndexRange == null) || (this.IndexRange?.Equals(other.IndexRange) == true)) &&
                ((this.Initialization == null && other.Initialization == null) || (this.Initialization?.Equals(other.Initialization) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Timescale = {(this.Timescale == null ? "null" : this.Timescale.ToString())}");
            toStringOutput.Add($"this.IndexRange = {(this.IndexRange == null ? "null" : this.IndexRange == string.Empty ? "" : this.IndexRange)}");
            toStringOutput.Add($"this.Initialization = {(this.Initialization == null ? "null" : this.Initialization.ToString())}");
        }
    }
}