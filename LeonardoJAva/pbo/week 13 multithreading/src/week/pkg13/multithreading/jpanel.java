
package week.pkg13.multithreading;

public class jpanel extends javax.swing.JPanel {

    public jpanel() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jProgressBar1 = new javax.swing.JProgressBar();
        jProgressBar2 = new javax.swing.JProgressBar();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();

        setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());
        add(jProgressBar1, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 80, 330, -1));
        add(jProgressBar2, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 120, 330, -1));

        jButton1.setText("Start");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 150, 90, 30));

        jButton2.setText("Stop");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 150, 80, 30));
    }// </editor-fold>//GEN-END:initComponents

    kuda kuda1;
    kuda kuda2;
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        
        MyThread mt = new MyThread();
        mt.start();
        
        kuda1 = new kuda(jProgressBar1,this,50,200);
        Thread t1 = new Thread(kuda1);
        t1.start();
        
        kuda2 = new kuda(jProgressBar2,this,50,250);
        Thread t2 = new Thread(kuda2);
        t2.start();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        kuda1.doStop();
        kuda2.doStop();
    }//GEN-LAST:event_jButton2ActionPerformed
    class MyThread extends Thread{
        
        @Override
        public void run() {
            System.out.println("Thread start..........");
            for (int i = 0; i < 100; i++) {
                System.out.println("i : "+i);
            }
        }
        
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JProgressBar jProgressBar1;
    private javax.swing.JProgressBar jProgressBar2;
    // End of variables declaration//GEN-END:variables
}
