package com.vogella.javastarter.exercises;

public class Person {
    String name;
    String surname;
    int age;
    private Address location;

    public Person() {
        name = "John";
        surname = "Doe";
        age = 20;
    }
    public Person(String name, String surname, int age) {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public void setName(String name) {
        this.name = name;
    }
    public String getName() {
        return name;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }
    public String getSurname() {
        return surname;
    }

    public void setAge(int age) {
        this.age = age;
    }
    public int getAge() {
        return age;
    }
    public void setAddress(Address loc) {
        this.location = loc;
    }
    public Address getAddress() {
        return location;
    }

    @Override
    public String toString() {
        return name + " " + surname;
    }
}