﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYS.IO.Socket.WinFormServer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.4.140")]
        public string SYS_ServerIP
        {
            get
            {
                return ((string)(this["SYS_ServerIP"]));
            }
            set
            {
                this["SYS_ServerIP"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int SYS_ServerPort
        {
            get
            {
                return ((int)(this["SYS_ServerPort"]));
            }
            set
            {
                this["SYS_ServerPort"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\CYS\\SocketDebug\\Server\\UpLoad\\")]
        public string SYS_UpLoadPath
        {
            get
            {
                return ((string)(this["SYS_UpLoadPath"]));
            }
            set
            {
                this["SYS_UpLoadPath"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\CYS\\SocketDebug\\Server\\DownLoad\\")]
        public string SYS_DownLoadPath
        {
            get
            {
                return ((string)(this["SYS_DownLoadPath"]));
            }
            set
            {
                this["SYS_DownLoadPath"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sogou_pinyin_61e.exe")]
        public string SYS_UpLoadFName
        {
            get
            {
                return ((string)(this["SYS_UpLoadFName"]));
            }
            set
            {
                this["SYS_UpLoadFName"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SYS_DownLoadFName
        {
            get
            {
                return ((string)(this["SYS_DownLoadFName"]));
            }
            set
            {
                this["SYS_DownLoadFName"] = value;
            }
        }
    }
}
