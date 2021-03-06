﻿using System.Xml.Linq;
using Newtonsoft.Json;

namespace Skybrud.Essentials.Xml {
    
    /// <summary>
    /// Class representing an object that was parsed from an instance of <see cref="XElement"/>.
    /// </summary>
    public class XmlObjectBase {
        
        #region Properties

        /// <summary>
        /// Gets the internal <see cref="XElement"/> the object was created from.
        /// </summary>
        [JsonIgnore]
        public XElement XElement { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Parses the specified <code>xml</code> into an instance of <see cref="XmlObjectBase"/>.
        /// </summary>
        /// <param name="xml">The instance of <see cref="XElement"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="XmlObjectBase"/>.</returns>
        protected XmlObjectBase(XElement xml) {
            XElement = xml;
        }

        #endregion

    }

}