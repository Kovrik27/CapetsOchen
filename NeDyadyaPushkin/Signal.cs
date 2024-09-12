﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapetsOchen.NeDyadyaPushkin
{
    public class Signals : INotifyPropertyChanged
    {
        protected void Signal([CallerMemberName] string caller = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
