using System;
using System.Collections.Generic;
using System.Threading;

namespace HW
{
    class Program
    {
        public static void Main(string[] args)
        {  
            var requestHandler = new DummyRequestHandler();

            void NewRequest(string message)
            {  
                Console.WriteLine($"Будет послано сообщение {message} \n");
                Console.WriteLine("Введите аргументы сообщения. Если аргументы не нужны " + "- введите /end \n");
                var args = new List<string>();
                string argument;
                while ((argument = Console.ReadLine()) != "/end")
                {
                    args.Add(argument);
                    Console.WriteLine("Введите следующий аргумент сообщения. " + "Для окончания добавления " + "аргументов введите /end \n" );
                }
                var id = Guid.NewGuid().ToString("D");
                Console.WriteLine($"Было отправлено сообщение \"{message}\". " + $"Присвоен идентификатор {id} \n");
                ThreadPool.QueueUserWorkItem(_ =>HandleRequest(id, message, args.ToArray()));
            }

            void HandleRequest(string id, string message,string[] args)
            {
                try
                {
                    var response = requestHandler.HandleRequest(message, args);
                    Console.WriteLine($"Сообщение с идентификатором {id} " + $"получило ответ - {response} \n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Сообщение с идентификатором {id} " + $"упало с ошибкой: {ex.Message} \n");
                }
            }
            
            string request ;
            Console.WriteLine("Введите текст запроса для отправки. " + "Для выхода введите /exit \n");            
            while ((request = Console.ReadLine()) != "/exit")
            {
                NewRequest(request);
                Console.WriteLine("Введите текст запроса для отправки. " + "Для выхода введите /exit \n");
            }
            Console.WriteLine("Конец работы " );
        }
    }
}

   