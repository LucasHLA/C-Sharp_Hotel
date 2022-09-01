namespace CSharpHotel.Models
{
    public class Client : Person
    {
        public Client() : base()
        {
        }

        public Client(string name, string cpf, string cellphone) : base(name, cpf, cellphone)
        {
            
        }

        public override void PresentYourself()
        {
            throw new NotImplementedException();
        }
    }
}