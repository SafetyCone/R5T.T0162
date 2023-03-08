using System;
using System.Linq;

using R5T.T0132;


namespace R5T.T0162.F001
{
    [FunctionalityMarker]
    public partial interface IMemberKindOperator : IFunctionalityMarker
    {
        private static Internal.IMemberKindOperator Internal => F001.Internal.MemberKindOperator.Instance;


        public char Get_MarkerKind_Character(string memberName)
        {
            var output = memberName.First();
            return output;
        }

        public bool Is_MethodKindMarked(string memberName)
        {
            var output = this.Is_MemberKindMarked(
                memberName,
                Instances.MemberKindMarkers.MethodKindMarker_Character);

            return output;
        }

        public bool Is_MemberKindMarked(
            string memberName,
            char memberKindMarker)
        {
            var isMemberKindMarked = this.Is_MemberKindMarked(memberName);
            if(!isMemberKindMarked)
            {
                return false;
            }

            var markerKindCharacter = this.Get_MarkerKind_Character(memberName);

            var output = markerKindCharacter == memberKindMarker;
            return output;
        }

        /// <summary>
        /// Determines if the member name is marked with a member kind. Returns true if:
        /// <list type="number">
        /// <item><inheritdoc cref="Internal.IMemberKindOperator.Is_MemberKindMarked_HasMinimumLength(string)" path="/summary"/></item>
        /// <item><inheritdoc cref="Internal.IMemberKindOperator.Is_MemberKindMarked_HasTokenSeparator(string)" path="/summary"/></item>
        /// <item><inheritdoc cref="Internal.IMemberKindOperator.Is_MemberKindMarked_HasRecognizedFirstCharacter(string)" path="/summary"/></item>
        /// </list>
        /// </summary>
        public bool Is_MemberKindMarked(string memberName)
        {
            var hasMinimumLength = Internal.Is_MemberKindMarked_HasMinimumLength(memberName);
            if(!hasMinimumLength)
            {
                return false;
            }

            var hasTokenSeparator = Internal.Is_MemberKindMarked_HasTokenSeparator(memberName);
            if(!hasTokenSeparator)
            {
                return false;
            }

            var hasRecognizedFirstCharacter = Internal.Is_MemberKindMarked_HasRecognizedFirstCharacter(memberName);
            if(!hasRecognizedFirstCharacter)
            {
                return false;
            }

            return true;
        }

        public bool Is_TypeKindMarked(string memberName)
        {
            var output = this.Is_MemberKindMarked(
                memberName,
                Instances.MemberKindMarkers.TypeKindMarker_Character);

            return output;
        }

        public string RemoveKindMark(string kindMarkedMemberName)
        {
            var output = kindMarkedMemberName[2..];
            return output;
        }
    }
}
