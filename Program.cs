using CSharpHotel.Models;
using CSharpHotel.Interfaces;
using CSharpHotel.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        {

        }
        Console.WriteLine("***************************************");
        Console.WriteLine("************ CSharp Hotel *************");
        Console.WriteLine("***************************************");
        Console.WriteLine();

        //Hire a room maid
        IRoomMaid roomMaid = new RoomMaid("Angela", "1234334535", "14489242");


        //Hire a recepcionist
        IRecepcionist recepcionist = new Recepcionist()
        {
            Name = "Julia",
            CPF = "97975649684",
            Cellphone = "32432423"
        };

        IManager manager = new Manager("Lucas", "888943930339", "039293839");
        IManager manager2 = new Manager("Joe", "9767656789898", "098764456");

        Hotel hotel = new Hotel("C-Sharp Hotal", new Adress()
        {
            CEP = "1345353336",
            Street = "XYZ",
            Number = 77,
            Additional_Information = "Third corner",
            Neighborhood = "seventh",
            City = "Bauru"
        });

        hotel.HireRoomMaid(roomMaid);
        hotel.HireRecepcionists(recepcionist);
        hotel.HireManager(manager);
        hotel.HireRecepcionists(manager2);
        hotel.HireRoomMaid(manager2);

        hotel.Manager.PresentYourself();

        foreach (var maid in hotel.RoomMaids)
        {
            maid.PresentYourself();
        }

        foreach (var recep in hotel.Recepcionists)
        {
            recep.PresentYourself();
        }

        //From now on everything is related to HR

        IOutsourcedHR hr = new HR("C-Sharp HR",hotel);

        //Hire a room maid

        var roomMaid2  = new RoomMaid{
            Name = "Eugene"
        };

        hr.HireRoomMaidHR(roomMaid2);

        // Hire recepcionist

        var recepcionist2 = new Recepcionist{
            Name = "Joyce",
            CPF = "1213223552"
        };

        hr.HireRecepcionistHR(recepcionist2);

        //promote a Room Maid to manager
        var promotedRoomMaid = new RoomMaid{
            Name = "Evelyn"
        };

        try
        {
            hr.PromoteToManager(promotedRoomMaid);
        }
        catch (InvalidDocumentsExceptions ex)
        {
            
           Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
       {
            //If it falls here , it menas that something is wrong with the code
            Console.WriteLine(ex.Message);
       }
       
        //promote a Recepcionist to manager

        var promotedRecepcionist = new Recepcionist{
            Name = "Amanda",
            CPF = "8978978676"
        };


       try
       {
         hr.PromoteToManager(promotedRecepcionist);
       }
       catch (InvalidDocumentsExceptions ex)
       {
        
         Console.WriteLine(ex.Message);
       }
       catch(Exception ex)
       {
            //If it falls here , it menas that something is wrong with the code
            Console.WriteLine(ex.Message);
       }
}
}