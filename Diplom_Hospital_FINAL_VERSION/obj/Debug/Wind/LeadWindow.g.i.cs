﻿#pragma checksum "..\..\..\Wind\LeadWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F26BDCE2D7E09B8C12A7AADDB04ACE4F1C0827BB9302CFFB7631CFC2B5DF752"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom_Hospital;
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


namespace Diplom_Hospital {
    
    
    /// <summary>
    /// LeadWindow
    /// </summary>
    public partial class LeadWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrders;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMakeReceipts;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOfReceipts;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogWriteOff;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Wind\LeadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMainPage;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom_Hospital;component/wind/leadwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Wind\LeadWindow.xaml"
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
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.btnOrders = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Wind\LeadWindow.xaml"
            this.btnOrders.Click += new System.Windows.RoutedEventHandler(this.btnOrders_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMakeReceipts = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Wind\LeadWindow.xaml"
            this.btnMakeReceipts.Click += new System.Windows.RoutedEventHandler(this.btnMakeReceipts_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLogOfReceipts = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Wind\LeadWindow.xaml"
            this.btnLogOfReceipts.Click += new System.Windows.RoutedEventHandler(this.btnLogOfReceipts_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogWriteOff = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Wind\LeadWindow.xaml"
            this.btnLogWriteOff.Click += new System.Windows.RoutedEventHandler(this.btnLogWriteOff_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMainPage = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Wind\LeadWindow.xaml"
            this.btnMainPage.Click += new System.Windows.RoutedEventHandler(this.btnMainPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
