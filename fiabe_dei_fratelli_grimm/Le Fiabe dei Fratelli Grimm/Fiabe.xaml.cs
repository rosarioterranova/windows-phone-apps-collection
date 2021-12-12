using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Le_Fiabe_dei_Fratelli_Grimm
{
    public partial class Fiabe : PhoneApplicationPage
    {
        int indice;
        string[] listaFiabe = { 
                                  "Fiabe/001.txt", "Fiabe/002.txt", "Fiabe/003.txt", "Fiabe/004.txt", "Fiabe/005.txt", "Fiabe/006.txt", "Fiabe/007.txt", "Fiabe/008.txt", "Fiabe/009.txt", "Fiabe/010.txt",
                                  "Fiabe/011.txt", "Fiabe/012.txt", "Fiabe/013.txt", "Fiabe/014.txt", "Fiabe/015.txt", "Fiabe/016.txt", "Fiabe/017.txt", "Fiabe/018.txt", "Fiabe/019.txt", "Fiabe/020.txt",
                                  "Fiabe/021.txt", "Fiabe/022.txt", "Fiabe/023.txt", "Fiabe/024.txt", "Fiabe/025.txt", "Fiabe/026.txt", "Fiabe/027.txt", "Fiabe/028.txt", "Fiabe/029.txt", "Fiabe/030.txt",
                                  "Fiabe/031.txt", "Fiabe/032.txt", "Fiabe/033.txt", "Fiabe/034.txt", "Fiabe/035.txt", "Fiabe/036.txt", "Fiabe/037.txt", "Fiabe/038.txt", "Fiabe/039.txt", "Fiabe/040.txt",
                                  "Fiabe/041.txt", "Fiabe/042.txt", "Fiabe/043.txt", "Fiabe/044.txt", "Fiabe/045.txt", "Fiabe/046.txt", "Fiabe/047.txt", "Fiabe/048.txt", "Fiabe/049.txt", "Fiabe/050.txt",
                                  "Fiabe/051.txt", "Fiabe/052.txt", "Fiabe/053.txt", "Fiabe/054.txt", "Fiabe/055.txt", "Fiabe/056.txt", "Fiabe/057.txt", "Fiabe/058.txt", "Fiabe/059.txt", "Fiabe/060.txt",
                                  "Fiabe/061.txt", "Fiabe/062.txt", "Fiabe/063.txt", "Fiabe/064.txt", "Fiabe/065.txt", "Fiabe/066.txt", "Fiabe/067.txt", "Fiabe/068.txt", "Fiabe/069.txt", "Fiabe/070.txt",
                                  "Fiabe/071.txt", "Fiabe/072.txt", "Fiabe/073.txt", "Fiabe/074.txt", "Fiabe/075.txt", "Fiabe/076.txt", "Fiabe/077.txt", "Fiabe/078.txt", "Fiabe/079.txt", "Fiabe/080.txt",
                                  "Fiabe/081.txt", "Fiabe/082.txt", "Fiabe/083.txt", "Fiabe/084.txt", "Fiabe/085.txt", "Fiabe/086.txt", "Fiabe/087.txt", "Fiabe/088.txt", "Fiabe/089.txt", "Fiabe/090.txt",
                                  "Fiabe/091.txt", "Fiabe/092.txt", "Fiabe/093.txt", "Fiabe/094.txt", "Fiabe/095.txt", "Fiabe/096.txt", "Fiabe/097.txt", "Fiabe/098.txt", "Fiabe/099.txt", "Fiabe/100.txt",
                                  "Fiabe/101.txt", "Fiabe/102.txt", "Fiabe/103.txt", "Fiabe/104.txt", "Fiabe/005.txt", "Fiabe/006.txt", "Fiabe/107.txt", "Fiabe/108.txt", "Fiabe/109.txt", "Fiabe/110.txt",
                                  "Fiabe/111.txt", "Fiabe/112.txt", "Fiabe/113.txt", "Fiabe/114.txt", "Fiabe/115.txt", "Fiabe/116.txt", "Fiabe/117.txt", "Fiabe/118.txt", "Fiabe/119.txt", "Fiabe/120.txt",
                                  "Fiabe/121.txt", "Fiabe/122.txt", "Fiabe/123.txt", "Fiabe/124.txt", "Fiabe/125.txt", "Fiabe/126.txt", "Fiabe/127.txt", "Fiabe/128.txt", "Fiabe/129.txt", "Fiabe/130.txt",
                                  "Fiabe/131.txt", "Fiabe/132.txt", "Fiabe/133.txt", "Fiabe/134.txt", "Fiabe/135.txt", "Fiabe/136.txt", "Fiabe/137.txt", "Fiabe/138.txt", "Fiabe/139.txt", "Fiabe/140.txt",
                                  "Fiabe/141.txt", "Fiabe/142.txt", "Fiabe/143.txt", "Fiabe/144.txt", "Fiabe/145.txt", "Fiabe/146.txt", "Fiabe/147.txt", "Fiabe/148.txt", "Fiabe/149.txt", "Fiabe/150.txt",
                                  "Fiabe/151.txt", "Fiabe/152.txt", "Fiabe/153.txt", "Fiabe/154.txt", "Fiabe/155.txt", "Fiabe/156.txt", "Fiabe/157.txt", "Fiabe/158.txt", "Fiabe/159.txt", "Fiabe/160.txt",
                                  "Fiabe/161.txt", "Fiabe/162.txt", "Fiabe/163.txt", "Fiabe/164.txt", "Fiabe/165.txt", "Fiabe/166.txt", "Fiabe/167.txt", "Fiabe/168.txt", "Fiabe/169.txt", "Fiabe/170.txt",
                                  "Fiabe/171.txt", "Fiabe/172.txt", "Fiabe/173.txt", "Fiabe/174.txt", "Fiabe/175.txt", "Fiabe/176.txt", "Fiabe/177.txt", "Fiabe/178.txt", "Fiabe/179.txt", "Fiabe/180.txt",
                                  "Fiabe/181.txt", "Fiabe/182.txt", "Fiabe/183.txt", "Fiabe/184.txt", "Fiabe/185.txt", "Fiabe/186.txt", "Fiabe/187.txt", "Fiabe/188.txt", "Fiabe/189.txt", "Fiabe/190.txt",
                                  "Fiabe/191.txt", "Fiabe/192.txt", "Fiabe/193.txt", "Fiabe/194.txt", "Fiabe/195.txt", "Fiabe/196.txt", "Fiabe/197.txt", "Fiabe/198.txt", "Fiabe/199.txt", "Fiabe/200.txt",
                                  "Fiabe/201.txt", "Fiabe/202.txt", "Fiabe/203.txt", "Fiabe/204.txt", "Fiabe/205.txt", "Fiabe/206.txt", "Fiabe/207.txt", "Fiabe/208.txt", "Fiabe/209.txt", "Fiabe/210.txt",
                                  "Fiabe/211.txt",
                              };
        string[] titoloFiaba = { 
                                   "001 Il principe ranocchio", "002 Gatto e topo in società", "003 La figlia della Madonna", "004 Storia di uno che se ne andò in cerca della paura", "005 Il lupo e i sette caprettini", "006 Il fedele Giovanni", "007 Il buon affare", "008 Lo strano violinista", "009 I dodici fratelli", "010 Gentaglia", "011 Fratellino e sorellina", "012 Raperonzolo", "013 I tre omini del bosco", "014 Le tre filatrici", "015 Hänsel e Gretel", "016 Le tre foglie della serpe", "017 La serpe bianca", "018 La pagliuzza, il carbone e il fagiolo", "019 Il pescatore e sua moglie", "020 Il prode piccolo sarto (Sette in un colpo)", "021 Cenerentola", "022 L'indovinello", "023 Il topino, l'uccellino e la salsiccia", "024 Madama Holle", "025 I sette corvi", "026 Cappuccetto Rosso", "027 I musicanti di Brema", "028 L'osso che canta", "029 I tre capelli d'oro del diavolo", "030 Pidocchietto e Pulcettina", "031 La fanciulla senza mani", "032 Gianni testa fina", "033 I tre linguaggi", "034 La saggia Elsa", "035 Il sarto in paradiso", "036 Il tavolino magico, l'asino d'oro e il randello castigamatti", "037 Pollicino", "038 La signora volpe", "039 Gli gnomi", "040 Il fidanzato brigante", "041 Messer Babau", "042 Il compare", "043 Frau Trude", "044 Comare Morte", "045 Il viaggio di Pollicino, il piccolo sarto", "046 L'uccello strano", "047 Il ginepro", "048 Il vecchio Sultano", "049 I sei cigni", "050 Rosaspina", "051 Ucceltrovato", "052 Il re Bazza di Tordo", "053 Biancaneve", "054 Lo zaino, il cappellino e la cornetta", "055 Tremotino", "056 Il diletto Orlando", "057 L'uccello d'oro", "058 Il cane e il passero", "059 Federico e Caterinella", "060 I due fratelli", "061 Il contadinello", "062 La regina delle api", "063 Le tre piume", "064 L'oca d'oro", "065 Dognipelo", "066 La sposa del leprotto", "067 I dodici cacciatori", "068 Il ladro e il suo maestro", "069 Jorinda e Joringhello", "070 I tre figli della fortuna", "071 I sei che si fanno strada per il mondo", "072 Il lupo e l'uomo", "073 Il lupo e la volpe", "074 La volpe e la comare", "075 La volpe e il gatto", "076 Il garofano", "077 La saggia Ghita", "078 Il vecchio nonno e il nipotino", "079 L'ondina", "080 La morte della gallinella", "081 Il Buontempone", "082 Il Giocatutto", "083 La fortuna di Gianni", "084 Gianni si sposa", "085 I figli d'oro", "086 La volpe e le oche", "087 Il ricco e il povero", "088 L'allodola che canta e saltella", "089 La piccola guardiana di oche", "090 Il giovane gigante", "091 Lo gnomo", "092 Il re del monte d'oro", "093 Il corvo", "094 La figlia furba del contadino", "095 Il vecchio Ildebrando", "096 I tre uccelli", "097 L'acqua della vita", "098 Il dottor Satutto", "099 Lo spirito nella bottiglia", "100 Il fuligginoso fratello del diavolo",
                                    "101 La giubba verde del diavolo","102 Il re di macchia e l'orso","103 La pappa dolce","104 I fedeli animali","105 Storie della serpe","106 Il povero garzone e la gattina","107 Le cornacchie","108 Gian Porcospino","109 La camicina da morto","110 L'ebreo nello spineto","111 Il cacciatore provetto","112 La trebbia venuta dal cielo","113 Il principe e la principessa","114 Il saggio piccolo sarto","115 La luce del sole lo rivelerà","116 La luce azzurra","117 Il bambino capriccioso","118 I tre cerusici","119 I sette svevi","120 I tre garzoni","121 Il principe senza paura","122 L'insalata magica","123 La vecchia nel bosco","124 I tre fratelli","125 Il diavolo e sua nonna","126 Fernando fedele e Fernando infedele","127 Il forno","128 La filatrice pigra","129 I quattro fratelli ingegnosi","130 Occhietto, Duocchietti, Treocchietti","131 La bella Caterinella e Pum Pum Fracassino","132 La volpe e il cavallo","133 Le scarpe logorate dal ballo","134 I sei servi","135 La sposa bianca e quella nera","136 L'uomo selvaggio","137 Le tre principesse nere","138 Knoist e i suoi tre figli","139 La ragazza di Brakel","140 Donnette","141 L'agnellino e il pesciolino","142 Il monte Simeli","143 Il giramondo","144 L'asinello","145 Il figlio ingrato","146 La rapa","147 Il fuoco che ringiovanisce","148 Le bestie del Signore e quelle del diavolo","149 La trave del gallo","150 La vecchia mendicante",
                                    "151 I tre pigri","152 Il pastorello","153 La pioggia di stelle","154 Il centesimo rubato","155 La scelta della sposa","156 Gli scarti","157 Il passero e i suoi quattro figli","158 La favola del paese di Cuccagna","159 Filastrocca di bugie","160 Fiaba indovinello","161 Biancaneve e Rosarossa","162 Il servo accorto","163 La bara di vetro","164 Il pigro Rico","165 L'uccello grifone","166 Il forte Hans","167 Il contadinello in paradiso","168 La magra Lisa","169 La casa nel bosco","170 Come dividere gioie e dolori","171 Il re di macchia","172 La sogliola","173 Il trombotto e l'upupa","174 Il gufo","175 La luna","176 Il termine della vita","177 I messaggeri della morte","178 Mastro Punteruolo","179 La guardiana delle oche alla fonte","180 I figli di Eva, uno diverso dall'altro","181 L'ondina della pescaia","182 I doni del popolo piccino","183 Il gigante e il sarto","184 Il chiodo","185 Il povero ragazzo nella fossa","186 La vera sposa","187 La lepre e il porcospino","188 Il fuso, la spola e l'ago","189 Il contadino e il diavolo","190 Le briciole sulla tavola","191 Il leprotto marino","192 Il ladro maestro","193 Il tamburino","194 La spiga","195 Il tumulo","196 Il vecchio Rink Rank","197 La palla di cristallo","198 La vergine Malvina","199 Gli stivali di bufalo","200 La chiave d'oro","201 San Giuseppe nel bosco","202 I dodici apostoli","203 La rosa","204 Umiltà e povertà portano in cielo","205 Il cibo di Dio","206 I tre ramoscelli verdi","207 Il bicchierino della Madonna","208 La vecchierella","209 Le nozze celesti","210 La verga di nocciolo","211 Il gatto con gli stivali"
                               };

        public Fiabe()
        {
            InitializeComponent();
            indice = App.globalIndex;
            Loaded += OnPageLoaded;
        }
        
        private void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            ScrollingTexFromHell.Content = TextToXaml(listaFiabe[indice]);
            titolo.Text = titoloFiaba[indice];
        }

        private static StackPanel TextToXaml(string filename)
        {
            var panel = new StackPanel();
            var resourceStream = Application.GetResourceStream(new Uri(filename, UriKind.RelativeOrAbsolute));
            if (resourceStream != null)
            {
                using (var reader = new StreamReader(resourceStream.Stream))
                {
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line))
                        {
                            panel.Children.Add(new Rectangle { Height = 20.0 });
                        }
                        else
                        {
                            var textBlock = new TextBlock
                            {
                                TextWrapping = TextWrapping.Wrap,
                                Text = line,
                                Style = (Style)Application.Current.Resources["PhoneTextNormalStyle"],
                                FontSize = 24,
                                Foreground=new SolidColorBrush(Colors.Black),
                            };
                            panel.Children.Add(textBlock);
                        }
                    } while (line != null);
                }
            }
            return panel;
        }
		
        private void Prossima_Click(object sender, EventArgs e)
        {
            if (indice != 210)
            {
                indice++;
                ScrollingTexFromHell.Content = TextToXaml(listaFiabe[indice]);
                titolo.Text = titoloFiaba[indice];
            }
        }

        private void Precedente_Click(object sender, EventArgs e)
        {
            if (indice != 0)
            {
                indice--;
                ScrollingTexFromHell.Content = TextToXaml(listaFiabe[indice]);
                titolo.Text = titoloFiaba[indice];
            }
        }

        private void Casuale_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 211); //0 incluso, 211 escluso
            indice = randomNumber;
            ScrollingTexFromHell.Content = TextToXaml(listaFiabe[indice]);
            titolo.Text = titoloFiaba[indice];
        }

        private void Ricerca_Click(object sender, EventArgs e)
        {
            ricerca.Visibility = Visibility.Visible;
        }

        private void vaiRicerca_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroPagina.Text) > 0 && int.Parse(numeroPagina.Text) < 212)
            {
                indice=int.Parse(numeroPagina.Text)-1;
                ScrollingTexFromHell.Content = TextToXaml(listaFiabe[indice]);
                titolo.Text = titoloFiaba[indice];
            }
            else
            {
                MessageBox.Show("Devi inserire un valore che va da 1 a 211", "Errore ricerca", MessageBoxButton.OK);
            }
            ricerca.Visibility = Visibility.Collapsed;
        }
    }
}