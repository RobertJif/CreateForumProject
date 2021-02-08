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
    public partial class Dashboard_G20SI : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("Insert into Forum_postg20(username, posttitle, postmessage) values ('" + user1 + "','" + txtposttitle.Text + "', '" + txtpostmessage.InnerText.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/Home_G20SI.aspx");

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
                indonesia = 0, dunia = 0, olahraga = 0, main = 0, piala = 0, liga = 0, juara = 0, atlet = 0, tim = 0, gelar = 0, madrid = 0, lima = 0, futsal = 0, sepakbola = 0, cantik = 0, tinju = 0, barcelona = 0, raih = 0, tiga = 0, para = 0, hasil = 0, skor = 0, lolos = 0, pekan = 0, negara = 0, basket = 0, dalam = 0, tahun = 0, vs = 0, timnas = 0, real = 0, klub = 0, musim = 0, ajang = 0, emas = 0, laga = 0, dua = 0, babak = 0, napoli = 0, ronaldo = 0, city = 0, renang = 0, league = 0,
                pilkada = 0, jadi = 0, koruptor = 0, mentri = 0, jokowi = 0, pilih = 0, vaksin = 0, sinovac = 0, kpk = 0, minta = 0, ingin = 0, pimpin = 0, akan = 0, korupsi = 0, hoax = 0, ahok = 0, buka = 0, pemprov = 0, dki = 0, polri = 0, janji = 0, dpr = 0, ekspor = 0, tugas = 0, presiden = 0,
                jabatan = 0, calon = 0, pajak = 0, jelang = 0, politik = 0, lagi = 0, industri = 0, google = 0, realme = 0, whatsapp = 0, mediatek = 0, program = 0, wifi = 0, baru = 0, hadir = 0, tips = 0, laptop = 0, aman = 0, guna = 0, xiaomi = 0, performa = 0, harga = 0, teknologi = 0, smartphone = 0, drone = 0, teleskop = 0, milik = 0, chipset = 0,
                snapdragon = 0, aplikasi = 0, cari = 0, hp = 0, kita = 0, bisa = 0, cepat = 0, situs = 0, robot = 0, jepang = 0, foto = 0, gratis = 0, cipta = 0, game = 0, spesifikasi = 0, pc = 0, mobile = 0, video = 0, banyak = 0, lebih = 0, grafik = 0, paling = 0, umum = 0, cyberpunk = 0, terbaik = 0, jago = 0, ps = 0, rilis = 0, amoungus = 0, legend = 0, freefire = 0, steam = 0;
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
                    else if (kata[j] == "pilkada")
                    {
                        pilkada = 1;
                    }
                    else if (kata[j] == "jadi")
                    {
                        jadi = 1;
                    }
                    else if (kata[j] == "koruptor")
                    {
                        koruptor = 1;
                    }
                    else if (kata[j] == "mentri")
                    {
                        mentri = 1;
                    }
                    else if (kata[j] == "jokowi")
                    {
                        jokowi = 1;
                    }
                    else if (kata[j] == "pilih")
                    {
                        pilih = 1;
                    }
                    else if (kata[j] == "vaksin")
                    {
                        vaksin = 1;
                    }
                    else if (kata[j] == "sinovac")
                    {
                        sinovac = 1;
                    }
                    else if (kata[j] == "kpk")
                    {
                        kpk = 1;
                    }
                    else if (kata[j] == "minta")
                    {
                        minta = 1;
                    }
                    else if (kata[j] == "ingin")
                    {
                        ingin = 1;
                    }
                    else if (kata[j] == "pimpin")
                    {
                        pimpin = 1;
                    }
                    else if (kata[j] == "akan")
                    {
                        akan = 1;
                    }
                    else if (kata[j] == "korupsi")
                    {
                        korupsi = 1;
                    }
                    else if (kata[j] == "hoax")
                    {
                        hoax = 1;
                    }
                    else if (kata[j] == "ahok")
                    {
                        ahok = 1;
                    }
                    else if (kata[j] == "buka")
                    {
                        buka = 1;
                    }
                    else if (kata[j] == "pemprov")
                    {
                        pemprov = 1;
                    }
                    else if (kata[j] == "dki")
                    {
                        dki = 1;
                    }
                    else if (kata[j] == "polri")
                    {
                        polri = 1;
                    }
                    else if (kata[j] == "janji")
                    {
                        janji = 1;
                    }
                    else if (kata[j] == "dpr")
                    {
                        dpr = 1;
                    }
                    else if (kata[j] == "ekspor")
                    {
                        ekspor = 1;
                    }
                    else if (kata[j] == "tugas")
                    {
                        tugas = 1;
                    }
                    else if (kata[j] == "presiden")
                    {
                        presiden = 1;
                    }
                    else if (kata[j] == "jabatan")
                    {
                        jabatan = 1;
                    }
                    else if (kata[j] == "calon")
                    {
                        calon = 1;
                    }
                    else if (kata[j] == "pajak")
                    {
                        pajak = 1;
                    }
                    else if (kata[j] == "jelang")
                    {
                        jelang = 1;
                    }
                    else if (kata[j] == "politik")
                    {
                        politik = 1;
                    }
                    else if (kata[j] == "lagi")
                    {
                        lagi = 1;
                    }
                    else if (kata[j] == "industri")
                    {
                        industri = 1;
                    }
                    else if (kata[j] == "google")
                    {
                        google = 1;
                    }
                    else if (kata[j] == "realme")
                    {
                        realme = 1;
                    }
                    else if (kata[j] == "whatsapp")
                    {
                        whatsapp = 1;
                    }
                    else if (kata[j] == "mediatek")
                    {
                        mediatek = 1;
                    }
                    else if (kata[j] == "program")
                    {
                        program = 1;
                    }
                    else if (kata[j] == "wifi")
                    {
                        wifi = 1;
                    }
                    else if (kata[j] == "baru")
                    {
                        baru = 1;
                    }
                    else if (kata[j] == "hadir")
                    {
                        hadir = 1;
                    }
                    else if (kata[j] == "tips")
                    {
                        tips = 1;
                    }
                    else if (kata[j] == "laptop")
                    {
                        laptop = 1;
                    }
                    else if (kata[j] == "aman")
                    {
                        aman = 1;
                    }
                    else if (kata[j] == "guna")
                    {
                        guna = 1;
                    }
                    else if (kata[j] == "xiaomi")
                    {
                        xiaomi = 1;
                    }
                    else if (kata[j] == "performa")
                    {
                        performa = 1;
                    }
                    else if (kata[j] == "harga")
                    {
                        harga = 1;
                    }
                    else if (kata[j] == "teknologi")
                    {
                        teknologi = 1;
                    }
                    else if (kata[j] == "smartphone")
                    {
                        smartphone = 1;
                    }
                    else if (kata[j] == "drone")
                    {
                        drone = 1;
                    }
                    else if (kata[j] == "teleskop")
                    {
                        teleskop = 1;
                    }
                    else if (kata[j] == "milik")
                    {
                        milik = 1;
                    }
                    else if (kata[j] == "chipset")
                    {
                        chipset = 1;
                    }
                    else if (kata[j] == "snapdragon")
                    {
                        snapdragon = 1;
                    }
                    else if (kata[j] == "aplikasi")
                    {
                        aplikasi = 1;

                    }
                    else if (kata[j] == "cari")
                    {
                        cari = 1;

                    }

                    else if (kata[j] == "hp")
                    {
                        hp = 1;

                    }
                    else if (kata[j] == "kita")
                    {
                        kita = 1;

                    }
                    else if (kata[j] == "bisa")
                    {
                        bisa = 1;

                    }
                    else if (kata[j] == "cepat")
                    {
                        cepat = 1;
                    }
                    else if (kata[j] == "situs")
                    {
                        situs = 1;

                    }
                    else if (kata[j] == "robot")
                    {
                        robot = 1;

                    }
                    else if (kata[j] == "jepang")
                    {
                        jepang = 1;

                    }
                    else if (kata[j] == "foto")
                    {
                        foto = 1;

                    }
                    else if (kata[j] == "gratis")
                    {
                        gratis = 1;
                    }
                    else if (kata[j] == "cipta")
                    {
                        cipta = 1;

                    }
                    else if (kata[j] == "game")
                    {
                        game = 1;

                    }
                    else if (kata[j] == "spesifikasi")
                    {
                        spesifikasi = 1;

                    }
                    else if (kata[j] == "pc")
                    {
                        pc = 1;

                    }
                    else if (kata[j] == "mobile")
                    {
                        mobile = 1;

                    }
                    else if (kata[j] == "video")
                    {
                        video = 1;

                    }
                    else if (kata[j] == "banyak")
                    {
                        banyak = 1;

                    }
                    else if (kata[j] == "lebih")
                    {
                        lebih = 1;

                    }
                    else if (kata[j] == "grafik")
                    {
                        grafik = 1;

                    }
                    else if (kata[j] == "paling")
                    {
                        paling = 1;

                    }
                    else if (kata[j] == "umum")
                    {
                        umum = 1;

                    }
                    else if (kata[j] == "cyberpunk")
                    {
                        cyberpunk = 1;

                    }
                    else if (kata[j] == "terbaik")
                    {
                        terbaik = 1;

                    }
                    else if (kata[j] == "jago")
                    {
                        jago = 1;

                    }
                    else if (kata[j] == "ps")
                    {
                        ps = 1;

                    }
                    else if (kata[j] == "rilis")
                    {
                        rilis = 1;

                    }
                    else if (kata[j] == "amoungus")
                    {
                        amoungus = 1;

                    }
                    else if (kata[j] == "legend")
                    {
                        legend = 1;

                    }
                    else if (kata[j] == "freefire")
                    {
                        freefire = 1;

                    }
                    else if (kata[j] == "steam")
                    {
                        steam = 1;

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
                    + Math.Pow(barcelona - cari2("barcelona", i + 1), 2) + Math.Pow(raih - cari2("raih", i + 1), 2)
                    + Math.Pow(tiga - cari2("tiga", i + 1), 2) + Math.Pow(para - cari2("para", i + 1), 2)
                    + Math.Pow(hasil - cari2("hasil", i + 1), 2) + Math.Pow(skor - cari2("skor", i + 1), 2) + Math.Pow(lolos - cari2("lolos", i + 1), 2)
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
                    + Math.Pow(pilkada - cari2("pilkada", i + 1), 2) + Math.Pow(jadi - cari2("jadi", i + 1), 2)
                    + Math.Pow(koruptor - cari2("koruptor", i + 1), 2) + Math.Pow(mentri - cari2("mentri", i + 1), 2)
                    + Math.Pow(jokowi - cari2("jokowi", i + 1), 2) + Math.Pow(pilih - cari2("pilih", i + 1), 2)
                    + Math.Pow(vaksin - cari2("vaksin", i + 1), 2) + Math.Pow(sinovac - cari2("sinovac", i + 1), 2)
                    + Math.Pow(kpk - cari2("kpk", i + 1), 2) + Math.Pow(minta - cari2("minta", i + 1), 2) + Math.Pow(ingin - cari2("ingin", i + 1), 2)
                    + Math.Pow(pimpin - cari2("pimpin", i + 1), 2) + Math.Pow(akan - cari2("akan", i + 1), 2)
                    + Math.Pow(korupsi - cari2("korupsi", i + 1), 2) + Math.Pow(hoax - cari2("hoax", i + 1), 2)
                    + Math.Pow(ahok - cari2("ahok", i + 1), 2) + Math.Pow(buka - cari2("buka", i + 1), 2)
                    + Math.Pow(pemprov - cari2("pemprov", i + 1), 2) + Math.Pow(dki - cari2("dki", i + 1), 2)
                    + Math.Pow(polri - cari2("polri", i + 1), 2) + Math.Pow(janji - cari2("janji", i + 1), 2)
                    + Math.Pow(dpr - cari2("dpr", i + 1), 2) + Math.Pow(ekspor - cari2("ekspor", i + 1), 2)
                    + Math.Pow(tugas - cari2("tugas", i + 1), 2) + Math.Pow(presiden - cari2("presiden", i + 1), 2)
                    + Math.Pow(jabatan - cari2("jabatan", i + 1), 2) + Math.Pow(calon - cari2("calon", i + 1), 2)
                    + Math.Pow(pajak - cari2("pajak", i + 1), 2) + Math.Pow(jelang - cari2("jelang", i + 1), 2)
                    + Math.Pow(politik - cari2("politik", i + 1), 2) + Math.Pow(lagi - cari2("lagi", i + 1), 2)
                    + Math.Pow(industri - cari2("industri", i + 1), 2) + Math.Pow(google - cari2("google", i + 1), 2)
                    + Math.Pow(realme - cari2("realme", i + 1), 2) + Math.Pow(whatsapp - cari2("whatsapp", i + 1), 2)
                    + Math.Pow(mediatek - cari2("mediatek", i + 1), 2) + Math.Pow(program - cari2("program", i + 1), 2)
                    + Math.Pow(wifi - cari2("wifi", i + 1), 2) + Math.Pow(baru - cari2("baru", i + 1), 2)
                    + Math.Pow(hadir - cari2("hadir", i + 1), 2) + Math.Pow(tips - cari2("tips", i + 1), 2)
                    + Math.Pow(laptop - cari2("laptop", i + 1), 2) + Math.Pow(aman - cari2("aman", i + 1), 2)
                    + Math.Pow(guna - cari2("guna", i + 1), 2) + Math.Pow(xiaomi - cari2("xiaomi", i + 1), 2)
                    + Math.Pow(performa - cari2("performa", i + 1), 2) + Math.Pow(harga - cari2("harga", i + 1), 2)
                    + Math.Pow(teknologi - cari2("teknologi", i + 1), 2) + Math.Pow(smartphone - cari2("smartphone", i + 1), 2)
                    + Math.Pow(drone - cari2("drone", i + 1), 2) + Math.Pow(teleskop - cari2("teleskop", i + 1), 2)
                    + Math.Pow(milik - cari2("milik", i + 1), 2) + Math.Pow(chipset - cari2("chipset", i + 1), 2)
                    + Math.Pow(snapdragon - cari2("snapdragon", i + 1), 2) + Math.Pow(aplikasi - cari2("aplikasi", i + 1), 2) + Math.Pow(cari - cari2("cari", i + 1), 2)
                    + Math.Pow(hp - cari2("hp", i + 1), 2) + Math.Pow(kita - cari2("kita", i + 1), 2)
                    + Math.Pow(bisa - cari2("bisa", i + 1), 2) + Math.Pow(cepat - cari2("cepat", i + 1), 2)
                    + Math.Pow(situs - cari2("situs", i + 1), 2) + Math.Pow(robot - cari2("robot", i + 1), 2)
                    + Math.Pow(jepang - cari2("jepang", i + 1), 2) + Math.Pow(foto - cari2("foto", i + 1), 2)
                    + Math.Pow(gratis - cari2("gratis", i + 1), 2) + Math.Pow(cipta - cari2("cipta", i + 1), 2)
                    + Math.Pow(game - cari2("game", i + 1), 2) + Math.Pow(spesifikasi - cari2("spesifikasi", i + 1), 2)
                    + Math.Pow(pc - cari2("pc", i + 1), 2) + Math.Pow(mobile - cari2("mobile", i + 1), 2)
                    + Math.Pow(video - cari2("video", i + 1), 2) + Math.Pow(banyak - cari2("banyak", i + 1), 2)
                    + Math.Pow(lebih - cari2("lebih", i + 1), 2) + Math.Pow(grafik - cari2("grafik", i + 1), 2)
                    + Math.Pow(paling - cari2("paling", i + 1), 2) + Math.Pow(umum - cari2("umum", i + 1), 2)
                    + Math.Pow(cyberpunk - cari2("cyberpunk", i + 1), 2) + Math.Pow(terbaik - cari2("terbaik", i + 1), 2)
                    + Math.Pow(jago - cari2("jago", i + 1), 2) + Math.Pow(ps - cari2("ps", i + 1), 2)
                    + Math.Pow(rilis - cari2("rilis", i + 1), 2) + Math.Pow(amoungus - cari2("amoungus", i + 1), 2)
                    + Math.Pow(legend - cari2("legend", i + 1), 2) + Math.Pow(freefire - cari2("freefire", i + 1), 2)
                    + Math.Pow(steam - cari2("steam", i + 1), 2);





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
            int a_edukasi = 0, a_olahraga = 0, a_politik = 0, a_teknologi = 0, a_game = 0;
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
                if (kategori[i].Contains("politik"))
                {
                    a_politik++;
                }
                if (kategori[i].Contains("teknologi"))
                {
                    a_teknologi++;
                }
                if (kategori[i].Contains("game"))
                {
                    a_game++;
                }
            }
            if (a_edukasi >= a_olahraga && a_edukasi >= a_politik && a_edukasi >= a_teknologi && a_edukasi >= a_game)
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
            else if (a_olahraga >= a_edukasi && a_olahraga >= a_politik && a_olahraga >= a_teknologi && a_olahraga >= a_game)
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
            else if (a_politik >= a_edukasi && a_politik >= a_olahraga && a_politik >= a_teknologi && a_politik >= a_game)
            {
                kat_akhir = "politik";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasipolitik(politik) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else if (a_teknologi >= a_edukasi && a_teknologi >= a_olahraga && a_teknologi >= a_politik && a_teknologi >= a_game)
            {
                kat_akhir = "teknologi";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasiteknologi(teknologi) values ('" + txtposttitle.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("Insert into semuatopik(topik, kategori) values ('" + txtposttitle.Text + "','" + kat_akhir + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else if (a_game >= a_edukasi && a_game >= a_olahraga && a_game >= a_politik && a_game >= a_teknologi)
            {
                kat_akhir = "game";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Insert into klasifikasi_game(game) values ('" + txtposttitle.Text + "')", con);
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
            string query = "Select count(*) from kata_dasar2 where kata_dasar='" + kata + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }

        public int cari2(string kata, int ind)
        {
            int count = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            string query = "Select " + kata + " from datatraining where id_dtr='" + ind + "'";
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
            string query = "Select kategori from datatraining where id_dtr='" + ind + "'";
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
            string query = "Select count(*) from datatraining";
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