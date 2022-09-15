using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int StorageCap { get; set; }
        public int Speed { get; set; }
        public string Content { get; set; }

        public BaseDisc(string name, int storageCap, int speed, string content)
        {
            Name = name;
            StorageCap = storageCap;
            Speed = speed;
            Content = content;
        }
    
    }
}
