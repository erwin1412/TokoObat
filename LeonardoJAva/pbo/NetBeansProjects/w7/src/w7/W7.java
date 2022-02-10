
package w7;


public class W7 {

//    public static void aging(pikachu temp){
//        temp.id=6;
//    }
    public static void main(String[] args) {
//        pikachu p = new pikachu();
//        p.id=15;
//        System.out.println(p.id);
//        // alamat memori objek pikachu
//        aging(p); // bila obj jd parameter maka jd pas by ref
//        System.out.println(p.id);
        int bil=5;
        ubah(bil);
        System.out.println(bil);
        String str="hallo";
        ubah(str);
        System.out.println(str);
        game g=new game();
        System.out.println(g.arr.get(0));
    }
    public static void ubah(int x){
        x=6;
    }
    public static void ubah(Integer x){//wrapper class
        x=6;
    }
    
    public static void ubah(String x){
        
    }
}
