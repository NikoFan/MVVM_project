﻿#pragma checksum "..\..\..\View\RegistrationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73AD64BB9EB5008CA5BFEA81C97109A8B3607302989A61837693053B5BE45F8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MVVM.View;
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


namespace MVVM.View {
    
    
    /// <summary>
    /// RegistrationWindow
    /// </summary>
    public partial class RegistrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MVVM.View.RegistrationWindow Reg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border NameRegistrationPlace;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNameInputHint;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerNameInput;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MailRegistrationPlace;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerMailInput;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PasswordRegistrationPlace;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox CustomerPasswordInput;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border RegistartionButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MVVM;component/view/registrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\RegistrationWindow.xaml"
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
            this.Reg = ((MVVM.View.RegistrationWindow)(target));
            return;
            case 2:
            this.NameRegistrationPlace = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.UserNameInputHint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CustomerNameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MailRegistrationPlace = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.CustomerMailInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PasswordRegistrationPlace = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.CustomerPasswordInput = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.RegistartionButton = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

