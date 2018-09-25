#pragma once
#include "Controller.cpp"
#include <list>
Parser parser;
Controller control;
namespace AutoSalon20 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для AutosalonForm
	/// </summary>
	public ref class AutosalonForm : public System::Windows::Forms::Form
	{

	public:

		AutosalonForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~AutosalonForm()
		{
			if (components)
			{
				delete components;
			}
		}

		System::Windows::Forms::ListViewItem^ LVAutoItem;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	protected:
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::ComboBox^  CBType;

	private: System::Windows::Forms::ComboBox^  CBModels;


	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::ListView^  LVAuto;

	private: System::Windows::Forms::ColumnHeader^  Mark;
	private: System::Windows::Forms::ColumnHeader^  Model;
	private: System::Windows::Forms::ColumnHeader^  Type;
	private: System::Windows::Forms::ColumnHeader^  Equipment;
	private: System::Windows::Forms::ColumnHeader^  Color;
	private: System::Windows::Forms::ColumnHeader^  Price;
	private: System::Windows::Forms::ColumnHeader^  Status;
	private: System::Windows::Forms::ComboBox^  CBMarks;
	private: System::Windows::Forms::TextBox^  TBPrice;


	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::RichTextBox^  RTBDetailInfo;

	private:
		
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(AutosalonForm::typeid));
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->CBType = (gcnew System::Windows::Forms::ComboBox());
			this->CBModels = (gcnew System::Windows::Forms::ComboBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->LVAuto = (gcnew System::Windows::Forms::ListView());
			this->Mark = (gcnew System::Windows::Forms::ColumnHeader());
			this->Model = (gcnew System::Windows::Forms::ColumnHeader());
			this->Type = (gcnew System::Windows::Forms::ColumnHeader());
			this->Equipment = (gcnew System::Windows::Forms::ColumnHeader());
			this->Color = (gcnew System::Windows::Forms::ColumnHeader());
			this->Price = (gcnew System::Windows::Forms::ColumnHeader());
			this->Status = (gcnew System::Windows::Forms::ColumnHeader());
			this->CBMarks = (gcnew System::Windows::Forms::ComboBox());
			this->TBPrice = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->RTBDetailInfo = (gcnew System::Windows::Forms::RichTextBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(509, 22);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(412, 79);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 29;
			this->pictureBox1->TabStop = false;
			// 
			// button2
			// 
			this->button2->BackColor = System::Drawing::Color::WhiteSmoke;
			this->button2->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 12));
			this->button2->Location = System::Drawing::Point(711, 453);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(324, 50);
			this->button2->TabIndex = 28;
			this->button2->Text = L"Зарезервировать";
			this->button2->UseVisualStyleBackColor = false;
			this->button2->Click += gcnew System::EventHandler(this, &AutosalonForm::button2_Click);
			// 
			// CBType
			// 
			this->CBType->FormattingEnabled = true;
			this->CBType->Items->AddRange(gcnew cli::array< System::Object^  >(4) { L"Sedan", L"Hatchback", L"Crossover", L"Coupe" });
			this->CBType->Location = System::Drawing::Point(55, 80);
			this->CBType->Name = L"CBType";
			this->CBType->Size = System::Drawing::Size(121, 21);
			this->CBType->TabIndex = 27;
			// 
			// CBModels
			// 
			this->CBModels->FormattingEnabled = true;
			this->CBModels->Location = System::Drawing::Point(55, 52);
			this->CBModels->Name = L"CBModels";
			this->CBModels->Size = System::Drawing::Size(121, 21);
			this->CBModels->TabIndex = 26;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 18, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label6->Location = System::Drawing::Point(743, 107);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(266, 35);
			this->label6->TabIndex = 24;
			this->label6->Text = L"Детальная информация";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 18, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label5->Location = System::Drawing::Point(233, 107);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(231, 35);
			this->label5->TabIndex = 23;
			this->label5->Text = L"Список автомобилей";
			this->label5->TextAlign = System::Drawing::ContentAlignment::TopCenter;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 9.749999F));
			this->label4->Location = System::Drawing::Point(214, 24);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(38, 19);
			this->label4->TabIndex = 22;
			this->label4->Text = L"Цена:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 9.749999F));
			this->label3->Location = System::Drawing::Point(16, 79);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(33, 19);
			this->label3->TabIndex = 21;
			this->label3->Text = L"Тип:";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 9.749999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label2->Location = System::Drawing::Point(3, 52);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(53, 19);
			this->label2->TabIndex = 20;
			this->label2->Text = L"Модель:";
			// 
			// LVAuto
			// 
			this->LVAuto->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(7) {
				this->Mark, this->Model, this->Type,
					this->Equipment, this->Color, this->Price, this->Status
			});
			this->LVAuto->HideSelection = false;
			this->LVAuto->Location = System::Drawing::Point(11, 144);
			this->LVAuto->Name = L"LVAuto";
			this->LVAuto->Size = System::Drawing::Size(694, 359);
			this->LVAuto->TabIndex = 19;
			this->LVAuto->UseCompatibleStateImageBehavior = false;
			this->LVAuto->View = System::Windows::Forms::View::Details;
			this->LVAuto->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &AutosalonForm::LVAuto_MouseClick);
			// 
			// Mark
			// 
			this->Mark->Text = L"Марка";
			this->Mark->Width = 115;
			// 
			// Model
			// 
			this->Model->Text = L"Модель";
			this->Model->Width = 105;
			// 
			// Type
			// 
			this->Type->Text = L"Тип";
			this->Type->Width = 69;
			// 
			// Equipment
			// 
			this->Equipment->Text = L"Комплектация";
			this->Equipment->Width = 97;
			// 
			// Color
			// 
			this->Color->Text = L"Цвет";
			this->Color->Width = 106;
			// 
			// Price
			// 
			this->Price->Text = L"Цена";
			this->Price->Width = 89;
			// 
			// Status
			// 
			this->Status->Text = L"Статус";
			this->Status->Width = 111;
			// 
			// CBMarks
			// 
			this->CBMarks->FormattingEnabled = true;
			this->CBMarks->Items->AddRange(gcnew cli::array< System::Object^  >(4) { L"Audi", L"BMW", L"Nissan", L"Kia" });
			this->CBMarks->Location = System::Drawing::Point(55, 25);
			this->CBMarks->Name = L"CBMarks";
			this->CBMarks->Size = System::Drawing::Size(121, 21);
			this->CBMarks->TabIndex = 18;
			this->CBMarks->SelectedIndexChanged += gcnew System::EventHandler(this, &AutosalonForm::comboBox1_SelectedIndexChanged);
			// 
			// TBPrice
			// 
			this->TBPrice->Location = System::Drawing::Point(256, 25);
			this->TBPrice->Name = L"TBPrice";
			this->TBPrice->Size = System::Drawing::Size(100, 20);
			this->TBPrice->TabIndex = 17;
			// 
			// button1
			// 
			this->button1->BackColor = System::Drawing::Color::WhiteSmoke;
			this->button1->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button1->ForeColor = System::Drawing::SystemColors::ControlText;
			this->button1->Location = System::Drawing::Point(218, 55);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(138, 41);
			this->button1->TabIndex = 16;
			this->button1->Text = L"Подобрать авто";
			this->button1->UseVisualStyleBackColor = false;
			this->button1->Click += gcnew System::EventHandler(this, &AutosalonForm::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Sitka Banner", 9.749999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(3, 24);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(46, 19);
			this->label1->TabIndex = 15;
			this->label1->Text = L"Марка:";
			// 
			// RTBDetailInfo
			// 
			this->RTBDetailInfo->Location = System::Drawing::Point(711, 145);
			this->RTBDetailInfo->Name = L"RTBDetailInfo";
			this->RTBDetailInfo->Size = System::Drawing::Size(323, 303);
			this->RTBDetailInfo->TabIndex = 30;
			this->RTBDetailInfo->Text = L"";
			// 
			// AutosalonForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1047, 524);
			this->Controls->Add(this->RTBDetailInfo);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->CBType);
			this->Controls->Add(this->CBModels);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->LVAuto);
			this->Controls->Add(this->CBMarks);
			this->Controls->Add(this->TBPrice);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"AutosalonForm";
			this->Text = L"Автосалон";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
		
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		this->LVAuto->Items->Clear();
		string model = control.Converter(CBModels->Text);
		string mark = control.Converter(CBMarks->Text);
		string type = control.Converter(CBType->Text);
		string price = control.Converter(TBPrice->Text);
		LoadItems(control.Search(mark, model, price, type, control.Load(5)));
		Clear();
		};
			 void LoadItems(list<Car> doc) {
				 for each (Car car in doc)
				 {
					 LVAutoItem = gcnew Windows::Forms::ListViewItem(gcnew String(car.GetMark().c_str()));
					 LVAutoItem->SubItems->Add(gcnew String(car.GetModel().c_str()));
					 LVAutoItem->SubItems->Add(gcnew String(car.GetType().c_str()));
					 LVAutoItem->SubItems->Add(gcnew String(car.GetCompType().c_str()));
					 LVAutoItem->SubItems->Add(gcnew String(car.GetColor().c_str()));
					 LVAutoItem->SubItems->Add(car.GetPrice().ToString());
					 LVAutoItem->SubItems->Add(gcnew String(car.GetStatus().c_str()));
					 this->LVAuto->Items->Add(this->LVAutoItem);
				 }
			 }
			 void Clear() 
			 {
				 CBMarks->Text = "";
				 CBType->Text = "";
				 CBModels->Text = "";
				 TBPrice->Text = "";
			 }
