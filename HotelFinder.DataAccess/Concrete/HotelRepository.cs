using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                hoteldbcontext.hotels.Add(hotel);
                hoteldbcontext.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                var deletehotel = GetHotelById(id);
                hoteldbcontext.hotels.Remove(deletehotel);
                hoteldbcontext.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using (var hoteldbcontext=new HotelDbContext())
            {
                return hoteldbcontext.hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                return hoteldbcontext.hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hoteldbcontext = new HotelDbContext())
            {
                hoteldbcontext.hotels.Update(hotel);
                hoteldbcontext.SaveChanges();
                return hotel;
            }
        }
    }
}
