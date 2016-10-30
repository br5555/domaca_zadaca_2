using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_zadatak5
{
    class Program
    {
        


        public class Student
        {
            public string Name { get; set; }
            public string Jmbag { get; set; }
            public Gender Gender { get; set; }
            public Student(string name, string jmbag)
            {
                Name = name;
                Jmbag = jmbag;
            }
        }
        public enum Gender
        {
            Male = 1
          , Female= 0
        }



        public class Univeristy
        {
            public string Name { get; set; }
            public Student[] Students { get; set; }

            
        }


        static void Main(string[] args)
        {


            Univeristy stomatolgija = new Univeristy();
            Univeristy biologija = new Univeristy();
            Univeristy fer = new Univeristy();
            Univeristy strojarstvo = new Univeristy();
            Univeristy veterina = new Univeristy();
            Univeristy medicina = new Univeristy();
            Univeristy rudarstvo = new Univeristy();
            Univeristy filozofski = new Univeristy();
            Univeristy pravni = new Univeristy();



            stomatolgija.Students = new Student[14];
            fer.Students = new Student[14];
            biologija.Students = new Student[12];
            strojarstvo.Students = new Student[14];
            medicina.Students = new Student[11];
            veterina.Students = new Student[14];
            filozofski.Students = new Student[12];
            rudarstvo.Students = new Student[14];
            pravni.Students = new Student[14];

            Student student1 = new Student("Branko", "0036481316");
            student1.Gender = Gender.Male;
            Student student2 = new Student("Ana", "3036481316");
            student2.Gender = Gender.Female;
            Student student3 = new Student("Ivona", "2036481316");
            student3.Gender = Gender.Female;
            Student student4 = new Student("Hana", "1036472983");
            student4.Gender = Gender.Female;
            Student student5 = new Student("Ivana", "0036485341");
            student5.Gender = Gender.Female;
            Student student6 = new Student("Marina", "0036483983");
            student6.Gender = Gender.Female;
            Student student7 = new Student("Olga", "0032393481");
            student7.Gender = Gender.Female;
            Student student8 = new Student("Tena", "0039180312");
            student8.Gender = Gender.Female;
            Student student9 = new Student("Manda", "0039831912");
            student9.Gender = Gender.Female;
            Student student10 = new Student("Magdalena", "0081839832");
            student10.Gender = Gender.Female;
            Student student11 = new Student("Stipe", "0031918311");
            student11.Gender = Gender.Male;
            Student student12 = new Student("Renato", "0094289421");
            student12.Gender = Gender.Male;
            Student student13 = new Student("Marko", "0019380131");
            student13.Gender = Gender.Male;
            Student student14 = new Student("Ivan", "0091389341");
            student14.Gender = Gender.Male;
            Student student15 = new Student("Jakov", "0098129483");
            student15.Gender = Gender.Male;
            Student student16 = new Student("Filip", "0038193801");
            student16.Gender = Gender.Male;
            Student student17 = new Student("Natalia", "0038428948");
            student17.Gender = Gender.Female;
            Student student18 = new Student("Nika", "0094847731");
            student18.Gender = Gender.Female;
            Student student19 = new Student("Sara", "0038297447");
            student19.Gender = Gender.Female;
            Student student20 = new Student("Vedrana", "0038327482");
            student20.Gender = Gender.Female;
            Student student21 = new Student("Jozefina", "0082842922");
            student21.Gender = Gender.Female;
            Student student22 = new Student("Marijan", "0041312112");
            student22.Gender = Gender.Male;
            Student student23 = new Student("Marijana", "0033143132");
            student23.Gender = Gender.Female;
            Student student24 = new Student("Joško", "0082947223");
            student24.Gender = Gender.Male;
            Student student25 = new Student("Ante", "0075289942");
            student25.Gender = Gender.Male;
            Student student26 = new Student("Roko", "0016482472");
            student26.Gender = Gender.Male;
            Student student27 = new Student("Filip", "0094774372");
            student27.Gender = Gender.Male;
            Student student28 = new Student("Fran", "0031988444");
            student28.Gender = Gender.Male;
            Student student29 = new Student("Maja", "0071873871");
            student29.Gender = Gender.Female;
            Student student30 = new Student("Benedikt", "0037173913");
            student30.Gender = Gender.Male;
            Student student31 = new Student("Jure", "0034772742");
            student31.Gender = Gender.Male;
            Student student32 = new Student("Boban", "0034242312");
            student32.Gender = Gender.Male;
            Student student33 = new Student("Stanko", "0061663112");
            student33.Gender = Gender.Male;
            Student student34 = new Student("Mirko", "0038472782");
            student34.Gender = Gender.Male;
            Student student35 = new Student("Dario", "0076238482");
            student35.Gender = Gender.Male;
            Student student36 = new Student("Luka", "0031341312");
            student36.Gender = Gender.Male;
            Student student37 = new Student("Dominik", "0031736121");
            student37.Gender = Gender.Male;
            Student student38 = new Student("Pavao", "0083813847");
            student38.Gender = Gender.Male;
            Student student39 = new Student("Petar", "0037166313");
            student39.Gender = Gender.Male;
            Student student40 = new Student("Damir", "0019381712");
            student40.Gender = Gender.Male;
            Student student41 = new Student("Antun", "0039193413");
            student41.Gender = Gender.Male;
            Student student42 = new Student("Antonio", "0032896428");
            student42.Gender = Gender.Male;
            Student student43 = new Student("Maroje", "0036980284");
            student43.Gender = Gender.Male;
            Student student44 = new Student("Marin", "0036481575");
            student44.Gender = Gender.Male;
            Student student45 = new Student("Lidija", "0018371711");
            student45.Gender = Gender.Female;
            Student student46 = new Student("Mia", "0082472242");
            student46.Gender = Gender.Female;
            Student student47 = new Student("Renata", "0035322311");
            student47.Gender = Gender.Female;
            Student student48 = new Student("Iva", "0036353422");
            student48.Gender = Gender.Female;
            Student student49 = new Student("Nikolina", "0036646433");
            student49.Gender = Gender.Female;
            Student student50 = new Student("Predrag", "0036134145");
            student50.Gender = Gender.Male;
            Student student51 = new Student("Marcelo", "0036331431");
            student51.Gender = Gender.Male;
            Student student52 = new Student("Konrad", "0036183781");
            student52.Gender = Gender.Male;
            Student student53 = new Student("Robert", "0036131312");
            student53.Gender = Gender.Male;
            Student student54 = new Student("Andrija", "0036198313");
            student54.Gender = Gender.Female;
            Student student55 = new Student("Andriana", "0036144542");
            student55.Gender = Gender.Female;
            Student student56 = new Student("Tamara", "0039999133");
            student56.Gender = Gender.Female;
            Student student57 = new Student("Anamaria", "0036414145");
            student57.Gender = Gender.Female;
            Student student58 = new Student("Marija", "0031314413");
            student58.Gender = Gender.Female;
            Student student59 = new Student("Antonia", "0036131819");
            student59.Gender = Gender.Female;
            Student student60 = new Student("Julija", "0036924884");
            student60.Gender = Gender.Female;
            Student student61 = new Student("Albert", "0036488494");
            student61.Gender = Gender.Male;
            Student student62 = new Student("Berislav", "0036314244");
            student62.Gender = Gender.Male;
            Student student63 = new Student("Bernard", "0036494274");
            student63.Gender = Gender.Male;
            Student student64 = new Student("Bosiljko", "0036858353");
            student64.Gender = Gender.Male;
            Student student65 = new Student("Bozidar", "0036445556");
            student65.Gender = Gender.Male;
            Student student66 = new Student("Branimir", "0036431556");
            student66.Gender = Gender.Male;
            Student student67 = new Student("Mato", "0036341424");
            student67.Gender = Gender.Male;
            Student student68 = new Student("Budimir", "0036444424");
            student68.Gender = Gender.Male;
            Student student69 = new Student("Benjamin", "0036141411");
            student69.Gender = Gender.Male;
            Student student70 = new Student("Karlo", "0036431414");
            student70.Gender = Gender.Male;
            Student student71 = new Student("Kazimir", "0036413314");
            student71.Gender = Gender.Male;
            Student student72 = new Student("Krešimir", "0036443242");
            student72.Gender = Gender.Male;
            Student student73 = new Student("Kristijan", "0032425524");
            student73.Gender = Gender.Male;
            Student student74 = new Student("Jozo", "0036245244");
            student74.Gender = Gender.Male;
            Student student75 = new Student("Krunoslav", "0036484244");
            student75.Gender = Gender.Male;
            Student student76 = new Student("Lorena", "0036485245");
            student76.Gender = Gender.Female;
            Student student77 = new Student("Petra", "0036757456");
            student77.Gender = Gender.Female;
            Student student78 = new Student("Stanko", "0036746643");
            student78.Gender = Gender.Male;
            Student student79 = new Student("Aleksandar", "0036646463");
            student79.Gender = Gender.Male;
            Student student80 = new Student("Miroslav", "0036245525");
            student80.Gender = Gender.Male;
            Student student81 = new Student("Tomisalv", "0036134142");
            student81.Gender = Gender.Male;
            Student student82 = new Student("Trpimir", "0036456623");
            student82.Gender = Gender.Male;
            Student student83 = new Student("Zvonimir", "0036424452");
            student83.Gender = Gender.Male;
            Student student84 = new Student("Manuel", "0036481399");
            student84.Gender = Gender.Male;
            Student student85 = new Student("Mario", "0036481388");
            student85.Gender = Gender.Male;
            Student student86 = new Student("Viktor", "0036481377");
            student86.Gender = Gender.Male;
            Student student87 = new Student("Mislav", "0036481445");
            student87.Gender = Gender.Male;
            Student student88 = new Student("Cujo", "0036481311");
            student88.Gender = Gender.Male;
            Student student89 = new Student("Mladen", "0036481315");
            student89.Gender = Gender.Male;
            Student student90 = new Student("Martin", "0036481314");
            student90.Gender = Gender.Male;
            Student student91 = new Student("Neven", "0036483141");
            student91.Gender = Gender.Male;
            Student student92 = new Student("Nikola", "0036483134");
            student92.Gender = Gender.Male;
            Student student93 = new Student("Nenad", "0036413412");
            student93.Gender = Gender.Male;
            Student student94 = new Student("Ninoslav", "0036481221");
            student94.Gender = Gender.Male;
            Student student95 = new Student("Patrik", "0036481313");
            student95.Gender = Gender.Male;
            Student student96 = new Student("Vinko", "0036481231");
            student96.Gender = Gender.Male;
            Student student97 = new Student("Vladimir", "0036481321");
            student97.Gender = Gender.Male;





            filozofski.Students[0] = student8;
            filozofski.Students[1] = student80;
            filozofski.Students[2] = student81;
            filozofski.Students[3] = student82;
            filozofski.Students[4] = student83;
            filozofski.Students[5] = student84;
            filozofski.Students[6] = student85;
            filozofski.Students[7] = student86;
            filozofski.Students[8] = student87;
            filozofski.Students[9] = student88;
            filozofski.Students[10] = student89;
            filozofski.Students[11] = student93;


            biologija.Students[0] = student1;
            biologija.Students[1] = student93;
            biologija.Students[2] = student94;
            biologija.Students[3] = student95;
            biologija.Students[4] = student96;
            biologija.Students[5] = student97;
            biologija.Students[6] = student33;
            biologija.Students[7] = student44;
            biologija.Students[8] = student53;
            biologija.Students[9] = student66;
            biologija.Students[10] = student73;
            biologija.Students[11] = student78;

            veterina.Students[0] = student4;
            veterina.Students[1] = student40;
            veterina.Students[2] = student41;
            veterina.Students[3] = student42;
            veterina.Students[4] = student43;
            veterina.Students[5] = student44;
            veterina.Students[6] = student45;
            veterina.Students[7] = student46;
            veterina.Students[8] = student47;
            veterina.Students[9] = student48;
            veterina.Students[10] = student49;
            veterina.Students[11] = student93;
            veterina.Students[12] = student41;
            veterina.Students[13] = student42;



            stomatolgija.Students[0] = student2;
            stomatolgija.Students[1] = student20;
            stomatolgija.Students[2] = student21;
            stomatolgija.Students[3] = student22;
            stomatolgija.Students[4] = student23;
            stomatolgija.Students[5] = student24;
            stomatolgija.Students[6] = student25;
            stomatolgija.Students[7] = student26;
            stomatolgija.Students[8] = student27;
            stomatolgija.Students[9] = student28;
            stomatolgija.Students[10] = student29;
            stomatolgija.Students[11] = student2;
            stomatolgija.Students[12] = student41;
            stomatolgija.Students[13] = student42;

            fer.Students[0] = student1;
            fer.Students[1] = student10;
            fer.Students[2] = student11;
            fer.Students[3] = student12;
            fer.Students[4] = student13;
            fer.Students[5] = student14;
            fer.Students[6] = student15;
            fer.Students[7] = student16;
            fer.Students[8] = student17;
            fer.Students[9] = student18;
            fer.Students[10] = student19;
            fer.Students[11] = student2;
            fer.Students[12] = student40;
            fer.Students[13] = student41;

            strojarstvo.Students[0] = student3;
            strojarstvo.Students[1] = student30;
            strojarstvo.Students[2] = student31;
            strojarstvo.Students[3] = student32;
            strojarstvo.Students[4] = student33;
            strojarstvo.Students[5] = student34;
            strojarstvo.Students[6] = student35;
            strojarstvo.Students[7] = student36;
            strojarstvo.Students[8] = student37;
            strojarstvo.Students[9] = student38;
            strojarstvo.Students[10] = student39;
            strojarstvo.Students[11] = student93;
            strojarstvo.Students[12] = student42;
            strojarstvo.Students[13] = student67;

            rudarstvo.Students[0] = student5;
            rudarstvo.Students[1] = student50;
            rudarstvo.Students[2] = student51;
            rudarstvo.Students[3] = student52;
            rudarstvo.Students[4] = student53;
            rudarstvo.Students[5] = student54;
            rudarstvo.Students[6] = student55;
            rudarstvo.Students[7] = student56;
            rudarstvo.Students[8] = student57;
            rudarstvo.Students[9] = student58;
            rudarstvo.Students[10] = student59;
            rudarstvo.Students[11] = student93;
            rudarstvo.Students[12] = student67;
            rudarstvo.Students[13] = student66;

            pravni.Students[0] = student7;
            pravni.Students[1] = student70;
            pravni.Students[2] = student71;
            pravni.Students[3] = student72;
            pravni.Students[4] = student73;
            pravni.Students[5] = student74;
            pravni.Students[6] = student75;
            pravni.Students[7] = student76;
            pravni.Students[8] = student77;
            pravni.Students[9] = student78;
            pravni.Students[10] = student79;
            pravni.Students[11] = student93;
            pravni.Students[12] = student67;
            pravni.Students[13] = student66;

            medicina.Students[0] = student96;
            medicina.Students[1] = student70;
            medicina.Students[2] = student61;
            medicina.Students[3] = student62;
            medicina.Students[4] = student63;
            medicina.Students[5] = student64;
            medicina.Students[6] = student65;
            medicina.Students[7] = student66;
            medicina.Students[8] = student67;
            medicina.Students[9] = student68;
            medicina.Students[10] = student69;

            stomatolgija.Name = "Stomatologija";
            biologija.Name = "Biologija";
            fer.Name = "Fakultet elektrotehnike i računarstva";
            medicina.Name = "Medicina";
            pravni.Name = "Pravo";
            filozofski.Name = "Filozofski";
            rudarstvo.Name = "Rudarstvo";
            veterina.Name = "Veterina";
            strojarstvo.Name = "Strojarstvo";
            List<Univeristy> Fakulteti = new List<Univeristy>();
            Fakulteti.Add(stomatolgija);
            Fakulteti.Add(biologija);
            Fakulteti.Add(fer);
            Fakulteti.Add(medicina);
            Fakulteti.Add(pravni);
            Fakulteti.Add(filozofski);
            Fakulteti.Add(rudarstvo);
            Fakulteti.Add(veterina);
            Fakulteti.Add(strojarstvo);








            
            Student[] studentiIzRH = (Fakulteti.SelectMany(i => i.Students)).Distinct().ToArray();
            foreach (Student g in studentiIzRH)
            {
                Console.WriteLine(g.Name);
            }


            Student[] StudentiNaViseFakulteta = (Fakulteti.SelectMany(i => i.Students)).GroupBy(el => el.Jmbag).Where(g => g.Count() > 1).Select(g => g.First()).ToArray();
            foreach (Student g in StudentiNaViseFakulteta)
            {
                Console.WriteLine(g.Name);
            }


            Univeristy[] SamoMFakulteti = Fakulteti.Where(i => !i.Students.Any(s => s.Gender == Gender.Female)).ToArray();
            foreach(Univeristy g in SamoMFakulteti)
            {
                Console.WriteLine(g.Name);
            }
 


            Console.Read();
        }
    }
}
