#include "Controller.cpp"

Controller control;
namespace SelectionTables {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для SelTForm
	/// </summary>
	public ref class SelTForm : public System::Windows::Forms::Form
	{
	public:
		SelTForm(void)
		{
			InitializeComponent();
			control.LoadTables();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~SelTForm()
		{
			if (components)
			{
				delete components;
			}
		}
		System::Windows::Forms::ListViewItem^ LVItem;
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::Label^  label3;

	protected:

	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::ComboBox^  CBCountry;



	private: System::Windows::Forms::ComboBox^  CBMaterial;

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::ComboBox^  CBColor;

	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;

	private: System::Windows::Forms::RichTextBox^  RBInfo;


	private: System::Windows::Forms::Button^  SearchButton;
	private: System::Windows::Forms::ListView^  LVofTables;
	private: System::Windows::Forms::ColumnHeader^  Name;
	private: System::Windows::Forms::ColumnHeader^  Price;

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
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->SearchButton = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->CBCountry = (gcnew System::Windows::Forms::ComboBox());
			this->CBMaterial = (gcnew System::Windows::Forms::ComboBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->CBColor = (gcnew System::Windows::Forms::ComboBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->RBInfo = (gcnew System::Windows::Forms::RichTextBox());
			this->LVofTables = (gcnew System::Windows::Forms::ListView());
			this->Name = (gcnew System::Windows::Forms::ColumnHeader());
			this->Price = (gcnew System::Windows::Forms::ColumnHeader());
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->SearchButton);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->CBCountry);
			this->groupBox1->Controls->Add(this->CBMaterial);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Controls->Add(this->CBColor);
			this->groupBox1->Location = System::Drawing::Point(13, 13);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(711, 110);
			this->groupBox1->TabIndex = 0;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Выбор параметров";
			// 
			// SearchButton
			// 
			this->SearchButton->Location = System::Drawing::Point(219, 81);
			this->SearchButton->Name = L"SearchButton";
			this->SearchButton->Size = System::Drawing::Size(286, 23);
			this->SearchButton->TabIndex = 9;
			this->SearchButton->Text = L"Просмотреть список товаров";
			this->SearchButton->UseVisualStyleBackColor = true;
			this->SearchButton->Click += gcnew System::EventHandler(this, &SelTForm::SearchButton_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(513, 44);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(55, 13);
			this->label3->TabIndex = 8;
			this->label3->Text = L"Страна ->";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(254, 44);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(69, 13);
			this->label2->TabIndex = 7;
			this->label2->Text = L"Материал ->";
			// 
			// CBCountry
			// 
			this->CBCountry->FormattingEnabled = true;
			this->CBCountry->Items->AddRange(gcnew cli::array< System::Object^  >(5) { L"", L"Russia", L"China", L"Italy", L"Germany" });
			this->CBCountry->Location = System::Drawing::Point(574, 40);
			this->CBCountry->Name = L"CBCountry";
			this->CBCountry->Size = System::Drawing::Size(121, 21);
			this->CBCountry->TabIndex = 6;
			// 
			// CBMaterial
			// 
			this->CBMaterial->FormattingEnabled = true;
			this->CBMaterial->Items->AddRange(gcnew cli::array< System::Object^  >(3) { L"", L"Wood", L"Glass" });
			this->CBMaterial->Location = System::Drawing::Point(329, 40);
			this->CBMaterial->Name = L"CBMaterial";
			this->CBMaterial->Size = System::Drawing::Size(121, 21);
			this->CBMaterial->TabIndex = 5;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(13, 44);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(44, 13);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Цвет ->";
			// 
			// CBColor
			// 
			this->CBColor->FormattingEnabled = true;
			this->CBColor->Items->AddRange(gcnew cli::array< System::Object^  >(5) { L"", L"Black", L"White", L"Brawn", L"Grey" });
			this->CBColor->Location = System::Drawing::Point(63, 40);
			this->CBColor->Name = L"CBColor";
			this->CBColor->Size = System::Drawing::Size(121, 21);
			this->CBColor->TabIndex = 0;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(109, 162);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(88, 13);
			this->label4->TabIndex = 9;
			this->label4->Text = L"Список товаров";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(465, 162);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(130, 13);
			this->label5->TabIndex = 10;
			this->label5->Text = L"Детальная информация";
			// 
			// RBInfo
			// 
			this->RBInfo->Location = System::Drawing::Point(324, 178);
			this->RBInfo->Name = L"RBInfo";
			this->RBInfo->Size = System::Drawing::Size(384, 251);
			this->RBInfo->TabIndex = 12;
			this->RBInfo->Text = L"";
			// 
			// LVofTables
			// 
			this->LVofTables->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(2) { this->Name, this->Price });
			this->LVofTables->Location = System::Drawing::Point(13, 178);
			this->LVofTables->Name = L"LVofTables";
			this->LVofTables->Size = System::Drawing::Size(305, 251);
			this->LVofTables->TabIndex = 13;
			this->LVofTables->UseCompatibleStateImageBehavior = false;
			this->LVofTables->View = System::Windows::Forms::View::Details;
			this->LVofTables->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &SelTForm::LVofTables_MouseClick);
			// 
			// Name
			// 
			this->Name->Text = L"Name";
			this->Name->Width = 140;
			// 
			// Price
			// 
			this->Price->Text = L"Price";
			this->Price->Width = 161;
			// 
			// SelTForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(737, 461);
			this->Controls->Add(this->LVofTables);
			this->Controls->Add(this->RBInfo);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->groupBox1);
			//this->Name = L"SelTForm";
			this->Text = L"Подбор столов";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

private: System::Void SearchButton_Click(System::Object^  sender, System::EventArgs^  e) {
	this->LVofTables->Items->Clear();
	RBInfo->Text = "";
	string color = control.Converter(CBColor->Text);
	string material = control.Converter(CBMaterial->Text);
	string country = control.Converter(CBCountry->Text);
	for each (Table t in control.Search(color, material, country))
	{
		LVItem = gcnew Windows::Forms::ListViewItem(gcnew String(t.GetName().c_str()));
		LVItem->SubItems->Add(gcnew String(t.GetPrice().ToString()));
		this->LVofTables->Items->Add(this->LVItem);
	}
}
private: System::Void LVofTables_MouseClick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
	RBInfo->Text = "";
	RBInfo->Text = gcnew String(control.SerchOne(control.Converter(LVofTables->SelectedItems[0]->SubItems[0]->Text)).ShowInfo().c_str());
}
};
}
