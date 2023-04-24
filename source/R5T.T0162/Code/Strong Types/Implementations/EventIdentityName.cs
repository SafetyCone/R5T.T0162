using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <inheritdoc cref="IEventIdentityName"/>
    [StrongTypeImplementationMarker]
    public sealed class EventIdentityName : TypedBase<string>, IStrongTypeMarker,
        IEventIdentityName
    {
        public EventIdentityName(string value)
            : base(value)
        {
        }
    }
}
