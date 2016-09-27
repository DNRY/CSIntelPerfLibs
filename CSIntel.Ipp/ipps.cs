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

// generated automatically on Wed Mar 31 16:30:13 2010

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CSIntel.Ipp
{
    //
    // enums
    //
    //
    // hidden or own structures
    //
    [StructLayout(LayoutKind.Sequential)]
    public struct IppToneState_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppTriangleState_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTFwdSpec_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTFwdSpec_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTFwdSpec_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTInvSpec_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTInvSpec_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDCTInvSpec_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTOutOrdSpec_C_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTOutOrdSpec_C_64fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_C_64fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_R_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_R_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsDFTSpec_R_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_32sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_C_64fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_R_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_R_16s32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_R_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_R_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFFTSpec_R_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRLMSMRState32s_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRLMSMRState32sc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRLMSState32f_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRLMSState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRSparseState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState32f_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState32fc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState32s_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState32sc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64f_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64f_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64f_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64fc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64fc_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState64fc_32sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsFIRState_64fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsHilbertSpec_16s16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsHilbertSpec_16s32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsHilbertSpec_32f32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRSparseState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState32f_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState32fc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState32s_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState32sc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64f_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64f_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64f_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64fc_16sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64fc_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState64fc_32sc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState_32fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState_64f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsIIRState_64fc { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandGaussState_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandGaussState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandGaussState_8u { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandUniState_16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandUniState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsRandUniState_8u { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTFwdState_16s32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTFwdState_16u32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTFwdState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTFwdState_8s32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTFwdState_8u32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTInvState_32f { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTInvState_32f16s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTInvState_32f16u { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTInvState_32f8s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsWTInvState_32f8u { };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppsROI
    {
        public int left;
        public int right;

        public IppsROI(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
    };

    unsafe public class sp
    {
        internal const string libname = "ipps.dll";

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ipps10Log10_32s_ISfs(int* pSrcDst, int Len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ipps10Log10_32s_Sfs(int* pSrc, int* pDst, int Len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsALawToLin_8u16s(byte* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsALawToLin_8u32f(byte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsALawToMuLaw_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_32s(int* pSrc, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_32s_I(int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAbs_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16s_I(short val, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16s_ISfs(short val, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16s_Sfs(short* pSrc, short val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16u_ISfs(ushort val, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_16u_Sfs(ushort* pSrc, ushort val, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32fc(Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32s_ISfs(int val, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32s_Sfs(int* pSrc, int val, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64f(double* pSrc, double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64f_I(double val, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64fc(Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64s_Sfs(long* pSrc, long val, long* pDst, uint len, int scaleFactor, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_64u_Sfs(ulong* pSrc, ulong val, ulong* pDst, uint len, int scaleFactor, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_8u_ISfs(byte val, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddC_8u_Sfs(byte* pSrc, byte val, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProductC_32f(float* pSrc, float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_16s32s_Sfs(short* pSrc1, short* pSrc2, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_16s_Sfs(short* pSrc1, short* pSrc2, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_32f(float* pSrc1, float* pSrc2, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_32s_Sfs(int* pSrc1, int* pSrc2, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_64f(double* pSrc1, double* pSrc2, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAddProduct_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s(short* pSrc1, short* pSrc2, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s32f(short* pSrc1, short* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s32s_I(short* pSrc, int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s_I(short* pSrc, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s_ISfs(short* pSrc, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16sc_ISfs(Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16u_ISfs(ushort* pSrc, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_16u_Sfs(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32f(float* pSrc1, float* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32fc_I(Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32s_ISfs(int* pSrc, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32s_Sfs(int* pSrc1, int* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32sc_ISfs(Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32sc_Sfs(Ipp32sc* pSrc1, Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_32u(uint* pSrc1, uint* pSrc2, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_64f(double* pSrc1, double* pSrc2, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_64f_I(double* pSrc, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_64fc_I(Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_64s_Sfs(long* pSrc1, long* pSrc2, long* pDst, uint len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_8u16u(byte* pSrc1, byte* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_8u_ISfs(byte* pSrc, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAdd_8u_Sfs(byte* pSrc1, byte* pSrc2, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_16u(ushort* pSrc, ushort val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_16u_I(ushort val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_32u(uint* pSrc, uint val, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_32u_I(uint val, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_8u(byte* pSrc, byte val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAndC_8u_I(byte val, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_16u_I(ushort* pSrc, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_32u(uint* pSrc1, uint* pSrc2, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_32u_I(uint* pSrc, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_8u(byte* pSrc1, byte* pSrc2, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAnd_8u_I(byte* pSrc, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsArctan_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsArctan_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsArctan_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsArctan_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_16s_Sfs(short* pSrc, int srcLen, short* pDst, int dstLen, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_32f(float* pSrc, int srcLen, float* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_32fc(Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_64f(double* pSrc, int srcLen, double* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_64fc(Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormA_16s_Sfs(short* pSrc, int srcLen, short* pDst, int dstLen, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormA_32f(float* pSrc, int srcLen, float* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormA_32fc(Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormA_64f(double* pSrc, int srcLen, double* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormA_64fc(Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormB_16s_Sfs(short* pSrc, int srcLen, short* pDst, int dstLen, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormB_32f(float* pSrc, int srcLen, float* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormB_32fc(Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormB_64f(double* pSrc, int srcLen, double* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsAutoCorr_NormB_64fc(Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int dstLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsBuildSymblTableDV4D_16sc(Ipp16sc* pVariantPoint, Ipp16sc* pCurrentSubsetPoint, int state, int bitInversion);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCalcStatesDV_16sc(ushort* pathError, byte* pNextState, ushort* pBranchError, short* pCurrentSubsetPoint, short* pPathTable, int state, int presentIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCartToPolar_16sc_Sfs(Ipp16sc* pSrc, short* pDstMagn, short* pDstPhase, int len, int magnScaleFactor, int phaseScaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCartToPolar_32f(float* pSrcRe, float* pSrcIm, float* pDstMagn, float* pDstPhase, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCartToPolar_32fc(Ipp32fc* pSrc, float* pDstMagn, float* pDstPhase, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCartToPolar_64f(double* pSrcRe, double* pSrcIm, double* pDstMagn, double* pDstPhase, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCartToPolar_64fc(Ipp64fc* pSrc, double* pDstMagn, double* pDstPhase, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCauchyDD2_32f_I(float* pSrcDst, float* pD2F, int len, float C);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCauchyD_32f_I(float* pSrcDst, int len, float C);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCauchy_32f_I(float* pSrcDst, int len, float C);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_16sc(short* pSrc, Ipp16sc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_16sc_I(Ipp16sc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_32fc(float* pSrc, Ipp32fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_64fc(double* pSrc, Ipp64fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjCcs_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjFlip_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjFlip_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjFlip_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_16sc(short* pSrc, Ipp16sc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_16sc_I(Ipp16sc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_32fc(float* pSrc, Ipp32fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_64fc(double* pSrc, Ipp64fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPack_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_16sc(short* pSrc, Ipp16sc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_16sc_I(Ipp16sc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_32fc(float* pSrc, Ipp32fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_64fc(double* pSrc, Ipp64fc* pDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConjPerm_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConj_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvBiased_32f(float* pSrc1, int len1, float* pSrc2, int len2, float* pDst, int lenDst, int bias);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvCyclic4x4_32f32fc(float* x, Ipp32fc* h, Ipp32fc* y);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvCyclic8x8_16s_Sfs(short* x, short* h, short* y, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvCyclic8x8_32f(float* x, float* h, float* y);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConv_16s_Sfs(short* pSrc1, int lenSrc1, short* pSrc2, int lenSrc2, short* pDst, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConv_32f(float* pSrc1, int lenSrc1, float* pSrc2, int lenSrc2, float* pDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConv_64f(double* pSrc1, int lenSrc1, double* pSrc2, int lenSrc2, double* pDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16f16s_Sfs(short* pSrc, short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16f32f(short* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s16f(short* pSrc, short* pDst, int len, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s32f([In] short[] pSrc, [In, Out]float[] pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s32f(IntPtr pSrc, IntPtr pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s32f_Sfs(short* pSrc, float* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s32s(short* pSrc, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s64f_Sfs(short* pSrc, double* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16s8s_Sfs(short* pSrc, sbyte* pDst, uint len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_16u32f(ushort* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_24s32f(byte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_24s32s(byte* pSrc, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_24u32f(byte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_24u32u(byte* pSrc, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f16f(float* pSrc, short* pDst, int len, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f16s_Sfs(float* pSrc, short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f16s_Sfs(IntPtr pSrc, IntPtr pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f16s_Sfs([In]float[] pSrc, [In, Out]short[] pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f16u_Sfs(float* pSrc, ushort* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f24s_Sfs(float* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f24u_Sfs(float* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f32s_Sfs(float* pSrc, int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f64f(float* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f8s_Sfs(float* pSrc, sbyte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f8s_Sfs(IntPtr pSrc, IntPtr pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f8s_Sfs([In]float[] pSrc, [In, Out]sbyte[] pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32f8u_Sfs(float* pSrc, byte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s16s(int* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s16s_Sfs(int* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s24s_Sfs(int* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s32f(int* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s32f_Sfs(int* pSrc, float* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s64f(int* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32s64f_Sfs(int* pSrc, double* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_32u24u_Sfs(uint* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64f16s_Sfs(double* pSrc, short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64f32f(double* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64f32s_Sfs(double* pSrc, int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64f64s_Sfs(double* pSrc, long* pDst, uint len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64s32s_Sfs(long* pSrc, int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_64s64f(long* pSrc, double* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_8s16s(sbyte* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_8s32f(sbyte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsConvert_8u32f(byte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_1u(byte* pSrc, int srcBitOffset, byte* pDst, int dstBitOffset, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_32s(int* pSrc, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_32sc(Ipp32sc* pSrc, Ipp32sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_64s(long* pSrc, long* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_64sc(Ipp64sc* pSrc, Ipp64sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCopy_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCountInRange_32s(int* pSrc, int len, int* pCounts, int lowerBound, int upperBound);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCplxToReal_16sc(Ipp16sc* pSrc, short* pDstRe, short* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCplxToReal_32fc(Ipp32fc* pSrc, float* pDstRe, float* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCplxToReal_64fc(Ipp64fc* pSrc, double* pDstRe, double* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_16s64s(short* pSrc1, int src1Len, short* pSrc2, int src2Len, long* pDst, int dstLen, int lowLag);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_16s_Sfs(short* pSrc1, int src1Len, short* pSrc2, int src2Len, short* pDst, int dstLen, int lowLag, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_32f(float* pSrc1, int src1Len, float* pSrc2, int src2Len, float* pDst, int dstLen, int lowLag);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_32fc(Ipp32fc* pSrc1, int src1Len, Ipp32fc* pSrc2, int src2Len, Ipp32fc* pDst, int dstLen, int lowLag);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_64f(double* pSrc1, int src1Len, double* pSrc2, int src2Len, double* pDst, int dstLen, int lowLag);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCrossCorr_64fc(Ipp64fc* pSrc1, int src1Len, Ipp64fc* pSrc2, int src2Len, Ipp64fc* pDst, int dstLen, int lowLag);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCubrt_32f(float* pSrc, float* pDst, int Len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsCubrt_32s16s_Sfs(int* pSrc, short* pDst, int Len, int sFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdFree_16s(IppsDCTFwdSpec_16s* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdFree_32f(IppsDCTFwdSpec_32f* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdFree_64f(IppsDCTFwdSpec_64f* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetBufSize_16s(IppsDCTFwdSpec_16s* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetBufSize_32f(IppsDCTFwdSpec_32f* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetBufSize_64f(IppsDCTFwdSpec_64f* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetSize_16s(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetSize_32f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdGetSize_64f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInitAlloc_16s(IppsDCTFwdSpec_16s** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInitAlloc_32f(IppsDCTFwdSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInitAlloc_64f(IppsDCTFwdSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInit_16s(IppsDCTFwdSpec_16s** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInit_32f(IppsDCTFwdSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwdInit_64f(IppsDCTFwdSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_16s_ISfs(short* pSrcDst, IppsDCTFwdSpec_16s* pDCTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_16s_Sfs(short* pSrc, short* pDst, IppsDCTFwdSpec_16s* pDCTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_32f(float* pSrc, float* pDst, IppsDCTFwdSpec_32f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_32f_I(float* pSrcDst, IppsDCTFwdSpec_32f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_64f(double* pSrc, double* pDst, IppsDCTFwdSpec_64f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTFwd_64f_I(double* pSrcDst, IppsDCTFwdSpec_64f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvFree_16s(IppsDCTInvSpec_16s* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvFree_32f(IppsDCTInvSpec_32f* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvFree_64f(IppsDCTInvSpec_64f* pDCTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetBufSize_16s(IppsDCTInvSpec_16s* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetBufSize_32f(IppsDCTInvSpec_32f* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetBufSize_64f(IppsDCTInvSpec_64f* pDCTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetSize_16s(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetSize_32f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvGetSize_64f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInitAlloc_16s(IppsDCTInvSpec_16s** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInitAlloc_32f(IppsDCTInvSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInitAlloc_64f(IppsDCTInvSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInit_16s(IppsDCTInvSpec_16s** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInit_32f(IppsDCTInvSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInvInit_64f(IppsDCTInvSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_16s_ISfs(short* pSrcDst, IppsDCTInvSpec_16s* pDCTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_16s_Sfs(short* pSrc, short* pDst, IppsDCTInvSpec_16s* pDCTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_32f(float* pSrc, float* pDst, IppsDCTInvSpec_32f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_32f_I(float* pSrcDst, IppsDCTInvSpec_32f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_64f(double* pSrc, double* pDst, IppsDCTInvSpec_64f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDCTInv_64f_I(double* pSrDst, IppsDCTInvSpec_64f* pDCTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_16s(IppsDFTSpec_C_16s* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_16sc(IppsDFTSpec_C_16sc* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_32f(IppsDFTSpec_C_32f* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_32fc(IppsDFTSpec_C_32fc* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_64f(IppsDFTSpec_C_64f* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_C_64fc(IppsDFTSpec_C_64fc* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_R_16s(IppsDFTSpec_R_16s* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_R_32f(IppsDFTSpec_R_32f* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFree_R_64f(IppsDFTSpec_R_64f* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDstRe, short* pDstIm, IppsDFTSpec_C_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, IppsDFTSpec_C_16sc* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_32f(float* pSrcRe, float* pSrcIm, float* pDstRe, float* pDstIm, IppsDFTSpec_C_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsDFTSpec_C_32fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_64f(double* pSrcRe, double* pSrcIm, double* pDstRe, double* pDstIm, IppsDFTSpec_C_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsDFTSpec_C_64fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToCCS_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToCCS_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToCCS_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPack_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPack_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPack_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPerm_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPerm_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTFwd_RToPerm_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_16s(IppsDFTSpec_C_16s* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_16sc(IppsDFTSpec_C_16sc* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_32f(IppsDFTSpec_C_32f* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_32fc(IppsDFTSpec_C_32fc* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_64f(IppsDFTSpec_C_64f* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_C_64fc(IppsDFTSpec_C_64fc* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_R_16s(IppsDFTSpec_R_16s* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_R_32f(IppsDFTSpec_R_32f* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTGetBufSize_R_64f(IppsDFTSpec_R_64f* pDFTSpec, int* pSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_16s(IppsDFTSpec_C_16s** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_16sc(IppsDFTSpec_C_16sc** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_32f(IppsDFTSpec_C_32f** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_32fc(IppsDFTSpec_C_32fc** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_64f(IppsDFTSpec_C_64f** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_C_64fc(IppsDFTSpec_C_64fc** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_R_16s(IppsDFTSpec_R_16s** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_R_32f(IppsDFTSpec_R_32f** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInitAlloc_R_64f(IppsDFTSpec_R_64f** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CCSToR_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CCSToR_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CCSToR_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDstRe, short* pDstIm, IppsDFTSpec_C_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, IppsDFTSpec_C_16sc* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_32f(float* pSrcRe, float* pSrcIm, float* pDstRe, float* pDstIm, IppsDFTSpec_C_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsDFTSpec_C_32fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_64f(double* pSrcRe, double* pSrcIm, double* pDstRe, double* pDstIm, IppsDFTSpec_C_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsDFTSpec_C_64fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PackToR_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PackToR_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PackToR_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PermToR_16s_Sfs(short* pSrc, short* pDst, IppsDFTSpec_R_16s* pDFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PermToR_32f(float* pSrc, float* pDst, IppsDFTSpec_R_32f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTInv_PermToR_64f(double* pSrc, double* pDst, IppsDFTSpec_R_64f* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdFree_C_32fc(IppsDFTOutOrdSpec_C_32fc* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdFree_C_64fc(IppsDFTOutOrdSpec_C_64fc* pDFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdFwd_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsDFTOutOrdSpec_C_32fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdFwd_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsDFTOutOrdSpec_C_64fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdGetBufSize_C_32fc(IppsDFTOutOrdSpec_C_32fc* pDFTSpec, int* size);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdGetBufSize_C_64fc(IppsDFTOutOrdSpec_C_64fc* pDFTSpec, int* size);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdInitAlloc_C_32fc(IppsDFTOutOrdSpec_C_32fc** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdInitAlloc_C_64fc(IppsDFTOutOrdSpec_C_64fc** pDFTSpec, int length, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdInv_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsDFTOutOrdSpec_C_32fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDFTOutOrdInv_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsDFTOutOrdSpec_C_64fc* pDFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDemodulateFM_CToR_16s(short* pSrcRe, short* pSrcIm, short* pDst, int len, Ipp16sc* pDlyPoint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivCRev_16u(ushort* pSrc, ushort val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivCRev_16u_I(ushort val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivCRev_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivCRev_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16s_ISfs(short val, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16s_Sfs(short* pSrc, short val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16u_ISfs(ushort val, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_16u_Sfs(ushort* pSrc, ushort val, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_32fc(Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_64f(double* pSrc, double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_64f_I(double val, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_64fc(Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_64s_ISfs(long val, long* pSrcDst, uint len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_8u_ISfs(byte val, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDivC_8u_Sfs(byte* pSrc, byte val, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16s_ISfs(short* pSrc, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16sc_ISfs(Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16u_ISfs(ushort* pSrc, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_16u_Sfs(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32f(float* pSrc1, float* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32fc_I(Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32s16s_Sfs(short* pSrc1, int* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32s_ISfs(int* pSrc, int* pSrcDst, int len, int ScaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_32s_Sfs(int* pSrc1, int* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_64f(double* pSrc1, double* pSrc2, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_64f_I(double* pSrc, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_64fc_I(Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_8u_ISfs(byte* pSrc, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_8u_Sfs(byte* pSrc1, byte* pSrc2, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_16s_ISfs(short* pSrc, short* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_16u_ISfs(ushort* pSrc, ushort* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_16u_Sfs(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_8u_ISfs(byte* pSrc, byte* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDiv_Round_8u_Sfs(byte* pSrc1, byte* pSrc2, byte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s16sc32fc(short* pSrc1, Ipp16sc* pSrc2, int len, Ipp32fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s16sc32sc_Sfs(short* pSrc1, Ipp16sc* pSrc2, int len, Ipp32sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s16sc64sc(short* pSrc1, Ipp16sc* pSrc2, int len, Ipp64sc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s16sc_Sfs(short* pSrc1, Ipp16sc* pSrc2, int len, Ipp16sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s32f(short* pSrc1, short* pSrc2, int len, float* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s32s32s_Sfs(short* pSrc1, int* pSrc2, int len, int* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s32s_Sfs(short* pSrc1, short* pSrc2, int len, int* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s64s(short* pSrc1, short* pSrc2, int len, long* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16s_Sfs(short* pSrc1, short* pSrc2, int len, short* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16sc32fc(Ipp16sc* pSrc1, Ipp16sc* pSrc2, int len, Ipp32fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16sc32sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, int len, Ipp32sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16sc64sc(Ipp16sc* pSrc1, Ipp16sc* pSrc2, int len, Ipp64sc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_16sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, int len, Ipp16sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32f(float* pSrc1, float* pSrc2, int len, float* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32f32fc(float* pSrc1, Ipp32fc* pSrc2, int len, Ipp32fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32f32fc64fc(float* pSrc1, Ipp32fc* pSrc2, int len, Ipp64fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32f64f(float* pSrc1, float* pSrc2, int len, double* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, int len, Ipp32fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32fc64fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, int len, Ipp64fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32s32sc_Sfs(int* pSrc1, Ipp32sc* pSrc2, int len, Ipp32sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32s_Sfs(int* pSrc1, int* pSrc2, int len, int* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_32sc_Sfs(Ipp32sc* pSrc1, Ipp32sc* pSrc2, int len, Ipp32sc* pDp, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_64f(double* pSrc1, double* pSrc2, int len, double* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_64f64fc(double* pSrc1, Ipp64fc* pSrc2, int len, Ipp64fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsDotProd_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, int len, Ipp64fc* pDp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_16s_ISfs(short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_16s_Sfs(short* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_32f64f(float* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_32s_ISfs(int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_32s_Sfs(int* pSrc, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_64s_ISfs(long* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsExp_64s_Sfs(long* pSrc, long* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_16s(IppsFFTSpec_C_16s* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_16sc(IppsFFTSpec_C_16sc* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_32f(IppsFFTSpec_C_32f* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_32fc(IppsFFTSpec_C_32fc* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_32s(IppsFFTSpec_C_32s* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_32sc(IppsFFTSpec_C_32sc* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_64f(IppsFFTSpec_C_64f* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_C_64fc(IppsFFTSpec_C_64fc* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_R_16s(IppsFFTSpec_R_16s* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_R_16s32s(IppsFFTSpec_R_16s32s* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_R_32f(IppsFFTSpec_R_32f* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_R_32s(IppsFFTSpec_R_32s* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFree_R_64f(IppsFFTSpec_R_64f* pFFTSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_16s_ISfs(short* pSrcDstRe, short* pSrcDstIm, IppsFFTSpec_C_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDstRe, short* pDstIm, IppsFFTSpec_C_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_16sc_ISfs(Ipp16sc* pSrcDst, IppsFFTSpec_C_16sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, IppsFFTSpec_C_16sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32f(float* pSrcRe, float* pSrcIm, float* pDstRe, float* pDstIm, IppsFFTSpec_C_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32f_I(float* pSrcDstRe, float* pSrcDstIm, IppsFFTSpec_C_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsFFTSpec_C_32fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32fc_I(Ipp32fc* pSrcDst, IppsFFTSpec_C_32fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32s_ISfs(int* pSrcDstRe, int* pSrcDstIm, IppsFFTSpec_C_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32s_Sfs(int* pSrcRe, int* pSrcIm, int* pDstRe, int* pDstIm, IppsFFTSpec_C_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32sc_ISfs(Ipp32sc* pSrcDst, IppsFFTSpec_C_32sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, IppsFFTSpec_C_32sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_64f(double* pSrcRe, double* pSrcIm, double* pDstRe, double* pDstIm, IppsFFTSpec_C_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_64f_I(double* pSrcDstRe, double* pSrcDstIm, IppsFFTSpec_C_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsFFTSpec_C_64fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_CToC_64fc_I(Ipp64fc* pSrcDst, IppsFFTSpec_C_64fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_16s32s_Sfs(short* pSrc, int* pDst, IppsFFTSpec_R_16s32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToCCS_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPack_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTFwd_RToPerm_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_16s(IppsFFTSpec_C_16s* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_16sc(IppsFFTSpec_C_16sc* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_32f(IppsFFTSpec_C_32f* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_32fc(IppsFFTSpec_C_32fc* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_32s(IppsFFTSpec_C_32s* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_32sc(IppsFFTSpec_C_32sc* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_64f(IppsFFTSpec_C_64f* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_C_64fc(IppsFFTSpec_C_64fc* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_R_16s(IppsFFTSpec_R_16s* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_R_16s32s(IppsFFTSpec_R_16s32s* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_R_32f(IppsFFTSpec_R_32f* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_R_32s(IppsFFTSpec_R_32s* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetBufSize_R_64f(IppsFFTSpec_R_64f* pFFTSpec, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_16s(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_16sc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_32f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_32fc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_32s(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_32sc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_64f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_C_64fc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_R_16s(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_R_16s32s(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_R_32f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_R_32s(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTGetSize_R_64f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_16s(IppsFFTSpec_C_16s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_16sc(IppsFFTSpec_C_16sc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_32f(IppsFFTSpec_C_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_32fc(IppsFFTSpec_C_32fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_32s(IppsFFTSpec_C_32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_32sc(IppsFFTSpec_C_32sc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_64f(IppsFFTSpec_C_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_C_64fc(IppsFFTSpec_C_64fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_R_16s(IppsFFTSpec_R_16s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_R_16s32s(IppsFFTSpec_R_16s32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_R_32f(IppsFFTSpec_R_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_R_32s(IppsFFTSpec_R_32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInitAlloc_R_64f(IppsFFTSpec_R_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_16s(IppsFFTSpec_C_16s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_16sc(IppsFFTSpec_C_16sc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_32f(IppsFFTSpec_C_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_32fc(IppsFFTSpec_C_32fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_32s(IppsFFTSpec_C_32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_32sc(IppsFFTSpec_C_32sc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_64f(IppsFFTSpec_C_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_C_64fc(IppsFFTSpec_C_64fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_R_16s(IppsFFTSpec_R_16s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_R_16s32s(IppsFFTSpec_R_16s32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_R_32f(IppsFFTSpec_R_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_R_32s(IppsFFTSpec_R_32s** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInit_R_64f(IppsFFTSpec_R_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, byte* pSpec, byte* pSpecBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_32s16s_Sfs(int* pSrc, short* pDst, IppsFFTSpec_R_16s32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CCSToR_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_16s_ISfs(short* pSrcDstRe, short* pSrcDstIm, IppsFFTSpec_C_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDstRe, short* pDstIm, IppsFFTSpec_C_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_16sc_ISfs(Ipp16sc* pSrcDst, IppsFFTSpec_C_16sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, IppsFFTSpec_C_16sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32f(float* pSrcRe, float* pSrcIm, float* pDstRe, float* pDstIm, IppsFFTSpec_C_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32f_I(float* pSrcDstRe, float* pSrcDstIm, IppsFFTSpec_C_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, IppsFFTSpec_C_32fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32fc_I(Ipp32fc* pSrcDst, IppsFFTSpec_C_32fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32s_ISfs(int* pSrcDstRe, int* pSrcDstIm, IppsFFTSpec_C_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32s_Sfs(int* pSrcRe, int* pSrcIm, int* pDstRe, int* pDstIm, IppsFFTSpec_C_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32sc_ISfs(Ipp32sc* pSrcDst, IppsFFTSpec_C_32sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, IppsFFTSpec_C_32sc* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_64f(double* pSrcRe, double* pSrcIm, double* pDstRe, double* pDstIm, IppsFFTSpec_C_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_64f_I(double* pSrcDstRe, double* pSrcDstIm, IppsFFTSpec_C_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, IppsFFTSpec_C_64fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_CToC_64fc_I(Ipp64fc* pSrcDst, IppsFFTSpec_C_64fc* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PackToR_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_16s_ISfs(short* pSrcDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_16s_Sfs(short* pSrc, short* pDst, IppsFFTSpec_R_16s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_32f(float* pSrc, float* pDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_32f_I(float* pSrcDst, IppsFFTSpec_R_32f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_32s_ISfs(int* pSrcDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_32s_Sfs(int* pSrc, int* pDst, IppsFFTSpec_R_32s* pFFTSpec, int scaleFactor, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_64f(double* pSrc, double* pDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFFTInv_PermToR_64f_I(double* pSrcDst, IppsFFTSpec_R_64f* pFFTSpec, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32f_16s_ISfs(short* pSrcDst, int numIters, IppsFIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32f_16s_Sfs(short* pSrc, short* pDst, int numIters, IppsFIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32f_Direct_16s_ISfs(short* pSrcDst, int numIters, float* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32f_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, float* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32fc_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, IppsFIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32fc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, IppsFIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32fc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32fc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32s_16s_ISfs(short* pSrcDst, int numIters, IppsFIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32s_16s_Sfs(short* pSrc, short* pDst, int numIters, IppsFIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32s_Direct_16s_ISfs(short* pSrcDst, int numIters, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32s_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32sc_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, IppsFIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32sc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, IppsFIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32sc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR32sc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_16s_ISfs(short* pSrcDst, int numIters, IppsFIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_16s_Sfs(short* pSrc, short* pDst, int numIters, IppsFIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_32f(float* pSrc, float* pDst, int numIters, IppsFIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_32f_I(float* pSrcDst, int numIters, IppsFIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_32s_ISfs(int* pSrcDst, int numIters, IppsFIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_32s_Sfs(int* pSrc, int* pDst, int numIters, IppsFIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_16s_ISfs(short* pSrcDst, int numIters, double* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, double* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_32f(float* pSrc, float* pDst, int numIters, double* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_32f_I(float* pSrcDst, int numIters, double* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_32s_ISfs(int* pSrcDst, int numIters, double* pTaps, int tapsLen, int* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64f_Direct_32s_Sfs(int* pSrc, int* pDst, int numIters, double* pTaps, int tapsLen, int* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, IppsFIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, IppsFIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, IppsFIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_32fc_I(Ipp32fc* pSrcDst, int numIters, IppsFIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_32sc_ISfs(Ipp32sc* pSrcDst, int numIters, IppsFIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, int numIters, IppsFIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_32fc_I(Ipp32fc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_32sc_ISfs(Ipp32sc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR64fc_Direct_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree32f_16s(IppsFIRState32f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree32fc_16sc(IppsFIRState32fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree32s_16s(IppsFIRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree32sc_16sc(IppsFIRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64f_16s(IppsFIRState64f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64f_32f(IppsFIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64f_32s(IppsFIRState64f_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64fc_16sc(IppsFIRState64fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64fc_32fc(IppsFIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree64fc_32sc(IppsFIRState64fc_32sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_16s(IppsFIRState_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_32f(IppsFIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_32fc(IppsFIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_32s(IppsFIRState_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_64f(IppsFIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRFree_64fc(IppsFIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGenBandpass_64f(double rLowFreq, double rHighFreq, double* taps, int tapsLen, IppWinType winType, IppBool doNormal);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGenBandstop_64f(double rLowFreq, double rHighFreq, double* taps, int tapsLen, IppWinType winType, IppBool doNormal);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGenHighpass_64f(double rfreq, double* taps, int tapsLen, IppWinType winType, IppBool doNormal);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGenLowpass_64f(double rfreq, double* taps, int tapsLen, IppWinType winType, IppBool doNormal);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine32f_16s(IppsFIRState32f_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine32fc_16sc(IppsFIRState32fc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine32s_16s(IppsFIRState32s_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine32sc_16sc(IppsFIRState32sc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64f_16s(IppsFIRState64f_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64f_32f(IppsFIRState64f_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64f_32s(IppsFIRState64f_32s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64fc_16sc(IppsFIRState64fc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64fc_32fc(IppsFIRState64fc_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine64fc_32sc(IppsFIRState64fc_32sc* pState, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine_16s(IppsFIRState_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine_32f(IppsFIRState_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine_32fc(IppsFIRState_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine_64f(IppsFIRState_64f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetDlyLine_64fc(IppsFIRState_64fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32f_16s(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32fc_16sc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32s_16s(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32s_16s32f(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32sc_16sc(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize32sc_16sc32fc(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64f_16s(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64f_32f(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64f_32s(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64fc_16sc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64fc_32fc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize64fc_32sc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_16s(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_32f(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_32fc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_32s(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_64f(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetStateSize_64fc(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32f_16s(IppsFIRState32f_16s* pState, float* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32fc_16sc(IppsFIRState32fc_16sc* pState, Ipp32fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32s_16s(IppsFIRState32s_16s* pState, int* pTaps, int* tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32s_16s32f(IppsFIRState32s_16s* pState, float* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32sc_16sc(IppsFIRState32sc_16sc* pState, Ipp32sc* pTaps, int* tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps32sc_16sc32fc(IppsFIRState32sc_16sc* pState, Ipp32fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64f_16s(IppsFIRState64f_16s* pState, double* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64f_32f(IppsFIRState64f_32f* pState, double* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64f_32s(IppsFIRState64f_32s* pState, double* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64fc_16sc(IppsFIRState64fc_16sc* pState, Ipp64fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64fc_32fc(IppsFIRState64fc_32fc* pState, Ipp64fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps64fc_32sc(IppsFIRState64fc_32sc* pState, Ipp64fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_16s(IppsFIRState_16s* pState, short* pTaps, int* tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_32f(IppsFIRState_32f* pState, float* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_32fc(IppsFIRState_32fc* pState, Ipp32fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_32s(IppsFIRState_32s* pState, int* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_64f(IppsFIRState_64f* pState, double* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRGetTaps_64fc(IppsFIRState_64fc* pState, Ipp64fc* pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32f_16s(IppsFIRState32f_16s** ppState, float* pTaps, int tapsLen, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32fc_16sc(IppsFIRState32fc_16sc** ppState, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32s_16s(IppsFIRState32s_16s** ppState, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32s_16s32f(IppsFIRState32s_16s** ppState, float* pTaps, int tapsLen, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32sc_16sc(IppsFIRState32sc_16sc** ppState, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit32sc_16sc32fc(IppsFIRState32sc_16sc** ppState, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64f_16s(IppsFIRState64f_16s** ppState, double* pTaps, int tapsLen, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64f_32f(IppsFIRState64f_32f** ppState, double* pTaps, int tapsLen, float* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64f_32s(IppsFIRState64f_32s** ppState, double* pTaps, int tapsLen, int* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64fc_16sc(IppsFIRState64fc_16sc** ppState, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64fc_32fc(IppsFIRState64fc_32fc** ppState, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit64fc_32sc(IppsFIRState64fc_32sc** ppState, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32f_16s(IppsFIRState32f_16s** pState, float* pTaps, int tapsLen, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32fc_16sc(IppsFIRState32fc_16sc** pState, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32s_16s(IppsFIRState32s_16s** pState, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32s_16s32f(IppsFIRState32s_16s** pState, float* pTaps, int tapsLen, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32sc_16sc(IppsFIRState32sc_16sc** pState, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc32sc_16sc32fc(IppsFIRState32sc_16sc** pState, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64f_16s(IppsFIRState64f_16s** pState, double* pTaps, int tapsLen, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64f_32f(IppsFIRState64f_32f** pState, double* pTaps, int tapsLen, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64f_32s(IppsFIRState64f_32s** pState, double* pTaps, int tapsLen, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64fc_16sc(IppsFIRState64fc_16sc** pState, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64fc_32fc(IppsFIRState64fc_32fc** pState, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc64fc_32sc(IppsFIRState64fc_32sc** pState, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_16s(IppsFIRState_16s** pState, short* pTaps, int tapsLen, int tapsFactor, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_32fc(IppsFIRState_32fc** pState, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_32s(IppsFIRState_32s** pState, int* pTaps, int tapsLen, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_64f(IppsFIRState_64f** pState, double* pTaps, int tapsLen, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInitAlloc_64fc(IppsFIRState_64fc** pState, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_16s(IppsFIRState_16s** ppState, short* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_32f(IppsFIRState_32f** ppState, float* pTaps, int tapsLen, float* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_32fc(IppsFIRState_32fc** ppState, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_32s(IppsFIRState_32s** pState, int* pTaps, int tapsLen, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_64f(IppsFIRState_64f** ppState, double* pTaps, int tapsLen, double* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRInit_64fc(IppsFIRState_64fc** ppState, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMS32f_16s(short* pSrc, short* pRef, short* pDst, int len, float mu, IppsFIRLMSState32f_16s* pStatel);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSFree32f_16s(IppsFIRLMSState32f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSFree_32f(IppsFIRLMSState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSGetDlyLine32f_16s(IppsFIRLMSState32f_16s* pState, short* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSGetDlyLine_32f(IppsFIRLMSState_32f* pState, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSGetTaps32f_16s(IppsFIRLMSState32f_16s* pState, float* pOutTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSGetTaps_32f(IppsFIRLMSState_32f* pState, float* pOutTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSInitAlloc32f_16s(IppsFIRLMSState32f_16s** pState, float* pTaps, int tapsLen, short* pDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSInitAlloc_32f(IppsFIRLMSState_32f** pState, float* pTaps, int tapsLen, float* pDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRFree32s_16s(IppsFIRLMSMRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRFree32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetDlyLine32s_16s(IppsFIRLMSMRState32s_16s* pState, short* pOutDlyLine, int* pOutDlyIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetDlyLine32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, Ipp16sc* pOutDlyLine, int* pOutDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetDlyVal32s_16s(IppsFIRLMSMRState32s_16s* pState, short* pOutVal, int index);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetDlyVal32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, Ipp16sc* pOutVal, int index);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetTaps32s_16s(IppsFIRLMSMRState32s_16s* pState, int* pOutTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetTaps32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, Ipp32sc* pOutTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetTapsPointer32s_16s(IppsFIRLMSMRState32s_16s* pState, int** pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRGetTapsPointer32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, int** pTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRInitAlloc32s_16s(IppsFIRLMSMRState32s_16s** pState, int* pTaps, int tapsLen, short* pDlyLine, int dlyLineIndex, int dlyStep, int updateDly, int mu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRInitAlloc32sc_16sc(IppsFIRLMSMRState32sc_16sc** pState, Ipp32sc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int dlyLineIndex, int dlyStep, int updateDly, int mu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMROne32s_16s(int* pDstVal, IppsFIRLMSMRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMROne32sc_16sc(Ipp32sc* pDstVal, IppsFIRLMSMRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMROneVal32s_16s(short val, int* pDstVal, IppsFIRLMSMRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMROneVal32sc_16sc(Ipp16sc val, Ipp32sc* pDstVal, IppsFIRLMSMRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRPutVal32s_16s(short val, IppsFIRLMSMRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRPutVal32sc_16sc(Ipp16sc val, IppsFIRLMSMRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetDlyLine32s_16s(IppsFIRLMSMRState32s_16s* pState, short* pInDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetDlyLine32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, Ipp16sc* pInDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetMu32s_16s(IppsFIRLMSMRState32s_16s* pState, int mu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetMu32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, int mu);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetTaps32s_16s(IppsFIRLMSMRState32s_16s* pState, int* pInTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRSetTaps32sc_16sc(IppsFIRLMSMRState32sc_16sc* pState, Ipp32sc* pInTaps);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRUpdateTaps32s_16s(int ErrVal, IppsFIRLMSMRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSMRUpdateTaps32sc_16sc(Ipp32sc ErrVal, IppsFIRLMSMRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSOne_Direct32f_16s(short src, short refval, short* pDstVal, float* pTapsInv, int tapsLen, float mu, short* pDlyLine, int* pDlyIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSOne_DirectQ15_16s(short src, short refval, short* pDstVal, int* pTapsInv, int tapsLen, int muQ15, short* pDlyLine, int* pDlyIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSOne_Direct_32f(float src, float refval, float* pDstVal, float* pTapsInv, int tapsLen, float mu, float* pDlyLine, int* pDlyIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSSetDlyLine32f_16s(IppsFIRLMSState32f_16s* pState, short* pDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMSSetDlyLine_32f(IppsFIRLMSState_32f* pState, float* pDlyLine, int dlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRLMS_32f(float* pSrc, float* pRef, float* pDst, int len, float mu, IppsFIRLMSState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32f_Direct_16s_ISfs(short* pSrcDst, int numIters, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32f_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32fc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32fc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32s_Direct_16s_ISfs(short* pSrcDst, int numIters, int* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32s_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, int* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32sc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp32sc* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR32sc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp32sc* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_16s_ISfs(short* pSrcDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_32f(float* pSrc, float* pDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_32f_I(float* pSrcDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_32s_ISfs(int* pSrcDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, int* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64f_Direct_32s_Sfs(int* pSrc, int* pDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, int* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_16sc_ISfs(Ipp16sc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_32fc_I(Ipp32fc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_32sc_ISfs(Ipp32sc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR64fc_Direct_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32sc* pDlyLine, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32f_16s(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32fc_16sc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32s_16s(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32s_16s32f(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32sc_16sc(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize32sc_16sc32fc(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64f_16s(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64f_32f(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64f_32s(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64fc_16sc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64fc_32fc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize64fc_32sc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize_16s(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize_32f(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize_32fc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize_64f(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRGetStateSize_64fc(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32f_16s(IppsFIRState32f_16s** ppState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32fc_16sc(IppsFIRState32fc_16sc** ppState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32s_16s(IppsFIRState32s_16s** ppState, int* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32s_16s32f(IppsFIRState32s_16s** ppState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32sc_16sc(IppsFIRState32sc_16sc** ppState, Ipp32sc* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit32sc_16sc32fc(IppsFIRState32sc_16sc** ppState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64f_16s(IppsFIRState64f_16s** ppState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64f_32f(IppsFIRState64f_32f** ppState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64f_32s(IppsFIRState64f_32s** ppState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, int* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64fc_16sc(IppsFIRState64fc_16sc** ppState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64fc_32fc(IppsFIRState64fc_32fc** ppState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit64fc_32sc(IppsFIRState64fc_32sc** ppState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32sc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32f_16s(IppsFIRState32f_16s** pState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32fc_16sc(IppsFIRState32fc_16sc** pState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32s_16s(IppsFIRState32s_16s** pState, int* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32s_16s32f(IppsFIRState32s_16s** pState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32sc_16sc(IppsFIRState32sc_16sc** pState, Ipp32sc* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc32sc_16sc32fc(IppsFIRState32sc_16sc** pState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64f_16s(IppsFIRState64f_16s** pState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64f_32f(IppsFIRState64f_32f** pState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64f_32s(IppsFIRState64f_32s** pState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64fc_16sc(IppsFIRState64fc_16sc** pState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64fc_32fc(IppsFIRState64fc_32fc** pState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc64fc_32sc(IppsFIRState64fc_32sc** pState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc_16s(IppsFIRState_16s** pState, short* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc_32fc(IppsFIRState_32fc** pState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc_64f(IppsFIRState_64f** pState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInitAlloc_64fc(IppsFIRState_64fc** pState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit_16s(IppsFIRState_16s** ppState, short* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, short* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit_32f(IppsFIRState_32f** ppState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit_32fc(IppsFIRState_32fc** ppState, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit_64f(IppsFIRState_64f** ppState, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, double* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRInit_64fc(IppsFIRState_64fc** ppState, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp64fc* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamGetStateSize_16s(int tapsLen, int upFactor, int downFactor, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamGetStateSize_32f(int tapsLen, int upFactor, int downFactor, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamInitAlloc_16s(IppsFIRState_16s** pState, short* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamInitAlloc_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamInit_16s(IppsFIRState_16s** ppState, short* pTaps, int tapsLen, int tapsFactor, int upFactor, int upPhase, int downFactor, int downPhase, IppRoundMode rndMode, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMRStreamInit_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_32f(float* pSrc, float* pDst, int numIters, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_32f_I(float* pSrcDst, int numIters, float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_32fc_I(Ipp32fc* pSrcDst, int numIters, Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_64f(double* pSrc, double* pDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_64f_I(double* pSrcDst, int numIters, double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRMR_Direct_64fc_I(Ipp64fc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32f_16s_Sfs(short src, short* pDstVal, IppsFIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32f_Direct_16s_ISfs(short* pSrcDstVal, float* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32f_Direct_16s_Sfs(short src, short* pDstVal, float* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32fc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsFIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32fc_Direct_16sc_ISfs(Ipp16sc* pSrcDstVal, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32fc_Direct_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, Ipp32fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32s_16s_Sfs(short src, short* pDstVal, IppsFIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32s_Direct_16s_ISfs(short* pSrcDstVal, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32s_Direct_16s_Sfs(short src, short* pDstVal, int* pTaps, int tapsLen, int tapsFactor, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32sc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsFIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32sc_Direct_16sc_ISfs(Ipp16sc* pSrcDstVal, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne32sc_Direct_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, Ipp32sc* pTaps, int tapsLen, int tapsFactor, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_16s_Sfs(short src, short* pDstVal, IppsFIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_32f(float src, float* pDstVal, IppsFIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_32s_Sfs(int src, int* pDstVal, IppsFIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_16s_ISfs(short* pSrcDstVal, double* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_16s_Sfs(short src, short* pDstVal, double* pTaps, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_32f(float src, float* pDstVal, double* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_32f_I(float* pSrcDstVal, double* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_32s_ISfs(int* pSrcDstVal, double* pTaps, int tapsLen, int* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64f_Direct_32s_Sfs(int src, int* pDstVal, double* pTaps, int tapsLen, int* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsFIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_32fc(Ipp32fc src, Ipp32fc* pDstVal, IppsFIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_32sc_Sfs(Ipp32sc src, Ipp32sc* pDstVal, IppsFIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_16sc_ISfs(Ipp16sc* pSrcDstVal, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, Ipp64fc* pTaps, int tapsLen, Ipp16sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_32fc(Ipp32fc src, Ipp32fc* pDstVal, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_32fc_I(Ipp32fc* pSrcDstVal, Ipp64fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_32sc_ISfs(Ipp32sc* pSrcDstVal, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne64fc_Direct_32sc_Sfs(Ipp32sc src, Ipp32sc* pDstVal, Ipp64fc* pTaps, int tapsLen, Ipp32sc* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_16s_Sfs(short src, short* pDstVal, IppsFIRState_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_32f(float src, float* pDstVal, IppsFIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_32fc(Ipp32fc src, Ipp32fc* pDstVal, IppsFIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_32s_Sfs(int src, int* pDstVal, IppsFIRState_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_64f(double src, double* pDstVal, IppsFIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_64fc(Ipp64fc src, Ipp64fc* pDstVal, IppsFIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_16s_ISfs(short* pSrcDstVal, short* pTapsQ15, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_16s_Sfs(short src, short* pDstVal, short* pTapsQ15, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_32f(float src, float* pDstVal, float* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_32f_I(float* pSrcDstVal, float* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_32fc(Ipp32fc src, Ipp32fc* pDstVal, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_32fc_I(Ipp32fc* pSrcDstVal, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_64f(double src, double* pDstVal, double* pTaps, int tapsLen, double* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_64f_I(double* pSrcDstVal, double* pTaps, int tapsLen, double* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_64fc(Ipp64fc src, Ipp64fc* pDstVal, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIROne_Direct_64fc_I(Ipp64fc* pSrcDstVal, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine32f_16s(IppsFIRState32f_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine32fc_16sc(IppsFIRState32fc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine32s_16s(IppsFIRState32s_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine32sc_16sc(IppsFIRState32sc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64f_16s(IppsFIRState64f_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64f_32f(IppsFIRState64f_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64f_32s(IppsFIRState64f_32s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64fc_16sc(IppsFIRState64fc_16sc* pState, Ipp16sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64fc_32fc(IppsFIRState64fc_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine64fc_32sc(IppsFIRState64fc_32sc* pState, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine_16s(IppsFIRState_16s* pState, short* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine_32f(IppsFIRState_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine_32fc(IppsFIRState_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine_64f(IppsFIRState_64f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetDlyLine_64fc(IppsFIRState_64fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32f_16s(float* pTaps, IppsFIRState32f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32fc_16sc(Ipp32fc* pTaps, IppsFIRState32fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32s_16s(int* pTaps, IppsFIRState32s_16s* pState, int tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32s_16s32f(float* pTaps, IppsFIRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32sc_16sc(Ipp32sc* pTaps, IppsFIRState32sc_16sc* pState, int tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps32sc_16sc32fc(Ipp32fc* pTaps, IppsFIRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64f_16s(double* pTaps, IppsFIRState64f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64f_32f(double* pTaps, IppsFIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64f_32s(double* pTaps, IppsFIRState64f_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64fc_16sc(Ipp64fc* pTaps, IppsFIRState64fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64fc_32fc(Ipp64fc* pTaps, IppsFIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps64fc_32sc(Ipp64fc* pTaps, IppsFIRState64fc_32sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_16s(short* pTaps, IppsFIRState_16s* pState, int tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_32f(float* pTaps, IppsFIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_32fc(Ipp32fc* pTaps, IppsFIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_32s(int* pTaps, IppsFIRState_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_64f(double* pTaps, IppsFIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSetTaps_64fc(Ipp64fc* pTaps, IppsFIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSparseGetStateSize_32f(int nzTapsLen, int order, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSparseInit_32f(IppsFIRSparseState_32f** pState, float* pNZTaps, int* pNZTapPos, int nzTapsLen, float* pDlyLine, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRSparse_32f(float* pSrc, float* pDst, int len, IppsFIRSparseState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamGetStateSize_16s(int tapsLen, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamGetStateSize_32f(int tapsLen, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamInitAlloc_16s(IppsFIRState_16s** pState, short* pTaps, int tapsLen, int tapsFactor, IppRoundMode rndMode);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamInitAlloc_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamInit_16s(IppsFIRState_16s** pState, short* pTaps, int tapsLen, int tapsFactor, IppRoundMode rndMode, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIRStreamInit_32f(IppsFIRState_32f** pState, float* pTaps, int tapsLen, byte* pBuffer);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_16s_ISfs(short* pSrcDst, int numIters, IppsFIRState_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_16s_Sfs(short* pSrc, short* pDst, int numIters, IppsFIRState_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32f(float* pSrc, float* pDst, int numIters, IppsFIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32f_I(float* pSrcDst, int numIters, IppsFIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, IppsFIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32fc_I(Ipp32fc* pSrcDst, int numIters, IppsFIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32s_ISfs(int* pSrcDst, int numIters, IppsFIRState_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_32s_Sfs(int* pSrc, int* pDst, int numIters, IppsFIRState_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_64f(double* pSrc, double* pDst, int numIters, IppsFIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_64f_I(double* pSrcDst, int numIters, IppsFIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int numIters, IppsFIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_64fc_I(Ipp64fc* pSrcDst, int numIters, IppsFIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_16s_ISfs(short* pSrcDst, int numIters, short* pTapsQ15, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_16s_Sfs(short* pSrc, short* pDst, int numIters, short* pTapsQ15, int tapsLen, short* pDlyLine, int* pDlyLineIndex, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_32f(float* pSrc, float* pDst, int numIters, float* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_32f_I(float* pSrcDst, int numIters, float* pTaps, int tapsLen, float* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_32fc_I(Ipp32fc* pSrcDst, int numIters, Ipp32fc* pTaps, int tapsLen, Ipp32fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_64f(double* pSrc, double* pDst, int numIters, double* pTaps, int tapsLen, double* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_64f_I(double* pSrcDst, int numIters, double* pTaps, int tapsLen, double* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFIR_Direct_64fc_I(Ipp64fc* pSrcDst, int numIters, Ipp64fc* pTaps, int tapsLen, Ipp64fc* pDlyLine, int* pDlyLineIndex);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_16s(short* pSrc, short* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_16s_I(short* pSrcDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_32f(float* pSrc, float* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_32f_I(float* pSrcDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_32s(int* pSrc, int* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_32s_I(int* pSrcDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_64f(double* pSrc, double* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_64f_I(double* pSrcDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_8u(byte* pSrc, byte* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFilterMedian_8u_I(byte* pSrcDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFindNearestOne_16u(ushort inpVal, ushort* pOutVal, int* pOutIndex, ushort* pTable, int tblLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFindNearest_16u(ushort* pVals, ushort* pOutVals, int* pOutIndexes, int len, ushort* pTable, int tblLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_16u(ushort* pSrc, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_16u_I(ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsFlip_8u_I(byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname, EntryPoint = "ippsGetLibVersion")]
        public static extern
        int* xippsGetLibVersion();

        public static IppLibraryVersion ippsGetLibVersion()
        {
            return new IppLibraryVersion(xippsGetLibVersion());
        }

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGetVarPointDV_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, Ipp16sc* pVariantPoint, byte* pLabel, int state);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzQ15_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* pVal, short rFreqQ15, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwoQ15_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* pVal, short* rFreqQ15, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwo_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* val, float* rFreq, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwo_32f(float* pSrc, int len, Ipp32fc* val, float* rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwo_32fc(Ipp32fc* pSrc, int len, Ipp32fc* val, float* rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwo_64f(double* pSrc, int len, Ipp64fc* val, double* rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertzTwo_64fc(Ipp64fc* pSrc, int len, Ipp64fc* val, double* rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_16s_Sfs(short* pSrc, int len, Ipp16sc* pVal, float rFreq, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* pVal, float rFreq, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_32f(float* pSrc, int len, Ipp32fc* pVal, float rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_32fc(Ipp32fc* pSrc, int len, Ipp32fc* pVal, float rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_64f(double* pSrc, int len, Ipp64fc* pVal, double rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsGoertz_64fc(Ipp64fc* pSrc, int len, Ipp64fc* pVal, double rFreq);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertFree_16s16sc(IppsHilbertSpec_16s16sc* pSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertFree_16s32fc(IppsHilbertSpec_16s32fc* pSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertFree_32f32fc(IppsHilbertSpec_32f32fc* pSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertInitAlloc_16s16sc(IppsHilbertSpec_16s16sc** pSpec, int length, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertInitAlloc_16s32fc(IppsHilbertSpec_16s32fc** pSpec, int length, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbertInitAlloc_32f32fc(IppsHilbertSpec_32f32fc** pSpec, int length, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbert_16s16sc_Sfs(short* pSrc, Ipp16sc* pDst, IppsHilbertSpec_16s16sc* pSpec, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbert_16s32fc(short* pSrc, Ipp32fc* pDst, IppsHilbertSpec_16s32fc* pSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsHilbert_32f32fc(float* pSrc, Ipp32fc* pDst, IppsHilbertSpec_32f32fc* pSpec);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32f_16s_ISfs(short* pSrcDst, int len, IppsIIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32f_16s_Sfs(short* pSrc, short* pDst, int len, IppsIIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32fc_16sc_ISfs(Ipp16sc* pSrcDst, int len, IppsIIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32fc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, IppsIIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32s_16s_ISfs(short* pSrcDst, int len, IppsIIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32s_16s_Sfs(short* pSrc, short* pDst, int len, IppsIIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32sc_16sc_ISfs(Ipp16sc* pSrcDst, int len, IppsIIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR32sc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, IppsIIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_16s_ISfs(short* pSrcDst, int len, IppsIIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_16s_Sfs(short* pSrc, short* pDst, int len, IppsIIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32f(float* pSrc, float* pDst, int len, IppsIIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32f_I(float* pSrcDst, int len, IppsIIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32s_IPSfs(int** ppSrcDst, int len, int nChannels, IppsIIRState64f_32s** ppState, int* pScaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32s_ISfs(int* pSrcDst, int len, IppsIIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32s_PSfs(int** ppSrc, int** ppDst, int len, int nChannels, IppsIIRState64f_32s** ppState, int* pScaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64f_32s_Sfs(int* pSrc, int* pDst, int len, IppsIIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_16sc_ISfs(Ipp16sc* pSrcDst, int len, IppsIIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, IppsIIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, IppsIIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_32fc_I(Ipp32fc* pSrcDst, int len, IppsIIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_32sc_ISfs(Ipp32sc* pSrcDst, int len, IppsIIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR64fc_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc* pDst, int len, IppsIIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree32f_16s(IppsIIRState32f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree32fc_16sc(IppsIIRState32fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree32s_16s(IppsIIRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree32sc_16sc(IppsIIRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64f_16s(IppsIIRState64f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64f_32f(IppsIIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64f_32s(IppsIIRState64f_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64fc_16sc(IppsIIRState64fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64fc_32fc(IppsIIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree64fc_32sc(IppsIIRState64fc_32sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree_32f(IppsIIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree_32fc(IppsIIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree_64f(IppsIIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRFree_64fc(IppsIIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGenHighpass_64f(double rFreq, double ripple, int order, double* pTaps, IppsIIRFilterType filterType);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGenLowpass_64f(double rFreq, double ripple, int order, double* pTaps, IppsIIRFilterType filterType);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine32f_16s(IppsIIRState32f_16s* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine32fc_16sc(IppsIIRState32fc_16sc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine32s_16s(IppsIIRState32s_16s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine32sc_16sc(IppsIIRState32sc_16sc* pState, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64f_16s(IppsIIRState64f_16s* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64f_32f(IppsIIRState64f_32f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64f_32s(IppsIIRState64f_32s* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64f_DF1_32s(IppsIIRState64f_32s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64fc_16sc(IppsIIRState64fc_16sc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64fc_32fc(IppsIIRState64fc_32fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine64fc_32sc(IppsIIRState64fc_32sc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine_32f(IppsIIRState_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine_32fc(IppsIIRState_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine_64f(IppsIIRState_64f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetDlyLine_64fc(IppsIIRState_64fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32f_16s(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32f_BiQuad_16s(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32fc_16sc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32fc_BiQuad_16sc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32s_16s(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32s_16s32f(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32s_BiQuad_16s(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32s_BiQuad_16s32f(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32sc_16sc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32sc_16sc32fc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32sc_BiQuad_16sc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize32sc_BiQuad_16sc32fc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_16s(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_32f(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_32s(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_BiQuad_16s(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_BiQuad_32f(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_BiQuad_32s(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64f_BiQuad_DF1_32s(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_16sc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_32fc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_32sc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_BiQuad_16sc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_BiQuad_32fc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize64fc_BiQuad_32sc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_32f(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_32fc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_64f(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_64fc(int order, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_BiQuad_32f(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_BiQuad_32fc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_BiQuad_64f(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_BiQuad_64fc(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRGetStateSize_BiQuad_DF1_32f(int numBq, int* pBufferSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32f_16s(IppsIIRState32f_16s** ppState, float* pTaps, int order, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32f_BiQuad_16s(IppsIIRState32f_16s** ppState, float* pTaps, int numBq, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32fc_16sc(IppsIIRState32fc_16sc** ppState, Ipp32fc* pTaps, int order, Ipp32fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32fc_BiQuad_16sc(IppsIIRState32fc_16sc** ppState, Ipp32fc* pTaps, int numBq, Ipp32fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32s_16s(IppsIIRState32s_16s** ppState, int* pTaps, int order, int tapsFactor, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32s_16s32f(IppsIIRState32s_16s** ppState, float* pTaps, int order, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32s_BiQuad_16s(IppsIIRState32s_16s** ppState, int* pTaps, int numBq, int tapsFactor, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32s_BiQuad_16s32f(IppsIIRState32s_16s** ppState, float* pTaps, int numBq, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32sc_16sc(IppsIIRState32sc_16sc** ppState, Ipp32sc* pTaps, int order, int tapsFactor, Ipp32sc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32sc_16sc32fc(IppsIIRState32sc_16sc** ppState, Ipp32fc* pTaps, int order, Ipp32sc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32sc_BiQuad_16sc(IppsIIRState32sc_16sc** ppState, Ipp32sc* pTaps, int numBq, int tapsFactor, Ipp32sc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit32sc_BiQuad_16sc32fc(IppsIIRState32sc_16sc** ppState, Ipp32fc* pTaps, int numBq, Ipp32sc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_16s(IppsIIRState64f_16s** ppState, double* pTaps, int order, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_32f(IppsIIRState64f_32f** ppState, double* pTaps, int order, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_32s(IppsIIRState64f_32s** ppState, double* pTaps, int order, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_BiQuad_16s(IppsIIRState64f_16s** ppState, double* pTaps, int numBq, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_BiQuad_32f(IppsIIRState64f_32f** ppState, double* pTaps, int numBq, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_BiQuad_32s(IppsIIRState64f_32s** ppState, double* pTaps, int numBq, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64f_BiQuad_DF1_32s(IppsIIRState64f_32s** ppState, double* pTaps, int numBq, int* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_16sc(IppsIIRState64fc_16sc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_32fc(IppsIIRState64fc_32fc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_32sc(IppsIIRState64fc_32sc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_BiQuad_16sc(IppsIIRState64fc_16sc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_BiQuad_32fc(IppsIIRState64fc_32fc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit64fc_BiQuad_32sc(IppsIIRState64fc_32sc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32f_16s(IppsIIRState32f_16s** ppState, float* pTaps, int order, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32f_BiQuad_16s(IppsIIRState32f_16s** ppState, float* pTaps, int numBq, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32fc_16sc(IppsIIRState32fc_16sc** ppState, Ipp32fc* pTaps, int order, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32fc_BiQuad_16sc(IppsIIRState32fc_16sc** ppState, Ipp32fc* pTaps, int numBq, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32s_16s(IppsIIRState32s_16s** ppState, int* pTaps, int order, int tapsFactor, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32s_16s32f(IppsIIRState32s_16s** ppState, float* pTaps, int order, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32s_BiQuad_16s(IppsIIRState32s_16s** ppState, int* pTaps, int numBq, int tapsFactor, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32s_BiQuad_16s32f(IppsIIRState32s_16s** ppState, float* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32sc_16sc(IppsIIRState32sc_16sc** ppState, Ipp32sc* pTaps, int order, int tapsFactor, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32sc_16sc32fc(IppsIIRState32sc_16sc** ppState, Ipp32fc* pTaps, int order, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32sc_BiQuad_16sc(IppsIIRState32sc_16sc** ppState, Ipp32sc* pTaps, int numBq, int tapsFactor, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc32sc_BiQuad_16sc32fc(IppsIIRState32sc_16sc** ppState, Ipp32fc* pTaps, int numBq, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_16s(IppsIIRState64f_16s** ppState, double* pTaps, int order, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_32f(IppsIIRState64f_32f** ppState, double* pTaps, int order, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_32s(IppsIIRState64f_32s** ppState, double* pTaps, int order, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_BiQuad_16s(IppsIIRState64f_16s** ppState, double* pTaps, int numBq, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_BiQuad_32f(IppsIIRState64f_32f** ppState, double* pTaps, int numBq, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_BiQuad_32s(IppsIIRState64f_32s** ppState, double* pTaps, int numBq, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64f_BiQuad_DF1_32s(IppsIIRState64f_32s** ppState, double* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_16sc(IppsIIRState64fc_16sc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_32fc(IppsIIRState64fc_32fc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_32sc(IppsIIRState64fc_32sc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_BiQuad_16sc(IppsIIRState64fc_16sc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_BiQuad_32fc(IppsIIRState64fc_32fc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc64fc_BiQuad_32sc(IppsIIRState64fc_32sc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_32f(IppsIIRState_32f** ppState, float* pTaps, int order, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_32fc(IppsIIRState_32fc** ppState, Ipp32fc* pTaps, int order, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_64f(IppsIIRState_64f** ppState, double* pTaps, int order, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_64fc(IppsIIRState_64fc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_BiQuad_32f(IppsIIRState_32f** ppState, float* pTaps, int numBq, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_BiQuad_32fc(IppsIIRState_32fc** ppState, Ipp32fc* pTaps, int numBq, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_BiQuad_64f(IppsIIRState_64f** ppState, double* pTaps, int numBq, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_BiQuad_64fc(IppsIIRState_64fc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInitAlloc_BiQuad_DF1_32f(IppsIIRState_32f** pState, float* pTaps, int numBq, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_32f(IppsIIRState_32f** ppState, float* pTaps, int order, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_32fc(IppsIIRState_32fc** ppState, Ipp32fc* pTaps, int order, Ipp32fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_64f(IppsIIRState_64f** ppState, double* pTaps, int order, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_64fc(IppsIIRState_64fc** ppState, Ipp64fc* pTaps, int order, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_BiQuad_32f(IppsIIRState_32f** ppState, float* pTaps, int numBq, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_BiQuad_32fc(IppsIIRState_32fc** ppState, Ipp32fc* pTaps, int numBq, Ipp32fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_BiQuad_64f(IppsIIRState_64f** ppState, double* pTaps, int numBq, double* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_BiQuad_64fc(IppsIIRState_64fc** ppState, Ipp64fc* pTaps, int numBq, Ipp64fc* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRInit_BiQuad_DF1_32f(IppsIIRState_32f** pState, float* pTaps, int numBq, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne32f_16s_Sfs(short src, short* pDstVal, IppsIIRState32f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne32fc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsIIRState32fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne32s_16s_Sfs(short src, short* pDstVal, IppsIIRState32s_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne32sc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsIIRState32sc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64f_16s_Sfs(short src, short* pDstVal, IppsIIRState64f_16s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64f_32f(float src, float* pDstVal, IppsIIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64f_32s_Sfs(int src, int* pDstVal, IppsIIRState64f_32s* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64fc_16sc_Sfs(Ipp16sc src, Ipp16sc* pDstVal, IppsIIRState64fc_16sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64fc_32fc(Ipp32fc src, Ipp32fc* pDstVal, IppsIIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne64fc_32sc_Sfs(Ipp32sc src, Ipp32sc* pDstVal, IppsIIRState64fc_32sc* pState, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_32f(float src, float* pDstVal, IppsIIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_32fc(Ipp32fc src, Ipp32fc* pDstVal, IppsIIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_64f(double src, double* pDstVal, IppsIIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_64fc(Ipp64fc src, Ipp64fc* pDstVal, IppsIIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_BiQuadDirect_16s(short src, short* pDstVal, short* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_BiQuadDirect_16s_I(short* pSrcDstVal, short* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_Direct_16s(short src, short* pDstVal, short* pTaps, int order, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIROne_Direct_16s_I(short* pSrcDst, short* pTaps, int order, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine32f_16s(IppsIIRState32f_16s* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine32fc_16sc(IppsIIRState32fc_16sc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine32s_16s(IppsIIRState32s_16s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine32sc_16sc(IppsIIRState32sc_16sc* pState, Ipp32sc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64f_16s(IppsIIRState64f_16s* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64f_32f(IppsIIRState64f_32f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64f_32s(IppsIIRState64f_32s* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64f_DF1_32s(IppsIIRState64f_32s* pState, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64fc_16sc(IppsIIRState64fc_16sc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64fc_32fc(IppsIIRState64fc_32fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine64fc_32sc(IppsIIRState64fc_32sc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine_32f(IppsIIRState_32f* pState, float* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine_32fc(IppsIIRState_32fc* pState, Ipp32fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine_64f(IppsIIRState_64f* pState, double* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetDlyLine_64fc(IppsIIRState_64fc* pState, Ipp64fc* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32f_16s(float* pTaps, IppsIIRState32f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32fc_16sc(Ipp32fc* pTaps, IppsIIRState32fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32s_16s(int* pTaps, IppsIIRState32s_16s* pState, int tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32s_16s32f(float* pTaps, IppsIIRState32s_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32sc_16sc(Ipp32sc* pTaps, IppsIIRState32sc_16sc* pState, int tapsFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps32sc_16sc32fc(Ipp32fc* pTaps, IppsIIRState32sc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64f_16s(double* pTaps, IppsIIRState64f_16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64f_32f(double* pTaps, IppsIIRState64f_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64f_32s(double* pTaps, IppsIIRState64f_32s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64fc_16sc(Ipp64fc* pTaps, IppsIIRState64fc_16sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64fc_32fc(Ipp64fc* pTaps, IppsIIRState64fc_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps64fc_32sc(Ipp64fc* pTaps, IppsIIRState64fc_32sc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps_32f(float* pTaps, IppsIIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps_32fc(Ipp32fc* pTaps, IppsIIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps_64f(double* pTaps, IppsIIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSetTaps_64fc(Ipp64fc* pTaps, IppsIIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSparseGetStateSize_32f(int nzTapsLen1, int nzTapsLen2, int order1, int order2, int* pStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSparseInit_32f(IppsIIRSparseState_32f** pState, float* pNZTaps, int* pNZTapPos, int nzTapsLen1, int nzTapsLen2, float* pDlyLine, byte* pBuf);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIRSparse_32f(float* pSrc, float* pDst, int len, IppsIIRSparseState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32f(float* pSrc, float* pDst, int len, IppsIIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32f_I(float* pSrcDst, int len, IppsIIRState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32f_IP(float** ppSrcDst, int len, int nChannels, IppsIIRState_32f** ppState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32f_P(float** ppSrc, float** ppDst, int len, int nChannels, IppsIIRState_32f** ppState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, IppsIIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_32fc_I(Ipp32fc* pSrcDst, int len, IppsIIRState_32fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_64f(double* pSrc, double* pDst, int len, IppsIIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_64f_I(double* pSrcDst, int len, IppsIIRState_64f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, IppsIIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_64fc_I(Ipp64fc* pSrcDst, int len, IppsIIRState_64fc* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_BiQuadDirect_16s(short* pSrc, short* pDst, int len, short* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_BiQuadDirect_16s_I(short* pSrcDst, int len, short* pTaps, int numBq, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_Direct_16s(short* pSrc, short* pDst, int len, short* pTaps, int order, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsIIR_Direct_16s_I(short* pSrcDst, int len, short* pTaps, int order, int* pDlyLine);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsImag_16sc(Ipp16sc* pSrc, short* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsImag_32fc(Ipp32fc* pSrc, float* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsImag_64fc(Ipp64fc* pSrc, double* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsJoinScaled_32f16s_D2L(float** pSrc, int nChannels, int chanLen, short* pDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsJoinScaled_32f24s_D2L(float** pSrc, int nChannels, int chanLen, byte* pDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsJoin_32f16s_D2L(float** pSrc, int nChannels, int chanLen, short* pDst);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_16s(short* pSrc, int val, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_16s_I(int val, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_16u(ushort* pSrc, int val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_16u_I(int val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_32s(int* pSrc, int val, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_32s_I(int val, int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_8u(byte* pSrc, int val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLShiftC_8u_I(int val, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLinToALaw_16s8u(short* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLinToALaw_32f8u(float* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLinToMuLaw_16s8u(short* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLinToMuLaw_32f8u(float* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_16s_ISfs(short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_16s_Sfs(short* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_32s16s_Sfs(int* pSrc, short* pDst, int Len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_32s_ISfs(int* pSrcDst, int Len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_32s_Sfs(int* pSrc, int* pDst, int Len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_64f32f(double* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsLn_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagSquared_32fc64f(Ipp32fc* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagSquared_32sc32s_Sfs(Ipp32sc* pSrc, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_16s32f(short* pSrcRe, short* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_16sc32f(Ipp16sc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_16sc_Sfs(Ipp16sc* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_32f(float* pSrcRe, float* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_32fc(Ipp32fc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_32sc_Sfs(Ipp32sc* pSrc, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_64f(double* pSrcRe, double* pSrcIm, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMagnitude_64fc(Ipp64fc* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxAbsIndx_16s(short* pSrc, int len, short* pMaxAbs, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxAbsIndx_32s(int* pSrc, int len, int* pMaxAbs, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxAbs_16s(short* pSrc, int len, short* pMaxAbs);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxAbs_32s(int* pSrc, int len, int* pMaxAbs);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_16s_I(short* pSrc, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_16u_I(ushort* pSrc, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_32f(float* pSrc1, float* pSrc2, float* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_32s_I(int* pSrc, int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_64f(double* pSrc1, double* pSrc2, double* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_64f_I(double* pSrc, double* pSrcDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_8u(byte* pSrc1, byte* pSrc2, byte* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxEvery_8u_I(byte* pSrc, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxIndx_16s(short* pSrc, int len, short* pMax, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxIndx_32f(float* pSrc, int len, float* pMax, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxIndx_32s(int* pSrc, int len, int* pMax, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxIndx_64f(double* pSrc, int len, double* pMax, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxOrder_16s(short* pSrc, int len, int* pOrder);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxOrder_32f(float* pSrc, int len, int* pOrder);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxOrder_32s(int* pSrc, int len, int* pOrder);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMaxOrder_64f(double* pSrc, int len, int* pOrder);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMax_16s(short* pSrc, int len, short* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMax_32f(float* pSrc, int len, float* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMax_32s(int* pSrc, int len, int* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMax_64f(double* pSrc, int len, double* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMeanStdDev_16s32s_Sfs(short* pSrc, int len, int* pMean, int* pStdDev, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMeanStdDev_16s_Sfs(short* pSrc, int len, short* pMean, short* pStdDev, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMeanStdDev_32f(float* pSrc, int len, float* pMean, float* pStdDev, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMeanStdDev_64f(double* pSrc, int len, double* pMean, double* pStdDev);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_16s_Sfs(short* pSrc, int len, short* pMean, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* pMean, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_32f(float* pSrc, int len, float* pMean, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_32fc(Ipp32fc* pSrc, int len, Ipp32fc* pMean, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_32s_Sfs(int* pSrc, int len, int* pMean, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_64f(double* pSrc, int len, double* pMean);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMean_64fc(Ipp64fc* pSrc, int len, Ipp64fc* pMean);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinAbsIndx_16s(short* pSrc, int len, short* pMinAbs, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinAbsIndx_32s(int* pSrc, int len, int* pMinAbs, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinAbs_16s(short* pSrc, int len, short* pMinAbs);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinAbs_32s(int* pSrc, int len, int* pMinAbs);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_16s_I(short* pSrc, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_16u_I(ushort* pSrc, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_32f(float* pSrc1, float* pSrc2, float* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_32s_I(int* pSrc, int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_64f(double* pSrc1, double* pSrc2, double* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_64f_I(double* pSrc, double* pSrcDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_8u(byte* pSrc1, byte* pSrc2, byte* pDst, uint len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinEvery_8u_I(byte* pSrc, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinIndx_16s(short* pSrc, int len, short* pMin, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinIndx_32f(float* pSrc, int len, float* pMin, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinIndx_32s(int* pSrc, int len, int* pMin, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinIndx_64f(double* pSrc, int len, double* pMin, int* pIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_16s(short* pSrc, int len, short* pMin, int* pMinIndx, short* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_16u(ushort* pSrc, int len, ushort* pMin, int* pMinIndx, ushort* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_32f(float* pSrc, int len, float* pMin, int* pMinIndx, float* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_32s(int* pSrc, int len, int* pMin, int* pMinIndx, int* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_32u(uint* pSrc, int len, uint* pMin, int* pMinIndx, uint* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_64f(double* pSrc, int len, double* pMin, int* pMinIndx, double* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMaxIndx_8u(byte* pSrc, int len, byte* pMin, int* pMinIndx, byte* pMax, int* pMaxIndx);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_16s(short* pSrc, int len, short* pMin, short* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_16u(ushort* pSrc, int len, ushort* pMin, ushort* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_32f(float* pSrc, int len, float* pMin, float* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_32s(int* pSrc, int len, int* pMin, int* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_32u(uint* pSrc, int len, uint* pMin, uint* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_64f(double* pSrc, int len, double* pMin, double* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMinMax_8u(byte* pSrc, int len, byte* pMin, byte* pMax);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMin_16s(short* pSrc, int len, short* pMin);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMin_32f(float* pSrc, int len, float* pMin);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMin_32s(int* pSrc, int len, int* pMin);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMin_64f(double* pSrc, int len, double* pMin);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_32s(int* pSrc, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_32sc(Ipp32sc* pSrc, Ipp32sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_64s(long* pSrc, long* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_64sc(Ipp64sc* pSrc, Ipp64sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMove_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMuLawToALaw_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMuLawToLin_8u16s(byte* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMuLawToLin_8u32f(byte* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16s_I(short val, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16s_ISfs(short val, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16s_Sfs(short* pSrc, short val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16u_ISfs(ushort val, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_16u_Sfs(ushort* pSrc, ushort val, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32f16s_Sfs(float* pSrc, float val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32fc(Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32s_ISfs(int val, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32s_Sfs(int* pSrc, int val, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64f(double* pSrc, double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64f64s_ISfs(double val, long* pSrcDst, uint len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64f_I(double val, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64fc(Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_64s_ISfs(long val, long* pSrcDst, uint len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_8u_ISfs(byte val, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_8u_Sfs(byte* pSrc, byte val, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulC_Low_32f16s(float* pSrc, float val, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPackConj_32f_I(float* pSrc, float* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPackConj_64f_I(double* pSrc, double* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_16s_ISfs(short* pSrc, short* pSrcDst, int length, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int length, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_32f(float* pSrc1, float* pSrc2, float* pDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_32f_I(float* pSrc, float* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_64f(double* pSrc1, double* pSrc2, double* pDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPack_64f_I(double* pSrc, double* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_16s_ISfs(short* pSrc, short* pSrcDst, int length, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int length, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_32f(float* pSrc1, float* pSrc2, float* pDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_32f_I(float* pSrc, float* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_64f(double* pSrc1, double* pSrc2, double* pDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMulPerm_64f_I(double* pSrc, double* pSrcDst, int length);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s(short* pSrc1, short* pSrc2, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s32f(short* pSrc1, short* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s32s_Sfs(short* pSrc1, short* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s_I(short* pSrc, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s_ISfs(short* pSrc, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16sc_ISfs(Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16u16s_Sfs(ushort* pSrc1, short* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16u_ISfs(ushort* pSrc, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_16u_Sfs(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32f(float* pSrc1, float* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32f32fc(float* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32f32fc_I(float* pSrc, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32fc_I(Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32s32sc_ISfs(int* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32s32sc_Sfs(int* pSrc1, Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32s_ISfs(int* pSrc, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32s_Sfs(int* pSrc1, int* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32sc_ISfs(Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_32sc_Sfs(Ipp32sc* pSrc1, Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_64f(double* pSrc1, double* pSrc2, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_64f_I(double* pSrc, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_64fc_I(Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_8u16u(byte* pSrc1, byte* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_8u_ISfs(byte* pSrc, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_8u_Sfs(byte* pSrc1, byte* pSrc2, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsMul_Low_32s_Sfs(int* pSrc1, int* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_16s32f(short* pSrc1, short* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_16s32s_Sfs(short* pSrc1, short* pSrc2, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_32f(float* pSrc1, float* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_32fc32f(Ipp32fc* pSrc1, Ipp32fc* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_64f(double* pSrc1, double* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_Inf_64fc64f(Ipp64fc* pSrc1, Ipp64fc* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_16s32f(short* pSrc1, short* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_16s32s_Sfs(short* pSrc1, short* pSrc2, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_16s64s_Sfs(short* pSrc1, short* pSrc2, int len, long* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_32f(float* pSrc1, float* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_32fc64f(Ipp32fc* pSrc1, Ipp32fc* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_64f(double* pSrc1, double* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L1_64fc64f(Ipp64fc* pSrc1, Ipp64fc* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2Sqr_16s64s_Sfs(short* pSrc1, short* pSrc2, int len, long* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_16s32f(short* pSrc1, short* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_16s32s_Sfs(short* pSrc1, short* pSrc2, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_32f(float* pSrc1, float* pSrc2, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_32fc64f(Ipp32fc* pSrc1, Ipp32fc* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_64f(double* pSrc1, double* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormDiff_L2_64fc64f(Ipp64fc* pSrc1, Ipp64fc* pSrc2, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_16s32f(short* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_16s32s_Sfs(short* pSrc, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_32f(float* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_32fc32f(Ipp32fc* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_64f(double* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_Inf_64fc64f(Ipp64fc* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_16s32f(short* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_16s32s_Sfs(short* pSrc, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_16s64s_Sfs(short* pSrc, int len, long* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_32f(float* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_32fc64f(Ipp32fc* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_64f(double* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L1_64fc64f(Ipp64fc* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2Sqr_16s64s_Sfs(short* pSrc, int len, long* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_16s32f(short* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_16s32s_Sfs(short* pSrc, int len, int* pNorm, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_32f(float* pSrc, int len, float* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_32fc64f(Ipp32fc* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_64f(double* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNorm_L2_64fc64f(Ipp64fc* pSrc, int len, double* pNorm);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_16s_Sfs(short* pSrc, short* pDst, int len, short vsub, int vdiv, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, Ipp16sc vsub, int vdiv, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_32f(float* pSrc, float* pDst, int len, float vsub, float vdiv);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, Ipp32fc vsub, float vdiv);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_64f(double* pSrc, double* pDst, int len, double vsub, double vdiv);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNormalize_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, Ipp64fc vsub, double vdiv);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_16u(ushort* pSrc, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_16u_I(ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_32u(uint* pSrc, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_32u_I(uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_8u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsNot_8u_I(byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_16u(ushort* pSrc, ushort val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_16u_I(ushort val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_32u(uint* pSrc, uint val, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_32u_I(uint val, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_8u(byte* pSrc, byte val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOrC_8u_I(byte val, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_16u_I(ushort* pSrc, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_32u(uint* pSrc1, uint* pSrc2, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_32u_I(uint* pSrc, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_8u(byte* pSrc1, byte* pSrc2, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsOr_8u_I(byte* pSrc, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPackBits_32u8u(uint* pSrcBit, int* pSrcBits, int srcLen, byte* pDst, int dstBitOffset, int* pDstLenBit);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_16s32f(short* pSrcRe, short* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_16sc32f(Ipp16sc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_16sc_Sfs(Ipp16sc* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_32f(float* pSrcRe, float* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_32fc(Ipp32fc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_32sc_Sfs(Ipp32sc* pSrc, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_64f(double* pSrcRe, double* pSrcIm, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPhase_64fc(Ipp64fc* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_16sc(short* pSrcMagn, short* pSrcPhase, int phaseFixedPoint, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_16sc_Sfs(short* pSrcMagn, short* pSrcPhase, Ipp16sc* pDst, int len, int magnScaleFactor, int phaseScaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_32f(float* pSrcMagn, float* pSrcPhase, float* pDstRe, float* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_32fc(float* pSrcMagn, float* pSrcPhase, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_32sc(int* pSrcMagn, int* pSrcPhase, int phaseFixedPoint, Ipp32sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_64f(double* pSrcMagn, double* pSrcPhase, double* pDstRe, double* pDstIm, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPolarToCart_64fc(double* pSrcMagn, double* pSrcPhase, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_16s32f(short* pSrcRe, short* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_16s_Sfs(short* pSrcRe, short* pSrcIm, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_16sc32f(Ipp16sc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_16sc_Sfs(Ipp16sc* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_32f(float* pSrcRe, float* pSrcIm, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_32fc(Ipp32fc* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_64f(double* pSrcRe, double* pSrcIm, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPowerSpectr_64fc(Ipp64fc* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPreemphasize_16s(short* pSrcDst, int len, float val);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsPreemphasize_32f(float* pSrcDst, int len, float val);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_16s(short* pSrc, int val, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_16s_I(int val, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_16u(ushort* pSrc, int val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_16u_I(int val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_32s(int* pSrc, int val, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_32s_I(int val, int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_8u(byte* pSrc, int val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRShiftC_8u_I(int val, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussFree_16s(IppsRandGaussState_16s* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussFree_32f(IppsRandGaussState_32f* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussFree_8u(IppsRandGaussState_8u* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussGetSize_16s(int* pRandGaussStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussInitAlloc_16s(IppsRandGaussState_16s** pRandGaussState, short mean, short stdDev, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussInitAlloc_32f(IppsRandGaussState_32f** pRandGaussState, float mean, float stdDev, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussInitAlloc_8u(IppsRandGaussState_8u** pRandGaussState, byte mean, byte stdDev, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGaussInit_16s(IppsRandGaussState_16s* pRandGaussState, short mean, short stdDev, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_16s(short* pDst, int len, IppsRandGaussState_16s* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_32f(float* pDst, int len, IppsRandGaussState_32f* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_8u(byte* pDst, int len, IppsRandGaussState_8u* pRandGaussState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_Direct_16s(short* pDst, int len, short mean, short stdev, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_Direct_32f(float* pDst, int len, float mean, float stdev, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandGauss_Direct_64f(double* pDst, int len, double mean, double stdev, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformFree_16s(IppsRandUniState_16s* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformFree_32f(IppsRandUniState_32f* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformFree_8u(IppsRandUniState_8u* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformGetSize_16s(int* pRandUniformStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformInitAlloc_16s(IppsRandUniState_16s** pRandUniState, short low, short high, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformInitAlloc_32f(IppsRandUniState_32f** pRandUniState, float low, float high, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformInitAlloc_8u(IppsRandUniState_8u** pRandUniState, byte low, byte high, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniformInit_16s(IppsRandUniState_16s* pRandUniState, short low, short high, uint seed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_16s(short* pDst, int len, IppsRandUniState_16s* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_32f(float* pDst, int len, IppsRandUniState_32f* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_8u(byte* pDst, int len, IppsRandUniState_8u* pRandUniState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_Direct_16s(short* pDst, int len, short low, short high, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_Direct_32f(float* pDst, int len, float low, float high, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRandUniform_Direct_64f(double* pDst, int len, double low, double high, uint* pSeed);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRealToCplx_16s(short* pSrcRe, short* pSrcIm, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRealToCplx_32f(float* pSrcRe, float* pSrcIm, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsRealToCplx_64f(double* pSrcRe, double* pSrcIm, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsReal_16sc(Ipp16sc* pSrc, short* pDstRe, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsReal_32fc(Ipp32fc* pSrc, float* pDstRe, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsReal_64fc(Ipp64fc* pSrc, double* pDstRe, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_16s(short* pSrc, int srcLen, short* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_16sc(Ipp16sc* pSrc, int srcLen, Ipp16sc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_32f(float* pSrc, int srcLen, float* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_32fc(Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_64f(double* pSrc, int srcLen, double* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleDown_64fc(Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_16s(short* pSrc, int srcLen, short* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_16sc(Ipp16sc* pSrc, int srcLen, Ipp16sc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_32f(float* pSrc, int srcLen, float* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_32fc(Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_64f(double* pSrc, int srcLen, double* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSampleUp_64fc(Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int* dstLen, int factor, int* phase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_16s(short val, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_16sc(Ipp16sc val, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_32f(float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_32fc(Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_32s(int val, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_32sc(Ipp32sc val, Ipp32sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_64f(double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_64fc(Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_64s(long val, long* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_64sc(Ipp64sc val, Ipp64sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSet_8u(byte val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_16u_I(ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_32s_I(int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortAscend_8u_I(byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_16u_I(ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_32s_I(int* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortDescend_8u_I(byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_16s_I(short* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_16u_I(ushort* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_32f_I(float* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_32s_I(int* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_64f_I(double* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexAscend_8u_I(byte* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_16s_I(short* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_16u_I(ushort* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_32f_I(float* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_32s_I(int* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_64f_I(double* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortIndexDescend_8u_I(byte* pSrcDst, int* pDstIdx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_16s_I(short* pSrcDst, short* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_16u_I(ushort* pSrcDst, ushort* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_32f_I(float* pSrcDst, float* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_32s_I(int* pSrcDst, int* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_32u_I(uint* pSrcDst, uint* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_64f_I(double* pSrcDst, double* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixAscend_8u_I(byte* pSrcDst, byte* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_16s_I(short* pSrcDst, short* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_16u_I(ushort* pSrcDst, ushort* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_32f_I(float* pSrcDst, float* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_32s_I(int* pSrcDst, int* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_32u_I(uint* pSrcDst, uint* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_64f_I(double* pSrcDst, double* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixDescend_8u_I(byte* pSrcDst, byte* pTmp, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_16s(short* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_16u(ushort* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_32f(float* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_32s(int* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_32u(uint* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexAscend_8u(byte* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_16s(short* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_16u(ushort* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_32f(float* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_32s(int* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_32u(uint* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSortRadixIndexDescend_8u(byte* pSrc, int srcStrideBytes, int* pDstIndx, int* pTmpIndx, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSplitScaled_16s32f_D2L(short* pSrc, float** pDst, int nChannels, int chanLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSplitScaled_24s32f_D2L(byte* pSrc, float** pDst, int nChannels, int chanLen);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16s_ISfs(short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16s_Sfs(short* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16sc_ISfs(Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16u_ISfs(ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_16u_Sfs(ushort* pSrc, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_8u_ISfs(byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqr_8u_Sfs(byte* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16s_ISfs(short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16s_Sfs(short* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16sc_ISfs(Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16u_ISfs(ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_16u_Sfs(ushort* pSrc, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_32s16s_Sfs(int* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64s16s_Sfs(long* pSrc, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64s_ISfs(long* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_64s_Sfs(long* pSrc, long* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_8u_ISfs(byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSqrt_8u_Sfs(byte* pSrc, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsStdDev_16s32s_Sfs(short* pSrc, int len, int* pStdDev, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsStdDev_16s_Sfs(short* pSrc, int len, short* pStdDev, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsStdDev_32f(float* pSrc, int len, float* pStdDev, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsStdDev_64f(double* pSrc, int len, double* pStdDev);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16s_ISfs(short val, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16s_Sfs(short* pSrc, short val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16u_ISfs(ushort val, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_16u_Sfs(ushort* pSrc, ushort val, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32fc(Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32s_ISfs(int val, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32s_Sfs(int* pSrc, int val, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_64f(double* pSrc, double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_64f_I(double val, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_64fc(Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_8u_ISfs(byte val, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubCRev_8u_Sfs(byte* pSrc, byte val, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16s_I(short val, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16s_ISfs(short val, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16s_Sfs(short* pSrc, short val, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16sc_Sfs(Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16u_ISfs(ushort val, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_16u_Sfs(ushort* pSrc, ushort val, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32f(float* pSrc, float val, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32f_I(float val, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32fc(Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32s_ISfs(int val, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32s_Sfs(int* pSrc, int val, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_32sc_Sfs(Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_64f(double* pSrc, double val, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_64f_I(double val, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_64fc(Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_8u_ISfs(byte val, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSubC_8u_Sfs(byte* pSrc, byte val, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16s(short* pSrc1, short* pSrc2, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16s32f(short* pSrc1, short* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16s_I(short* pSrc, short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16s_ISfs(short* pSrc, short* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16s_Sfs(short* pSrc1, short* pSrc2, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16sc_ISfs(Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16sc_Sfs(Ipp16sc* pSrc1, Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16u_ISfs(ushort* pSrc, ushort* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_16u_Sfs(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32f(float* pSrc1, float* pSrc2, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32f_I(float* pSrc, float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32fc(Ipp32fc* pSrc1, Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32fc_I(Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32s_ISfs(int* pSrc, int* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32s_Sfs(int* pSrc1, int* pSrc2, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32sc_ISfs(Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_32sc_Sfs(Ipp32sc* pSrc1, Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_64f(double* pSrc1, double* pSrc2, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_64f_I(double* pSrc, double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_64fc(Ipp64fc* pSrc1, Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_64fc_I(Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_8u_ISfs(byte* pSrc, byte* pSrcDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSub_8u_Sfs(byte* pSrc1, byte* pSrc2, byte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumLn_16s32f(short* pSrc, int len, float* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumLn_32f(float* pSrc, int len, float* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumLn_32f64f(float* pSrc, int len, double* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumLn_64f(double* pSrc, int len, double* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumWindow_16s32f(short* pSrc, float* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSumWindow_8u32f(byte* pSrc, float* pDst, int len, int maskSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_16s32s_Sfs(short* pSrc, int len, int* pSum, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_16s_Sfs(short* pSrc, int len, short* pSum, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_16sc32sc_Sfs(Ipp16sc* pSrc, int len, Ipp32sc* pSum, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_16sc_Sfs(Ipp16sc* pSrc, int len, Ipp16sc* pSum, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_32f(float* pSrc, int len, float* pSum, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_32fc(Ipp32fc* pSrc, int len, Ipp32fc* pSum, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_32s_Sfs(int* pSrc, int len, int* pSum, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_64f(double* pSrc, int len, double* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSum_64fc(Ipp64fc* pSrc, int len, Ipp64fc* pSum);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_16u(ushort* pSrc, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_16u_I(ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_24u(byte* pSrc, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_24u_I(byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_32u(uint* pSrc, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_32u_I(uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_64u(ulong* pSrc, ulong* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsSwapBytes_64u_I(ulong* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_16s(short* pSrc, short* pDst, int len, short level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_16s_I(short* pSrcDst, int len, short level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, short level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_16sc_I(Ipp16sc* pSrcDst, int len, short level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_32f(float* pSrc, float* pDst, int len, float level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_32f_I(float* pSrcDst, int len, float level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_32fc_I(Ipp32fc* pSrcDst, int len, float level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_64f(double* pSrc, double* pDst, int len, double level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_64f_I(double* pSrcDst, int len, double level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_64fc_I(Ipp64fc* pSrcDst, int len, double level, IppCmpOp relOp);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_16s(short* pSrc, short* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_16s_I(short* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_32f(float* pSrc, float* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_32f_I(float* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_32s(int* pSrc, int* pDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_32s_I(int* pSrcDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_64f(double* pSrc, double* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTAbs_64f_I(double* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_16s(short* pSrc, short* pDst, int len, short level, short value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_16s_I(short* pSrcDst, int len, short level, short value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, short level, Ipp16sc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_16sc_I(Ipp16sc* pSrcDst, int len, short level, Ipp16sc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_32f(float* pSrc, float* pDst, int len, float level, float value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_32f_I(float* pSrcDst, int len, float level, float value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level, Ipp32fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_32fc_I(Ipp32fc* pSrcDst, int len, float level, Ipp32fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_64f(double* pSrc, double* pDst, int len, double level, double value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_64f_I(double* pSrcDst, int len, double level, double value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level, Ipp64fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GTVal_64fc_I(Ipp64fc* pSrcDst, int len, double level, Ipp64fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_16s(short* pSrc, short* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_16s_I(short* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_16sc_I(Ipp16sc* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32f(float* pSrc, float* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32f_I(float* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32fc_I(Ipp32fc* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32s(int* pSrc, int* pDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_32s_I(int* pSrcDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_64f(double* pSrc, double* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_64f_I(double* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_GT_64fc_I(Ipp64fc* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_16s(short* pSrc, short* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_16s_I(short* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_32f(float* pSrc, float* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_32f_I(float* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_32s(int* pSrc, int* pDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_32s_I(int* pSrcDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_64f(double* pSrc, double* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTAbs_64f_I(double* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_32f(float* pSrc, float* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_32f_I(float* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_32fc_I(Ipp32fc* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_64f(double* pSrc, double* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_64f_I(double* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTInv_64fc_I(Ipp64fc* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_16s(short* pSrc, short* pDst, int len, short levelLT, short valueLT, short levelGT, short valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_16s_I(short* pSrcDst, int len, short levelLT, short valueLT, short levelGT, short valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_32f(float* pSrc, float* pDst, int len, float levelLT, float valueLT, float levelGT, float valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_32f_I(float* pSrcDst, int len, float levelLT, float valueLT, float levelGT, float valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_32s(int* pSrc, int* pDst, int len, int levelLT, int valueLT, int levelGT, int valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_32s_I(int* pSrcDst, int len, int levelLT, int valueLT, int levelGT, int valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_64f(double* pSrc, double* pDst, int len, double levelLT, double valueLT, double levelGT, double valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTValGTVal_64f_I(double* pSrcDst, int len, double levelLT, double valueLT, double levelGT, double valueGT);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_16s(short* pSrc, short* pDst, int len, short level, short value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_16s_I(short* pSrcDst, int len, short level, short value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, short level, Ipp16sc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_16sc_I(Ipp16sc* pSrcDst, int len, short level, Ipp16sc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_32f(float* pSrc, float* pDst, int len, float level, float value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_32f_I(float* pSrcDst, int len, float level, float value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level, Ipp32fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_32fc_I(Ipp32fc* pSrcDst, int len, float level, Ipp32fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_64f(double* pSrc, double* pDst, int len, double level, double value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_64f_I(double* pSrcDst, int len, double level, double value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level, Ipp64fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LTVal_64fc_I(Ipp64fc* pSrcDst, int len, double level, Ipp64fc value);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_16s(short* pSrc, short* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_16s_I(short* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_16sc_I(Ipp16sc* pSrcDst, int len, short level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32f(float* pSrc, float* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32f_I(float* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32fc_I(Ipp32fc* pSrcDst, int len, float level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32s(int* pSrc, int* pDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_32s_I(int* pSrcDst, int len, int level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_64f(double* pSrc, double* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_64f_I(double* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsThreshold_LT_64fc_I(Ipp64fc* pSrcDst, int len, double level);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneFree(IppToneState_16s* pToneState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneGetStateSizeQ15_16s(int* pToneStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneInitAllocQ15_16s(IppToneState_16s** pToneState, short magn, short rFreqQ15, int phaseQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneInitQ15_16s(IppToneState_16s* pToneState, short magn, short rFreqQ15, int phaseQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneQ15_16s(short* pDst, int len, IppToneState_16s* pToneState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsToneQ15_Direct_16s(short* pDst, int len, short magn, short rFreqQ15, int phaseQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_16s(short* pDst, int len, short magn, float rFreq, float* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_16sc(Ipp16sc* pDst, int len, short magn, float rFreq, float* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_32f(float* pDst, int len, float magn, float rFreq, float* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_32fc(Ipp32fc* pDst, int len, float magn, float rFreq, float* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_64f(double* pDst, int len, double magn, double rFreq, double* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTone_Direct_64fc(Ipp64fc* pDst, int len, double magn, double rFreq, double* pPhase, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleFree(IppTriangleState_16s* pTriangleState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleGetStateSizeQ15_16s(int* pTriangleStateSize);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleInitAllocQ15_16s(IppTriangleState_16s** pTriangleState, short magn, short rFreqQ15, int phaseQ15, int asymQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleInitQ15_16s(IppTriangleState_16s* pTriangleState, short magn, short rFreqQ15, int phaseQ15, int asymQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleQ15_16s(short* pDst, int len, IppTriangleState_16s* pTriangleState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangleQ15_Direct_16s(short* pDst, int len, short magn, short rFreqQ15, int phaseQ15, int asymQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_16s(short* pDst, int len, short magn, float rFreq, float asym, float* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_16sc(Ipp16sc* pDst, int len, short magn, float rFreq, float asym, float* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_32f(float* pDst, int len, float magn, float rFreq, float asym, float* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_32fc(Ipp32fc* pDst, int len, float magn, float rFreq, float asym, float* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_64f(double* pDst, int len, double magn, double rFreq, double asym, double* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsTriangle_Direct_64fc(Ipp64fc* pDst, int len, double magn, double rFreq, double asym, double* pPhase);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsUpdateLinear_16s32s_I(short* pSrc, int len, int* pSrcDst, int srcShiftRight, short alpha, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsUpdatePathMetricsDV_16u(ushort* pBranchError, ushort* pMinPathError, byte* pMinSost, ushort* pPathError, int state);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsUpdatePower_16s32s_I(short* pSrc, int len, int* pSrcDst, int srcShiftRight, short alpha, IppHintAlgorithm hint);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_16s(short* pDst, int len, short magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_16u(ushort* pDst, int len, ushort magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_32f(float* pDst, int len, float magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_32s(int* pDst, int len, int magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_32u(uint* pDst, int len, uint magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_64f(double* pDst, int len, double magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_8s(sbyte* pDst, int len, sbyte magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorJaehne_8u(byte* pDst, int len, byte magn);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_16s(short* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_16u(ushort* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_32f(float* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_32s(int* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_32u(uint* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_64f(double* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_8s(sbyte* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorRamp_8u(byte* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_16s(short* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_16u(ushort* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_32f(float* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_32s(int* pDst, int len, double offset, double slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_32u(uint* pDst, int len, double offset, double slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_64f(double* pDst, int len, double offset, double slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_8s(sbyte* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsVectorSlope_8u(byte* pDst, int len, float offset, float slope);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdFree_16s32f(IppsWTFwdState_16s32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdFree_16u32f(IppsWTFwdState_16u32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdFree_32f(IppsWTFwdState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdFree_8s32f(IppsWTFwdState_8s32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdFree_8u32f(IppsWTFwdState_8u32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdGetDlyLine_16s32f(IppsWTFwdState_16s32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdGetDlyLine_16u32f(IppsWTFwdState_16u32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdGetDlyLine_32f(IppsWTFwdState_32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdGetDlyLine_8s32f(IppsWTFwdState_8s32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdGetDlyLine_8u32f(IppsWTFwdState_8u32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdInitAlloc_16s32f(IppsWTFwdState_16s32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdInitAlloc_16u32f(IppsWTFwdState_16u32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdInitAlloc_32f(IppsWTFwdState_32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdInitAlloc_8s32f(IppsWTFwdState_8s32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdInitAlloc_8u32f(IppsWTFwdState_8u32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdSetDlyLine_16s32f(IppsWTFwdState_16s32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdSetDlyLine_16u32f(IppsWTFwdState_16u32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdSetDlyLine_32f(IppsWTFwdState_32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdSetDlyLine_8s32f(IppsWTFwdState_8s32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwdSetDlyLine_8u32f(IppsWTFwdState_8u32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwd_16s32f(short* pSrc, float* pDstLow, float* pDstHigh, int dstLen, IppsWTFwdState_16s32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwd_16u32f(ushort* pSrc, float* pDstLow, float* pDstHigh, int dstLen, IppsWTFwdState_16u32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwd_32f(float* pSrc, float* pDstLow, float* pDstHigh, int dstLen, IppsWTFwdState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwd_8s32f(sbyte* pSrc, float* pDstLow, float* pDstHigh, int dstLen, IppsWTFwdState_8s32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTFwd_8u32f(byte* pSrc, float* pDstLow, float* pDstHigh, int dstLen, IppsWTFwdState_8u32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_16s(short* pSrc, int len, short* pDstLow, short* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_16s_Sfs(short* pSrc, int len, short* pDstLow, short* pDstHigh, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_32f(float* pSrc, int len, float* pDstLow, float* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_32s(int* pSrc, int len, int* pDstLow, int* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_32s_Sfs(int* pSrc, int len, int* pDstLow, int* pDstHigh, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_64f(double* pSrc, int len, double* pDstLow, double* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_64s(long* pSrc, int len, long* pDstLow, long* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_64s_Sfs(long* pSrc, int len, long* pDstLow, long* pDstHigh, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_8s(sbyte* pSrc, int len, sbyte* pDstLow, sbyte* pDstHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarFwd_8s_Sfs(sbyte* pSrc, int len, sbyte* pDstLow, sbyte* pDstHigh, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_16s(short* pSrcLow, short* pSrcHigh, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_16s_Sfs(short* pSrcLow, short* pSrcHigh, short* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_32f(float* pSrcLow, float* pSrcHigh, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_32s(int* pSrcLow, int* pSrcHigh, int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_32s_Sfs(int* pSrcLow, int* pSrcHigh, int* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_64f(double* pSrcLow, double* pSrcHigh, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_64s(long* pSrcLow, long* pSrcHigh, long* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_64s_Sfs(long* pSrcLow, long* pSrcHigh, long* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_8s(sbyte* pSrcLow, sbyte* pSrcHigh, sbyte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTHaarInv_8s_Sfs(sbyte* pSrcLow, sbyte* pSrcHigh, sbyte* pDst, int len, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvFree_32f(IppsWTInvState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvFree_32f16s(IppsWTInvState_32f16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvFree_32f16u(IppsWTInvState_32f16u* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvFree_32f8s(IppsWTInvState_32f8s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvFree_32f8u(IppsWTInvState_32f8u* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvGetDlyLine_32f(IppsWTInvState_32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvGetDlyLine_32f16s(IppsWTInvState_32f16s* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvGetDlyLine_32f16u(IppsWTInvState_32f16u* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvGetDlyLine_32f8s(IppsWTInvState_32f8s* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvGetDlyLine_32f8u(IppsWTInvState_32f8u* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvInitAlloc_32f(IppsWTInvState_32f** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvInitAlloc_32f16s(IppsWTInvState_32f16s** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvInitAlloc_32f16u(IppsWTInvState_32f16u** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvInitAlloc_32f8s(IppsWTInvState_32f8s** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvInitAlloc_32f8u(IppsWTInvState_32f8u** pState, float* pTapsLow, int lenLow, int offsLow, float* pTapsHigh, int lenHigh, int offsHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvSetDlyLine_32f(IppsWTInvState_32f* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvSetDlyLine_32f16s(IppsWTInvState_32f16s* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvSetDlyLine_32f16u(IppsWTInvState_32f16u* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvSetDlyLine_32f8s(IppsWTInvState_32f8s* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInvSetDlyLine_32f8u(IppsWTInvState_32f8u* pState, float* pDlyLow, float* pDlyHigh);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInv_32f(float* pSrcLow, float* pSrcHigh, int srcLen, float* pDst, IppsWTInvState_32f* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInv_32f16s(float* pSrcLow, float* pSrcHigh, int srcLen, short* pDst, IppsWTInvState_32f16s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInv_32f16u(float* pSrcLow, float* pSrcHigh, int srcLen, ushort* pDst, IppsWTInvState_32f16u* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInv_32f8s(float* pSrcLow, float* pSrcHigh, int srcLen, sbyte* pDst, IppsWTInvState_32f8s* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWTInv_32f8u(float* pSrcLow, float* pSrcHigh, int srcLen, byte* pDst, IppsWTInvState_32f8u* pState);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBartlett_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanOpt_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanQ15_16s(short* pSrc, short* pDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanQ15_16s_I(short* pSrcDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanQ15_16s_ISfs(short* pSrcDst, int len, int alphaQ15, int scaleFactor);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanQ15_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanQ15_16sc_I(Ipp16sc* pSrcDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackmanStd_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_16s(short* pSrc, short* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_16s_I(short* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_16sc_I(Ipp16sc* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_32f(float* pSrc, float* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_32f_I(float* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_32fc_I(Ipp32fc* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_64f(double* pSrc, double* pDst, int len, double alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_64f_I(double* pSrcDst, int len, double alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, double alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinBlackman_64fc_I(Ipp64fc* pSrcDst, int len, double alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHamming_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_16s(short* pSrc, short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_16s_I(short* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_16sc_I(Ipp16sc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_32f(float* pSrc, float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_32f_I(float* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_32fc_I(Ipp32fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_64f(double* pSrc, double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_64f_I(double* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinHann_64fc_I(Ipp64fc* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiserQ15_16s(short* pSrc, short* pDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiserQ15_16s_I(short* pSrcDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiserQ15_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiserQ15_16sc_I(Ipp16sc* pSrcDst, int len, int alphaQ15);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_16s(short* pSrc, short* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_16s_I(short* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_16sc(Ipp16sc* pSrc, Ipp16sc* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_16sc_I(Ipp16sc* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_32f(float* pSrc, float* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_32f_I(float* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_32fc(Ipp32fc* pSrc, Ipp32fc* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_32fc_I(Ipp32fc* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_64f(double* pSrc, double* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_64f_I(double* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_64fc(Ipp64fc* pSrc, Ipp64fc* pDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsWinKaiser_64fc_I(Ipp64fc* pSrcDst, int len, float alpha);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_16u(ushort* pSrc, ushort val, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_16u_I(ushort val, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_32u(uint* pSrc, uint val, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_32u_I(uint val, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_8u(byte* pSrc, byte val, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXorC_8u_I(byte val, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_16u(ushort* pSrc1, ushort* pSrc2, ushort* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_16u_I(ushort* pSrc, ushort* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_32u(uint* pSrc1, uint* pSrc2, uint* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_32u_I(uint* pSrc, uint* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_8u(byte* pSrc1, byte* pSrc2, byte* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsXor_8u_I(byte* pSrc, byte* pSrcDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZeroCrossing_16s32f(short* pSrc, uint len, float* pValZCR, IppsZCType zcType);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZeroCrossing_32f(float* pSrc, uint len, float* pValZCR, IppsZCType zcType);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_16s(short* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_16sc(Ipp16sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_32f(float* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_32fc(Ipp32fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_32s(int* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_32sc(Ipp32sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_64f(double* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_64fc(Ipp64fc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_64s(long* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_64sc(Ipp64sc* pDst, int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern
        IppStatus ippsZero_8u(byte* pDst, int len);
    };
};