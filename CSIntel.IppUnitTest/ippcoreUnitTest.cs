using CSIntel.Ipp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace IppWrapperUnitTest
{
    [TestClass]
    public class ippcoreUnitTest
    {
        [TestMethod]
        public void Test_ippGetLibVersion()
        {
            var ippLibVersion = core.ippGetLibVersion();

            Console.WriteLine("major = {0}\n", ippLibVersion.major);
            Console.WriteLine("minor = {0}\n", ippLibVersion.minor);
            Console.WriteLine("majorBuild = {0}\n", ippLibVersion.majorBuild);
            Console.WriteLine("build = {0}\n", ippLibVersion.build);
            Console.WriteLine("targetCpu = {0}\n", ippLibVersion.targetCpu);
            Console.WriteLine("Name = {0}\n", ippLibVersion.Name);
            Console.WriteLine("Version = {0}\n", ippLibVersion.Version);
            Console.WriteLine("BuildDate = {0}\n", ippLibVersion.BuildDate);
        }

        [TestMethod]
        public void Test_ippsConvert_16s32f()
        {
            var length = 100;
            var value = 5;
            var testArray = Enumerable.Repeat((short)value, length).ToArray();
            var resultArray = new float[length];
            var expected = Enumerable.Repeat((float)value, length).ToArray();

            var gcHandleTest = GCHandle.Alloc(testArray, GCHandleType.Pinned);
            var gcHandleResult = GCHandle.Alloc(resultArray, GCHandleType.Pinned);
            IntPtr pTest = Marshal.UnsafeAddrOfPinnedArrayElement(testArray, 0);
            IntPtr pResult = Marshal.UnsafeAddrOfPinnedArrayElement(resultArray, 0);

            sp.ippsConvert_16s32f(pTest, pResult, length);

            gcHandleTest.Free();
            gcHandleResult.Free();

            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }

            resultArray = new float[length];
            sp.ippsConvert_16s32f(testArray, resultArray, length);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void Test_ippsConvert_32f16s_Sfs()
        {
            var length = 100;
            var value = 5;
            var testArray = Enumerable.Repeat((float)value, length).ToArray();
            var resultArray = new short[length];
            var expected = Enumerable.Repeat((short)value, length).ToArray();

            var gcHandleTest = GCHandle.Alloc(testArray, GCHandleType.Pinned);
            var gcHandleResult = GCHandle.Alloc(resultArray, GCHandleType.Pinned);
            IntPtr pTest = Marshal.UnsafeAddrOfPinnedArrayElement(testArray, 0);
            IntPtr pResult = Marshal.UnsafeAddrOfPinnedArrayElement(resultArray, 0);

            sp.ippsConvert_32f16s_Sfs(pTest, pResult, length, IppRoundMode.ippRndZero, 0);

            gcHandleTest.Free();
            gcHandleResult.Free();

            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }

            resultArray = new short[length];
            sp.ippsConvert_32f16s_Sfs(testArray, resultArray, length, IppRoundMode.ippRndZero, 0);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }
        }

        [TestMethod]
        public void Test_ippsConvert_32f8s_Sfs()
        {
            var length = 100;
            var value = 5;
            var testArray = Enumerable.Repeat((float)value, length).ToArray();
            var resultArray = new sbyte[length];
            var expected = Enumerable.Repeat((sbyte)value, length).ToArray();

            var gcHandleTest = GCHandle.Alloc(testArray, GCHandleType.Pinned);
            var gcHandleResult = GCHandle.Alloc(resultArray, GCHandleType.Pinned);
            IntPtr pTest = Marshal.UnsafeAddrOfPinnedArrayElement(testArray, 0);
            IntPtr pResult = Marshal.UnsafeAddrOfPinnedArrayElement(resultArray, 0);

            sp.ippsConvert_32f8s_Sfs(pTest, pResult, length, IppRoundMode.ippRndZero, 0);

            gcHandleTest.Free();
            gcHandleResult.Free();

            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }

            resultArray = new sbyte[length];
            sp.ippsConvert_32f8s_Sfs(testArray, resultArray, length, IppRoundMode.ippRndZero, 0);
            for (int i = 0; i < length; i++)
            {
                Assert.AreEqual(expected[i], resultArray[i]);
            }
        }
    }
}