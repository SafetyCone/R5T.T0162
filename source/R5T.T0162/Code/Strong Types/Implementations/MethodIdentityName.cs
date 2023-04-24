using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IMethodIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class MethodIdentityName : TypedBase<string>, IStrongTypeMarker,
        IMethodIdentityName
    {
        public MethodIdentityName(string value)
            : base(value)
        {
        }
    }
}
