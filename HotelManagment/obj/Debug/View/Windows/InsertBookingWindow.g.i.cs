﻿#pragma checksum "..\..\..\..\View\Windows\InsertBookingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58C4B0A1A3458C4653C80BE25A4CF7A4BFAD8063FC13D7EE289EAE8C4BD3AAC3"
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
    /// InsertBookingWindow
    /// </summary>
    public partial class InsertBookingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertGuestID;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker InsertBookingDate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertDuration;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertId_room;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertAmount;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertHotelAdminID;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddBooking;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelManagment;component/view/windows/insertbookingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
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
            this.InsertGuestID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.InsertBookingDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.InsertDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.InsertId_room = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.InsertAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.InsertHotelAdminID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnAddBooking = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\View\Windows\InsertBookingWindow.xaml"
            this.BtnAddBooking.Click += new System.Windows.RoutedEventHandler(this.BtnAddBooking_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

