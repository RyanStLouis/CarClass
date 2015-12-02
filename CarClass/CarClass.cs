/*
 * Created by: Ryan St. Louis
 * Created on: 15/12/02
 * Created for: ICS3U
 * Daily Assignment – Unit 8-01
 * This program does nothing
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass
{
    public partial class frmCarClass : Form
    {
        class Vehicle
        {
            private string _liscensePlate;
            private string _colour;
            private int _numOfDoors;
            private int _speed;
            private int _maxSpeed;

            public void Accelerate(int speedIncrease)
            {
                this._speed = speedIncrease + this._speed;
            }
            public void Brake(int speedDecrease)
            {
                this._speed = this._speed - speedDecrease;
            }
            public string CurrentState()
            {
                string returnString;

                returnString = "Speed: " + this._speed + "Liscense Plate: " + this._liscensePlate +
                    "# of doors: " + this._numOfDoors + "Colour: " + this._colour;

                return returnString;
            }
        }

        public frmCarClass()
        {
            InitializeComponent();
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {

        }
    }
}
