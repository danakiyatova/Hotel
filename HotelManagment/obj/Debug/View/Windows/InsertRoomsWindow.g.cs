﻿#pragma checksum "..\..\..\..\View\Windows\InsertRoomsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDFE2FBCDE95A07941AE32B348F9E81EB1D0E0EB025837E71B8E9BA0CAFB23BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelManagment.View.Windows;
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


namespace HotelManagment.View.Windows {
    
    
    /// <summary>
    /// InsertRoomsWindow
    /// </summary>
    public partial class InsertRoomsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertRoomName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertSeats;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertCost;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertRoomStatusID;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertRoomCategoryID;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelManagment;component/view/windows/insertroomswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
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
            this.InsertRoomName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.InsertRoomNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InsertSeats = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.InsertCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.InsertRoomStatusID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.InsertRoomCategoryID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\View\Windows\InsertRoomsWindow.xaml"
            this.BtnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

