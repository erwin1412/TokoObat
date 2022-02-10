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
//semua class di Java defaultnya adalah turunan dari class Object
public class Pokemon { //extends Object
    protected int id,hp;
    private static int counter;
    protected String type;
    
    public Pokemon(String type)
    {
        id=++counter;
        hp=100;
        //this.type mengakses property/attribute class ini sendiri
        this.type=type; 
    }
    public Pokemon() {
        //memanggil constructor dalam class ini sendiri
        this("unknown"); 
    } 
    @Override//penanda kalau method toString ini override method dari Object
    //memastikan tidak salah ketik/salah parameter
    public String toString() {
         return "Pokemon dengan id:"+id+" dan type:"+type+" hp:"+hp;
    }
    public void battle(){
        
    }
    public int getHp() {return hp;} 
    public void setHp(int hp) {this.hp=hp;}
}
