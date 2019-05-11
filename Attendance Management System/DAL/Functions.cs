using Attendance_Management_System.BLL;
using Microsoft.Extensions.Configuration.IConfiguration;
using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Twilio.VS2010;

namespace Attendance_Management_System.DAL
{
    class Functions
    {
        ParentsBLL pbll = new ParentsBLL();
        bool SendSMS(string StudentID, string Name,string Message, string From)
        {
            bool IsSuccess = false; 
            try
            {
                var client = new Client(creds: new Nexmo.Api.Request.Credentials
                {
                    ApiKey =  "kxadjkmKlcHJ68df4X39bcGfj", //from appsettings.json
                    ApiSecret ="7jad67df^ed6hjkJKS%jytlgj0jl"//from appsettings.json
                });

                var results = client.SMS.Send(request: new Nexmo.Api.SMS.SMSRequest
                {
                    from = From, //school number
                    to = pbll.Phone,
                    text = Message
                });
                IsSuccess = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString(), $"{pbll.Phone} - {From} - {Message}");
            }
            return IsSuccess;
        }
    }
}
