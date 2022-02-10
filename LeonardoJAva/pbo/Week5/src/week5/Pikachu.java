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
public class Pikachu extends Pokemon{
    //int id; //default visibility package, bisa diakses oleh class2 apapun dalam package yang sama
    public Pikachu(String t) {
        super(t);
    }
    @Override
    public void battle() {
        hp-=20;
    }
}
