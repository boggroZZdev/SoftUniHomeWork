using System;
using System.ComponentModel.DataAnnotations;

namespace TrainSystem.Models
{
    public class Trip
    {

        [Key]
        public int Id { get; set; }

        [Microsoft.Build.Framework.Required]
        [MinLenght(1)]
        public string Origin { get; set; }
        [Microsoft.Build.Framework.Required]
        [MinLenght(1)]
        public string Destination { get; set; }

        public int Business { get; set; }
        public int Economy { get; set; }

    }

    public class MinLenghtAttribute : Attribute
    {
        public MinLenghtAttribute(int i)
        {
            throw new NotImplementedException();
        }
    }
}