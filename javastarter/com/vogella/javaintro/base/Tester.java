package com.vogella.javaintro.base;

public class Tester {

    public static void main(String[] args) {
        System.out.println(MyStaticExample.stat);
        MyStaticExample.statMethod();
        MyExtentionClass ext = new MyExtentionClass();
        ext.hello();
    }
}