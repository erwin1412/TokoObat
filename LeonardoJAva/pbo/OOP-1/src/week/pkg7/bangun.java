/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week.pkg7;

import java.io.Serializable;

/**
 *
 * @author C204
 */
public abstract class bangun implements bisaGerak, Cloneable, Comparable, Serializable{
//abstract: class tidak pernah dibuat langsung
    protected int x, y, alas, tinggi;
    public bangun(int x, int y){
        this.x=x;
        this.y=y;
        alas=(int) (Math.random()*10+2);
        tinggi=(int) (Math.random()*10+2);
    }
    public abstract void gambar();
    //void belum punya bentuk, dipakai di anaknya
    //kalau ada void yang abstact, maka class harus abstract juga
    public void maju(){
        x+=5;
    }
    public void mundur(){
        x-=5;
    }
    

    public void setAlas(int alas) {
        this.alas = alas;
    }

    public abstract double getLuas();

    @Override
    public String toString() {
        return "bangun{" + "x=" + x + ", y=" + y + ", alas=" + alas + ", tinggi=" + tinggi + '}';
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone(); //To change body of generated methods, choose Tools | Templates.
    }
    //membandingkan diri sendiri dengan t
    @Override
    public int compareTo(Object t){
        bangun b=(bangun) t;
        //descending
        double selisih=(b.getLuas())-(getLuas());
        //ascending: 
        //double selisih=(getLuas())-(b.getLuas());
        return(int) selisih;
    }
    
}
