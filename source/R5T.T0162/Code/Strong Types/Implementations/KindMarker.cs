using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IKindMarker"/>
    [StrongTypeImplementationMarker]
    public class KindMarker : TypedBase<char>, IStrongTypeMarker,
        IKindMarker
    {
        public KindMarker(char value)
            : base(value)
        {
        }
    }
}