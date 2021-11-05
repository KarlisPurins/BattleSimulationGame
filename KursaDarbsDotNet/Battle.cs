using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursaDarbsDotNet
{
    public partial class Battle : Form
    {
        String[] units = {"Axeman", "Spearman", "Swordsman"};
        int unitNumber = 0;
        int[,] playerTacticalLayout = new int[5,2]; //Troop type, troop count
        int[,] enemyTacticalLayout = new int[5,2]; //Troop type, troop count
        int[] axeman = {12, 10, 1, 2, 4}; //Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
        int[] spearman = {10, 6, 2, 0, 2}; //Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
        int[] swordsman = {14, 8, 4, 1, 2}; //Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
        public Battle()
        {
            InitializeComponent();
            updateLeftArmyLabel();
            lblSelectedUnit.Text = units[unitNumber];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(unitNumber == 2)
            {
                unitNumber = 0;
            }
            else
            {
                unitNumber++;
            }
            this.lblSelectedUnit.Text = units[unitNumber];
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Battle battleWindow = new Battle();
            this.Hide();
            battleWindow.Show();
        }

        private void armySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArmySelection armyWindow = new ArmySelection();
            this.Hide();
            armyWindow.Show();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter troop count in boxes for your army and enemy army. \n" +
                "Press \"To Battle\" button.\n" +
                "Afterwards You will be sent to Battle window.\n" +
                "Choose your troops and put them in tactical formation by clicking checkboxes.\n" +
                "When ready, press \"Start Battle\" button.\n" +
                "Good luck, have fun! :)");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is battle simulation game \nAuthor: Karlis Purins (IT19072)");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void battleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Battle battleWindow = new Battle();
            this.Hide();
            battleWindow.Show();
        }

        private void cbox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbox1.Checked == true)
            {
                if (ArmySelection.playerTroops[unitNumber] == 0)
                {
                    MessageBox.Show("You don't have this troop type");
                    cbox1.Checked = false;
                }
                else
                {
                    if(ArmySelection.playerTroops[unitNumber] < 10) //if army has LESS than 10 units of same kind
                    {
                        playerTacticalLayout[0, 0] = unitNumber; //Adds troop Type
                        playerTacticalLayout[0, 1] = ArmySelection.playerTroops[unitNumber]; //Adds troop count
                        cbox1.Text = ArmySelection.playerTroops[unitNumber] + units[unitNumber]; //Displays type and count as text next to CheckBox
                        ArmySelection.playerTroops[unitNumber] = 0;
                        updateLeftArmyLabel();

                    }
                    else //if army has MORE than 10 units of same kind
                    {
                        playerTacticalLayout[0, 0] = unitNumber;
                        playerTacticalLayout[0, 1] = 10;
                        cbox1.Text = 10 + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] -= 10;
                        updateLeftArmyLabel();
                    } 
                }
                
            }
            else
            {
                ArmySelection.playerTroops[unitNumber] += playerTacticalLayout[0,1];
                cbox1.Text = null;
                playerTacticalLayout[0, 1] = 0;
                updateLeftArmyLabel();
            }
            
        }

        private void cbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox2.Checked == true)
            {
                if (ArmySelection.playerTroops[unitNumber] == 0)
                {
                    MessageBox.Show("You don't have this troop type");
                    cbox2.Checked = false;
                }
                else
                {
                    if (ArmySelection.playerTroops[unitNumber] < 10)
                    {
                        playerTacticalLayout[1, 0] = unitNumber; 
                        playerTacticalLayout[1, 1] = ArmySelection.playerTroops[unitNumber];
                        cbox2.Text = ArmySelection.playerTroops[unitNumber] + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] = 0;
                        updateLeftArmyLabel();

                    }
                    else
                    {
                        playerTacticalLayout[1, 0] = unitNumber;
                        playerTacticalLayout[1, 1] = 10;
                        cbox2.Text = 10 + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] -= 10;
                        updateLeftArmyLabel();
                    }
                }
            }
            else
            {
                ArmySelection.playerTroops[unitNumber] += playerTacticalLayout[1,1];
                cbox2.Text = null;
                playerTacticalLayout[1,1] = 0;
                updateLeftArmyLabel();
            }
        }

        private void cbox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox3.Checked == true)
            {
                if (ArmySelection.playerTroops[unitNumber] == 0)
                {
                    MessageBox.Show("You don't have this troop type");
                    cbox3.Checked = false;
                }
                else
                {
                    if (ArmySelection.playerTroops[unitNumber] < 10)
                    {
                        playerTacticalLayout[2, 0] = unitNumber;
                        playerTacticalLayout[2,1] = ArmySelection.playerTroops[unitNumber];
                        cbox3.Text = ArmySelection.playerTroops[unitNumber] + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] = 0;
                        updateLeftArmyLabel();

                    }
                    else
                    {
                        playerTacticalLayout[2, 0] = unitNumber;
                        playerTacticalLayout[2,1] = 10;
                        cbox3.Text = 10 + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] -= 10;
                        updateLeftArmyLabel();
                    }
                }
            }
            else
            {
                ArmySelection.playerTroops[unitNumber] += playerTacticalLayout[2,1];
                cbox3.Text = null;
                playerTacticalLayout[2,1] = 0;
                updateLeftArmyLabel();
            }
        }

        private void cbox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox4.Checked == true)
            {
                if (ArmySelection.playerTroops[unitNumber] == 0)
                {
                    MessageBox.Show("You don't have this troop type");
                    cbox4.Checked = false;
                }
                else
                {
                    if (ArmySelection.playerTroops[unitNumber] < 10)
                    {
                        playerTacticalLayout[3, 0] = unitNumber;
                        playerTacticalLayout[3, 1] = ArmySelection.playerTroops[unitNumber];
                        cbox4.Text = ArmySelection.playerTroops[unitNumber] + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] = 0;
                        updateLeftArmyLabel();

                    }
                    else
                    {
                        playerTacticalLayout[3, 0] = unitNumber;
                        playerTacticalLayout[3,1] = 10;
                        cbox4.Text = 10 + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] -= 10;
                        updateLeftArmyLabel();
                    }
                }
            }
            else
            {
                ArmySelection.playerTroops[unitNumber] += playerTacticalLayout[3,1];
                cbox4.Text = null;
                playerTacticalLayout[3,1] = 0;
                updateLeftArmyLabel();
            }
        }

        private void cbox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox5.Checked == true)
            {
                if (ArmySelection.playerTroops[unitNumber] == 0)
                {
                    MessageBox.Show("You don't have this troop type");
                    cbox5.Checked = false;
                }
                else
                {
                    if (ArmySelection.playerTroops[unitNumber] < 10)
                    {
                        playerTacticalLayout[4, 0] = unitNumber;
                        playerTacticalLayout[4,1] = ArmySelection.playerTroops[unitNumber];
                        cbox5.Text = ArmySelection.playerTroops[unitNumber] + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] = 0;
                        updateLeftArmyLabel();

                    }
                    else
                    {
                        playerTacticalLayout[4, 0] = unitNumber;
                        playerTacticalLayout[4,1] = 10;
                        cbox5.Text = 10 + units[unitNumber];
                        ArmySelection.playerTroops[unitNumber] -= 10;
                        updateLeftArmyLabel();
                    }
                }
            }
            else
            {
                ArmySelection.playerTroops[unitNumber] += playerTacticalLayout[4,1];
                playerTacticalLayout[4,1] = 0;
                cbox5.Text = null;
                updateLeftArmyLabel();
            }
        }

        private void updateLeftArmyLabel()
        {
            lblTestText.Text = ArmySelection.playerTroops[0] + " Axeman\n" +
                ArmySelection.playerTroops[1] + " Spearman\n" +
                ArmySelection.playerTroops[2] + " Swordsman";
        }

        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            startBattle();
        }

        private void startBattle()
        {
            enemyLayout();
            MessageBox.Show("Battle started");
            while (ArmySelection.playerTroops[3] > 0 && ArmySelection.enemyTroops[3] > 0)
            {
                regimentShift();
                regimentBattle();
            }
            if(ArmySelection.playerTroops[3] > 0 && ArmySelection.enemyTroops[3] <= 0)
            {
                MessageBox.Show("You won!\n" +
                    "You had "+ArmySelection.playerTroops[3]+ " troops left.");
                for(int i=0; i<4; i++)
                {
                    ArmySelection.playerTroops[i] = 0;
                    ArmySelection.enemyTroops[i] = 0;
                }
                ArmySelection armyWindow = new ArmySelection();
                this.Hide();
                armyWindow.Show();

            }
            else if(ArmySelection.playerTroops[3] <= 0 && ArmySelection.enemyTroops[3] <= 0)
            {
                MessageBox.Show("It's a draw.");
                for (int i = 0; i < 4; i++)
                {
                    ArmySelection.playerTroops[i] = 0;
                    ArmySelection.enemyTroops[i] = 0;
                }
                ArmySelection armyWindow = new ArmySelection();
                this.Hide();
                armyWindow.Show();
            }
            else
            {
                MessageBox.Show("You lost...\n" +
                    "Enemy had " + ArmySelection.enemyTroops[3] + " troops left.");
                for (int i = 0; i < 4; i++)
                {
                    ArmySelection.playerTroops[i] = 0;
                    ArmySelection.enemyTroops[i] = 0;
                }
                ArmySelection armyWindow = new ArmySelection();
                this.Hide();
                armyWindow.Show();
            }
            
        }

        private void regimentShift()
        {
            for(int i=0; i<5; i++) //Iterates through all "CheckBoxes"
            {
                if (playerTacticalLayout[i, 1] != 0 && enemyTacticalLayout[i, 1] != 0) //This CheckBox both has troops
                    continue;
                else if (playerTacticalLayout[i, 1] == 0 && enemyTacticalLayout[i, 1] == 0) //This CheckBox nobody has troops
                    continue;
                else if (playerTacticalLayout[i, 1] != 0 && enemyTacticalLayout[i, 1] == 0) //Player has troops, enemy dont have in this CheckBox
                {
                    if(isRegimentOnPlayerLeft(i) && isRegimentOnPlayerRight(i)) //Occupied on both sides
                    {
                        continue;
                    }
                    else if (!isRegimentOnPlayerLeft(i) && isRegimentOnPlayerRight(i)) //Occupied on right, free on left
                    {
                        moveLeft(playerTacticalLayout, i);
                    }
                    else //occupied on left, free on right; OR free on both sides
                    {
                        moveRight(playerTacticalLayout, i);
                    }
                }
                else if (playerTacticalLayout[i, 1] == 0 && enemyTacticalLayout[i, 1] != 0) //Enemy has troops, player dont have
                {
                    if (isRegimentOnEnemyLeft(i) && isRegimentOnEnemyRight(i)) //Occupied on both sides
                    {
                        continue;
                    }
                    else if (isRegimentOnEnemyLeft(i) && !isRegimentOnEnemyRight(i)) //occupied on left, free on right
                    {
                        moveRight(enemyTacticalLayout, i);
                    }
                    else //Occupied on right, free on left; OR free on both sides
                    {
                        moveLeft(enemyTacticalLayout, i);
                    }

                }
            }
        }

        private void regimentBattle()
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (playerTacticalLayout[i, 1] != 0 && enemyTacticalLayout[i, 1] != 0) //This CheckBox both has troops
                {
                    int[] totalHPAfterBattle = battleSetup(playerTacticalLayout[i, 0], playerTacticalLayout[i, 1], enemyTacticalLayout[i, 0], enemyTacticalLayout[i, 1]);
                    bool playerAlive, enemyAlive;
                    if (totalHPAfterBattle[0] == 0)
                        playerAlive = false;
                    else
                        playerAlive = true;
                    if (totalHPAfterBattle[1] == 0)
                        enemyAlive = false;
                    else
                        enemyAlive = true;
                    if (!playerAlive && enemyAlive) //Player dead, enemy alive
                    {
                        ArmySelection.playerTroops[3] -= playerTacticalLayout[i, 1];
                        playerTacticalLayout[i, 1] = 0;
                        int startingTroopStackCount = enemyTacticalLayout[i, 1];
                        enemyTacticalLayout[i, 1] = (int)(totalHPAfterBattle[1] / getTroopTypeArray(enemyTacticalLayout[i, 0])[0]);
                        ArmySelection.enemyTroops[3] -= (startingTroopStackCount - enemyTacticalLayout[i, 1]);
                    }
                    else if (playerAlive && !enemyAlive) //Player alive, enemy dead
                    {
                        ArmySelection.enemyTroops[3] -= enemyTacticalLayout[i, 1];
                        enemyTacticalLayout[i, 1] = 0;
                        int startingTroopStackCount = playerTacticalLayout[i, 1];
                        playerTacticalLayout[i, 1] = (int)(totalHPAfterBattle[0] / getTroopTypeArray(playerTacticalLayout[i, 0])[0]);
                        ArmySelection.playerTroops[3] -= (startingTroopStackCount - playerTacticalLayout[i, 1]);
                    }
                    else if (playerAlive && enemyAlive) //Both alive
                    {
                        int playerStartingTroopStackCount = playerTacticalLayout[i, 1];
                        int enemyStartingTroopStackCount = enemyTacticalLayout[i, 1];
                        playerTacticalLayout[i, 1] = (int)(totalHPAfterBattle[0] / getTroopTypeArray(playerTacticalLayout[i, 0])[0]);
                        enemyTacticalLayout[i, 1] = (int)(totalHPAfterBattle[1] / getTroopTypeArray(enemyTacticalLayout[i, 0])[0]);
                        ArmySelection.enemyTroops[3] -= (enemyStartingTroopStackCount - enemyTacticalLayout[i, 1]);
                        ArmySelection.playerTroops[3] -= (playerStartingTroopStackCount - playerTacticalLayout[i, 1]);

                    }
                    else                                //Both dead
                    {
                        ArmySelection.enemyTroops[3] -= enemyTacticalLayout[i, 1];
                        ArmySelection.playerTroops[3] -= playerTacticalLayout[i, 1];
                        enemyTacticalLayout[i, 1] = 0;
                        playerTacticalLayout[i, 1] = 0;
                    }
                }
                else
                    continue;
            }
        }

        private int[] battleSetup(int playerTroopType, int playerTroopCount, int eneTroopType, int eneTroopCount)
        { //Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
            int[] playerTroopTotalStats = new int[6];
            int[] enemyTroopTotalStats = new int[6];
            if (playerTroopType == 0) //is Axeman
            {
                playerTroopTotalStats = doTotalStatsCalculus(axeman, playerTroopCount, playerTroopType);
            }else if(playerTroopType == 1) //is Spearman
            {
                playerTroopTotalStats = doTotalStatsCalculus(spearman, playerTroopCount, playerTroopType);
            }
            else //is Swordsman
            {
                playerTroopTotalStats = doTotalStatsCalculus(swordsman, playerTroopCount, playerTroopType);
            }
            if(eneTroopType == 0) //is Axeman
            {
                enemyTroopTotalStats = doTotalStatsCalculus(axeman, eneTroopCount, eneTroopType);
            }
            else if (eneTroopType == 1){ //is Spearman
                enemyTroopTotalStats = doTotalStatsCalculus(spearman, eneTroopCount, eneTroopType);
            }
            else //is Swordsman
            {
                enemyTroopTotalStats = doTotalStatsCalculus(swordsman, eneTroopCount, eneTroopType);
            }
            return battleFight(playerTroopTotalStats, enemyTroopTotalStats);

        }

        private int[] battleFight(int[] playerTroops, int[] enemyTroops)
        {//Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
            //Player does damage
            if(enemyTroops[5] == playerTroops[3]) //Has player troops Edge over enemy troops
            {
                if (((playerTroops[1] + playerTroops[4]) - enemyTroops[2]) > 0) //if damage is negative
                    enemyTroops[0] -= ((playerTroops[1] + playerTroops[4]) - enemyTroops[2]);
            }
            else
            {
                if((playerTroops[1] - enemyTroops[2]) > 0)
                    enemyTroops[0] -= (playerTroops[1] - enemyTroops[2]);
            }
            //Enemy does damage
            if(playerTroops[5] == enemyTroops[3]) //Has enemy troop Edge over Player troops
            {
                if(((enemyTroops[1] + enemyTroops[4]) - playerTroops[2]) > 0)
                    playerTroops[0] -= ((enemyTroops[1] + enemyTroops[4]) - playerTroops[2]);
            }
            else
            {
                if((enemyTroops[1] - playerTroops[2]) > 0)
                    playerTroops[0] -= (enemyTroops[1] - playerTroops[2]);
            }
            //Who is dead
            int[] totalHP = new int[2];
            if(playerTroops[0] <= 0 && enemyTroops[0] > 0) //Player dead, enemy alive
            {
                totalHP[0] = 0;
                totalHP[1] = enemyTroops[0];
            }else if(playerTroops[0] > 0 && enemyTroops[0] <= 0) //Player alive, enemy dead
            {
                totalHP[0] = playerTroops[0];
                totalHP[1] = 0;
            }else if(playerTroops[0] <= 0 && enemyTroops[0] <= 0) //Both dead
            {
                totalHP[0] = 0;
                totalHP[1] = 0;
            }
            else                                                //Both alive
            {
                totalHP[0] = playerTroops[0];
                totalHP[1] = enemyTroops[0];
            }
            return totalHP;
        }

        private void enemyLayout()
        {
            for(int c=0; c<3; c++) //Iterates through Troop Types in army
            {
                for (int i = 0; i < 5; i++) //Iterates through "CheckBoxes"
                {
                    if (enemyTacticalLayout[i,1] != 0) //Not empty "CheckBox"
                        continue;
                    if (ArmySelection.enemyTroops[c] == 0) //No troops in this troop type
                    {
                        break;
                    }
                    else if (ArmySelection.enemyTroops[c] < 10) //If LESS than 10 of one kind in army
                    {
                        enemyTacticalLayout[i, 0] = c; //Troop type
                        enemyTacticalLayout[i, 1] = ArmySelection.enemyTroops[c]; //Troop count
                        ArmySelection.enemyTroops[c] = 0; //Left troop count
                    }
                    else //if MORE than 10 of one kind in army
                    {
                        enemyTacticalLayout[i, 0] = c; //Troop type
                        enemyTacticalLayout[i, 1] = 10; //Troop count
                        ArmySelection.enemyTroops[c] -= 10; //Left troop count
                    }

                }
            }
            
            
        }

        private bool isRegimentOnPlayerRight(int givenNumber)
        {
            if(givenNumber == 4)
            {
                if (playerTacticalLayout[0, 1] != 0)
                    return true;
                return false;
            }
            else
            {
                if (playerTacticalLayout[givenNumber + 1, 1] != 0)
                    return true;
                return false;
            }
                
        }
        private bool isRegimentOnPlayerLeft(int givenNumber)
        {
            if(givenNumber == 0)
            {
                if (playerTacticalLayout[4, 1] != 0)
                    return true;
                return false;
            }
            else
            {
                if (playerTacticalLayout[givenNumber - 1, 1] != 0)
                    return true;
                return false;
            }
        }
        private bool isRegimentOnEnemyRight(int givenNumber)
        {
            
            
            if(givenNumber == 4)
            {
                if (enemyTacticalLayout[0, 1] != 0)
                    return true;
                return false;
            }
            else
            {
                if (enemyTacticalLayout[givenNumber + 1, 1] != 0)
                    return true;
                return false;
            }
        }
        private bool isRegimentOnEnemyLeft(int givenNumber)
        {
            if(givenNumber == 0)
            {
                if (enemyTacticalLayout[4, 1] != 0)
                    return true;
                return false;
            }
            else
            {
                if (enemyTacticalLayout[givenNumber - 1, 1] != 0)
                    return true;
                return false;
            }
        }

        private void moveRight(int[,] tacticalLayout, int givenNumber)
        {
            if(givenNumber == 4)
            {
                tacticalLayout[0, 0] = tacticalLayout[givenNumber, 0];
                tacticalLayout[0, 1] = tacticalLayout[givenNumber, 1];
                tacticalLayout[givenNumber, 1] = 0;
            }
            else
            {
                tacticalLayout[givenNumber + 1, 0] = tacticalLayout[givenNumber, 0];
                tacticalLayout[givenNumber + 1, 1] = tacticalLayout[givenNumber, 1];
                tacticalLayout[givenNumber, 1] = 0;
            }
            
        }

        private void moveLeft(int[,] tacticalLayout, int givenNumber)
        {
            if(givenNumber == 0)
            {
                tacticalLayout[4, 0] = tacticalLayout[givenNumber, 0];
                tacticalLayout[4, 1] = tacticalLayout[givenNumber, 1];
                tacticalLayout[givenNumber, 1] = 0;
            }
            else
            {
                tacticalLayout[givenNumber - 1, 0] = tacticalLayout[givenNumber, 0];
                tacticalLayout[givenNumber - 1, 1] = tacticalLayout[givenNumber, 1];
                tacticalLayout[givenNumber, 1] = 0;
            }
            
        }

        private int[] doTotalStatsCalculus(int[] troop, int count, int troopType)
        {//Health, Attack, defense, Edge over troop (0 - Axeman, 1 - Spearman, 2 - Swordsman), Edge added Attack
            int[] returnArray = new int[6];
            returnArray[0] = troop[0] * count;
            returnArray[1] = troop[1] * count;
            returnArray[2] = troop[2] * count;
            returnArray[3] = troop[3];
            returnArray[4] = troop[4] * count;
            returnArray[5] = troopType;
            return returnArray;
        }

        private int[] getTroopTypeArray(int troopTypeNumber)
        {
            if (troopTypeNumber == 0) //is Axeman
            {
                return axeman;
            }
            else if (troopTypeNumber == 1) //is Spearman
            {
                return spearman;
            }
            else //is Swordsman
            {
                return swordsman;
            } 
        }
    }
}
