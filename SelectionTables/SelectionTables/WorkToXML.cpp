#include "Table.cpp"
using namespace tinyxml2;
using namespace std;
class WorkToXML {
	string name, material, color, country;
	int price, sizeX, sizeY, count;
	list<Table> tables;
public:
	WorkToXML() {}
	list<Table> Load() {
		XMLDocument doc;
		XMLError eResult = doc.LoadFile("Tables.xml");
		XMLNode* root = doc.FirstChildElement("Tables");
		XMLElement* element = root->FirstChildElement("Count");
		element->QueryIntText(&count);
		element = root->FirstChildElement("Table");
		XMLElement* item;
		int i = 0;
		while (element != nullptr && i < count) {
			item = element->FirstChildElement("Name");
			name = item->GetText();
			item = element->FirstChildElement("Material");
			material = item->GetText();
			item = element->FirstChildElement("Color");
			color = item->GetText();
			item = element->FirstChildElement("Country");
			country = item->GetText();
			item = element->FirstChildElement("Price");
			item->QueryIntText(&price);
			item = element->FirstChildElement("X");
			item->QueryIntText(&sizeX);
			item = element->FirstChildElement("Y");
			item->QueryIntText(&sizeY);
			tables.push_back(Table(name, material, color, country, price, sizeX, sizeY));
			element = element->NextSiblingElement("Table");
			i++;
		}
		return tables;
	}
};