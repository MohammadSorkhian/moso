package academy.learnprogramming;

public class Main {

    public static void main(String[] args) {
        int myValue = 10_000;
        System.out.println(myValue);
        int max = Integer.MAX_VALUE;
        int min = Integer.MIN_VALUE;
        System.out.println(max);
        System.out.println(min);
        byte byteMax = Byte.MAX_VALUE;
        byte byteMin = Byte.MIN_VALUE;
        System.out.println(byteMax);
        System.out.println(byteMin);

        long longMax = Long.MAX_VALUE;
        System.out.println(longMax);
        long x = 100L;
        int y = (int) (x);

        float folatMax = Float.MAX_VALUE;
        System.out.println(folatMax);
        double weightLb = 230d; //Pound
        double weightKG = weightLb * 0.453592d; //KG
        System.out.println(weightKG);
        char myChar = 'M';
        char copyRight = '\u00A9';
        System.out.println(copyRight);
        boolean booleanValue = true;
        boolean booleanFalse = false;
        String myString = "hi";

        int myScore = 88;
        String pass = myScore > 90 ? "Very Good" : "Good";
        System.out.println(pass);

        if (myScore < 100 && myScore > 90) {
            System.out.println("the result =" + "True");
        } else {
            System.out.println("oh! sorry");
        }
    }
}
