﻿#pragma checksum "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CE241458CC92666435BBCA4F7B539AB69251D932"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IntercityTransportation.Windows.Voyages;
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


namespace IntercityTransportation.Windows.Voyages {
    
    
    /// <summary>
    /// EditVoyageWindow
    /// </summary>
    public partial class EditVoyageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DriverGrid;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VehicleGrid;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RouteGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IntercityTransportation;component/windows/voyages/editvoyagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 40 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchDriverButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DriverGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 58 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchVehicleButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.VehicleGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 76 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchRouteButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RouteGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 90 "..\..\..\..\..\Windows\Voyages\EditVoyageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveVoyageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

