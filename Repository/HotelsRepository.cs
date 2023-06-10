using ModelViewController.Context;
using ModelViewController.Models;

namespace ModelViewController.Repository
{
	public class HotelsRepository : IHotelsRepository
	{
		private List<Booknow> booknows;
		private readonly BooknowDbContext context;
		public HotelsRepository(BooknowDbContext booknowDbContext)

        {
			context=booknowDbContext;
			//booknows = new List<Booknow>()
			//{
			//	new Booknow{ hotelname="ks hotel",amount=3000},
			//	new Booknow{ hotelname="abc hotel",amount=5000}
			//};
        }
        public Booknow Add(Booknow booknow)
		{
			context.Booknows.Add(booknow);
			context.SaveChanges();
			return booknow;
		}

		public Booknow Delete(int amount)
		{
			Booknow todelete = context.Booknows.Find(amount);
			if (todelete != null) 
			{
				context.Booknows.Remove(todelete);
				context.SaveChanges();
			}
			return todelete;

		}

		public IEnumerable<Booknow> GetAllHotels()
		{
			return context.Booknows.ToList();
		}

		public Booknow GetHotelsById(int amount)
		{
			return context.Booknows.Find(amount);
		}

		public void Save() 
		{
			context.SaveChanges();
		}
		public Booknow Update(Booknow modifydetails)
		{
			context.Update(modifydetails);
			context.SaveChanges();
			return modifydetails;
		}
		private bool _dispose = false;
		public virtual void Dispose(bool disposing) 
		{
			if(!this._dispose)
			{
				if(disposing)
				{
					context.Dispose();
				}
			}
			this._dispose = true;
		}
		void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
