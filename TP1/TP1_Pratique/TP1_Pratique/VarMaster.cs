using System;

namespace TP1_Pratique
{
    class VarMaster :  Rules
    {

        Factory temp;
        static void Main(string[] args)
        {
            Init();
        }

        static public void Init() {
            Factory temp = new Factory(0);
            RandomVarGenerator Gen = new RandomVarGenerator();

            Gen.ImportDictionnary();
            Gen.RandomizeIt();


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
