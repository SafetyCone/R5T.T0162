using System;


namespace R5T.T0162.Extensions
{
    public static class StringExtensions
    {
        public static IdentityName ToIdentityName(this string value)
        {
            return Instances.StringOperator.ToIdentityName(value);
        }

        public static MethodIdentityName ToMethodIdentityName(this string value)
        {
            return Instances.StringOperator.ToMethodIdentityName_WithoutValidation(value);
        }

        public static TypeIdentityName ToTypeIdentityName(this string value)
        {
            return Instances.StringOperator.ToTypeIdentityName_WithoutValidation(value);
        }
    }
}
