using System;

using R5T.T0132;


namespace R5T.T0162.F001
{
    [FunctionalityMarker]
    public partial interface IKindMarkerOperator : IFunctionalityMarker
    {
        public bool Is_ValidKindMarker(char kindMarker)
        {
            var allKindMarkerCharacters = Instances.KindMarkerSets.All_Characters_Hash;

            var output = allKindMarkerCharacters.Contains(kindMarker);
            return output;
        }

        public void Verify_ValidKindMarker(char kindMarker)
        {
            var isValidKindMarker = this.Is_ValidKindMarker(kindMarker);
            if (!isValidKindMarker)
            {
                throw new Exception($"'{kindMarker}': invalid kind marker.");
            }
        }
    }
}
