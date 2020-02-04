package com.vogella.javaintro.base;

class MyBaseClass {
    public void hello() {
        System.out.println("Hello from MyBaseClass");
    }
}

abstract class MyAbstract { //cant be instantiated, only used for subclasses?
    abstract double returnDouble(); //defined without implementation -> abstract
                                    //the sub class will have to define implementation
}