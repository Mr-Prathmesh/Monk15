using Monk15.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monk15.Models
{
    public class UserRegistrationModel
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public string role { get; set; }
        public string remember_token { get; set; }
        public Nullable<bool> agreed_terms { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }

        public string SaveUserRegistration(UserRegistrationModel model)
        {
            string msg = "Saved Successfully";
            Monk15Entities db = new Monk15Entities();
            var data = new User()
            {
                first_name = model.first_name,
                last_name = model.last_name,
                username = model.username,
                email = model.email,
                password_hash = model.password_hash,
                role = model.role,
                agreed_terms = model.agreed_terms,

            };
            db.Users.Add(data);
            db.SaveChanges();
            return msg;


        }
    }
}