/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg1;

import java.util.ArrayList;

/**
 *
 * @author asus_
 */
public class rekening {
    ArrayList<String> history=new ArrayList<>();
    private String jenisRek, namaPemilik;
    private int limTran, noRek, totalTran, saldo;
    private boolean lihatHistory;

    public rekening(String jenisRek, int limTran, boolean lihatHistory, String namaPemilik) {
        this.jenisRek = jenisRek;
        this.limTran = limTran;
        this.lihatHistory = lihatHistory;
        this.namaPemilik=namaPemilik;
        this.noRek=(int) (Math.random()*89999+10000);
        this.totalTran=0;
        this.saldo=0;
    }

    public void setHistory(ArrayList<String> history) {
        this.history = history;
    }

    public ArrayList<String> getHistory() {
        return history;
    }
    
    public void tarik(int jumlah){
        totalTran+=jumlah;
        saldo-=jumlah;
    }
    
    public void setor(int jumlah){
        totalTran+=jumlah;
        saldo+=jumlah;
    }

    public void setSaldo(int saldo) {
        this.saldo = saldo;
    }

    public int getSaldo() {
        return saldo;
    }

    public void setNoRek(int noRek) {
        this.noRek = noRek;
    }

    public void setTotalTran(int totalTran) {
        this.totalTran = totalTran;
    }

    public int getTotalTran() {
        return totalTran;
    }

    public int getNoRek() {
        return noRek;
    }

    public void setNamaPemilik(String namaPemilik) {
        this.namaPemilik = namaPemilik;
    }

    public String getNamaPemilik() {
        return namaPemilik;
    }

    public String getJenisRek() {
        return jenisRek;
    }

    public void setJenisRek(String jenisRek) {
        this.jenisRek = jenisRek;
    }

    public int getLimTran() {
        return limTran;
    }

    public boolean isLihatHistory() {
        return lihatHistory;
    }

    public void setLimTran(int limTran) {
        this.limTran = limTran;
    }

    public void setLihatHistory(boolean lihatHistory) {
        this.lihatHistory = lihatHistory;
    }
    
}
