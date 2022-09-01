using CSharpHotel.Interfaces;

namespace CSharpHotel.Models
{
    public class RoomMaid : Person,IRoomMaid
    {
        public RoomMaid() : base()
        {
        }

        public RoomMaid(string name, string cpf, string cellphone) : base(name, cpf, cellphone)
        {
        }

        public void CleanTheRoom()
        {
            Console.WriteLine("I know how to clean the room");
        }

        public void MakeTheBed()
        {
           Console.WriteLine("I know how to make the bed");
        }

        public override void PresentYourself()
        {
            System.Console.WriteLine("Nice to meet you, i am the Room Maid "+Name);
        }
    }
}