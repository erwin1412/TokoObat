/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quizpbono2;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedWriter;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JOptionPane;

/**
 *
 * @author ASUS
 */

public class panel1 extends javax.swing.JPanel {
    
    public panel1() {
        initComponents();
        this.setBounds(0, 0, 500, 300);
        player.setBackground(Color.red);
        this.setSize(20, 20);
        setFocusable(true);
        player.setVisible(true);
        player.setFocusable(false);
        load.setFocusable(false);
    }
    
    public void createAndSave(ArrayList<balokHalangan> balok){
        balok.add(new balokHalangan(10, 20, 20));
        balok.add(new balokHalangan(10, 20, 40));
        balok.add(new balokHalangan(10, 20, 60));
        balok.add(new balokHalangan(10, 20, 80));
        balok.add(new balokHalangan(10, 20, 100));
        balok.add(new balokHalangan(10, 40, 20));
        balok.add(new balokHalangan(10, 60, 20));
        balok.add(new balokHalangan(10, 80, 20));
        balok.add(new balokHalangan(10, 100, 20));
        balok.add(new balokHalangan(10, 120, 20));
        try {
            FileOutputStream fout;
            fout = new FileOutputStream("halangan.txt");
            ObjectOutputStream out = new ObjectOutputStream(fout);
            out.writeObject(balok);
            out.close();
        } catch (FileNotFoundException ex) {
            Logger.getLogger(panel1.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(panel1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public void reload(){
        ArrayList<balokHalangan> balok=new ArrayList<>();
        createAndSave(balok);
        balok=null;
//            FileInputStream fin= new FileInputStream("halangan.txt");
//            ObjectInputStream ois= new ObjectInputStream(fin);
//            balok = (ArrayList<balokHalangan>)ois.readObject();
//            System.out.println("sukses");
        try {
            ObjectInputStream filein=new ObjectInputStream(new FileInputStream("halangan.txt"));
            balok=(ArrayList<balokHalangan>)filein.readObject();
            filein.close();
        } catch (IOException ex) {
            System.out.println("error");
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(panel1.class.getName()).log(Level.SEVERE, null, ex);
        }
        makeButoon(balok);
    }
    
    public void makeButoon(ArrayList<balokHalangan> balok){
        ArrayList<JButton> penghalang;
        penghalang= new ArrayList<JButton>();
        for (int a = 0; a < balok.size(); a++) {
            penghalang.add(new JButton());
            penghalang.get(a).setBounds(balok.get(a).getPosx(),balok.get(a).getPosy(),balok.get(a).getUkuran(),balok.get(a).getUkuran());
            penghalang.get(a).setForeground(Color.white);
            penghalang.get(a).setBackground(Color.blue);
            penghalang.get(a).setText(a+"");
            this.add(penghalang.get(a));
            this.repaint();
        }
        for (int a = 0; a < penghalang.size(); a++) {
            this.add(penghalang.get(a));
            this.repaint();
        }
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        player = new javax.swing.JButton();
        load = new javax.swing.JButton();

        setPreferredSize(new java.awt.Dimension(500, 300));
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });
        setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        player.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                playerActionPerformed(evt);
            }
        });
        player.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                playerKeyPressed(evt);
            }
        });
        add(player, new org.netbeans.lib.awtextra.AbsoluteConstraints(215, 259, 20, 20));

        load.setText("Load");
        load.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                loadActionPerformed(evt);
            }
        });
        load.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                loadKeyPressed(evt);
            }
        });
        add(load, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 10, -1, -1));
    }// </editor-fold>//GEN-END:initComponents

    private void playerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_playerActionPerformed
        
    }//GEN-LAST:event_playerActionPerformed

    private void playerKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_playerKeyPressed
        int key=evt.getKeyCode();
        System.out.println(key);
        if ( key==87 && player.getY()>=10){//atas
            player.setLocation(player.getX(), player.getY()-10);
        }
        else if ( key==83 && player.getY()<=270){//bawah
            player.setLocation(player.getX(), player.getY()+10);
        }
        else if ( key==65 && player.getX()>=7){//kiri
            player.setLocation(player.getX()-10, player.getY());
        }
        else if ( key==68 && player.getX()<460){//kanan
            player.setLocation(player.getX()+10, player.getY());
        }
    }//GEN-LAST:event_playerKeyPressed

    private void loadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_loadActionPerformed
        reload();
    }//GEN-LAST:event_loadActionPerformed

    private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
        
    }//GEN-LAST:event_formKeyPressed

    private void loadKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_loadKeyPressed
        
    }//GEN-LAST:event_loadKeyPressed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton load;
    private javax.swing.JButton player;
    // End of variables declaration//GEN-END:variables
}
