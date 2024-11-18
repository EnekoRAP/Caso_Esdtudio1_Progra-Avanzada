namespace CasoPractico1_G2.Models
{
    public class EstudianteModel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public int CursoId { get; set; }

        // Relación con Curso
        public CursoModel? Curso { get; set; } // Propiedad de navegación

    }
}
