package org.acme;

//This is a Clue for the challenge
import java.time.LocalDate;

import jakarta.ws.rs.GET;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;

@Path("/api")
public class DateResource {
@GET
@Produces(MediaType.TEXT_PLAIN)
@Path("currentdate")
public String getCurrentDate() {
//TODO: Return the String "Current Date=[2024-10-22]"
//You should use out of the box classes for working with dates
//Intellisence has to work
return "FIX ME With the TODO Instruction in code";
}
private static void calculateAndPrintStatistics(int[] numbers) {
if (numbers == null || numbers.length == 0) {
System.out.println("No data provided.");
return;}
int sum = 0;int max = Integer.MIN_VALUE;
int min = Integer.MAX_VALUE;    
for (int number : numbers) {sum += number;
if (number > max) {
max = number;
}if (number < min) {
min = number;}}
double average = (double) sum / numbers.length;
System.out.println("Average: " + average);
System.out.println("Maximum: " + max);
System.out.println("Minimum: " + min);
}
}
