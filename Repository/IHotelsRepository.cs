using ModelViewController.Models;

namespace ModelViewController.Repository
{
	public interface IHotelsRepository
	{
		Booknow Add(Booknow booknow);
		Booknow Update(Booknow booknow);
		Booknow Delete(int amount);
		Booknow GetHotelsById(int amount);

		void Save();
		IEnumerable<Booknow> GetAllHotels();
		
	}
}
