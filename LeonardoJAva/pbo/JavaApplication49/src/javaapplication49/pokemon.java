/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication49;
public class pokemon {
    private String nama;
    private int hp,maxhp,level,exp;
    private int atk,def;
    private String[] skill = new String[4];
    private int[] mp = new int[4];
    private int[] maxmp = new int[4];
    private String tipe = new String();
    public pokemon(String nama, int hp, int atk, int def,String skill,int mp,String tipe) {
        this.nama = nama;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        maxhp=hp;
        level=1;
        exp=0;
        for (int i = 0; i < 4; i++) {
            this.skill[i]="-";
        }
        this.skill[0]=skill;
        this.skill[1]=skill;
        this.skill[2]=skill;
        this.skill[3]=skill;
        this.mp[0]=mp;
        this.maxmp[0]=mp;
        this.tipe = tipe;
    }

    public String getTipe() {
        return tipe;
    }

    public void setTipe(String tipe) {
        this.tipe = tipe;
    }

    public int[] getMaxmp() {
        return maxmp;
    }

    public void setMaxmp(int[] maxmp) {
        this.maxmp = maxmp;
    }

    public String getNama() {
        return nama;
    }

    public void setNama(String nama) {
        this.nama = nama;
    }

    public int getHp() {
        return hp;
    }

    public void setHp(int hp) {
        this.hp = hp;
    }

    public int getMaxhp() {
        return maxhp;
    }

    public void setMaxhp(int maxhp) {
        this.maxhp = maxhp;
    }

    public int getLevel() {
        return level;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    public int getExp() {
        return exp;
    }

    public void setExp(int exp) {
        this.exp = exp;
    }

    public int getAtk() {
        return atk;
    }

    public void setAtk(int atk) {
        this.atk = atk;
    }

    public int getDef() {
        return def;
    }

    public void setDef(int def) {
        this.def = def;
    }

    public String[] getSkill() {
        return skill;
    }

    public void setSkill(String[] skill) {
        this.skill = skill;
    }

    public int[] getMp() {
        return mp;
    }

    public void setMp(int[] mp) {
        this.mp = mp;
    }
    
}
