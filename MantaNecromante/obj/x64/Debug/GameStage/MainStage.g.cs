﻿#pragma checksum "C:\Users\paulo\source\repos\RPG\MantaDoNecromante\MantaNecromante\GameStage\MainStage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "01E759DC02961556947F8CDF117E7B4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MantaNecromante.GameStage
{
    partial class MainStage : 
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
                    this.Floor = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 2:
                {
                    this.Mansion = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.OptionsMenu = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.quick_menu = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.Nothing = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.Start = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\GameStage\MainStage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Start).Click += this.Continue;
                    #line default
                }
                break;
            case 7:
                {
                    this.ExitGame = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\GameStage\MainStage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ExitGame).Click += this.Exit;
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

