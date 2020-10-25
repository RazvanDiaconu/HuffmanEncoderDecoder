using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huffman
{
    class Codor
    {
        public List<Node> listaFrunze;
        internal void EncodeFromFile(string filePath)
        {
            listaFrunze = FaVectorDeFrecventa(filePath);
            ConstruiesteArbore(listaFrunze);
            GenerareCoduri(listaFrunze[0], "");
            CreazaFisierCodat(listaFrunze[0], filePath, CaleFisier(filePath));

        }
        internal void EncodeFromInputArea(string textDeCodat)
        {
            listaFrunze = FaVectorDeFrecventa2(textDeCodat);
            ConstruiesteArbore(listaFrunze);
            GenerareCoduri(listaFrunze[0], "");
            CreazaFisierCodat2(listaFrunze[0], textDeCodat, CaleFisier(Directory.GetCurrentDirectory() + "InputArea"));

        }
        public void AfisareInListBox(Node nodParinte, ListBox Lista)
        {
            if (nodParinte == null)
                return;
            if (nodParinte.nodStanga == null && nodParinte.nodDreapta == null)
            {
                Lista.Items.Add(nodParinte.caracter + "  =   " + nodParinte.cod);
                return;
            }

            AfisareInListBox(nodParinte.nodDreapta, Lista);
            AfisareInListBox(nodParinte.nodStanga, Lista);
        }
        
        private void CreazaFisierCodat(Node nodParinte, string filePath1, string filePath2)
        {
            FileStream cs = new FileStream(filePath2, FileMode.Create);
            FileStream fs = new FileStream(filePath1, FileMode.Open);
            GlobalVar a = new GlobalVar();

            string buffer = ScrieAntet(fs);

            for (int i = 0; i < buffer.Length; i += 8)
            {
                string deScris = buffer.Substring(i, 8);
                cs.WriteByte(Convert.ToByte(Convert.ToInt32(deScris, 2)));
            }

            fs.Close();

            fs = new FileStream(filePath1, FileMode.Open);
            buffer = "";
            string miniBuffer = "";

            for (int i = 0; i < fs.Length; i++)
            {
                string bytePentruCodat = Convert.ToChar(fs.ReadByte()).ToString();
                CodeazaByte(bytePentruCodat, nodParinte, a);
                buffer += a.cod;
                if (UmpleBuffer(buffer))
                {
                    miniBuffer = buffer.Substring(0, 8);
                    cs.WriteByte(Convert.ToByte(Convert.ToInt32(miniBuffer, 2)));
                    buffer = buffer.Substring(8);
                }
            }
            if (buffer != "")
            {
                cs.WriteByte(NBiti(buffer, 8));
            }
            cs.Flush();
            cs.Close();
            fs.Close();


        }

        private void CreazaFisierCodat2(Node nodParinte, string textDeCodat, string filePath2)
        {
            FileStream cs = new FileStream(filePath2, FileMode.Create);
            
            GlobalVar a = new GlobalVar();

            string buffer = ScrieAntet(textDeCodat);

            for (int i = 0; i < buffer.Length; i += 8)
            {
                string deScris = buffer.Substring(i, 8);
                cs.WriteByte(Convert.ToByte(Convert.ToInt32(deScris, 2)));
            }
            buffer = "";
            string miniBuffer = "";

            for (int i = 0; i < textDeCodat.Length; i++)
            {
                string bytePentruCodat = textDeCodat[i].ToString();
                CodeazaByte(bytePentruCodat, nodParinte, a);
                buffer += a.cod;
                if (UmpleBuffer(buffer))
                {
                    miniBuffer = buffer.Substring(0, 8);
                    cs.WriteByte(Convert.ToByte(Convert.ToInt32(miniBuffer, 2)));
                    buffer = buffer.Substring(8);
                }
            }
            if (buffer != "")
            {
                cs.WriteByte(NBiti(buffer, 8));
            }
            cs.Flush();
            cs.Close();
        }

        private byte NBiti(string intrare, int biti)
        {
            string temp = "";
            for (int i = 0; i < biti - intrare.Length; i++)
            {
                temp += "0";
            }
            intrare += temp;

            return Convert.ToByte(Convert.ToInt32(intrare, 2));
        }

        private bool UmpleBuffer(string buffer)
        {
            if (buffer.Length >= 8)
            {
                return true;
            }
            else return false;
        }

        private void CodeazaByte(string tempByte, Node node, GlobalVar variabilaGlobala)
        {

            if (node == null)
                return;
            if (node.nodStanga == null && node.nodDreapta == null)
            {
                if (tempByte == Convert.ToChar(node.caracter).ToString())
                {
                    variabilaGlobala.cod = node.cod;
                }

                return;
            }

            CodeazaByte(tempByte, node.nodDreapta, variabilaGlobala);
            CodeazaByte(tempByte, node.nodStanga, variabilaGlobala);

        }

        private string ScrieAntet(FileStream fs)
        {
            uint[] temp = new uint[256];
            string antent = "";
            for (int i = 0; i < fs.Length; i++)
            {
                int a = fs.ReadByte();
                temp[a]++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0)
                {
                    antent += "1";
                }
                else antent += "0";
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0) antent += ScriePe32(temp[i]);
            }
            fs.Close();
            return antent;
        }
        private string ScrieAntet(string fs)
        {
            uint[] temp = new uint[256];
            string antent = "";
            for (int i = 0; i < fs.Length; i++)
            {
                int a = fs[i];
                temp[a]++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0)
                {
                    antent += "1";
                }
                else antent += "0";
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != 0) antent += ScriePe32(temp[i]);
            }
            return antent;
        }
        private string ScriePe32(uint valoare)
        {
            string temp = Convert.ToString(valoare, 2);
            string returnedString = "";
            for (int i = 0; i < 32 - temp.Length; i++)
            {
                returnedString += 0;
            }
            returnedString += temp;
            return returnedString;
        }

        private string CaleFisier(string filePath)
        {

            return filePath + ".hf";
        }

        public void GenerareCoduri(Node arbore, string cod)
        {
            if (arbore == null)
            {
                return;
            }
            if (arbore.nodStanga == null && arbore.nodDreapta == null)
            {
                arbore.cod = cod;
                return;

            }
            GenerareCoduri(arbore.nodStanga, cod + "0");
            GenerareCoduri(arbore.nodDreapta, cod + "1");
        }

        public void ConstruiesteArbore(List<Node> vectorDeFrecventa)
        {
            while (vectorDeFrecventa.Count > 1)
            {
                Node nod1 = vectorDeFrecventa[0];
                vectorDeFrecventa.RemoveAt(0);
                Node nod2 = vectorDeFrecventa[0];

                vectorDeFrecventa.RemoveAt(0);
                vectorDeFrecventa.Add(new Node(nod1, nod2));
                vectorDeFrecventa.Sort();
            }
        }

        private List<Node> FaVectorDeFrecventa(string filePath)
        {
            List<Node> ListaDeNoduri = new List<Node>();
            FileStream fs = new FileStream(filePath, FileMode.Open);

            for (int i = 0; i < fs.Length; i++)
            {
                string byteCitit = Convert.ToChar(fs.ReadByte()).ToString();//
                if (ListaDeNoduri.Exists(x => x.caracter == byteCitit))
                {
                    int index = ListaDeNoduri.FindIndex(x => x.caracter == byteCitit);
                    ListaDeNoduri[index].frecventa++;
                }
                else
                {
                    ListaDeNoduri.Add(new Node(byteCitit));
                }

            }
            fs.Close();
            ListaDeNoduri.Sort();
            return ListaDeNoduri;
        }
        private List<Node>FaVectorDeFrecventa2(string textDeCodat)
        {
            List<Node> ListaDeNoduri = new List<Node>();
            for (int i = 0; i < textDeCodat.Length; i++)
            {
                
                if (ListaDeNoduri.Exists(x => x.caracter == textDeCodat[i].ToString()))
                {
                    int index = ListaDeNoduri.FindIndex(x => x.caracter == textDeCodat[i].ToString());
                    ListaDeNoduri[index].frecventa++;
                }
                else
                {
                    ListaDeNoduri.Add(new Node(textDeCodat[i].ToString()));
                }

            }
            ListaDeNoduri.Sort();
            return ListaDeNoduri;
        }
    }
}
