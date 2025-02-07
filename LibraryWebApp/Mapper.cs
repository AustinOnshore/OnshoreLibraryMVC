﻿using ConsoleLibrary.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApp.Models;
using LibraryCommon;

namespace LibraryWebApp.Mapping
{
    public class Mapper
    {
        internal static List<AuthorModel> AuthorListToAuthorModelList(List<Author> list)
        {
            //throw new NotImplementedException();

            List<AuthorModel> _returnedList = new List<AuthorModel>();


            foreach(Author item in list)
            {

                AuthorModel m = new AuthorModel();

                m.FirstName = item.FirstName;
                m.LastName = item.LastName;
                m.AuthorID = item.AuthorID;
                m.Bio = item.Bio;
                m.BirthLocation = item.BirthLocation;
                m.DateOfBirth = item.DateOfBirth;

                _returnedList.Add(m);


            }
            return _returnedList;
            
            // List of Authors from common layer 

        }

        public List<RoleModel> RoleListToRoleModels(List<Role> list)
        {
            List<RoleModel> toReturn = new List<RoleModel>();


            foreach (Role role in list)
            {
                RoleModel newModel = new RoleModel();
                newModel.RoleID = role.RoleID;
                newModel.RoleName = role.RoleName;

                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<UserModel> UserListToUserModels(List<User> list)
        {
            List<UserModel> toReturn = new List<UserModel>();


            foreach (User user in list)
            {
                UserModel newModel = new UserModel();

                newModel.UserID = user.UserID;
                newModel.FirstName = user.FirstName;
                newModel.LastName = user.LastName;
                newModel.UserName = user.UserName;
                newModel.Password = user.Password;
                newModel.RoleID_FK = user.RoleID_FK;
                newModel.Salt = user.Salt;

                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal static UserModel UserToUserModel(User user)
        {
            UserModel _userModel = new UserModel();

            _userModel.FirstName = user.FirstName;
            _userModel.LastName = user.LastName;
            _userModel.Password = user.Password;
            _userModel.RoleID_FK = user.RoleID_FK;
            _userModel.RoleName = Mapper.RoleIdToRoleName(user.RoleID_FK);
            _userModel.UserID = user.UserID;
            _userModel.UserName = user.UserName;

            return _userModel;
        }

        private static string RoleIdToRoleName(int inRoleId)
        {
            switch (inRoleId)
            {
                case 1:
                    return RoleType.Administrator.ToString();
                case 2:
                    return RoleType.Librarian.ToString();
                case 3:
                    return RoleType.Patron.ToString();
                default:
                    return RoleType.Anonymous.ToString();
            }
        }

        internal List<BookModel> BookListToBookModels(List<Book> list)
        {
            List<BookModel> toReturn = new List<BookModel>();

            foreach (Book book in list)
            {
                BookModel newModel = new BookModel();

                newModel.BookID = book.BookID;
                newModel.Title = book.Title;
                newModel.Description = book.Description;
                newModel.Price = book.Price;
                newModel.IsPaperback = book.IsPaperback;
                newModel.PublishDate = book.PublishDate;
                newModel.AuthorID_FK = book.AuthorID_FK;
                newModel.GenreID_FK = book.GenreID_FK;
                newModel.PublisherID_FK = book.PublisherID_FK;

                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<AuthorModel> AuthorListToAuthorModels(List<Author> list)
        {
            List<AuthorModel> toReturn = new List<AuthorModel>();


            foreach (Author author in list)
            {
                AuthorModel newModel = new AuthorModel();

                newModel.AuthorID = author.AuthorID;
                newModel.FirstName = author.FirstName;
                newModel.LastName = author.LastName;
                newModel.Bio = author.Bio;
                newModel.BirthLocation = author.BirthLocation;
                newModel.DateOfBirth = author.DateOfBirth;


                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<GenreModel> GenreListToGenreModels(List<Genre> list)
        {
            List<GenreModel> toReturn = new List<GenreModel>();


            foreach (Genre genre in list)
            {
                GenreModel newModel = new GenreModel();

                newModel.GenreID = genre.GenreID;
                newModel.Name = genre.Name;
                newModel.Description = genre.Description;
                newModel.IsFiction = genre.IsFiction;


                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<PublisherModel> PublisherListToPublisherModels(List<Publisher> list)
        {
            List<PublisherModel> toReturn = new List<PublisherModel>();


            foreach (Publisher publisher in list)
            {
                PublisherModel newModel = new PublisherModel();

                newModel.PublisherID = publisher.PublisherID;
                newModel.Name = publisher.Name;
                newModel.Address = publisher.Address;
                newModel.City = publisher.City;
                newModel.State = publisher.State;
                newModel.Zip = publisher.Zip;

                toReturn.Add(newModel);
            }

            return toReturn;
        }


    }
}