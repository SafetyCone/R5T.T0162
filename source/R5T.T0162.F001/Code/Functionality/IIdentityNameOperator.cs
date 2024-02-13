using System;

using R5T.F0000.Extensions;
using R5T.T0132;
using R5T.T0162.Extensions;
using R5T.T0162.Z000;


namespace R5T.T0162.F001
{
    [FunctionalityMarker]
    public partial interface IIdentityNameOperator : IFunctionalityMarker
    {
        public string Get_IdentityName(
            char kindMarker,
            string value)
        {
            var output = $"{kindMarker}{Instances.TokenSeparators.KindMarkerSeparator}{value}";
            return output;
        }

        /// <summary>
        /// And identity name must be at least two characters long: the first characters is the kind-marker, and the second is the kind-marker separator.
        /// Empty identity strings are allowed, as long as they have a kind-marker and kind-marker separator (i.e. are at least two characters in length).
        /// </summary>
        public bool Is_MinimumLength(string identityName)
        {
            // Choose greater-then-or-equal-to 2, to allow empty identity names (but require the kind-marker and kind-marker separator).
            var output = identityName.Length >= Instances.Values.IdentityName_MinimumLength;
            return output;
        }

        /// <summary>
        /// Identity names cannot be null.
        /// </summary>
        public bool Is_NotNull(string identityName)
        {
            var output = Instances.NullOperator.Is_NotNull(identityName);
            return output;
        }

        /// <summary>
        /// <para>Returns the portion of the identity name following the kind marker separator (the third character to the end).</para>
        /// Unchecked in the sense that no length check is performed.
        /// </summary>
        public string Get_IdentityNameValue_Unchecked(string identityName)
        {
            var output = Instances.StringOperator.Get_Substring_From_Exclusive(1, identityName);
            return output;
        }

        /// <summary>
        /// Returns the first character of the identity name, which is the kind-marker.
        /// Unchecked in the sense that:
        /// A) no check is performed to ensure the identity name is at least one character long, and
        /// B) no check is performed to ensure the kind-marker is one of the valid kind markers.
        /// </summary>
        public char Get_KindMarker_Unchecked(string identityName)
        {
            var output = identityName.Get_First();
            return output;
        }

        /// <summary>
        /// Gets the kind-marker, checking that the kind-marker is one of the valid kind markers.
        /// Unchecked in the sense that no check is performed to ensure the identity name is at least one character long.
        /// </summary>
        public char Get_KindMarker_Unchecked_CheckValidity(string identityName)
        {
            var kindMarker = this.Get_KindMarker_Unchecked(identityName);

            Instances.KindMarkerOperator.Verify_ValidKindMarker(kindMarker);

            return kindMarker;
        }

        /// <summary>
        /// Unchecked in the sense that no check is performed to ensure the identity name is at least two characters long.
        /// </summary>
        public bool Has_KindMarkerSeparator_Unchecked(string identityName)
        {
            var secondCharacter = identityName.Get_Second();

            var output = secondCharacter == Instances.TokenSeparators.KindMarkerSeparator;
            return output;
        }

        /// <summary>
        /// Unchecked in the sense that no check is performed to ensure the identity name is at least one character long.
        /// </summary>
        public bool Has_ValidKindMarker_Unchecked(string identityName)
        {
            var kindMarker = this.Get_KindMarker_Unchecked(identityName);

            var output = Instances.KindMarkerOperator.Is_ValidKindMarker(kindMarker);
            return output;
        }

        /// <summary>
        /// Checks for minimal validity by checking minimum length, and whether the identity name begins with one of the valid kind markers and has a kind-marker separator.
        /// <para>Does <strong>not</strong> check for whether the </para>
        /// </summary>
        public bool Is_MinimallyValidIdentityName(string identityName)
        {
            // Utilize short-circuiting in the && operator (the conditional logical and operator) to prevent index-out-of-range exceptions.
            var output = true
                && this.Is_NotNull(identityName)
                && this.Is_MinimumLength(identityName)
                && this.Has_KindMarkerSeparator_Unchecked(identityName)
                && this.Has_ValidKindMarker_Unchecked(identityName)
                ;

            return output;
        }

        /// <summary>
        /// Unchecked in the sense that:
        /// A) no check is performed to ensure the identity name is at least one character long, and
        /// B) no check is performed to ensure the kind-marker is one of the valid kind markers.
        /// </summary>
        public bool Is_KindMarker_Unchecked(string identityName, char kindMarker)
        {
            var actualKindMarker = this.Get_KindMarker_Unchecked(identityName);

            var output = actualKindMarker == kindMarker;
            return output;
        }

        /// <summary>
        /// Return an identity name that is actually of the identity name type specified by the kind-marker of the identity name.
        /// </summary>
        public IIdentityName ToIdentityName_OfKindMarkedType(string identityName)
        {
            var kindMarker = this.Get_KindMarker_Unchecked(identityName);

            IIdentityName output = kindMarker switch
            {
                IKindMarkers.Error_Constant => identityName.ToError(),
                IKindMarkers.Event_Constant => identityName.ToEventIdentityName(),
                IKindMarkers.Field_Constant => identityName.ToFieldIdentityName(),
                IKindMarkers.Method_Constant => identityName.ToMethodIdentityName(),
                IKindMarkers.Namespace_Constant => identityName.ToNamespaceIdentityName(),
                IKindMarkers.Property_Constant => identityName.ToPropertyIdentityName(),
                IKindMarkers.Type_Constant => identityName.ToTypeIdentityName(),
                _ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException(kindMarker.ToString(), "Kind Marker")
            };

            return output;
        }

        public void Verify_IsKindMarker(string identityName, char kindMarker)
        {
            var isKindMarker = this.Is_KindMarker_Unchecked(identityName, kindMarker);
            if (!isKindMarker)
            {
                throw new Exception($"Kind marker '{kindMarker}' not found in identity name '{identityName}'.");
            }
        }

        public void Verify_IsMinimumLength(string identityName)
        {
            var isMinimumLength = this.Is_MinimumLength(identityName);
            if (!isMinimumLength)
            {
                throw new Exception($"\"{identityName}\": identity was not the minimum length (of {Instances.Values.IdentityName_MinimumLength}).");
            }
        }
    }
}
