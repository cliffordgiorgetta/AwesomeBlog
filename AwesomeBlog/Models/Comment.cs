//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwesomeBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int commentID { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public string body { get; set; }
        public string author { get; set; }
        public System.DateTime date { get; set; }
        public int PostID { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
