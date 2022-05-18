using System.Numerics;

namespace EncryptionAlgorithms
{
    internal class RsaPrivateCrtKeyParameters
    {
        private BigInteger bigInteger1;
        private BigInteger bigInteger2;
        private BigInteger bigInteger3;
        private BigInteger bigInteger4;
        private BigInteger bigInteger5;
        private BigInteger bigInteger6;
        private BigInteger bigInteger7;
        private BigInteger bigInteger8;

        public RsaPrivateCrtKeyParameters(BigInteger bigInteger1, BigInteger bigInteger2, BigInteger bigInteger3, BigInteger bigInteger4, BigInteger bigInteger5, BigInteger bigInteger6, BigInteger bigInteger7, BigInteger bigInteger8)
        {
            this.bigInteger1 = bigInteger1;
            this.bigInteger2 = bigInteger2;
            this.bigInteger3 = bigInteger3;
            this.bigInteger4 = bigInteger4;
            this.bigInteger5 = bigInteger5;
            this.bigInteger6 = bigInteger6;
            this.bigInteger7 = bigInteger7;
            this.bigInteger8 = bigInteger8;
        }
    }
}