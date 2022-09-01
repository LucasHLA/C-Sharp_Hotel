using CSharpHotel.Interfaces;

namespace CSharpHotel.Models
{
    public class Hotel
    {
        public string Name{get;set;}

        public Adress Adress{get;set;}

        public List<IRecepcionist> Recepcionists {get; private set;}

        public List<IRoomMaid> RoomMaids{get; private set;}

        public IManager Manager{get; private set;}

        public Hotel(string name)
        {
            Name = name;
            Recepcionists = new List<IRecepcionist>();
            RoomMaids = new List<IRoomMaid>();
        }

        public Hotel(string name,Adress adress)
        {
            Name = name;
            Adress = adress;
            Recepcionists = new List<IRecepcionist>();
            RoomMaids = new List<IRoomMaid>();
        }

        public void HireManager(IManager manager)
        {
            Manager = manager;

        }

        public void HireRoomMaid(IRoomMaid roomMaid)
        {
            RoomMaids.Add(roomMaid);
        }

        public void HireRecepcionists(IRecepcionist recepcionist)
        {
            Recepcionists.Add(recepcionist);
        }
    }
}