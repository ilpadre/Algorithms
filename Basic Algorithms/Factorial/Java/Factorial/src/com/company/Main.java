package com.company;

public class Main {

    public static void main(String[] args) {
        for (int i=0; i<=10; i++) {
            System.out.println("The factorial of " + i + " is " + Factorial(i));
        }

    }

    private static long Factorial(long n) {
        if (n > 0) {
            return n * Factorial(n-1);
        }
        return 1;
    }
}
