using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicPatternFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB,0.618)) {
                    if (isInRange(BD, 1.272, 1.618)) {
                        if (isInRange(XD, 0.786)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish G-786");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.382, 0.50)) {
                    if (isInRange(BD, 1.618, 2.618)) {
                        if (isInRange(XD, 0.886)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish B-886");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.382)) {
                    if (isInRange(BD, 2.0, 3.618)) {
                        if (isInRange(XD, 1.13)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish AB-113");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.786)) {
                    if (isInRange(BD, 1.618, 2.24)) {
                        if (isInRange(XD,1.272)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish B-1272");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.382, 0.50)) {
                    if (isInRange(BD, 1.618, 2.618)) {
                        if (isInRange(XD, 0.886, 0.886)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish B-886");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.382, 0.618)) {
                    if (isInRange(BD, 2.24, 3.618)) {
                        if (isInRange(XD, 1.618)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish C-1618");
                        }
                    }
                }
            }

            if (isInRange(AC, 0.382, 0.886)) {
                if (isInRange(XB, 0.886)) {
                    if (isInRange(BD, 2.0, 3.618)) {
                        if (isInRange(XD, 1.618)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish DC-1618");
                        }
                    }
                }
            }

            if (isInRange(AC, 1.13, 1.618)) {                 
                    if (isInRange(BD, 1.618, 2.24)) {
                        if (isInRange(XD, 0.886, 1.13)) {
                            MessageBox.Show("Il s'agit d'un Bullish ou Bearish  S-886");
                    }                    
                }
            }

            if (isInRange(AC, 1.13, 1.618)) {
                    if (isInRange(BD, 1.618, 2.24)) {
                    MessageBox.Show("Il s'agit d'un 50% reversal (à vérifier pour OC pas calculé)");
                        
                    }
                
            } 

        }

        private Boolean isInRange(TextBox what, Double val1, Double val2 = 3121.24234)
        {
            if(val2 == 3121.24234) { val2 = val1; }
            if (what.Text.Contains(".")) what.Text = what.Text.Replace(".", ",");
            if (Convert.ToDouble(what.Text) <= val2 && Convert.ToDouble(what.Text) >= val1)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.ForeColor == Color.Red) {
                button2.ForeColor = Color.Green;
            } else {         
                button2.ForeColor = Color.Red;
            }

            if (pictureBox1.Image.Size.Width == 1045  && pictureBox1.Image.Size.Height == 773 ) {
                pictureBox1.Image = Properties.Resources.Screenshot_2;
            } else {
                pictureBox1.Image = Properties.Resources.Screenshot_1;
            }
        }
    }
}
