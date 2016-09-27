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

using System;
using System.Runtime.InteropServices;

namespace CSIntel.Ipp
{
    //
    // enums
    //
    public enum IppDataType
    {
        ippUndef = -1,
        ipp1u = 0,
        ipp8u = 1,
        ipp8uc = 2,
        ipp8s = 3,
        ipp8sc = 4,
        ipp16u = 5,
        ipp16uc = 6,
        ipp16s = 7,
        ipp16sc = 8,
        ipp32u = 9,
        ipp32uc = 10,
        ipp32s = 11,
        ipp32sc = 12,
        ipp32f = 13,
        ipp32fc = 14,
        ipp64u = 15,
        ipp64uc = 16,
        ipp64s = 17,
        ipp64sc = 18,
        ipp64f = 19,
        ipp64fc = 20,
    };

    public enum IppCpuType
    {
        ippCpuUnknown = 0,
        ippCpuPP = 1,
        ippCpuPMX = 2,
        ippCpuPPR = 3,
        ippCpuPII = 4,
        ippCpuPIII = 5,
        ippCpuP4 = 6,
        ippCpuP4HT = 7,
        ippCpuP4HT2 = 8,
        ippCpuCentrino = 9,
        ippCpuCoreSolo = 10,
        ippCpuCoreDuo = 11,
        ippCpuITP = 16,
        ippCpuITP2 = 17,
        ippCpuEM64T = 32,
        ippCpuC2D = 33,
        ippCpuC2Q = 34,
        ippCpuPenryn = 35,
        ippCpuBonnell = 36,
        ippCpuNehalem = 37,
        ippCpuNext = 38,
        ippCpuSSE = 64,
        ippCpuSSE2 = 65,
        ippCpuSSE3 = 66,
        ippCpuSSSE3 = 67,
        ippCpuSSE41 = 68,
        ippCpuSSE42 = 69,
        ippCpuAVX = 70,
        ippCpuAES = 71,
        ippCpuX8664 = 96,
    };

    public enum IppsZCType
    {
        ippZCR = 0,
        ippZCXor = 1,
        ippZCC = 2,
    };

    public enum IppsIIRFilterType
    {
        ippButterworth = 0,
        ippChebyshev1 = 1,
    };

    public enum IppBool
    {
        ippFalse = 0,
        ippTrue = 1,
    };

