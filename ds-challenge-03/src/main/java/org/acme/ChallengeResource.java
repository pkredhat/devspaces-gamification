package org.acme;

import java.nio.file.Files;

import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;

@Path("/api")
public class ChallengeResource {

    @Path("greet/{name}")
    @GET
    @Produces(MediaType.TEXT_PLAIN)
    public String greetUser(String name) {
     String user = name;
     return "Hello "+user+"\n";
    }    

    // Sample Hello Method
    @Path("hello")
    @GET
    @Produces(MediaType.TEXT_PLAIN)
    public String greet() {
        return "Hello Challenge Attendees";
    }    

}