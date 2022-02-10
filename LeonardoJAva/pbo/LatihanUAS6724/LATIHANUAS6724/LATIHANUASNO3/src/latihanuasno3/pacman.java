/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanuasno3;

import java.awt.Image;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author asus_
 */
public class pacman extends java.lang.Thread{
    private ImageIcon[][] gambar=new ImageIcon[4][2];
    private JLabel labelP;
    private static int arah;
    animasi animate;
    ArrayList<enemy> e=new ArrayList<>();

    public void setE(ArrayList<enemy> e) {
        this.e = e;
    }

    public ArrayList<enemy> getE() {
        return e;
    }

    public void setGambar(ImageIcon[][] gambar) {
        this.gambar = gambar;
    }

    public void setLabelP(JLabel labelP) {
        this.labelP = labelP;
    }

    public void setArah(int arah) {
        this.arah = arah;
    }

    public void setAnimate(animasi animate) {
        this.animate = animate;
    }

    public int getArah() {
        return arah;
    }

    public animasi getAnimate() {
        return animate;
    }

    public ImageIcon[][] getGambar() {
        return gambar;
    }

    public JLabel getLabelP() {
        return labelP;
    }
    public pacman(){
        gambar[0][0] = setGambar(new ImageIcon("images/atas1.png"));
        gambar[0][1] = setGambar(new ImageIcon("images/atas2.png"));
        
        gambar[2][0] = setGambar(new ImageIcon("images/bawah1.png"));
        gambar[2][1] = setGambar(new ImageIcon("images/bawah2.png"));
        
        gambar[1][0] = setGambar(new ImageIcon("images/kiri1.png"));
        gambar[1][1] = setGambar(new ImageIcon("images/kiri2.png"));
        
        gambar[3][0] = setGambar(new ImageIcon("images/kanan1.png"));
        gambar[3][1] = setGambar(new ImageIcon("images/kanan2.png"));
        this.labelP=new JLabel(this.gambar[3][0]);
        this.labelP.setBounds(0, 0, 50, 50);
    }
    ImageIcon setGambar(ImageIcon raw){
        Image img = raw.getImage();
        Image newImg = img.getScaledInstance(50, 50, Image.SCALE_SMOOTH);
        ImageIcon finalImage= new ImageIcon(newImg);
        return finalImage;
    }

    @Override
    public void run() {
        while(true){
            animate=new animasi(labelP, gambar, arah);
            animate.start();
            
            try {
                Thread.sleep(500);
            } catch (InterruptedException ex) {
                Logger.getLogger(pacman.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
       
    }
    
}
