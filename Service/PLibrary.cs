using Models.DTOs;
using Models.Request;
using Models.Response;
using Persistence.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PLibrary : ILibrary
    {
        private readonly BookShopContext _appDbContext;

        public PLibrary(BookShopContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Object InsertBook(RqBook rqBook)
        {
            try
            {
                if (rqBook != null)
                {
                    Book book = new Book
                    {
                        Title = rqBook.TITLE,
                        Year = rqBook.YEAR,
                        Genre = rqBook.GENRE,
                        Numberpages = rqBook.NUMBER_PAGES,
                        Idpublisher = rqBook.ID_PUBLISHER,
                        Idauthor = rqBook.ID_AUTHOR,
                        Status = true
                    };
                    using (_appDbContext)
                    {
                        Author author = _appDbContext.Authors.Where(x => x.IdAuthor == book.Idauthor).FirstOrDefault();
                        Publisher publisher = _appDbContext.Publishers.Where(x => x.IdPublisher == book.Idpublisher).FirstOrDefault();
                        if (author is not null)
                        {
                            if (publisher is not null)
                            {
                                if (publisher.MaxBooksReg < 0 || (publisher.MaxBooksReg > 0 && publisher.BooksRegCount < publisher.MaxBooksReg))
                                {
                                    _appDbContext.Books.Add(book);
                                    publisher.BooksRegCount++;
                                    _appDbContext.SaveChanges();
                                    //Response 200 OK
                                    return new GenericResponse<DTO_BOOK>
                                    {
                                        Data = new DTO_BOOK
                                        {
                                            Title = book.Title,
                                            Year = book.Year,
                                            Genre = book.Genre,
                                            NumberPages = book.Numberpages,
                                            IdPublisher = book.Idpublisher,
                                            IdAuthor = book.Idauthor
                                        },
                                        Notification = new Notification
                                        {
                                            Code = ((int)System.Net.HttpStatusCode.OK).ToString(),
                                            Message = "OK",
                                            Description = "OK - Success",
                                            Timestamp = DateTime.Now.ToUniversalTime()
                                        }
                                    };
                                }
                                else
                                {   //Response 404 
                                    EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error404;
                                    emptyDataResponse.Notification.Description = "No es posible registrar el libro, se alcanzó el máximo permitido";
                                    emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                                    return emptyDataResponse;
                                }
                            }
                            else
                            {   //Response 404 
                                EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error404;
                                emptyDataResponse.Notification.Description = "La editorial no está registrada";
                                emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                                return emptyDataResponse;
                            }
                        }
                        else
                        {   //Response 404 
                            EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error404;
                            emptyDataResponse.Notification.Description = "El autor no está registrado";
                            emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                            return emptyDataResponse;
                        }
                    }
                }
                else
                {   //Response 400 
                    EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error400;
                    emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                    return emptyDataResponse;
                }
            }
            catch (Exception e)
            {    //Response 500 
                EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error500;
                emptyDataResponse.Notification.Message = e.Message;
                emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                return emptyDataResponse;
            }
        }
        public Object InsertAuthor(RqAuthor rqAuthor)
        {
            try
            {
                if (rqAuthor != null)
                {
                    Author author = new Author
                    {
                        Name1 = rqAuthor.Name1,
                        Name2 = rqAuthor.Name2,
                        Lastname1 = rqAuthor.Lastname1,
                        Lastname2 = rqAuthor.Lastname2,
                        DateBirth = rqAuthor.DateBirth,
                        Hometown = rqAuthor.Hometown,
                        Email = rqAuthor.Email,
                        Status = true
                    };
                    using (_appDbContext)
                    {
                        _appDbContext.Authors.Add(author);
                        _appDbContext.SaveChanges();
                        //Response 200 OK
                        return new GenericResponse<DTO_AUTHOR>
                        {
                            Data = new DTO_AUTHOR
                            {
                                Name1 = author.Name1,
                                Name2 = author.Name2,
                                Lastname1 = author.Lastname1,
                                Lastname2 = author.Lastname2,
                                DateBirth = author.DateBirth,
                                Hometown = author.Hometown,
                                Email = author.Email,
                            },
                            Notification = new Notification
                            {
                                Code = ((int)System.Net.HttpStatusCode.OK).ToString(),
                                Message = "OK",
                                Description = "OK - Success",
                                Timestamp = DateTime.Now.ToUniversalTime()
                            }
                        };
                    }
                }
                else
                {   //Response 400 
                    EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error400;
                    emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                    return emptyDataResponse;
                }
            }
            catch (Exception e)
            {    //Response 500 
                EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error500;
                emptyDataResponse.Notification.Message = e.Message;
                emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                return emptyDataResponse;
            }
        }
        public Object InsertPublisher(RqPublisher rqPublisher)
        {
            try
            {
                if (rqPublisher != null)
                {
                    Publisher publisher = new Publisher
                    {
                        Name = rqPublisher.Name,
                        MailingAddress = rqPublisher.MailingAddress,
                        Telephone = rqPublisher.Telephone,
                        Email = rqPublisher.Email,
                        MaxBooksReg = rqPublisher.MaxBooksReg < 1 ? -1 : rqPublisher.MaxBooksReg,
                        Status = true
                    };
                    using (_appDbContext)
                    {
                        _appDbContext.Publishers.Add(publisher);
                        _appDbContext.SaveChanges();
                        //Response 200 OK
                        return new GenericResponse<DTO_PUBLISHER>
                        {
                            Data = new DTO_PUBLISHER
                            {
                                Name = publisher.Name,
                                MailingAddress = publisher.MailingAddress,
                                Telephone = publisher.Telephone,
                                Email = publisher.Email,
                                MaxBooksReg = publisher.MaxBooksReg
                            },
                            Notification = new Notification
                            {
                                Code = ((int)System.Net.HttpStatusCode.OK).ToString(),
                                Message = "OK",
                                Description = "OK - Success",
                                Timestamp = DateTime.Now.ToUniversalTime()
                            }
                        };
                    }
                }
                else
                {   //Response 400 
                    EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error400;
                    emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                    return emptyDataResponse;
                }
            }
            catch (Exception e)
            {    //Response 500 
                EmptyDataResponse emptyDataResponse = EmptyDataResponse.Error500;
                emptyDataResponse.Notification.Message = e.Message;
                emptyDataResponse.Notification.Timestamp = DateTime.Now.ToUniversalTime();
                return emptyDataResponse;
            }
        }
    }
}
