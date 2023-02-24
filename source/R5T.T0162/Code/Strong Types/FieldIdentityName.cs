using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class FieldIdentityName : IdentityName, IStrongTypeMarker
    {
        public FieldIdentityName(string value)
            : base(value)
        {
        }
    }
}
