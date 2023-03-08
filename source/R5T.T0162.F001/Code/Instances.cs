using System;


namespace R5T.T0162.F001
{
    public static class Instances
    {
        public static Z000.IMemberKindMarkers MemberKindMarkers => Z000.MemberKindMarkers.Instance;
        public static IMemberKindOperator MemberKindOperator => F001.MemberKindOperator.Instance;
        public static Z000.ITokenSeparators TokenSeparators => Z000.TokenSeparators.Instance;
    }
}