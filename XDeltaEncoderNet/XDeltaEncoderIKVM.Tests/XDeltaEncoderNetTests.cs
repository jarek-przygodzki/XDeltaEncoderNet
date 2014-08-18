using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.mantlik.xdeltaencoder;

using System.IO;

namespace XDeltaEncoderIKVM.Tests
{
    [TestClass]
    public class XDeltaEncoderNetTests
    {
        [TestMethod]
        public void TestCreatePatch()
        {
            var source = @"TestData\net.jarekprzygodzki.egc_0.1.0.201408191703.jar";
            var target = @"TestData\net.jarekprzygodzki.egc_0.1.0.201408191706.jar";
            var patch  = Path.GetTempFileName();
            string[] args = { source, target, patch };
            XDeltaEncoder.main(args);
            File.Delete(patch);
        }
    }
}
