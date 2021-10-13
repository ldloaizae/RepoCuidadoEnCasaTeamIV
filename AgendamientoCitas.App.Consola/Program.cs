using System;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Consola
{
    class Program
    {
        private static IRepositorioPrestadorDeServicio _repoPrestadorDeServicio=new RepositorioPrestadorDeServicio();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPrestadorDeServicio();
            Console.WriteLine("Added");

        }
        private static void AddPrestadorDeServicio()
        {
            var prestadorDeServicio =new PrestadorDeServicio
            {
                //Id = "0001",
                RazonSocial="Prestador de servicio 1",
                Nit="52525252525-0",
                Telefono="3002152014",
                
            };
            _repoPrestadorDeServicio.AddPrestadorDeServicio(prestadorDeServicio);
        }
    }
}
