﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//THESE ARE GAL's FUNCTION NOT MINE !!

namespace Gal
{


    class GBAFunctions


    {
        public void WriteHex(string BytesToWrite, string Offset, string FileLocation, int AmountToWrite) //Made by Gal.
        {
            using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(FileLocation))) //We can't use it if we don't  reference it :P.
            {
                if (AmountToWrite == 1) //If the amount to write was set to 1...
                {
                    bw.Seek(Convert.ToInt32(Offset, 16), SeekOrigin.Begin); //The BinaryWriter will start reading from the offset given.
                    ushort u = Convert.ToUInt16(BytesToWrite, 16); //A new short that will store the byte the user wants to write.
                    bw.Write((byte)u); //Converts the short to a byte and writes it.
                }
                if (AmountToWrite == 2) //If the amount io write was set to 2...
                {
                    bw.Seek(Convert.ToInt32(Offset, 16), SeekOrigin.Begin); //The BinaryWriter will start reading from the offset given.
                    ushort u = Convert.ToUInt16(BytesToWrite, 16); //A new short that will store the bytes to user wants to write.
                    bw.Write((byte)((u >> 8) & 255)); //Seperates the left 2 characters of the short and, converts them to a byte and writes them.
                    bw.Write((byte)(u & 255)); //Seperates the right 2 characters of the short and, converts them to a byte and writes them.
                }
            }
        }


        public string GetGameCode(string FileLocation) //Made by Gal.
        {
            string gameCode = string.Empty; //Declared a thing that's gonna store the bytes read.
            using (BinaryReader br = new BinaryReader(File.OpenRead(FileLocation))) //We can't use it if we don't  reference it :P.
            {
                br.BaseStream.Seek(0xAC, SeekOrigin.Begin); //Sets the seeking position at 0xAC, the area where the game code is at (at Pokémon games).
                gameCode = Encoding.UTF8.GetString(br.ReadBytes(4)); //Reads 4 bytes, the amount of bytes the game code requires and converts them to UTF8 so it could be readable lol.

            }
            return (gameCode); //Returns a string.


        }

        public string ReadHex(int BytesToRead, string Offset, string FileLocation, bool SplitBytesBySpace) //Some parts made by Gal. The other parts written by Hopeless Masquerade! Arigato!
        {
            string bytes = string.Empty; //Declared a string that's gonna store the bytes read.
            using (BinaryReader br = new BinaryReader(File.OpenRead(FileLocation))) //We can't use it if we don't  reference it :P.
            {


                br.BaseStream.Position = Convert.ToInt32(Offset, 16); //BinaryReader will start reading from the given offset.
                for (int x = 0; x < BytesToRead; x++) //The command will repeat itself for the number of bytes the user wants to read.
                {

                    bytes += br.ReadByte().ToString("X"); //Each time, the BinaryReader will read a byte and add it to the string.

                    if (SplitBytesBySpace == true)
                    {
                        bytes += " "; //If the bool was set to true, it will also seperate the bytes with a space.
                    }
                }


            }
            return (bytes); //Returns a string.

        }





        public void IpsPatch(string TargetFilePath, string IpsFilePath) //This code wasn't made by me. It's by www.smwiki.net.
        {
            FileStream romstream = new FileStream(TargetFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            FileStream ipsstream = new FileStream(IpsFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            int lint = (int)ipsstream.Length;
            byte[] ipsbyte = new byte[ipsstream.Length];
            byte[] rombyte = new byte[romstream.Length];
            IAsyncResult romresult;
            IAsyncResult ipsresult = ipsstream.BeginRead(ipsbyte, 0, lint, null, null);
            ipsstream.EndRead(ipsresult);
            int ipson = 5;
            int totalrepeats = 0;
            int offset = 0;
            bool keepgoing = true;
            while (keepgoing == true)
            {
                offset = ipsbyte[ipson] * 0x10000 + ipsbyte[ipson + 1] * 0x100 + ipsbyte[ipson + 2];
                ipson += 3;
                if (ipsbyte[ipson] * 256 + ipsbyte[ipson + 1] == 0)
                {
                    ipson += 2;
                    totalrepeats = ipsbyte[ipson] * 256 + ipsbyte[ipson + 1];
                    ipson += 2;
                    byte[] repeatbyte = new byte[totalrepeats];
                    for (int ontime = 0; ontime < totalrepeats; ontime++)
                        repeatbyte[ontime] = ipsbyte[ipson];
                    romstream.Seek(offset, SeekOrigin.Begin);
                    romresult = romstream.BeginWrite(repeatbyte, 0, totalrepeats, null, null);
                    romstream.EndWrite(romresult);
                    ipson++;
                }
                else
                {
                    totalrepeats = ipsbyte[ipson] * 256 + ipsbyte[ipson + 1];
                    ipson += 2;
                    romstream.Seek(offset, SeekOrigin.Begin);
                    romresult = romstream.BeginWrite(ipsbyte, ipson, totalrepeats, null, null);
                    romstream.EndWrite(romresult);
                    ipson += totalrepeats;
                }
                if (ipsbyte[ipson] == 69 && ipsbyte[ipson + 1] == 79 && ipsbyte[ipson + 2] == 70)
                    keepgoing = false;
            }
            romstream.Close();
            ipsstream.Close();


        }


        public void WriteHexArray(byte[] ByteArray, string Offset, string FileLocation) {
            using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(FileLocation))) { //We can't use it if we don't  reference it :P.
                bw.BaseStream.Position = Convert.ToInt32(Offset, 16); //Sets the position of the BinaryWriter to the offset provided.
                bw.Write(ByteArray); //Writes the bytes array provided.
            }



        }



    }





    }

