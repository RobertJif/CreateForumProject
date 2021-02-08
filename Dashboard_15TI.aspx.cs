using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Create_Forum_Project
{
    public partial class Dashboard_15TI : System.Web.UI.Page
    {
        string user1;
        string datetime = System.DateTime.Now.Date.ToLongDateString();
        string hurufkecil;
        int j, wrd = 0;
        string[] tokenization;

        protected void Page_Load(object sender, EventArgs e)
        {
            user1 = Session["nam"].ToString();
            lblwelcom.InnerHtml = user1.ToString();
            //div_dashboard_box.Visible = true;
        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {
            token();
            //List<string> words = txtposttitle.Text.Replace(",", "").Replace(".", "").Split(" ").ToList();
            //tokenization = txtposttitle.Text.Split(' ');
            //Label1.Text += tokenization;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert into forum_post15ti(username, posttitle, postmessage) values ('" + user1 + "','" + txtposttitle.Text + "', '" + txtpostmessage.InnerText.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/Home_15TI.aspx");

        }
        public void token()
        {
            hurufkecil = txtposttitle.Text.ToLower();//casefolding
            string[] kata = new string[] { " pada ", " sebagai ", " telah ", " punya ", " dari ", " untuk ", " setiap ", " pernah ", " lain ", " baik ", " memang ", " bisa ", " tetapi ", " sudah ", " karena ", " jadi ", " seperti ", " ada ", " antara ", " juga ", " hampir ", " semua ", " setelah ", " di ", " tentang ", " mampu ", " yang ", " ke ", " memiliki ", " dia ", " maka ", " bagaimana ", " jika ", " dalam ", " akan ", " sekali ", " suka ", " jauh ", " belum ", " disini ", " disana ", " kecil ", " secara ", " anda ", " terus ", " banyak", " kembali ", " atas ", " mari ", " dekat ", " masih ", " oleh ", " dengan ", " mungkin ", " nanti ", " dan ", " atau " };
            foreach (string word in kata)
            {
                hurufkecil = hurufkecil.Replace(word, " ");
            }
            string[] words = hurufkecil.Split(' ');
            foreach (string word in words)
            {
                wrd++;
            }
            tokenization = new string[wrd];
            foreach (string word in words)
            {
                tokenization[j++] = stemming(word);
            }



            for (int i = 0; i < tokenization.Length; i++)
            {
                //Label1.Text += tokenization[i] + " ";
            }

            knn(tokenization);
        }

        public void knn(string[] kata)
        {
            double[] jarak = new double[jumlah()];
            string[] kategori = new string[jumlah()];
            int kuliah = 0, ajar = 0, jurus = 0, tentang = 0, cara = 0, didik = 0, ilmu = 0, teknik = 0, soal = 0, salah = 0, universitas = 0, s1 = 0, akuntansi = 0, stan = 0, masuk = 0, negeri = 0, apa = 0, benar = 0, mengapa = 0, beasiswa = 0, harus = 0, ptn = 0, d3 = 0, uji = 0, sbmptn = 0, jakarta = 0,
                indonesia = 0, dunia = 0, olahraga = 0, main = 0, piala = 0, liga = 0, juara = 0, atlet = 0, tim = 0, gelar = 0, madrid = 0, lima = 0, futsal = 0, sepakbola = 0, cantik = 0, tinju = 0, game = 0, barcelona = 0, raih = 0, tiga = 0, para = 0, hasil = 0, skor = 0, lolos = 0, pekan = 0, negara = 0, basket = 0, dalam = 0, tahun = 0, vs = 0, timnas = 0, real = 0, klub = 0, musim = 0, ajang = 0, emas = 0, laga = 0, dua = 0, babak = 0, napoli = 0, ronaldo = 0, city = 0, renang = 0, league = 0,
                bisnis = 0, usaha = 0, peluang = 0, jasa = 0, agen = 0, dengan = 0, jadi = 0, online = 0, untuk = 0, buat = 0, mau = 0, modal = 0, grosir = 0, murah = 0, kecil = 0, kaskus = 0, jual = 0, harga = 0, punya = 0, kirim = 0, cari = 0, kuota = 0, rotan = 0, mudah = 0, bingung = 0,
                hilang = 0, kunci = 0, motor = 0, temu = 0, bagi = 0, rasa = 0, silahkan = 0, hubung = 0, baak = 0, sebuah = 0, berita = 0, flashdisk = 0, kacamata = 0, jam = 0, tangan = 0, barang = 0, ktm = 0, atm = 0, hp = 0, helm = 0, rektorat = 0, dompet = 0, parkir = 0, uang = 0, hitam = 0, lab = 0, merek = 0, laptop = 0,
                panitia = 0, recruitment = 0, pcr = 0, reminder = 0, interview = 0, umum = 0, cup = 0, itsa = 0, volleyball = 0, rekrut = 0, ihsbt = 0, proliga = 0, mahasiswa = 0, nama = 0, badminton = 0, ihsjw = 0, snc = 0, wisuda = 0, sid = 0, day = 0, anggota = 0, kri = 0, takraw = 0, seminar = 0, school = 0, sepak = 0, rekrutmen = 0, ito = 0, sts = 0, daftar = 0, iso = 0, competition = 0, mbl = 0, ngumbarni = 0, workshop = 0;
            for (int i = 0; i < jumlah(); i++)
            {
                for (int j = 0; j < kata.Length; j++)
                {
                    if (kata[j] == "kuliah")
                    {
                        kuliah = 1;
                    }
                    else if (kata[j] == "ajar")
                    {
                        ajar = 1;
                    }
                    else if (kata[j] == "jurus")
                    {
                        jurus = 1;
                    }
                    else if (kata[j] == "tentang")
                    {
                        tentang = 1;
                    }
                    else if (kata[j] == "cara")
                    {
                        cara = 1;
                    }
                    else if (kata[j] == "didik")
                    {
                        didik = 1;
                    }
                    else if (kata[j] == "ilmu")
                    {
                        ilmu = 1;
                    }
                    else if (kata[j] == "teknik")
                    {
                        teknik = 1;
                    }
                    else if (kata[j] == "soal")
                    {
                        soal = 1;
                    }
                    else if (kata[j] == "salah")
                    {
                        salah = 1;
                    }
                    else if (kata[j] == "universitas")
                    {
                        universitas = 1;
                    }
                    else if (kata[j] == "s1")
                    {
                        s1 = 1;
                    }
                    else if (kata[j] == "akuntansi")
                    {
                        akuntansi = 1;
                    }
                    else if (kata[j] == "stan")
                    {
                        stan = 1;
                    }
                    else if (kata[j] == "masuk")
                    {
                        masuk = 1;
                    }
                    else if (kata[j] == "negeri")
                    {
                        negeri = 1;
                    }
                    else if (kata[j] == "apa")
                    {
                        apa = 1;
                    }
                    else if (kata[j] == "benar")
                    {
                        benar = 1;
                    }
                    else if (kata[j] == "mengapa")
                    {
                        mengapa = 1;
                    }
                    else if (kata[j] == "beasiswa")
                    {
                        beasiswa = 1;
                    }
                    else if (kata[j] == "harus")
                    {
                        harus = 1;
                    }
                    else if (kata[j] == "ptn")
                    {
                        ptn = 1;
                    }
                    else if (kata[j] == "d3")
                    {
                        d3 = 1;
                    }
                    else if (kata[j] == "uji")
                    {
                        uji = 1;
                    }
                    else if (kata[j] == "sbmptn")
                    {
                        sbmptn = 1;
                    }
                    else if (kata[j] == "jakarta")
                    {
                        jakarta = 1;
                    }
                    else if (kata[j] == "indonesia")
                    {
                        indonesia = 1;
                    }
                    else if (kata[j] == "dunia")
                    {
                        dunia = 1;
                    }
                    else if (kata[j] == "olahraga")
                    {
                        olahraga = 1;
                    }
                    else if (kata[j] == "main")
                    {
                        main = 1;
                    }
                    else if (kata[j] == "piala")
                    {
                        piala = 1;
                    }
                    else if (kata[j] == "liga")
                    {
                        liga = 1;
                    }
                    else if (kata[j] == "juara")
                    {
                        juara = 1;
                    }
                    else if (kata[j] == "atlet")
                    {
                        atlet = 1;
                    }
                    else if (kata[j] == "tim")
                    {
                        tim = 1;
                    }
                    else if (kata[j] == "gelar")
                    {
                        gelar = 1;
                    }
                    else if (kata[j] == "madrid")
                    {
                        madrid = 1;
                    }
                    else if (kata[j] == "lima")
                    {
                        lima = 1;
                    }
                    else if (kata[j] == "futsal")
                    {
                        futsal = 1;
                    }
                    else if (kata[j] == "sepakbola")
                    {
                        sepakbola = 1;
                    }
                    else if (kata[j] == "cantik")
                    {
                        cantik = 1;
                    }
                    else if (kata[j] == "tinju")
                    {
                        tinju = 1;
                    }
                    else if (kata[j] == "game")
                    {
                        game = 1;
                    }
                    else if (kata[j] == "barcelona")
                    {
                        barcelona = 1;
                    }
                    else if (kata[j] == "raih")
                    {
                        raih = 1;
                    }
                    else if (kata[j] == "tiga")
                    {
                        tiga = 1;
                    }
                    else if (kata[j] == "para")
                    {
                        para = 1;
                    }
                    else if (kata[j] == "hasil")
                    {
                        hasil = 1;
                    }
                    else if (kata[j] == "skor")
                    {
                        skor = 1;
                    }
                    else if (kata[j] == "lolos")
                    {
                        lolos = 1;
                    }
                    else if (kata[j] == "pekan")
                    {
                        pekan = 1;
                    }
                    else if (kata[j] == "negara")
                    {
                        negara = 1;
                    }
                    else if (kata[j] == "basket")
                    {
                        basket = 1;
                    }
                    else if (kata[j] == "dalam")
                    {
                        dalam = 1;
                    }
                    else if (kata[j] == "tahun")
                    {
                        tahun = 1;
                    }
                    else if (kata[j] == "vs")
                    {
                        vs = 1;
                    }
                    else if (kata[j] == "timnas")
                    {
                        timnas = 1;
                    }
                    else if (kata[j] == "real")
                    {
                        real = 1;
                    }
                    else if (kata[j] == "klub")
                    {
                        klub = 1;
                    }
                    else if (kata[j] == "musim")
                    {
                        musim = 1;
                    }
                    else if (kata[j] == "ajang")
                    {
                        ajang = 1;
                    }
                    else if (kata[j] == "emas")
                    {
                        emas = 1;
                    }
                    else if (kata[j] == "laga")
                    {
                        laga = 1;
                    }
                    else if (kata[j] == "dua")
                    {
                        dua = 1;
                    }
                    else if (kata[j] == "babak")
                    {
                        babak = 1;
                    }
                    else if (kata[j] == "napoli")
                    {
                        napoli = 1;
                    }
                    else if (kata[j] == "ronaldo")
                    {
                        ronaldo = 1;
                    }
                    else if (kata[j] == "city")
                    {
                        city = 1;
                    }
                    else if (kata[j] == "renang")
                    {
                        renang = 1;
                    }
                    else if (kata[j] == "league")
                    {
                        league = 1;
                    }
                    else if (kata[j] == "bisnis")
                    {
                        bisnis = 1;
                    }
                    else if (kata[j] == "usaha")
                    {
                        usaha = 1;
                    }
                    else if (kata[j] == "peluang")
                    {
                        peluang = 1;
                    }
                    else if (kata[j] == "jasa")
                    {
                        jasa = 1;
                    }
                    else if (kata[j] == "agen")
                    {
                        agen = 1;
                    }
                    else if (kata[j] == "dengan")
                    {
                        dengan = 1;
                    }
                    else if (kata[j] == "jadi")
                    {
                        jadi = 1;
                    }
                    else if (kata[j] == "online")
                    {
                        online = 1;
                    }
                    else if (kata[j] == "untuk")
                    {
                        untuk = 1;
                    }
                    else if (kata[j] == "buat")
                    {
                        buat = 1;
                    }
                    else if (kata[j] == "mau")
                    {
                        mau = 1;
                    }
                    else if (kata[j] == "modal")
                    {
                        modal = 1;
                    }
                    else if (kata[j] == "grosir")
                    {
                        grosir = 1;
                    }
                    else if (kata[j] == "murah")
                    {
                        murah = 1;
                    }
                    else if (kata[j] == "kecil")
                    {
                        kecil = 1;
                    }
                    else if (kata[j] == "kaskus")
                    {
                        kaskus = 1;
                    }
                    else if (kata[j] == "jual")
                    {
                        jual = 1;
                    }
                    else if (kata[j] == "harga")
                    {
                        harga = 1;
                    }
                    else if (kata[j] == "punya")
                    {
                        punya = 1;
                    }
                    else if (kata[j] == "kirim")
                    {
                        kirim = 1;
                    }
                    else if (kata[j] == "cari")
                    {
                        cari = 1;
                    }
                    else if (kata[j] == "kuota")
                    {
                        kuota = 1;
                    }
                    else if (kata[j] == "rotan")
                    {
                        rotan = 1;
                    }
                    else if (kata[j] == "mudah")
                    {
                        mudah = 1;
                    }
                    else if (kata[j] == "bingung")
                    {
                        bingung = 1;
                    }
                    else if (kata[j] == "hilang")
                    {
                        hilang = 1;
                    }
                    else if (kata[j] == "kunci")
                    {
                        kunci = 1;
                    }
                    else if (kata[j] == "motor")
                    {
                        motor = 1;
                    }
                    else if (kata[j] == "temu")
                    {
                        temu = 1;
                    }
                    else if (kata[j] == "bagi")
                    {
                        bagi = 1;
                    }
                    else if (kata[j] == "rasa")
                    {
                        rasa = 1;
                    }
                    else if (kata[j] == "silahkan")
                    {
                        silahkan = 1;
                    }
                    else if (kata[j] == "hubung")
                    {
                        hubung = 1;
                    }
                    else if (kata[j] == "baak")
                    {
                        baak = 1;
                    }
                    else if (kata[j] == "sebuah")
                    {
                        sebuah = 1;
                    }
                    else if (kata[j] == "berita")
                    {
                        berita = 1;
                    }
                    else if (kata[j] == "flashdisk")
                    {
                        flashdisk = 1;
                    }
                    else if (kata[j] == "kacamata")
                    {
                        kacamata = 1;
                    }
                    else if (kata[j] == "jam")
                    {
                        jam = 1;
                    }
                    else if (kata[j] == "tangan")
                    {
                        tangan = 1;
                    }
                    else if (kata[j] == "barang")
                    {
                        barang = 1;
                    }
                    else if (kata[j] == "ktm")
                    {
                        ktm = 1;
                    }
                    else if (kata[j] == "atm")
                    {
                        atm = 1;
                    }
                    else if (kata[j] == "hp")
                    {
                        hp = 1;
                    }
                    else if (kata[j] == "helm")
                    {
                        helm = 1;
                    }
                    else if (kata[j] == "rektorat")
                    {
                        rektorat = 1;
                    }
                    else if (kata[j] == "dompet")
                    {
                        dompet = 1;
                    }
                    else if (kata[j] == "parkir")
                    {
                        parkir = 1;
                    }
                    else if (kata[j] == "uang")
                    {
                        uang = 1;
                    }
                    else if (kata[j] == "hitam")
                    {
                        hitam = 1;
                    }
                    else if (kata[j] == "lab")
                    {
                        lab = 1;
                    }
                    else if (kata[j] == "merek")
                    {
                        merek = 1;
                    }
                    else if (kata[j] == "laptop")
                    {
                        laptop = 1;
                    }
                    else if (kata[j] == "panitia")
                    {
                        panitia = 1;

                    }
                    else if (kata[j] == "recruitment")
                    {
                        recruitment = 1;

                    }

                    else if (kata[j] == "pcr")
                    {
                        pcr = 1;

                    }
                    else if (kata[j] == "reminder")
                    {
                        reminder = 1;

                    }
                    else if (kata[j] == "interview")
                    {
                        interview = 1;

                    }
                    else if (kata[j] == "umum")
                    {
                        umum = 1;
                    }
                    else if (kata[j] == "cup")
                    {
                        cup = 1;

                    }
                    else if (kata[j] == "itsa")
                    {
                        itsa = 1;

                    }
                    else if (kata[j] == "volleyball")
                    {
                        volleyball = 1;

                    }
                    else if (kata[j] == "rekrut")
                    {
                        rekrut = 1;

                    }
                    else if (kata[j] == "ihsbt")
                    {
                        ihsbt = 1;
                    }
                    else if (kata[j] == "proliga")
                    {
                        proliga = 1;

                    }
                    else if (kata[j] == "mahasiswa")
                    {
                        mahasiswa = 1;

                    }
                    else if (kata[j] == "nama")
                    {
                        nama = 1;

                    }
                    else if (kata[j] == "badminton")
                    {
                        badminton = 1;

                    }
                    else if (kata[j] == "ihsjw")
                    {
                        ihsjw = 1;

                    }
                    else if (kata[j] == "snc")
                    {
                        snc = 1;

                    }
                    else if (kata[j] == "wisuda")
                    {
                        wisuda = 1;

                    }
                    else if (kata[j] == "sid")
                    {
                        sid = 1;

                    }
                    else if (kata[j] == "day")
                    {
                        day = 1;

                    }
                    else if (kata[j] == "anggota")
                    {
                        anggota = 1;

                    }
                    else if (kata[j] == "kri")
                    {
                        kri = 1;

                    }
                    else if (kata[j] == "takraw")
                    {
                        takraw = 1;

                    }
                    else if (kata[j] == "seminar")
                    {
                        seminar = 1;

                    }
                    else if (kata[j] == "school")
                    {
                        school = 1;

                    }
                    else if (kata[j] == "sepak")
                    {
                        sepak = 1;

                    }
                    else if (kata[j] == "rekrutmen")
                    {
                        rekrutmen = 1;

                    }
                    else if (kata[j] == "ito")
                    {
                        ito = 1;

                    }
                    else if (kata[j] == "sts")
                    {
                        sts = 1;

                    }
                    else if (kata[j] == "daftar")
                    {
                        daftar = 1;

                    }
                    else if (kata[j] == "iso")
                    {
                        iso = 1;

                    }
                    else if (kata[j] == "competition")
                    {
                        competition = 1;

                    }
                    else if (kata[j] == "mbl")
                    {
                        mbl = 1;

                    }
                    else if (kata[j] == "ngumbarni")
                    {
                        ngumbarni = 1;

                    }
                    else if (kata[j] == "workshop")
                    {
                        workshop = 1;

                    }
                }

                jarak[i] = Math.Pow(kuliah - cari2("kuliah", i + 1), 2) + Math.Pow(ajar - cari2("ajar", i + 1), 2)
                    + Math.Pow(jurus - cari2("jurus", i + 1), 2) + Math.Pow(tentang - cari2("tentang", i + 1), 2)
                    + Math.Pow(cara - cari2("cara", i + 1), 2) + Math.Pow(didik - cari2("didik", i + 1), 2)
                    + Math.Pow(ilmu - cari2("ilmu", i + 1), 2) + Math.Pow(teknik - cari2("teknik", i + 1), 2)
                    + Math.Pow(soal - cari2("soal", i + 1), 2) + Math.Pow(salah - cari2("salah", i + 1), 2)
                    + Math.Pow(universitas - cari2("universitas", i + 1), 2) + Math.Pow(s1 - cari2("s1", i + 1), 2)
                    + Math.Pow(akuntansi - cari2("akuntansi", i + 1), 2) + Math.Pow(stan - cari2("stan", i + 1), 2)
                    + Math.Pow(masuk - cari2("masuk", i + 1), 2) + Math.Pow(negeri - cari2("negeri", i + 1), 2)
                    + Math.Pow(apa - cari2("apa", i + 1), 2) + Math.Pow(benar - cari2("benar", i + 1), 2)
                    + Math.Pow(mengapa - cari2("mengapa", i + 1), 2) + Math.Pow(beasiswa - cari2("beasiswa", i + 1), 2)
                    + Math.Pow(harus - cari2("harus", i + 1), 2) + Math.Pow(ptn - cari2("ptn", i + 1), 2)
                    + Math.Pow(d3 - cari2("d3", i + 1), 2) + Math.Pow(uji - cari2("uji", i + 1), 2)
                    + Math.Pow(sbmptn - cari2("sbmptn", i + 1), 2) + Math.Pow(jakarta - cari2("jakarta", i + 1), 2)
                    + Math.Pow(indonesia - cari2("indonesia", i + 1), 2) + Math.Pow(dunia - cari2("dunia", i + 1), 2)
                    + Math.Pow(olahraga - cari2("olahraga", i + 1), 2) + Math.Pow(main - cari2("main", i + 1), 2)
                    + Math.Pow(piala - cari2("piala", i + 1), 2) + Math.Pow(liga - cari2("liga", i + 1), 2)
                    + Math.Pow(juara - cari2("juara", i + 1), 2) + Math.Pow(atlet - cari2("atlet", i + 1), 2)
                    + Math.Pow(tim - cari2("tim", i + 1), 2) + Math.Pow(gelar - cari2("gelar", i + 1), 2)
                    + Math.Pow(madrid - cari2("madrid", i + 1), 2) + Math.Pow(lima - cari2("lima", i + 1), 2)
                    + Math.Pow(futsal - cari2("futsal", i + 1), 2) + Math.Pow(sepakbola - cari2("sepakbola", i + 1), 2)
                    + Math.Pow(cantik - cari2("cantik", i + 1), 2) + Math.Pow(tinju - cari2("tinju", i + 1), 2)
                    + Math.Pow(game - cari2("game", i + 1), 2) + Math.Pow(barcelona - cari2("barcelona", i + 1), 2)
                    + Math.Pow(raih - cari2("raih", i + 1), 2) + Math.Pow(tiga - cari2("tiga", i + 1), 2)
                    + Math.Pow(para - cari2("para", i + 1), 2) + Math.Pow(hasil - cari2("hasil", i + 1), 2)
                    + Math.Pow(skor - cari2("skor", i + 1), 2) + Math.Pow(lolos - cari2("lolos", i + 1), 2)
                    + Math.Pow(pekan - cari2("pekan", i + 1), 2) + Math.Pow(negara - cari2("negara", i + 1), 2)
                    + Math.Pow(basket - cari2("basket", i + 1), 2) + Math.Pow(dalam - cari2("dalam", i + 1), 2)
                    + Math.Pow(tahun - cari2("tahun", i + 1), 2) + Math.Pow(vs - cari2("vs", i + 1), 2)
                    + Math.Pow(timnas - cari2("timnas", i + 1), 2) + Math.Pow(real - cari2("real", i + 1), 2)
                    + Math.Pow(klub - cari2("klub", i + 1), 2) + Math.Pow(musim - cari2("musim", i + 1), 2)
                    + Math.Pow(ajang - cari2("ajang", i + 1), 2) + Math.Pow(emas - cari2("emas", i + 1), 2)
                    + Math.Pow(laga - cari2("laga", i + 1), 2) + Math.Pow(dua - cari2("dua", i + 1), 2)
                    + Math.Pow(babak - cari2("babak", i + 1), 2) + Math.Pow(napoli - cari2("napoli", i + 1), 2)
                    + Math.Pow(ronaldo - cari2("ronaldo", i + 1), 2) + Math.Pow(city - cari2("city", i + 1), 2)
                    + Math.Pow(renang - cari2("renang", i + 1), 2) + Math.Pow(league - cari2("league", i + 1), 2)
                    + Math.Pow(bisnis - cari2("bisnis", i + 1), 2) + Math.Pow(usaha - cari2("usaha", i + 1), 2)
                    + Math.Pow(peluang - cari2("peluang", i + 1), 2) + Math.Pow(jasa - cari2("jasa", i + 1), 2)
                    + Math.Pow(agen - cari2("agen", i + 1), 2) + Math.Pow(dengan - cari2("dengan", i + 1), 2)
                    + Math.Pow(jadi - cari2("jadi", i + 1), 2) + Math.Pow(online - cari2("online", i + 1), 2)
                    + Math.Pow(untuk - cari2("untuk", i + 1), 2) + Math.Pow(buat - cari2("buat", i + 1), 2)
                    + Math.Pow(mau - cari2("mau", i + 1), 2) + Math.Pow(modal - cari2("modal", i + 1), 2)
                    + Math.Pow(grosir - cari2("grosir", i + 1), 2) + Math.Pow(murah - cari2("murah", i + 1), 2)
                    + Math.Pow(kecil - cari2("kecil", i + 1), 2) + Math.Pow(kaskus - cari2("kaskus", i + 1), 2)
                    + Math.Pow(jual - cari2("jual", i + 1), 2) + Math.Pow(harga - cari2("harga", i + 1), 2)
                    + Math.Pow(punya - cari2("punya", i + 1), 2) + Math.Pow(kirim - cari2("kirim", i + 1), 2)
                    + Math.Pow(cari - cari2("cari", i + 1), 2) + Math.Pow(kuota - cari2("kuota", i + 1), 2)
                    + Math.Pow(rotan - cari2("rotan", i + 1), 2) + Math.Pow(mudah - cari2("mudah", i + 1), 2)
                    + Math.Pow(bingung - cari2("bingung", i + 1), 2) + Math.Pow(hilang - cari2("hilang", i + 1), 2)
                    + Math.Pow(kunci - cari2("kunci", i + 1), 2) + Math.Pow(motor - cari2("motor", i + 1), 2)
                    + Math.Pow(temu - cari2("temu", i + 1), 2) + Math.Pow(bagi - cari2("bagi", i + 1), 2)
                    + Math.Pow(rasa - cari2("rasa", i + 1), 2) + Math.Pow(silahkan - cari2("silahkan", i + 1), 2)
                    + Math.Pow(hubung - cari2("hubung", i + 1), 2) + Math.Pow(baak - cari2("baak", i + 1), 2)
                    + Math.Pow(sebuah - cari2("sebuah", i + 1), 2) + Math.Pow(berita - cari2("berita", i + 1), 2)
                    + Math.Pow(flashdisk - cari2("flashdisk", i + 1), 2) + Math.Pow(kacamata - cari2("kacamata", i + 1), 2)
                    + Math.Pow(jam - cari2("jam", i + 1), 2) + Math.Pow(tangan - cari2("tangan", i + 1), 2)
                    + Math.Pow(barang - cari2("barang", i + 1), 2) + Math.Pow(ktm - cari2("ktm", i + 1), 2)
                    + Math.Pow(atm - cari2("atm", i + 1), 2) + Math.Pow(hp - cari2("hp", i + 1), 2)
                    + Math.Pow(helm - cari2("helm", i + 1), 2) + Math.Pow(rektorat - cari2("rektorat", i + 1), 2)
                    + Math.Pow(dompet - cari2("dompet", i + 1), 2) + Math.Pow(parkir - cari2("parkir", i + 1), 2)
                    + Math.Pow(uang - cari2("uang", i + 1), 2) + Math.Pow(hitam - cari2("hitam", i + 1), 2)
                    + Math.Pow(lab - cari2("lab", i + 1), 2) + Math.Pow(merek - cari2("merek", i + 1), 2)
                    + Math.Pow(laptop - cari2("laptop", i + 1), 2) + Math.Pow(panitia - cari2("panitia", i + 1), 2)
                    + Math.Pow(recruitment - cari2("recruitment", i + 1), 2) +
                    +Math.Pow(pcr - cari2("pcr", i + 1), 2) + Math.Pow(reminder - cari2("reminder", i + 1), 2)
                    + Math.Pow(interview - cari2("interview", i + 1), 2) + Math.Pow(umum - cari2("umum", i + 1), 2)
                    + Math.Pow(cup - cari2("cup", i + 1), 2) + Math.Pow(itsa - cari2("itsa", i + 1), 2)
                    + Math.Pow(volleyball - cari2("volleyball", i + 1), 2) + Math.Pow(rekrut - cari2("rekrut", i + 1), 2)
                    + Math.Pow(ihsbt - cari2("ihsbt", i + 1), 2) + Math.Pow(proliga - cari2("proliga", i + 1), 2)
                    + Math.Pow(mahasiswa - cari2("mahasiswa", i + 1), 2) + Math.Pow(nama - cari2("nama", i + 1), 2)
                    + Math.Pow(badminton - cari2("badminton", i + 1), 2) + Math.Pow(ihsjw - cari2("ihsjw", i + 1), 2)
                    + Math.Pow(snc - cari2("snc", i + 1), 2) + Math.Pow(wisuda - cari2("wisuda", i + 1), 2)
                    + Math.Pow(sid - cari2("sid", i + 1), 2) + Math.Pow(day - cari2("day", i + 1), 2)
                    + Math.Pow(anggota - cari2("anggota", i + 1), 2) + Math.Pow(kri - cari2("kri", i + 1), 2)
                    + Math.Pow(takraw - cari2("takraw", i + 1), 2) + Math.Pow(seminar - cari2("seminar", i + 1), 2)
                    + Math.Pow(school - cari2("school", i + 1), 2) + Math.Pow(sepak - cari2("sepak", i + 1), 2)
                    + Math.Pow(rekrutmen - cari2("rekrutmen", i + 1), 2) + Math.Pow(ito - cari2("ito", i + 1), 2)
                    + Math.Pow(sts - cari2("sts", i + 1), 2) + Math.Pow(daftar - cari2("daftar", i + 1), 2)
                    + Math.Pow(iso - cari2("iso", i + 1), 2) + Math.Pow(competition - cari2("competition", i + 1), 2)
                    + Math.Pow(mbl - cari2("mbl", i + 1), 2) + Math.Pow(ngumbarni - cari2("ngumbarni", i + 1), 2)
                    + Math.Pow(workshop - cari2("workshop", i + 1), 2);





                jarak[i] = Math.Sqrt(jarak[i]);
                kategori[i] = carikategori(i + 1);
            }
            string temp2 = "";
            double temp = 0;
            for (int j = 0; j < jarak.Length; j++)
            {
                for (int k = j + 1; k < jarak.Length; k++)
                {
                    if (jarak[k] < jarak[j])
                    {
                        temp = jarak[j];
                        jarak[j] = jarak[k];
                        jarak[k] = temp;
                        temp2 = kategori[j];
                        kategori[j] = kategori[k];
                        kategori[k] = temp2;
                    }
                }
            }
            for (int i = 0; i < jarak.Length; i++)
            {
                //Label1.Text += jarak[i].ToString() + kategori[i];
            }
            string kat_akhir = "";
            int a_edukasi = 0, a_olahraga = 0, a_bisnis = 0, a_berita_kehilangan = 0, a_kepanitiaan = 0;
            for (int i = 0; i < 6; i++)
            {
                if (kategori[i].Contains("edukasi"))
                {
                    a_edukasi++;
                }
                if (kategori[i].Contains("olahraga"))
                {
                    a_olahraga++;
                }
                if (kategori[i].Contains("bisnis"))
                {
                    a_bisnis++;
                }
                if (kategori[i].Contains("berita_kehilangan"))
                {
                    a_berita_kehilangan++;
                }
                if (kategori[i].Contains("kepanitiaan"))
                {
                    a_kepanitiaan++;
                }
            }
            if (a_edukasi > a_olahraga && a_edukasi > a_bisnis && a_edukasi > a_berita_kehilangan && a_edukasi > a_kepanitiaan)
            {
                kat_akhir = "edukasi";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_edukasi(edukasi) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();



            }
            else if (a_olahraga > a_edukasi && a_olahraga > a_bisnis && a_olahraga > a_berita_kehilangan && a_olahraga > a_kepanitiaan)
            {
                kat_akhir = "olahraga";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_olahraga(olahraga) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else if (a_bisnis > a_edukasi && a_bisnis > a_olahraga && a_bisnis > a_berita_kehilangan && a_bisnis > a_kepanitiaan)
            {
                kat_akhir = "bisnis";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_bisnis(bisnis) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else if (a_berita_kehilangan > a_edukasi && a_berita_kehilangan > a_olahraga && a_berita_kehilangan > a_bisnis && a_berita_kehilangan > a_kepanitiaan)
            {
                kat_akhir = "berita kehilangan";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_berita(berita_kehilangan) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else if (a_kepanitiaan > a_edukasi && a_kepanitiaan > a_olahraga && a_kepanitiaan > a_bisnis && a_kepanitiaan > a_berita_kehilangan)
            {
                kat_akhir = "kepanitiaan";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_kepanitiaan(panitia) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }

            //Label1.Text += kat_akhir;
        }

        public string stemming(string kata)
        {
            if (kata.Length > 5)
            {
                kata = hapuspartikel(kata);
                kata = hapuspp(kata);
                kata = hapusawalan1(kata);
                kata = hapusawalan2(kata);
                kata = hapusakhiran(kata);
                kata = hapusakhiran2(kata);

            }
            return kata;
        }

        public int cari(string kata)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            string query = "Select count(*) from kata_dasar where kata_dasar='" + kata + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            return count;
            con.Close();
        }

        public int cari2(string kata, int ind)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            string query = "Select " + kata + " from data_training2 where id_dtr='" + ind + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }

        public string carikategori(int ind)
        {
            string count = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            string query = "Select kategori from data_training2 where id_dtr='" + ind + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            count = (string)cmd.ExecuteScalar();
            con.Close();
            return count;

        }

        public int jumlah()
        {
            int count = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            string query = "Select count(*) from data_training2";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }

        public string hapuspartikel(string kata)
        {
            string temp = kata;
            if (cari(kata) != 1)
            {
                if (((kata.Substring(kata.Length - 3)).Equals("kah")) || ((kata.Substring(kata.Length - 3)).Equals("lah")) || ((kata.Substring(kata.Length - 3)).Equals("pun")))
                {
                    kata = kata.Substring(0, kata.Length - 3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
            }
            return kata;
        }
        public string hapuspp(string kata)
        {
            string temp = kata;
            if (cari(kata) != 1)
            {
                if (kata.Length > 4)
                {
                    if (kata.Substring(kata.Length - 2).Equals("ku") || (kata.Substring(kata.Length - 2).Equals("mu")))
                    {
                        kata = kata.Substring(0, kata.Length - 2);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                    else if (kata.Substring(kata.Length - 3).Equals("nya"))
                    {
                        kata = kata.Substring(0, kata.Length - 3);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }


                }
            }
            return kata;
        }
        public string hapusawalan1(string kata)
        {
            string temp2 = kata;
            if (cari(kata) != 1)
            {
                string temp = kata;
                if (kata.Substring(0, 2).Equals("me"))
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                        if (kata.Substring(0, 3).Equals("men"))
                        {
                            if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                            {
                                kata = "t" + kata.Substring(3);
                                if (cari(kata) != 1)
                                {
                                    kata = temp;
                                }
                            }
                            else
                            {
                                kata = kata.Substring(3);
                                if (cari(kata) != 1)
                                {
                                    kata = temp;
                                }
                            }

                            if (cari(kata) != 1)
                            {
                                kata = temp;
                                if (kata.Substring(0, 4).Equals("meng"))
                                {
                                    kata = (kata.Substring(4));
                                    if (cari(kata) != 1)
                                    {
                                        kata = "k" + kata;
                                        if (cari(kata) != 1)
                                        {
                                            kata = temp;
                                        }
                                    }
                                }
                                else if (kata.Substring(0, 4).Equals("meny"))
                                {
                                    kata = ("s" + kata.Substring(4));

                                    if (cari(kata) != 1)
                                    {
                                        kata = ("k" + kata.Substring(1));
                                        if (cari(kata) != 1)
                                        {
                                            kata = temp;
                                        }
                                    }
                                }
                            }
                        }
                        else if (kata.Substring(0, 3).Equals("mem"))
                        {
                            if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                            {
                                kata = "p" + kata.Substring(3);
                                if (cari(kata) != 1)
                                {
                                    kata = temp;
                                }
                            }
                            else
                            {
                                kata = kata.Substring(3);
                                if (cari(kata) != 1)
                                {
                                    kata = temp;
                                }
                            }
                        }
                    }
                }

                else if (kata.Substring(0, 4).Equals("peng"))
                {
                    if (kata.Substring(4, 1).Equals("e") || kata.Substring(4, 1).Equals("a"))
                    {
                        kata = "k" + kata.Substring(4);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                    else
                    {
                        kata = kata.Substring(4);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                }
                else if (kata.Substring(0, 4).Equals("peny"))
                {
                    kata = "s" + kata.Substring(4);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 3).Equals("pen"))
                {
                    if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                    {
                        kata = "t" + kata.Substring(3);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                    else
                    {
                        kata = kata.Substring(3);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                }
                else if (kata.Substring(0, 3).Equals("pem"))
                {
                    if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                    {
                        kata = "p" + kata.Substring(3);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                    else
                    {
                        kata = kata.Substring(3);
                        if (cari(kata) != 1)
                        {
                            kata = temp;
                        }
                    }
                }
                else if (kata.Substring(0, 2).Equals("di"))
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 3).Equals("ter"))
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 2).Equals("ke"))
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 2).Equals("pe") && kata.Length > 5)
                {
                    kata = kata.Substring(2);

                    if (cari(kata) != 1)
                    {
                        kata = temp;
                        if (kata.Substring(0, 3).Equals("pel"))
                        {
                            kata = kata.Substring(3);
                            if (cari(kata) != 1)
                            {
                                kata = temp;
                            }
                        }
                    }
                }
                else if (kata.Substring(0, 3).Equals("ber"))
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
            }
            if (cari(kata) != 1)
            {
                kata = temp2;
            }
            return kata;
        }

        public string hapusawalan2(string kata)
        {
            string temp = kata;
            if (cari(kata) != 1)
            {
                if (kata.Substring(0, 3).Equals("ber"))
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 3).Equals("bel"))
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 2).Equals("be"))
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 3).Equals("per") && kata.Length > 5)
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 2).Equals("pe") && kata.Length > 5)
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 3).Equals("pel") && kata.Length > 5)
                {
                    kata = kata.Substring(3);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
                else if (kata.Substring(0, 2).Equals("se") && kata.Length > 5)
                {
                    kata = kata.Substring(2);
                    if (cari(kata) != 1)
                    {
                        kata = temp;
                    }
                }
            }
            return kata;
        }

        public string hapusakhiran(string kata)
        {
            string temp2 = kata;
            if (cari(kata) != 1)
            {
                string temp = hapusawalan12(kata);
                if (cari(temp) != 1)
                {
                    kata = temp;
                    if (kata.Substring(kata.Length - 3).Equals("kan"))
                    {
                        kata = kata.Substring(0, kata.Length - 3);
                    }
                    else
                        if (kata.Substring(kata.Length - 1).Equals("i"))
                        {
                            kata = kata.Substring(0, kata.Length - 1);
                        }
                        else
                            if (kata.Substring(kata.Length - 3).Equals("nya"))
                            {
                                kata = kata.Substring(0, kata.Length - 3);
                            }
                }

                if (cari(kata) != 1)
                {
                    kata = temp;
                    if (kata.Substring(kata.Length - 2).Equals("an"))
                    {
                        kata = kata.Substring(0, kata.Length - 2);
                    }
                }
            }
            if (cari(kata) != 1)
            {
                kata = temp2;
            }
            return kata;
        }
        public string hapusawalan12(string kata)
        {
            if (cari(kata) != 1)
            {
                string temp = kata;

                if (cari(kata) != 1)
                {
                    kata = temp;

                    if (kata.Substring(0, 3).Equals("men"))
                    {
                        if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                        {
                            kata = "t" + kata.Substring(3);
                        }
                        else
                        {
                            kata = kata.Substring(3);
                        }
                    }
                    else if (kata.Substring(0, 3).Equals("mem"))
                    {
                        if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                        {
                            kata = "p" + kata.Substring(3);
                        }
                        else
                        {
                            kata = kata.Substring(3);
                        }
                    }

                    if (kata.Substring(0, 4).Equals("meng"))
                    {
                        kata = (kata.Substring(4));
                        if (cari(kata) != 1)
                        {
                            kata = "k" + kata;
                        }
                    }
                    else if (kata.Substring(0, 4).Equals("meny"))
                    {
                        kata = ("s" + kata.Substring(4));

                        if (cari(kata) != 1)
                        {
                            kata = ("k" + kata.Substring(1));
                        }
                    }

                    else if (kata.Substring(0, 4).Equals("peng"))
                    {
                        if (kata.Substring(4, 1).Equals("e") || kata.Substring(4, 1).Equals("a"))
                        {
                            kata = "k" + kata.Substring(4);
                        }
                        else
                        {
                            kata = kata.Substring(4);
                        }
                    }
                    else if (kata.Substring(0, 4).Equals("peny"))
                    {
                        kata = "s" + kata.Substring(4);
                    }
                    else if (kata.Substring(0, 3).Equals("pen"))
                    {
                        if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                        {
                            kata = "t" + kata.Substring(3);
                        }
                        else
                        {
                            kata = kata.Substring(3);
                        }
                    }
                    else if (kata.Substring(0, 3).Equals("pem"))
                    {
                        if (kata.Substring(3, 1).Equals("a") || kata.Substring(3, 1).Equals("i") || kata.Substring(3, 1).Equals("e") || kata.Substring(3, 1).Equals("u") || kata.Substring(3, 1).Equals("o"))
                        {
                            kata = "p" + kata.Substring(3);
                        }
                        else
                        {
                            kata = kata.Substring(3);
                        }
                    }
                    else if (kata.Substring(0, 2).Equals("di"))
                    {
                        kata = kata.Substring(2);
                    }
                    else if (kata.Substring(0, 2).Equals("ke"))
                    {
                        kata = kata.Substring(2);
                    }
                    else if (kata.Substring(0, 3).Equals("ter"))
                    {
                        kata = kata.Substring(3);
                    }
                    else if (kata.Substring(0, 2).Equals("pe") && kata.Length > 5)
                    {
                        kata = kata.Substring(2);
                    }
                    else if (kata.Substring(0, 3).Equals("ber"))
                    {
                        kata = kata.Substring(3);
                    }
                }
            }
            return kata;
        }

        public string hapusakhiran2(string kata)
        {
            string temp = kata;
            if (kata.Substring(0, 2).Equals("me"))
            {
                kata = kata.Substring(2);
                kata = (hapusakhiran(kata));
            }
            else
                if (kata.Substring(0, 3).Equals("pel"))
                {
                    kata = kata.Substring(3);
                }
                else
                    if (kata.Substring(0, 3).Equals("per"))
                    {
                        kata = kata.Substring(3);
                    }

            if (cari(kata) != 1)
            {
                kata = temp;
            }
            return kata;
        }
    }
}
