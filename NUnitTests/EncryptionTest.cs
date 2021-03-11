using NUnit.Framework;
using TameOfThrones;
namespace NUnitTests
{
    public class EncryptionTest
    {
      
        [Test]
        public void SeasarCipherTest()
        {
            string text = "rozo";
            int index = 3;
            string result = Encryption.SeasarCipher(text, index);
            Assert.AreEqual(result, "olwl");
        }
        [Test]
        public void AlphabetCountCheckTest()
        {
            string emblem = "panda";
            string msg = "ahdvvnxxxautup";
            bool result = Encryption.AlphabetCountCheck(emblem, msg);
            Assert.AreEqual(result, true);
        }

    }
}