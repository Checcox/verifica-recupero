using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EsercizioVerificaRecuperoGit
{
    internal class Alunno
    {
        List<Alunno> Alunni = new List<Alunno>();
        public string nome;
        public string cognome;
        public int eta;
        public string cittaDiResidenza;


        private void addAlunno(string nOme, string CoGnome, int etA, string CittADiResidenza)
        {
            Alunno alunno = new Alunno();
            Alunni.Add(alunno);
        }



        private void setNome(string Nome)
        {
            nome = Nome;
        }

        private void setCognome(string Cognome)
        {
            cognome = Cognome;
        }

        private void setEta(int Eta)
        {
            eta = Eta;
        }

        private void setCittaresidenza(string CittaresiDenza)
        {
            cittaDiResidenza = CittaresiDenza;
        }

        private void toString()
        {
            MessageBox.Show("nome: " + nome + "\n" + "cognome: " + cognome + "\n" + "età: " + eta + "\n" + "Città di residenza: " + cittaDiResidenza);
        }

        private string BiennioOTriennio(int posizione)
        {
            if (Alunni[posizione].eta < 16)
            {
                return "Biennio";
            }
            else
            {
                return "Triennio";
            }
        }        
    }
}
