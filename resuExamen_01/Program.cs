using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace resuExa_01
{
    class Program
    {
        //esta propiedad debe cambiarse de acorde a necesidad
        private static String ruta = @"C:\Users\jruiz\Desktop\Datos\";

        //método principal
        static void Main(string[] args){
            //crea instancia del programa para invocar 
            Program ejecu = new Program();
            ejecu.migraOrdersDetails();
            Console.ReadKey();
        }


        //traslada los datos texto a datos binarios para el archivo de
        //Orders Details
        private void migraOrdersDetails()
        {
            //declara variables para estadísticas del proceso
            int registros = 0, errores = 0;
            try
            {
                //obtiene un vector con todo el contenido del archivo plano
                String[] contenido = System.IO.File.ReadAllLines(ruta + "Orders_Details.txt");

                //abre acceso de escritura para archivo binario
                FileStream archi = new FileStream(ruta + "Orders_Details.dat",
                                                  FileMode.OpenOrCreate, FileAccess.Write);

                BinaryFormatter escribir = new BinaryFormatter();

                //procesa línea por línea el archivo plano
                foreach (String linea in contenido)
                {
                    //descompone la linea de texto obtenida por medio del caracter de control
                    String[] valores = linea.Split(';');

                    //aumenta en uno los registro procesados
                    registros++;

                    //escribe el vector obtenido en un objeto de tipo clsOrderDetails en el binario
                    try
                    {
                        escribir.Serialize(archi, new clsOrderDetails(int.Parse(valores[0]),
                                                                      short.Parse(valores[1]),
                                                                      float.Parse(valores[3]),
                                                                      short.Parse(valores[4]),
                                                                      float.Parse(valores[5])));
                    }
                    catch (FormatException e)
                    {
                        //aumenta en uno los registros con error
                        errores++;

                        //invoca el registro de errores
                        regisError("migraOrdersDetails", linea, e.Message);
                    }
                }//fin del procesamiento del archivo plano    

                //cierra el archivo binario
                archi.Close();
            }
            catch (IOException e)
            {
                regisError("migraOrdersDetails","no aplica",e.Message);
            }
            finally
            {
                //invoca al método de detalle para imprimir estadísticas
                detalle("Order Details", registros, errores);
            }
        }//fin del método para migrar Order Details
        

        //imprime las estadísitcas del proceso de migración
        private void detalle(String modulo, int registros, int errores) {
            Console.WriteLine("========================================================");
            Console.WriteLine("Archivo Procesado...: " + modulo);
            Console.WriteLine("Total de Registros..: " + registros);
            Console.WriteLine("Total de Errores....: " + errores);
            Console.WriteLine("Total de Correctos..: " + (registros-errores));
            Console.WriteLine("========================================================\n\n");
        }//fin del método que imprime estadísitcas


        //imprime las estadísitcas del proceso de migración
        private void regisError(String modulo, String codigo, String error){
            try
            {
                //crea el objeto para el acceso al archivo de control de errores
                StreamWriter sw = new StreamWriter(ruta + "Errores_exa_01.log", true, Encoding.UTF8);

                //escribe el error reportado 
                sw.Write(modulo + "\t" + error + "\t" + codigo + "\t" + DateTime.Now.ToString() + "\n");

                //cierra el archivo de errores
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Excepción: " + e.Message);
            }
        }//fin del método para registrar errores.

        }//fin de la clase principal
    }////fin del namespace
