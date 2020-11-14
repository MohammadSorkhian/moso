public class Dog extends Animal{
    private int eyes;
    private int legs;
    private int tail;
    public Dog(String name, int brain, int body, int size, int weight,int eyes, int legs, int tail){
        super(name, brain, body, size, weight);
        this.eyes = eyes;
        this.legs = legs;
        this.tail = tail;
    }
    @Override
    public void eat(){
        System.out.println("dog.eat()");
    }
}
