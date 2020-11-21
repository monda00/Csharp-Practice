using System;

namespace SampleEX501
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.com", "000-0000-0000");

            cp.Call("111-1111-1111");
            cp.SendMail("foo@email.com");

            IPhone phone = (IPhone)cp;
            phone.Call("222-2222-2222");

            IEmail mail = (IEmail)cp;
            mail.SendMail("fuga@email.com");
        }
    }
}
