/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package w7;

/**
 *
 * @author B204
 */
public class charmander extends pokemon{

    public charmander(String type) {
        super(type);
    }
    @Override
    public void battle(){
        hp-=20;
    }
}
