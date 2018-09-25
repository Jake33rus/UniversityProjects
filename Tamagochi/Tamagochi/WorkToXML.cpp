#include <string>
#include "Beast.cpp"
#include "tinyxml2.h"
using namespace std;
using namespace tinyxml2;
class WorkToXML {
	XMLDocument doc;
	
public:
	Beast newXML(string n) {
		doc.LoadFile("Tamagochi.xml");
		XMLNode* root = doc.FirstChildElement("Beast");
		XMLElement* name = root->FirstChildElement("Name");
		XMLElement* HP = root->FirstChildElement("HP");
		XMLElement* eat = root->FirstChildElement("Eat");
		XMLElement* game = root->FirstChildElement("Game");
		name->SetText(n.c_str());
		HP->SetText(100);
		eat->SetText(100);
		game->SetText(100);
		doc.SaveFile("Tamagochi.xml");
		return Beast(n);
	}
	Beast readXML() {
		string name;
		int health, food, play;
		doc.LoadFile("Tamagochi.xml");
		XMLNode* root = doc.FirstChildElement("Beast");
		XMLElement* n = root->FirstChildElement("Name");
		name = n->GetText();
		XMLElement* HP = root->FirstChildElement("HP");
		HP->QueryIntText(&health);
		XMLElement* eat = root->FirstChildElement("Eat");
		eat->QueryIntText(&food);
		XMLElement* game = root->FirstChildElement("Game");
		game->QueryIntText(&play);
		return Beast(name, health, food, play);
	}

	void saveXML(int health, int food, int happy ) {
		doc.LoadFile("Tamagochi.xml");
		XMLNode* root = doc.FirstChildElement("Beast");
		XMLElement* HP = root->FirstChildElement("HP");
		HP->SetText(health);
		XMLElement* eat = root->FirstChildElement("Eat");
		eat->SetText(food);
		XMLElement* game = root->FirstChildElement("Game");
		game->SetText(happy);
		doc.SaveFile("Tamagochi.xml");
	}
};