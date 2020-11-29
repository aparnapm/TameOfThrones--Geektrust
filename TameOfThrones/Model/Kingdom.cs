using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.Model
{
    public class Kingdom
    {
        private string name;
        private string emblem;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Emblem
        {
            get
            {
                return emblem;
            }
            set
            {
                emblem = value;
            }
        }
    }
}
