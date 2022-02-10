/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanuasno3;

import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author asus_
 */
public class animasi extends java.lang.Thread{
    JLabel lblUnit;
    private ImageIcon[][] gambar = new ImageIcon[4][3];
    private int ctrGerak;
    private static int arah;
    public animasi(JLabel lblUnit, ImageIcon[][] gambar, int arah)
    {
        this.ctrGerak=0;
        this.lblUnit = lblUnit;
        this.gambar = gambar;
        this.arah=arah;
    }
    public void setLokasi(int arah){
        if(arah==0){
            lblUnit.setLocation(lblUnit.getX(), lblUnit.getY()-5);
        }
        else if(arah==1){
            lblUnit.setLocation(lblUnit.getX()-5, lblUnit.getY());
        }
        else if(arah==2){
            lblUnit.setLocation(lblUnit.getX(), lblUnit.getY()+5);
        }
        else if(arah==3){
            lblUnit.setLocation(lblUnit.getX()+5, lblUnit.getY());
        }
        
        if(lblUnit.getY()<=-5){
            lblUnit.setLocation(lblUnit.getX(), 600);
        }
        else if(lblUnit.getX()<=-5){
            lblUnit.setLocation(800, lblUnit.getY());
        }
        else if(lblUnit.getX()>=800){
            lblUnit.setLocation(0, lblUnit.getY());
        }
        else if(lblUnit.getY()>=600){
            lblUnit.setLocation(lblUnit.getX(), 0);
        }
        
    }

    @Override
    public void run() {
        while(ctrGerak<10){
            ctrGerak++;
            if(ctrGerak%2==0){
                lblUnit.setIcon(gambar[arah][0]);
            }
            else if(ctrGerak%2==1){
                lblUnit.setIcon(gambar[arah][1]);
            }
            setLokasi(arah);
            try {
                Thread.sleep(100);
            } catch (InterruptedException ex) {
                Logger.getLogger(animasi.class.getName()).log(Level.SEVERE, null, ex);
            }
            
        }
    }
    
}
