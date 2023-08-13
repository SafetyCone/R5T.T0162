using System;


namespace R5T.T0162.F001
{
    public static class Instances
    {
        public static IKindMarkerOperator KindMarkerOperator => F001.KindMarkerOperator.Instance;
        public static Z000.IKindMarkers KindMarkers => Z000.KindMarkers.Instance;
        public static Z000.IKindMarkerSets KindMarkerSets => Z000.KindMarkerSets.Instance;
        public static IMemberKindOperator MemberKindOperator => F001.MemberKindOperator.Instance;
        public static F0000.INullOperator NullOperator => F0000.NullOperator.Instance;
        public static F0000.IStringOperator StringOperator => F0000.StringOperator.Instance;
        public static F0000.ISwitchOperator SwitchOperator => F0000.SwitchOperator.Instance;
        public static Z000.ITokenSeparators TokenSeparators => Z000.TokenSeparators.Instance;
        public static IValues Values => F001.Values.Instance;
    }
}