/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package w7;

import java.util.Objects;

/**
 *
 * @author B204
 */
public class pokemon { // extends Object (default)
    protected int id; // jika tidak di private makadpt diakses oleh class apapun dlm package yg sama
    private static int ctr=0;
    protected String type;
    int hp;

    public pokemon(String type) {
        hp=100;
        id=++ctr;
        this.type = type;
    }
    public pokemon() {
        this("unknown");//memanggil constructor dlm class yg sama
    }
    

    @Override//meng override method dr obj
    public String toString() {
        return "pokemon dengan " + "id=" + id + ", dan type=" + type +"hp : "+hp;
    }

    void battle() {
        
    }
}
