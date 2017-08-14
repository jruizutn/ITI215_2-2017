//Cargando librerias
import java.util.Random;
import javax.swing.JOptionPane;

public class corrida {
    public static void main(String[] args) {
        //Declaración de vectores
        int vec1[] = null;
        int vec2[] = new int [5];
        int vec3[] = null, vec4;
        int[] vec5 = null, vec6 = null;

        //Diferentes formas de inicializar el código
        vec1 = iniVector(10);
        iniVector(vec2);
        vec3 = iniVector(10);
        vec5 = iniVector(10);
        vec6 = iniVector(Integer.
                         parseInt(JOptionPane.
                                showInputDialog("Digite tamaño")));
        
        //Imprime uno de los vectores
        impriVector(vec1);
    }
    
    private static void iniVector(int vc[]){        
        Random rnd = new Random();
        for(int i=0; i < vc.length; i++){
            vc[i] = rnd.nextInt(100)+1;
        }
    }
    
    private static int[] iniVector(int tam){
        int vc[] = new int [tam];
        Random rnd = new Random();
        for(int i=0; i < vc.length; i++){
            vc[i] = rnd.nextInt(100)+1;
        }
        return vc;
    }
    
    private static void impriVector(int vc[]){
        for(int i=0; i < vc.length; i++){
            System.out.println(vc[i]);
        }
    }
    
}








