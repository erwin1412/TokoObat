
package pbo;

import java.awt.Color;

public abstract class Bangun {
    protected int x,y,width,height;
    private Color warna;
    private char karakter;

    public Bangun(int x, int y, int width, int height, Color warna, char karakter) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.warna = warna;
        this.karakter = karakter;
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public Color getWarna() {
        return warna;
    }

    public void setWarna(Color warna) {
        this.warna = warna;
    }

    public char getKarakter() {
        return karakter;
    }

    public void setKarakter(char karakter) {
        this.karakter = karakter;
    }
    public abstract void gerak();
}
