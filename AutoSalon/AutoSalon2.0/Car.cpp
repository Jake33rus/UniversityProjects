#include "BaseHeader.h"
#include "Complectation.cpp"
#include <sstream>
using namespace std;

class Car
{
	string color;
	string type;
	int price;
	int horsepower;
	int mass;
	int maxspeed;
	double secToHundred;
	string status;
	string mark;
	string model;
	string compType;
	Complectation *comp;

	string convertInt(int i) {
		stringstream ss;
		ss << i;
		return ss.str();
	}
	public:
		Car() {}
		Car(string j, string a = NULL, string b = NULL, int c = 0, int d = 0, int e = 0,
			 int g = 0, double h = 0, string k = "Available", string l = NULL, string m = NULL)
		{
			color = a;
			type = b;
			price = c;
			horsepower = d;
			mass = e;
			maxspeed = g;
			secToHundred = h;
			mark = l;
			model = m;
			status = k;
			compType = j;
			comp = new Complectation(j);
		}
		string GetColor() {
			return color;
		}
		string GetType() {
			return type;
		}
		string GetStatus() {
			return status;
		}
		string GetMark() {
			return mark;
		}
		string GetModel() {
			return model;
		}
		string GetCompType() {
			return compType;
		}
		int GetPrice() {
			return price;
		}
		int GetHorsepower() {
			return horsepower;
		}
		int GetMass() {
			return mass;
		}
		int GetMaxspeed() {
			return maxspeed;
		}

		double GetSecToHundred() {
			return secToHundred;
		}
		
		void ChangeStatus()
		{
			status = "Unavailable";
		}
		string ShowInfo() {
			return "Model-> " + model + "\n Mark-> " + mark + "\n Type-> " + type + "\n price-> " + convertInt(price) + "\n Color-> " + color
				+ "\n Horsepower->" + convertInt(horsepower) + "\n Mass-> " + convertInt(mass) + "\n Max speed ->" + convertInt(maxspeed)
				+ "\n Seconds to 100-> " + convertInt(secToHundred) +"\n"+ comp->ShowInfo();
		}
};