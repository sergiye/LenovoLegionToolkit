﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LenovoLegionToolkit.Lib.Automation.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LenovoLegionToolkit.Lib.Automation.Resources.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When AC power adapter is connected.
        /// </summary>
        public static string ACAdapterConnectedAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("ACAdapterConnectedAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When AC power adapter is disconnected.
        /// </summary>
        public static string ACAdapterDisconnectedAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("ACAdapterDisconnectedAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        public static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kill apps.
        /// </summary>
        public static string DeactivateGPUAutomationStepState_KillApps {
            get {
                return ResourceManager.GetString("DeactivateGPUAutomationStepState_KillApps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restart GPU.
        /// </summary>
        public static string DeactivateGPUAutomationStepState_RestartGPU {
            get {
                return ResourceManager.GetString("DeactivateGPUAutomationStepState_RestartGPU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} second.
        /// </summary>
        public static string Delay_Second {
            get {
                return ResourceManager.GetString("Delay_Second", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} seconds.
        /// </summary>
        public static string Delay_Second_Many {
            get {
                return ResourceManager.GetString("Delay_Second_Many", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When low wattage AC power adapter is connected.
        /// </summary>
        public static string LowWattageACAdapterConnectedAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("LowWattageACAdapterConnectedAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to On startup.
        /// </summary>
        public static string OnStartupAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("OnStartupAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When power mode is changed.
        /// </summary>
        public static string PowerModeAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("PowerModeAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When app is running.
        /// </summary>
        public static string ProcessesAreRunningAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("ProcessesAreRunningAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When app closes.
        /// </summary>
        public static string ProcessesStopRunningAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("ProcessesStopRunningAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At specified time.
        /// </summary>
        public static string TimeAutomationPipelineTrigger_DisplayName {
            get {
                return ResourceManager.GetString("TimeAutomationPipelineTrigger_DisplayName", resourceCulture);
            }
        }
    }
}