using Refactoring_using_Generics.Context;
using Refactoring_using_Generics.Entities;
using Refactoring_using_Generics.Interfaces;
using Refactoring_using_Generics.Repository;

class Program
{
    static void Main(string[] args)
    {
        using var context = new SchoolContext();
        IAsientoRepository asientoRepo = new AsientoRepository(context);

        // Crear y agregar un nuevo asiento
        Asiento nuevoAsiento = new Asiento { BusId = 11, NumeroPiso = 07, NumeroAsiento = 06, FechaCreacion = DateTime.Now };
        asientoRepo.Agregar(nuevoAsiento);

        // Traer todos los asientos
        List<Asiento> asientos = asientoRepo.TraerTodos();
        foreach (var asiento in asientos)
        {
            Console.WriteLine($"AsientoId: {asiento.AsientoId}, BusId: {asiento.BusId}, NumeroPiso: {asiento.NumeroPiso}," +
                $" NumeroAsiento: {asiento.NumeroAsiento}, FechaCreacion: {asiento.FechaCreacion}");
        }

        // Obtener un asiento por ID
        Asiento asientoObtenido = asientoRepo.ObtenerPorId(nuevoAsiento.AsientoId);
        Console.WriteLine($"Obtenido: AsientoId: {asientoObtenido.AsientoId}, BusId: {asientoObtenido.BusId}");

        // Actualizar el asiento
        asientoObtenido.NumeroAsiento = 10;
        asientoRepo.Actualizar(asientoObtenido);

        // Remover el asiento
        asientoRepo.Remover(asientoObtenido);
    }
}