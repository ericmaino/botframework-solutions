﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalitySample.Responses.Cancel
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CancelStrings
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CancelStrings()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HospitalitySample.Responses.Cancel.CancelStrings", typeof(CancelStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ok, let&apos;s start over..
        /// </summary>
        public static string CANCEL_CONFIRMED
        {
            get
            {
                return ResourceManager.GetString("CANCEL_CONFIRMED", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ok, let&apos;s keep going..
        /// </summary>
        public static string CANCEL_DENIED
        {
            get
            {
                return ResourceManager.GetString("CANCEL_DENIED", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to cancel?.
        /// </summary>
        public static string CANCEL_PROMPT
        {
            get
            {
                return ResourceManager.GetString("CANCEL_PROMPT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Looks like there&apos;s nothing to cancel! Try saying &quot;help&quot; to get started..
        /// </summary>
        public static string NOTHING_TO_CANCEL
        {
            get
            {
                return ResourceManager.GetString("NOTHING_TO_CANCEL", resourceCulture);
            }
        }
    }
}
