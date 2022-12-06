using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace Hospital_Management_System
{
    public abstract class DataAcces
    {
        static public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static SqlConnection SqlConnection;
        static string connectionString  = "Data Source=Decode;Initial Catalog=Hospital_DB;Integrated Security=True";

        public DataAcces()
        {
             //ConfigurationManager.ConnectionStrings["HospitalDataBaseConnectionString"].ConnectionString;
        }

        
        public static DataTable ExecuteQuery(string sql)
        {
            try
            {
                using (SqlConnection = new SqlConnection(connectionString))
                {
                    SqlConnection.Open();
                    using (var command = new SqlCommand(sql, SqlConnection))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        DataSet dataset = new DataSet();
                        sqlDataAdapter.Fill(dataset);
                        return dataset.Tables[0];

                    }

                }
            }
            catch(Exception e)
            {
                throw e;
                return null;
            }
        }

        public static void ExecuteUpdateQuery(string sql)
        {
            try
            {
                using (SqlConnection = new SqlConnection(connectionString))
                {
                    SqlConnection.Open();
                    using (var command = new SqlCommand(sql, SqlConnection))
                    {
                        command.ExecuteNonQuery();
                        
                    }

                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static bool LoginCheck(string sql)
        {
            try
            {
                using (SqlConnection = new SqlConnection(connectionString))
                {
                    SqlConnection.Open();
                    using (var command = new SqlCommand(sql, SqlConnection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }


        }

        public static string Email(string userEmail,string userPassword)
        {
            string tempPassword = RandomNumber(1000, 10000).ToString();
            string deleveryMessage;
            string email = "team.dynamics.inventory@gmail.com";
            string password = "teamdynamic11";
            SmtpClient smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = email,
                    Password = password
                }
            };
            MailAddress From = new MailAddress(email, "team dynamic");
            MailAddress To = new MailAddress(userEmail, "Someone");
            MailMessage mailMessage = new MailMessage()
            {
                From = From,
                Subject = "noreply-Hospital Management System",
                Body = "" +
                "\nInvo-" +"Your user account password is"+ userPassword + ""
            };
            mailMessage.To.Add(To);
            try
            {
                smtpClient.Send(mailMessage);
                deleveryMessage = @"A temporary password has been sent to your email, 
                                    Plese log in and then manualy reset the password";

            }
            catch (Exception ex) { deleveryMessage = ex.Message; }
            return deleveryMessage;
        }


    }
}
