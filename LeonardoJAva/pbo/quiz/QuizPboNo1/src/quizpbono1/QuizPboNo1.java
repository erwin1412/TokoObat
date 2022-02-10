
package quizpbono1;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class QuizPboNo1 {

    public static void main(String[] args) {
        ArrayList<rekening> r = new ArrayList<rekening>();
        r.add(new rekening("S",25000000,false));
        r.add(new rekening("G",50000000,true));
        r.add(new rekening("P",100000000,true));
        ArrayList<customer> c = new ArrayList<>();
        menu(r, c);
    }
    
    public static void menu(ArrayList<rekening> r,ArrayList<customer> c){
        Scanner scanInt = new Scanner(System.in);
        Scanner scanStr = new Scanner(System.in);
        Random rnd= new Random();
        System.out.print("====MENU====\n1. Buat Rekening\n2. Setor Tunai\n3. Tarik Tunai\n4. Informasi Rekening"
                + "\n5. Lihat History Transaksi\n0. Exit\nPilih Menu : ");
        int pilihMenu=scanInt.nextInt();
        if ( pilihMenu==1 ){
            System.out.print("Input Nama : ");
            String nama=scanStr.nextLine();
            String s="";
            do{
                System.out.println("input harus (S/G/P)(Upper case)");
                System.out.print("Jenis Rekening : ");s=scanStr.nextLine();
            }while(!s.equals("S") && !s.equals("G") && !s.equals("P"));
            int rek=rnd.nextInt(90000)+10000;
            c.add(new customer(nama,s,rek));
            System.out.println("Rekening berhasil didaftarkan\nNomor rekening anda : "+rek);
        }
        else if ( pilihMenu==2 || pilihMenu==3 ){
            System.out.print("no rekening : ");
            int noRekTujuan=scanInt.nextInt();
            int ctr=-1;
            for (int a = 0; a < c.size(); a++) {
                if ( c.get(a).getNoRekening()==noRekTujuan){
                    ctr=a;
                }
            }
            if ( ctr>=0){
                String batas=c.get(ctr).getJenisRekening();
                int nominalBatas=0;
                if ( batas.equalsIgnoreCase("s")){
                    nominalBatas=25000000;
                }
                else if ( batas.equalsIgnoreCase("g")){
                    nominalBatas=50000000;
                }
                else if ( batas.equalsIgnoreCase("p")){
                    nominalBatas=100000000;
                }
                
                int uang=0;
                System.out.print("jumlah uang : ");
                uang=scanInt.nextInt();
                if ( uang>=0 && uang<=nominalBatas && pilihMenu==2){
                    System.out.println("Setor Tunai Sukses");
                    c.get(ctr).tambahSaldo(uang);
                    c.get(ctr).penguranganLimit(uang);
                    c.get(ctr).tambahHistori("Setoran Tunai - "+uang);
                }
                else if (  uang>=0 && uang<=nominalBatas && pilihMenu==3 && c.get(ctr).getSaldo()>=uang){
                    System.out.println("Tarik Tunai Sukses");
                    c.get(ctr).penguranganSaldo(uang);
                    c.get(ctr).penguranganLimit(uang);
                    c.get(ctr).tambahHistori("Tarik Tunai - "+uang);
                }
                else{
                    if ( pilihMenu==2 )System.out.println("Setor Tunai gagal");
                    else if (pilihMenu==3)System.out.println("Tarik Tunai gagal");
                }
            }
            else System.out.println("no rekening tidak ada");
        }
        else if ( pilihMenu==4 ){
            System.out.print("no rekening : ");
            int noRekTujuan=scanInt.nextInt();
            int ctr=-1;
            for (int a = 0; a < c.size(); a++) {
                if ( c.get(a).getNoRekening()==noRekTujuan){
                    ctr=a;
                }
            }
            if ( ctr>=0){
                String jenis="";
                if ( c.get(ctr).getJenisRekening().equalsIgnoreCase("s")){
                    jenis="Silver";
                }
                else if ( c.get(ctr).getJenisRekening().equalsIgnoreCase("g")){
                    jenis="Gold";
                }
                else if ( c.get(ctr).getJenisRekening().equalsIgnoreCase("p")){
                    jenis="Platinum";
                }
                System.out.println("Nama            : "+c.get(ctr).getNama());
                System.out.println("Jumlah Saldo    : "+c.get(ctr).getSaldo());
                System.out.println("Jenis Rekening  : "+jenis);
                System.out.println("Sisa Limit      : "+c.get(ctr).getSisaLimit());
            }
            else System.out.println("no rekening tidak ditemukan");
        }
        else if ( pilihMenu==5){
            System.out.print("no rekening : ");
            int noRekTujuan=scanInt.nextInt();
            int ctr=-1;
            for (int a = 0; a < c.size(); a++) {
                if ( c.get(a).getNoRekening()==noRekTujuan){
                    ctr=a;
                }
            }
            if ( ctr>=0 ){
                String jenis=c.get(ctr).getJenisRekening();
                if ( jenis.equalsIgnoreCase("s")){
                    System.out.println("Jenis Nomor Rekening ini tidak dapat menggunakan fitur ini");
                }
                else{
                    c.get(ctr).cetakHistori();
                }
            }
            else System.out.println("Nomor Rekening tidak ditemukan");
        }
        if ( pilihMenu!=0){
            menu(r, c);
        }
        
    }
}
