using System;
using System.Linq;
using R5T.T0132;


namespace R5T.T0162.F001.Internal
{
    [FunctionalityMarker]
    public partial interface IMemberKindOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Is the member name at least two characters long, to allow for the member kind marker character and member kind marker token separator character?
        /// </summary>
        public bool Is_MemberKindMarked_HasMinimumLength(string memberName)
        {
            var length = memberName.Length;

            // Allow empty member names, so just test if length is 2 or greater.
            var isMinimumLength = length > 1;
            return isMinimumLength;
        }

        /// <summary>
        /// Is the second character the member kind marker token separtor (":")?
        /// </summary>
        public bool Is_MemberKindMarked_HasTokenSeparator(string memberName)
        {
            var secondCharacter = memberName.Second();

            var output = Instances.TokenSeparators.KindMarkerSeparator == secondCharacter;
            return output;
        }

        /// <summary>
        /// Is the first character one of the recognized member kind markers?
        /// </summary>
        public bool Is_MemberKindMarked_HasRecognizedFirstCharacter(string memberName)
        {
            var possibleMarkerKindCharacter = Instances.MemberKindOperator.Get_MarkerKind_Character(memberName);

            var allMarkersHash = Instances.KindMarkerSets.All_Characters_Hash;

            var output = allMarkersHash.Contains(possibleMarkerKindCharacter);
            return output;
        }
    }
}
