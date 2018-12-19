/*
 * Eltoyelna Build Information
 * Author: XerShade
 * Website: http://www.xershade.ca/
 * License: GNU General Public License v3.0
 * 
 * Important Notice: Do no change the contents of this file. This file defines information that is
 * used when the engine is built and run. Changing anything in this file will result in you not getting
 * any support from me or my community! The contents of this file will be checked should you ask for support.
 */
using System;

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
        public const string Version = "1.0.0.0";
        /// <summary>
        /// Controls accessibility of an individual managed type or member, or of all types within an assembly, to COM.
        /// </summary>
        public const bool ComVisible = true;
        /// <summary>
        /// Specifies the guid for the Eltoyelna Engine.
        /// </summary>
        public static readonly Guid Guid = new Guid("0D5DCC3D-A110-4DCC-867E-25541F900856");
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

        /// <summary>
        /// Defines assembly information for the client application.
        /// </summary>
        public static class Client
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Client";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The client application for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "b5ff0bc5-a338-48c5-8378-b984c5531f01";
        }

        /// <summary>
        /// Defines assembly information for the editors library.
        /// </summary>
        public static class Editors
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Editors Library";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The editors library for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "c01798d6-ca45-4571-b56f-63d2c069bdeb";
        }

        /// <summary>
        /// Defines assembly information for the game library.
        /// </summary>
        public static class Game
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Game Library";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The game library for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "088a97b9-4084-49b3-86df-bf06fff4b948";
        }

        /// <summary>
        /// Defines assembly information for the media library.
        /// </summary>
        public static class Media
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Media Library";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The media library for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "856f509b-42a7-4563-9158-ba475613124e";
        }

        /// <summary>
        /// Defines assembly information for the network library.
        /// </summary>
        public static class Network
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Network Library";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The networking library for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "cb4b3c20-2eb2-46bb-a8da-4fae10171e72";
        }

        /// <summary>
        /// Defines assembly information for the server application.
        /// </summary>
        public static class Server
        {
            /// <summary>
            /// Specifies a description for the assembly.
            /// </summary>
            public const string Title = Product + " Server";
            /// <summary>
            /// Provides a text description for the assembly.
            /// </summary>
            public const string Description = "The server application for the " + Product + " engine.";
            /// <summary>
            /// Specifies the guid for the assembly.
            /// </summary>
            public const string Guid = "2e3b7724-1e9b-4117-ba93-bc01710b5535";
        }
    }
}