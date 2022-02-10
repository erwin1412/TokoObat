
package lat.uts.pbo;

/**
 *
 * @author ASUS
 */
public class beast extends status{

    int clawOfTheWindManaCost=70,beastManaSkinManaCost=150,heavenStepManaCost=35,deadlyStrikeManaCost=500;

    public beast(String nama, String title, int hp, int atk, int armor, int evasion, int mana) {
        super(nama, title, hp, atk, armor, evasion, mana);
    }

    public beast(String nama, int hp, int atk, int armor, int evasion, int mana) {
        super(nama, hp, atk, armor, evasion, mana);
    }

    public int getClawOfTheWindManaCost() {
        return clawOfTheWindManaCost;
    }

    public int getBeastManaSkinManaCost() {
        return beastManaSkinManaCost;
    }

    public int getHeavenStepManaCost() {
        return heavenStepManaCost;
    }

    public int getDeadlyStrikeManaCost() {
        return deadlyStrikeManaCost;
    }
    
    @Override
    public void cetakMenuAttack(){
        System.out.println("1. clawOfTheWind");
        System.out.println("2. beastManaSkin");
        System.out.println("3. heavenStep");
        System.out.println("4. deadlyStrike");
    }
    
    public int clawOfTheWind(){
        int damage=getAtk()+100;
        manaForSkill(clawOfTheWindManaCost);
        return damage;
    }
    
    public int beastManaSkin(){
        int armorUp=getArmor()+25;
        manaForSkill(beastManaSkinManaCost);
        return armorUp;
    }
    
    public int heavenStep(){
        manaForSkill(heavenStepManaCost);
        return 90;
    }
    
    public int deadlyStrike(){
        manaForSkill(deadlyStrikeManaCost);
        return getAtk()+500;
    }
}
