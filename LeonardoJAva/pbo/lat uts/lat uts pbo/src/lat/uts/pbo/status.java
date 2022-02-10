
package lat.uts.pbo;

import java.util.Random;

public class status {
    private String nama,title;
    private int hp,atk,armor,hp_battle,evasion;
    private int mana,mana_battle;

    public status(String nama, String title, int hp, int atk, int armor , int evasion, int mana ) {
        this.nama = nama;
        this.title = title;
        this.hp = hp;
        this.atk = atk;
        this.armor = armor;
        this.hp_battle = hp;
        this.evasion = evasion;
        this.mana = mana;
        this.mana_battle = mana;
    }

    public status(String nama, int hp, int atk, int armor, int evasion, int mana ) {
        this.nama = nama;
        this.title="none";
        this.hp = hp;
        this.atk = atk;
        this.armor = armor;
        this.hp_battle = hp;
        this.evasion = evasion;
        this.mana = mana;
        this.mana_battle = mana;
    }
    
    public String getNama() {
        return nama;
    }

    public void setNama(String nama) {
        this.nama = nama;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public int getHp() {
        return hp;
    }

    public void setHp(int hp) {
        this.hp = hp;
    }

    public int getAtk() {
        return atk;
    }

    public void setAtk(int atk) {
        this.atk = atk;
    }

    public int getArmor() {
        return armor;
    }

    public void setArmor(int armor) {
        this.armor = armor;
    }

    public int getHp_battle() {
        return hp_battle;
    }

    public void setHp_battle(int hp_battle) {
        this.hp_battle = hp_battle;
    }

    public int getEvasion() {
        return evasion;
    }

    public void setEvasion(int evasion) {
        this.evasion = evasion;
    }

    public int getMana() {
        return mana;
    }

    public void setMana(int mana) {
        this.mana = mana;
    }

    public int getMana_battle() {
        return mana_battle;
    }

    public void setMana_battle(int mana_battle) {
        this.mana_battle = mana_battle;
    }
    
    public void damageCalculation(int damage){
        hp_battle-=damage;
    }
    
    public void manaForSkill(int cost){
        mana_battle-=cost;
    }
    public void cetakMenuAttack(){
        
    }

    public void restoreMana(int mana){
        this.mana_battle+=mana;
    }
    @Override
    public String toString() {
        return "nama : " + nama + "( " + title + " )" + "\nHealth : " + hp_battle + "/" + hp  + "\nMana : " + mana_battle +"/"+ mana;
    }
    
}
