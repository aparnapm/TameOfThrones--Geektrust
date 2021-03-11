using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using TameOfThrones.Interfaces;
using TameOfThrones.Model;

namespace TameOfThrones
{
   
    public class GoldenCrown : IFileParser, IGoldenCrownStrategy
    {
        public static int MAX_KINGDOM_COUNT = 3;
        public Kingdom CurrentRulingKingdom;
        private Dictionary<Message, Status> messageList; 
        public GoldenCrown()
        {
            CurrentRulingKingdom = new Kingdom();
            CurrentRulingKingdom.Emblem = "GORILLA";
            CurrentRulingKingdom.Name = "SPACE";
            messageList = new Dictionary<Message, Status>();
        }

        public IEnumerable<string> ConquerStrategy()
        {
            IEnumerable<string> conquerList = messageList.Where(item => item.Value == Status.SUCCESS).Select(val=> val.Key.KingdomName);
            if(conquerList.Count()>=MAX_KINGDOM_COUNT)
            {
                return conquerList;
            }
            return null;
        }

        public void MsgDecryptionStrategy()
        {
            foreach(Message msg in messageList.Keys.ToList())
            {
                string emblem = UniverseSoutheros.GetInstance().GetEmblemByName
                    (msg.KingdomName);
                int cipherNumber = emblem.Length;
                string decryptedText= Encryption.SeasarCipher(msg.SecretMsg, cipherNumber);
                if(Encryption.AlphabetCountCheck(emblem, decryptedText))
                {
                    messageList[msg] = Status.SUCCESS;
                }
                else
                {
                    messageList[msg] = Status.FAILURE;
                }
            }
        }

        public void ParseFile(string fileName)
        {
            string[] messages = File.ReadAllLines(fileName);
           
            foreach (string msg in messages)
            {
                MessageParser secretMsg = new MessageParser();
                secretMsg.ParseMessage(msg.ToUpper(), ' ');
                string kingdomName = secretMsg.SecretMessage.KingdomName;
                if (kingdomName != CurrentRulingKingdom.Name )
                {
                    messageList.Add(secretMsg.SecretMessage, Status.NONE);
                }
            }
        }
    }
}
