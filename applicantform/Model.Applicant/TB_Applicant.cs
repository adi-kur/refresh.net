namespace Model.Applicant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Applicant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        public string Contact_Number { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Date_Of_Birth { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public bool? Major { get; set; }

        [StringLength(100)]
        public string Question { get; set; }

        public bool Is_Delete { get; set; }

        [StringLength(50)]
        public string Created_By { get; set; }

        public DateTime? Created_On { get; set; }

        [StringLength(50)]
        public string Modified_By { get; set; }

        public DateTime? Modified_On { get; set; }
    }
}
