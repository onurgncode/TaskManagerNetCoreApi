using StaticKimlikKarti.Models;
using StaticKimlikKarti.Repostiory;

namespace TaskUI.Repostiory
{
    public class RaporYonet
    {
        private readonly GorevYonet _gorevs;

        public RaporYonet(GorevYonet gorevs)
        {
            _gorevs = gorevs;
        }

        public List<Gorev> DayList()
        {
            return _gorevs.GetAll().Where(i => i.olusturulma.Date == DateTime.Today).ToList();
        }
        public List<Gorev> WeeklyList()
        {
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            return _gorevs.GetAll().Where(i => i.olusturulma.Date >= startOfWeek).ToList();
        }
        public List<Gorev> MonthlyList()
        {
            DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            return _gorevs.GetAll().Where(i => i.olusturulma.Date >= startOfMonth).ToList();
        }
    }
}
                                                                                           