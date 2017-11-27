using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;

namespace appInternacional
{
    class clsIdioma
    {
        //Variable de tipo constante para contener el diccionario
        static List<clsdicci> diccio ;

        public void Idioma()
        {
            diccio = iniLenguaje();
        }


        //Inicializa el lenguaje del programa
        private List<clsdicci> iniLenguaje()
        {
            //Ruta de los diccionarios
            String ruta = Path.GetFullPath(@"..\..\diccionarios");
            //String ruta = Path.GetFullPath("diccionarios");

            //Crea recurso local para extraer el diccionario
            ResXResourceReader expre;

            //Variable local para identificar el diccionario
            //esta variable es temporal y será sustituida por rutina  
            char lengu = 'I';

            //Selecciona el diccionario de interes
            switch (lengu)
            {
                case 'E':
                    expre = new ResXResourceReader(ruta + @"\misRecursos.resx");
                    break;
                case 'I':
                    expre = new ResXResourceReader(ruta + @"\myResources.resx");
                    break;
                case 'F':
                    expre = new ResXResourceReader(ruta + @"\mesRessources.resx");
                    break;
                default:
                    expre = new ResXResourceReader(ruta + @"\misRecursos.resx");
                    break;
            }//fin del switch de seleccion de los diccionarios

            //Crea el diccionario a memoria a partir de lista dinamica
            List<clsdicci> lista = new List<clsdicci>();

            //Popula la lista con los teminos del diccionario
            foreach (DictionaryEntry tupla in expre)
            {
                lista.Add(new clsdicci(tupla.Key.ToString(), tupla.Value.ToString()));
            }

            return lista;
        }//fin del metodo para iniciar idioma

        //Retorna expresion en lenguaje seleccionado
        public String Expresion(String palabra)
        {
            return (from expre in diccio where expre.Llave.ToString() == palabra select expre).ToArray()[0].Valor;
        }

        //Clase interna para crear el diccionario a memoria
        private class clsdicci
        {
            String llave;
            String valor;

            public clsdicci(string llave, string valor)
            {
                this.Llave = llave;
                this.Valor = valor;
            }

            public string Llave { get => llave; set => llave = value; }
            public string Valor { get => valor; set => valor = value; }
        }        
    }//fin de la clase para idiomas
}//fin del namespace

