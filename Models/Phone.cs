namespace mvcbasic.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Phone
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot be more than 50 characters")]
        public string Name { get; set; }
    }
}