
package week.pkg6;

import java.io.Serializable;

public class barang implements Serializable,Comparable{
    private int id,harga,jumlah;
    private String nama;
    private static int counter;
    private static int modeSort=1;//1 : nama , 2 : harga , 3 : jumlah

    public barang(int harga, int jumlah, String nama) {
        this.harga = harga;
        this.jumlah = jumlah;
        this.nama = nama;
        id=++counter;
    }

    @Override
    public int compareTo(Object t) {
        barang b=(barang)t;
        if ( modeSort==1 )
            return nama.compareTo(b.nama);
        else if ( modeSort==2 )
            return harga-b.harga;
        return jumlah-b.jumlah;
    }

    public static int getModeSort() {
        return modeSort;
    }

    public static void setModeSort(int modeSort) {
        barang.modeSort = modeSort;
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
        barang.counter = counter;
    }

    @Override
    public String toString() {
        return "barang{" + "id=" + id + ", harga=" + harga + ", jumlah=" + jumlah + ", nama=" + nama + '}';
    }
    
}
