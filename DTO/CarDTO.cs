using System;

namespace poc_refit.DTO
{
    public struct CarDTO
    {
        public  Guid  Id { get; set; }
		public  string  Name { get; set; }
		public  string  Description { get; set; }
		public  double  Price { get; set; }
		public  int  Year { get; set; }
		public  string  Category { get; set; }
		public  DateTime  CreatedAt { get; set; }
    }
}