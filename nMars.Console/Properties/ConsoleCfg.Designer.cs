﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nMars.Console.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class ConsoleCfg : global::System.Configuration.ApplicationSettingsBase {
        
        private static ConsoleCfg defaultInstance = ((ConsoleCfg)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ConsoleCfg())));
        
        public static ConsoleCfg Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nMars.Engine")]
        public string DefaultEngine {
            get {
                return ((string)(this["DefaultEngine"]));
            }
            set {
                this["DefaultEngine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nMars.Parser")]
        public string DefaultParser {
            get {
                return ((string)(this["DefaultParser"]));
            }
            set {
                this["DefaultParser"] = value;
            }
        }
    }
}
