using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch (cmbCipherTypes.SelectedIndex)
            {
                case 0:
                    {
                        Rail_fence_cipher rail_fence_cipher = new Rail_fence_cipher();
                        string src = txbData.Text;
                        src = src.Replace(" ", "");
                        int key = Convert.ToInt32(txbKey.Text);
                        if (rbEncrypt.Checked)
                            txbResult.Text = rail_fence_cipher.Encrypt(src, key);
                        else if (rbDecrypt.Checked)
                            txbResult.Text = rail_fence_cipher.Decrypt(src, key);
                        else
                            MessageBox.Show("Encrypt or decrypt???", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 1:
                    {
                        Column_cipher column_cipher = new Column_cipher();
                        string src = txbData.Text;
                        src = src.Replace(" ", "");
                        string key = txbKey.Text;
                        if (rbEncrypt.Checked)
                            txbResult.Text = column_cipher.Encrypt(src, key);
                        else if (rbDecrypt.Checked)
                            txbResult.Text = column_cipher.Decrypt(src, key);
                        else
                            MessageBox.Show("Encrypt or decrypt???", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2:
                    {
                        Turning_grille_cipher turning_grille_cipher = new Turning_grille_cipher();
                        string src = txbData.Text;
                        src = src.Replace(" ", "");
                        src = turning_grille_cipher.CheckSource(src);
                        string key = txbKey.Text;
                        if (turning_grille_cipher.CheckKey(key))
                        {
                            if (rbEncrypt.Checked)
                                txbResult.Text = turning_grille_cipher.Encrypt(src, key);
                            else if (rbDecrypt.Checked)
                                txbResult.Text = turning_grille_cipher.Decrypt(src, key);
                            else
                                MessageBox.Show("Encrypt or decrypt???", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Incorrect key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3:
                    {
                        Vigenere_cipher vigener_cipher = new Vigenere_cipher();
                        string src = txbData.Text;
                        src = src.Replace(" ", "");
                        string key = txbKey.Text;
                        key = vigener_cipher.StraightKeyword(src.Length, key);
                        if (!vigener_cipher.Check(src))
                        {
                            MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (rbEncrypt.Checked)
                            txbResult.Text = vigener_cipher.Encrypt(src, key);
                        else if (rbDecrypt.Checked)
                            txbResult.Text = vigener_cipher.Decrypt(src, key);
                        else
                            MessageBox.Show("Encrypt or decrypt???", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
