﻿#pragma checksum "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F849D9364C0C0558618DD27796A8349ED35A3B956C6D31FF9849DBEC7C144460"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ByteBagWPF.Frontend.Views.MessageWindow.Error;
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


namespace ByteBagWPF.Frontend.Views.MessageWindow.Error {
    
    
    /// <summary>
    /// ErrorMessageWindow
    /// </summary>
    public partial class ErrorMessageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 70 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorMessageLaB;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errorTextBlock;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okBT;
        
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
            System.Uri resourceLocater = new System.Uri("/ByteBagWPF;component/frontend/views/messagewindow/error/errormessagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
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
            
            #line 15 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
            ((ByteBagWPF.Frontend.Views.MessageWindow.Error.ErrorMessageWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 142 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.errorMessageLaB = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.errorTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.okBT = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\..\..\..\..\..\Frontend\Views\MessageWindow\Error\ErrorMessageWindow.xaml"
            this.okBT.Click += new System.Windows.RoutedEventHandler(this.okBT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
