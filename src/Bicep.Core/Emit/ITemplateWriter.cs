// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Bicep.Core.Emit
{
    public interface ITemplateWriter
    {
        void Write(SourceAwareJsonTextWriter writer);
    }
}
