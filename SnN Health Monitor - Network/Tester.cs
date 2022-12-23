namespace Network
{
    public class Tester
    {
        static void Main()
        {
            var address = "192.168.1.253";
            var timeout = 1000;
            var ping = new NetPinger(address, timeout);
            var successStatus = ping.IsSuccessful;

            if (successStatus)
               Console.WriteLine("Ping was successful with time : " + ping.Time);
            else
                 Console.WriteLine("Ping was unsuccessful with time : " + ping.Time);
        }
    }
}
