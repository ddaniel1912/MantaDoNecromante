﻿#pragma checksum "C:\Users\Das Neves\Source\Repos\MantaDoNecromante11\MantaNecromante\ClassMenu\ClassMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24C60142EECE8D3BDA4E597C09246F52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MantaNecromante.ClassMenu
{
    partial class ClassMenu : 
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
                    this.Exit1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\ClassMenu\ClassMenu.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Exit1).Click += this.IniciarLadina;
                    #line default
                }
                break;
            case 6:
                {
                    this.voltar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\ClassMenu\ClassMenu.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.voltar).Click += this.Retornar;
                    #line default
                }
                break;
            case 7:
                {
                    this.Exit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\ClassMenu\ClassMenu.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Exit).Click += this.IniciarMago;
                    #line default
                }
                break;
            case 8:
                {
                    this.Start = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\ClassMenu\ClassMenu.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Start).Click += this.Iniciar_Gladiador;
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

