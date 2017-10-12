using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conErrores{
    class Program{
        static void Main(string[] args){
            int val1 = 0, val2 = 0, resu = 0;
            try{
                //captura los datos y los asigna a las variables
                Console.Write("Digite un valor entero  ");
                val1 = int.Parse(Console.ReadLine());

                Console.Write("Digite un segundo valor entero  ");
                val2 = int.Parse(Console.ReadLine());

                //se realiza una division entre los numeros dados por el usuario
                resu = val1 / val2;
            }catch(FormatException err){
                Console.WriteLine("Error: " + err.Message);
            }catch(ArithmeticException err){
                Console.WriteLine("Error: " + err.Message);
            }catch(Exception err){
                Console.WriteLine("Error: " + err.Message);
            }finally{
                Console.Write("Resultado es " + resu);
            }

            //control de errores personalizados
            misControles validar = new misControles();

            try{
                validar.correc(" El profe es un gran playo y es un mongolo ");
            }catch (miExcepcion err){
                Console.Write(err.Message);
            }

            //espera que el usuario presione una tecla para salir
            Console.ReadKey();
        }
    }
}