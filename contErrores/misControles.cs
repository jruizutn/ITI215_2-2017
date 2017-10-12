using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conErrores
{
    class misControles
    {
        public void valiNegativos(int param){
            if (param < 0){
                throw new miExcepcion("Número negativo");
            }
        }//fin del metodo de validar valores negativos

        //declara vector para el control de malas palabras
        string[] malasPala = {"puto", "puta", "hijueputa", "malparido", "malparida", "mierda", "verga",
                              "picha", "carepicha", "playo" ,"culo", "estupido" ,"imbecil", "porno",
                              "playo" ,"culo","mongolo" ,"estupida", "mongola", "idiota","tierrosa"};

        public void malasPal(string param){
            string[] txt = param.Split(' ');

            for (int a = 0; a < param.Length; a++){
                for (int i = 0; i < malasPala.Length; i++){
                    if (txt[a] == malasPala[i]){
                        throw new miExcepcion(" Palabra inapropiada");
                    }
                }
            }
        }//fin de control de malas palabras

        public void correc(string param){
            for (int i = 0; i < malasPala.Length; i++){
                if (param.Contains(malasPala[i])){
                    param = param.Replace(malasPala[i], "****");
                }
            }
            throw new miExcepcion(param);
        }//fin del metodo de censura de errores


        public void palabrotas2(String[] cadena){
            String salida = " ";  //salida es un espacio en blanco pero despues se va modificando con todas las palabras buenas
            String[] palabrasM = {"carepicha","picha","playo", //vectorcon las palabras que desee bloquear
                            "hijueputa","malparido",
                            "idiota", "imbecil","pichazo","puta"};

            String aux = " ";  //variable que sirve para igualar a palabu
            foreach (String palabu in cadena) //palabu sera un string que este en cadena, va en orden
            {
                aux = palabu; //aux pasaria a ser palabu, y palabu es la primer palabra de el vector cadena, y cadena es toda la oracion que el usuario introdujo
                foreach (String palama in palabrasM)//dice que palama sera todas las palabras que esten en el vector de palabrasM
                {
                    if (palama == palabu)//compara la palabra mala con la palabra que este en la oracion que usuario uso 
                    {
                        aux = " !#$%&&/( "; //si son iguales quiere decir que hay una mala palabra, entonces aux cambia por lo que quiero bloquearlo, entonces la mala palabra se bloquea

                    }
                }

                salida = salida + " " + aux;//luego salida(que es un espacio en blanco), cambia y escribe lo que aux tenga, hay dos opciones que siga escribiendo la oracion que el usuario introdujo o que la bloquee si es una mala palabra, eso dependera de si es una buena o mala palabra 
            }

            throw new miExcepcion(salida); //Tira la oracion ya cambiada, en el caso de que se hiciera un cambio 
        }
    }
}