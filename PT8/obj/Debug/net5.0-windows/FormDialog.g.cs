﻿#pragma checksum "..\..\..\FormDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F926E0B1A0D7B0FBAAF5CA607D632154F4D29BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using PT8;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PT8 {
    
    
    /// <summary>
    /// FormDialog
    /// </summary>
    public partial class FormDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FileRB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DirectoryRB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ReadOnlyCB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ArchiveCB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HiddenCB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SystemCB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OKbutton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\FormDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelbutton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PT8;component/formdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FormDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.fileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FileRB = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.DirectoryRB = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.ReadOnlyCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.ArchiveCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.HiddenCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.SystemCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.OKbutton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\FormDialog.xaml"
            this.OKbutton.Click += new System.Windows.RoutedEventHandler(this.OKButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Cancelbutton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\FormDialog.xaml"
            this.Cancelbutton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
