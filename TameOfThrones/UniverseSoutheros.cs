using System;
using System.Collections.Generic;
using System.Text;
using TameOfThrones.Model;

namespace TameOfThrones
{
    public class UniverseSoutheros
    {
        private static UniverseSoutheros _southeros;
        List<Kingdom> kingdomList = new List<Kingdom>();

        public static UniverseSoutheros GetInstance()
        {
            if (_southeros == null)
            {
                _southeros = new UniverseSoutheros();
            }
            return _southeros;
        }
    
        public void AddKingdom(string _name, string _emblem)
        {
            Kingdom _kingdom = new Kingdom();
            _kingdom.Name = _name;
            _kingdom.Emblem = _emblem;
            _southeros.kingdomList.Add(_kingdom);
        }
        public string GetEmblemByName(string name)
        {
            Kingdom kingdom = _southeros.kingdomList.Find(item => item.Name == name);
            return kingdom == null ? "" : kingdom.Emblem;
        }
    }
}
