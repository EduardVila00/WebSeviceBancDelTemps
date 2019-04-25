using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Antlr.Runtime.Misc;
using Microsoft.Ajax.Utilities;

namespace WebSeviceBancDelTemps.Models.Repositoris
{
    public class PostsRepository
    {
        private static BancDelTempsEntities db = new BancDelTempsEntities();


        public static List<Post> GetAllPosts()
        {
            var llistaPosts = db.Posts.Where(x => x.active).ToList();
            return llistaPosts;
        }
        public static Posts GetAllPostsAndroid()
        {
            var llistaPosts = new Posts(db.Posts.Where(x => x.active).ToList());
            return llistaPosts;
        }

        public static List<Post> GetPostsByCategory(int idCategory)
        {
            var llistaPosts = db.Posts.Where(x => x.Category_Id_Category == idCategory && x.active).ToList();
            return llistaPosts;
        }

        public static List<Post> GetPostsByDateCreated(string date)
        {

            var llistaPosts = db.Posts.Where(x => (x.date_created) == date && x.active).ToList();
            return llistaPosts;
        }

        public static List<Post> GetPostsByDateFinished(string date)
        {
            var llistaPosts = db.Posts.Where(x => x.date_finished == date && x.active).ToList();
            return llistaPosts;
        }

        public static List<Post> GetPostsByLocation(string location)
        {
            var llistaPosts = db.Posts.Where(x => x.location.Contains(location) && x.active).ToList();
            return llistaPosts;
        }

        public static List<Post> GetPostsByTitle(string title)
        {
            var llistaPosts = db.Posts.Where(x => x.title.Contains(title) && x.active).ToList();
            return llistaPosts;
        }
        public static Posts GetPostsByTitleAnd(string title)
        {
            var llistaPosts =new Posts(db.Posts.Where(x => x.title.Contains(title) && x.active).ToList());
            return llistaPosts;
        }

        public static List<Post> GetPostsByUser(string filtre)
        {
            var llistaPosts = db.Posts.Where(x => x.User.name.Contains(filtre) && x.active).ToList();
            return llistaPosts;
        }

        public static Post GetSinglePost(int id)
        {

            var post = db.Posts.SingleOrDefault(x => x.Id_Post == id);
            return post;
        }

        public static Post InsertPost(Post post)
        {
            try
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return GetSinglePost(post.Id_Post);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static Post UpdatePost(int id, Post post)
        {
            try
            {
                var u0 = db.Posts.SingleOrDefault(x => x.Id_Post == id);
                if (u0 == null) return null;
                u0.date_created = post.date_created;
                u0.date_finished = post.date_finished;
                u0.description = post.description;
                u0.location = post.location;
                u0.title = post.title;
                u0.active = post.active;
                u0.UserId_User = post.UserId_User;
                u0.Category_Id_Category = post.Category_Id_Category;
                db.SaveChanges();
                return GetSinglePost(u0.Id_Post);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeletePost(int id)
        {
            //var u = db.Posts.SingleOrDefault(x => x.Id_Post == id);
            //if (u == null) return;
            //db.Posts.Remove(u);
            //db.SaveChanges();
            var u = db.Posts.SingleOrDefault(x => x.Id_Post == id);
            u.active = false;
            db.SaveChanges();

        }
    }
}