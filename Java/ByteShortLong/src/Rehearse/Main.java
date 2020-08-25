package Rehearse;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
//        String num = "2020";
//        int num2 = Integer.parseInt(num);
//        System.out.println(num2);

//        Scanner scanner = new Scanner(System.in);
//
//        System.out.println("Please enter your year of birth : ");
//        boolean hasNextInt = scanner.hasNextInt();
//        while (!hasNextInt){
//            System.out.println("Sorry the entered value is incorrect " +
//                    "Please enter your year of birth : ");
//            scanner.nextLine();
//            hasNextInt = scanner.hasNextInt();
//        }
//        int yearOfBirth = scanner.nextInt();
//
//
//
//        scanner.nextLine();
//
//        System.out.println("Please enter your name : ");
//        String name = scanner.nextLine();
//
//        int age = 2020 - yearOfBirth;
//
//        scanner.close();
//
//        System.out.println(name + "'s age is " + age);

//        System.out.println("Enter your nums");
//        Scanner scanner = new Scanner(System.in);
//        double sum = 0;
//
//        while(true){
//            boolean isNum = scanner.hasNextInt();
//            if (isNum){
//                sum += scanner.nextInt();
//                scanner.nextLine();
//            }else{
//                System.out.println(sum);
//                break;
//            }
//
//        }
//        scanner.close();

        class SimpleCalculator {
            private double firstNumber;
            private double secondNumber;

            public void setFirstNumber(double firstNumber){
                this.firstNumber = firstNumber;
            }
            public void setSecondNumber(double secondNumber) {
                this.secondNumber = secondNumber;
            }
            public double getFirstNumber(){
                return this.firstNumber;
            }
            public double getSecondNumber() {
                return this.secondNumber;
            }
            public double getAdditionResult(){
                return (firstNumber+secondNumber);
            }
        }

        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.0);
        calculator.setSecondNumber(4);
        System.out.println(calculator.getAdditionResult());
    }
}
