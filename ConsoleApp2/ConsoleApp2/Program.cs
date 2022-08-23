using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

class Hello
{

    public static void Main()
    {
        // Specify the directory you want to manipulate.

        string path = @"c:\bd_json";

        try  {
            Console.WriteLine("RUTA = "+ path);
            //Determine whether the directory exists.
            if (Directory.Exists(path)){
                Console.WriteLine("ese camino ya existe");
                return;
            }
            //Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("el directorio fue creado con éxito en {0}.", Directory.GetCreationTime(path));
            //Delete the directory.
            //di.Delete();
            //Console.WriteLine("El directorio se eliminó con éxito.");
        }
        catch (Exception e)  {
            Console.WriteLine("el proceso falló:: {0}", e.ToString());
        }  finally {
            Console.ReadKey();
        }
    }


}
