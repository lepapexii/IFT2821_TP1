using System;

namespace TP1_Pratique
{
    class TP1 : Rules
    {

        Factory temp;
        static void Main(string[] args)
        {
            
        }

        public void init() {
            temp = new Factory(0);

        }


        public void BdName(string Name)
        {
            foreach (string BdName in temp.LesEntites1) {
                Console.WriteLine(BdName.ToString());
            }
        }

        public void AddInfo(string Name)
        {
            temp.AddInfo(Name);
        }
    }
}
