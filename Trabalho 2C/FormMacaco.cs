using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    public partial class FormMacaco : Form
    {
        int vida = 3;
        int vida2 = 3;
        int atacar = 1;
        int atacar2 = 1;    
        int recarga = 0;
        int recarga2 = 0;
        int i = 0;
    

        public FormMacaco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i != 999)
            {
                if (i % 2 == 0)
                {
                    CbAtacar2.Visible = true;
                    CbDefender2.Visible = true;
                    CbRecarregar2.Visible = true;
                    label4.Visible = true;
                    LbMunição2.Visible = true;

                    CbAtacar1.Visible = false;
                    CbDefender1.Visible = false;
                    CbRecarregar1.Visible = false;
                    label2.Visible = false;
                    LbMunição1.Visible = false;
                }
                if (i % 2 != 0)
                {
                    CbAtacar2.Visible = false;
                    CbDefender2.Visible = false;
                    CbRecarregar2.Visible = false;
                    label4.Visible=false;
                    LbMunição2.Visible=false;

                    CbAtacar1.Visible = true;
                    CbDefender1.Visible = true;
                    CbRecarregar1.Visible = true;
                    label2.Visible=true;
                    LbMunição1.Visible=true;
                }
                i++;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            int vidam1 = int.Parse(LbVida1.Text);
            int vidam2 = int.Parse(LbVida2.Text);   
            int munição1 = int.Parse(LbMunição1.Text);
            int munição2 = int.Parse(LbMunição2.Text);


            while (vidam1 >=0 && vidam2 >=0)
            {
                
                //error
               if (CbAtacar1.Checked == false && CbAtacar2.Checked == false && CbDefender1.Checked == false && CbDefender2.Checked == false && CbRecarregar1.Checked == false && CbRecarregar2.Checked == false)
                 {
                    MessageBox.Show("Error:004");
                    return;
                 }
                //coluna defesa e ataque
                if (CbAtacar1.Checked == true && CbDefender2.Checked == true)
                {
                    if (munição1 != 0 || munição2 != 0)
                    {
                        MessageBox.Show("o macaco 1 atacou e o macaco 2 defendeu aconteceu nada");
                        CbAtacar1.Checked = false;
                        CbDefender2.Checked = false;
                        munição1 = recarga--;

                        LbMunição1.Text = Convert.ToString(recarga);
                        return;
                    }
                    else
                    {
                        CbAtacar1.Checked = false;
                        CbDefender2.Checked = false;
                        MessageBox.Show("Erro:003");
                        return;
                    }
                    
                }
                else if (CbDefender1.Checked == true && CbAtacar2.Checked == true)
                {
                    if (munição1 != 0 || munição2 != 0)
                    {
                        MessageBox.Show("o macaco 1 defendeu e o macaco 2 atacou não aconteceu nada");
                        CbAtacar2.Checked = false;
                        CbDefender1.Checked = false;
                        munição2 = recarga2--;

                        LbMunição2.Text = Convert.ToString(recarga2);
                        return;
                    }
                    else
                    {
                        CbAtacar2.Checked = false;
                        CbDefender1.Checked = false;
                        MessageBox.Show("Erro:003");
                        return;
                    }
                }
                //coluna ataque e recarga               
                else if (CbRecarregar1.Checked == true && CbAtacar2.Checked == true)
                {
                    if (munição1 != 0 || munição2 != 0)
                    {
                        munição1 = recarga = recarga + 1;
                        LbMunição1.Text = Convert.ToString(recarga);

                        vidam1 = vida--;
                        LbVida1.Text = Convert.ToString(vida);

                        munição2 = recarga2--;

                        LbMunição2.Text = Convert.ToString(recarga2);

                        CbRecarregar1.Checked = false;
                        CbAtacar2.Checked = false;

                        MessageBox.Show("o macaco 1 recarregou e o macaco 2 atacou,-1 vida para macaco 1");
                        return;
                    }
                    else
                    {
                        CbRecarregar1.Checked = false;
                        CbAtacar2.Checked = false;

                        MessageBox.Show("Erro:003");
                        return;
                    }
                   
                }
                else if(CbAtacar1.Checked == true && CbRecarregar2.Checked == true)
                {
                    if (munição1 != 0 || munição2 != 0)
                    {
                        vidam2 = vida2--;
                        LbVida2.Text = Convert.ToString(vida2);


                        munição2 = recarga2 = recarga2 + 1;
                        LbMunição2.Text = Convert.ToString(recarga2);

                        CbRecarregar2.Checked = false;
                        CbAtacar1.Checked = false;

                        munição1 = recarga--;

                        LbMunição1.Text = Convert.ToString(recarga);

                        MessageBox.Show("o macaco 1 atacou e o macaco 2 recarregou,-1 vida para macaco 2");
                        return;
                    }
                    else
                    {
                        CbRecarregar2.Checked = false;
                        CbAtacar1.Checked = false;

                        MessageBox.Show("Erro:003");
                        return;
                    }
                  
                }
                //coluna defesa e recarga
                else if(CbDefender1.Checked == true && CbRecarregar2.Checked == true )
                {
                    munição2 = recarga2 = recarga2 + 1;
                    LbMunição2.Text = Convert.ToString(recarga2);

                    CbDefender1.Checked = false;
                    CbRecarregar2.Checked = false;

                    MessageBox.Show("o macaco 1 denfendeu e o macaco 2 recarregou ");
                    return;
                }
                else if(CbRecarregar1.Checked == true && CbDefender2.Checked ==  true)
                {
                    munição1 = recarga = recarga + 1;
                    LbMunição1.Text = Convert.ToString(recarga);
                    CbDefender2.Checked = false;
                    CbRecarregar1.Checked = false;

                    MessageBox.Show("o macaco 1 recarregou e o macaco 2 defendeu ");
                    return;
                }
                // apenas defesa
                else if(CbDefender1.Checked == true && CbDefender2.Checked == true)
                {

                    CbDefender2.Checked = false;
                    CbDefender1.Checked = false;
                    MessageBox.Show("Os dois macacos defenderam não aconteceu nada");
                    return;
                }
                // apenas ataque
                else if(CbAtacar1.Checked == true && CbAtacar2.Checked == true)
                {
                    if (munição1 != 0 || munição2 != 0)
                    {        
                        vidam1 = vidam1 - atacar;
                        LbVida1.Text = Convert.ToString(vidam1);
                        vidam2 = vidam2 - atacar;
                        LbVida2.Text = Convert.ToString(vidam2);

                        munição1 = recarga--;
                        munição1 = recarga;

                        LbMunição1.Text = Convert.ToString(recarga);

                       munição2 = recarga2--;
                        
                        LbMunição2.Text = Convert.ToString(recarga2);

                        CbAtacar1.Checked = false;
                        CbAtacar2.Checked = false;
                        MessageBox.Show("Os dois macacos atacaram!");
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Erro:003");
                        return;

                    }                   
                }
                // apenas recarga
                else if (CbRecarregar1.Checked == true && CbRecarregar2.Checked == true)
                {
                    munição1 = recarga = recarga + 1 ;
                    LbMunição1.Text = Convert.ToString(recarga);

                    munição2 = recarga2 = recarga2 + 1;
                    LbMunição2.Text = Convert.ToString(recarga2);

                    CbRecarregar1.Checked = false;
                    CbRecarregar2.Checked = false;

                    MessageBox.Show("Os dois macacos recarregaram");
                    return;
                }
                //obrigações e Erros                                  
                     if (CbAtacar1.Checked == true && CbDefender1.Checked == true)
                     {

                        MessageBox.Show("Error:001");

                        return;
                     }
                    else if (CbAtacar1.Checked == true && CbDefender1.Checked == true && CbRecarregar1.Checked == true)
                    {

                        MessageBox.Show("Error:002");

                        return;
                    }
                    else if (CbAtacar2.Checked == true && CbDefender2.Checked == true)
                    {

                        MessageBox.Show("Error:001");
                        return;

                    }
                    else if (CbAtacar2.Checked == true && CbDefender2.Checked == true && CbRecarregar2.Checked == true)
                    {

                        MessageBox.Show("Error:002");
                        return;

                    }
                if (vidam1 == 0 && vidam2 == 0)
                {
                    MessageBox.Show("Empate jogo surreal!!!");
                    return;

                }
                if (vidam1 == 0 && vidam2 != 0)
                {
                    MessageBox.Show("macaco 2  ganhou!!!");
                    return;
                }
                if (vidam2 == 0 && vidam1 != 0)
                {
                    MessageBox.Show("macaco 1 ganhou!!");
                    return;
                }
            }

            
            
        }
    }
}
