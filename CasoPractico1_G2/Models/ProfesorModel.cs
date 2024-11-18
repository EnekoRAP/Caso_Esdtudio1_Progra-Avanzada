namespace CasoPractico1_G2.Models
{
    public class ProfesorModel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public int CursoId { get; set; }

        // Relación con Curso
        public CursoModel? Curso { get; set; }  // Relación con el curso
    }
}
