﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class EndToEndTests13Ext : EndToEndTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
