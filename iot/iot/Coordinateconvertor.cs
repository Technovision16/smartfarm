using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iot
{
    class Coordinateconvertor
    {
        public static string Longitude = "akshay";
        public static string Latitude = null;

        public async static void getlocation()
        {
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10)
                    );
                Longitude = geoposition.Coordinate.Point.Position.Longitude.ToString("0.00000");
                Latitude = geoposition.Coordinate.Point.Position.Latitude.ToString("0.00000");


            }
            catch (Exception ex)
            {
                Latitude = "please go back and wait for 5-10sec";
                Longitude = "please go back and wait for 5-10sec";
                if ((uint)ex.HResult == 0x80004004)
                {
                    Latitude = "please go back and wait for 5-10sec";
                    Longitude = "please go back and wait for 5-10sec";
                }
            }
            {

            }
        }
    }
}
