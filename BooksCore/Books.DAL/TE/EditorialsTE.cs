using Books.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.TE
{
    public class EditorialsTE
    {
        public List<Editorial> ReadAll()
        {
            List<Editorial> EditorialList = new List<Editorial>();

            using (var context = new BooksAndAuthorsContext())
            {
                try
                {
                    EditorialList = context.Editorials.ToList();

                    return EditorialList;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

            }

        }

        public Editorial ReadOne(int IdEditorial)
        {
            Editorial Editorial = new Editorial();


            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Editorial = context.Editorials.Where(e => e.IdEditorials == IdEditorial).FirstOrDefault();
                    }

                    return Editorial;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }


        }


        public void CreateEditorial(Editorial EditorialToCreate)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    context.Editorials.Add(EditorialToCreate);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }


        public void EditEditorial(Editorial EditorialToEdit)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Editorial EditorialCtx = context.Editorials.Where(e => e.IdEditorials == EditorialToEdit.IdEditorials).FirstOrDefault();

                        EditorialCtx.EditorialName = EditorialToEdit.EditorialName;

                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }


        public void DeleteEditoral(int id)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Editorial res = new Editorial();
                        res = context.Editorials.Where(e => e.IdEditorials == id).FirstOrDefault();
                        context.Remove(res);
                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }
    }
}
