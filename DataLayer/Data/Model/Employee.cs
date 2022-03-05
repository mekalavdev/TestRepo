using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Data.Model
{
    [Table("Employee", Schema = "dbo")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee Id")]
        public int EmpId { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        [ForeignKey("DesignationInfo")]
        [Required]
        public int DesignationId { get; set; }

        public virtual Designation DesignationInfo { get; set; }
    }
}
