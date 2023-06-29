using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace car_rental.Models
{
    public class Klient
    {
        private int id;
        private string imie;
        private string nazwisko;
        private string nr_tel;
        private string miasto;
        private string ulica;
        private string adres;
        private string kod_poczt;

        [DisplayName("Id")]
        public int Id { get { return id; } set { id = value; } }
        [DisplayName("Imię")]
        [Required(ErrorMessage ="Imię klienta jest wymagane")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Imię musi mieć od 3 do 20 znaków")]
        public string Imie { get { return imie; } set { imie = value; } }
        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "Nazwisko klienta jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nazwisko musi mieć od 3 do 30 znaków")]
        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Numer telefonu klienta jest wymagany")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Numer telefonu musi zawierać 9 znaków")]
        public string Nr_tel { get { return nr_tel; } set { nr_tel = value; } }
        [DisplayName("Miasto")]
        [Required(ErrorMessage = "Miasto zamieszkania klienta jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nazwa miasta musi mieć od 3 do 30 znaków")]
        public string Miasto { get { return miasto; } set { miasto = value; } }
        [DisplayName("Ulica")]
        [Required(ErrorMessage = "Ulica zamieszkania klienta jest wymagana")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nazwa ulicy musi mieć od 3 do 30 znaków")]
        public string Ulica { get {return ulica; } set { ulica = value; } }
        [DisplayName("Adres")]
        [Required(ErrorMessage = "Adres zamieszkania klienta jest wymagany")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Adres musi mieć od 3 do 10 znaków")]
        public string Adres { get { return adres; } set { adres = value; } }
        [DisplayName("Kod pocztowy")]
        [Required(ErrorMessage = "Kod pocztowy klienta jest wymagany")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Kod pocztowy musi zawierać 6 znaków")]
        public string Kod_poczt { get { return kod_poczt; } set { kod_poczt = value; } }
    }
}
