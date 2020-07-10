using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [Display(Name = "姓名")]
    public string Name { get; set; }

    [Display(Name = "性別")]
    public GenderType Gender { get; set; }
  }
}