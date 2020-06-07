using System;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.Text.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace codev
{
    class Program
    {
       public class Parser
        {
          public int numero_casas { get; set; }
          public string token { get; set; }
          public string cifrado { get; set; }
          public string decifrado { get; set; }
          public string resumo_criptografico { get; set; }
        }


        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        

        static void Main(string[] args)
        {
            string path = @"G:\vs\answer.json";
            using (var wb = new WebClient())
            {
                string response = wb.DownloadString("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=a84faf22281b5606ec9e840c09e589be0c3cc7d4");
                File.WriteAllText(path, response);
                string teste = File.ReadAllText(path);
                Console.WriteLine(teste);
                var exec = JsonSerializer.Deserialize<Parser>(teste);
                
                
                foreach (char ch in exec.cifrado)
                        exec.decifrado += cipher(ch, 26 - exec.numero_casas);
                Console.WriteLine(exec.decifrado);

                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                
                exec.resumo_criptografico = Hash(exec.decifrado);
                Console.WriteLine(exec.resumo_criptografico);


                string jsonString;
                jsonString = JsonSerializer.Serialize(exec);

                string conv = exec.ToString();
                File.WriteAllText(path,jsonString);

                string caminhoJSON = path;
                string postURI = "https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=";
                string token = "a84faf22281b5606ec9e840c09e589be0c3cc7d4";

                byte[] arquivoByte = File.ReadAllBytes(caminhoJSON);

                using (MultipartFormDataContent tipoConteudo = new MultipartFormDataContent())
                {
                    tipoConteudo.Add(new StreamContent(new MemoryStream(arquivoByte)), "answer", "answer.json");
                    HttpResponseMessage resposta = new HttpClient().PostAsync(postURI + token, tipoConteudo).Result;
                }
            }

            
        }
    }
}
