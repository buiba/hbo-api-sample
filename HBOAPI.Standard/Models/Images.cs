// <copyright file="Images.cs" company="APIMatic">
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
    /// Images.
    /// </summary>
    [XmlRootAttribute("Images")]
    public class Images
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Images"/> class.
        /// </summary>
        public Images()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Images"/> class.
        /// </summary>
        /// <param name="tile">tile.</param>
        /// <param name="tilezoom">tilezoom.</param>
        /// <param name="tileburnedin">tileburnedin.</param>
        public Images(
            string tile,
            string tilezoom,
            string tileburnedin)
        {
            this.Tile = tile;
            this.Tilezoom = tilezoom;
            this.Tileburnedin = tileburnedin;
        }

        /// <summary>
        /// Gets or sets Tile.
        /// </summary>
        [JsonProperty("tile")]
        [XmlElement("tile")]
        public string Tile { get; set; }

        /// <summary>
        /// Gets or sets Tilezoom.
        /// </summary>
        [JsonProperty("tilezoom")]
        [XmlElement("tilezoom")]
        public string Tilezoom { get; set; }

        /// <summary>
        /// Gets or sets Tileburnedin.
        /// </summary>
        [JsonProperty("tileburnedin")]
        [XmlElement("tileburnedin")]
        public string Tileburnedin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Images : ({string.Join(", ", toStringOutput)})";
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

            return obj is Images other &&
                ((this.Tile == null && other.Tile == null) || (this.Tile?.Equals(other.Tile) == true)) &&
                ((this.Tilezoom == null && other.Tilezoom == null) || (this.Tilezoom?.Equals(other.Tilezoom) == true)) &&
                ((this.Tileburnedin == null && other.Tileburnedin == null) || (this.Tileburnedin?.Equals(other.Tileburnedin) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tile = {(this.Tile == null ? "null" : this.Tile == string.Empty ? "" : this.Tile)}");
            toStringOutput.Add($"this.Tilezoom = {(this.Tilezoom == null ? "null" : this.Tilezoom == string.Empty ? "" : this.Tilezoom)}");
            toStringOutput.Add($"this.Tileburnedin = {(this.Tileburnedin == null ? "null" : this.Tileburnedin == string.Empty ? "" : this.Tileburnedin)}");
        }
    }
}