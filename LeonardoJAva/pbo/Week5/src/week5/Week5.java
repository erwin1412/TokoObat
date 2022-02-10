/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week5;

/**
 *
 * @author master
 */
public class Week5 {
    public static void aging(Pikachu temp)
    {
        temp.id=6;
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        /*
        Pikachu p=new Pikachu();
        p.id=5;
        System.out.println(p.id); //p adalah reference/alamat memori dari objek Pikachu
        aging(p); //bila objek yg kita create dari class dijadikan parameter, maka sifatnya pass by reference
        System.out.println(p.id); 
        */
        int bilangan=5;
        ubah(bilangan); 
        System.out.println(bilangan); //bilangan tetap, karena tipe data primitif pass by value
        
        Integer bil=5;
        ubah(bil); //pass by value
        System.out.println(bil);
        
        String str="hallo";
        ubah(str); //pass by value
        System.out.println(str);
        
        Game g=new Game();        
    }
    public static void ubah(int x)
    {
        x=6;
    }
    public static void ubah(Integer x) //wrapper class, class2 untuk tipe data primitif
    {
        x=6;
    }
    public static void ubah(String str) //wrapper class, class2 untuk tipe data primitif
    {
        str="bye";
    }
    
}
