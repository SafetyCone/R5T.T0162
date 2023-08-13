using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <summary>
    /// Strongly-types a string as the value of an identity name.
    /// </summary>
    [StrongTypeMarker]
    public interface IIdentityNameValue : IStrongTypeMarker,
        ITyped<string>
    {
    }
}