/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week8;

import java.io.Serializable;

/**
 *
 * @author master
 */
public class Barang implements Serializable,
        Comparable{
    private int id,harga,jumlah;
    private String nama;
    private static int counter; //autogenerate id    
    private static int modeSort=1;//1:nama,2:harga,3:jumlah
    public Barang(int harga, int jumlah, String nama) {
        id=++counter;
        this.harga = harga;
        this.jumlah = jumlah;
        this.nama = nama;
    }

    public static int getModeSort() {
        return modeSort;
    }

    public static void setModeSort(int modeSort) {
        Barang.modeSort = modeSort;
    }
    
    @Override
    public String toString() {
        return "Barang{" + "id=" + id +
                ", harga=" + harga + 
                ", jumlah=" + jumlah + ", "
                + "nama=" + nama + '}';
    }   
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public int getHarga() {
        return harga;
    }
    public void setHarga(int harga) {
        this.harga = harga;
    }
    public int getJumlah() {
        return jumlah;
    }
    public void setJumlah(int jumlah) {
        this.jumlah = jumlah;
    }
    public String getNama() {
        return nama;
    }
    public void setNama(String nama) {
        this.nama = nama;
    }
    public static int getCounter() {
        return counter;
    }
    public static void setCounter(int counter) {
        Barang.counter = counter;
    }   

    @Override
    public int compareTo(Object t) {
        Barang baranglain = (Barang)t;
        if (modeSort==1)
            return nama.compareTo(baranglain.nama);
        else if (modeSort==2)
            return harga-baranglain.harga;
        else //default sorting by jumlah
            return jumlah-baranglain.jumlah;
    }
}
