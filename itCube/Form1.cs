using System;
using System.Drawing;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
namespace itCube
{

    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button selectedButton = null;
        private Label selectedLabel;

        public Form1()
        {
            InitializeComponent();

            button17.Click += Button_Click;
            button18.Click += Button_Click;
            button19.Click += Button_Click;
            button20.Click += Button_Click;
            button21.Click += Button_Click;
            button22.Click += Button_Click;

            
            selectedLabel = label25;

            panel2.Visible = false;textBox6.Visible = false;
            panel3.Visible = false;textBox8.Visible = false;
            panel4.Visible = false;panel10.Visible = false;
            panel5.Visible = false;panel11.Visible = false;
            panel6.Visible = false;panel12.Visible = false;
            panel7.Visible = false; panel13.Visible = false;
            panel8.Visible = false; panel14.Visible = false;
            button8.Visible = false;panel15.Visible = false;
            button9.Visible = false;
            panel9.Visible = false;button11.Visible = false;
            textBox6.Multiline = true;
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Text = "Курс \"Программирование роботов\" предназначен для тех, кто интересуется робототехникой и хочет научиться программировать и управлять роботами.\r\nЗанятия строятся от простого к сложному, причем, на самих занятиях не просто занимаются конструированием и собиранием роботов из деталек, а выполняют проекты: знакомятся с теоретическими вопросами, ставят поисковые задачи, учатся работать в команде, обсуждать и отстаивать свою точку зрения.\r\n\r\nРобот помогает пройти путь обучения легко и с удовольствием: материал не выдается в сухом и дозированном виде, а познается детьми в игре, в творчестве и поиске решения задачи.\r\n\r\nВ ходе курса изучаются следующие темы:\r\n1. Введение в робототехнику\r\n2. Аппаратное обеспечение роботов (Изучение компонентов сенсоров, моторов и различных комплектующих)\r\n3. Программное обеспечение роботов (Изучение компьютерных программ для написания алгоритмов работы)\r\n\r\nВ рамках этого курса обучающиеся изучают основы программирования, применяемого в робототехнике, а также основные концепции и техники управления роботами.";
            textBox6.Size = new Size(200, 100);

            Controls.Add(textBox6);
            int s;


        }
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;

