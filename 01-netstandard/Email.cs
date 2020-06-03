using System;

namespace BibliotecaEmNetStandard
{
    public class Email
    {
        public string HostSmtp { get; private set; }

        public string Usuario { get; private set; }

        public string Senha { get; private set; }

        public string Remetente { get; private set; }

        public string Corpo { get; private set; }

        public Email(string hostSmtp, string usuario, string senha)
        {
            HostSmtp = hostSmtp;
            Usuario = usuario;
            Senha = senha;
        }

        public void Enviar(string remetente, string corpo)
        {
            Remetente = remetente;

            Corpo = corpo;

            Console.WriteLine("Email enviado com sucesso!");
            Console.WriteLine($"remetente {Remetente} {Corpo}");
        }
    }
}
