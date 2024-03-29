﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete
{
    public partial class RussianRoullette : Form
    {
        Bullets bullets = new Bullets();//This is instance of bullet class
        Random randomNumbers = new Random();
        int totalShoot = 6;//sets the value for totalshots
        int gunTry = 2;//sets the value for gun
        public RussianRoullette()//This is constructor
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();//An assembly is a file that is automatically generated by the compiler 
            warGround.Image = RussianRoullete.Properties.Resources.load;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete.Properties.Resources.LoadingShotgun);//Add sound here
            soundPlayer.Play();//play sound

            loadBtn.Enabled = false;
            bullets.Load = 1;
            //bullets.Spin = randomNumbers.Next(1, 6);
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();//An assembly is a file that is automatically generated by the compiler 
            warGround.Image = RussianRoullete.Properties.Resources.spin;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete.Properties.Resources.Empty);//Add sound here
            soundPlayer.Play();//play sound

            spinBtn.Enabled = false;
            
            bullets.Spin = randomNumbers.Next(1, 6);
        }

        private void shootBtn_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();//An assembly is a file that is automatically generated by the compiler 
            warGround.Image = RussianRoullete.Properties.Resources.shoot;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (totalShoot > 0 && bullets.Spin == 1)
            {
                MessageBox.Show("Shoot You loose");
                shootAwayBtn.Enabled = false;
                shootBtn.Enabled = false;
            }
            else if (totalShoot > 0 && bullets.Spin != 1)
            {
                MessageBox.Show("Blank Fire");
                totalShoot = totalShoot - 1;//minus one from total
                bullets.Spin = bullets.ShootLoop(bullets.Spin);

            }
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            (new RussianRoullette()).Show();
            this.Hide();
        }

        private void shootAwayBtn_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();//An assembly is a file that is automatically generated by the compiler 
            warGround.Image = RussianRoullete.Properties.Resources.shootaway;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (totalShoot > 0 && bullets.Spin == 1 && gunTry==2)
            {
                MessageBox.Show("you win you score is 200");
                shootAwayBtn.Enabled = false;
                shootBtn.Enabled = false;
            }
            if (totalShoot > 0 && bullets.Spin == 1 && gunTry == 1)
            {
                MessageBox.Show("you win you score is 100");
                shootAwayBtn.Enabled = false;
                shootBtn.Enabled = false;
            }
            else if (totalShoot > 0 && bullets.Spin != 1)
            {
                MessageBox.Show("Blank Fire");
                totalShoot = totalShoot - 1;//minus one from total
                bullets.Spin = bullets.ShootLoop(bullets.Spin);

            }
        }
    }
}
