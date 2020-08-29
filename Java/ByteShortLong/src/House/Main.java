package House;

public class Main {
    public static void main(String[] args) {
    Wall wal1 = new Wall("west");
    Wall wal2 = new Wall("north");
    Wall wal3 = new Wall("east");
    Wall wal4 = new Wall("south");

    Ceiling ceiling = new Ceiling(12,55);
    Bed bed = new Bed("modern", 4,3,2,1);
    Lamp lamp = new Lamp("classic", false,75);
    BedRoom bedRoom = new BedRoom( wal1,wal2, wal3,wal4,ceiling,bed,lamp);
    bedRoom.makeBed();
    }
}
