using System;

class Program
{
    static void Main(string[] args)
    {
        bool cycle = true;
        int moleculeIndex;
        int featureIndex;
        MolecularWeight weight = new MolecularWeight();
        BoilingMelting point = new BoilingMelting();
        Density density = new Density();
        Solubility solubility = new Solubility();
        while (cycle == true) {
            moleculeIndex = weight.DisplayMenu();
            Console.WriteLine("")
            featureIndex = weight.ChooseFeature
            Console.WriteLine("")
            if (featureIndex > 0 && featureIndex < 8) {

            }
            if (featureIndex == 8) {
                
            }
        }
    }
}