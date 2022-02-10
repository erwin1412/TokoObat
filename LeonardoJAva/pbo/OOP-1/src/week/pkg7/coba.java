/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week.pkg7;

import java.util.Arrays;

/**
 *
 * @author C204
 */
public class coba {
    public static void main(String[] args) {
        String[] kata={"halo", "apa", "kabar"};
        System.out.println();
        Arrays.sort(kata);
        for (int i = 0; i < 3; i++) {
            System.out.println(kata[i]);
        }
        int arr[]={1, 5, 4, 2, 8, 6};
        Arrays.sort(arr);
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
