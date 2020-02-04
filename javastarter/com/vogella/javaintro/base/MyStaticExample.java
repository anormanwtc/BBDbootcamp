package com.vogella.javaintro.base;

public class MyStaticExample {

    public static String stat = "Globally accessable var";

    public static void statMethod() {
        System.out.println("Globally accessable method");
    }
}

/*
* If its not public then it cant be accessed outside of this file?
*/