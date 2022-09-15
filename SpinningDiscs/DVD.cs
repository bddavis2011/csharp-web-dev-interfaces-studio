using System;
namespace SpinningDiscs
{
    public class DVD
    {
        public interface IDVD
        {
            double SpinDisc();
            double StorageCap();

            string DataType();

            double PitSpace();
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
