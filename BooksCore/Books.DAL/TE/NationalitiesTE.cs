using Books.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.TE
{
    public class NationalitiesTE
    {
        //CRUD Nationalities
        public List<Nationality> ReadAll()
        {
            List<Nationality> NationList = new List<Nationality>();

            using (var context = new BooksAndAuthorsContext())
            {
                try
                {
                    NationList = context.Nationalities.ToList();

                    return NationList;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

            }

        }

        public Nationality ReadOne(int IdNation)
        {
            Nationality Nation = new Nationality();

            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Nation = context.Nationalities.Where(n => n.IdNationalities == IdNation).FirstOrDefault();
                    }

                    return Nation;

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }


        }


        public void CreateNation(Nationality NationToCreate)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    context.Nationalities.Add(NationToCreate);
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }


        }


        public void EditNation(Nationality NationToEdit)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Nationality NationCtx = context.Nationalities.Where(n => n.IdNationalities == NationToEdit.IdNationalities).FirstOrDefault();

                        NationCtx.Nationality1 = NationToEdit.Nationality1;

                        context.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

        }


        public void DeleteNation(int id)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Nationality res = new Nationality();
                        res = context.Nationalities.Where(n => n.IdNationalities == id).FirstOrDefault();
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
