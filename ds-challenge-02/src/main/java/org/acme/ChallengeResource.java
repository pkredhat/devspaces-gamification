package org.acme;

import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;

@Path("/api")
public class ChallengeResource {

//TO DO :: Write the challenge-02 method
/** 
public String greetUser() {
 String user;
 return "Hello "+user;
}
*/

//Sample Hello Method
@Path("hello")
@GET
@Produces(MediaType.TEXT_PLAIN)
public String greet() {
    return "Hello Challenge Attendees";
}

}