using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IFieldIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class FieldIdentityName : TypedBase<string>, IStrongTypeMarker,
        IFieldIdentityName
    {
        public FieldIdentityName(string value)
            : base(value)
        {
        }
    }
}
