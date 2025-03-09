using StaticKimlikKarti.Models;

namespace StaticKimlikKarti.Repostiory
{
    public class GorevYonet
    {
        private readonly AppContextDb _contextDb;

        public GorevYonet(AppContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public List<Gorev> GetAll()
        {
            var listele = _contextDb.gorev.ToList();
            return listele;
        }

        public Gorev Add(Gorev gorev)
        {
            _contextDb.gorev.Add(gorev);
            _contextDb.SaveChanges();
            return gorev;
        }
    }
}
