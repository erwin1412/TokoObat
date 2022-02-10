
package quizpbono2;

import java.io.Serializable;

public class balokHalangan implements Serializable{
    private int ukuran,posx,posy;
    balokHalangan(int a, int b, int c){
        ukuran=a; 
        posx=b; 
        posy=c;
    }
    int getUkuran(){
        return ukuran;
    }     
    int getPosx(){
        return posx;
    }     
    int getPosy(){
        return posy;
    }
}
