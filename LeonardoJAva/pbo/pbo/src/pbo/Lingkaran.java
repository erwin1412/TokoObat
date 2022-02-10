/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pbo;

import java.awt.Color;

/**
 *
 * @author B201
 */
public class Lingkaran extends Bangun{

    public Lingkaran(int x, int y, int width, int height, Color warna, char karakter) {
        super(x, y, width, height, warna, karakter);
    }
    
    public void gerak(){
        y-=5;
    }
}
