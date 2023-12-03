using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool cycle;
        int moleculeIndex;
        int featureIndex;
        string acidity;
        string temperature;
        string electricalBehavior;
        string massInVolume;
        string organicCharacter;
        string vibration;
        string massInMol;
        string solution;
        string name;
        AcidityBasicity pKa = new AcidityBasicity();
        BoilingMelting point = new BoilingMelting();
        Conductivity conductivity = new Conductivity();
        Density density = new Density();
        ElectrophilicNucleophilic character = new ElectrophilicNucleophilic();
        InfraredPeaks wavenumber = new InfraredPeaks();
        MolecularWeight weight = new MolecularWeight();
        Solubility solubility = new Solubility();
        cycle = pKa.Welcome();
        while (cycle == true) {
            moleculeIndex = pKa.DisplayMenu();
            Console.WriteLine(" ");
            if (moleculeIndex > -1 && moleculeIndex < 30) {
                featureIndex = pKa.ChooseFeature();
            }
            else {
                featureIndex = -1;
            }
            Console.WriteLine(" ");
            if (featureIndex > -1 && featureIndex < 9) {
                if (featureIndex == 0) {
                    acidity = pKa.ShowConstant(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{acidity}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 1) {
                    temperature = point.ShowPoints(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{temperature}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 2) {
                    electricalBehavior = conductivity.ShowElectricalBehavior(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{electricalBehavior}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 3) {
                    massInVolume = density.ShowDensity(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{massInVolume}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 4) {
                    organicCharacter = character.ShowCharacter(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{organicCharacter}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 5) {
                    vibration = wavenumber.ShowPeaks(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{vibration}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 6) {
                    massInMol = weight.ShowWeight(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{massInMol}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 7) {
                    solution = solubility.ShowSolubility(moleculeIndex);
                    name = pKa.ShowName(moleculeIndex);
                    Console.WriteLine($"{name}");
                    Console.WriteLine($"{solution}");
                    cycle = pKa.Reload();
                }
                else if (featureIndex == 8) {
                name = pKa.ShowName(moleculeIndex);
                acidity = pKa.ShowConstant(moleculeIndex);
                temperature = point.ShowPoints(moleculeIndex);
                electricalBehavior = conductivity.ShowElectricalBehavior(moleculeIndex);
                massInVolume = density.ShowDensity(moleculeIndex);
                organicCharacter = character.ShowCharacter(moleculeIndex);
                vibration = wavenumber.ShowPeaks(moleculeIndex);
                massInMol = weight.ShowWeight(moleculeIndex);
                solution = solubility.ShowSolubility(moleculeIndex);
                Console.WriteLine($"{name}");
                Console.WriteLine(" ");
                Console.WriteLine("List of Features: ");
                Console.WriteLine($"1. {acidity}");
                Console.WriteLine($"2. {temperature}");
                Console.WriteLine($"3. {electricalBehavior}");
                Console.WriteLine($"4. {massInVolume}");
                Console.WriteLine($"5. {organicCharacter}");
                Console.WriteLine($"6. {vibration}");
                Console.WriteLine($"7. {massInMol}");
                Console.WriteLine($"8. {solution}");
                cycle = pKa.Reload();
                }
            }
            else {
                cycle = false;
            }
        }
    }
}