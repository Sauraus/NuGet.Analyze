﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.468
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Analyze {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AnalyzeCommandResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AnalyzeCommandResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Analyze.AnalyzeCommandResources", typeof(AnalyzeCommandResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzes package dependencies directly from a source control repository or server..
        /// </summary>
        internal static string AnalyzeCommandDescription {
            get {
                return ResourceManager.GetString("AnalyzeCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url to the source control repository or server..
        /// </summary>
        internal static string AnalyzeCommandRepositoryDescription {
            get {
                return ResourceManager.GetString("AnalyzeCommandRepositoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository specified cannot be found or is not a valid directory. Please provide a valid path to a repository folder..
        /// </summary>
        internal static string AnalyzeCommandRepositoryNotFound {
            get {
                return ResourceManager.GetString("AnalyzeCommandRepositoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository specified cannot be empty. Please provide a valid repository path..
        /// </summary>
        internal static string AnalyzeCommandRepositoryRequired {
            get {
                return ResourceManager.GetString("AnalyzeCommandRepositoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown command has been used. Please profide a valid command..
        /// </summary>
        internal static string AnalyzeCommandUnknownCommand {
            get {
                return ResourceManager.GetString("AnalyzeCommandUnknownCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Tfs | FileSystem&gt; [options].
        /// </summary>
        internal static string AnalyzeCommandUsageSummary {
            get {
                return ResourceManager.GetString("AnalyzeCommandUsageSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get more detailed output..
        /// </summary>
        internal static string AnalyzeCommandVerboseDescription {
            get {
                return ResourceManager.GetString("AnalyzeCommandVerboseDescription", resourceCulture);
            }
        }
    }
}