    public enum IppStatus
    {
        ippStsNotSupportedModeErr = -9999,
        ippStsCpuNotSupportedErr = -9998,
        ippStsDitherTypeErr = -224,
        ippStsH264BufferFullErr = -223,
        ippStsWrongAffinitySettingErr = -222,
        ippStsLoadDynErr = -221,
        ippStsPointAtInfinity = -220,
        ippStsI18nUnsupportedErr = -219,
        ippStsI18nMsgCatalogOpenErr = -218,
        ippStsI18nMsgCatalogCloseErr = -217,
        ippStsUnknownStatusCodeErr = -216,
        ippStsOFBSizeErr = -215,
        ippStsLzoBrokenStreamErr = -214,
        ippStsRoundModeNotSupportedErr = -213,
        ippStsDecimateFractionErr = -212,
        ippStsWeightErr = -211,
        ippStsQualityIndexErr = -210,
        ippStsIIRPassbandRippleErr = -209,
        ippStsFilterFrequencyErr = -208,
        ippStsFIRGenOrderErr = -207,
        ippStsIIRGenOrderErr = -206,
        ippStsConvergeErr = -205,
        ippStsSizeMatchMatrixErr = -204,
        ippStsCountMatrixErr = -203,
        ippStsRoiShiftMatrixErr = -202,
        ippStsResizeNoOperationErr = -201,
        ippStsSrcDataErr = -200,
        ippStsMaxLenHuffCodeErr = -199,
        ippStsCodeLenTableErr = -198,
        ippStsFreqTableErr = -197,
        ippStsIncompleteContextErr = -196,
        ippStsSingularErr = -195,
        ippStsSparseErr = -194,
        ippStsBitOffsetErr = -193,
        ippStsQPErr = -192,
        ippStsVLCErr = -191,
        ippStsRegExpOptionsErr = -190,
        ippStsRegExpErr = -189,
        ippStsRegExpMatchLimitErr = -188,
        ippStsRegExpQuantifierErr = -187,
        ippStsRegExpGroupingErr = -186,
        ippStsRegExpBackRefErr = -185,
        ippStsRegExpChClassErr = -184,
        ippStsRegExpMetaChErr = -183,
        ippStsStrideMatrixErr = -182,
        ippStsCTRSizeErr = -181,
        ippStsJPEG2KCodeBlockIsNotAttached = -180,
        ippStsNotPosDefErr = -179,
        ippStsEphemeralKeyErr = -178,
        ippStsMessageErr = -177,
        ippStsShareKeyErr = -176,
        ippStsIvalidPublicKey = -175,
        ippStsIvalidPrivateKey = -174,
        ippStsOutOfECErr = -173,
        ippStsECCInvalidFlagErr = -172,
        ippStsMP3FrameHeaderErr = -171,
        ippStsMP3SideInfoErr = -170,
        ippStsBlockStepErr = -169,
        ippStsMBStepErr = -168,
        ippStsAacPrgNumErr = -167,
        ippStsAacSectCbErr = -166,
        ippStsAacSfValErr = -164,
        ippStsAacCoefValErr = -163,
        ippStsAacMaxSfbErr = -162,
        ippStsAacPredSfbErr = -161,
        ippStsAacPlsDataErr = -160,
        ippStsAacGainCtrErr = -159,
        ippStsAacSectErr = -158,
        ippStsAacTnsNumFiltErr = -157,
        ippStsAacTnsLenErr = -156,
        ippStsAacTnsOrderErr = -155,
        ippStsAacTnsCoefResErr = -154,
        ippStsAacTnsCoefErr = -153,
        ippStsAacTnsDirectErr = -152,
        ippStsAacTnsProfileErr = -151,
        ippStsAacErr = -150,
        ippStsAacBitOffsetErr = -149,
        ippStsAacAdtsSyncWordErr = -148,
        ippStsAacSmplRateIdxErr = -147,
        ippStsAacWinLenErr = -146,
        ippStsAacWinGrpErr = -145,
        ippStsAacWinSeqErr = -144,
        ippStsAacComWinErr = -143,
        ippStsAacStereoMaskErr = -142,
        ippStsAacChanErr = -141,
        ippStsAacMonoStereoErr = -140,
        ippStsAacStereoLayerErr = -139,
        ippStsAacMonoLayerErr = -138,
        ippStsAacScalableErr = -137,
        ippStsAacObjTypeErr = -136,
        ippStsAacWinShapeErr = -135,
        ippStsAacPcmModeErr = -134,
        ippStsVLCUsrTblHeaderErr = -133,
        ippStsVLCUsrTblUnsupportedFmtErr = -132,
        ippStsVLCUsrTblEscAlgTypeErr = -131,
        ippStsVLCUsrTblEscCodeLengthErr = -130,
        ippStsVLCUsrTblCodeLengthErr = -129,
        ippStsVLCInternalTblErr = -128,
        ippStsVLCInputDataErr = -127,
        ippStsVLCAACEscCodeLengthErr = -126,
        ippStsNoiseRangeErr = -125,
        ippStsUnderRunErr = -124,
        ippStsPaddingErr = -123,
        ippStsCFBSizeErr = -122,
        ippStsPaddingSchemeErr = -121,
        ippStsInvalidCryptoKeyErr = -120,
        ippStsLengthErr = -119,
        ippStsBadModulusErr = -118,
        ippStsLPCCalcErr = -117,
        ippStsRCCalcErr = -116,
        ippStsIncorrectLSPErr = -115,
        ippStsNoRootFoundErr = -114,
        ippStsJPEG2KBadPassNumber = -113,
        ippStsJPEG2KDamagedCodeBlock = -112,
        ippStsH263CBPYCodeErr = -111,
        ippStsH263MCBPCInterCodeErr = -110,
        ippStsH263MCBPCIntraCodeErr = -109,
        ippStsNotEvenStepErr = -108,
        ippStsHistoNofLevelsErr = -107,
        ippStsLUTNofLevelsErr = -106,
        ippStsMP4BitOffsetErr = -105,
        ippStsMP4QPErr = -104,
        ippStsMP4BlockIdxErr = -103,
        ippStsMP4BlockTypeErr = -102,
        ippStsMP4MVCodeErr = -101,
        ippStsMP4VLCCodeErr = -100,
        ippStsMP4DCCodeErr = -99,
        ippStsMP4FcodeErr = -98,
        ippStsMP4AlignErr = -97,
        ippStsMP4TempDiffErr = -96,
        ippStsMP4BlockSizeErr = -95,
        ippStsMP4ZeroBABErr = -94,
        ippStsMP4PredDirErr = -93,
        ippStsMP4BitsPerPixelErr = -92,
        ippStsMP4VideoCompModeErr = -91,
        ippStsMP4LinearModeErr = -90,
        ippStsH263PredModeErr = -83,
        ippStsH263BlockStepErr = -82,
        ippStsH263MBStepErr = -81,
        ippStsH263FrameWidthErr = -80,
        ippStsH263FrameHeightErr = -79,
        ippStsH263ExpandPelsErr = -78,
        ippStsH263PlaneStepErr = -77,
        ippStsH263QuantErr = -76,
        ippStsH263MVCodeErr = -75,
        ippStsH263VLCCodeErr = -74,
        ippStsH263DCCodeErr = -73,
        ippStsH263ZigzagLenErr = -72,
        ippStsFBankFreqErr = -71,
        ippStsFBankFlagErr = -70,
        ippStsFBankErr = -69,
        ippStsNegOccErr = -67,
        ippStsCdbkFlagErr = -66,
        ippStsSVDCnvgErr = -65,
        ippStsJPEGHuffTableErr = -64,
        ippStsJPEGDCTRangeErr = -63,
        ippStsJPEGOutOfBufErr = -62,
        ippStsDrawTextErr = -61,
        ippStsChannelOrderErr = -60,
        ippStsZeroMaskValuesErr = -59,
        ippStsQuadErr = -58,
        ippStsRectErr = -57,
        ippStsCoeffErr = -56,
        ippStsNoiseValErr = -55,
        ippStsDitherLevelsErr = -54,
        ippStsNumChannelsErr = -53,
        ippStsCOIErr = -52,
        ippStsDivisorErr = -51,
        ippStsAlphaTypeErr = -50,
        ippStsGammaRangeErr = -49,
        ippStsGrayCoefSumErr = -48,
        ippStsChannelErr = -47,
        ippStsToneMagnErr = -46,
        ippStsToneFreqErr = -45,
        ippStsTonePhaseErr = -44,
        ippStsTrnglMagnErr = -43,
        ippStsTrnglFreqErr = -42,
        ippStsTrnglPhaseErr = -41,
        ippStsTrnglAsymErr = -40,
        ippStsHugeWinErr = -39,
        ippStsJaehneErr = -38,
        ippStsStrideErr = -37,
        ippStsEpsValErr = -36,
        ippStsWtOffsetErr = -35,
        ippStsAnchorErr = -34,
        ippStsMaskSizeErr = -33,
        ippStsShiftErr = -32,
        ippStsSampleFactorErr = -31,
        ippStsSamplePhaseErr = -30,
        ippStsFIRMRFactorErr = -29,
        ippStsFIRMRPhaseErr = -28,
        ippStsRelFreqErr = -27,
        ippStsFIRLenErr = -26,
        ippStsIIROrderErr = -25,
        ippStsDlyLineIndexErr = -24,
        ippStsResizeFactorErr = -23,
        ippStsInterpolationErr = -22,
        ippStsMirrorFlipErr = -21,
        ippStsMoment00ZeroErr = -20,
        ippStsThreshNegLevelErr = -19,
        ippStsThresholdErr = -18,
        ippStsContextMatchErr = -17,
        ippStsFftFlagErr = -16,
        ippStsFftOrderErr = -15,
        ippStsStepErr = -14,
        ippStsScaleRangeErr = -13,
        ippStsDataTypeErr = -12,
        ippStsOutOfRangeErr = -11,
        ippStsDivByZeroErr = -10,
        ippStsMemAllocErr = -9,
        ippStsNullPtrErr = -8,
        ippStsRangeErr = -7,
        ippStsSizeErr = -6,
        ippStsBadArgErr = -5,
        ippStsNoMemErr = -4,
        ippStsSAReservedErr3 = -3,
        ippStsErr = -2,
        ippStsSAReservedErr1 = -1,
        ippStsNoErr = 0,
        ippStsNoOperation = 1,
        ippStsMisalignedBuf = 2,
        ippStsSqrtNegArg = 3,
        ippStsInvZero = 4,
        ippStsEvenMedianMaskSize = 5,
        ippStsDivByZero = 6,
        ippStsLnZeroArg = 7,
        ippStsLnNegArg = 8,
        ippStsNanArg = 9,
        ippStsJPEGMarker = 10,
        ippStsResFloor = 11,
        ippStsOverflow = 12,
        ippStsLSFLow = 13,
        ippStsLSFHigh = 14,
        ippStsLSFLowAndHigh = 15,
        ippStsZeroOcc = 16,
        ippStsUnderflow = 17,
        ippStsSingularity = 18,
        ippStsDomain = 19,
        ippStsNonIntelCpu = 20,
        ippStsCpuMismatch = 21,
        ippStsNoIppFunctionFound = 22,
        ippStsDllNotFoundBestUsed = 23,
        ippStsNoOperationInDll = 24,
        ippStsInsufficientEntropy = 25,
        ippStsOvermuchStrings = 26,
        ippStsOverlongString = 27,
        ippStsAffineQuadChanged = 28,
        ippStsWrongIntersectROI = 29,
        ippStsWrongIntersectQuad = 30,
        ippStsSmallerCodebook = 31,
        ippStsSrcSizeLessExpected = 32,
        ippStsDstSizeLessExpected = 33,
        ippStsStreamEnd = 34,
        ippStsDoubleSize = 35,
        ippStsNotSupportedCpu = 36,
        ippStsUnknownCacheSize = 37,
        ippStsSymKernelExpected = 38,
        ippStsEvenMedianWeight = 39,
        ippStsWrongIntersectVOI = 40,
        ippStsI18nMsgCatalogInvalid = 41,
        ippStsI18nGetMessageFail = 42,
        ippStsWaterfall = 43,
        ippStsPrevLibraryUsed = 44,
        ippStsLLADisabled = 45,
        ippStsNoAntialiasing = 46,
        ippStsRepetitiveSrcData = 47,
    };

