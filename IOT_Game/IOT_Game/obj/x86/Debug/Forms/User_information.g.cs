﻿#pragma checksum "C:\Projects\GameApplication\IOT_Game\IOT_Game\Forms\User_information.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DA82B6A184791DF21D9BC2A14C2722A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IOT_Game.Forms
{
    partial class User_information : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Forms\User_information.xaml line 13
                {
                    this.txtFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Forms\User_information.xaml line 15
                {
                    this.txtLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Forms\User_information.xaml line 17
                {
                    this.txtUsername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Forms\User_information.xaml line 20
                {
                    this.txtPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6: // Forms\User_information.xaml line 22
                {
                    this.txtTcNo = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Forms\User_information.xaml line 23
                {
                    this.CdtDateBirth = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 8: // Forms\User_information.xaml line 24
                {
                    this.cmbGender = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9: // Forms\User_information.xaml line 29
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Forms\User_information.xaml line 31
                {
                    this.txtPhoneNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Forms\User_information.xaml line 32
                {
                    this.cmbJob = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12: // Forms\User_information.xaml line 38
                {
                    this.cmbCity = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13: // Forms\User_information.xaml line 44
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSave).Click += this.BtnSave_Click;
                }
                break;
            case 14: // Forms\User_information.xaml line 45
                {
                    this.btnExit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnExit).Click += this.BtnExit_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

