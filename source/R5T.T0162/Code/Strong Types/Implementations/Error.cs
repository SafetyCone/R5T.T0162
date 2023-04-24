using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IError"/>
    [StrongTypeImplementationMarker]
    public sealed class Error : TypedBase<string>, IStrongTypeMarker,
        IError
    {
        public Error(string value)
            : base(value)
        {
        }
    }
}
