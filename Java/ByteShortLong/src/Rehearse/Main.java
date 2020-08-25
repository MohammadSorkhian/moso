package Rehearse;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        moso.VipPerson person1 = new moso.VipPerson();
        moso.VipPerson person2 = new moso.VipPerson("bob",2000, "moso@y.com");
        System.out.println(person1.getCreditLimit());
        System.out.println(person2.getCreditLimit());

      }
}

