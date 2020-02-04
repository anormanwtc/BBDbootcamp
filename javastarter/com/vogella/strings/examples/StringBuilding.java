
package com.vogella.strings.examples;

class StringBuilding {
    StringBuilder sb = new StringBuilder("Hello ");
    public void main(String[] args) {
        sb.append("Eclipse");
        String s = sb.toString();
        System.out.print(s);
    }
}

// String.valueOf('number')     converts numbers to strings
// Integer.parseInt(String)     converts strings to numbers
        // parseFloat
        // parseDouble

        