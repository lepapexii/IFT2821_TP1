using System;

namespace TP1
{
    class Mainz 
    {
        public static void Main(string[] args)
        {
            TP1_Pratique.RandomVarGenerator RandomVarGenerator = new TP1_Pratique.RandomVarGenerator();
            var v = RandomVarGenerator.RandomizeIt();
            System.Diagnostics.Debug.WriteLine("Le mot choisit" + ' ' + v);
            System.Diagnostics.Debug.WriteLine("Le mot choisit" + ' ' + v);


            /*string temp = randomVarGenerator.RandomizeIt();
            string temp2 = randomVarGenerator.RandomizeIt();
              System.Diagnostics.Debug.WriteLine("Le mot choisit" + ' ' + v);
            System.Diagnostics.Debug.WriteLine("Le mot choisit" + ' ' + temp2);*/

        }



    }
}
