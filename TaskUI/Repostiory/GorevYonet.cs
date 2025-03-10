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

        public void Delete(int Id)
        {
            Gorev deleted = _contextDb.gorev.FirstOrDefault(gorev => gorev.id == Id);
            _contextDb.gorev.Remove(deleted);
            _contextDb.SaveChanges();
            
        }

        public void Complate(bool veri, int Id)
        {
                Gorev Tamamlandi = _contextDb.gorev.FirstOrDefault(x => x.id == Id);
                Tamamlandi.tamamlandi = veri;
                _contextDb.gorev.Update(Tamamlandi);
                _contextDb.SaveChanges();
            
           
        }
    }
}
