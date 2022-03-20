using System;

namespace enums
{
    class Program
    {
        enum EmpTypeEnum
        {
            Manager,
            Grunt,
            Contractor,
            VicePresident
        };

        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            var manager = EmpTypeEnum.Manager;
            AskForBonus(manager);
            Console.WriteLine(manager.GetType());
            Console.WriteLine(Enum.GetUnderlyingType(manager.GetType()));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
            Console.WriteLine(manager.ToString());
            Console.WriteLine(manager.GetHashCode());
            foreach (var item in Enum.GetValues(typeof(EmpTypeEnum)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
