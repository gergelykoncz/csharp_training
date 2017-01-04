namespace CBasics.DataTypes
{
    class TypeConversions
    {
        void Conversions()
        {
            int i = 100;
            short s = (short)i;

            //The default casting allows overflows
            int i2 = int.MaxValue;
            short s2 = (short)i2; //s2 = -1

            //Use a checked block so it'll raise a runtime error
            checked
            {
                int i3 = int.MaxValue;
                short s3 = (short)i3;//this will throw an exception, because truncation would occur
            }

            //unchecked is the default in C#
            unchecked
            {
                int i3 = int.MaxValue;
                short s3 = (short)i3; //-1
            }
        }
    }
}
