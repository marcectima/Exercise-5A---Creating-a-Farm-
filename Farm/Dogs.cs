using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Dogs
    {
        Program program = new Program();
        Tools tools = new Tools();
        // 1st Animal
        string name; double age; string sound; double health; double appetite; double thirst; double hygiene;
        public string[] names = new string[50];
        string GetName() => this.name; void SetName(string name) => this.name += name;
        double GetAge() => this.age; void SetAge() => this.age += age;
        string GetSound() => this.sound; void SetSound(string sound) => this.sound += sound;
        double GetHealth() => this.health; void SetHealth(double health) => this.health += health;
        double GetAppetite() => this.appetite; void SetAppetite(double appetite) => this.appetite += appetite;
        double GetThirst() => this.thirst; void SetThirst(double thrist) => this.thirst += thirst;
        double GetHygiene() => this.hygiene; void SetHygiene(double hygiene) => this.hygiene += hygiene;
        // 2nd Animal
        string GetName1() => this.name; void SetName1(double name) => this.name += name;
        double GetAge1() => this.age; void SetAge1() => this.age += age;
        string GetSound1() => this.sound; void SetSound1() => this.sound += sound;
        double GetHealth1() => this.health; void SetHealth1(double health) => this.health += health;
        double GetAppetite1() => this.appetite; void SetAppetite1(double appetite) => this.appetite += appetite;
        double GetThirst1() => this.thirst; void SetThirst1(double thrist) => this.thirst += thirst;
        double GetHygiene1() => this.hygiene; void SetHygiene1(double hygiene) => this.hygiene += hygiene;
        // 3rd Animal
        string GetName2() => this.name; void SetName2(double name) => this.name += name;
        double GetAge2() => this.age; void SetAge2() => this.age += age;
        string GetSound2() => this.sound; void SetSound2() => this.sound += sound;
        double GetHealth2() => this.health; void SetHealth2(double health) => this.health += health;
        double GetAppetite2() => this.appetite; void SetAppetite2(double appetite) => this.appetite += appetite;
        double GetThirst2() => this.thirst; void SetThirst2(double thrist) => this.thirst += thirst;
        double GetHygiene2() => this.hygiene; void SetHygiene2(double hygiene) => this.hygiene += hygiene;
        //4th Animal
        string GetName3() => this.name; void SetName3(double name) => this.name += name;
        double GetAge3() => this.age; void SetAge3() => this.age += age;
        string GetSound3() => this.sound; void SetSound3() => this.sound += sound;
        double GetHealth3() => this.health; void SetHealth3(double health) => this.health += health;
        double GetAppetite3() => this.appetite; void SetAppetite3(double appetite) => this.appetite += appetite;
        double GetThirst3() => this.thirst; void SetThirst3(double thrist) => this.thirst += thirst;
        double GetHygiene3() => this.hygiene; void SetHygiene3(double hygiene) => this.hygiene += hygiene;
        int amount;


        public void Main()
        {
            names = new string[] { "Rick", "Po", "Duley", "Sherrian" };
            Random ran = new Random();
            this.name = names[ran.Next(0, 3)];
            this.age = 0;
            this.sound = "Woof";
            this.health = 100;  //1000 * 2
            this.appetite = 90;
            this.thirst = 100;  //20 1/5
            this.hygiene = 100; //50 1/2
            if (GetAppetite() > 100)
            {


                SetAppetite((100 - GetAppetite()));

            }
            if (GetAppetite() < 20 || GetThirst() < 20)
            {
                Console.WriteLine(GetName() + ": " + GetSound() + "Fill my stomach.");
                Console.ReadKey();
                menu();
            }
            else
            {
                menu();
            }
            void menu()
            {
                bool keeplooping = true;
                do
                {
                    int x;
                    Console.WriteLine("Here's the list your cats \n" +
                        "1. " + GetName() + "\n" +
                        "2. " + GetName1() + "\n" +
                        "3. " + GetName2() + "\n" +
                        "4. " + GetName3() + "\n" +
                        "5. Go Back");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        A();
                    }
                    else if (x == 2)
                    {
                        A1();
                    }
                    else if (x == 3)
                    {
                        A2();
                    }
                    else if (x == 4)
                    {
                        A3();
                    }
                    else if (x == 5)
                    {
                        (keeplooping) = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }
            void A()
            {
                bool keeplooping = true;
                do
                {
                    int x;
                    Console.WriteLine("What would like to do with " + GetName() + "\n" +
                        "1. Status \n" +
                        "2. Feed \n" +
                        "3. Bathe \n" +
                        "4. Take cat to Veterinarian \n" +
                        "5. Go back");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Status();
                    }
                    else if (x == 2)
                    {

                        Feed();
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Bathe your Cat \n" +
                            "\n" +
                            "How many minutes you want bathe your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene(amount * tools.bathing());
                        if (GetHygiene() > 100)
                        {
                            SetHygiene((100 - GetAppetite()));
                        }
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("Animal Hospital \n" +
                            "\n" +
                            "What quality you want to reat your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene(amount * tools.veterinrain());
                        if (GetHealth() > 100)
                        {
                            SetHealth((100 - GetAppetite()));
                        }
                    }
                    else if (x == 5)
                    {
                        Console.ReadKey();
                        keeplooping = false;
                        menu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }
            void Status()
            {
                Console.WriteLine($"{GetName()}'s Status \n" +
                "\n" +
                $"Age: {GetAge()} \n" +
                $"Hunger Level: {GetAppetite()}%\n" +
                $"Thrist Level: {GetThirst()}%\n" +
                $"Hygiene: {GetHygiene()}% \n" +
                $"Health {(GetHealth()) - (GetHygiene() / 10)}% \n");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            void Feed()
            {
                int x;
                Console.WriteLine("What would like to feed the Cat \n" +
                    "1. Vegatable \n" +
                    "2. Meat \n" +
                    "3. Water \n" +
                    "4. Go Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 && GetAppetite() >= 100)
                {
                    string[] talkl = new string[12];
                    talkl = new string[] { ", I'm full.", ", no thak you.", ". *Shakes head*", ". *Purls*" };
                    Random talkr = new Random();
                    string talk = talkl[talkr.Next(0, 3)];
                    Console.WriteLine($"{GetName()}: {GetSound()}" + talk);
                    Console.ReadKey();
                    Console.Clear();
                    menu();

                }
                else if (x == 1 && GetAppetite() < 100)
                {
                    string[] talkl1 = new string[12];
                    talkl1 = new string[] { "Thanks, but that was a strange meal", "Yuk! What was that", "Don't Give me that again",
                        "Did you posion me?" };
                    Random talkr1 = new Random();
                    string talk1 = talkl1[talkr1.Next(0, 3)];
                    Console.WriteLine("How many bowl you would like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite(+(amount * tools.vegatable() / 10));
                    if (GetAppetite() > 100)
                    {
                        SetAppetite((100 - GetAppetite()));
                    }
                    Console.WriteLine($"{GetName()}: {GetSound()}. " + talk1);
                    Console.ReadKey();
                }
                else if (x == 2 && GetAppetite() < 100)
                {
                    string[] talkl2 = new string[12];
                    talkl2 = new string[] { "Thank you", "Brrrrp!", "ahhhh?", "Much better" };
                    Random talkr2 = new Random();
                    string talk2 = talkl2[talkr2.Next(0, 3)];
                    Console.WriteLine("How many bowl of meat would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite(+(amount * tools.vegatable() / 10));
                    if (GetAppetite() > 100)
                    {
                        SetAppetite((100 - GetAppetite()));
                    }
                    Console.WriteLine($"{GetName()}: {GetSound()}. " + talk2);
                    Console.ReadKey();
                }
                else if (x == 3 && GetAppetite() < 100)
                {
                    string[] talkl3 = new string[12];
                    talkl3 = new string[] { "Thank you", "That was delicious", "Can I have more?", "Yummy" };
                    Random talkr3 = new Random();
                    string talk3 = talkl3[talkr3.Next(0, 3)];
                    Console.WriteLine("How many cups would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite(+(amount * tools.vegatable() / 10));
                    if (GetAppetite() > 100)
                    {
                        SetAppetite((100 - GetAppetite()));
                    }
                    Console.WriteLine($"{GetName()}: {GetSound()}. " + talk3);
                    Console.ReadKey();
                }
                else if (x == 5)
                {
                    Feed();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    Feed();
                }
            }
            void A1()
            {
                bool keeplooping = true;
                do
                {
                    int x;
                    Console.WriteLine("What would like to do with " + GetName() + "\n" +
                        "1. Status \n" +
                        "2. Feed \n" +
                        "3. Bathe \n" +
                        "4. Take cat to Veterinarian \n" +
                        "5. Go back");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Status1();
                    }
                    else if (x == 2)
                    {

                        Feed1();
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Bathe your Cat \n" +
                            "\n" +
                            "How many minutes you want bathe your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene(amount * tools.bathing());
                        if (GetHygiene() > 100)
                        {
                            SetHygiene((100 - GetAppetite()));
                        }
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("Animal Hospital \n" +
                            "\n" +
                            "What quality you want to reat your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene(amount * tools.veterinrain());
                        if (GetHealth() > 100)
                        {
                            SetHealth((100 - GetAppetite()));
                        }
                    }
                    else if (x == 5)
                    {
                        Console.ReadKey();
                        keeplooping = false;
                        menu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }
            void Status1()
            {
                Console.WriteLine($"{GetName1()}'s Status \n" +
                "\n" +
                $"Age: {GetAge1()} \n" +
                $"Hunger Level: {GetAppetite1()}%\n" +
                $"Thrist Level: {GetThirst1()}%\n" +
                $"Hygiene: {GetHygiene1()}% \n" +
                $"Health {(GetHealth1()) - (GetHygiene1() / 10)}% \n");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            void Feed1()
            {
                int x;
                Console.WriteLine("What would like to feed the Cat \n" +
                    "1. Vegatable \n" +
                    "2. Meat \n" +
                    "3. Water \n" +
                    "4. Go Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 && GetAppetite1() >= 100)
                {
                    string[] talkl = new string[12];
                    talkl = new string[] { ", I'm full.", ", no thak you.", ". *Shakes head*", ". *Purls*" };
                    Random talkr = new Random();
                    string talk = talkl[talkr.Next(0, 3)];
                    Console.WriteLine($"{GetName1()}: {GetSound1()}" + talk);
                    Console.ReadKey();
                    Console.Clear();
                    menu();

                }
                else if (x == 1 && GetAppetite1() < 100)
                {
                    string[] talkl1 = new string[12];
                    talkl1 = new string[] { "Thanks, but that was a strange meal", "Yuk! What was that", "Don't Give me that again",
                        "Did you posion me?" };
                    Random talkr1 = new Random();
                    string talk1 = talkl1[talkr1.Next(0, 3)];
                    Console.WriteLine("How many bowl you would like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite(+(amount * tools.vegatable() / 10));
                    if (GetAppetite() > 100)
                    {
                        SetAppetite((100 - GetAppetite()));
                    }
                    Console.WriteLine($"{GetName()}: {GetSound()}. " + talk1);
                    Console.ReadKey();
                }
                else if (x == 2 && GetAppetite() < 100)
                {
                    string[] talkl2 = new string[12];
                    talkl2 = new string[] { "Thank you", "Brrrrp!", "ahhhh?", "Much better" };
                    Random talkr2 = new Random();
                    string talk2 = talkl2[talkr2.Next(0, 3)];
                    Console.WriteLine("How many bowl of meat would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite1(+(amount * tools.vegatable() / 10));
                    if (GetAppetite1() > 100)
                    {
                        SetAppetite1((100 - GetAppetite()));
                    }
                    Console.WriteLine($"{GetName1()}: {GetSound1()}. " + talk2);
                    Console.ReadKey();
                }
                else if (x == 3 && GetAppetite1() < 100)
                {
                    string[] talkl3 = new string[12];
                    talkl3 = new string[] { "Thank you", "That was delicious", "Can I have more?", "Yummy" };
                    Random talkr3 = new Random();
                    string talk3 = talkl3[talkr3.Next(0, 3)];
                    Console.WriteLine("How many cups would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite1(+(amount * tools.vegatable() / 10));
                    if (GetAppetite1() > 100)
                    {
                        SetAppetite1((100 - GetAppetite1()));
                    }
                    Console.WriteLine($"{GetName1()}: {GetSound1()}. " + talk3);
                    Console.ReadKey();
                }
                else if (x == 5)
                {
                    Feed();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    Feed();
                }
            }
            void A2()
            {
                bool keeplooping = true;
                do
                {
                    int x;
                    Console.WriteLine("What would like to do with " + GetName2() + "\n" +
                        "1. Status \n" +
                        "2. Feed \n" +
                        "3. Bathe \n" +
                        "4. Take cat to Veterinarian \n" +
                        "5. Go back");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Status2();
                    }
                    else if (x == 2)
                    {

                        Feed2();
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Bathe your Cat \n" +
                            "\n" +
                            "How many minutes you want bathe your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene2(amount * tools.bathing());
                        if (GetHygiene2() > 100)
                        {
                            SetHygiene2((100 - GetAppetite2()));
                        }
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("Animal Hospital \n" +
                            "\n" +
                            "What quality you want to reat your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene2(amount * tools.veterinrain());
                        if (GetHealth2() > 100)
                        {
                            SetHealth2((100 - GetAppetite2()));
                        }
                    }
                    else if (x == 5)
                    {
                        Console.ReadKey();
                        keeplooping = false;
                        menu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }
            void Status2()
            {
                Console.WriteLine($"{GetName2()}'s Status \n" +
                "\n" +
                $"Age: {GetAge2()} \n" +
                $"Hunger Level: {GetAppetite2()}%\n" +
                $"Thrist Level: {GetThirst2()}%\n" +
                $"Hygiene: {GetHygiene2()}% \n" +
                $"Health {(GetHealth2()) - (GetHygiene2() / 10)}% \n");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            void Feed2()
            {
                int x;
                Console.WriteLine("What would like to feed the Cat \n" +
                    "1. Vegatable \n" +
                    "2. Meat \n" +
                    "3. Water \n" +
                    "4. Go Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 && GetAppetite2() >= 100)
                {
                    string[] talkl = new string[12];
                    talkl = new string[] { ", I'm full.", ", no thak you.", ". *Shakes head*", ". *Purls*" };
                    Random talkr = new Random();
                    string talk = talkl[talkr.Next(0, 3)];
                    Console.WriteLine($"{GetName2()}: {GetSound2()}" + talk);
                    Console.ReadKey();
                    Console.Clear();
                    menu();

                }
                else if (x == 1 && GetAppetite2() < 100)
                {
                    string[] talkl1 = new string[12];
                    talkl1 = new string[] { "Thanks, but that was a strange meal", "Yuk! What was that", "Don't Give me that again",
                        "Did you posion me?" };
                    Random talkr1 = new Random();
                    string talk1 = talkl1[talkr1.Next(0, 3)];
                    Console.WriteLine("How many bowl you would like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite2(+(amount * tools.vegatable() / 10));
                    if (GetAppetite2() > 100)
                    {
                        SetAppetite2((100 - GetAppetite2()));
                    }
                    Console.WriteLine($"{GetName2()}: {GetSound2()}. " + talk1);
                    Console.ReadKey();
                }
                else if (x == 2 && GetAppetite2() < 100)
                {
                    string[] talkl2 = new string[12];
                    talkl2 = new string[] { "Thank you", "Brrrrp!", "ahhhh?", "Much better" };
                    Random talkr2 = new Random();
                    string talk2 = talkl2[talkr2.Next(0, 3)];
                    Console.WriteLine("How many bowl of meat would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite2(+(amount * tools.vegatable() / 10));
                    if (GetAppetite2() > 100)
                    {
                        SetAppetite2((100 - GetAppetite2()));
                    }
                    Console.WriteLine($"{GetName2()}: {GetSound2()}. " + talk2);
                    Console.ReadKey();
                }
                else if (x == 3 && GetAppetite2() < 100)
                {
                    string[] talkl3 = new string[12];
                    talkl3 = new string[] { "Thank you", "That was delicious", "Can I have more?", "Yummy" };
                    Random talkr3 = new Random();
                    string talk3 = talkl3[talkr3.Next(0, 3)];
                    Console.WriteLine("How many cups would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite2(+(amount * tools.vegatable() / 10));
                    if (GetAppetite2() > 100)
                    {
                        SetAppetite2((100 - GetAppetite2()));
                    }
                    Console.WriteLine($"{GetName2()}: {GetSound2()}. " + talk3);
                    Console.ReadKey();
                }
                else if (x == 5)
                {
                    Feed2();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    Feed2();
                }
            }
            void A3()
            {
                bool keeplooping = true;
                do
                {
                    int x;
                    Console.WriteLine("What would like to do with " + GetName3() + "\n" +
                        "1. Status \n" +
                        "2. Feed \n" +
                        "3. Bathe \n" +
                        "4. Take cat to Veterinarian \n" +
                        "5. Go back");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Status3();
                    }
                    else if (x == 2)
                    {

                        Feed3();
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Bathe your Cat \n" +
                            "\n" +
                            "How many minutes you want bathe your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene3(amount * tools.bathing());
                        if (GetHygiene3() > 100)
                        {
                            SetHygiene3((100 - GetAppetite3()));
                        }
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("Animal Hospital \n" +
                            "\n" +
                            "What quality you want to reat your cat");
                        amount = Convert.ToInt32(Console.ReadLine());
                        SetHygiene3(amount * tools.veterinrain());
                        if (GetHealth3() > 100)
                        {
                            SetHealth3((100 - GetAppetite3()));
                        }
                    }
                    else if (x == 5)
                    {
                        Console.ReadKey();
                        keeplooping = false;
                        menu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (keeplooping);
            }
            void Status3()
            {
                Console.WriteLine($"{GetName3()}'s Status \n" +
                "\n" +
                $"Age: {GetAge3()} \n" +
                $"Hunger Level: {GetAppetite3()}%\n" +
                $"Thrist Level: {GetThirst3()}%\n" +
                $"Hygiene: {GetHygiene3()}% \n" +
                $"Health {(GetHealth3()) - (GetHygiene3() / 10)}% \n");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            void Feed3()
            {
                int x;
                Console.WriteLine("What would like to feed the Cat \n" +
                    "1. Vegatable \n" +
                    "2. Meat \n" +
                    "3. Water \n" +
                    "4. Go Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 && GetAppetite3() >= 100)
                {
                    string[] talkl = new string[12];
                    talkl = new string[] { ", I'm full.", ", no thak you.", ". *Shakes head*", ". *Purls*" };
                    Random talkr = new Random();
                    string talk = talkl[talkr.Next(0, 3)];
                    Console.WriteLine($"{GetName3()}: {GetSound3()}" + talk);
                    Console.ReadKey();
                    Console.Clear();
                    menu();

                }
                else if (x == 1 && GetAppetite3() < 100)
                {
                    string[] talkl1 = new string[12];
                    talkl1 = new string[] { "Thanks, but that was a strange meal", "Yuk! What was that", "Don't Give me that again",
                        "Did you posion me?" };
                    Random talkr1 = new Random();
                    string talk1 = talkl1[talkr1.Next(0, 3)];
                    Console.WriteLine("How many bowl you would like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite3(+(amount * tools.vegatable() / 10));
                    if (GetAppetite3() > 100)
                    {
                        SetAppetite3((100 - GetAppetite3()));
                    }
                    Console.WriteLine($"{GetName3()}: {GetSound3()}. " + talk1);
                    Console.ReadKey();
                }
                else if (x == 2 && GetAppetite3() < 100)
                {
                    string[] talkl2 = new string[12];
                    talkl2 = new string[] { "Thank you", "Brrrrp!", "ahhhh?", "Much better" };
                    Random talkr2 = new Random();
                    string talk2 = talkl2[talkr2.Next(0, 3)];
                    Console.WriteLine("How many bowl of meat would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite3(+(amount * tools.vegatable() / 10));
                    if (GetAppetite3() > 100)
                    {
                        SetAppetite3((100 - GetAppetite3()));
                    }
                    Console.WriteLine($"{GetName3()}: {GetSound3()}. " + talk2);
                    Console.ReadKey();
                }
                else if (x == 3 && GetAppetite3() < 100)
                {
                    string[] talkl3 = new string[12];
                    talkl3 = new string[] { "Thank you", "That was delicious", "Can I have more?", "Yummy" };
                    Random talkr3 = new Random();
                    string talk3 = talkl3[talkr3.Next(0, 3)];
                    Console.WriteLine("How many cups would you like?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    SetAppetite3(+(amount * tools.vegatable() / 10));
                    if (GetAppetite3() > 100)
                    {
                        SetAppetite3((100 - GetAppetite3()));
                    }
                    Console.WriteLine($"{GetName3()}: {GetSound3()}. " + talk3);
                    Console.ReadKey();
                }
                else if (x == 5)
                {
                    Feed3();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    Feed3();
                }
            }
        }
    }
}