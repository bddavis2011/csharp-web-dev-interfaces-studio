using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class IOpticalDisc
    {
        public abstract void SpinDisc();
        public abstract void StoreData();
        public abstract void ReadData();
        public abstract void WriteData();
    }
}
