using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijPoruka
    {
        public static List<Poruke> ListaPorukaStudenta(Student student)
        {
            List<Poruke> listaPoruka = new List<Poruke>();

            using (var context = new Entities())
            {
                var upit = (from p in context.Poruke
                            where student.ID_studenta == p.student_id
                            select new
                            {
                                ImePrezime = p.Instruktori.ime + " " + p.Instruktori.prezime,
                                naslov_poruke = p.naslov_poruke,
                                sadrzaj = p.sadrzaj,
                                datum = p.datum
                            }).ToList().Select(x => new Poruke
                            {
                                ImePrezime = x.ImePrezime,
                                naslov_poruke = x.naslov_poruke,
                                sadrzaj = x.sadrzaj,
                                datum = x.datum
                            });

                listaPoruka = upit.ToList();
            }

            return listaPoruka;
        }

        internal static List<Poruke> ListaPorukaInstruktora(Instruktor instruktor)
        {
            List<Poruke> listaPoruka = new List<Poruke>();

            using (var context = new Entities())
            {
                var upit = (from p in context.Poruke
                           where instruktor.ID_instruktora == p.instruktor_id
                           select new 
                           {
                               ImePrezime = p.Studenti.ime + " " + p.Studenti.prezime,
                               naslov_poruke = p.naslov_poruke,
                               sadrzaj = p.sadrzaj,
                               datum = p.datum
                           }).ToList().Select(x => new Poruke {
                               ImePrezime = x.ImePrezime,
                               naslov_poruke = x.naslov_poruke,
                               sadrzaj = x.sadrzaj,
                               datum = x.datum
                           });

                listaPoruka = upit.ToList();
            }

            return listaPoruka;
        }

        public static List<Instruktor> DohvatiPrimateljeStudenta()
        {
            using (var context = new Entities())
            {
                List<Instruktori> instruktori = context.Instruktori.ToList();

                List<Instruktor> listaPrimatelja = new List<Instruktor>();

                foreach (var item in instruktori)
                {
                    listaPrimatelja.Add(new Instruktor
                    {
                        ID_instruktora = item.ID_instruktora,
                        KorisnickoIme = item.korisnicko_ime,
                        Ime = item.ime,
                        Prezime = item.prezime
                    });
                }

                return listaPrimatelja;
            }
        }

        public static List<Student> DohvatiPrimateljeInstruktora()
        {
            using (var context = new Entities())
            {
                List<Studenti> studenti = context.Studenti.ToList();

                List<Student> listaPrimatelja = new List<Student>();

                foreach (var item in studenti)
                {
                    listaPrimatelja.Add(new Student
                    {
                        ID_studenta = item.ID_studenta,
                        KorisnickoIme = item.korisnicko_ime,
                        Ime = item.ime,
                        Prezime = item.prezime
                    });
                }

                return listaPrimatelja;
            }
        }

        public static Poruke PosaljiPorukuInstruktoru(Instruktor primatelj, Student posiljatelj, string naslov, string sadrzaj, DateTime datum)
        {
            using (var context = new Entities())
            {
                Poruke novaPoruka = new Poruke()
                {
                    instruktor_id = primatelj.ID_instruktora,
                    student_id = posiljatelj.ID_studenta,
                    naslov_poruke = naslov,
                    sadrzaj = sadrzaj,
                    datum = datum
                };
                context.Poruke.Add(novaPoruka);
                context.SaveChanges();

                List<Poruke> listaPoruka = ListaPorukaInstruktora(primatelj);
                Poruke poruka = listaPoruka.Find(x => (x.instruktor_id == primatelj.ID_instruktora));

                return poruka;
            }
        }

        public static Poruke PosaljiPorukuStudentu(Student primatelj, Instruktor posiljatelj, string naslov, string sadrzaj, DateTime datum)
        {
            using (var context = new Entities())
            {
                Poruke novaPoruka = new Poruke()
                {
                    instruktor_id = posiljatelj.ID_instruktora,
                    student_id = primatelj.ID_studenta,
                    naslov_poruke = naslov,
                    sadrzaj = sadrzaj,
                    datum = datum
                };
                context.Poruke.Add(novaPoruka);
                context.SaveChanges();

                List<Poruke> listaPoruka = ListaPorukaStudenta(primatelj);
                Poruke poruka = listaPoruka.Find(x => (x.student_id == primatelj.ID_studenta));

                return poruka;
            }
        }
    }
}
