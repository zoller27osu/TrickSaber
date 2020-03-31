﻿using System;
using System.Collections.Generic;
using System.Linq;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace TrickSaber
{
    internal class BindingsViewController : BSMLResourceViewController
    {
        public override string ResourceName => "TrickSaber.Views.BindingsView.bsml";

        [UIValue("TriggerAction-value")]
        public string UseTrigger {
            get => PluginConfig.Instance.TriggerAction;
            set => PluginConfig.Instance.TriggerAction = value;
        }

        [UIValue("GripAction-value")]
        public string GripAction
        {
            get => PluginConfig.Instance.GripAction;
            set => PluginConfig.Instance.GripAction = value;
        }

        [UIValue("ThumbAction-value")]
        public string ThumbAction
        {
            get => PluginConfig.Instance.ThumbstickAction;
            set => PluginConfig.Instance.ThumbstickAction = value;
        }

        [UIValue("ShowGripBinding")]
        public bool GripEnabled => Plugin.HeadSet!="Oculus Rift";

        [UIValue("ShowIndexText")] public bool ShowIndexText => !GripEnabled;

        [UIValue("TrickActionEnum-list")]
        public List<object> TrickActionList = Enum.GetNames(typeof(TrickAction)).ToList<object>();
    }
}