import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Main {
    public static void main(String[] args) {
//        Connection conn = DriverManager.getConnection("jdbc:sqlite:C:\\users\\moham\\Desktop\\moso\\Java\\testDB\\testjava.db");
        try {
            Connection conn = DriverManager.getConnection("jdbc:sqlite:C:\\Users\\moham\\Downloads\\Compressed\\music.db");
        } catch(SQLException){
            System.out.println("an error occured");}
    }
}
