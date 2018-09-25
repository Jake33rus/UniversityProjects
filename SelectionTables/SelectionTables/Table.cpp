#include "Header.h"
using namespace std;
class Table 
{
	string name, material, color, country;
	int price, sizeX, sizeY;
public:
	Table(string name, string  material, string color, string country, int price, int sizeX, int sizeY) 
	{	
		this->name = name;
		this->material = material;
		this->color = color;
		this->country = country;
		this->price = price;
		this->sizeX = sizeX;
		this->sizeY = sizeY;
	}
	string GetName() { return name; }
	string GetMaterial() { return material; }
	string GetColor() { return color; }
	string GetCountry() { return country; }
	int GetPrice() { return price; }
	int GetSizeX() { return sizeX; }
	int GetSizeY() { return sizeY; }
	string ShowInfo() 
	{
		return "Table " + name + "\n\n Made of " + material + "\n Made from " + country + "\n Color - " + color +
			"\n Price - " + IntToStr(price) + " rub \n Size: " + IntToStr(sizeX) + "*" + IntToStr(sizeY);
	}
	string IntToStr(int i) {
		stringstream ss;
		ss << i;
		return ss.str();
	}
};