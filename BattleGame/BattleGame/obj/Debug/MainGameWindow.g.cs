﻿#pragma checksum "..\..\MainGameWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33BBA37C4691EA7BA49C2E61B566C98DE0AA5AB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BattleGame;
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


namespace BattleGame {
    
    
    /// <summary>
    /// MainGameWindow
    /// </summary>
    public partial class MainGameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 111 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLobby;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button instrWindowButton;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button redSideSurrender;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button redSidePassTurn;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blueSideSurrender;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blueSidePassTurn;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerTb;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScoreTb;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreLbl;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label turnSideLbl;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label turnSideLblStr;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label celsiusSign;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label redSideNameLbl;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image redSideImg;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label blueSideNameLbl;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image blueSideImg;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Board;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label redSideEnergyLbl;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label darkRedEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label darkRedEnergyNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label redEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label redEnergyNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lightRedEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lightRedEnergyNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label blueSideEnergyLbl;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label darkBlueEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label darkBlueEnergyNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label blueEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label blueEnergyNumberLbl;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lightBlueEnergyEffectLbl;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\MainGameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lightBlueEnergyNumberLbl;
        
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
            System.Uri resourceLocater = new System.Uri("/BattleGame;component/maingamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainGameWindow.xaml"
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
            this.btnLobby = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\MainGameWindow.xaml"
            this.btnLobby.Click += new System.Windows.RoutedEventHandler(this.BtnLobby_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\MainGameWindow.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.BtnReset_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.instrWindowButton = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\MainGameWindow.xaml"
            this.instrWindowButton.Click += new System.Windows.RoutedEventHandler(this.InstrWindowButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.redSideSurrender = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\MainGameWindow.xaml"
            this.redSideSurrender.Click += new System.Windows.RoutedEventHandler(this.RedSideSurrender_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.redSidePassTurn = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\MainGameWindow.xaml"
            this.redSidePassTurn.Click += new System.Windows.RoutedEventHandler(this.RedSidePassTurn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.blueSideSurrender = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\MainGameWindow.xaml"
            this.blueSideSurrender.Click += new System.Windows.RoutedEventHandler(this.BlueSideSurrender_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.blueSidePassTurn = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\MainGameWindow.xaml"
            this.blueSidePassTurn.Click += new System.Windows.RoutedEventHandler(this.BlueSidePassTurn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TimerTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ScoreTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.scoreLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.turnSideLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.turnSideLblStr = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.celsiusSign = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.redSideNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.redSideImg = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.blueSideNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.blueSideImg = ((System.Windows.Controls.Image)(target));
            return;
            case 18:
            this.Board = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 19:
            this.redSideEnergyLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.darkRedEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.darkRedEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.redEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 23:
            this.redEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 24:
            this.lightRedEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.lightRedEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 26:
            this.blueSideEnergyLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 27:
            this.darkBlueEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 28:
            this.darkBlueEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.blueEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 30:
            this.blueEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 31:
            this.lightBlueEnergyEffectLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 32:
            this.lightBlueEnergyNumberLbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

