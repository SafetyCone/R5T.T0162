using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class MethodIdentityName : IdentityName, IStrongTypeMarker
    {
        public MethodIdentityName(string value)
            : base(value)
        {
        }
    }
}
