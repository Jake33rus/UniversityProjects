
#include <iostream>
#include <ctime>   
#include "WorkToXML.cpp"
class Controller 
{
	WorkToXML worker;
	
public:
	void SetHP(Beast beast) {
		beast.SetHP(10);
	}
	void SetHappy(Beast beast) {
		beast.SetHappy(20);
	}
	void SetEat(Beast beast) {
		beast.SetEat(15);
	}

	string Converter(System::String^ s) {
		char cStr[50] = { 0 };
		if (s->Length < sizeof(cStr))
			sprintf(cStr, "%s", s);
		string stlString(cStr);
		return stlString;
	}
	int pereodicTimer(int s, int param)
	{
		clock_t end_time = clock() + s * CLOCKS_PER_SEC;
		while (clock()<end_time) {}
		return --param;
	}
	Beast Load() {
		return worker.readXML();
	}
	void Save(int h, int f, int p) {
		return worker.saveXML(h, f, p);
	}
	Beast New(string name) {
		
		return worker.newXML(name);
	}
};