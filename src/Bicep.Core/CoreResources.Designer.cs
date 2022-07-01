//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.Core {
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    ///   This class was generated by MSBuild using the GenerateResource task.
    ///   To add or remove a member, edit your .resx file then rerun MSBuild.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "15.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CoreResources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.Core.CoreResources", typeof(CoreResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Property &apos;adminUserName&apos; should not use a literal value. Use a param instead..
        /// </summary>
        internal static string AdminUsernameShouldNotBeLiteralRuleDescription {
            get {
                return ResourceManager.GetString("AdminUsernameShouldNotBeLiteralRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom bicepconfig.json file found ({0})..
        /// </summary>
        internal static string BicepConfigCustomSettingsFoundFormatMessage {
            get {
                return ResourceManager.GetString("BicepConfigCustomSettingsFoundFormatMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No bicepconfig.json found for configuration override..
        /// </summary>
        internal static string BicepConfigNoCustomSettingsMessage {
            get {
                return ResourceManager.GetString("BicepConfigNoCustomSettingsMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Environment URLs should not be hardcoded. Use the environment() function to ensure compatibility across clouds..
        /// </summary>
        internal static string EnvironmentUrlHardcodedRuleDescription {
            get {
                return ResourceManager.GetString("EnvironmentUrlHardcodedRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation: {0}..
        /// </summary>
        internal static string InterpolateNotConcatFixTitle {
            get {
                return ResourceManager.GetString("InterpolateNotConcatFixTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Use string interpolation instead of the concat function..
        /// </summary>
        internal static string InterpolateNotConcatRuleDescription {
            get {
                return ResourceManager.GetString("InterpolateNotConcatRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Linter is disabled in settings file located at {0} .
        /// </summary>
        internal static string LinterDisabledFormatMessage {
            get {
                return ResourceManager.GetString("LinterDisabledFormatMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Analyzer &apos;{0}&apos; encountered an unexpected exception. {1}.
        /// </summary>
        internal static string LinterRuleExceptionMessageFormat {
            get {
                return ResourceManager.GetString("LinterRuleExceptionMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resource location should be specified by a parameter without a default value or one that defaults to &apos;global&apos; or resourceGroup().location..
        /// </summary>
        internal static string LocationSetByParameterRuleDescription {
            get {
                return ResourceManager.GetString("LocationSetByParameterRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Maximum number of outputs used..
        /// </summary>
        internal static string MaxNumberOutputsRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberOutputsRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Too many outputs. Number of outputs is limited to {0}..
        /// </summary>
        internal static string MaxNumberOutputsRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberOutputsRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Maximum number of parameters used..
        /// </summary>
        internal static string MaxNumberParametersRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberParametersRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Too many parameters. Number of parameters is limited to {0}..
        /// </summary>
        internal static string MaxNumberParametersRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberParametersRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Maximum number of resources used..
        /// </summary>
        internal static string MaxNumberResourcesRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberResourcesRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Too many resources. Number of resources is limited to {0}..
        /// </summary>
        internal static string MaxNumberResourcesRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberResourcesRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Maximum number of variables used..
        /// </summary>
        internal static string MaxNumberVariablesRuleDescription {
            get {
                return ResourceManager.GetString("MaxNumberVariablesRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Too many variables. Number of variables is limited to {0}..
        /// </summary>
        internal static string MaxNumberVariablesRuleMessageFormat {
            get {
                return ResourceManager.GetString("MaxNumberVariablesRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A resource location should not use a hard-coded string or variable value. Change variable &apos;{0}&apos; into a parameter instead..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorChangeVarToParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorChangeVarToParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; may be used as a resource location in the module and should not be assigned a hard-coded string or variable value..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorForModuleParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorForModuleParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A resource location should not use a hard-coded string or variable value..
        /// </summary>
        internal static string NoHardcodedLocation_ErrorForResourceLocation {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorForResourceLocation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Please use a parameter value, an expression, or the string &apos;{0}&apos;. Found: &apos;{1}&apos;.
        /// </summary>
        internal static string NoHardcodedLocation_ErrorSolution {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ErrorSolution", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Change variable &apos;{0}&apos; into a parameter instead.
        /// </summary>
        internal static string NoHardcodedLocation_FixChangeVarToParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_FixChangeVarToParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Create new parameter &apos;{0}&apos; with default value {1}.
        /// </summary>
        internal static string NoHardcodedLocation_FixNewParam {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_FixNewParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; of module &apos;{1}&apos; isn&apos;t assigned an explicit value, and its default value may not give the intended behavior for a location-related parameter. You should assign an explicit value to the parameter..
        /// </summary>
        internal static string NoHardcodedLocation_ModuleLocationNeedsExplicitValue {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ModuleLocationNeedsExplicitValue", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A resource location should be either an expression or the string &apos;{0}&apos;. Found &apos;{1}&apos;.
        /// </summary>
        internal static string NoHardcodedLocation_ResourceLocationShouldBeExpressionOrGlobal {
            get {
                return ResourceManager.GetString("NoHardcodedLocation_ResourceLocationShouldBeExpressionOrGlobal", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A resource&apos;s location should not use a hard-coded string or variable value. It should use a parameter, an expression, or the string &apos;global&apos;..
        /// </summary>
        internal static string NoHardcodedLocationRuleDescription {
            get {
                return ResourceManager.GetString("NoHardcodedLocationRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Functions resourceGroup().location and deployment().location should only be used as the default value of a parameter..
        /// </summary>
        internal static string NoLocExprOutsideParamsRuleDescription {
            get {
                return ResourceManager.GetString("NoLocExprOutsideParamsRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Use a parameter here instead of &apos;{0}&apos;. &apos;resourceGroup().location&apos; and &apos;deployment().location&apos; should only be used as a default value for parameters..
        /// </summary>
        internal static string NoLocExprOutsideParamsRuleError {
            get {
                return ResourceManager.GetString("NoLocExprOutsideParamsRuleError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No unnecessary dependsOn..
        /// </summary>
        internal static string NoUnnecessaryDependsOnRuleDescription {
            get {
                return ResourceManager.GetString("NoUnnecessaryDependsOnRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary dependsOn entry &apos;{0}&apos;..
        /// </summary>
        internal static string NoUnnecessaryDependsOnRuleMessage {
            get {
                return ResourceManager.GetString("NoUnnecessaryDependsOnRuleMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to function &apos;{0}&apos;.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsFunction {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsFunction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} Found possible secret: {1}.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsMessageFormat {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to output name &apos;{0}&apos; suggests a secret.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsOutputName {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsOutputName", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Outputs should not contain secrets..
        /// </summary>
        internal static string OutputsShouldNotContainSecretsRuleDescription {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to secure parameter &apos;{0}&apos;.
        /// </summary>
        internal static string OutputsShouldNotContainSecretsSecureParam {
            get {
                return ResourceManager.GetString("OutputsShouldNotContainSecretsSecureParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to All parameters must be used..
        /// </summary>
        internal static string ParameterMustBeUsedRuleDescription {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; is declared but never used..
        /// </summary>
        internal static string ParameterMustBeUsedRuleMessageFormat {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to function &apos;{0}&apos;.
        /// </summary>
        internal static string PossibleSecretMessageFunction {
            get {
                return ResourceManager.GetString("PossibleSecretMessageFunction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to secure parameter &apos;{0}&apos;.
        /// </summary>
        internal static string PossibleSecretMessageSecureParam {
            get {
                return ResourceManager.GetString("PossibleSecretMessageSecureParam", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove quotes from property name &apos;{0}&apos;..
        /// </summary>
        internal static string PreferUnquotedPropertyNamesDeclarationFixTitle {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNamesDeclarationFixTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Replace array syntax with &apos;{0}&apos;..
        /// </summary>
        internal static string PreferUnquotedPropertyNamesDereferenceFixTitle {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNamesDereferenceFixTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Property names that are valid identifiers should be declared without quotation marks and accessed using dot notation..
        /// </summary>
        internal static string PreferUnquotedPropertyNamesRuleDescription {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNamesRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Property names that are valid identifiers should be declared without quotation marks and accessed using dot notation..
        /// </summary>
        internal static string PreferUnquotedPropertyNamesRuleDescription {
            get {
                return ResourceManager.GetString("PreferUnquotedPropertyNamesRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use protectedSettings for commandToExecute secrets.
        /// </summary>
        internal static string ProtectCommandToExecuteSecretsRuleDescription {
            get {
                return ResourceManager.GetString("ProtectCommandToExecuteSecretsRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Use protectedSettings for commandToExecute secrets. Found possible secret: {0}.
        /// </summary>
        internal static string ProtectCommandToExecuteSecretsRuleMessage {
            get {
                return ResourceManager.GetString("ProtectCommandToExecuteSecretsRuleMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove insecure default value..
        /// </summary>
        internal static string SecureParameterDefaultFixTitle {
            get {
                return ResourceManager.GetString("SecureParameterDefaultFixTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Secure parameters should not have hardcoded defaults (except for empty or newGuid())..
        /// </summary>
        internal static string SecureParameterDefaultRuleDescription {
            get {
                return ResourceManager.GetString("SecureParameterDefaultRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary string interpolation..
        /// </summary>
        internal static string SimplifyInterpolationFixTitle {
            get {
                return ResourceManager.GetString("SimplifyInterpolationFixTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove unnecessary string interpolation..
        /// </summary>
        internal static string SimplifyInterpolationRuleDescription {
            get {
                return ResourceManager.GetString("SimplifyInterpolationRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to All variables must be used..
        /// </summary>
        internal static string UnusedVariableRuleDescription {
            get {
                return ResourceManager.GetString("UnusedVariableRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Variable &quot;{0}&quot; is declared but never used..
        /// </summary>
        internal static string UnusedVariableRuleMessageFormat {
            get {
                return ResourceManager.GetString("UnusedVariableRuleMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Use recent API versions.
        /// </summary>
        internal static string UseRecentApiVersionRuleDescription {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use recent API version {0}.
        /// </summary>
        internal static string UseRecentApiVersionRuleMessageFormat {
            get {
                return ResourceManager.GetString("UseRecentApiVersionRuleMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machines shouldn&apos;t use preview images..
        /// </summary>
        internal static string UseStableVMImage {
            get {
                return ResourceManager.GetString("UseStableVMImage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Virtual machines shouldn&apos;t use preview images. Use stable version in imageReference property &quot;{0}&quot;..
        /// </summary>
        internal static string UseStableVMImageRuleFixMessageFormat {
            get {
                return ResourceManager.GetString("UseStableVMImageRuleFixMessageFormat", resourceCulture);
            }
        }
    }
}
