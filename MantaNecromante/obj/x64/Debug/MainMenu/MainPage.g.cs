﻿#pragma checksum "C:\Users\Lucas\source\repos\MantaDoNecromante\MantaNecromante\MainMenu\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "11B5E73D71E9855D7E7A82BFC2F24D8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontEnd
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.myPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.Floor = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 3:
                {
                    this.Fall = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.Exit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\MainMenu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Exit).Click += this.Sair;
                    #line default
                }
                break;
            case 6:
                {
                    this.Start = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\MainMenu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Start).Click += this.Iniciar;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

