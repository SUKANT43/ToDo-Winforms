package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController//representation state transfer
public class HelloWorldController {

    @GetMapping("/h")
    public String sayHelloWorld() {
        return "Hello World!";
    }
}
//maven is a build tool is helps to run the multiple files in differnt formats so it helps to combine multiple files and give as a single runable file
/*
commands:
mvnw clean -->it used to clean the target folder
mvnw compile-->compile and gives the required files
mvnw clean compile-->clean and compile the code
mvnw test -->uses to test the testcase in the test folder
mvnw verify -->it gives the verification of the coden and gives the jar file as a single file
mvnw clean install-->this is for the whole process it compile, test and gives the jar file
 */
