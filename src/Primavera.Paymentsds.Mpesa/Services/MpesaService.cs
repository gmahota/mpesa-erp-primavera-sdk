using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Primavera.Paymentsds.Mpesa.Models;
using Newtonsoft.Json;

namespace Primavera.Paymentsds.Mpesa.Services
{
    public class MpesaService : BaseService
    {
        static HttpClient client = new HttpClient();

        public string api_host;
        public string api_token { get; set; }
        public string api_key { get; set; }
        public string entity_uuid { get; set; }
        public string logFolder { get; set; }
        public MpesaService(string host, string apiKey, string entity_uuid, string log)
        {
            this.api_host = host;
            this.api_key = apiKey;
            this.entity_uuid = entity_uuid;
            this.logFolder = log;
        }

        public async Task<string> GetReference(string userName, string password,string phonenumber, string documento, double amount)
        {
            try
            {
                if (! await GetToken(userName, password))
                {
                    throw new Exception("User or Password Not Valid!");
                }
                                
                // Update port # in the following line.
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(api_host);
                }

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                client.DefaultRequestHeaders.Authorization = 
                    new AuthenticationHeaderValue("Bearer", api_token);
                
                client.DefaultRequestHeaders
                    .TryAddWithoutValidation("Content-Type", "application/json");

                Invoice inv = new Invoice
                {
                    amount = 1,
                    invoice_number = documento,
                    phonenumber = phonenumber
                };

                string jsonString = JsonConvert.SerializeObject(inv);

                string url = string.Format(@"api/mpesa/recievemoney?amount={0}&number={1}&phonenumber={2}",
                    inv.amount, 
                    inv.invoice_number,
                    phonenumber
                );

                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var pagamentosServico = JsonConvert.DeserializeObject<MpesaResponce>(response.Content.ReadAsStringAsync().Result);

                    return response.Content.ReadAsStringAsync().Result;
                    //Escreve no ERP Os Dados
                }
                else
                {
                    throw new Exception("Error call the api " + "/n" + JsonConvert.SerializeObject(response));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> GetToken(string userName, string password)
        {
            try
            {
                // Create a new product
                User user = new User
                {
                    username = userName,
                    password = password
                };

                // Update port # in the following line.
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(api_host);
                }

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                string jsonString = JsonConvert.SerializeObject(user);

                string url = string.Format(@"api/login");

                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var resp = JsonConvert.DeserializeObject<UserResponse>(response.Content.ReadAsStringAsync().Result);

                    this.api_token = resp.access_token;

                    return true;
                    //Escreve no ERP Os Dados
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
              
    }
}
