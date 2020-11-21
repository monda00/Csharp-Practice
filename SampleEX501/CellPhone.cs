using System;

namespace SampleEX501
{
    class CellPhone : IPhone, IEmail
    {
        private string mailAddress;
        private string number;

        public CellPhone(string mailAddress, string number)
        {
            this.mailAddress = mailAddress;
            this.number = number;
        }

        public void SendMail(string address)
        {
            Console.WriteLine("send mail from " + this.mailAddress + " to " + address);
        }

        public void Call(string number)
        {
            Console.WriteLine("call from " + this.number + " to " + number);
        }
    }
}