﻿#pragma checksum "..\..\..\Windows\ErrorWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB91A7A266EE39353022DD9D1D8D8BAF9BD89125"
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
using MahApps.Metro.IconPacks;
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
    /// ErrorWindow
    /// </summary>
    public partial class ErrorWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FunnyBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RebootButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock3;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox moreInfoCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/MineRealmsLauncher;component/windows/errorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ErrorWindow.xaml"
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
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.FunnyBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CopyButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Windows\ErrorWindow.xaml"
            this.CopyButton.Click += new System.Windows.RoutedEventHandler(this.CopyButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\ErrorWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RebootButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\ErrorWindow.xaml"
            this.RebootButton.Click += new System.Windows.RoutedEventHandler(this.RebootButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 35 "..\..\..\Windows\ErrorWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 38 "..\..\..\Windows\ErrorWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 41 "..\..\..\Windows\ErrorWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.moreInfoCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

