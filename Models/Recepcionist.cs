using CSharpHotel.Interfaces;

namespace CSharpHotel.Models
{
    public class Recepcionist : Person,IRecepcionist
    {
        public Recepcionist() : base()
        {
        }

        public Recepcionist(string name, string cpf, string cellphone) : base(name, cpf, cellphone)
        {
        }

        public void PickUpThePhone()
        {
            Console.WriteLine("I know how to pick up the phone!");
        }

        public override void PresentYourself()
        {
            Console.WriteLine("Hello, nice to meet you! i am the recepcionist "+Name);
            
        }

        public void SpeakAdvancedEnglish()
        {
            Console.WriteLine("I Speak advanced english!");
        }
    }
}