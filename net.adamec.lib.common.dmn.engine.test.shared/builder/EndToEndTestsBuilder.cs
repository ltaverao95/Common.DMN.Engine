﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.test.complex;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class EndToEndTestsBuilder : EndToEndTests
    {
        protected override SourceEnum Source => SourceEnum.Builder;
    }
}
