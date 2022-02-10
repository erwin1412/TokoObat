
package quizpbono1;

import java.util.ArrayList;

public class customer {
    private String jenisRekening;
    private int noRekening,sisaLimit;
    private ArrayList<String> histori;
    private String nama;
    private int saldo;
    
    public customer(String nama,String jenisRekening, int noRekening) {
        histori=new ArrayList<>();
        this.jenisRekening = jenisRekening;
        this.noRekening = noRekening;
        this.nama = nama;
        saldo=0;
        if ( jenisRekening.equalsIgnoreCase("s")){
            sisaLimit=25000000;
        }
        if ( jenisRekening.equalsIgnoreCase("g")){
            sisaLimit=25000000;
        }
        if ( jenisRekening.equalsIgnoreCase("p")){
            sisaLimit=25000000;
        }
    }

    public String getJenisRekening() {
        return jenisRekening;
    }

    public void setJenisRekening(String jenisRekening) {
        this.jenisRekening = jenisRekening;
    }

    public int getNoRekening() {
        return noRekening;
    }

    public void setNoRekening(int noRekening) {
        this.noRekening = noRekening;
    }

    public ArrayList<String> getHistori() {
        return histori;
    }

    public void setHistori(ArrayList<String> histori) {
        this.histori = histori;
    }

    public int getSaldo() {
        return saldo;
    }
    
    public void tambahSaldo(int saldo){
        this.saldo+=saldo;
    }
    
    public void penguranganSaldo(int saldo){
        this.saldo-=saldo;
    }
    
    public void setSaldo(int saldo) {
        this.saldo = saldo;
    }
    
    public void tambahHistori(String h){
        histori.add(h);
    }
    
    public void cetakHistori(){
        System.out.println("====Histori====");
        for (int a = 0; a < histori.size(); a++) {
            System.out.println((a+1)+". "+histori.get(a));
        }
    }
    
    public int getSisaLimit() {
        return sisaLimit;
    }

    public void setSisaLimit(int sisaLimit) {
        this.sisaLimit = sisaLimit;
    }
    
    public void penguranganLimit(int l){
        sisaLimit-=l;
    }

    public String getNama() {
        return nama;
    }

    public void setNama(String nama) {
        this.nama = nama;
    }
    
    
}
