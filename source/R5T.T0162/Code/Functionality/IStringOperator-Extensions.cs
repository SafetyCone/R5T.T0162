using System;

using R5T.T0132;


namespace R5T.T0162.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IError ToError(string value)
        {
            var error = new Error(value);
            return error;
        }

        public IEventIdentityName ToEventIdentityName(string value)
        {
            var error = new EventIdentityName(value);
            return error;
        }

        public IFieldIdentityName ToFieldIdentityName(string value)
        {
            var output = new FieldIdentityName(value);
            return output;
        }

        public IIdentityName ToIdentityName(string value)
        {
            var output = new IdentityName(value);
            return output;
        }

        /// <inheritdoc cref="IIdentityNameValue"/>
        public IIdentityNameValue ToIdentityNameValue(string value)
        {
            var output = new IdentityNameValue(value);
            return output;
        }

        public IMethodIdentityName ToMethodIdentityName_WithoutValidation(string value)
        {
            var methodIdentityName = new MethodIdentityName(value);
            return methodIdentityName;
        }

        public INamespaceIdentityName ToNamespaceIdentityName(string value)
        {
            var output = new NamespaceIdentityName(value);
            return output;
        }

        public IPropertyIdentityName ToPropertyIdentityName(string value)
        {
            var output = new PropertyIdentityName(value);
            return output;
        }

        public ITypeIdentityName ToTypeIdentityName_WithoutValidation(string value)
        {
            var typeIdentityName = new TypeIdentityName(value);
            return typeIdentityName;
        }
    }
}
