using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.VS2010;

namespace Attendance_Management_System.DAL
{
    class Functions
    {
        void SendSMS(string studentid, string name)
        {
            try
            {

                //do all your validations first before submitting the message. This depends on your requirements for the SMS system

                const string accountSid = "ACa391ae95a4326a583a32ec9da356e4ca";
                const string authToken = "a678b0e3974f485da98cc368262f65e3";
                TwilioClient.Init(accountSid, authToken)

                if (item.SubItems(3).text <> "") {
                   string toNumber = New PhoneNumber(item.SubItems(3).text) //+61467513992
                   string message = MessageResource.Create(
                        toNumber, from:= New PhoneNumber("+61448687018"),
                    body:= "You child " & name & " of student id" & studentid &
                        " days. Waiting for scheduling.");
                    Console.WriteLine(message.Sid)
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
