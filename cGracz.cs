using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
    public enum symbol { X = 1, O = 10 }

    class cGracz
    {

        string nazwa;
        int ilosc_wygranych=0;
        symbol symbol;


        public void setNazwa(string _nazwa) { nazwa = _nazwa; }
        public string getNazwa() { return nazwa; }
        public int getIlosc_wygranych() { return ilosc_wygranych; }
        public void setSymbol(symbol _symbol) { symbol = _symbol; }
        public symbol GetSymbol() { return symbol; }
        public void fIlosc_pkt_1()
        {
            ilosc_wygranych += 1;
        }

    }
}
