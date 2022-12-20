using System.Net.NetworkInformation;

namespace Network
{
    public class NetPinger
    {
        private readonly Ping _ping = new Ping();
        public float Time { get; private set; }
        public int StatusCode { get; private set; }
        public bool IsSuccessful
        {
            get {return this.StatusCode == 0;}

        }

        public NetPinger(string address, int timeout)
        {
            if (string.IsNullOrEmpty(address) || timeout <= 0) 
                throw new InvalidOperationException();

            this.SendPing(address, timeout);
        }

        private void SendPing(string address, int timeout)
        {
            PingReply reply = _ping.Send(address, timeout);

            this.Time = reply.RoundtripTime;
            this.StatusCode = (int)reply.Status;
        }
    }
}