    public enum IppWinType
    {
        ippWinBartlett = 0,
        ippWinBlackman = 1,
        ippWinHamming = 2,
        ippWinHann = 3,
        ippWinRect = 4,
    };

    public enum IppRoundMode
    {
        ippRndZero = 0,
        ippRndNear = 1,
        ippRndFinancial = 2,
    };

    public enum IppCmpOp
    {
        ippCmpLess = 0,
        ippCmpLessEq = 1,
        ippCmpEq = 2,
        ippCmpGreaterEq = 3,
        ippCmpGreater = 4,
    };

    public enum IppiMaskSize
    {
        ippMskSize1x3 = 13,
        ippMskSize1x5 = 15,
        ippMskSize3x1 = 31,
        ippMskSize3x3 = 33,
        ippMskSize5x1 = 51,
        ippMskSize5x5 = 55,
    };

    public enum IppHintAlgorithm
    {
        ippAlgHintNone = 0,
        ippAlgHintFast = 1,
        ippAlgHintAccurate = 2,
    };

    public enum IppiFraction
    {
        ippPolyphase_1_2 = 0,
        ippPolyphase_3_5 = 1,
        ippPolyphase_2_3 = 2,
        ippPolyphase_7_10 = 3,
        ippPolyphase_3_4 = 4,
    };

