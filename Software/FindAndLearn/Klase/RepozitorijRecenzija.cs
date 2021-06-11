using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijRecenzija
    {
        public static List<Recenzija> ListaRecenzija { get; set; }

        public static Recenzija KreirajRecenziju()
        {
            Recenzija recenzija = new Recenzija();
            return recenzija;
        }

        public static void DodajRecenziju(Recenzija recenzija)
        {
            using (var entities = new Entities())
            {
                Recenzije novaRecenzijaBaza = new Recenzije
                {
                    instruktor_id = recenzija.Instruktor.ID_instruktora,
                    student_id = recenzija.Student.ID_studenta,
                    ocjena = recenzija.Ocjena,
                    komentar=recenzija.Komentar
                };
                entities.Recenzije.Add(novaRecenzijaBaza);
                entities.SaveChanges();

              
                
            }

        }

        public static void ObrisiRecenziju(int idRecenzije)
        {
            using (var entities=new Entities())
            {
                var recenzija = (from rec in entities.Recenzije
                                 where rec.ID_recenzije == idRecenzije
                                 select rec).Single();
                Recenzije recenzijaBrisanje = recenzija;
                entities.Recenzije.Attach(recenzijaBrisanje);
                entities.Recenzije.Remove(recenzija);
                entities.SaveChanges();
            }
        }
    }
}
