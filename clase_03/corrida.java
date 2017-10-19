
import javax.swing.JOptionPane;


public class corrida {

    public static void main(String[] args) {
        //declara instancia de la clase
        subrutinas ejecu = new subrutinas();
        
        //Uso de subrutinas
        ejecu.saludar();
        ejecu.saludar("jorgito");
        //suma(5, 3);
        JOptionPane.showMessageDialog(null,"La suma es " + ejecu.suma(5, 3));
        
<<<<<<< Updated upstream
        //invoca la subrutina de suma
=======
>>>>>>> Stashed changes
        int c = ejecu.suma(6, -2);
        JOptionPane.showMessageDialog(null,"La suma es " + c);        
                
    }//fin del main    
    
<<<<<<< Updated upstream
}//fin de la clase
=======
}//fin de la clase













>>>>>>> Stashed changes
