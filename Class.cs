namespace Pemograman.ClassDanObject
{
    public class class
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void taxiinfo()
        {
			Console.WriteLine(" Driver Name : {0}", DriverName);
            Console.WriteLine(" OnDuty : {0}", OnDuty);
            Console.WriteLine(" Number Passenger : {0}", NumPassenger);
        }

        public void pickuppassenger()
        {
            Console.WriteLine("{0}, sedang menjemput penumpang", name);
        }

        public void dropoffpassenger()
        {
            Console.WriteLine("{0}, selesai mengantar penumpang", name);
        }
    }
}