using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TP1_Pratique
{
    /*La paresse ultime je suis tanner de trouver et rentrer des nom de variables */
    public class RandomVarGenerator : Rules
    {
        public ArrayList WordDict = new ArrayList();


        public RandomVarGenerator() {


        }

        public ArrayList WordDict1 { get => WordDict; set => WordDict = value; }

        public void AddInfo(string Liste)
        {
            throw new NotImplementedException();
        }

        public void BdName(string Name)
        {
            throw new NotImplementedException();
        }

        public void ImportDictionnary() {

            string[] dict = System.IO.File.ReadAllLines(@"C:\dev\IFT2821\TP1\TP1_Pratique\assets\words.txt");

            foreach (string mot in dict) {

                if (mot.Length <= 7) {
                    WordDict.Add(mot);
                }

            }

            

        }

        public string RandomizeIt() {

            ImportDictionnary();
            Random rnd = new Random();
            int choice = rnd.Next(1, 1000);

        
            string var = (string)WordDict[choice];
           
            return var;


        }




    }
}
