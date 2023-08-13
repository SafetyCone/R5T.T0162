using System;


namespace R5T.T0162.Extensions
{
    public static class StringExtensions
    {
        public static IError ToError(this string value)
        {
            return Instances.StringOperator_Extensions.ToError(value);
        }

        public static IEventIdentityName ToEventIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToEventIdentityName(value);
        }

        public static IFieldIdentityName ToFieldIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToFieldIdentityName(value);
        }

        public static IIdentityName ToIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToIdentityName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToIdentityNameValue(string)"/>
        public static IIdentityNameValue ToIdentityNameValue(this string value)
        {
            return Instances.StringOperator_Extensions.ToIdentityNameValue(value);
        }

        public static IMethodIdentityName ToMethodIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToMethodIdentityName_WithoutValidation(value);
        }

        public static INamespaceIdentityName ToNamespaceIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToNamespaceIdentityName(value);
        }

        public static IPropertyIdentityName ToPropertyIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToPropertyIdentityName(value);
        }

        public static ITypeIdentityName ToTypeIdentityName(this string value)
        {
            return Instances.StringOperator_Extensions.ToTypeIdentityName_WithoutValidation(value);
        }
    }
}
