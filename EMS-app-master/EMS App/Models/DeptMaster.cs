using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS_App.Models
{
    [Table("Department")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set;}
        public virtual ICollection<EmpProfile>? EmpProfiles { get; set; }
    }
}
