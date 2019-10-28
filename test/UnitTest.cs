using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shadowsocks.Controller;
using GlobalHotKey;
using System.Windows.Input;
using System.Threading;
using System.Collections.Generic;
using Shadowsocks.Controller.Hotkeys;
using System.Diagnostics;
using System.IO;
using Shadowsocks.Model;

namespace Shadowsocks.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCompareVersion()
        {
            Assert.IsTrue(UpdateChecker.CompareVersion("2.3.1.0", "2.3.1") == 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("1.2", "1.3") < 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("1.3", "1.2") > 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("1.3", "1.3") == 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("1.2.1", "1.2") > 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("2.3.1", "2.4") < 0);
            Assert.IsTrue(UpdateChecker.CompareVersion("1.3.2", "1.3.1") > 0);
        }

        [TestMethod]
        public void TestHotKey2Str()
        {
            Assert.AreEqual("Ctrl+A", HotKeys.HotKey2Str(Key.A, ModifierKeys.Control));
            Assert.AreEqual("Ctrl+Alt+D2", HotKeys.HotKey2Str(Key.D2, (ModifierKeys.Alt | ModifierKeys.Control)));
            Assert.AreEqual("Ctrl+Alt+Shift+NumPad7", HotKeys.HotKey2Str(Key.NumPad7, (ModifierKeys.Alt | ModifierKeys.Control | ModifierKeys.Shift)));
            Assert.AreEqual("Ctrl+Alt+Shift+F6", HotKeys.HotKey2Str(Key.F6, (ModifierKeys.Alt | ModifierKeys.Control | ModifierKeys.Shift)));
            Assert.AreNotEqual("Ctrl+Shift+Alt+F6", HotKeys.HotKey2Str(Key.F6, (ModifierKeys.Alt | ModifierKeys.Control | ModifierKeys.Shift)));
        }

        [TestMethod]
        public void TestStr2HotKey()
        {
            Assert.IsTrue(HotKeys.Str2HotKey("Ctrl+A").Equals(new HotKey(Key.A, ModifierKeys.Control)));
            Assert.IsTrue(HotKeys.Str2HotKey("Ctrl+Alt+A").Equals(new HotKey(Key.A, (ModifierKeys.Control | ModifierKeys.Alt))));
            Assert.IsTrue(HotKeys.Str2HotKey("Ctrl+Shift+A").Equals(new HotKey(Key.A, (ModifierKeys.Control | ModifierKeys.Shift))));
            Assert.IsTrue(HotKeys.Str2HotKey("Ctrl+Alt+Shift+A").Equals(new HotKey(Key.A, (ModifierKeys.Control | ModifierKeys.Alt | ModifierKeys.Shift))));
            HotKey testKey0 = HotKeys.Str2HotKey("Ctrl+Alt+Shift+A");
            Assert.IsTrue(testKey0 != null && testKey0.Equals(new HotKey(Key.A, (ModifierKeys.Control | ModifierKeys.Alt | ModifierKeys.Shift))));
            HotKey testKey1 = HotKeys.Str2HotKey("Ctrl+Alt+Shift+F2");
            Assert.IsTrue(testKey1 != null && testKey1.Equals(new HotKey(Key.F2, (ModifierKeys.Control | ModifierKeys.Alt | ModifierKeys.Shift))));
            HotKey testKey2 = HotKeys.Str2HotKey("Ctrl+Shift+Alt+D7");
            Assert.IsTrue(testKey2 != null && testKey2.Equals(new HotKey(Key.D7, (ModifierKeys.Control | ModifierKeys.Alt | ModifierKeys.Shift))));
            HotKey testKey3 = HotKeys.Str2HotKey("Ctrl+Shift+Alt+NumPad7");
            Assert.IsTrue(testKey3 != null && testKey3.Equals(new HotKey(Key.NumPad7, (ModifierKeys.Control | ModifierKeys.Alt | ModifierKeys.Shift))));
        }

        [TestMethod]
        public void TestGithubRelease()
        {
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<GithubRelease>>(File.ReadAllText("GithubReleasesTestData.json"));
            Assert.IsTrue(result.Count == 30);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_Standard()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0.zip", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, string.Empty);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_StandardWithSuffix()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0-prerelease.zip", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, "prerelease");
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_Standard_MismatchExtension()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0.zip.hash", out version, out suffix);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_StandardWithSuffix_MismatchExtension()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0-prerelease.zip.hash", out version, out suffix);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_Standard_Capitalize()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("sHaDoWsOcKs-1.0.0.0.zIP", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, string.Empty);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_Standard2()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.2.3-release.zip", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.2.3");
            Assert.AreEqual(suffix, "release");
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_Standard_Exe()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0.exe", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, string.Empty);
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_StandardWithSuffix_Exe()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0-prerelease.exe", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, "prerelease");
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_StandardWithMoreSuffix()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0-prerelease test.zip", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, "prerelease test");
        }

        [TestMethod]
        public void TestExtractVersionInfoFromFileName_StandardWithMoreSuffix2()
        {
            string version, suffix;
            UpdateChecker updateChecker = new UpdateChecker();
            var result = updateChecker.ExtractVersionInfoFromFileName("Shadowsocks-1.0.0.0-prerelease-test.zip", out version, out suffix);
            Assert.IsTrue(result);
            Assert.AreEqual(version, "1.0.0.0");
            Assert.AreEqual(suffix, "prerelease-test");
        }
    }
}
