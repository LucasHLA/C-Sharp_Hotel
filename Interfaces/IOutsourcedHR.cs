using CSharpHotel.Models;

namespace CSharpHotel.Interfaces
{
    public interface IOutsourcedHR
    {
        void HireRoomMaidHR(RoomMaid roomMaid);
        
        void HireRecepcionistHR(Recepcionist recepcionist);

        void PromoteToManager(RoomMaid roomMaid);

        void PromoteToManager(Recepcionist recepcionist);
    }
}