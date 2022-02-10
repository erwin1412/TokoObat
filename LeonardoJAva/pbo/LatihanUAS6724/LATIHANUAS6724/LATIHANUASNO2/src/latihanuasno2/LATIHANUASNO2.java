/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanuasno2;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author asus_
 */
public class LATIHANUASNO2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArrayList<balokHalangan> blocks=new ArrayList<balokHalangan>();
        blocks.add(new balokHalangan(50, 100, 100));
        blocks.add(new balokHalangan(50, 20, 30));
        blocks.add(new balokHalangan(50, 150, 150));
        blocks.add(new balokHalangan(50, 300, 250));
        blocks.add(new balokHalangan(50, 200, 50));
        try {
            ObjectOutputStream fileout=new ObjectOutputStream(new FileOutputStream("halangan.txt"));
            fileout.writeObject(blocks);
            fileout.close();
            System.out.println("halangan created");
        } catch (IOException ex) {
            Logger.getLogger(LATIHANUASNO2.class.getName()).log(Level.SEVERE, null, ex);
        }
        frame f=new frame();
        f.setVisible(true);
    }
    
}
