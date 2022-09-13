﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Trendyol_Test_Automation_with_Ranorex
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording3 recording.
    /// </summary>
    [TestModule("508a9782-0c8a-4087-ab98-0f9879ea1dbe", ModuleType.Recording, 1)]
    public partial class Recording3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Trendyol_Test_Automation_with_RanorexRepository repository.
        /// </summary>
        public static Trendyol_Test_Automation_with_RanorexRepository repo = Trendyol_Test_Automation_with_RanorexRepository.Instance;

        static Recording3 instance = new Recording3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording3 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap' at 22;5.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYapInfo, new RecordItemIndex(0));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.GirişYap.Click("22;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.UEyeOl2' at 18;11.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.UEyeOl2Info, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.UEyeOl2.Click("18;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmail' at 89;23.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmailInfo, new RecordItemIndex(4));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmail.Click("89;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'tren dy olranorex@gmail.com' with focus on 'EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmail'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmailInfo, new RecordItemIndex(5));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.RegisterEmail.PressKeys("tren dy olranorex@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl.HttpsWwwTrendyolComUyelikcbEqhttps.UEyeOl' at 27;4.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.HttpsWwwTrendyolComUyelikcbEqhttps.UEyeOlInfo, new RecordItemIndex(6));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl.HttpsWwwTrendyolComUyelikcbEqhttps.UEyeOl.Click("27;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 600ms.", new RecordItemIndex(7));
            Delay.Duration(600, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl.LuetfenGecerliBirEmailAdresiGiriniz'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LuetfenGecerliBirEmailAdresiGirinizInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl.LuetfenGecerliBirEmailAdresiGirinizInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
