
package lat.uts.pbo;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class LatUtsPbo {

    public static void main(String[] args) {
        Scanner scanInt= new Scanner(System.in);
        Scanner scanStr= new Scanner(System.in);
        Random rnd=new Random();
        ArrayList<status> heroes= new ArrayList<>();
        int pilihan=0;
        do{
            System.out.print("===menu===\n1. new heroes\n2. battle \n0. exit\npilihan : ");
            pilihan=scanInt.nextInt();
            if ( pilihan==1 ){
                int summonHero=0;
                do{
                    System.out.print("pilih Ras Hero :\n1. Human\n2. Beast\n0. exit\npilihan : ");
                    summonHero=scanInt.nextInt();
                    if ( summonHero>0 && summonHero<3){
                        hiroNoShoukanSuru(heroes, summonHero);
                    }
                }while(summonHero!=0);
            }
            else if ( pilihan==2 ){
                boolean fight=true;
                int chooseHero=0;
                do{
                    for (int a = 0; a < heroes.size(); a++) {
                        System.out.println((a+1)+". "+heroes.get(a).getNama()+" Ras : "+heroes.get(a).getClass().getSimpleName());
                    }
                }while(chooseHero!=0);
                System.out.println("pilihan : ");
                chooseHero=scanInt.nextInt();
                chooseHero--;
                int enemyHero=rnd.nextInt(heroes.size());
                status player = null;
                status enemy = null;
                if ( chooseHero==0)player=heroes.get(chooseHero);
                else if ( chooseHero==1 )player=heroes.get(chooseHero);
                if ( enemyHero==0)enemy=heroes.get(enemyHero);
                else if ( enemyHero==1 )enemy=heroes.get(enemyHero);
                int move=0;
                int enemyMove;
                boolean manaCukup=true;
                int restoreManaPlayer=player.getMana()/2;
                int restoreManaEnemy=enemy.getMana()/2;
                int ctr=0;
                do{
                    if ( ctr==4 ){
                        player.restoreMana(restoreManaPlayer);
                        enemy.restoreMana(restoreManaEnemy);
                        ctr=0;
                    }
                    manaCukup=true;
                    System.out.println(player);
                    System.out.println("");
                    System.out.println(enemy);
                    System.out.println("");
                    System.out.println("choose your move : ");
                    player.cetakMenuAttack();
                    do{
                        move=scanInt.nextInt();
                        if ( player instanceof human ){
                            if ( move==1 && ((human) player).getMirageManaCost()>player.getMana_battle() || 
                                 move==2 && ((human) player).getSpearEdgeManaCost()>player.getMana_battle() ||
                                 move==3 && ((human) player).getWallOfSandManaCost()>player.getMana_battle() || 
                                 move==4 && ((human) player).getPoisonKnifeManaCost()>player.getMana_battle() ){
                                manaCukup=false;
                            }
                        }
                        else if ( player instanceof beast ){
                            if ( move==1 && ((beast) player).getClawOfTheWindManaCost()>player.getMana_battle() || 
                                 move==2 && ((beast) player).getBeastManaSkinManaCost()>player.getMana_battle() ||
                                 move==3 && ((beast) player).getHeavenStepManaCost()>player.getMana_battle() || 
                                 move==4 && ((beast) player).getDeadlyStrikeManaCost()>player.getMana_battle() ){
                                manaCukup=false;
                            }
                        }
                    }while(move<1 && move>4);
                    enemyMove=rnd.nextInt(4)+1;
                    if ( manaCukup)battle(player, move, enemy,enemyMove);
                    else System.out.println("mana tidak cukup");
                    ctr++;
                    if ( player.getHp_battle()<=0 ){
                        System.out.println("enemy win");
                        fight=false;
                    }
                    else if ( enemy.getHp_battle()<=0 ){
                        System.out.println("player win");
                        fight=false;
                    }
                }while(fight);
            }
        }while(pilihan!=0);
    }
    public static void battle(status player, int move , status enemy,int enemyMove){
        int myDamage=0,myEvasion=0;
        int enemyDamage=0,enemyEvasion=0;
        //enemy
        if ( enemy instanceof human){
            if ( enemyMove==1 ){
                enemyEvasion+=((human) enemy).mirage();
            }
            else if ( enemyMove==2 ){
                enemyDamage+=((human) enemy).spearEdge();
            }
            else if ( enemyMove==3 ){
                myDamage-=((human) enemy).wallOfSand();
            }
            else if ( enemyMove==4 ){
                enemyDamage+=((human) enemy).poisonKnife();
            }
        }
        else if (enemy instanceof beast){
            if ( enemyMove==1 ){
                enemyDamage+=((beast) enemy).clawOfTheWind();
            }
            else if ( enemyMove==2 ){
                enemyDamage-=((beast) enemy).beastManaSkin();
            }
            else if ( enemyMove==3 ){
                enemyEvasion+=((beast) enemy).heavenStep();
            }
            else if ( enemyMove==4 ){
                enemyDamage+=((beast) enemy).deadlyStrike();
            }
        }
        //player
        if ( player instanceof human){
            if ( move==1 ){
                myEvasion+=((human) player).mirage();
            }
            else if ( move==2 ){
                myDamage+=((human) player).spearEdge();
            }
            else if ( move==3 ){
                enemyDamage-=((human) player).wallOfSand();
            }
            else if ( move==4 ){
                myDamage+=((human) player).poisonKnife();
            }
        }
        else if (player instanceof beast){
            if ( move==1 ){
                myDamage+=((beast) player).clawOfTheWind();
            }
            else if ( move==2 ){
                enemyDamage-=((beast) player).beastManaSkin();
            }
            else if ( move==3 ){
                myEvasion+=((beast) player).heavenStep();
            }
            else if ( move==4 ){
                myDamage+=((beast) player).deadlyStrike();
            }
        }
        // player attack enemy
        Random rnd=new Random();
        int dogde=rnd.nextInt(100);
        if ( dogde>100-enemyEvasion){
            myDamage=0;
            System.out.println("enemy dogde");
        }
        else if (myDamage<=0){
            System.out.println("your attack has been blocked");
        }
        else{
            enemy.damageCalculation(myDamage);
            System.out.println("you have dealt "+myDamage+"damage");
        }
        //enemy attack player
        dogde=rnd.nextInt(100);
        if ( dogde>100-myEvasion){
            enemyDamage=0;
            System.out.println("player dogde");
        }
        else if (enemyDamage<=0){
            System.out.println("enemy attack has been blocked");
        }
        else{
            player.damageCalculation(enemyDamage);
            System.out.println("enemy have dealt "+enemyDamage+"damage");
        }
    }
    public static void hiroNoShoukanSuru(ArrayList<status> heroes ,int summonChoice ){
        Scanner scanInt= new Scanner(System.in);
        Scanner scanStr= new Scanner(System.in);
        String nama;
        int hp,atk,armor,evasion,mana;
        boolean kembar=false;
        do{
            System.out.println("nama : ");
            kembar=false;
            nama=scanStr.nextLine();
            if ( heroes.size()>0){
                for (status h : heroes) {
                    if ( h.getNama().equals(nama)){
                        kembar=true;
                    }
                }
            }
            if ( nama.length()==0){
                System.out.println("nama harus di isi");
            }
            if ( kembar ){
                System.out.println("nama sudah pernah dipakai");
            }
        }while(nama.length()<0 || kembar);
        do{
            System.out.println("hp : ");
            hp=scanInt.nextInt();
            if ( hp<0 ){
                System.out.println("hp harus lebih besar dari 0");
            }
        }while(hp<=0);
        do{
            System.out.println("armor : ");
            armor=scanInt.nextInt();
            if ( armor<0 ){
                System.out.println("armor harus lebih besar sama dengan dari 0");
            }
        }while(armor<0);
        do{
            System.out.println("attack : ");
            atk=scanInt.nextInt();
            if ( atk<0 ){
                System.out.println("attack harus lebih besar sama dengan 0");
            }
        }while(atk<0);
        do{
            System.out.println("evasion : ");
            evasion=scanInt.nextInt();
        }while(evasion<0);
        do{
            System.out.println("mana : ");
            mana=scanInt.nextInt();
            if ( mana<0 ){
                System.out.println("mana harus lebih besar sama dengan 0");
            }
        }while(mana<0);
        if ( summonChoice==1 )heroes.add(new human(nama, hp, atk, armor, evasion, mana));
        else if ( summonChoice==2 )heroes.add(new beast(nama, hp, atk, armor, evasion, mana));
        System.out.println("hero has been summoned");
    }
}
