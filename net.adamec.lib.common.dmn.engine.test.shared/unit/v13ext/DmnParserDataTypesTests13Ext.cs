﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserDataTypesTests13Ext: DmnParserDataTypesTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
