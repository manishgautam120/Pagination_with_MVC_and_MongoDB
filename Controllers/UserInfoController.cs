using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson; //all line added extra
using System.Configuration;
using MongoDB.Driver.Core;
using Pagination_with_MVC_and_MongoDB.App_Start;     //for handling  error and including this page as start coz controller is everything manage
using MongoDB.Driver;
using Pagination_with_MVC_and_MongoDB.Models;
using PagedList;
using PagedList.Mvc;

namespace Pagination_with_MVC_and_MongoDB.Controllers
{
    public class UserInfoController : Controller
    {

        private MongoDBContext dbcontext;                                       //extra added
        private IMongoCollection<UserInfo> userInfoCollection;                //extra added


        public UserInfoController()
        {
            dbcontext = new MongoDBContext();
            userInfoCollection = dbcontext.database.GetCollection<UserInfo>("userinfo"); //we are getting collection //product is collection name
        }

        // GET: UserInfo before adding pagination
        //public ActionResult Index()
        //{
        //   
        //    // List<UserInfo> user = userInfoCollection.AsQueryable<UserInfo>().ToList();//before adding pagination
        //    List<UserInfo> user = userInfoCollection.AsQueryable<UserInfo>().ToList();
        //    return View(user);

        //}
        public ActionResult Index(int ? page)     //after adding pagination
        {
            var pageNumber = page ?? 1;
            var pageSize = 10;
            var  users = userInfoCollection.AsQueryable<UserInfo>().OrderBy(x=> x.Name).ToPagedList(pageNumber,pageSize);
            return View(users);

        }

    }
}
