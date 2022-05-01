namespace Filme_Locadora.DataAccess
{
    public static class DbFilmes
    {
        public static void Incluir(Tbfilmes filme)
        {
            using (var ctx = new VIDEO_LOCADORAContext())
            {
                ctx.Tbfilmes.Add(filme);
                ctx.SaveChanges();
            }
        }
        public static Tbfilmes Buscar(int id)
        {
            using (var ctx = new VIDEO_LOCADORAContext())
            {
                return ctx.Tbfilmes.FirstOrDefault(p => p.Id == id);
            }
        }
        public static IEnumerable<Tbcategorias> ListarCategorias()
        {
            using (var ctx = new VIDEO_LOCADORAContext())
            {
                return ctx.Tbcategorias.ToList();
            }
        }

        public static IEnumerable<Tbfilmes> Listar()
        {
            using (var ctx = new VIDEO_LOCADORAContext())
            {
                return ctx.Tbfilmes.ToList();
            }
        }
    }


}
