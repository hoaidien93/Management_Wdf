﻿#pragma checksum "..\..\Bill.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E6EC3350103615BAC54EEF787369CA503332308"
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
    /// Bill
    /// </summary>
    public partial class Bill : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ten;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Total;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListProducts;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateBill;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProduct;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox List_Products;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Bill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Qty;
        
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
            System.Uri resourceLocater = new System.Uri("/Management_Project;component/bill.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Bill.xaml"
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
            this.ID = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\Bill.xaml"
            this.ID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ten = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\Bill.xaml"
            this.Ten.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ten_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Total = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ListProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.CreateBill = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Bill.xaml"
            this.CreateBill.Click += new System.Windows.RoutedEventHandler(this.CreateBill_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Bill.xaml"
            this.AddProduct.Click += new System.Windows.RoutedEventHandler(this.AddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.List_Products = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\Bill.xaml"
            this.List_Products.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_Products_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Qty = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\Bill.xaml"
            this.Qty.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ten_Copy_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
