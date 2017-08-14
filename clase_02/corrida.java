
import javax.swing.JOptionPane;

public class corrida {
    // Ejemplos varios para toma de decisiones y 
    // ciclos repetitivos
    public static void main(String[] args) {
        //Toma de decisiones
        //uso del if
        int n1 = Integer.
                    parseInt(JOptionPane.showInputDialog("Digite un valor entero"));
        int n2 = Integer.
                    parseInt(JOptionPane.showInputDialog("Digite un segundo valor entero"));
        
        //if sencillo
        if(n1==n2)
            JOptionPane.
                showMessageDialog(null, "Ambas variables son idénticas...!\n"+
                                         "tienen asignado el valor: "+n1);
        
//        //if sencillo con manejo de bloque
//        if(n1==n2){
//            JOptionPane.showMessageDialog(null, "Ambas variables son idénticas...!\n"+
//                                                "tienen asignado el valor: "+n1+"\n"+
//                                                "Procedo a cambiarlas");
//            n1 *= n2;
//            n2 -= n1;
//        }//fin del if
//        JOptionPane.showMessageDialog(null, "Ahora las variables tiene otros valores\n"+
//                                                "N1: "+ n1 + " y\nN2: "+n2);
//        
//        //if - else
//        if(n1==n2)
//            JOptionPane.showMessageDialog(null, "Ambas variables son idénticas...!\n"+
//                                                "tienen asignado el valor: "+n1);
//        else
//            JOptionPane.showMessageDialog(null, "Las variables son diferentes\n"+
//                                                "N1: "+ n1 + " y\nN2: "+n2);
//        
//        //if anidados
//        if(n1==n2){
//            JOptionPane.showMessageDialog(null, "Ambas variables son idénticas...!");
//        }else if(n1 > n2){
//            JOptionPane.showMessageDialog(null, "N1: "+ n1 + " es mayor que N2: "+n2);
//        }else if(n1 < n2){
//            JOptionPane.showMessageDialog(null, "N1: "+ n1 + " es menor que N2: "+n2);
//        }else{
//            JOptionPane.showMessageDialog(null, "No puede definir el tipo de igualdad");
//        }
//        
        //comparando texto
//        String exp1 = JOptionPane.showInputDialog("Digite un texto");
//        String exp2 = JOptionPane.showInputDialog("Digite un segundo texto");
//        
//        exp1 = exp1.toLowerCase();
//        exp2 = exp2.toUpperCase();
//        
//        if(exp1.compareTo(exp2)==0)
//            JOptionPane.
//                    showMessageDialog(null, "No puede definir el tipo de igualdad");
//        else if(exp1.compareTo(exp2)<0)
//            JOptionPane.
//                    showMessageDialog(null, "Exp1 se coloca antes que Exp2");
//        else if(exp1.compareTo(exp2)>0)
//            JOptionPane.
//                    showMessageDialog(null, "Exp1 se coloca después de Exp2");
//        
        
//        //comparando texto
//        String exp1 = JOptionPane.showInputDialog("Digite un texto");
//        String exp2 = JOptionPane.showInputDialog("Digite un segundo texto");
//        
//               
//        if(exp1.compareToIgnoreCase(exp2)==0)
//            JOptionPane.
//                    showMessageDialog(null, "No puede definir el tipo de igualdad");
//        else if(exp1.compareToIgnoreCase(exp2)<0)
//            JOptionPane.
//                    showMessageDialog(null, "Exp1 se coloca antes que Exp2");
//        else if(exp1.compareToIgnoreCase(exp2)>0)
//            JOptionPane.
//                    showMessageDialog(null, "Exp1 se coloca después de Exp2");
//        
        //uso del switch "Case"
//        byte opc = Byte.parseByte(JOptionPane.showInputDialog("1. Opción 1\n"+
//                                                              "2. Opción 2\n"+
//                                                              "3. Opción 3\n\n"+
//                                                              "Elija un alternativa"));
//        switch(opc){
//            case 1:
//                JOptionPane.showMessageDialog(null, "Opción 1 seleccionada...!");
//                break;
//            case 2:
//                JOptionPane.showMessageDialog(null, "Opción 2 seleccionada...!");
//                break;    
//            case 3:
//                JOptionPane.showMessageDialog(null, "Opción 3 seleccionada...!");
//                break;    
//            default:
//                JOptionPane.showMessageDialog(null, "Opción seleccionada NO EXISTE.");
//        }//fin del switch
//        
        
        
        
        //Ciclos repetitivos
        //uso del for
        for(int i = 1; i <= 10; i++){
            System.out.println("i => [" + i + "]");
        }
        System.out.println("/*----------------*/");
        
        
        
        
    }    
}







