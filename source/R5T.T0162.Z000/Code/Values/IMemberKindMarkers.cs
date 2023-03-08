using System;
using System.Collections.Generic;

using R5T.T0131;


namespace R5T.T0162.Z000
{
    /// <summary>
    /// Source: <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments#d42-id-string-format"/>
    /// </summary>
    [ValuesMarker]
    public partial interface IMemberKindMarkers : IValuesMarker
    {
        private readonly static Lazy<char[]> All_Characters_Internal = new Lazy<char[]>(() => new char[]
        {
            
            MemberKindMarkers.Instance.ErrorKindMarker_Character,
            MemberKindMarkers.Instance.EventKindMarker_Character,
            MemberKindMarkers.Instance.FieldKindMarker_Character,
            MemberKindMarkers.Instance.MethodKindMarker_Character,
            MemberKindMarkers.Instance.NamespaceKindMarker_Character,
            MemberKindMarkers.Instance.PropertyKindMarker_Character,
            MemberKindMarkers.Instance.TypeKindMarker_Character,
        });

        private static readonly Lazy<HashSet<char>> All_Characters_Hash_Internal = new Lazy<HashSet<char>>(() => new HashSet<char>(
            IMemberKindMarkers.All_Characters_Internal.Value));


        public char[] All_Characters => IMemberKindMarkers.All_Characters_Internal.Value;
        public HashSet<char> All_Characters_Hash => IMemberKindMarkers.All_Characters_Hash_Internal.Value;

        public string EventKindMarker => "E";
        public char EventKindMarker_Character => 'E';
        public string FieldKindMarker => "F";
        public char FieldKindMarker_Character => 'F';
        public string MethodKindMarker => "M";
        public char MethodKindMarker_Character => 'M';
        public string NamespaceKindMarker => "N";
        public char NamespaceKindMarker_Character => 'N';
        public string PropertyKindMarker => "P";
        public char PropertyKindMarker_Character => 'P';
        public string TypeKindMarker => "T";
        public char TypeKindMarker_Character => 'T';
        public string ErrorKindMarker => "!";
        public char ErrorKindMarker_Character => '!';
    }
}
