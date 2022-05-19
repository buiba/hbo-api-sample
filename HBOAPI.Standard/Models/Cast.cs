// <copyright file="Cast.cs" company="APIMatic">
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
    /// Cast.
    /// </summary>
    [XmlRootAttribute("Cast")]
    public class Cast
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cast"/> class.
        /// </summary>
        public Cast()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cast"/> class.
        /// </summary>
        /// <param name="role">role.</param>
        /// <param name="person">person.</param>
        public Cast(
            string role,
            string person)
        {
            this.Role = role;
            this.Person = person;
        }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role")]
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets Person.
        /// </summary>
        [JsonProperty("person")]
        [XmlElement("person")]
        public string Person { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cast : ({string.Join(", ", toStringOutput)})";
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

            return obj is Cast other &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.Person == null && other.Person == null) || (this.Person?.Equals(other.Person) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role == string.Empty ? "" : this.Role)}");
            toStringOutput.Add($"this.Person = {(this.Person == null ? "null" : this.Person == string.Empty ? "" : this.Person)}");
        }
    }
}