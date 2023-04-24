using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="INamespaceIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class NamespaceIdentityName : TypedBase<string>, IStrongTypeMarker,
        INamespaceIdentityName
    {
        public NamespaceIdentityName(string value)
            : base(value)
        {
        }
    }
}
