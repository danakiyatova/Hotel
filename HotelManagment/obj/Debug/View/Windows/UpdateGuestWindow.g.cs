﻿#pragma checksum "..\..\..\..\View\Windows\UpdateGuestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E60662337CA5731010645E48DA5DAC06FF71D8970C35A69D4D4471CF8CF5FA9"
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
    /// UpdateGuestWindow
    /// </summary>
    public partial class UpdateGuestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertSurname;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertPatronymic;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertPSeries;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InsertPNumber;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenderCB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateGuest;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelManagment;component/view/windows/updateguestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
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
            this.InsertSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.InsertName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InsertPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.InsertPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.InsertPSeries = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.InsertPNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.GenderCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BtnUpdateGuest = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\View\Windows\UpdateGuestWindow.xaml"
            this.BtnUpdateGuest.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateGuest_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

