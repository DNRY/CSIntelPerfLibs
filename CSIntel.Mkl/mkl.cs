using System;
using System.Runtime.InteropServices;
using System.Security;

//reference : https://software.intel.com/en-us/articles/using-intel-mkl-in-your-c-program
namespace CSIntel.Mkl
{
    public sealed class CBLAS
    {
        private CBLAS()
        {
        }

        /** Constants for CBLAS_ORDER enum, file "mkl_cblas.h" */

        public sealed class ORDER
        {
            private ORDER()
            {
            }

            public static int RowMajor = 101;  /* row-major arrays */
            public static int ColMajor = 102;  /* column-major arrays */
        }

        /** Constants for CBLAS_TRANSPOSE enum, file "mkl_cblas.h" */

        public sealed class TRANSPOSE
        {
            private TRANSPOSE()
            {
            }

            public static int NoTrans = 111; /* trans='N' */
            public static int Trans = 112; /* trans='T' */
            public static int ConjTrans = 113; /* trans='C' */
        }

        public static void sgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            float alpha,
            float[] A,
            int lda,
            float[] B,
            int ldb,
            float beta,
            ref float[] C,
            int ldc
            )
        {
            MklNativeMethods.cblas_sgemm(Order, TransA, TransB, M, N, K,
                alpha, A, lda, B, ldb, beta, C, ldc);
        }

        public static void sgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            float alpha,
            IntPtr ptrA,
            int lda,
            IntPtr ptrB,
            int ldb,
            float beta,
            ref IntPtr ptrC,
            int ldc
            )
        {
            MklNativeMethods.cblas_sgemm_ptr(Order, TransA, TransB, M, N, K,
                alpha, ptrA, lda, ptrB, ldb, beta, ptrC, ldc);
        }

        public static void dgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            double alpha,
            double[] A,
            int lda,
            double[] B,
            int ldb,
            double beta,
            ref double[] C,
            int ldc
            )
        {
            MklNativeMethods.cblas_dgemm(Order, TransA, TransB, M, N, K,
                alpha, A, lda, B, ldb, beta, C, ldc);
        }

        public static void dgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            double alpha,
            IntPtr ptrA,
            int lda,
            IntPtr ptrB,
            int ldb,
            double beta,
            ref IntPtr ptrC,
            int ldc
            )
        {
            MklNativeMethods.cblas_dgemm_ptr(Order, TransA, TransB, M, N, K,
                alpha, ptrA, lda, ptrB, ldb, beta, ptrC, ldc);
        }

        public static void cgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            ref MKL_Complex8 alpha,
            MKL_Complex8[] A,
            int lda,
            MKL_Complex8[] B,
            int ldb,
            ref MKL_Complex8 beta,
            ref MKL_Complex8[] C,
            int ldc
            )
        {
            MklNativeMethods.cblas_cgemm(Order, TransA, TransB, M, N, K,
                ref alpha, A, lda, B, ldb, ref beta, C, ldc);
        }

        public static void cgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            ref MKL_Complex8 alpha,
            IntPtr ptrA,
            int lda,
            IntPtr ptrB,
            int ldb,
            ref MKL_Complex8 beta,
            ref IntPtr ptrC,
            int ldc
            )
        {
            MklNativeMethods.cblas_cgemm_ptr(Order, TransA, TransB, M, N, K,
                ref alpha, ptrA, lda, ptrB, ldb, ref beta, ptrC, ldc);
        }
    }

    public static class mkl_version
    {
        public static void mkl_get_version(ref MKLVersion mklVersion)
        {
            var mklVer_ = new MKLVersion_();

            MklNativeMethods.mkl_get_version(ref mklVer_);

            mklVersion.MajorVersion = mklVer_.MajorVersion;
            mklVersion.MinorVersion = mklVer_.MinorVersion;
            mklVersion.UpdateVersion = mklVer_.UpdateVersion;
            unsafe
            {
                mklVersion.ProductStatus = new string(mklVer_.ProductStatus);
                mklVersion.Build = new string(mklVer_.Build);
                mklVersion.Processor = new string(mklVer_.Processor);
                mklVersion.Platform = new string(mklVer_.Platform);
            }
        }
    }

    [SuppressUnmanagedCodeSecurity]
    internal sealed class MklNativeMethods
    {
        internal const string libName = "mkl_rt.dll";

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void mkl_get_version(ref MKLVersion_ mklVersion);

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cblas_sgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            float alpha,
            [In] float[] A,
            int lda,
            [In] float[] B,
            int ldb,
            float beta,
            [In, Out] float[] C,
            int ldc
            );

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl,
             EntryPoint = "cblas_sgemm")]
        internal static extern void cblas_sgemm_ptr(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            float alpha,
            IntPtr A,
            int lda,
            IntPtr B,
            int ldb,
            float beta,
            IntPtr C,
            int ldc
            );

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cblas_dgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            double alpha,
            [In] double[] A,
            int lda,
            [In] double[] B,
            int ldb,
            double beta,
            [In, Out] double[] C,
            int ldc
            );

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl,
             EntryPoint = "cblas_dgemm")]
        internal static extern void cblas_dgemm_ptr(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            double alpha,
            IntPtr A,
            int lda,
            IntPtr B,
            int ldb,
            double beta,
            IntPtr C,
            int ldc
            );

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cblas_cgemm(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            ref MKL_Complex8 alpha,
            [In] MKL_Complex8[] A,
            int lda,
            [In] MKL_Complex8[] B,
            int ldb,
            ref MKL_Complex8 beta,
            [In, Out] MKL_Complex8[] C,
            int ldc
            );

        [DllImport(libName, CallingConvention = CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemm")]
        internal static extern void cblas_cgemm_ptr(
            int Order,
            int TransA,
            int TransB,
            int M,
            int N,
            int K,
            ref MKL_Complex8 alpha,
            IntPtr A,
            int lda,
            IntPtr B,
            int ldb,
            ref MKL_Complex8 beta,
            IntPtr C,
            int ldc
            );
    }
}