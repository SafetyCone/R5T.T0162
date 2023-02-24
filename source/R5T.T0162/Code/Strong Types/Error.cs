using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// While not technically an identity string, if a referenced code element cannot be resolved, an error string is produced in place of an identity name.
    /// So its basically the "error" identity name.
    /// </summary>
    [StrongTypeMarker]
    public class Error : IdentityName, IStrongTypeMarker
    {
        public Error(string value)
            : base(value)
        {
        }
    }
}
