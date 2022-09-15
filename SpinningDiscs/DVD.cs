using System;
namespace SpinningDiscs
{
    public class DVD: BaseDisc
    {
        public bool IsVideo { get; set; }
        public DVD(string name, int storageCap, int speed, string content) : base(name, storageCap, speed, content)
        {
            IsVideo = true;
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
