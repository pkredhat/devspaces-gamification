package org.acme;

import io.quarkus.test.junit.QuarkusTest;
import org.junit.jupiter.api.Test;

import static io.restassured.RestAssured.given;
import static org.hamcrest.CoreMatchers.is;

import java.time.LocalDate;

@QuarkusTest
class DateResourceTest {
    @Test
    void testHelloEndpoint() {
        given()
          .when().get("/api/currentdate")
          .then()
             .statusCode(200)
             .body(is("Current Date=["+LocalDate.now()+"]"));
    }

}