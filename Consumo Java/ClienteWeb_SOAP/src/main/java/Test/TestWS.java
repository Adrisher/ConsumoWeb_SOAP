package Test;

import ws.WSOperaciones;
import ws.WSOperaciones_Service;

public class TestWS {

    public static void main(String[] args) {

        WSOperaciones_Service servicio = new WSOperaciones_Service();
        WSOperaciones cliente = servicio.getWSOperacionesPort();

        //Loguearse
        if(cliente.loguin("Adrisher", "Aigz1752")){
            System.out.println("Credenciales correctas");
        }else{
            System.out.println("Credenciales incorrectas");
        }
            
        //Procesar pago
        if(cliente.procesarPago(5000, 50) != -1){
            System.out.println("Pago exitosamente realizado!!");
            System.out.println("Su vuelto es: "+cliente.procesarPago(5000, 50));
        }else{
            System.out.println("Saldo insuficiente");
        }
    }
}
