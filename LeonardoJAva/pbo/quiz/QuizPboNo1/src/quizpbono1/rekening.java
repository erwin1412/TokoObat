
package quizpbono1;

public class rekening {
    private String jenisRekening;
    private int limitTransaksi;
    private boolean fiturHistoryTransaksi;

    public rekening(String jenisRekening, int limitTransaksi, boolean fiturHistoryTransaksi) {
        this.jenisRekening = jenisRekening;
        this.limitTransaksi = limitTransaksi;
        this.fiturHistoryTransaksi = fiturHistoryTransaksi;
    }

    public String getJenisRekening() {
        return jenisRekening;
    }

    public void setJenisRekening(String jenisRekening) {
        this.jenisRekening = jenisRekening;
    }

    public int getLimitTransaksi() {
        return limitTransaksi;
    }

    public void setLimitTransaksi(int limitTransaksi) {
        this.limitTransaksi = limitTransaksi;
    }

    public boolean isFiturHistoryTransaksi() {
        return fiturHistoryTransaksi;
    }

    public void setFiturHistoryTransaksi(boolean fiturHistoryTransaksi) {
        this.fiturHistoryTransaksi = fiturHistoryTransaksi;
    }

}
