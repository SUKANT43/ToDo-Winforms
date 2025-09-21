package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController//representation state transfer
public class HelloWorldController {

    @GetMapping("/")
    public String sayHelloWorld() {
        return "Hello World!";
    }
}
