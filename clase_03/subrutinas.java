
import java.util.Random;
import javax.swing.JOptionPane;


public class subrutinas {
    //rutinas locales
    public void saludar(){
        JOptionPane.showMessageDialog(null,"buenas tardes a todos");
    }//fin de saludar
    
    public void saludar(String alguien){
        JOptionPane.showMessageDialog(null,"buenas tardes " +alguien);
    }//fin de saludar
    
    //retorna un valor entero
    public int suma(int a, int b){
        return a+b;
    }
    
    //utiliza libreria random para calcular aleatorios
    public int dados(){
        Random rnd = new Random();
        return rnd.nextInt(6)+1;
    }
    
}
















