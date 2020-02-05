package com.vogella.javainterface; 

import com.vogella.javainterface.MyInterface;

public class MyInterfaceImpl implements MyInterface {
    @Override
    public void test() {
        System.out.println("test");
    }
    @Override
    public void write(String s) {
        System.out.println(s);
    }

    public static void main(String[] args) {
        MyInterfaceImpl impl = new MyInterfaceImpl();
        System.out.println(impl.reverseString("Lars is pink now"));
    }
}