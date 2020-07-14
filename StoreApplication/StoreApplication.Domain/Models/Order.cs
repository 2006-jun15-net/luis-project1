using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreApplication.Domain.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }


        //public ApplicationUser applicationUser { get; set; }


        [Required(ErrorMessage = "Please Enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2,MinimumLength =2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        [StringLength(5, MinimumLength = 5)]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

        public Order()
        {

        }

        public Order(int orderId, string firstName, string lastName, DateTime orderPlaced, List<OrderDetail> orderDetails, decimal orderTotal)
        {
            OrderId = orderId;
            FirstName = firstName;
            LastName = lastName;
            OrderPlaced = orderPlaced;
            OrderDetails = orderDetails;
            OrderTotal = orderTotal;
        }

        //public Order(int orderId, DateTime orderPlaced, ApplicationUser applicationUser, decimal orderTotal)
        //{
        //    OrderId = orderId;
        //    OrderPlaced = orderPlaced;
        //    //this.applicationUser = applicationUser;
        //    OrderTotal = orderTotal;
        //}
    }
}
