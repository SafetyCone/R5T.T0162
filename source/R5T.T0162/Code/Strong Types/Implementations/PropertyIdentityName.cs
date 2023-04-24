using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IPropertyIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class PropertyIdentityName : TypedBase<string>, IStrongTypeMarker,
        IPropertyIdentityName
    {
        public PropertyIdentityName(string value)
            : base(value)
        {
        }
    }
}
