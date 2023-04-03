/// @author Денисова Екатерина
/// класс бот

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Windows.Forms;
using Newtonsoft.Json;

public abstract class IChatBot
{
    public abstract string Answer(string q);
}

namespace Chat_Bot
{
    
    public class ChatBot : IChatBot
    {
        public static string uName;  // имя пользователя

        public static void SetUserName(string s)
        {
            uName = s;
        }


        public List<string> history = new List<string>();
        public int lastLineIndex = 0;
        //public static string path = "history";

        // Загрузка истории из файла в list history
        public void LoadHistory(string path = "history")
        {
            // проверка на существование файла
            // если не существует, то создать
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            string s;

            // чтение
            /*using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }*/


            // асинхронное чтение
            /*using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }*/

            using (StreamReader reader = new StreamReader(path))
            {

                do
                {
                    // Прочитать строку из файла
                    s = reader.ReadLine();

                    history.Add(s); // добавление строки в историю
                }
                while (s != null); // проверка, не конец ли файла

                reader.Close();
                
            }

            // если файл пустой
            /*if ((text == null))
            {
                text = "";
            }
            history.Add(text); // добавление содержимого файла в историю*/

        }

        // добавление истории в файл
        public void SaveHistory(string path = "history")
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            /*if (s == null)
            {
                s = "";
            }*/

            // добавление текста в файл
            /*using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(s);
            }*/

            // добавление в файл
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int i = lastLineIndex+1; i < history.Count(); i++)
                {
                    writer.WriteLine(history[i]);
                }
                
            }

        }


        // приветствие
        public static Regex regexHello = new Regex(@"пр(и|e)ве*т|прив|х(а|e|э)*й|hi*|hello*|(зд|д)(а|о)ро*(в|у)", RegexOptions.IgnoreCase);
        // время
        public static Regex regexTime = new Regex(@"ча(с|сов)|врем(я|ени)", RegexOptions.IgnoreCase);
        // дата
        public static Regex regexDate = new Regex(@"дата|число|день", RegexOptions.IgnoreCase);
        // команды с параметрами
        public static Regex regexSum = new Regex(@"^сложи \d* и \d*$", RegexOptions.IgnoreCase);
        public static Regex regexSub = new Regex(@"^вычти \d* из \d*$", RegexOptions.IgnoreCase);
        public static Regex regexMult = new Regex(@"^умножь \d* на \d*$", RegexOptions.IgnoreCase);
        public static Regex regexDiv = new Regex(@"^(раз|по)дели \d* на \d*$", RegexOptions.IgnoreCase);
        // погода
        public static Regex regexWeather = new Regex(@"погода|градус(ов|ы)|температура", RegexOptions.IgnoreCase);






        public string BotHello()
        {
            Random r = new Random();
            string[] arr = { "Привет", "Приветствую", "Хэй", "Здаров"};
            int a = r.Next(arr.Length); // случайный индекс массива

            return arr[a] + ", " + uName;
        }

        public string BotTime()
        {
            return "Время: " + DateTime.Now.ToString("HH:mm:ss") + "\r\n";
        }

        public string BotDate()
        {
            return "Дата: " + DateTime.Now.ToString("dd/MM/yyyy") + "\r\n";
        }

        public int BotSum(string s)
        {
            string[] s_arr = s.Split();
            int x1 = int.Parse(s_arr[1]);
            int x2 = int.Parse(s_arr[3]);
            return x1+x2;
        }

        public int BotSub(string s)
        {
            string[] s_arr = s.Split();
            int x1 = int.Parse(s_arr[1]);
            int x2 = int.Parse(s_arr[3]);
            return x2 - x1;
        }

        public int BotMult(string s)
        {
            string[] s_arr = s.Split();
            int x1 = int.Parse(s_arr[1]);
            int x2 = int.Parse(s_arr[3]);
            return x1 * x2;
        }

        public int BotDiv(string s)
        {
            string[] s_arr = s.Split();
            int x1 = int.Parse(s_arr[1]);
            int x2 = int.Parse(s_arr[3]);
            return x1/x2;
        }


        //string url = "https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&units=metric&appid=ab34896f51377943f5ff794a7f16498d";
        string url = "https://api.openweathermap.org/data/2.5/weather?q=Chita,ru&units=metric&appid=ab34896f51377943f5ff794a7f16498d";

        public string BotWeather()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); 
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            return "Температура в " + weatherResponse.Name + ": " + weatherResponse.Main.Temp + "°C\r\n";
        }

        public string BotAnswer()
        {
            return "Бот, " + DateTime.Now.ToString("HH:mm:ss") + ":"; // + "\r\n" + ans + "\r\n";
        }

        public string UserRequest()
        {
            return uName + ", " + DateTime.Now.ToString("HH:mm:ss") + ":"; //+ "\r\n" + req + "\r\n";
        }

        public override string Answer(string q)
        {
            history.Add(UserRequest());
            history.Add(q);
            history.Add("\r\n");
            history.Add(BotAnswer());
          
            string s = "";
            s += UserRequest() + "\r\n" + q + "\r\n\r\n" + BotAnswer() + "\r\n";

            if (regexHello.IsMatch(q))
            {
                history.Add(BotHello());
                history.Add("\r\n");
                s += BotHello() + "\r\n\r\n";

                //return BotHello() + "\r\n";
            }

            else if (regexTime.IsMatch(q))
            {
                history.Add(BotTime());
                history.Add("\r\n");
                s += BotTime() + "\r\n\r\n";
                //return BotTime() + "\r\n";
            }

            else if (regexDate.IsMatch(q))
            {
                history.Add(BotDate());
                history.Add("\r\n");
                s += BotDate() + "\r\n\r\n";
                //return BotDate() + "\r\n";
            }

            else if (regexSum.IsMatch(q))
            {
                history.Add(Convert.ToString((BotSum(q))));
                history.Add("\r\n");
                s += Convert.ToString((BotSum(q))) + "\r\n\r\n";
                //return BotSum() + "\r\n";
            }

            else if (regexSub.IsMatch(q))
            {
                history.Add(Convert.ToString((BotSub(q))));
                history.Add("\r\n");
                s += Convert.ToString((BotSub(q))) + "\r\n\r\n";
                //return BotSub() + "\r\n";
            }

            else if (regexMult.IsMatch(q))
            {
                history.Add(Convert.ToString((BotMult(q))));
                history.Add("\r\n");
                s += Convert.ToString((BotMult(q))) + "\r\n\r\n";
                //return BotMult() + "\r\n";
            }

            else if (regexDiv.IsMatch(q))
            {
                history.Add(Convert.ToString((BotDiv(q))));
                history.Add("\r\n");
                s += Convert.ToString((BotDiv(q))) + "\r\n\r\n";
                //return BotDiv() + "\r\n";
            }
            else if (regexWeather.IsMatch(q))
            {
                s += BotWeather() + "\r\n\r\n";
            }

            else
            {
                history.Add("Не знаю такой команды");
                history.Add("\r\n");
                s += "Не знаю такой команды\r\n\r\n";
                //return "Не знаю такой команды\r\n";
            }
            return s;
        }


    }


}
