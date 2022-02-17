﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        //add handler so that player can't go off screen

        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed; //continuously drop the player towards the floor - adds gravity effect

            if (jumping && force < 0) //checking if the player is jumping and force of the jump is less than 0 if so then we can change jump back to false
            {
                jumping = false;
            }

            if (goLeft) //if go left is true then we can push the character towards left of the screen
            {
                player.Left -= 5;
            }

            if (goRight) //if go right variable is true then we are going to move the player left towards the right
            {
                player.Left += 5;
            }
             
            if (jumping) //If jumping is true then we change the jump speed integer to minus 12 which means it will thrust the player towards the top and we decrease the force by 1. If we don’t do this then character can fly over everything we need to give the jump a limit              
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else //ELSE the character is not jumping then we can keep the jump speed on 12
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

            }

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You WIN! You scored: " + score.ToString());
            }
        }
    }
}
