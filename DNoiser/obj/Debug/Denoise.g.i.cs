﻿#pragma checksum "..\..\Denoise.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F37F7834ACA32E96CF8583DC81172B126CE8587"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace DNoiser {
    
    
    /// <summary>
    /// Denoise
    /// </summary>
    public partial class Denoise : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button denoise_it;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label count_label;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label denoise_count_label;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label output_dir_label;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button output_dir_btn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Denoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox hrd_checkbox;
        
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
            System.Uri resourceLocater = new System.Uri("/DNoiser;component/denoise.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Denoise.xaml"
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
            this.denoise_it = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Denoise.xaml"
            this.denoise_it.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.denoise_it_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.count_label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.denoise_count_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.output_dir_label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.output_dir_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Denoise.xaml"
            this.output_dir_btn.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.output_dir_btn_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.hrd_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