            if (selectedButton == null)
            {
               
                selectedButton = clickedButton;
                label25.Text = GetCourseText(clickedButton);
            }
            else if (selectedButton == clickedButton)
            {
            
                MessageBox.Show("У вас уже есть выбранный курс. Хотите изменить?", "Предупреждение", MessageBoxButtons.YesNo);
            }
            else
            {
                
                MessageBox.Show("У вас уже есть выбранный курс. Хотите изменить?", "Предупреждение", MessageBoxButtons.YesNo);
                selectedButton = clickedButton;
                label25.Text = GetCourseText(clickedButton);
            }
        }

        private string GetCourseText(System.Windows.Forms.Button button)
        {
            if (button == button17)
            {
                return "Выбранный курс: Мобильная разработка";
            }
            else if (button == button18)
            {
                return "Выбранный курс: Кибергигиена";
            }
            else if (button == button19)
            {
                return "Выбранный курс: Программирование роботов";
            }
            else if (button == button20)
            {
                return "Выбранный курс: Основы алгоритмики и логики";
            }
            else if (button == button21)
            {
                return "Выбранный курс: Программирование на Python";
            }
            else if (button == button22)
            {
                return "Выбранный курс: Системное администрирование";
            }

            return string.Empty;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text +" " + textBox2.Text + " " + textBox3.Text;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox1.Text != "")
            {
                textBox4.Visible = false;
                label1.Visible = false; label2.Visible = false;
                label3.Visible = false; label4.Visible = false;
                label5.Visible = false; label8.Visible = false;
                label9.Visible = false; label10.Visible = false;
                textBox1.Visible = false; textBox2.Visible = false;
                textBox2.Visible = false; textBox3.Visible = false;
                button1.Visible = false; panel1.Visible = false;
                checkBox1.Visible = false; checkBox2.Visible = false;

                panel8.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                button9.Visible = true;
                button8.Visible = true;
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля, перед выбором курса!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            int borderWidth = 2;

            Graphics g = e.Graphics;

            
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);
           
            {
               
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;button1.Visible = true;
            panel8.Visible = false;panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible =false;panel6.Visible = false;
            panel7.Visible = false;button9.Visible = false;
            button8.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox9.Visible = true; panel10.Visible = false;
            panel11.Visible = true;
            textBox9.ScrollBars = ScrollBars.Vertical;textBox9.Text = "Курс \"Мобильная разработка\" предназначен для учащихся, которые интересуются созданием мобильных приложений для популярных платформ.\r\nВ данном курсе рассматривается разработка Андроид-приложений на базе облачного средства App Inventor. Целью программы «Мобильная разработка» является развитие умений и навыков создания простых мобильных приложений для ОС Андроид.\r\n\r\nКроме того на базе визуального конструктора среды App Inventor развивается алгоритмическое мышление учащихся, творческие способности, аналитические и логические компетенции.\r\n\r\nВ ходе курса студенты получат практические навыки в разработке мобильных приложений и познакомятся с основными компонентами и функциями мобильных платформ. Они также изучат языки программирования, фреймворки и инструменты, необходимые для создания мобильных приложений.";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;panel2.Visible = true;
            panel3.Visible = true;panel4.Visible = true;
            panel5.Visible = true;panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true;panel9.Visible = false;
            Size = new Size(1005, 691);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox8.Visible = true;panel10.Visible = true;
            textBox7.ScrollBars = ScrollBars.Vertical;textBox8.Text = "Курс \"Кибергигиена\" предназначен для учеников, которые хотят научиться обеспечивать безопасность и защиту своих данных и личной информации в цифровом мире. В рамках этого курса учащиеся изучают основные принципы и методы обеспечения кибербезопасности, а также различные аспекты кибергигиены.\r\n\r\nКурс рассчитан на развитие умения поиска необходимой информации, поиска достоверной информации в Интернете, навыков распознавания угрозы в Интернет-ресурсах и противодействия им.\r\n\r\nВ ходе курса студенты узнают о различных угрозах, с которыми сталкиваются пользователи в сети, таких как вирусы, хакеры, фишинговые атаки и кража личных данных. Они изучат методы защиты от таких угроз и научатся применять соответствующие меры предосторожности для обеспечения своей кибербезопасности.\r\n\r\nКурс \"Кибергигиена\" охватывает следующие темы:\r\n1. Основы кибербезопасности: введение в основные принципы и концепции кибербезопасности\r\n2. Защита паролей и учетных записей: создание и управление безопасными паролями, защита учетных записей.\r\n3. Защита от вредоносных программ: распознавание и предотвращение атак вирусов, троянов, шпионского и рекламного ПО.\r\n4. Безопасное интернет-серфинг: защита от фишинговых атак, опасных ссылок и мошенничества в сети.\r\n5. Конфиденциальность и защита данных";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            panel8.Visible = true; panel2.Visible = true;
            panel3.Visible = true; panel4.Visible = true;
            panel5.Visible = true; panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true; panel9.Visible = false;
            panel10.Visible = false;

            Size = new Size(1005, 691);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            panel8.Visible = true; panel2.Visible = true;
            panel3.Visible = true; panel4.Visible = true;
            panel5.Visible = true; panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true; panel9.Visible = false;
            panel10.Visible = false;panel11.Visible = false;

            Size = new Size(1005, 691);
        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox6.Visible = false; panel9.Visible = true; textBox7.Text = "Курс \"Программирование роботов\" предназначен для тех, кто интересуется робототехникой и хочет научиться программировать и управлять роботами.\r\nЗанятия строятся от простого к сложному, причем, на самих занятиях не просто занимаются конструированием и собиранием роботов из деталек, а выполняют проекты: знакомятся с теоретическими вопросами, ставят поисковые задачи, учатся работать в команде, обсуждать и отстаивать свою точку зрения.\r\n\r\nРобот помогает пройти путь обучения легко и с удовольствием: материал не выдается в сухом и дозированном виде, а познается детьми в игре, в творчестве и поиске решения задачи.\r\n\r\nВ ходе курса изучаются следующие темы:\r\n1. Введение в робототехнику\r\n2. Аппаратное обеспечение роботов (Изучение компонентов сенсоров, моторов и различных комплектующих)\r\n3. Программное обеспечение роботов (Изучение компьютерных программ для написания алгоритмов работы)\r\n\r\nВ рамках этого курса обучающиеся изучают основы программирования, применяемого в робототехнике, а также основные концепции и техники управления роботами.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox9.Visible = false; panel10.Visible = false;
            panel11.Visible = false;panel12.Visible = true;
            textBox10.ScrollBars = ScrollBars.Vertical;textBox10.Text = "Любите компьютерные игры? Хотите создать свою собственную игру?\r\nТогда этот курс для вас!\r\nЗанятия по основы алгоритмики и логики представляют собой введение в основы алгоритмического мышления, логического анализа и решения проблем. Этот курс направлен на развитие навыков анализа, проектирования и реализации алгоритмов, а также понимания основных принципов логического мышления.\r\n\r\nЗадавая поведение своих персонажей в программе Scratch, вы научитесь основам программирования и изучите такие темы как:\r\n1. Введение в алгоритмику:\r\n• Определение алгоритма и его основные свойства.\r\n• Роль алгоритмов в решении задач.\r\n2. Понятие переменных и типов данных.\r\n• Массивы\r\n2. Исполнители\r\n3. Проектирование алгоритмов\r\n• Условные операторы\r\n• Циклы\r\n5. Звуковые и графические редакторы.\r\n\r\nПри создании проектов в данной среде можно познакомиться с полным циклом разработки программы, начиная с этапа описания идеи и заканчивая тестированием и отладкой.\r\nВ конце образовательной программы обучающиеся создадут свой итоговый проект.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel8.Visible = true; panel2.Visible = true;
            panel3.Visible = true; panel4.Visible = true;
            panel5.Visible = true; panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true; panel9.Visible = false;
            panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false;

            Size = new Size(1005, 691);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel8.Visible = true; panel2.Visible = true;
            panel3.Visible = true; panel4.Visible = true;
            panel5.Visible = true; panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true; panel9.Visible = false;
            panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false;panel13.Visible = false;

            Size = new Size(1005, 691);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox9.Visible = false; panel10.Visible = false;
            panel11.Visible = false; panel12.Visible = false;
            panel13.Visible = true;
            textBox11.ScrollBars = ScrollBars.Vertical;textBox11.Text = "Курс предназначен для начинающих и поможет освоить один из самых распространенных языков программирования, с помощью которого можно создавать сайты, ботов, Desktop-приложения, а также обрабатывать и анализировать большие объемы данных.\r\n\r\nВы освоите базовые понятия и элементы языка программирования Python (операторы, числовые и строковые переменные, списки, условия и циклы) и научитесь создавать программы на языке Python, разрабатывая игры.\r\n\r\nВ ходе курса рассматриваются следующие темы:\r\n1. Введение в Python: обзор основных характеристик языка, синтаксиса и основных концепций программирования.\r\n2. Типы данных и операции: работа с числами, строками, списками, словарями и другими типами данных, а также выполнение операций и манипуляций с ними.\r\n3. Условные выражения и циклы: использование условных операторов (if-else) и циклов (for, while) для контроля выполнения программы.\r\n4. Функции и модули: создание собственных функций, использование встроенных функций, организация кода в модули и пакеты.\r\n5. Обработка исключений: обработка ошибок и исключительных ситуаций в программе, управление исключениями.\r\n6. Работа с файлами: чтение и запись данных в файлы, манипуляции с файловой системой.";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            panel8.Visible = true; panel2.Visible = true;
            panel3.Visible = true; panel4.Visible = true;
            panel5.Visible = true; panel6.Visible = true;
            panel7.Visible = true; button9.Visible = true;
            button8.Visible = true; panel9.Visible = false;
            panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false;
            panel14.Visible = false;

            Size = new Size(1005, 691);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Size = new Size(824, 664);
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox9.Visible = false; panel10.Visible = false;
            panel11.Visible = false; panel12.Visible = false;
            panel13.Visible = false; panel14.Visible = true;
            textBox12.ScrollBars = ScrollBars.Vertical; textBox12.Text = "Курс \"Системное администрирование\" предназначен для учеников, которые интересуются управлением и обслуживанием компьютерных систем и сетей. В рамках этого курса учащиеся изучают основы системного администрирования, включая установку, конфигурацию, мониторинг и обслуживание компьютерных систем и сетей.\r\n\r\nВ ходе курса изучаются различные направления системного администрирования, такие как управление операционными системами, настройка сетей, обеспечение безопасности и резервного копирования данных, а также устранение неполадок и обеспечение высокой доступности систем.\r\n\r\nКроме того, ученики будут знакомиться с основными инструментами и технологиями, используемыми в системном администрировании, такими как серверы, виртуализация, облачные вычисления и системы мониторинга.\r\nПрограмма нацелена на то, чтобы привить детям навыки в обращении с компьютерным и сетевым оборудованием, системным и прикладным программным обеспечением.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int selectedYear = dateTimePicker1.Value.Year;

            if (selectedYear <= 2010)
            {
                label38.Text = "Выбранный курс: Мобильная разработка";
            }
            else
            {
                MessageBox.Show("Возраст вашего ребенка не подходит для данного курса.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel8.Visible = false; panel2.Visible = false;
            panel3.Visible = false; panel4.Visible = false;
            panel5.Visible = false; panel6.Visible = false;
            panel7.Visible = false; button9.Visible = false;
            button8.Visible = false; button11.Visible = true;
            textBox9.Visible = false; panel10.Visible = false;
            panel11.Visible = false; panel12.Visible = false;
            panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = true;

            string data1 = textBox15.Text; 
            string data2 = textBox13.Text; 
            string data3 = textBox14.Text;
            string data4 = textBox5.Text;

            label27.Text = data1;
            label35.Text = data2; 
            label36.Text = data3;  
            label37.Text = data4;
            label38.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            label49.Text = "";
            if (checkBox4.Checked)
            {
                label49.Text += checkBox1.Text;
            }

            if (checkBox3.Checked)
            {
                if (label49.Text != "")
                {
                    label49.Text += ", ";
                }
                label49.Text += checkBox2.Text;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox14.Text != "" && textBox13.Text != "" && textBox5.Text != "")
            {
                textBox4.Visible = false;panel16.Visible = false;
                label1.Visible = false; label2.Visible = false;
                label3.Visible = false; label4.Visible = false;
                label5.Visible = false; label8.Visible = false;
                label9.Visible = false; label10.Visible = false;
                textBox1.Visible = false; textBox2.Visible = false;
                textBox2.Visible = false; textBox3.Visible = false;
                button1.Visible = false; panel1.Visible = false;
                checkBox1.Visible = false; checkBox2.Visible = false;

                panel8.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                button9.Visible = true;
                button8.Visible = true;
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля, перед выбором курса!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel15.Visible = false; panel16.Visible = true; button1.Visible = true;  
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int selectedYear = dateTimePicker1.Value.Year;

            if (selectedYear <= 2010)
            {
                label38.Text = "Выбранный курс: Кибергигиена";
            }
            else
            {
                MessageBox.Show("Возраст вашего ребенка не подходит для данного курса.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }
    }
}
