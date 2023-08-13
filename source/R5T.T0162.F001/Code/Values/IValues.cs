using System;

using R5T.T0131;


namespace R5T.T0162.F001
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public int IdentityName_MinimumLength => 2;
    }
}
