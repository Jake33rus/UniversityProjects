#include <stdio.h>
#include <iostream>
#include <string>
#include "tinyxml2.h"
#include <locale>
#include <list>
#include "Car.cpp"


using namespace tinyxml2;
using namespace std;

class Parser {
	string mark, model, color, type, complictationType, status;
	int price, horsepower, mass, maxspeed, count;
	double secToMaxspeed;
	Complectation comp;
	list<Car> result;


	list<Car> Load(char* nameDoc) {
		result.clear();
		string mark, model, color, type, complictationType, status;
		int price, horsepower, mass, maxspeed, count;
		double secToHundred;

		XMLDocument doc;
		XMLError eResult = doc.LoadFile(nameDoc);
		XMLNode* root = doc.FirstChildElement("Cars");
		XMLElement* element = root->FirstChildElement("Mark");
		mark = element->GetText();
		element = root->FirstChildElement("Count");
		element->QueryIntText(&count);
		element = root->FirstChildElement("Car");
		XMLElement* item;
		int i = 0;
		while (element != nullptr && i < count) {
			item = element->FirstChildElement("Model");
			model = item->GetText();
			item = element->FirstChildElement("color");
			color = item->GetText();
			item = element->FirstChildElement("type");
			type = item->GetText();
			item = element->FirstChildElement("complictationType");
			complictationType = item->GetText();
			item = element->FirstChildElement("price");
			item->QueryIntText(&price);
			item = element->FirstChildElement("horsepower");
			item->QueryIntText(&horsepower);
			item = element->FirstChildElement("mass");
			item->QueryIntText(&mass);
			item = element->FirstChildElement("maxspeed");
			item->QueryIntText(&maxspeed);
			item = element->FirstChildElement("secToHundred");
			item->QueryDoubleText(&secToHundred);
			item = element->FirstChildElement("status");
			status = item->GetText();
			result.push_back(Car(complictationType, color, type, price, horsepower, mass, maxspeed, secToHundred, status, mark, model ));
			element = element->NextSiblingElement("Car");
			i++;
		}
		return result;
	}
public:
	Parser() {}

	void Save(Car car) 
	{	
		char* docName;
		XMLDocument doc;
		if (car.GetMark() == "BMW") {
			docName = "bmw.xml";
		}
		if (car.GetMark() == "Kia") {
			docName = "kia.xml";
		}
		if (car.GetMark() == "Audi") {
			docName = "audi.xml";
		}
		if (car.GetMark() == "Nissan") {
			docName = "nissan.xml";
		}
		int count, i;
		doc.LoadFile(docName);
		XMLNode* root = doc.FirstChildElement("Cars");
		XMLElement* element = root->FirstChildElement("Count");
		element = root->FirstChildElement("Car");
		element->QueryIntText(&count);
		while (element != nullptr && i < count) {
			XMLElement* model = element->FirstChildElement("Model");
			XMLElement*	color = element->FirstChildElement("color");
			XMLElement* comp = element->FirstChildElement("complictationType");
			XMLElement* item = element->FirstChildElement("status");
			if (car.GetModel() == model->GetText() && car.GetColor() == color->GetText() && car.GetCompType() == comp->GetText()) 
			{
				item->SetText(car.GetStatus().c_str());  
			}
			element = element->NextSiblingElement("Car");
			i++;
		}
		doc.SaveFile(docName);
	}
	list<Car> GetAllCars() {
		list<Car> temp;
		for each (Car c in GetAudi())
		{
			temp.push_back(c);
		}
		for each (Car c in GetNissan())
		{
			temp.push_back(c);
		}
		for each (Car c in GetBMW())
		{
			temp.push_back(c);
		}
		for each (Car c in GetKia())
		{
			temp.push_back(c);
		}
		return temp;
 	}
	list<Car> GetAudi() {
		return Load("audi.xml");
	}
	list<Car> GetBMW() {
		return Load("bmw.xml");
	}
	list<Car> GetNissan() {
		return Load("nissan.xml");
	}
	list<Car> GetKia() {
		return Load("kia.xml");
	}
};