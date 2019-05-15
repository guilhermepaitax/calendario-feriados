using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoCalendario
{
    public partial class FormFeriados : Form
    {
        public FormFeriados()
        {
            InitializeComponent();
        }

        private void buttonCalcaular_Click(object sender, EventArgs e)
        {
            //Pegar o texto do maskedTextBoxAno e colocar na variavel ano convertentdo para int
            int ano = Convert.ToInt32(maskedTextBoxAno.Text);
            //Verifica se o ano digitado e acima de 1587
            if (ano < 1587)
            {
                MessageBox.Show("O ano minimo permitido é 1587!", "Erro");//Exibe a mensagem de erro
                return;//retorna pra não executar o resto
            }

            DateTime pascoa = Pascoa(ano);//Cria uma variavel do tipo Datetime que recebe a data da pascoa retornada pela funcão Pascoa()
            richTextBox1.Clear();//Limpa o richTextBox1
            richTextBox1.AppendText("Lista de Feriados de " + ano.ToString());//Mostra o texto Lista de Feriados junto ccom o ano digitado
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("Confraternizacao Universal: " + DiaDaSemana(ano, 01, 01) + ", " //Exibe o nome do feriado, em seguida o dia da semana retornado pelo metodo DiaDaSemana
                + new DateTime(ano, 01, 01).ToShortDateString() + Environment.NewLine);//Exibe a data do feriado como o DateTime

            int carnavalOrdinal = DataParaOrdinal(pascoa.Year, pascoa.Month, pascoa.Day) - 47;//Criando a variavel que recebe o dia ordinal retornado pela DataParaOrdinal da pascoa - 47
            DateTime Carnaval = OrdinalParaData(carnavalOrdinal, ano);//Cria variavel que recebe a data apartir do dia ordinal
            richTextBox1.AppendText("Carnaval: " + DiaDaSemana(Carnaval.Year, Carnaval.Month, Carnaval.Day) +
                ", " + Carnaval.ToShortDateString() + Environment.NewLine);//Exibe as informacoes do feriado

            int sextaSantaOrdinal = DataParaOrdinal(pascoa.Year, pascoa.Month, pascoa.Day) - 2;
            DateTime sextaSanta = OrdinalParaData(sextaSantaOrdinal, ano);
            richTextBox1.AppendText("Paixão de Cristo: " + DiaDaSemana(sextaSanta.Year, sextaSanta.Month, sextaSanta.Day) + 
                ", " + sextaSanta.ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Pascoa: " + DiaDaSemana(ano, pascoa.Month, pascoa.Day) + ", "
                + new DateTime(ano, pascoa.Month, pascoa.Day).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Tiradentes: " + DiaDaSemana(ano, 04, 21) + ", " +
                new DateTime(ano, 04, 21).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Dia do Trabalhador: " + DiaDaSemana(ano, 05, 01) + ", " +
                new DateTime(ano, 05, 01).ToShortDateString() + Environment.NewLine);

            int corpus = DataParaOrdinal(pascoa.Year, pascoa.Month, pascoa.Day) + 60;
            DateTime corpusChristi = OrdinalParaData(corpus, ano);
            richTextBox1.AppendText("Corpus Christi: " + DiaDaSemana(corpusChristi.Year, corpusChristi.Month, corpusChristi.Day) +
                ", " + corpusChristi.ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Dia da Pátria: " + DiaDaSemana(ano, 09, 07) + ", " +
                new DateTime(ano, 09, 07).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Nossa Senhora Aparecida: " + DiaDaSemana(ano, 10, 12) + ", " +
                new DateTime(ano, 10, 12).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Finados: " + DiaDaSemana(ano, 11, 02) + ", " +
                new DateTime(ano, 11, 02).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Proclamação da República: " + DiaDaSemana(ano, 11, 15) + ", " +
                new DateTime(ano, 11, 15).ToShortDateString() + Environment.NewLine);

            richTextBox1.AppendText("Natal: " + DiaDaSemana(ano, 12, 25) + ", " +
                new DateTime(ano, 12, 25).ToShortDateString() + Environment.NewLine);

        }

        private string DiaDaSemana(double ano, double mes, double dia)
        {
            //Criando array de strings dos dias da semana
            string[] Dias = new string[] { "Sábado", "Domindo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira",
                "Quinta-Feira", "Sexta-Feira" };
            //Algoritimo para calcular o dia da semana
            double a, b, c, d, e, f, g, h, i, j;
            a = (12 - mes) / 10;
            a = Math.Floor(a);
            b = ano - a;
            b = Math.Floor(b);
            c = mes + (12 * a);
            c = Math.Floor(c);
            d = b / 100;
            d = Math.Floor(d);
            e = d / 4;
            e = Math.Floor(e);
            f = 2 - d + e;
            f = Math.Floor(f);
            g = 365.25 * b;
            g = Math.Floor(g);
            h = 30.6001 * (c + 1);
            h = Math.Floor(h);
            i = (f + g) + (h + dia) + 5;
            i = Math.Floor(i);
            j = i % 7;

            return Dias[Convert.ToInt32(j)];//retorna o array Dias na posicao calculada pelo algoritimo representado por j
        }

        private DateTime Pascoa(double ano)
        {
            //Algoritimo para calcular a data da pascoa
            int a, b, c, d, e, f, g, h, i, k, l, m, an = Convert.ToInt32(ano), mes, dia;
            a = (an % 19);
            b = an / 100;
            c = (an % 100);
            d = b / 4;
            e = (b % 4);
            f = (b + 8) / 25;
            g = (b - f + 1) / 3;
            h = ((19 * a + b - d - g + 15) % 30);
            i = c / 4;
            k = (c % 4);
            l = ((32 + 2 * e + 2 * i - h - k) % 7);
            m = (a + 11 * h + 22 * l) / 451;
            mes = (h + l - 7 * m + 114) / 31;
            dia = ((h + l - 7 * m + 114) % 31) + 1;
            return (new DateTime(an, mes, dia));//retorna um DateTime do dia mes e ano da pascoa
        }

        
        private Boolean Bissexto(int ano)
        {
            //verifica se o ano recebido por parametro tem resto 0 na divisão por 4 e tem resto diferente de 0 na divisão por 100
            if (ano % 4 == 0 && ano % 100 != 0)
            {
                //Retorna true ou seja e um ano bissexto
                return true;
            }
            else
            {
                //retorna false ou seja não e um ano bissexto
                return false;
            } 
        } 

        private int[] GeraTabelaMeses(int ano)
        {
            int[] mes = new int[] {0,31,28,31,30,31,30,31,31,30,31,30,31};//Cria um array de int com a quantia de dias dos meses

            if (Bissexto(ano) == false)//Verifia se o ano recebido e bissexto
            {
                return mes;//Caso não seja apenas retorna o array dos meses
            }
            else
            {
                mes[2] = 29;//Caso seja bissexto a posicão 2 do array recebe 29 dias e retorna o array
                return mes;
            }     
        }


        private int[] GeraTabelaOrdinais(int ano)
        {
            int[] mes = GeraTabelaMeses(ano);//array recebe retorno da funcão GeraTabelaMeses
            int[] ordinais = new int[12];//Criando array de ordinais
            ordinais[0] = 0;
            for (int i = 1; i < 12; i++)//Fazendo um for para percorrer o array dos meses
            {  
                ordinais[i] = mes[i] + ordinais[i - 1];//ordinais recebe a quantida de dias do mes somado com a quantia de ordinais da pocicao anterior  
            }
            return ordinais;//retorna o array de ordinais
        }

        private int DataParaOrdinal(int ano, int mes, int dia)
        {
            int[] ordinais = GeraTabelaOrdinais(ano);//recebe o array de ordinais da GeraTabelaOrdinais
            return (ordinais[mes - 1] + dia);//retorna a data ordinal que se da pelo dia somado pelo array de ordinais na posicao mes menos 1
        }

        private DateTime OrdinalParaData(int diaOrdinal, int ano)
        {
            int mes = 0, dia = 0;
            int[] ordinais = GeraTabelaOrdinais(ano);
            for (int i = 0; i < 12; i++)//For para percorrer o array de ordinais
            {
                if (diaOrdinal > ordinais[i])//verifica de o diaOrdinal e maior que o ordinasi na posicao i
                {
                    mes = i + 1;//variavel mes recebe o valor do i mais 1
                    dia = diaOrdinal - ordinais[i];//variavel dia recebe o diaOrdinal subtraido pelo ordinais na posicao i

                }
            }
            return (new DateTime(ano, mes, dia));//retorna um DateTime da data do dia em ordinal 
        }  
    }
}
