using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4
{
    class handler
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            var k = true;
            while (k)
            {
                Console.WriteLine("Нажмите на кнопку:");
                var letter = Console.ReadKey();

                switch (letter.KeyChar)
                {
                    case 'с':
                        k = false;
                        break;
                    case 'c':
                        k = false;
                        break;

                    default:
                        OnKeyPressed?.Invoke(this, letter.KeyChar);
                        break;
                }

            }
        }
    }
}

