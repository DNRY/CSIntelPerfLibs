/*
//
//                  INTEL CORPORATION PROPRIETARY INFORMATION
//     This software is supplied under the terms of a license agreement or
//     nondisclosure agreement with Intel Corporation and may not be copied
//     or disclosed except in accordance with the terms of that agreement.
//        Copyright(c) 2003-2012 Intel Corporation. All Rights Reserved.
//
//     Intel(R) Integrated Performance Primitives Using Intel(R) IPP
//     in Microsoft* C# .NET for Windows* Sample
//
//  By downloading and installing this sample, you hereby agree that the
//  accompanying Materials are being provided to you under the terms and
//  conditions of the End User License Agreement for the Intel(R) Integrated
//  Performance Primitives product previously accepted by you. Please refer
//  to the file ippEULA.rtf located in the root directory of your Intel(R) IPP
//  product installation for more information.
//
*/

// generated automatically on Fri Jul  9 10:24:33 2010

using System.Runtime.InteropServices;
using System.Security;

namespace CSIntel.Ipp
{
    //
    // enums
    //
    public enum IppAffinityType
    {
        ippAffinityCompactFineCore = 0,
        ippAffinityCompactFineHT = 1,
        ippAffinityAllEnabled = 2,
        ippAffinityRestore = 3,
        ippTstAffinityCompactFineCore = 4,
        ippTstAffinityCompactFineHT = 5,
    };

    //
    // hidden or own structures
    //
    [StructLayout(LayoutKind.Sequential)]
    public struct IppMsgCatalog { };

    unsafe public class core
    {
        internal const string libname = "ippcore.dll";

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        void ippAlignPtr(char* ptr, int alignBytes);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippEnableCpu(IppCpuType cpu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        ulong ippGetCpuClocks();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippGetCpuFeatures(ulong* pFeaturesMask, uint* pCpuidInfoRegs);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippGetCpuFreqMhz(int* pMhz);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppCpuType ippGetCpuType();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        ulong ippGetEnabledCpuFeatures();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname, EntryPoint = "ippGetLibVersion")]
        public static extern
        int* xippGetLibVersion();

        public static IppLibraryVersion ippGetLibVersion()
        {
            return new IppLibraryVersion(xippGetLibVersion());
        }

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippGetMaxCacheSizeB(int* pSizeByte);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippGetMessageStatusI18n(IppMsgCatalog* pMsgCatalog, IppStatus StsCode, ushort* pMsg);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        int ippGetNumCoresOnDie();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippGetNumThreads(int* pNumThr);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname, EntryPoint = "ippGetStatusString")]
        public static extern
        sbyte* xippGetStatusString(IppStatus StsCode);

        public static string ippGetStatusString(IppStatus StsCode)
        {
            return new string(xippGetStatusString(StsCode));
        }

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippInit();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippInitCpu(IppCpuType cpu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippMessageCatalogCloseI18n(IppMsgCatalog* pMsgCatalog);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippMessageCatalogOpenI18n(IppMsgCatalog** pMsgCatalog);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippSetAffinity(IppAffinityType aType, int offset);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippSetDenormAreZeros(int value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippSetFlushToZero(int value, uint* pUMask);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippSetNumThreads(int numThr);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippStaticInit();

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippStaticInitCpu(IppCpuType cpu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        uint ippStatusToMessageIdI18n(IppStatus StsCode);
    };
};