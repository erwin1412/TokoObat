/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quizpbono3;

import java.awt.Image;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author ASUS
 */
public class pacman implements Runnable{
    frame1 f1;
    JLabel imgNow;
    ImageIcon[][] img = new ImageIcon[4][2];
    boolean stop=false;
    int moveX,moveY;
    Random rnd = new Random();

    public pacman(frame1 f1) {
        this.f1=f1;
        img[0][0]=setGambar(new ImageIcon("Resources/atas1.png"));
        img[0][1]=setGambar(new ImageIcon("Resources/atas2.png"));
        img[1][0]=setGambar(new ImageIcon("Resources/bawah1.png"));
        img[1][1]=setGambar(new ImageIcon("Resources/bawah2.png"));
        img[2][0]=setGambar(new ImageIcon("Resources/kanan1.png"));
        img[2][1]=setGambar(new ImageIcon("Resources/kanan2.png"));
        img[3][0]=setGambar(new ImageIcon("Resources/kiri1.png"));
        img[3][1]=setGambar(new ImageIcon("Resources/kiri2.png"));
        imgNow= new JLabel(img[1][1]);
        this.imgNow.setBounds(500, 250, 50, 50);
        imgNow.setLocation(f1.getIconPlayer().getX(), f1.getIconPlayer().getY());
        moveX=0;
        moveY=0;
    }
    
    ImageIcon setGambar(ImageIcon raw){
        Image img = raw.getImage();
        Image newImg = img.getScaledInstance(50, 50, Image.SCALE_SMOOTH);
        ImageIcon finalImage= new ImageIcon(newImg);
        return finalImage;
    }
    
    @Override
    public void run() {
        int ctr=1;
        while( !stop ){
            try{
                if ( moveX==0 && moveY<0 ) {
                    this.imgNow.setIcon(img[0][ctr]);
                    imgNow.setLocation(imgNow.getX()+moveX,imgNow.getY()+moveY);
                    f1.changePicture(imgNow.getIcon(),imgNow.getX()+moveX,imgNow.getY()+moveY);
                }
                else if ( moveX==0 && moveY>0 ) {
                    this.imgNow.setIcon(img[1][ctr]);
                    imgNow.setLocation(imgNow.getX()+moveX,imgNow.getY()+moveY);
                    f1.changePicture(imgNow.getIcon(),imgNow.getX()+moveX,imgNow.getY()+moveY);
                }
                else if ( moveX>0 && moveY==0 ){
                    this.imgNow.setIcon(img[2][ctr]);
                    imgNow.setLocation(imgNow.getX()+moveX,imgNow.getY()+moveY);
                    f1.changePicture(imgNow.getIcon(),imgNow.getX()+moveX,imgNow.getY()+moveY);
                }
                else if ( moveX<0 && moveY==0 ){
                    this.imgNow.setIcon(img[3][ctr]);
                    imgNow.setLocation(imgNow.getX()+moveX,imgNow.getY()+moveY);
                    f1.changePicture(imgNow.getIcon(),imgNow.getX()+moveX,imgNow.getY()+moveY);
                }
                ctr--;
                if ( ctr==-1){
                    stop=true;
                }
                Thread.sleep(200);
            } catch (InterruptedException ex) {
                Logger.getLogger(pacman.class.getName()).log(Level.SEVERE, null, ex);
            } 
        }
        moveX=0;moveY=0;
        stop=false;
    }
    
}
