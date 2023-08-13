using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IIdentityNameValue"/>
    [StrongTypeImplementationMarker]
    public class IdentityNameValue : TypedBase<string>, IStrongTypeMarker,
        IIdentityNameValue
    {
        public IdentityNameValue(string value)
            : base(value)
        {
        }
    }
}