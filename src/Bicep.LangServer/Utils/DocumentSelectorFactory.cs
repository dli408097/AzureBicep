// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using Bicep.Core;

namespace Bicep.LanguageServer.Utils
{
    public class DocumentSelectorFactory
    {
        public static DocumentSelector Create() => DocumentSelector.ForLanguage(
            LanguageConstants.LanguageId);

        public static DocumentSelector CreateForBicepAndParams() => DocumentSelector.ForLanguage(
            LanguageConstants.LanguageId,
            LanguageConstants.ParamsLanguageId);

        public static DocumentSelector CreateForTextDocumentSync() => DocumentSelector.ForLanguage(
            //for future: register bicepparam language id
            LanguageConstants.LanguageId,
            LanguageConstants.ParamsLanguageId,
            LanguageConstants.JsonLanguageId,
            LanguageConstants.JsoncLanguageId,
            LanguageConstants.ArmTemplateLanguageId);
    }
}

