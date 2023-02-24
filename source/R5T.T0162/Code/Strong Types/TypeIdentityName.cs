using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class TypeIdentityName : IdentityName, IStrongTypeMarker
    {
        public TypeIdentityName(string value)
            : base(value)
        {
        }
    }
}
