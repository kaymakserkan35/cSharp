using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OtomatikMail
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=NORTHWND;User ID=udemy; Password =1";
            string sql = "select * from Orders where OrderDate>= DATEADD(DAY, -720, CONVERT(date, sysdatetime()))";
            SqlDataAdapter sda=new SqlDataAdapter(sql,cs);
            DataTable dt=new DataTable();
            sda.Fill(dt);

            string mailBody = "";
            foreach (DataRow item in dt.Rows)
            {
                mailBody += item["OrderDate"] + " " + item["CustomerID"];
            }

            MailGonder(mailBody);
        }

        private static void MailGonder(string mailBody)
        {
            MailMessage ePosta=new MailMessage();
            ePosta.From=new MailAddress("canbozzz1@gmail.com");
            ePosta.To.Add("bmuguraydin@gmail.com");
            ePosta.Subject = "Son Siparişler";
            ePosta.Body = mailBody;

            SmtpClient stmp=new SmtpClient();
            stmp.Credentials=new System.Net.NetworkCredential("canbozzz1@gmail.com","6156876413213543213");
            stmp.Port = 587;
            stmp.Host = "smtp.gmail.com";
            stmp.EnableSsl = true;
            stmp.Send(ePosta);
        }
    }
}
