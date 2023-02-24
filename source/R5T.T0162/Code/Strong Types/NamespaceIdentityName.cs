using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class NamespaceIdentityName : IdentityName, IStrongTypeMarker
    {
        public NamespaceIdentityName(string value)
            : base(value)
        {
        }
    }
}
