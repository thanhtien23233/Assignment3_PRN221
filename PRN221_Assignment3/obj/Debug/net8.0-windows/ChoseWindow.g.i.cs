﻿#pragma checksum "..\..\..\ChoseWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F3D203B55AF330E97755812849AE29F10A899AC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PRN221PE_FA22_TrialTest;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PRN221PE_FA22_TrialTest {
    
    
    /// <summary>
    /// ChoseWindow
    /// </summary>
    public partial class ChoseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\ChoseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_JobPosting;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\ChoseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CandidateProfile;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ChoseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ChoseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Logout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN221_SE1704_TranThanhTien_SE172791;V1.0.0.0;component/chosewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChoseWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btn_JobPosting = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\ChoseWindow.xaml"
            this.btn_JobPosting.Click += new System.Windows.RoutedEventHandler(this.btn_JobPosting_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_CandidateProfile = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\ChoseWindow.xaml"
            this.btn_CandidateProfile.Click += new System.Windows.RoutedEventHandler(this.btn_CandidateProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\ChoseWindow.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\ChoseWindow.xaml"
            this.btn_Logout.Click += new System.Windows.RoutedEventHandler(this.btn_Logout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
