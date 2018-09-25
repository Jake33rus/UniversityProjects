#include "AutosalonForm.h"

using namespace System;
using namespace System::Windows::Forms;


[STAThread]
int main() {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	AutoSalon20::AutosalonForm form;
	Application::Run(%form);
	return 0; 
}