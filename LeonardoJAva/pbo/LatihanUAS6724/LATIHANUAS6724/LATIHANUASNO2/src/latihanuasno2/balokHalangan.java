/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanuasno2;

import java.io.Serializable;

/**
 *
 * @author asus_
 */
public class balokHalangan implements Serializable{
    private int ukuran,posx,posy;
    balokHalangan(int a, int b, int c)
    {ukuran=a; posx=b; posy=c;}
    int getUkuran()
    {return ukuran;}
    int getPosx()
    {return posx;}
    int getPosy()
    {return posy;}
    
}
