/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quizpbono3;

import java.awt.Color;
import java.awt.Graphics2D;
import java.awt.geom.Rectangle2D;
import java.util.Random;

/**
 *
 * @author ASUS
 */
public class musuh {
    Graphics2D img;
    int x,y,w,h;
    Random rnd= new Random();
    public musuh() {
        w=20;
        h=20;
        Rectangle2D kotak = new Rectangle2D.Double(rnd.nextInt(),rnd.nextInt(),w,h);
    }
    
}
