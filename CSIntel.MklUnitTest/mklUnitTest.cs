using CSIntel.Mkl;
using MathNet.Numerics.LinearAlgebra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSIntel.MklUnitTest
{
    [TestClass]
    public class mklUnitTest
    {
        [TestMethod]
        public void Test_MKL_Get_Version()
        {
            MKLVersion mklVer = new MKLVersion();
            mkl_version.mkl_get_version(ref mklVer);
            Console.WriteLine(mklVer.ToString());
        }

        [TestMethod]
        public void Test_cblasSgemm()
        {
            /* Data initialization */
            int Order = CBLAS.ORDER.ColMajor;
            int TransA = CBLAS.TRANSPOSE.NoTrans;
            int TransB = CBLAS.TRANSPOSE.NoTrans;

            Random rand = new Random();
            int rows_a = rand.Next(2, 10);
            int cols_a = rand.Next(2, 10);

            int rows_b = cols_a;
            int cols_b = rand.Next(2, 10);

            int rows_c = rows_a;
            int cols_c = cols_b;

            float[] A = new float[rows_a * cols_a];
            float[] B = new float[rows_b * cols_b];
            float[] C = new float[rows_c * cols_c];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToSingle(rand.Next(0, 10));
            }

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = Convert.ToSingle(rand.Next(0, 10));
            }

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = Convert.ToSingle(rand.Next(0, 10));
            }

            var alpha = Convert.ToSingle(rand.Next(0, 10));
            var beta = Convert.ToSingle(rand.Next(0, 10));

            var mA = Matrix<float>.Build.Dense(rows_a, cols_a, A);
            var mB = Matrix<float>.Build.Dense(rows_b, cols_b, B);
            var mC = Matrix<float>.Build.Dense(rows_c, cols_c, C).Clone();

            Console.WriteLine("MKL cblas_sgemm example");
            Console.WriteLine();
            /* Print initial data */
            Console.WriteLine("alpha=" + alpha);
            Console.WriteLine("beta=" + beta);
            Console.WriteLine("Matrix A");
            Console.WriteLine(mA.ToString());
            Console.WriteLine("Matrix B");
            Console.WriteLine(mB.ToString());
            Console.WriteLine("Initial C");
            Console.WriteLine(mC.ToString());

            /* Computation */
            CBLAS.sgemm(Order, TransA, TransB, rows_a, cols_b, cols_a, alpha, A, rows_a, B, rows_b, beta, ref C, rows_c);

            mC = alpha * mA * mB + beta * mC; //sgemm
            var expected = mC.ToColumnWiseArray(); //reference result by Math.Net

            for (int i = 0; i < C.Length; i++)
            {
                Assert.AreEqual(expected[i], C[i]);
            }

            /* Print the result */
            var mCResult = Matrix<float>.Build.Dense(rows_c, cols_c, C);
            Console.WriteLine("expected");
            Console.WriteLine(mC.ToString());
            Console.WriteLine("Result");
            Console.WriteLine(mCResult.ToString());
            Console.WriteLine("TEST PASSED");
            Console.WriteLine();
        }
    }
}