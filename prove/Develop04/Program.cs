using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List <string> menu = new List<string> {"Menu Options: ","1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit", "Select a choice from the menu: "};
        bool repeat = true;
        while (repeat == true) {
            for (int i = 0; i < menu.Count(); i++)
            {
                Console.WriteLine(menu[i]);
                Thread.Sleep(400);
            }
            string userChoice = Console.ReadLine();
            int activity = int.Parse(userChoice);
            if (activity == 1) {
                Breathe breathe = new Breathe();
                breathe.BreathingActivity();
            }
            else if (activity == 2) {
                Reflect reflect = new Reflect();
                reflect.ReflectActivity();
            }
            else if (activity == 3) {
                List list = new List();
                list.ListActivity();
            }
            else if (activity == 4) {
                repeat = false;
            }
        }    
    }
}