using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="ITypeIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class TypeIdentityName : TypedBase<string>, IStrongTypeMarker,
        ITypeIdentityName
    {
        public TypeIdentityName(string value)
            : base(value)
        {
        }
    }
}
