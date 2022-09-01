using CSharpHotel.Interfaces;

namespace CSharpHotel.Models
{
    public class Manager : Person, IManager
    {
        public Manager() : base()
        {
        }

        public Manager(string name, string cpf, string cellphone) : base(name, cpf, cellphone)
        {
        }

        public void CleanTheRoom()
        {
            Console.WriteLine("I am the manager and i know hhow to clean a room");
            Console.WriteLine();
        }

        public void KnowHowTheHotelWorks()
        {
            Console.WriteLine("I am the manager I know how the whole Hotel works very well!");
            Console.WriteLine();
        }

        public void MakeTheBed()
        {
            Console.WriteLine("I am the manager and i know how to make the bed");
            Console.WriteLine();
        }

        public void PickUpThePhone()
        {
            Console.WriteLine("I am the manager and i know how to pick up the phone");
            Console.WriteLine();
        }

        public override void PresentYourself()
        {
            Console.WriteLine("Hello, it is nice to meet you, I Am the manager, my name is "+Name);
            Console.WriteLine();
        }

        public void SpeakAdvancedEnglish()
        {
            Console.WriteLine("I am the manager and i do speak advanced English");
            Console.WriteLine();
        }
    }
}