package com.example.demo;

import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/todo")
public class ToDoController {

    @GetMapping("/")
    String getTodo(){
        return "todo";
    }

    @GetMapping("/{id}")
    String getTodoById(@PathVariable int id){
        return "todo "+id;
    }

    @GetMapping("")
    String getTodoByParams(@RequestParam("todoid") long id){
        return "Param "+id;
    }

    @PostMapping("/create")
    String CreateUser(@RequestBody String body){
        return body;
    }


}
