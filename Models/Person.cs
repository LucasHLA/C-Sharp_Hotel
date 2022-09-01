using CSharpHotel.Interfaces;

namespace CSharpHotel.Models
{
    public abstract class Person : IPerson
    {
        public string Name{get;set;}

        public string CPF {get;set;}

        public string Cellphone{get;set;}

        public Person(){

        }

        public Person(string name, string cpf, string cellphone){
            Name = name;
            CPF = cpf;
            Cellphone = cellphone;
        }

        public virtual void PresentYourself(){
            Console.WriteLine("I am the person "+Name);
            Console.WriteLine();
        }
    }
}