using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gal;

namespace GB_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GBAFunctions gf = new GBAFunctions();
        string gameCode = string.Empty;//Makes a new string that will be used to the gamecode.

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd.Filter = "GB File(*.gb,*.gbc)|*.gb;*.gbc"; //Makes a filter for the open file dialog. You don't want the user to open .NDS files, aren't ya?
            ofd.ShowDialog();//Shows the open file dialog
            
            using (BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName))) //Sets a new integer to the BinaryReader
            {
                br.BaseStream.Seek(0x13C, SeekOrigin.Begin); //The seek is starting from 0x13C
                gameCode = Encoding.UTF8.GetString(br.ReadBytes(3)); //Reads 3 bytes from 0x13C and encodes it to text
                br.Close();
            }
            if (gameCode == "BLU") // Checks if the game code is BLUE.
            {
                label1.Text = "LOADED ROM: Pokémon BLUE"; //If it's BLUE, it changes label1's text.
                loaded = true;
            }
            else if (gameCode == "RED") // Checks if the game code is RED.
            {
                label1.Text = "LOADED ROM: Pokémon RED"; //If it's RED, it changes label1's text.
                loaded = true;
            }
            else if (gameCode == "YEL") // Checks if the game code is YELA.
            {
                label1.Text = "LOADED ROM: Pokémon YELLOW"; //If it's YELA, it changes label1's text.
                loaded = true;
            }
            else //If the gamecode isn't on the list.
            {
                label1.Text = "Loaded Game: ???"; //Changes label1's text.
                MessageBox.Show("The loaded game isn't supported"); //Creates a message box with the text "The loaded game isn't supported", since this program only supports first gen FR rom.
            }
        }
        int tradeVal;
        bool loaded = false;
        string selectedPkm; //offset du pkm selectionné
        string pkmLevel;
        string evolmethod = string.Empty;
        string evolLevel = string.Empty;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {

                if (cb1.SelectedItem == "Draco")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b763";
                        pkmLevel = "3b764";
                    }
                    else
                    {
                        selectedPkm = "3b5ba";
                        pkmLevel = "3b5bb";
                    }

                }
                if (cb1.SelectedItem == "Kokiyas")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b488";
                        pkmLevel = "3b489";
                    }
                    else
                    {
                        selectedPkm = "3b2f9";
                        pkmLevel = "3b2fa";
                    }

                }
                if (cb1.SelectedItem == "Bulbizarre")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3ba06";
                        pkmLevel = "3ba07";
                    }
                    else
                    {
                        selectedPkm = "3b847";
                        pkmLevel = "3b848";
                    }

                }
                if (cb1.SelectedItem == "Herbizarre")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b3d7";
                        pkmLevel = "3b3d8";
                    }
                    else
                    {
                        selectedPkm = "3b24e";
                        pkmLevel = "3b24f";
                    }
                }
                if (cb1.SelectedItem == "Salameche")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bafa";
                        pkmLevel = "3bafb";
                    }
                    else
                    {
                        selectedPkm = "3b93b";
                        pkmLevel = "3b93c";
                    }

                }
                if (cb1.SelectedItem == "Reptincel")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb1c";
                        pkmLevel = "3bb1d";
                    }
                    else
                    {
                        selectedPkm = "3b95d";
                        pkmLevel = "3b95e";
                    }

                }
                if (cb1.SelectedItem == "Carapuce")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb0b";
                        pkmLevel = "3bb0c";
                    }
                    else
                    {
                        selectedPkm = "3b94c";
                        pkmLevel = "3b94d";
                    }

                }
                if (cb1.SelectedItem == "Carabaffe")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb2d";
                        pkmLevel = "3bb2e";
                    }
                    else
                    {
                        selectedPkm = "3b96e";
                        pkmLevel = "3b96f";
                    }
                }
                if (cb1.SelectedItem == "Chenipan")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b8fa";
                        pkmLevel = "3b8fb";
                    }
                    else
                    {
                        selectedPkm = "3b745";
                        pkmLevel = "3b746";
                    }

                }
                if (cb1.SelectedItem == "Chrysacier")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b8ff";
                        pkmLevel = "3b900";
                    }
                    else
                    {
                        selectedPkm = "3b74a";
                        pkmLevel = "3b74b";
                    }

                }
                if (cb1.SelectedItem == "Aspicot")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b896";
                        pkmLevel = "3b897";
                    }
                    else
                    {
                        selectedPkm = "3b6e7";
                        pkmLevel = "3b6e8";
                    }

                }
                if (cb1.SelectedItem == "Coconfort")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b89b";
                        pkmLevel = "3b89c";
                    }
                    else
                    {
                        selectedPkm = "3b6ec";
                        pkmLevel = "3b6ed";
                    }
                }
                if (cb1.SelectedItem == "Roucoul")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b536";
                        pkmLevel = "3b537";
                    }
                    else
                    {
                        selectedPkm = "3b39f";
                        pkmLevel = "3b3a0";
                    }

                }
                if (cb1.SelectedItem == "Roucoups")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b9e5";
                        pkmLevel = "3b9e6";
                    }
                    else
                    {
                        selectedPkm = "3b826";
                        pkmLevel = "3b827";
                    }

                }
                if (cb1.SelectedItem == "Rattata")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3ba83";
                        pkmLevel = "3ba84";
                    }
                    else
                    {
                        selectedPkm = "3b8c4";
                        pkmLevel = "3b8c5";
                    }
                }

                if (cb1.SelectedItem == "Piafabec")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b3a1";
                        pkmLevel = "3b3a2";
                    }
                    else
                    {
                        selectedPkm = "3b215";
                        pkmLevel = "3b216";
                    }

                }
                if (cb1.SelectedItem == "Abo")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b860";
                        pkmLevel = "3b861";
                    }
                    else
                    {
                        selectedPkm = "3b6b1";
                        pkmLevel = "3b6b2";
                    }

                }
                if (cb1.SelectedItem == "Pikachu")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b736";
                        pkmLevel = "3b737";
                    }
                    else
                    {
                        selectedPkm = "3b595";
                        pkmLevel = "3b596";
                    }

                }
                if (cb1.SelectedItem == "Sabelette")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b7a8";
                        pkmLevel = "3b7a9";
                    }
                    else
                    {
                        selectedPkm = "3b5ff";
                        pkmLevel = "3b600";
                    }

                }
                if (cb1.SelectedItem == "NidoranF")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b423";
                        pkmLevel = "3b424";
                    }
                    else
                    {
                        selectedPkm = "3b29a";
                        pkmLevel = "3b29b";
                    }
                }
                if (cb1.SelectedItem == "Nidorina")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3baac";
                        pkmLevel = "3baad";
                    }
                    else
                    {
                        selectedPkm = "3b8ed";
                        pkmLevel = "3b8ef";
                    }

                }
                if (cb1.SelectedItem == "NidoranM")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b37e";
                        pkmLevel = "3b37f";
                    }
                    else
                    {
                        selectedPkm = "3b1f5";
                        pkmLevel = "3b1f6";
                    }

                }
                if (cb1.SelectedItem == "Nidorino")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3ba9a";
                        pkmLevel = "3ba9b";
                    }
                    else
                    {
                        selectedPkm = "3b8db";
                        pkmLevel = "3b8dd";
                    }

                }
                if (cb1.SelectedItem == "Melofee")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b38f";
                        pkmLevel = "3b390";
                    }
                    else
                    {
                        selectedPkm = "3b206";
                        pkmLevel = "3b207";
                    }
                }
                if (cb1.SelectedItem == "Goupix")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b724";
                        pkmLevel = "3b725";
                    }
                    else
                    {
                        selectedPkm = "3b583";
                        pkmLevel = "3b584";
                    }

                }
                if (cb1.SelectedItem == "Rondoudou")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b7da";
                        pkmLevel = "3b7db";
                    }
                    else
                    {
                        selectedPkm = "3b631";
                        pkmLevel = "3b632";
                    }

                }
                if (cb1.SelectedItem == "Nosferapti")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b851";
                        pkmLevel = "3b852";
                    }
                    else
                    {
                        selectedPkm = "3b6a2";
                        pkmLevel = "3b6a3";
                    }

                }
                if (cb1.SelectedItem == "Mystherbe")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb54";
                        pkmLevel = "3bb55";
                    }
                    else
                    {
                        selectedPkm = "3b995";
                        pkmLevel = "3b996";
                    }
                }
                if (cb1.SelectedItem == "Ortide")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb65";
                        pkmLevel = "3bb66";
                    }
                    else
                    {
                        selectedPkm = "3b9a6";
                        pkmLevel = "3b9a7";
                    }

                }
                if (cb1.SelectedItem == "Paras")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b86f";
                        pkmLevel = "3b870";
                    }
                    else
                    {
                        selectedPkm = "3b2f9";
                        pkmLevel = "3b2fa";
                    }

                }
                if (cb1.SelectedItem == "Mimitos")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b68f";
                        pkmLevel = "3b690";
                    }
                    else
                    {
                        selectedPkm = "3b4f2";
                        pkmLevel = "3b4f3";
                    }

                }
                if (cb1.SelectedItem == "Taupiqueur")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b662";
                        pkmLevel = "3b663";
                    }
                    else
                    {
                        selectedPkm = "3b4c5";
                        pkmLevel = "3b4c6";
                    }
                }
                if (cb1.SelectedItem == "Miaouss")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b700";
                        pkmLevel = "3b701";
                    }
                    else
                    {
                        selectedPkm = "3b55f";
                        pkmLevel = "3b560";
                    }

                }
                if (cb1.SelectedItem == "Psykokwak")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b5d5";
                        pkmLevel = "3b5d6";
                    }
                    else
                    {
                        selectedPkm = "3b43c";
                        pkmLevel = "3b43d";
                    }

                }
                if (cb1.SelectedItem == "Ferosinge")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b640";
                        pkmLevel = "3b641";
                    }
                    else
                    {
                        selectedPkm = "3b4a7";
                        pkmLevel = "3b4a8";
                    }

                }
                if (cb1.SelectedItem == "Caninos")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b50e";
                        pkmLevel = "3b50f";
                    }
                    else
                    {
                        selectedPkm = "3b377";
                        pkmLevel = "3b378";
                    }
                }
                if (cb1.SelectedItem == "Ptitard")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b6c7";
                        pkmLevel = "3b6c8";
                    }
                    else
                    {
                        selectedPkm = "3b526";
                        pkmLevel = "3b527";
                    }

                }
                if (cb1.SelectedItem == "Tetarte")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b87e";
                        pkmLevel = "3b87f";
                    }
                    else
                    {
                        selectedPkm = "3b6cf";
                        pkmLevel = "3b6d0";
                    }

                }
                if (cb1.SelectedItem == "Abra")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b9d2";
                        pkmLevel = "3b9d3";
                    }
                    else
                    {
                        selectedPkm = "3b813";
                        pkmLevel = "3b814";
                    }

                }
                if (cb1.SelectedItem == "Kadabra")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b558";
                        pkmLevel = "3b559";
                    }
                    else
                    {
                        selectedPkm = "3b3c1";
                        pkmLevel = "3b3c2";
                    }
                }
                if (cb1.SelectedItem == "Machoc")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b842";
                        pkmLevel = "3b843";
                    }
                    else
                    {
                        selectedPkm = "3b693";
                        pkmLevel = "3b694";
                    }

                }
                if (cb1.SelectedItem == "Machopeur")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b58a";
                        pkmLevel = "3b58b";
                    }
                    else
                    {
                        selectedPkm = "3b3f1";
                        pkmLevel = "3b3f2";
                    }

                }
                if (cb1.SelectedItem == "Chetiflor")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb7f";
                        pkmLevel = "3bb80";
                    }
                    else
                    {
                        selectedPkm = "3b9c0";
                        pkmLevel = "3b9c1";
                    }

                }
                if (cb1.SelectedItem == "Boustiflor")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bb92";
                        pkmLevel = "3bb93";
                    }
                    else
                    {
                        selectedPkm = "3b9d3";
                        pkmLevel = "3b9d4";
                    }
                }
                if (cb1.SelectedItem == "Tentacool")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b498";
                        pkmLevel = "3b499";
                    }
                    else
                    {
                        selectedPkm = "3b309";
                        pkmLevel = "3b30a";
                    }

                }
                if (cb1.SelectedItem == "Racaillou")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3babe";
                        pkmLevel = "3babf";
                    }
                    else
                    {
                        selectedPkm = "3b8ff";
                        pkmLevel = "3b900";
                    }

                }
                if (cb1.SelectedItem == "Gravalanche")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b569";
                        pkmLevel = "3b56a";
                    }
                    else
                    {
                        selectedPkm = "3b3d2";
                        pkmLevel = "3b3d3";
                    }

                }
                if (cb1.SelectedItem == "Ponyta")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3ba64";
                        pkmLevel = "3ba65";
                    }
                    else
                    {
                        selectedPkm = "3b8a5";
                        pkmLevel = "3b8a6";
                    }

                }
                if (cb1.SelectedItem == "Ramoloss")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b547";
                        pkmLevel = "3b548";
                    }
                    else
                    {
                        selectedPkm = "3b3b0";
                        pkmLevel = "3b3b1";
                    }
                }
                if (cb1.SelectedItem == "Magneti")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3bae5";
                        pkmLevel = "3bae6";
                    }
                    else
                    {
                        selectedPkm = "3b926";
                        pkmLevel = "3b927";
                    }

                }
                if (cb1.SelectedItem == "Doduo")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b6b6";
                        pkmLevel = "3b6b7";
                    }
                    else
                    {
                        selectedPkm = "3b515";
                        pkmLevel = "3b516";
                    }

                }
                if (cb1.SelectedItem == "Otaria")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b653";
                        pkmLevel = "3b654";
                    }
                    else
                    {
                        selectedPkm = "3b4b6";
                        pkmLevel = "3b4b7";
                    }

                }
                if (cb1.SelectedItem == "Tadmorv")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b40c";
                        pkmLevel = "3b40d";
                    }
                    else
                    {
                        selectedPkm = "3b283";
                        pkmLevel = "3b284";
                    }

                }
                if (cb1.SelectedItem == "Fantominus")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b4ad";
                        pkmLevel = "3b4ae";
                    }
                    else
                    {
                        selectedPkm = "3b31e";
                        pkmLevel = "3b31f";
                    }

                }
                if (cb1.SelectedItem == "Spectrum")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b9c9";
                        pkmLevel = "3b9ca";
                    }
                    else
                    {
                        selectedPkm = "3b80a";
                        pkmLevel = "3b80b";
                    }

                }
                if (cb1.SelectedItem == "Soporifik")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b5e4";
                        pkmLevel = "3b5e5";
                    }
                    else
                    {
                        selectedPkm = "3b44b";
                        pkmLevel = "3b44c";
                    }

                }
                if (cb1.SelectedItem == "Krabby")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b70f";
                        pkmLevel = "3b710";
                    }
                    else
                    {
                        selectedPkm = "3b56e";
                        pkmLevel = "3b56f";
                    }

                }
                if (cb1.SelectedItem == "Voltorbe")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b3b0";
                        pkmLevel = "3b3b1";
                    }
                    else
                    {
                        selectedPkm = "3b227";
                        pkmLevel = "3b228";
                    }

                }
                if (cb1.SelectedItem == "Noeunoeuf")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b3fa";
                        pkmLevel = "3b3fb";
                    }
                    else
                    {
                        selectedPkm = "3b271";
                        pkmLevel = "3b272";
                    }

                }
                if (cb1.SelectedItem == "Osselait")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b43c";
                        pkmLevel = "3b43d";
                    }
                    else
                    {
                        selectedPkm = "3b2b3";
                        pkmLevel = "3b2b4";
                    }

                }
                if (cb1.SelectedItem == "Smogo")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b62f";
                        pkmLevel = "3b630";
                    }
                    else
                    {
                        selectedPkm = "3b496";
                        pkmLevel = "3b497";
                    }

                }
                if (cb1.SelectedItem == "Rhinocorne")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b451";
                        pkmLevel = "3b452";
                    }
                    else
                    {
                        selectedPkm = "3b2c2";
                        pkmLevel = "3b2c3";
                    }

                }
                if (cb1.SelectedItem == "Hypotrempe")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b789";
                        pkmLevel = "3b78a";
                    }
                    else
                    {
                        selectedPkm = "3b5e0";
                        pkmLevel = "3b5e1";
                    }

                }
                if (cb1.SelectedItem == "Poissirene")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3ba3d";
                        pkmLevel = "3ba3e";
                    }
                    else
                    {
                        selectedPkm = "3b87e";
                        pkmLevel = "3b87f";
                    }

                }
                if (cb1.SelectedItem == "Stari")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b4c6";
                        pkmLevel = "3b4c7";
                    }
                    else
                    {
                        selectedPkm = "3b335";
                        pkmLevel = "3b336";
                    }

                }
                if (cb1.SelectedItem == "Magicarpe")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b962";
                        pkmLevel = "3b963";
                    }
                    else
                    {
                        selectedPkm = "3b7a9";
                        pkmLevel = "3b7aa";
                    }

                }
                if (cb1.SelectedItem == "Evoli")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b7f0";
                        pkmLevel = "3b7f1";
                    }
                    else
                    {
                        selectedPkm = "3b647";
                        pkmLevel = "3b648";
                    }

                }
                if (cb1.SelectedItem == "Amonita")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b7c3";
                        pkmLevel = "3b7c4";
                    }
                    else
                    {
                        selectedPkm = "3b61a";
                        pkmLevel = "3b61b";
                    }

                }
                if (cb1.SelectedItem == "Kabuto")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b772";
                        pkmLevel = "3b773";
                    }
                    else
                    {
                        selectedPkm = "3b5c9";
                        pkmLevel = "3b5ca";
                    }

                }
                if (cb1.SelectedItem == "Minidraco")
                {
                    if (gameCode == "YEL")
                    {
                        selectedPkm = "3b754";
                        pkmLevel = "3b755";
                    }
                    else
                    {
                        selectedPkm = "3b5ab";
                        pkmLevel = "3b5ac";
                    }

                }
                evolmethod = gf.ReadHex(1, selectedPkm, ofd.FileName, true);
                evolLevel = gf.ReadHex(1, pkmLevel, ofd.FileName, true); //Recuperation du niveau en HEX
                int dec = int.Parse(evolLevel, System.Globalization.NumberStyles.HexNumber); //Convertion du hex en dec
                textBox1.Text = dec.ToString(); //Affichage d'un int dans un string
                tradeVal = Convert.ToInt32(evolmethod);
                if (tradeVal == 1)
                {
                    CBlvl.SelectedItem = "Niveau";

                }
                else if (tradeVal == 3)
                {
                    CBlvl.SelectedItem = "Echange";

                }
                else if (tradeVal == 2)
                {
                    CBlvl.SelectedItem = "Pierre";
                }

            }
            else
            {
                MessageBox.Show("LOAD A GAME FIRST !!!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int leveldec = int.Parse(textBox1.Text); //Recuperation du niveau en decimal
            string hexValue = leveldec.ToString("X"); //Convertion du niveau en HEX
            string methodpkm = CBlvl.SelectedItem.ToString();
            if (methodpkm == "Niveau")
            {
                gf.WriteHex("1", selectedPkm, ofd.FileName, 1); //Save Method changes - Level
            }
            else if (methodpkm == "Pierre")
            {
                gf.WriteHex("2", selectedPkm, ofd.FileName, 1); //Save Method changes - Evolution Stone
            }
            else if (methodpkm == "Echange")
            {
                gf.WriteHex("3", selectedPkm, ofd.FileName, 1); //Save Method changes - Trade
            }

            gf.WriteHex(hexValue, pkmLevel, ofd.FileName, 1); // Save Level changes
            MessageBox.Show("Modification saved");

        }

        private void CBlvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBlvl.SelectedItem == "Echange")
            {
                textBox1.Enabled = false;
            }
            else if (CBlvl.SelectedItem == "Niveau")
            {
                textBox1.Enabled = true;
            }
            else if (CBlvl.SelectedItem == "Pierre")
            {
                textBox1.Enabled = false;
            }
        }
    }

}