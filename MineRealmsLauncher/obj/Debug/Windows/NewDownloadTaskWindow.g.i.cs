﻿#pragma checksum "..\..\..\Windows\NewDownloadTaskWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79F2680EBD0649B57CC2E6516E9AAE3D288E2B37"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MineRealmsLauncher.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MineRealmsLauncher.Windows {
    
    
    /// <summary>
    /// NewDownloadTaskWindow
    /// </summary>
    public partial class NewDownloadTaskWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid versionListDataGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox verToInstallForgeComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid forgeListDataGrid;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox verToInstallLiteComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid liteloaderListDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MineRealmsLauncher;component/windows/newdownloadtaskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((MineRealmsLauncher.Windows.NewDownloadTaskWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.versionListDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 32 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DownloadVerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 35 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshVerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.verToInstallForgeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            this.verToInstallForgeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VerToInstallForgeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.forgeListDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 56 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DownloadForgeButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 58 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshForgeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.verToInstallLiteComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            this.verToInstallLiteComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VerToInstallLiteComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.liteloaderListDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 74 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DownloadLiteloaderButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 76 "..\..\..\Windows\NewDownloadTaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefresLiteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

