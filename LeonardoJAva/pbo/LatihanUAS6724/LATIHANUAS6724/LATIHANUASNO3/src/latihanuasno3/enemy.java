/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanuasno3;

import java.awt.Color;

/**
 *
 * @author asus_
 */
public class enemy extends java.lang.Thread{
    private int x, y, width, height;
    private Color warna;

    public enemy(int x, int y, int width, int height, Color warna) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.warna = warna;
    }

    public void setX(int x) {
        this.x = x;
    }

    public void setY(int y) {
        this.y = y;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public void setWarna(Color warna) {
        this.warna = warna;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public int getWidth() {
        return width;
    }

    public int getHeight() {
        return height;
    }

    public Color getWarna() {
        return warna;
    }
    
}
