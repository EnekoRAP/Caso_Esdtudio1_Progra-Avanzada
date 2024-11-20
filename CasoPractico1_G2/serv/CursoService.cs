using CasoPractico1_G2.Models;

namespace CasoPractico1_G2.serv
{
    public class CursoService : ICursoService
    {
        private List<CursoModel> cursos = new List<CursoModel>
        {
            new CursoModel { Cod_Curso = 1, Nombre = "Matemáticas", Descripcion = "Curso básico de álgebra y geometría" },
            new CursoModel { Cod_Curso = 2, Nombre = "Ciencias", Descripcion = "Curso de física y química básica" },
            new CursoModel { Cod_Curso = 3, Nombre = "Programación I", Descripcion = "Introducción a la programación con Java y C++" },
            new CursoModel { Cod_Curso = 4, Nombre = "Estructuras de Datos", Descripcion = "Estudio de estructuras de datos como listas, pilas, colas y árboles" },
            new CursoModel { Cod_Curso = 5, Nombre = "Sistemas Operativos", Descripcion = "Fundamentos de sistemas operativos, administración de procesos y memoria" },
            new CursoModel { Cod_Curso = 6, Nombre = "Bases de Datos", Descripcion = "Diseño, implementación y gestión de bases de datos relacionales" },
            new CursoModel { Cod_Curso = 7, Nombre = "Redes de Computadoras", Descripcion = "Estudio de redes, protocolos, y comunicaciones entre computadoras" },
            new CursoModel { Cod_Curso = 8, Nombre = "Desarrollo Web", Descripcion = "Tecnologías y frameworks para el desarrollo de aplicaciones web" },
            new CursoModel { Cod_Curso = 9, Nombre = "Algoritmos", Descripcion = "Teoría y práctica de algoritmos para la resolución de problemas computacionales" },
            new CursoModel { Cod_Curso = 10, Nombre = "Ingeniería de Software", Descripcion = "Principios de desarrollo de software, análisis y diseño de sistemas" },
            new CursoModel { Cod_Curso = 11, Nombre = "Inteligencia Artificial", Descripcion = "Fundamentos de inteligencia artificial, aprendizaje automático y redes neuronales" },
            new CursoModel { Cod_Curso = 12, Nombre = "Seguridad Informática", Descripcion = "Estudio de la seguridad en sistemas informáticos, cifrado y protección de datos" }
        };

        public List<CursoModel> ObtenerCursos()
        {
            return cursos;
        }
    }
}
