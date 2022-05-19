// <copyright file="Initialization.cs" company="APIMatic">
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
    /// Initialization.
    /// </summary>
    [XmlRootAttribute("Initialization")]
    public class Initialization
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Initialization"/> class.
        /// </summary>
        public Initialization()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Initialization"/> class.
        /// </summary>
        /// <param name="range">range.</param>
        public Initialization(
            string range)
        {
            this.Range = range;
        }

        /// <summary>
        /// Gets or sets Range.
        /// </summary>
        [JsonProperty("range")]
        [XmlAttribute("range")]
        public string Range { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Initialization : ({string.Join(", ", toStringOutput)})";
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

            return obj is Initialization other &&
                ((this.Range == null && other.Range == null) || (this.Range?.Equals(other.Range) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Range = {(this.Range == null ? "null" : this.Range == string.Empty ? "" : this.Range)}");
        }
    }
}