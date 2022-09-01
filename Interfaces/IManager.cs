namespace CSharpHotel.Interfaces
{
    public interface IManager : IRoomMaid, IRecepcionist, IPerson
    {
        void KnowHowTheHotelWorks();
    }
}