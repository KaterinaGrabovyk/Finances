using System.Text.RegularExpressions;

namespace Finances
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView2.GridLines = true;
            listView2.View = View.Details;
            listView2.Scrollable = true;
            listView2.MultiSelect = false;
            listView2.Columns.Add("Ваша карта", 150, HorizontalAlignment.Center);
            listView2.Columns.Add("Друга карта", 150, HorizontalAlignment.Center);
            listView2.Columns.Add("Стан вашої карти", 150, HorizontalAlignment.Center);

        }
        LinkedList<Transaction> moneyTransact = new LinkedList<Transaction>();
        string znack = "";
        Regex reCard = new Regex(@"[0-9]{10}$");
        //пошук
        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (moneyTransact.Count > 0)
            {
                if (radioButton3.Checked == true)
                {
                    if (reCard.IsMatch(textBox3.Text))
                    {
                        foreach (Transaction t in moneyTransact)
                        {

                            if (t.Card1 == textBox3.Text)
                            {
                                ListViewItem item = new ListViewItem();
                                item.SubItems.Clear();
                                item.SubItems[0].Text = t.Card1;
                                item.SubItems.Add(t.Card2);
                                item.SubItems.Add(t.card1MoneyCount);
                                listView2.Items.Add(item);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильно вписано номер карти.");
                    }
                     
                }
                if(radioButton4.Checked == true)
                {
                    if (reCard.IsMatch(textBox3.Text))
                    {
                        foreach (Transaction t in moneyTransact)
                        {

                            if (t.Card2 == textBox3.Text)
                            {
                                ListViewItem item = new ListViewItem();
                                item.SubItems.Clear();
                                item.SubItems[0].Text = t.Card1;
                                item.SubItems.Add(t.Card2);
                                item.SubItems.Add(t.card1MoneyCount);
                                listView2.Items.Add(item);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильно вписано номер карти.");
                    }

                }
                if (radioButton3.Checked == false && radioButton4.Checked == false )
                {

                    foreach (Transaction t in moneyTransact)
                    {
                            ListViewItem item = new ListViewItem();
                            item.SubItems.Clear();
                            item.SubItems[0].Text = t.Card1;
                            item.SubItems.Add(t.Card2);
                            item.SubItems.Add(t.card1MoneyCount);
                            listView2.Items.Add(item);
                    }
                }
                textBox3.Text = "";
                radioButton3.Checked = false; radioButton4.Checked = false;
            }
        }
        //додавання
        private void button1_Click(object sender, EventArgs e)
        {
            string Ycard = textBox1.Text;
            string Ocard = textBox2.Text;
            string Sum = $"{numericUpDown1.Value}";
            if (Ycard == null || Ocard == null || numericUpDown1.Value == 0 || znack == "")
            {
                MessageBox.Show("Не вписано інформацію");
                return;
            }else if (!reCard.IsMatch(Ycard)||!reCard.IsMatch(Ocard))
            {
                MessageBox.Show("Неправильно вписано номер карти.");
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Ви впевнені в транзакції?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    if (moneyTransact.Count == 0)
                    {
                        moneyTransact.AddFirst(new Transaction() { Card1 = Ycard, Card2 = Ocard, card1MoneyCount = $"{znack}{Sum} грн" });
                    }

                    else
                    {
                        moneyTransact.AddLast(new Transaction() { Card1 = Ycard, Card2 = Ocard, card1MoneyCount = $"{znack}{Sum} грн" });
                    }
                    listView2.Items.Clear();
                    foreach (var s in moneyTransact)
                    {
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Clear();
                        item.SubItems[0].Text = s.Card1;
                        item.SubItems.Add(s.Card2);
                        item.SubItems.Add(s.card1MoneyCount);
                        listView2.Items.Add(item);
                    }
                    MessageBox.Show("Транзакцію додано. Поля буде очищено.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    numericUpDown1.Value = 0;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    znack = "";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            znack = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            znack = "-";
        }


    }
    class Transaction
    {
        //Ваша карта
        public string Card1 { get; set; }
        //Карта з якої ви або берете, або надсилаєте гроші
        public string Card2 { get; set; }
        //Грошовий переклад
        public string card1MoneyCount { get; set; }
    }
}