private: System::Void comboBox1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
	this->CBModels->Items->Clear();
	list<Car> temp;
	if (CBMarks->Text == "Audi") {
		temp = control.Load(1);
	}
	if (CBMarks->Text == "BMW") {
		temp = control.Load(2);	
	}
	if (CBMarks->Text == "Nissan") {
		temp = control.Load(3);
	}
	if (CBMarks->Text == "Kia") {
		temp = control.Load(4);
	}
	for each (Car c in temp)
	{
		this->CBModels->Items->Add(gcnew String(c.GetModel().c_str()));
	}
	};

private: System::Void LVAuto_MouseClick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	RTBDetailInfo->Text = "Марка -> " + LVAuto->SelectedItems[0]->SubItems[0]->Text + "Model ->" + LVAuto->SelectedItems[0]->SubItems[1]->Text;
	control.UpdateSelCar(control.oneCarSrch(control.Converter(LVAuto->SelectedItems[0]->SubItems[0]->Text),
		control.Converter(LVAuto->SelectedItems[0]->SubItems[1]->Text),
		control.Converter(LVAuto->SelectedItems[0]->SubItems[5]->Text),
		control.Converter(LVAuto->SelectedItems[0]->SubItems[4]->Text),
		control.Converter(LVAuto->SelectedItems[0]->SubItems[3]->Text)));
	RTBDetailInfo->Text = gcnew String(control.SelectedCar.ShowInfo().c_str());
}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
	control.SelectedCar.ChangeStatus();
	parser.Save(control.SelectedCar);
}
};
}