package Hamberger;

public class HealthyBurger extends Hamburger{
    private String healthyExtra1Name;
    private double healthExtra1Price;

    private String healthyExtra2Name;
    private double healthExtra2Price;

    public HealthyBurger(String meat, double price) {
        super("Healty", meat, price, "Brown");
    }

    public void addHealthyAddition1(String name, double price){
        this.healthyExtra1Name = name;
        this.healthExtra1Price = price;
    }
    public void addHealthyAddition2(String name, double price){
        this.healthyExtra2Name = name;
        this.healthExtra2Price = price;
    }

    @Override
    public double itemizeHamburger() {
        double hamburgerPrice = super.itemizeHamburger();
        if (healthyExtra1Name != null){
            hamburgerPrice += healthExtra1Price;
            System.out.println("added "+this.healthyExtra1Name+" for an extra "+this.healthExtra1Price);
        }
        if (healthyExtra2Name != null){
            hamburgerPrice += healthExtra2Price;
            System.out.println("added "+this.healthyExtra2Name+" for an extra "+this.healthExtra2Price);
        }
        return hamburgerPrice;
    }
}
