/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package w7;

import java.util.ArrayList;

/**
 *
 * @author B204
 */
public class game {
    ArrayList<pokemon> arr=new ArrayList<>();
    public game() {
        pokemon p=new pokemon();
        System.out.println(p);//saat p dicetak dia otomatis memanggil toString
        arr.add(new pikachu("electric"));
        arr.add(new charmander("fire"));
        arr.add(new squirtle("water"));
//        for (pokemon a : arr) {
//            System.out.println(a);
//        }
        for (pokemon a : arr) {
            pokemon pok = a;
            if ( pok instanceof pikachu){
                System.out.println("pikachu : "+pok);
            }
            if ( pok instanceof charmander){
                System.out.println("pikachu : "+pok);
            }
            if ( pok instanceof squirtle){
                System.out.println("pikachu : "+pok);
            }
            pok.battle();
            if ( pok instanceof squirtle){
                squirtle s = (squirtle)pok;
            }
        }
        for (pokemon a : arr) {
            System.out.println(a);
        }
        charmander c= (charmander)arr.get(1);
    }
}
