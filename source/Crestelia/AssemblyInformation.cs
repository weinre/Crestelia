/*
 * Crestelia Build Information
 * Author: XerShade
 * Website: http://www.xershade.ca/
 * License: GNU General Public License v3.0
 * 
 * Important Notice: Do no change the contents of this file. This file defines information that is
 * used when the engine is built and run. Changing anything in this file will result in you not getting
 * any support from me or my community! The contents of this file will be checked should you ask for support.
 */

namespace Crestelia
{
    /// <summary>
    /// AssemblyInfo class, defines assembly information constants.
    /// </summary>
    public static class AssemblyInformation
    {
        /// <summary>
        /// Defines a product name custom attribute for an assembly manifest.
        /// </summary>
        public const string Product = "Crestelia";
        /// <summary>
        /// Defines a company name custom attribute for an assembly manifest.
        /// </summary>
        public const string Company = "XerShade's Corner";
        /// <summary>
        /// Defines a copyright custom attribute for an assembly manifest.
        /// </summary>
        public const string Copyright = "Copyright © " + Company + " 2018";
        /// <summary>
        /// Specifies which culture the assembly supports.
        /// </summary>
        public const string Culture = "en-CA";
        /// <summary>
        /// Specifies the version of the assemblies.
        /// </summary>
        public const string Version = "1.0.1";
        /// <summary>
        /// Controls accessibility of an individual managed type or member, or of all types within an assembly, to COM.
        /// </summary>
        public const bool ComVisible = true;
        /// <summary>
        /// Defines the name of the author of the assemblies.
        /// </summary>
        public const string Author = "XerShade";
        /// <summary>
        /// Defines the url of the author of the assemblies.
        /// </summary>
        public const string Website = "http://www.xershade.ca/";

        /// <summary>
        /// Defines assembly information for the core library.
        /// </summary>
        public static class Crestelia
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product;
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = Product + " is an image splitting, and eventually merging, program made in C# using SFML.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "df84d390-a3b2-4cb0-a2cd-cc5834a9637b";
        }
    }
}