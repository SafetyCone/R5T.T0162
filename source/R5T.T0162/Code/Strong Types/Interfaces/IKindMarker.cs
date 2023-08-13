using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0162
{
    /// <summary>
    /// Strongly-types a character as a member identity name kind-marker.
    /// <para><inheritdoc cref="Documentation.See_IDStringsInMSDocs" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IKindMarker : IStrongTypeMarker,
        ITyped<char>
    {
    }
}