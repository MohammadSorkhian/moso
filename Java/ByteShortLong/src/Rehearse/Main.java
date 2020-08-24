package Rehearse;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
//        String num = "2020";
//        int num2 = Integer.parseInt(num);
//        System.out.println(num2);

        Scanner scanner = new Scanner(System.in);

        System.out.println("Please enter your year of birth : ");
        boolean hasNextInt = scanner.hasNextInt();
        while (!hasNextInt){
            System.out.println("Sorry the entered value is incorrect " +
                    "Please enter your year of birth : ");
            scanner.nextLine();
            hasNextInt = scanner.hasNextInt();
        }
        int yearOfBirth = scanner.nextInt();



        scanner.nextLine();

        System.out.println("Please enter your name : ");
        String name = scanner.nextLine();

        int age = 2020 - yearOfBirth;

        scanner.close();

        System.out.println(name + "'s age is " + age);






    }
}
