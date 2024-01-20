using System;
using System.Speech.Synthesis;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");

            // Reproduzir o arquivo de áudio ao ligar
            ReproduzirAudio("Piririm Piririm Piririm Alguem ligou pra mim Quem é?");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        // Método para reproduzir um arquivo de áudio
        private void ReproduzirAudio(string Audio)
        {
            try
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer()) // metodo da biblioteca instanciada
                {
                    synth.SetOutputToDefaultAudioDevice();
                    synth.Speak($"{Audio}");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao reproduzir áudio: {ex.Message}");
            }
        }
    }
}