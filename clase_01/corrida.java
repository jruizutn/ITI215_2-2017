
import javax.swing.JOptionPane;

public class corrida {

    public static void main(String[] args) {
        //declaración de variables
        int val1;
        int val2 = 0;
        int a1, a2, a3;
        int b1 = 1, b2 =2;
        
        float precio1 = 453.70f;
        double precio2 = 453.70;
        
        //ejemplo de procesos
        val1 = 34;
        val2 = val1 + 45;
        System.out.print("El valor de val1 es: "+val1+
                         "\nel valor de val2 es: " +val2+"\n");
        
        //capturando datos
        String nombre ;
        nombre = JOptionPane.showInputDialog("Digite un nombre");
        
        a1 = Integer.parseInt(JOptionPane.
                showInputDialog("Digite un número entro"));
        
        precio1 = Float.parseFloat(JOptionPane.
                showInputDialog("Digite un número flotante"));
        
        char letra = JOptionPane.
                showInputDialog("Digite un caracter").charAt(0);
        
        JOptionPane.
            showMessageDialog(null,"Yo me llamo " + nombre +
                                   "\nEl libro cuesta "+String.valueOf(precio1)+
                                   "\nEl número digitado fue: " + a1 +
                                   "\nEl caracter digitado fue: " + letra);
                
    }
    
}
