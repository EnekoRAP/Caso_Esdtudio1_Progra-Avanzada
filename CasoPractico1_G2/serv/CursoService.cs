using CasoPractico1_G2.Models;

namespace CasoPractico1_G2.serv
{
    public class CursoService : ICursoService
    {
        private List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" }
        };

        public List<CursoModel> ObtenerCursos()
        {
            return cursos;
        }
    }
}
