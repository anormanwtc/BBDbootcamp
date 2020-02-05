// package com.vogella.javastarter.exercises;   //This works with java Main.java

import com.vogella.javastarter.exercises.*;     //this works with java Main

public class Main {
    public static void main(String[] args) {
        Person guy = new Person();
        Person gal = new Person("Jo", "Deer", 22);
        Address loc = new Address();
        System.out.println(guy.toString());
        System.out.println(gal.toString());
        loc.setCity("CapeTown");
        loc.setNumber("69");
        loc.setCountry("SA");

        guy.setAddress(loc);
        System.out.println(guy.getAddress().toString());
    }
}