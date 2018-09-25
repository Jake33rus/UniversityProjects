#include "Controller.cpp"
Controller control;
Beast beast;
namespace Tamagochi {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для WorldForm
	/// </summary>
	public ref class WorldForm : public System::Windows::Forms::Form
	{
	public:
		WorldForm(void)
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
		~WorldForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ProgressBar^  progressHealth;
	private: System::Windows::Forms::ProgressBar^  progressHappy;
	private: System::Windows::Forms::ProgressBar^  progressEat;
	protected:

	protected:






	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::PictureBox^  PBBeast;
	private: System::Windows::Forms::Button^  buttonHealing;
	private: System::Windows::Forms::Button^  buttonPlaing;
	private: System::Windows::Forms::Button^  buttonEating;







	private: System::Windows::Forms::TextBox^  TBName;


	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::TextBox^  TBNameCreate;

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Button^  buttonNew;
	private: System::Windows::Forms::Button^  buttonLoad;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::Label^  label4;


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
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(WorldForm::typeid));
			this->progressHealth = (gcnew System::Windows::Forms::ProgressBar());
			this->progressHappy = (gcnew System::Windows::Forms::ProgressBar());
			this->progressEat = (gcnew System::Windows::Forms::ProgressBar());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->PBBeast = (gcnew System::Windows::Forms::PictureBox());
			this->buttonHealing = (gcnew System::Windows::Forms::Button());
			this->buttonPlaing = (gcnew System::Windows::Forms::Button());
			this->buttonEating = (gcnew System::Windows::Forms::Button());
			this->TBName = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->TBNameCreate = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->buttonNew = (gcnew System::Windows::Forms::Button());
			this->buttonLoad = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->PBBeast))->BeginInit();
			this->SuspendLayout();
			// 
			// progressHealth
			// 
			this->progressHealth->Location = System::Drawing::Point(323, 57);
			this->progressHealth->Name = L"progressHealth";
			this->progressHealth->Size = System::Drawing::Size(286, 23);
			this->progressHealth->TabIndex = 4;
			// 
			// progressHappy
			// 
			this->progressHappy->Location = System::Drawing::Point(323, 104);
			this->progressHappy->Name = L"progressHappy";
			this->progressHappy->Size = System::Drawing::Size(286, 23);
			this->progressHappy->TabIndex = 5;
			// 
			// progressEat
			// 
			this->progressEat->Location = System::Drawing::Point(323, 147);
			this->progressEat->Name = L"progressEat";
			this->progressEat->Size = System::Drawing::Size(286, 23);
			this->progressEat->TabIndex = 6;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::Color::White;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold));
			this->label2->ForeColor = System::Drawing::Color::Black;
			this->label2->Location = System::Drawing::Point(237, 62);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(80, 16);
			this->label2->TabIndex = 7;
			this->label2->Text = L"Здоровье";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::Color::White;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold));
			this->label3->ForeColor = System::Drawing::Color::Black;
			this->label3->Location = System::Drawing::Point(250, 108);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(69, 16);
			this->label3->TabIndex = 8;
			this->label3->Text = L"Счастье";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->BackColor = System::Drawing::Color::White;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label4->ForeColor = System::Drawing::Color::Black;
			this->label4->Location = System::Drawing::Point(244, 149);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(76, 18);
			this->label4->TabIndex = 9;
			this->label4->Text = L"Сытость";
			// 
			// PBBeast
			// 
			this->PBBeast->BackColor = System::Drawing::SystemColors::ActiveCaption;
			this->PBBeast->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"PBBeast.Image")));
			this->PBBeast->Location = System::Drawing::Point(686, 12);
			this->PBBeast->Name = L"PBBeast";
			this->PBBeast->Size = System::Drawing::Size(310, 310);
			this->PBBeast->TabIndex = 10;
			this->PBBeast->TabStop = false;
			// 
			// buttonHealing
			// 
			this->buttonHealing->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"buttonHealing.Image")));
			this->buttonHealing->Location = System::Drawing::Point(295, 193);
			this->buttonHealing->Name = L"buttonHealing";
			this->buttonHealing->Size = System::Drawing::Size(90, 90);
			this->buttonHealing->TabIndex = 11;
			this->buttonHealing->UseVisualStyleBackColor = true;
			this->buttonHealing->Click += gcnew System::EventHandler(this, &WorldForm::button1_Click);
			// 
			// buttonPlaing
			// 
			this->buttonPlaing->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"buttonPlaing.Image")));
			this->buttonPlaing->Location = System::Drawing::Point(408, 193);
			this->buttonPlaing->Name = L"buttonPlaing";
			this->buttonPlaing->Size = System::Drawing::Size(90, 90);
			this->buttonPlaing->TabIndex = 12;
			this->buttonPlaing->UseVisualStyleBackColor = true;
			this->buttonPlaing->Click += gcnew System::EventHandler(this, &WorldForm::buttonPlaing_Click);
			// 
			// buttonEating
			// 
			this->buttonEating->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"buttonEating.Image")));
			this->buttonEating->Location = System::Drawing::Point(519, 193);
			this->buttonEating->Name = L"buttonEating";
			this->buttonEating->Size = System::Drawing::Size(90, 90);
			this->buttonEating->TabIndex = 13;
			this->buttonEating->UseVisualStyleBackColor = true;
			this->buttonEating->Click += gcnew System::EventHandler(this, &WorldForm::buttonEating_Click);
			// 
			// TBName
			// 
			this->TBName->Location = System::Drawing::Point(382, 12);
			this->TBName->Name = L"TBName";
			this->TBName->Size = System::Drawing::Size(152, 20);
			this->TBName->TabIndex = 15;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->BackColor = System::Drawing::Color::White;
			this->label5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold));
			this->label5->ForeColor = System::Drawing::Color::Black;
			this->label5->Location = System::Drawing::Point(339, 12);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(37, 16);
			this->label5->TabIndex = 16;
			this->label5->Text = L"Имя";
			// 
			// TBNameCreate
			// 
			this->TBNameCreate->Location = System::Drawing::Point(12, 36);
			this->TBNameCreate->Name = L"TBNameCreate";
			this->TBNameCreate->Size = System::Drawing::Size(216, 20);
			this->TBNameCreate->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::Color::White;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->ForeColor = System::Drawing::Color::Black;
			this->label1->Location = System::Drawing::Point(12, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(216, 16);
			this->label1->TabIndex = 1;
			this->label1->Text = L"Придумайте имя персонажу";
			// 
			// buttonNew
			// 
			this->buttonNew->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->buttonNew->Location = System::Drawing::Point(38, 62);
			this->buttonNew->Name = L"buttonNew";
			this->buttonNew->Size = System::Drawing::Size(152, 23);
			this->buttonNew->TabIndex = 2;
			this->buttonNew->Text = L"Создать";
			this->buttonNew->UseVisualStyleBackColor = true;
			this->buttonNew->Click += gcnew System::EventHandler(this, &WorldForm::buttonNew_Click);
			// 
			// buttonLoad
			// 
			this->buttonLoad->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->buttonLoad->Location = System::Drawing::Point(38, 101);
			this->buttonLoad->Name = L"buttonLoad";
			this->buttonLoad->Size = System::Drawing::Size(152, 23);
			this->buttonLoad->TabIndex = 3;
			this->buttonLoad->Text = L"Загрузить";
			this->buttonLoad->UseVisualStyleBackColor = true;
			this->buttonLoad->Click += gcnew System::EventHandler(this, &WorldForm::buttonLoad_Click);
			// 
			// button4
			// 
			this->button4->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->button4->Location = System::Drawing::Point(38, 144);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(152, 23);
			this->button4->TabIndex = 14;
			this->button4->Text = L"Сохранить";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &WorldForm::button4_Click);
			// 
			// WorldForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::Black;
			this->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"$this.BackgroundImage")));
			this->ClientSize = System::Drawing::Size(1008, 361);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->buttonLoad);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->buttonNew);
			this->Controls->Add(this->TBName);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->TBNameCreate);
			this->Controls->Add(this->buttonEating);
			this->Controls->Add(this->buttonPlaing);
			this->Controls->Add(this->buttonHealing);
			this->Controls->Add(this->PBBeast);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->progressEat);
			this->Controls->Add(this->progressHappy);
			this->Controls->Add(this->progressHealth);
			this->ForeColor = System::Drawing::Color::AliceBlue;
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::SizableToolWindow;
			this->Name = L"WorldForm";
			this->Text = L"Тамагочи";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->PBBeast))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void buttonNew_Click(System::Object^  sender, System::EventArgs^  e) {
		beast = control.New(control.Converter(TBNameCreate->Text));
		TBName->Text = gcnew String(beast.GetName().c_str());
		PBBeast->Image = Image::FromFile("Happy.png");
		//startGame();
	}

	private: System::Void buttonLoad_Click(System::Object^  sender, System::EventArgs^  e) {
		beast = control.Load();
		TBName->Text = gcnew String(beast.GetName().c_str());
		if (beast.GetFullness() > 50 && beast.GetHappy() > 50 && beast.GetHP() > 50)
			PBBeast->Image = Image::FromFile("Happy.png");
		if (beast.GetFullness() < 50 || beast.GetHappy() < 50 || beast.GetHP() < 50)
			PBBeast->Image = Image::FromFile("Norm.png");
		if (beast.GetFullness() < 25 || beast.GetHappy() < 25 || beast.GetHP() < 25)
			PBBeast->Image = Image::FromFile("Sad.png");
		//startGame();
	}
	private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
		control.Save(beast.GetHP(), beast.GetHappy(), beast.GetFullness());
	}
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		beast.SetHP(15);
	}
	private: System::Void buttonPlaing_Click(System::Object^  sender, System::EventArgs^  e) {
		beast.SetHappy(20);
	}
	private: System::Void buttonEating_Click(System::Object^  sender, System::EventArgs^  e) {
		beast.SetEat(25);
	}
			 void startGame()
			 {
				 for (;;)
				 {
					 beast.SetHP(beast.GetHP() - 1);
					 progressHealth->Value = beast.GetHP();
					 beast.SetHappy(beast.GetHappy() - 1);
					 progressHealth->Value = beast.GetHappy();
					 beast.SetEat(beast.GetFullness() - 1);
					 progressHealth->Value = beast.GetFullness();

					 if (beast.GetFullness() > 50 && beast.GetHappy() > 50 && beast.GetHP() > 50)
						 PBBeast->Image = Image::FromFile("Happy.png");
					 if (beast.GetFullness() < 50 || beast.GetHappy() < 50 || beast.GetHP() < 50)
						 PBBeast->Image = Image::FromFile("Norm.png");
					 if (beast.GetFullness() < 25 || beast.GetHappy() < 25 || beast.GetHP() < 25)
						 PBBeast->Image = Image::FromFile("Sad.png");
				 }
			 }
	};
}
