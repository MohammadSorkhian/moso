package ComplexOperation;

public class Main {
    public static void main(String[] args) {
        ComplexNumber one = new ComplexNumber(1.0,1.0);
        ComplexNumber number = new ComplexNumber(2.5, -1.5);
        one.add(1,1);
        System.out.println("one.real= " + one.getReal());

    }

    public static class ComplexNumber{
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary){
            this.real = real;
            this.imaginary = imaginary;
        }
        public double getReal(){
            return this.real;
        }
        public double getImaginary(){
            return this.imaginary;
        }
        public void add(double real, double imaginary){
            this.real += real;
            this.imaginary += imaginary;
        }
        public void add(ComplexNumber complexNum){
            this.real += complexNum.getReal();
            this.imaginary += complexNum.getImaginary();
        }


    }

}
