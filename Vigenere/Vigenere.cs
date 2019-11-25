using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Vigenere
{
    class Resultado
    {
        public int Score = 0;
        public string Chave = "";
        public string Texto = "";
        public List<string> palavrasEncontradas = new List<string>();
    }
    class Vigenere
    {
        string[] inglesPalavras_List;
        string[] portuguesPalavras_List;


        public void CarregarPalavrasPortugues()
        {
            portuguesPalavras_List = File.ReadAllLines(@"BancoPalavras3Letras.txt");
        }

        public void CarregarPalavrasIngles()
        {
            inglesPalavras_List = File.ReadAllLines(@"BancoPalavrasIngles.txt");
        }

        private string gerarChaveTamanhoTexto(string str, string key)
        {
            int offset = 0;
            int tamanhoChave = key.Length;
            string resultado = "";

            for (int i = 0; i < str.Length; i++)
            {

                if (CaractereNaoPermitido(str[i]))
                {
                    resultado += str[i].ToString();
                    continue;
                }

                resultado += key[offset];
                offset++;

                if (offset >= tamanhoChave)
                    offset = 0;
            }

            return resultado;
        }

        public List<string> DescriptografarSemChave(string text)
        {
            List<Resultado> resultados = new List<Resultado>();
            List<string> retornar = new List<string>();

            foreach (string palavra in portuguesPalavras_List)
            {
                string descript = Descriptografar(text, palavra);
                List<string> palEncontradas = new List<string>();
                int score = buscarPalavrasEmIngles(descript, ref palEncontradas);

                if (score > 0)
                {
                    Resultado r = new Resultado();
                    r.Chave = palavra;
                    r.Score = score;
                    r.Texto = descript;
                    r.palavrasEncontradas = palEncontradas;
                    resultados.Add(r);
                }
            }

            resultados = resultados.OrderBy(r => r.Score).ToList();
            resultados.Reverse();

            foreach (var resutado in resultados)
            {
                string palavrasEncontradas = "";
                foreach (var palavra in resutado.palavrasEncontradas)
                {
                    palavrasEncontradas += palavra + ", ";
                }

                retornar.Add(Environment.NewLine + Environment.NewLine +
                    "Chave: " + resutado.Chave + Environment.NewLine +
                    "Score: " + resutado.Score.ToString() + Environment.NewLine +
                    "Palavras Encontradas: " + palavrasEncontradas + Environment.NewLine + Environment.NewLine +
                    resutado.Texto
                    );
            }

            return retornar;
        }

        private int buscarPalavrasEmIngles(string text, ref List<string> palEncontradas)
        {
            int qntEncontrado = 0;
            bool palavraEncontrada = false;
            foreach (var palavra in text.Split(' '))
            {
                foreach (var word in inglesPalavras_List)
                {
                    if (palavra.Equals(word.ToUpper()))
                    {
                        qntEncontrado += word.Length;

                        foreach (var pal in palEncontradas)
                        {
                            if (pal == word)
                                palavraEncontrada = true;

                        }
                        
                        if (!palavraEncontrada)
                            palEncontradas.Add(word);

                        palavraEncontrada = false;
                    }
                }
            }
            

            return qntEncontrado;
        }

        public string Criptografar(string str, string password)
        {
            string key = gerarChaveTamanhoTexto(str, password);
            string cipher_text = "";

            for (int i = 0; i < str.Length; i++)
            {
                // converting in range 0-25 
                int x = (str[i] + key[i]) % 26;

                // convert into alphabets(ASCII) 
                x += 'A';

                cipher_text += (char)(x);
            }
            return cipher_text;
        }

        // This function decrypts the encrypted text 
        // and returns the original text 
        public string Descriptografar(string cipher_text, string password)
        {
            password = password.ToUpper();
            cipher_text = cipher_text.ToUpper();
            string orig_text = "";
            string key = gerarChaveTamanhoTexto(cipher_text, password);

            for (int i = 0; i < cipher_text.Length && i < key.Length; i++)
            {

                if (CaractereNaoPermitido(cipher_text[i]))
                {
                    orig_text += cipher_text[i].ToString();
                    continue;
                }

                // converting in range 0-25 
                int x = (cipher_text[i] - key[i] + 26) % 26;

                // convert into alphabets(ASCII) 
                x += 'A';
                orig_text += (char)(x);
            }
            return orig_text;
        }

        private bool CaractereNaoPermitido(char caract)
        {
            return " ()#$%&*+={}[]_-,.!?<>:;'\"\\0123456789".Contains(caract.ToString());
        }

    }

}


