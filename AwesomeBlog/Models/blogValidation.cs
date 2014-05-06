using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AwesomeBlog.Models
{
    [MetadataType(typeof(PostMetadata))]
    public partial class Post
    {
        
    }
    public class PostMetadata
    {
        [Required(ErrorMessage="Title required"), Display(Name="Title")]
        public string title;

        [Required(ErrorMessage="Date required"), Display(Name="Date")]
        public DateTime date;

        [Required(ErrorMessage="Your name required"), Display(Name="Author")]
        public string author;

        [Display(Name="Likes")]
        public int likes;

        [Display(Name="Dislikes")]
        public int dislikes;

        [Display(Name="Views")]
        public int views;

        [Display(Name="Picture")]
        public string picture;

        [Required(ErrorMessage="Text required"), Display(Name="Body")]
        public string body;


    }


}