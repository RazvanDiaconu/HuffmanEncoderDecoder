using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Huffman
{
    internal class Decodor : Codor
    {
        public List<Node> ListaDeNoduri = new List<Node>();


        public void Decodeaza(string cale)
        {
            
            FileStream fs = new FileStream(cale, FileMode.Open);
            int nr = 0;
            string temp = CitesteAntet(32, fs);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != '0')
                {
                    nr++;
                    ListaDeNoduri.Add(new Node(Convert.ToChar(i).ToString()));
                }
            }
            temp = CitesteAntet(nr * 4, fs);
            for (int i = 0; i < nr; i++)
            {
                ListaDeNoduri[i].frecventa = Convert.ToUInt32(temp.Substring(i * 32, 32), 2);
            }

            ListaDeNoduri.Sort();

            ConstruiesteArbore(ListaDeNoduri);
            uint nrTotalDeCaractere = ListaDeNoduri[0].frecventa;
            GenerareCoduri(ListaDeNoduri[0], "");
            temp = CitesteAntet(Convert.ToInt32(fs.Length - (32 + 4 * nr)), fs);
            GlobalVar iesire = new GlobalVar();
            DecodeazaFisier(ListaDeNoduri[0], temp, iesire, "", 0, ListaDeNoduri[0], nrTotalDeCaractere);
            CreazaFisierDecodat(iesire.text,cale);

        }

        private void CreazaFisierDecodat(string text,string cale)
        {
            FileStream fs = new FileStream(cale.Substring(0, cale.Length - 3), FileMode.Create);
            //for(int i = 0; i < text.Length; i++)
            //{
            //    fs.WriteByte(Convert.ToByte(text[i]));
            //}
            //Console.WriteLine(text);
            fs.Write(Encoding.UTF8.GetBytes(text), 0,text.Length);
            fs.Flush();
        }

        public void DecodeazaFisier(Node nodStart, string deDecodat, GlobalVar iesire, string temp, int nr, Node NodParinte, uint nrCaractere)
        {
            temp = deDecodat.Substring(0, nr);
            if (nrCaractere != 0)
            {      // if (nodStart == null) return;

                if (nodStart.eFrunza == true && nodStart.cod == temp)
                {
                    iesire.text += nodStart.caracter;
                    deDecodat = deDecodat.Substring(nodStart.cod.Length, deDecodat.Length - nodStart.cod.Length);
                    // nr = 1;
                    DecodeazaFisier(NodParinte, deDecodat, iesire, "", 0, NodParinte, nrCaractere - 1);


                }
                else if (deDecodat[nr] == '0')
                {

                    DecodeazaFisier(nodStart.nodStanga, deDecodat, iesire, temp, nr + 1, NodParinte, nrCaractere);

                }
                else
                {
                    DecodeazaFisier(nodStart.nodDreapta, deDecodat, iesire, temp, nr + 1, NodParinte, nrCaractere);

                }

            }

        }
        public string CitesteAntet(int a, FileStream fisier)
        {
            string returnedString = "";
            for (int i = 0; i < a; i++)
            {
                int temp = fisier.ReadByte();
                returnedString += Convert.ToString(temp, 2).PadLeft(8, '0');
            }
            return returnedString;

        }
    }
}