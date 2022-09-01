using CSharpHotel.Exceptions;
using CSharpHotel.Interfaces;


namespace CSharpHotel.Models
{
    public class HR : IOutsourcedHR
    {
        public HR(string name) 
        {
            this.Name = name;
   
        }
                public string Name{get;set;}
        public Hotel Hotel{get;set;}

        public HR(string name, Hotel hotel)
        {
            Name = name;
            Hotel = hotel;
        }

        public void HireRecepcionistHR(Recepcionist recepcionist)
        {
            Hotel.Recepcionists.Add(recepcionist);
        }

        public void HireRoomMaidHR(RoomMaid roomMaid)
        {
            Hotel.RoomMaids.Add(roomMaid);
        }

        public void PromoteToManager(RoomMaid roomMaid)
        {
            if(roomMaid.CPF == null){
                throw new InvalidDocumentsExceptions();
            }

            Hotel.HireManager(new Manager(){
                Name = roomMaid.Name,
                CPF = roomMaid.CPF,
                Cellphone = roomMaid.Cellphone
            });
            
        }

        public void PromoteToManager(Recepcionist recepcionist)
        {
            if(recepcionist.CPF == null){
                throw new InvalidDocumentsExceptions("Regularize your CPF to be promoted");
            }
            Hotel.HireManager(new Manager(){
                Name = recepcionist.Name,
                CPF = recepcionist.CPF,
                Cellphone = recepcionist.Cellphone
            });
        }
    }
}
