using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevMediaMigracao.Domain.Model;
using DevMediaMigracao.Infraestrutura.Data;


namespace DevMediaMigracao
{
    class Program
    {
        static void Main(string[] args)
        {                        

            try
            {   
                LojaContext loja = new LojaContext();                

                loja.Produtos.Add(new Produtos
                {
                    Id = 103,
                    Nome = "Borracha Mercurio",
                    Preco = (decimal)1.50,                    
                    DataCompra = DateTime.Now,
                    Marca = "Bic"
                });

                loja.SaveChanges();

                
                loja.Clientes.Add(new Cliente
                {
                    Id = 103,
                    Nome = "João Ribeiro",
                    TelefoneContato = "21 99999-9999",
                    Email = "joao@gmail.com"
                });
                

                var cliente = new Cliente
                {
                    Id = 999,
                    Nome = "Carlos",
                    Email = "cadu.vieira@gmail.com",
                    TelefoneContato = "21 99999-9999"
                };

                Console.WriteLine(cliente.ToString().ToUpper());
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

            finally
            {
                Console.WriteLine("Cadastro realizado com sucesso");
            }

            
            
        }
    }
}
