using System;
using System.Collections.Generic;
using System.Text;
using TameOfThrones.Interfaces;
using TameOfThrones.Model;

namespace TameOfThrones
{
    enum Status
    {
        SUCCESS,
        FAILURE,
        NONE
    }
    public class MessageParser 
    {
        private Message secretMessage;
        public MessageParser()
        {
            secretMessage= new Message(); 
        }
        public Message SecretMessage
        {
            get
            {
                return secretMessage;
            }
            set
            {
                secretMessage = value;
            }
        }


        public void ParseMessage(string inputRow, char delimiter)
        {
            SecretMessage.KingdomName = inputRow.Split(' ')[0];
            SecretMessage.SecretMsg = inputRow.Split(' ')[1];
        }
    }
}
