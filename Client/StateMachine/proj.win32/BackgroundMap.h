#pragma once
#include "cocos2d.h"
USING_NS_CC;

class BackgroundMap
{
private:
	static bool init_checker;
	int x;
	int y;
	enum style {GRASS, MUD, WALL};
	Sprite *bgSprite;

private:
	void backgroundMapInit(void);
	bool getInitChecker(void) { return init_checker; }
	void setInitChecker(bool check) { init_checker = check; }
	void setSpritePosition(int x, int y);

public:
	BackgroundMap();
	BackgroundMap(int x, int y, int style);
	void changeBackgroundImage(int style);
	Sprite *getSprite() { return bgSprite; }
};

