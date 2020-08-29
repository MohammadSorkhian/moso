package Hamberger;

import java.util.SplittableRandom;

public class Main {
    public static void main(String[] args) {
    Hamburger hamburger = new Hamburger("basic","beef",3.56,"white");
    double price = hamburger.itemizeHamburger();
    hamburger.addHamburgerAddition1("tomato", 0.27);
    hamburger.addHamburgerAddition2("lettuce", 0.75);
    hamburger.addHamburgerAddition3("cheese",1.12);
    hamburger.itemizeHamburger();

    HealthyBurger healthyBurger = new HealthyBurger("Bacon",5.67);
    healthyBurger.addHealthyAddition1("egg",5.43);
    healthyBurger.itemizeHamburger();



    }
}
