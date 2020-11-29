using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.Interfaces
{
    public interface IGoldenCrownStrategy
    {
        public void MsgDecryptionStrategy();
        public IEnumerable<string> ConquerStrategy();
    }
}
