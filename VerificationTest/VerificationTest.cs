using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VerificationTest {
    [TestClass]
    public class VerificationTest
    {
        private string appkey = "";
        private string appsecret = "";
        [TestMethod]
        public void StartVerification() {
            var client = new Sinch.Verification.Client(appkey, appsecret);
            var result = client.StartSMSVerification("+15612600684").Result;
            Assert.AreNotEqual(0, int.Parse(result.Id));
        }
        [TestMethod]
        public void VerifyCode() {
            var client = new Sinch.Verification.Client(appkey, appsecret);
            var result = client.VerifySMSCode("+15612600684", "7023").Result;
            Assert.AreNotEqual(0, int.Parse(result.id));
        }
    }
}
