﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nMars.Screensaver.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class ScreensaverCfg : global::System.Configuration.ApplicationSettingsBase {
        
        private static ScreensaverCfg defaultInstance = ((ScreensaverCfg)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ScreensaverCfg())));
        
        public static ScreensaverCfg Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nMars.Engine")]
        public string DefaultEngine
        {
            get
            {
                return ((string)(this["DefaultEngine"]));
            }
            set
            {
                this["DefaultEngine"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nMars.Parser")]
        public string DefaultParser
        {
            get
            {
                return ((string)(this["DefaultParser"]));
            }
            set
            {
                this["DefaultParser"] = value;
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public System.Collections.Generic.List<string> KnownComponents
        {
            get
            {
                return ((System.Collections.Generic.List<string>)(this["KnownComponents"]));
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Project {
            get {
                return ((string)(this["Project"]));
            }
            set {
                this["Project"] = value;
            }
        }
    }
}