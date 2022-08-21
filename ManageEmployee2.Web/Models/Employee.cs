using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageEmployee2.Web.Models
{
    [MetadataType(typeof(tblEmployeeMetaData))]
    public partial class tblEmployee
    {

    }
    public class tblEmployeeMetaData
    {
        [DisplayName("Employee Name")]
        public string Name { get; set; }
    }
}