﻿#pragma checksum "..\..\MaterialsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C5EBE5A1B91F86702128C4A373D8CBF8E62D0A1AFD54E5A82A1884592D5DE2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Master_floor;
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


namespace Master_floor {
    
    
    /// <summary>
    /// MaterialsPage
    /// </summary>
    public partial class MaterialsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProdTypeBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MaterialTypeBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Val1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Val2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProdAmountBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MaterialAmountBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MaterialsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calculate;
        
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
            System.Uri resourceLocater = new System.Uri("/Master-floor;component/materialspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MaterialsPage.xaml"
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
            this.ProdTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.MaterialTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Val1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Val2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProdAmountBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MaterialAmountBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Calculate = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MaterialsPage.xaml"
            this.Calculate.Click += new System.Windows.RoutedEventHandler(this.Calculate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

