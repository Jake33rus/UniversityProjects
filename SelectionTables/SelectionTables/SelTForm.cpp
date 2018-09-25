#include "SelTForm.h"
using namespace System;
using namespace System::Windows::Forms;


[STAThread]
int main() {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	SelectionTables::SelTForm form;
	Application::Run(%form);
	return 0;
}
