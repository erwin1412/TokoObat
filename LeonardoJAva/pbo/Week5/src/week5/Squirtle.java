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
public class Squirtle extends Pokemon{
    public Squirtle(String t)
    {
        super(t);
    }
    @Override
    public void battle() {
        hp-=10;
    }
    public void aquaJet() {
        hp-=45;
    }
}
