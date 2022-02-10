/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg1;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author asus_
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner scanInt=new Scanner(System.in);
        Scanner scanStr=new Scanner(System.in);
        ArrayList<rekening> listR=new ArrayList<rekening>();
        int menu;
        int noRek, jumlah;
        String nama, jenisR;
        do{
            System.out.println("1. buat rekening");
            System.out.println("2. setor tunai");
            System.out.println("3. tarik tunai");
            System.out.println("4. detail rekening");
            System.out.println("5. history rekening");
            System.out.println("menu: ");
            menu=scanInt.nextInt();
            if(menu==1){
                System.out.println("jenis rekening: ");
                System.out.println("silver: s");
                System.out.println("gold: g");
                System.out.println("platinum: p");
                System.out.print("nama pemilik: ");
                nama=scanStr.nextLine();
                System.out.print("jenis rekening: ");
                jenisR=scanStr.nextLine();
                if("s".equals(jenisR)){
                    listR.add(new silver(nama));
                    System.out.println("dibuat rekening baru silver bernomor rekening: "+listR.get(listR.size()-1).getNoRek());
                }
                else if("g".equals(jenisR)){
                    listR.add(new gold(nama));
                    System.out.println("dibuat rekening baru gold bernomor rekening: "+listR.get(listR.size()-1).getNoRek());
                }
                else if("p".equals(jenisR)){
                    listR.add(new platinum(nama));
                    System.out.println("dibuat rekening baru platinum bernomor rekening: "+listR.get(listR.size()-1).getNoRek());
                }
            }
            else if(menu==2){
                System.out.println("no rekening: ");
                noRek=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        System.out.println("nama: "+listR.get(i).getNamaPemilik());
                        System.out.println("jenis: "+listR.get(i).getJenisRek());
                        System.out.println("saldo: "+listR.get(i).getSaldo());
                        System.out.print("sisa limit transaksi: ");
                        System.out.println(listR.get(i).getLimTran()-listR.get(i).getTotalTran());
                    }
                }
                System.out.println("jumlah setor: ");
                jumlah=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        if(jumlah<listR.get(i).getLimTran()&&
                            listR.get(i).getTotalTran()<listR.get(i).getLimTran()){
                            listR.get(i).setor(jumlah);
                            System.out.println("setoran sukses");
                            if(listR.get(i).isLihatHistory()==true){
                                listR.get(i).getHistory().add("setoran - "+jumlah);
                            }
                        }
                        else if(listR.get(i).getTotalTran()>listR.get(i).getLimTran()||
                                jumlah>listR.get(i).getLimTran()){
                            System.out.println("limit transaksi sudah tercapai");
                        }
                    }
                }
            }
            else if(menu==3){
                System.out.println("no rekening: ");
                noRek=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        System.out.println("nama: "+listR.get(i).getNamaPemilik());
                        System.out.println("jenis: "+listR.get(i).getJenisRek());
                        System.out.println("saldo: "+listR.get(i).getSaldo());
                        System.out.print("sisa limit transaksi: ");
                        System.out.println(listR.get(i).getLimTran()-listR.get(i).getTotalTran());
                    }
                }
                System.out.println("jumlah tarikan: ");
                jumlah=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        if(jumlah<listR.get(i).getSaldo()&&
                            listR.get(i).getTotalTran()<listR.get(i).getLimTran()){
                            listR.get(i).tarik(jumlah);
                            System.out.println("tarik tunai sukses");
                            if(listR.get(i).isLihatHistory()==true){
                                listR.get(i).getHistory().add("tarikan - "+jumlah);
                            }
                        }
                        else if(jumlah>listR.get(i).getSaldo()||
                                listR.get(i).getTotalTran()>listR.get(i).getLimTran()){
                            System.out.println("limit transaksi sudah tercapai");
                        }
                    }
                }
            }
            else if(menu==4){
                System.out.println("input no rekening: ");
                noRek=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        System.out.println("nama: "+listR.get(i).getNamaPemilik());
                        System.out.println("saldo: "+listR.get(i).getSaldo());
                        System.out.println("jenis rekening: "+listR.get(i).getJenisRek());
                        System.out.print("sisa limit transaksi: ");
                        System.out.println(listR.get(i).getLimTran()-listR.get(i).getTotalTran());
                    }
                }
            }
            else if(menu==5){
                System.out.println("input no rekening: ");
                noRek=scanInt.nextInt();
                for (int i = 0; i < listR.size(); i++) {
                    if(noRek==listR.get(i).getNoRek()){
                        if(listR.get(i).isLihatHistory()==true){
                            for (int j = 0; j < listR.get(i).getHistory().size(); j++) {
                                System.out.println(listR.get(i).getHistory().get(j));
                            }
                        }
                        else if(listR.get(i).isLihatHistory()==false){
                            System.out.println("rekening tidak bisa akses history (jenis rekening silver)");
                        }
                    }
                }
            }
        }while(menu!=0);
    }
    
}
