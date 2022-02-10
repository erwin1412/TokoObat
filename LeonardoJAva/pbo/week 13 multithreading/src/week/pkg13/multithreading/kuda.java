
package week.pkg13.multithreading;

import java.awt.Color;
import java.awt.Graphics2D;
import java.awt.Rectangle;
import java.awt.geom.Rectangle2D;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JProgressBar;

public class kuda implements Runnable{
    JProgressBar bar;
    jpanel canvas;
    int x,y;
    boolean stop=false;
    public kuda(JProgressBar pb , jpanel g2 , int x, int y){
        bar=pb;
        canvas=g2;
        this.x=x;
        this.y=y;
        pb.setBackground(Color.black);
        pb.setForeground(Color.yellow);
    }
    
    public void doStop(){
        stop=true;
    }
    
    public void draw(){
        Graphics2D g2= (Graphics2D) canvas.getGraphics();
        g2.setColor(Color.blue);
        g2.fill(new Rectangle2D.Double(x,y,20,20));
        //canvas.repaint();
    }
    
    public void hapus(){
        Graphics2D g2= (Graphics2D) canvas.getGraphics();
        g2.setColor(new Color(240,240,240));
        g2.fill(new Rectangle2D.Double(x,y,20,20));
    }
    
    @Override
    public void run() {
        Random r = new Random();
        while( !stop && bar.getValue()<bar.getMaximum()){
            try {
                int maju= r.nextInt(5);
                bar.setValue(bar.getValue()+maju);
                hapus();
                x+=maju;
                draw();
                Thread.sleep(100);
            } catch (InterruptedException ex) {
                Logger.getLogger(kuda.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
}
