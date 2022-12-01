using System;
using System.IO;
using System.Threading;

namespace proxyma_task1
{
    class Program
    {
        public static int GetInterval()
        {
            string text = "";
            using (StreamReader fs = new StreamReader(@"D:\1.txt"))
            {
                while (true)
                {
                    // Читаем строку из файла во временную переменную.
                    string temp = fs.ReadLine();
                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;
                    // Пишем считанную строку в итоговую переменную.
                    text += temp;
                }
            }
            // конвертируем принятую string-переменную в INT 
            int interval = Convert.ToInt32(text);
            Console.WriteLine(interval);
            return interval;
        
        }

        static void Main(string[] args)
        {
            // Время указывается в миллисекундах
            Timer timer = new Timer(showTime, null, 0, GetInterval());
            // Таймер будет работать до тех пор, пока мы не нажмём Enter
            string txt = Console.ReadLine();
            if (txt == "quit" || txt == "QUIT") return ;
                
        }

        static void showTime(Object obj)
        {
            Console.WriteLine("Текущие дата и время: {0}", DateTime.Now.ToString());
        }

    }
}

 

  

