/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week5;

import java.util.ArrayList;

/**
 *
 * @author master
 */

public class Game {
    //Polymorphism
    ArrayList<Pokemon> arr=new ArrayList<Pokemon>();
    public Game() {
        //Pokemon p=new Pokemon();
        //saat p dicetak sebagai String, otomatis memanggil toString kalau ada
        //System.out.println(p);
        arr.add(new Pikachu("Electric"));
        arr.add(new Charmander("Fire"));
        arr.add(new Squirtle("Water"));
        //for(Pokemon p:arr)
        for(int i=0;i<arr.size();i++)
        {
            Pokemon p = arr.get(i);
            if (p instanceof Pikachu) { //untuk tahu wujud aslinya
                System.out.println("Pikachu: " + p);
            }
            if (p instanceof Charmander) {
                System.out.println("Charmander: " + p);
            }
            if (p instanceof Squirtle) {
                System.out.println("Squirtle: " + p);
            }
            p.battle(); //hp otomatis berkurang sesuai object aslinya
            if (p instanceof Squirtle) { //pastikan kalau memang Squirtle
                Squirtle s = (Squirtle)p; //casting dari Pokemon ke bentuk asalnya
                s.aquaJet();
            }
        }
        for(Pokemon p:arr) 
        {
            System.out.println(p);
        }
        //andaikan Charmander evolve jadi Squirtle
        Charmander c = (Charmander)arr.get(1); 
        Squirtle s = new Squirtle("Water");
        s.setHp(c.getHp());
        arr.set(1, s);
        for(Pokemon p:arr) 
        {
            System.out.println(p);
        }        
    }
}
