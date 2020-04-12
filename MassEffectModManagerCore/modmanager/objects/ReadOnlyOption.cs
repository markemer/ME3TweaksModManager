﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MassEffectModManagerCore.modmanager.localizations;

namespace MassEffectModManagerCore.modmanager.objects
{
    public class ReadOnlyOption : AlternateOption, INotifyPropertyChanged
    {
        public override string Description { get; internal set; } = M3L.GetString(M3L.string_descriptionSetConfigFilesReadOnly);
        public override string FriendlyName { get; internal set; } = M3L.GetString(M3L.string_makeConfigFilesReadonly);
        public override bool CheckedByDefault => false;
        public override bool IsManual => true;
        public override bool IsAlways => false;
        public override double UIOpacity => 1;
        public override bool UIRequired => false;
        public override bool UINotApplicable => false;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}