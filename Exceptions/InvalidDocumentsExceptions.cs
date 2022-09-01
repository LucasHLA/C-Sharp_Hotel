namespace CSharpHotel.Exceptions
{
    public class InvalidDocumentsExceptions : Exception
    {
         public InvalidDocumentsExceptions()
         :base("Invalid Documents, verify!")
         {

         }


         public InvalidDocumentsExceptions(string message) : base(message)
         {

         }
    }
}