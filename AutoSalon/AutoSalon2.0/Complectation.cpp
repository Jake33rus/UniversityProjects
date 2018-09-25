#include "BaseHeader.h"

using namespace std;

class Complectation
{
	string cabinDesc;
	bool condit;
	bool onboardComp;
	string diskDesc;
	string gearbpxType;

	public:

	Complectation(string a="Base" )
	{
		if (a == "Base")
		{
			cabinDesc = "fabric upholstery";
			diskDesc = "pressed discs";
			gearbpxType = "manual gearbox";
			condit = false;
			onboardComp = false;
		}
		else if (a == "Sport")
		{
			cabinDesc = "sport chairs";
			diskDesc = "alloy wheels";
			gearbpxType = "manual gearbox";
			condit = true;
			onboardComp = true;
		}
		else
		{
			cabinDesc = "leather upholstery";
			diskDesc = "alloy wheels";
			gearbpxType = "automatic transmission";
			condit = true;
			onboardComp = true;
		}
	}

	string ShowInfo() {
		string condey = condit ? "Conditional est'" : "Conditional net";
		string comp = onboardComp ? "On Board Computer" : "Magnitola";
		return cabinDesc + " " + diskDesc + " " + gearbpxType + " " + condey + " " + comp+"\n";
	}
};