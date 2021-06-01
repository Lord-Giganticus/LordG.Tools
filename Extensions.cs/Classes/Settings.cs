using System;
using System.Collections.Generic;
using System.Text;

namespace LordG.Tools.Extensions.Classes
{
    public abstract class SettingsBase
    {
        public abstract object this[string item] { get; set; }

        public abstract void Save();

        public abstract void Reload();

        public abstract void Upgrade();
    }
}
