using System;

namespace Huffman
{
    public class Node : IComparable<Node>
    {
        public uint frecventa;
        public string caracter;
        public string cod = "";
        public Node nodParinte, nodStanga, nodDreapta;
        public bool eFrunza;
        public Node(string caracter)
        {
            this.caracter = caracter;
            frecventa = 1;
            nodParinte = nodStanga = nodDreapta =  null;
            eFrunza = true;
        }
        public Node(Node nod1, Node nod2)
        {
            eFrunza = false;
            nodParinte = null;
                caracter = nod1.caracter + nod2.caracter;
                frecventa = nod1.frecventa + nod2.frecventa;
                nodDreapta = nod2;
                nodStanga = nod1;
                nodStanga.nodParinte = nodDreapta.nodParinte = this;
            
        }
        public int CompareTo(Node other)
        {
            if (this.frecventa == other.frecventa)
            {
                return this.caracter.CompareTo(other.caracter);
            }
            return this.frecventa.CompareTo(other.frecventa);
        }
    }
}