﻿#pragma checksum "..\..\ThongKeDoanhThu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A150CFFEBC56AEE3CD1569377F0EED7AA7B68E35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Management_Project;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace Management_Project {
    
    
    /// <summary>
    /// ThongKeDoanhThu
    /// </summary>
    public partial class ThongKeDoanhThu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ThongKeDoanhThu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDate;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ThongKeDoanhThu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ThongKeDoanhThu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Loc;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ThongKeDoanhThu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart lineChart;
        
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
            System.Uri resourceLocater = new System.Uri("/Management_Project;component/thongkedoanhthu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThongKeDoanhThu.xaml"
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
            this.StartDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 20 "..\..\ThongKeDoanhThu.xaml"
            this.StartDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Start_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EndDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 23 "..\..\ThongKeDoanhThu.xaml"
            this.EndDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.End_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Loc = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ThongKeDoanhThu.xaml"
            this.Loc.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lineChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

