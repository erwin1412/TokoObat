/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lat.uts.pbo;

import java.util.Random;

/**
 *
 * @author ASUS
 */
public class human extends status{

    private int mirageManaCost=50,spearEdgeManaCost=70,wallOfSandManaCost=55,poisonKnifeManaCost=35;

    public human(String nama, String title, int hp, int atk, int armor, int evasion, int mana) {
        super(nama, title, hp, atk, armor, evasion, mana);
    }

    public human(String nama, int hp, int atk, int armor, int evasion, int mana) {
        super(nama, hp, atk, armor, evasion, mana);
    }
    
    @Override
    public void cetakMenuAttack(){
        System.out.println("1. mirage");
        System.out.println("2. spearEdge");
        System.out.println("3. wallOfSand");
        System.out.println("4. poisonKnife");
    }
    
    public int getMirageManaCost() {
        return mirageManaCost;
    }

    public int getSpearEdgeManaCost() {
        return spearEdgeManaCost;
    }

    public int getWallOfSandManaCost() {
        return wallOfSandManaCost;
    }

    public int getPoisonKnifeManaCost() {
        return poisonKnifeManaCost;
    }

    public int mirage(){
        manaForSkill(mirageManaCost);
        return 55;
    }
    
    public int spearEdge(){
        int totalDamage=getAtk()*2;
        manaForSkill(spearEdgeManaCost);
        return totalDamage;
    }
    
    public int wallOfSand(){
        manaForSkill(wallOfSandManaCost);
        int defenseUp=getArmor()*3/2;
        return defenseUp;
    }
    
    public int poisonKnife(){
        manaForSkill(poisonKnifeManaCost);
        int armorReduction=25;
        return armorReduction;
    }
}
