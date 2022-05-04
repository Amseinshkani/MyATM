using System;
using System.Collections.Generic;

namespace Sample
{
    public class SATM : IATM
    {
        List<MUsers> MList = new List<MUsers>();

        public void Elephant()
        {
            MUsers A = new MUsers();
            A.HolderName = "AmirAshkani";
            A.NameBank = "Tejarat";
            A.PassWord = 2002;
            A.CardNumber = 5859611898571594;
            A.cash = 1999999999;

            MList.Add (A);

            MUsers R = new MUsers();
            R.HolderName = "RahimGhasemi";
            R.NameBank = "Melat";
            R.PassWord = 1967;
            R.CardNumber = 5821781419165245;
            R.cash = 1999999999;

            MList.Add (R);

            MUsers M = new MUsers();
            M.HolderName = "MahmudShiri";
            M.NameBank = "Sepah";
            M.PassWord = 1267;
            M.CardNumber = 5821781419165245;
            M.cash = 1999999999;

            MList.Add (M);
        }

        public bool Check(int Pass)
        {
            foreach (var item in MList)
            {
                if (Pass == item.PassWord)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowMenu(int Pass)
        {
            string Repeat;
            do
            {
                Console
                    .WriteLine("***/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/***");
                Console
                    .WriteLine("WithDrawal/*/*/*/Inventory/*/*/*/Cart TO Cart/*/*/*/ChangePassword/*/*/*/Specifications");
                Console.WriteLine();
                Console.Write("ENTER : ");
                string S = Console.ReadLine();
                switch (S)
                {
                    case "WithDrawal":
                        WithDrawal (Pass);
                        break;
                    case "Inventory":
                        Inventory (Pass);
                        break;
                    case "Cart TO Cart":
                        CartTOCart (Pass);
                        break;
                    case "ChangePassword":
                        ChangePassword (Pass);
                        break;
                    case "Specifications":
                        Specifications (Pass);
                        break;
                    default:
                        Console
                            .WriteLine("NotAvailable/*/*/*/NotAvailable/*/*/*/NotAvailable/*/*/*/NotAvailable/*/*/*/NotAvailable");
                        break;
                }
                System.Console.WriteLine();
                System.Console.Write("You have another request ? y - n ");
                Repeat = Console.ReadLine();
            }
            while (Repeat != "y");
        }

        public bool WithDrawal(int Pass)
        {
            Console.WriteLine($"How much money does want?");
            int Money = int.Parse(Console.ReadLine());

            foreach (var item in MList)
            {
                if (Money <= item.cash)
                {
                    if (Pass == item.PassWord)
                    {
                        Console
                            .WriteLine("/*************************************************************************/");

                        item.cash = item.cash - Money;

                        System.Console.WriteLine("Take your Money");

                        Console
                            .WriteLine("Do you need inventory? ( y - n ) : ");
                        string Inventory;
                        Inventory = Console.ReadLine();
                        if (Inventory == "y")
                        {
                            Console
                                .WriteLine("/*************************************************************************/");
                            Console
                                .WriteLine($"Your account balance : {item.cash}");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Inventory is not enough");
                        }
                    }
                }
            }
            return false;
        }

        public bool Inventory(int Pass)
        {
            foreach (var item in MList)
            {
                if (Pass == item.PassWord)
                {
                    Console
                        .WriteLine("/*************************************************************************/");

                    Console
                        .WriteLine($"{item.HolderName} account balance : {item.cash}");

                    return true;
                }
            }
            return false;
        }

        public bool CartTOCart(int Pass)
        {
            System.Console.WriteLine("Enter the Cart number");
            long CartNumber = long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the amount of money");
            int Money = int.Parse(Console.ReadLine());

            foreach (var item in MList)
            {
                if (Money <= item.cash)
                {
                    if (Pass == item.PassWord)
                    {
                        item.cash = item.cash - Money;
                        System
                            .Console
                            .WriteLine("****************************/Succsess/****************************");
                        System.Console.WriteLine();
                        System
                            .Console
                            .WriteLine($"Destination card :{item.CardNumber} Destination card : { CartNumber} Amount : {Money} AccountBalance : {item.cash}");
                    }
                }
                else
                {
                    Console.WriteLine("Inventory is not enough");
                }
            }
            return false;
        }

        public bool ChangePassword(int Pass)
        {
            foreach (var item in MList)
            {
                if (Pass == item.PassWord)
                {
                    System.Console.WriteLine("Enter your new pass : ");
                    int newpass = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Old Pass is : {item.PassWord}");
                    item.PassWord = newpass;

                    Console
                        .WriteLine($"your new PassWorld is :{item.PassWord}");

                    System.Console.WriteLine("succses");
                    return true;
                }
            }
            return false;
        }

        public List<MUsers> Specifications(int Pass)
        {
            foreach (var item in MList)
            {
                if (Pass == item.PassWord)
                {
                    System.Console.WriteLine($"HolderName : {item.HolderName} ");
                    System.Console.WriteLine($"NameBank : {item.NameBank} ");
                    System.Console.WriteLine($"cash : {item.cash} ");
                    System.Console.WriteLine($"PassWord : {item.PassWord} ");
                    System.Console.WriteLine($"CardNumber : {item.CardNumber} ");
                }
            }
            return MList;
        }
    }
}
