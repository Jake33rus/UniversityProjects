#include <string>
#include "tinyxml2.h"
#include "Panda.cpp"

using namespace std;
using namespace tinyxml2;

class XMLsup
{
	XMLDocument doc;

public:

	Panda loadFromXML()
	{
		int health, power, mood;
		doc.LoadFile("MyPanda.xml");
		XMLNode* root = doc.FirstChildElement("Panda");
		XMLElement* Health = root->FirstChildElement("Health");
		Health->QueryIntText(&health);
		XMLElement* Power = root->FirstChildElement("Power");
		Power->QueryIntText(&power);
		XMLElement* Mood = root->FirstChildElement("Mood");
		Mood->QueryIntText(&mood);

		return Panda(health, power, mood);
	}

	void saveToXML(Panda panda) {
		doc.LoadFile("MyPanda.xml");
		XMLNode* root = doc.FirstChildElement("Panda");
		XMLElement* Singularity = root->FirstChildElement("Health");
		Singularity->SetText(panda.getHealth());
		XMLElement* Power = root->FirstChildElement("Power");
		Power->SetText(panda.getPower());
		XMLElement* Mood = root->FirstChildElement("Mood");
		Mood->SetText(panda.getMood());
		doc.SaveFile("MyPanda.xml");
	}
	
	Panda newGame()
	{
		doc.LoadFile("MyPanda.xml");
		XMLNode* root = doc.FirstChildElement("Panda");
		XMLElement* Health = root->FirstChildElement("Health");
		Health->SetText(100);
		XMLElement* Power = root->FirstChildElement("Power");
		Power->SetText(100);
		XMLElement* Mood = root->FirstChildElement("Mood");
		Mood->SetText(100);

		return Panda();
	}


};