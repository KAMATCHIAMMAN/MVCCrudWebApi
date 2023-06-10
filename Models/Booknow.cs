using System.ComponentModel.DataAnnotations;

namespace ModelViewController.Models
{
    public class Booknow
    {
        
      
        public string hotelname { get; set; }
		[Key]

		public int amount { get; set; }

		internal Booknow Add(Booknow booknow)
		{
			throw new NotImplementedException();
		}
	}
}
