using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ooad.Client
{
    class Client
    {
        private string url = "http://localhost:51169/";
        private static volatile Client instance;
        static object key = new object();
        public static Client Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Client();
                    }
                }
                return instance;
            }
        }
        private Client()
        {
        }
        public string Get(string path)
        {
            try
            {
                string jsonString = "error";
                // server local
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync(path);
                response.Wait();
                var readData = response.Result;
                if (readData.IsSuccessStatusCode)
                {
                    var jsonData = readData.Content.ReadAsStringAsync();
                    jsonString = jsonData.Result;
                }
                return jsonString;
            }
            catch
            {
                return "error";
            }
        }
        public void Post(string path, object obj)
        {
            // server local
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                var response = client.PostAsJsonAsync(path, obj).Result;

            }
            catch
            {
                Console.Write("error");
            }
        }
        public async void Delete(string path, string key)
        {
            // server local
            try
            {
                if (key.Length != 0)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(url);
                    var response = await client.DeleteAsync(path + key);
                }
            }
            catch
            {
                Console.Write("error");
            }
        }
        public async void Put(string path, object obj)
        {
            try
            {
                if (obj != null)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(url);
                    var response = await client.PutAsJsonAsync(path, obj);
                }
            }
            catch
            {
                Console.Write("error");
            }
        }
    }
}
