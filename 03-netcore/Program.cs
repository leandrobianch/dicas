using BibliotecaEmNetStandard;
namespace CamadaUsuarioNetCore
{
    class Program
    {
        static void Main(string[] args)
        {            
            Email email = new Email("smtp@dominio.com.br", "usuario.sistema", "senha.usuario.sistema");
            
            email.Enviar("naoresponda", "enviamos um link para recuração de sua senha, teste feito pelo .NET CORE 3.1");
        }
    }
}
