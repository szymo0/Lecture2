﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactsApp.Domain {
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
    internal class DomainResurces {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DomainResurces() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ContactsApp.Domain.DomainResurces", typeof(DomainResurces).Assembly);
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
        ///   Looks up a localized string similar to Builder was alredy use to build object. Cannot reuse builder.
        /// </summary>
        internal static string BuilderAlreadyCreateObject {
            get {
                return ResourceManager.GetString("BuilderAlreadyCreateObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email {0} already is set as primary email address and cannot be add as alternetive.
        /// </summary>
        internal static string EmailAlreadyAddedAsPrimaryMessage {
            get {
                return ResourceManager.GetString("EmailAlreadyAddedAsPrimaryMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid format of email message {0}. Please correct email address..
        /// </summary>
        internal static string InvalidEmailAddressFormatMessage {
            get {
                return ResourceManager.GetString("InvalidEmailAddressFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid format of phone number {0}. Please correct phone number. Example phone number: (+22) 111-111-111;111-111-11.
        /// </summary>
        internal static string InvalidPhoneNumberFormatMessage {
            get {
                return ResourceManager.GetString("InvalidPhoneNumberFormatMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Phone {0} already is set as primary phone number and cannot be add as alternetive phone number.
        /// </summary>
        internal static string PhoneAlreadyAddedAsPrimaryMessage {
            get {
                return ResourceManager.GetString("PhoneAlreadyAddedAsPrimaryMessage", resourceCulture);
            }
        }
    }
}