    public enum IppChannels
    {
        ippC0 = 0,
        ippC1 = 1,
        ippC2 = 2,
        ippC3 = 3,
        ippC4 = 4,
        ippP2 = 5,
        ippP3 = 6,
        ippP4 = 7,
        ippAC1 = 8,
        ippAC4 = 9,
        ippA0C4 = 10,
        ippAP4 = 11,
    };

    public enum IppiBorderType
    {
        ippBorderConst = 0,
        ippBorderRepl = 1,
        ippBorderWrap = 2,
        ippBorderMirror = 3,
        ippBorderMirrorR = 4,
        ippBorderMirror2 = 5,
        ippBorderInMem = 6,
        ippBorderInMemTop = 16,
        ippBorderInMemBottom = 32,
        ippBorderInMemLeft = 64,
        ippBorderInMemRight = 128,
    };

    //
    // hidden or own structures
    //
    [StructLayout(LayoutKind.Sequential)]
    public struct IppsVLCDecodeSpec_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsVLCDecodeUTupleSpec_32s { };

    [StructLayout(LayoutKind.Sequential)]
    public struct IppsVLCEncodeSpec_32s { };

    //
    // open structures
    //
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp32fc
    {
        public float re;
        public float im;

        public Ipp32fc(float re, float im)
        {
            this.re = re;
            this.im = im;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppiPoint
    {
        public int x;
        public int y;

        public IppiPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IpprPoint
    {
        public int x;
        public int y;
        public int z;

        public IpprPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IpprVolume
    {
        public int width;
        public int height;
        public int depth;

        public IpprVolume(int width, int height, int depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppiRect
    {
        public int x;
        public int y;
        public int width;
        public int height;

        public IppiRect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppPointPolar
    {
        public float rho;
        public float theta;

        public IppPointPolar(float rho, float theta)
        {
            this.rho = rho;
            this.theta = theta;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp64sc
    {
        public long re;
        public long im;

        public Ipp64sc(long re, long im)
        {
            this.re = re;
            this.im = im;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp32sc
    {
        public int re;
        public int im;

        public Ipp32sc(int re, int im)
        {
            this.re = re;
            this.im = im;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppiSize
    {
        public int width;
        public int height;

        public IppiSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IppiPoint_32f
    {
        public float x;
        public float y;

        public IppiPoint_32f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp16uc
    {
        public ushort re;
        public ushort im;

        public Ipp16uc(ushort re, ushort im)
        {
            this.re = re;
            this.im = im;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp64fc
    {
        public double re;
        public double im;

        public Ipp64fc(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp8sc
    {
        public sbyte re;
        public sbyte im;

        public Ipp8sc(sbyte re, sbyte im)
        {
            this.re = re;
            this.im = im;
        }
    };

    unsafe public class IppLibraryVersion
    {
        public int major;
        public int minor;
        public int majorBuild;
        public int build;
        public string targetCpu;
        public string Name;
        public string Version;
        public string BuildDate;

        public IppLibraryVersion(int* p)
        {
            major = *p; p++;
            minor = *p; p++;
            majorBuild = *p; p++;
            build = *p; p++;
            targetCpu = new string((sbyte*)p, 0, 4); p++;
            if (8 == IntPtr.Size)
            {
                p++;
            }
            sbyte** s = (sbyte**)p;
            Name = new string(*s); s++;
            Version = new string(*s); s++;
            BuildDate = new string(*s);
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IpprCuboid
    {
        public int x;
        public int y;
        public int z;
        public int width;
        public int height;
        public int depth;

        public IpprCuboid(int x, int y, int z, int width, int height, int depth)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Ipp16sc
    {
        public short re;
        public short im;

        public Ipp16sc(short re, short im)
        {
            this.re = re;
            this.im = im;
        }
    };
};