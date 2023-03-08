using System;

using R5T.T0131;


namespace R5T.T0162.Z000
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker
    {
        public string MemberKindMarkerTokenSeparator => ":";
        public char MemberKindMarkerTokenSeparator_Character => ':';
    }
}
