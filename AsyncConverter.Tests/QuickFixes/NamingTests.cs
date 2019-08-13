﻿using AsyncConverter.QuickFixes;
using AsyncConverter.Tests.Helpers;
using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace AsyncConverter.Tests.QuickFixes
{
    [TestNetFramework46]
    public class NamingTests : CSharpQuickFixTestBase<AsyncMethodNamingQuickFix>
    {
        [TestCaseSource(typeof(TestHelper), nameof(TestHelper.FileNames), new object[]{@"QuickFixes\" + nameof(NamingTests)})]
        public void Test(string fileName)
        {
            DoTestFiles(fileName);
        }
    }
}