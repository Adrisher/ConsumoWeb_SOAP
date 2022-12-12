package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;


@WebService(serviceName = "WSOperaciones")
public class WSOperaciones {

    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }

   
    @WebMethod(operationName = "Loguin")
    public Boolean Loguin(@WebParam(name = "User") String user, @WebParam(name = "Password") String password) {
        
         
        if(user.equals("Adrisher") && password.equals("Aigz1752")){
            return true;
        }else{
            return false;
        }
    }

    
    @WebMethod(operationName = "ProcesarPago")
    public int ProcesarPago(@WebParam(name = "total") int total, @WebParam(name = "pago") int pago) {
        
        if(pago >= total){
            return pago - total;
        }else{
            return -1;
        }
    }
}
