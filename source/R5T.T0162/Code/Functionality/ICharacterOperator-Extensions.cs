using System;

using R5T.T0132;


namespace R5T.T0162.Extensions
{
    [FunctionalityMarker]
    public partial interface ICharacterOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IKindMarker"/>
        public IKindMarker ToKindMarker(char value)
        {
            var output = new KindMarker(value);
            return output;
        }
    }
}
