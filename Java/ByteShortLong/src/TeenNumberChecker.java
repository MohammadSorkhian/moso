public class TeenNumberChecker {
    public static boolean hasTeen (int x, int y, int z){
        if ((x<=19 && x>=13) || (y<=19 && y>=13) || (z<=19 && z>=13))
            return true;
        else
            return false;
    }

    public static boolean isTeen (int num){
        if (num<=19 && num>=13)
            return true;
        else
            return false;
    }

}
