/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quizpbono3;

import java.awt.Image;
import java.util.ArrayList;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author ASUS
 */
public class frame1 extends javax.swing.JFrame {

    pacman player;
    ArrayList<musuh> enemy;
    public frame1() {
        initComponents();
        enemy=new ArrayList<>();
        player= new pacman(this);
        this.setSize(800, 600);
        iconPlayer.setText("");
        iconPlayer.setIcon(player.imgNow.getIcon());
        iconPlayer.setFocusable(true);
    }
    public void changePicture(Icon icon,int x,int y){
        iconPlayer.setIcon(icon);
        iconPlayer.setLocation(x, y);
    }

    public JLabel getIconPlayer() {
        return iconPlayer;
    }

    public void setIconPlayer(JLabel iconPlayer) {
        this.iconPlayer = iconPlayer;
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        iconPlayer = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        iconPlayer.setText("jLabel1");
        iconPlayer.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                iconPlayerKeyPressed(evt);
            }
        });
        getContentPane().add(iconPlayer, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 250, -1, -1));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void iconPlayerKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_iconPlayerKeyPressed
        int key=evt.getKeyCode();
        System.out.println(key);
        if ( key==87 && player.imgNow.getY()>=10){//atas
            player.moveY=-10;
            player.run();
        }
        else if ( key==87 && player.imgNow.getY()<10){
            player.moveY=-10;
            player.imgNow.setLocation(player.imgNow.getX(),450+player.moveY);
            player.run();
        }
        else if ( key==83 && player.imgNow.getY()<=450){//bawah
            player.moveY=10;
            player.run();
        }
        else if ( key==83 && player.imgNow.getY()>=450){//bawah
            player.moveY=10;
            player.imgNow.setLocation(player.imgNow.getX(),player.moveY);
            player.run();
        }
        else if ( key==65 && player.imgNow.getX()>=7){//kiri
            player.moveX=-10;
            player.run();
        }
        else if ( key==65 && player.imgNow.getX()<7){//kiri
            player.moveX=-10;
            player.imgNow.setLocation(700+player.moveX,player.imgNow.getY());
            player.run();
        }
        else if ( key==68 && player.imgNow.getX()<=700){//kanan
            player.moveX=10;
            player.run();
        }
        else if ( key==68 && player.imgNow.getX()>700){//kanan
            player.moveX=10;
            player.imgNow.setLocation(player.moveX,player.imgNow.getY());
            player.run();
        }
    }//GEN-LAST:event_iconPlayerKeyPressed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frame1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frame1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frame1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frame1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frame1().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel iconPlayer;
    // End of variables declaration//GEN-END:variables
}
