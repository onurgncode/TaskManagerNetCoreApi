using StaticKimlikKarti.Models;

namespace TaskUI.Repostiory
{
    public interface IGorevYonet
    {
        public List<Gorev> GetAll();
        public Gorev Add(Gorev gorev);
        public void Delete(int Id);
    }
}
