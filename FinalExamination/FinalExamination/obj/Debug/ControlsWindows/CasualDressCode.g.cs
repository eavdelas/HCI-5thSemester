﻿#pragma checksum "..\..\..\ControlsWindows\CasualDressCode.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F3796C5A4CC57421F94F249B6FA3987357D82AC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalExamination.ControlsWindows;
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


namespace FinalExamination.ControlsWindows {
    
    
    /// <summary>
    /// CasualDressCode
    /// </summary>
    public partial class CasualDressCode : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PantsImage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShirtImage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ShoesImage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ShirtLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PantsLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ControlsWindows\CasualDressCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ShoesLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalExamination;component/controlswindows/casualdresscode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ControlsWindows\CasualDressCode.xaml"
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
            
            #line 9 "..\..\..\ControlsWindows\CasualDressCode.xaml"
            ((FinalExamination.ControlsWindows.CasualDressCode)(target)).Deactivated += new System.EventHandler(this.Window_Deactivated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PantsImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.ShirtImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.ShoesImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.ShirtLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PantsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ShoesLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
