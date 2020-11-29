using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.Model
{
    public class Message
    {
        private string kingdomName;
        private string secretMsg;
       
        public string KingdomName
        {
            get
            {
                return kingdomName;
            }
            set
            {
                kingdomName = value;
            }
        }
        public string SecretMsg
        {
            get
            {
                return secretMsg;
            }
            set
            {
                secretMsg = value;
            }
        }
    
    }
}
