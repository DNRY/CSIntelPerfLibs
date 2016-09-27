using System.Runtime.InteropServices;

namespace CSIntel.Mkl
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MKL_Complex8
    {
        public float real;
        public float imag;

        public MKL_Complex8(float re, float im)
        {
            real = re; imag = im;
        }
    };

    public struct MKLVersion
    {
        public int MajorVersion;
        public int MinorVersion;
        public int UpdateVersion;
        public string ProductStatus;
        public string Build;
        public string Processor;
        public string Platform;
    };

    unsafe internal struct MKLVersion_
    {
        public int MajorVersion;
        public int MinorVersion;
        public int UpdateVersion;
        public sbyte* ProductStatus;
        public sbyte* Build;
        public sbyte* Processor;
        public sbyte* Platform;
    };
}