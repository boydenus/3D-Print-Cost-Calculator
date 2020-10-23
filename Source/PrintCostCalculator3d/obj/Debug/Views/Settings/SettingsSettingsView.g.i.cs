﻿#pragma checksum "..\..\..\..\Views\Settings\SettingsSettingsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5697405DC25CFCE424CD6126A8B161EA895DE9CDA11378CFDB2E90F90E1DA6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using PrintCostCalculator3d.Converters;
using PrintCostCalculator3d.Resources.Localization;
using PrintCostCalculator3d.Validators;
using PrintCostCalculator3d.ViewModels;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace PrintCostCalculator3d.Views {
    
    
    /// <summary>
    /// SettingsSettingsView
    /// </summary>
    public partial class SettingsSettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLocation;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch ToggleSwitchIsPortable;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonResetEverything;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonResetCustom;
        
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
            System.Uri resourceLocater = new System.Uri("/3dPrintCostCalculator2;component/views/settings/settingssettingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 19 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
            ((PrintCostCalculator3d.Views.SettingsSettingsView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxLocation = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
            this.TextBoxLocation.Drop += new System.Windows.DragEventHandler(this.TextBoxLocation_Drop);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\Views\Settings\SettingsSettingsView.xaml"
            this.TextBoxLocation.PreviewDragOver += new System.Windows.DragEventHandler(this.TextBoxLocation_PreviewDragOver);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ToggleSwitchIsPortable = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 4:
            this.RadioButtonResetEverything = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.RadioButtonResetCustom = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
