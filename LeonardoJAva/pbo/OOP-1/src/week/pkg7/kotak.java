/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week.pkg7;

/**
 *
 * @author C204
 */
public class kotak extends bangun{

    public kotak(int x, int y) {
        super(x, y);
    }

    @Override
    public void gambar() {
        for (int i = 0; i < tinggi; i++) {
            for (int j = 0; j < alas; j++) {
                System.out.print("*");
            }
            System.out.println();
        }
    }
    @Override
    public double getLuas(){
        return alas*tinggi;
    }
    
}
