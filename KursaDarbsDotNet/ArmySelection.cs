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
    public partial class ArmySelection : Form
    {
        static public int[] playerTroops = new int[4]; //0 - Axeman, 1 - Spearman, 2 - Swordsman, 4 - Total
        static public int[] enemyTroops = new int[4]; //0 - Axeman, 1 - Spearman, 2 - Swordsman, 4 - Total
        public ArmySelection()
        {
            InitializeComponent();
            lblTotalCntPlayer.Text = "Total Count: " + playerTroops[3];
            lblTotalCntEne.Text = "Total Count: " + enemyTroops[3];
            updatePlayerArmyLabel();
            updateEnemyArmyLabel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void battleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Battle battleWindow = new Battle();
            this.Hide();
            battleWindow.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is battle simulation game \nAuthor: Karlis Purins (IT19072)");
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

        private void armySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArmySelection armyWindow = new ArmySelection();
            this.Hide();
            armyWindow.Show();
        }

        private void btnToBattle_Click(object sender, EventArgs e)
        {
          
            if (playerTroops[3] <= 0 || enemyTroops[3] <= 0)
            {
                MessageBox.Show("Error! You must enter at least 1 troop on your and enemy side!");
            }
            else
            {
                //MessageBox.Show("Player troop count: " + playerTroops[3] + "\nEnemy troop count: " + enemyTroops[3]);
                Battle battleWindow = new Battle();
                this.Hide();
                battleWindow.Show();
            }
            
        }

        private void txtYourAxe_TextChanged(object sender, EventArgs e)
        {
            btnConfPlayAxe.Visible = true;
        }

        private void txtYourSpear_TextChanged(object sender, EventArgs e)
        {
            btnConfPlaySpear.Visible = true;
        }

        private void txtYourSword_TextChanged(object sender, EventArgs e)
        {
            btnConfPlaySword.Visible = true;
        }

        private void txtEneAxe_TextChanged(object sender, EventArgs e)
        {
            btnConfEneAxe.Visible = true;
        }

        private void txtEneSpear_TextChanged(object sender, EventArgs e)
        {
            btnConfEneSpear.Visible = true;
        }

        private void txtEneSword_TextChanged(object sender, EventArgs e)
        {
            btnConfEneSword.Visible = true;
        }

        private void updatePlayerTotalTroopCount(int i)
        {
                try
                {
                    if(i == 0)
                    {
                        int number = Int32.Parse(txtYourAxe.Text);
                        if(checkPlayerMaximumAllowed(number))
                            playerTroops[0] += number;
                        updatePlayerArmyLabel();

                    }
                    if(i == 1)
                    {
                        int number = Int32.Parse(txtYourSpear.Text);
                        if (checkPlayerMaximumAllowed(number))
                            playerTroops[1] += number;
                        updatePlayerArmyLabel();
                    }
                        
                    if(i == 2)
                    {
                        int number = Int32.Parse(txtYourSword.Text);
                        if (checkPlayerMaximumAllowed(number))
                            playerTroops[2] += number;
                        updatePlayerArmyLabel();
                    }    
                }
                catch (Exception e)
                {
                }
            
            
        }

        private void updateEnemyTotalTroopCount(int i)
        {
            
                try
                {
                    if (i == 0)
                    {
                        int number = Int32.Parse(txtEneAxe.Text);
                        if (checkEnemyMaximumAllowed(number))
                            enemyTroops[0] += number;
                        updateEnemyArmyLabel();
                    }
                    if (i == 1)
                    {
                        int number = Int32.Parse(txtEneSpear.Text);
                        if (checkEnemyMaximumAllowed(number))
                            enemyTroops[1] += number;
                        updateEnemyArmyLabel();
                    }
                    if (i == 2)
                    {
                        int number = Int32.Parse(txtEneSword.Text);
                        if (checkEnemyMaximumAllowed(number))
                            enemyTroops[2] += number;
                        updateEnemyArmyLabel();
                    }
                }
                catch (Exception e)
                { 
                }
            
            
        }

        private void btnConfPlayAxe_Click(object sender, EventArgs e)
        {
            updatePlayerTotalTroopCount(0);
            lblTotalCntPlayer.Text = "Total Count: " + playerTroops[3];
        }

        private void btnConfPlaySpear_Click(object sender, EventArgs e)
        {
            updatePlayerTotalTroopCount(1);
            lblTotalCntPlayer.Text = "Total Count: " + playerTroops[3];
        }

        private void btnConfPlaySword_Click(object sender, EventArgs e)
        {
            updatePlayerTotalTroopCount(2);
            lblTotalCntPlayer.Text = "Total Count: " + playerTroops[3];
        }

        private void btnConfEneAxe_Click(object sender, EventArgs e)
        {
            updateEnemyTotalTroopCount(0);
            lblTotalCntEne.Text = "Total Count: " + enemyTroops[3];
        }

        private void btnConfEneSpear_Click(object sender, EventArgs e)
        {
            updateEnemyTotalTroopCount(1);
            lblTotalCntEne.Text = "Total Count: " + enemyTroops[3];
        }

        private void btnConfEneSword_Click(object sender, EventArgs e)
        {
            updateEnemyTotalTroopCount(2);
            lblTotalCntEne.Text = "Total Count: " + enemyTroops[3];
        }

        private bool checkPlayerMaximumAllowed(int enteredNumber)
        {
            if ((playerTroops[3] + enteredNumber) <= 50)
            {
                playerTroops[3] += enteredNumber;
                return true;
            }
            else
            {
                MessageBox.Show("Army can't be larger than 50 units.");
                return false;
            }
                
        }

        private bool checkEnemyMaximumAllowed(int enteredNumber)
        {
            if ((enemyTroops[3] + enteredNumber) <= 50)
            {
                enemyTroops[3] += enteredNumber;
                return true;
            }
            else
            {
                MessageBox.Show("Army can't be larger than 50 units.");
                return false;
            }

        }

        private void updatePlayerArmyLabel()
        {
            lblPlayerArmy.Text = playerTroops[0] + " Axeman\n" +
                playerTroops[1] + " Spearman\n" +
                playerTroops[2] + " Swordsman";
        }

        private void updateEnemyArmyLabel()
        {
            lblEneArmy.Text = enemyTroops[0] + " Axeman\n" +
                enemyTroops[1] + " Spearman\n" +
                enemyTroops[2] + " Swordsman";
        }
    }
}
