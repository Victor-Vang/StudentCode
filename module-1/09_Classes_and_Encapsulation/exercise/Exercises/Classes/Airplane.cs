namespace Exercises.Classes
{
    public class Airplane
    {

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }

        public int BookedFirstClassSeats { get; private set; }
        
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; private set; }

        public int BookedCoachSeats { get; private set; }
       
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true)
            {
                int occupiedSeats = totalNumberOfSeats + BookedFirstClassSeats;
                if (occupiedSeats <= TotalFirstClassSeats)
                {
                    BookedFirstClassSeats = occupiedSeats;
                    return true;
                }
                else if (occupiedSeats > TotalFirstClassSeats)
                {
                    return false;
                }
            }
            else if (forFirstClass == false)
            {
                int occupiedSeats = totalNumberOfSeats + BookedCoachSeats;
                if (occupiedSeats <= TotalCoachSeats)
                {
                    BookedCoachSeats = occupiedSeats;
                    return true;
                }
                else if (occupiedSeats > TotalCoachSeats)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
