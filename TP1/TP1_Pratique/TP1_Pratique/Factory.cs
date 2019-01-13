using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Pratique
{
    class Factory : Rules
    {
        private HashSet<string> LesEntites = new HashSet<string>();
        private int test;
       
        
        public Factory(int combien) {

            this.test = combien;

        }

        public int Test { get => test; set => test = value; }
        public HashSet<string> LesEntites1 { get => LesEntites; set => LesEntites = value; }

        public void BdName(string Name)
        {
            foreach (string BdName in this.LesEntites1)
            {
                Console.WriteLine(BdName.ToString());
            }
        }

        public void AddInfo(string Liste)
        {
            LesEntites1.Add(Liste);
           
        }

    }
}
