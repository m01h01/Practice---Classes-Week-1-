using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Classes__Week_1_
{
    internal class House
    {
        string _type; 
        string _yearbuilt;
        string _bedrooms;
        string _bathrooms;
        int _sqareft;
        string _mlsNumber; //listing number for selling house

        public House(string type, string year, string bedrooms, string bathrooms, int sqareft)
        {
            _type = type;
            _yearbuilt = year;
            _bedrooms = bedrooms;
            _bathrooms = bathrooms;
            _sqareft = sqareft;

            Random random= new Random();
            int num = random.Next(1000000, 10000000);
            _mlsNumber = num.ToString();
            
        }

        public string Type { get => _type; set => _type = value; }
        public string Year { get => _yearbuilt; set => _yearbuilt = value; }
        public string Bedrooms { get => _bedrooms; set => _bedrooms = value; }
        public string Bathrooms { get => _bathrooms; set => _bathrooms = value; }
        public int Sqareft { get => _sqareft; set => _sqareft = value; }
        public string MlsNumber { get => _mlsNumber; /*set => _mlsNumber = value;*/ }

        public override string ToString()
        {
            return $"Listing House for sell: MLS# :{_mlsNumber}, {_type}, {_yearbuilt}, {_bedrooms} Bedrooms, " +
                $"{_bathrooms} Bathrooms, {_sqareft} Sq Ft";
        }
    }
}
