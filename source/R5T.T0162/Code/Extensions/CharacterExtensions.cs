using System;


namespace R5T.T0162.Extensions
{
    public static class CharacterExtensions
    {
        /// <inheritdoc cref="ICharacterOperator.ToKindMarker(char)"/>
        public static IKindMarker ToKindMarker(this char value)
        {
            return Instances.CharacterOperator_Extensions.ToKindMarker(value);
        }
    }
}
