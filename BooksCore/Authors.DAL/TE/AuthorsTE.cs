using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors.DAL.TE
{
    public class AuthorsTE
    {
        public List<Authors> ReadAll()
        {
            List<Authors> Authorlist = new List<Authors>();

            using (var context = new BooksAndAuthorsEntities())
            {
                try
                {
                    Authorlist = context.Authors.ToList();
                    foreach (Authors Author in Authorlist)
                    {
                        context.Entry(Author).Reference(r => r.Nationalities).Load();

                    }

                    return Authorlist;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

            }

        }

        public Authors ReadOne(int IdAuthor)
        {

            Authors Author = new Authors();

            using (var context = new BooksAndAuthorsEntities())
                try
                {
                    {
                        Author = context.Authors.Where(a => a.IdAuthors == IdAuthor).FirstOrDefault();

                        if (Author != null)
                        {
                            context.Entry(Author).Reference(r => r.Nationalities).Load();

                        }

                    }

                    return Author;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }


        }


        public void CreateAuthor(Authors AuthorToCreate)
        {
            using (var context = new BooksAndAuthorsEntities())
                try
                {
                    {
                        context.Authors.Add(AuthorToCreate);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }


        }


        public void EditAuthors(Authors AuthorToEdit)
        {
            using (var context = new BooksAndAuthorsEntities())
                try
                {
                    {
                        Authors AuthorCtx = context.Authors.Where(a => a.IdAuthors == AuthorToEdit.IdAuthors).FirstOrDefault();

                        AuthorCtx.AuthorName = AuthorToEdit.AuthorName;
                        AuthorCtx.Nationality = AuthorToEdit.Nationality;

                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }


        public void DeleteAuthor(int IdAuthor)
        {
            using (var context = new BooksAndAuthorsEntities())
                try
                {
                    {
                        Authors Author = new Authors();
                        Author = context.Authors.Where(a => a.IdAuthors == IdAuthor).FirstOrDefault();
                        if (Author != null)
                        {
                            context.Authors.Remove(Author);
                            context.SaveChanges();
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }
    }
}
