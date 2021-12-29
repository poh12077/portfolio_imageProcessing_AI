﻿#pragma checksum "..\..\ConvolutionalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76D42112898D6BDA0D5F6956BF34C08EB92E58B25EFB092C6E8847D69AED5892"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImageProcessingWPF;
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


namespace ImageProcessingWPF {
    
    
    /// <summary>
    /// ConvolutionalWindow
    /// </summary>
    public partial class ConvolutionalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Brightness;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sobel_x;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sobel_y;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button laplacian_1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button laplacian_2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button low_pass;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ConvolutionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button high_pass;
        
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
            System.Uri resourceLocater = new System.Uri("/ImageProcessingWPF;component/convolutionalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConvolutionalWindow.xaml"
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
            this.Brightness = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.sobel_x = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ConvolutionalWindow.xaml"
            this.sobel_x.Click += new System.Windows.RoutedEventHandler(this.InverseClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sobel_y = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.laplacian_1 = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.laplacian_2 = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.low_pass = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.high_pass = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

