using System;
using System.Collections.Generic;

using R5T.T0131;


namespace R5T.T0162.Z000
{
    [ValuesMarker]
    public partial interface IKindMarkerSets : IValuesMarker
    {
        private static readonly Lazy<char[]> zAll_Characters = new Lazy<char[]>(() => new[]
        {
            IKindMarkers.Error_Constant,
            IKindMarkers.Event_Constant,
            IKindMarkers.Field_Constant,
            IKindMarkers.Method_Constant,
            IKindMarkers.Namespace_Constant,
            IKindMarkers.Property_Constant,
            IKindMarkers.Type_Constant,
        });

        public char[] All_Characters => zAll_Characters.Value;

        private static readonly Lazy<HashSet<char>> zAll_Characters_Hash = new Lazy<HashSet<char>>(() => new HashSet<char>(
            IKindMarkerSets.zAll_Characters.Value));

        public HashSet<char> All_Characters_Hash => zAll_Characters_Hash.Value;
    }
}
