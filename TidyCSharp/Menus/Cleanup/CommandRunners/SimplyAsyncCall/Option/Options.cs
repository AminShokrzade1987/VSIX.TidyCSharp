﻿using Geeks.VSIX.TidyCSharp.Cleanup.Infra;

namespace Geeks.VSIX.TidyCSharp.Cleanup.SimplyAsyncCall
{
    public class Options : OptionsBase, ICleanupOption
    {
        public CleanupTypes? CleanupItems => (CleanupTypes?)CleanupItemsInteger;

        protected override CodeCleanerType GetCodeCleanerType()
        {
            return CodeCleanerType.CamelCasedMethodVariable;
        }
    }
}
