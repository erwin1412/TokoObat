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
public class Charmander extends Pokemon{
    public Charmander(String t)
    {
        super(t); //memanggil constructor induk
    }
    @Override
    public void battle() {
        hp-=5;
    }
    public void flameBurst() {
        hp-=50;
    }
}
