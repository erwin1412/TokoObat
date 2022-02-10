/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week.pkg7;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInput;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author C204
 */
public class Week7 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArrayList<bangun> arr=new ArrayList<bangun>();
        arr.add(new segitiga(2, 4));
        arr.add(new kotak(3, 2));
        arr.add(new segitiga(5, 3));
        arr.add(new kotak(1, 3));
        for (bangun b : arr) {
            System.out.println("----------------");
            b.gambar();
            System.out.println(b.toString());
        }
        System.out.println();
        System.out.println("duplikat: ");
        try {
            //program uji coba(mungkin ada error)
            bangun hasil=(bangun) arr.get(arr.size()-1).clone();
            arr.add(hasil);
            arr.get(arr.size()-1).setAlas(3);
        } catch (CloneNotSupportedException ex) {
            Logger.getLogger(Week7.class.getName()).log(Level.SEVERE, null, ex);
            //kalau error muncul pesan, tidak langsung crash
        }
        Collections.sort(arr);
        for (bangun b : arr) {
            System.out.println("----------------");
            b.gambar();
            b.toString();
            System.out.println(b.toString());
        }
        try {
            //simpan ke file, jangan lupa pakai serialzable
            ObjectOutputStream oos=new ObjectOutputStream(new FileOutputStream("data.dat"));
            oos.writeObject(arr);
            oos.close();
        } catch (IOException ex) {
            System.out.println("gagal tulis file!!!");
        }
        System.out.println("proses baca file");
        ArrayList<bangun> arrLoad=new ArrayList<>();
        try {
            ObjectInputStream ois=new ObjectInputStream(new FileInputStream("data.dat"));
            arrLoad=(ArrayList<bangun>)ois.readObject();
            ois.close();
            for (int i = 0; i < arrLoad.size(); i++) {
                System.out.println(arrLoad.get(i));
            }
        } catch (IOException ex) {
            Logger.getLogger(Week7.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Week7.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
