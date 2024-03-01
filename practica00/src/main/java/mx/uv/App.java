package mx.uv;

import static spark.Spark.*;
/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        System.out.println( "Hello World!" );

        get("/xml", (request, response) ->{
            response.type("application/xml");
            String respuesta = "<producto><nombre>Camisa</nombre><precio>50.00</precio></producto>";
            return respuesta;
        });
    }
}
