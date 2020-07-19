#include "BackgroundMap.h"

namespace Background
{
	const int widthNum = 10;
	const int heightNum = 8;
	const int widthSize = 100;
	const int heightSize = 100;
	BackgroundMap **bgMap;
}

bool BackgroundMap::init_checker = false;

BackgroundMap::BackgroundMap()
{
}
BackgroundMap::BackgroundMap(int x, int y, int style)
{
	if (!getInitChecker())
		backgroundMapInit();

	changeBackgroundImage(style);
	
}

void BackgroundMap::backgroundMapInit()
{
	using namespace Background;
	bgMap = new BackgroundMap *[Background::widthNum];
	for (int i = 0; i < Background::widthNum; i++)
	{
		Background::bgMap[i] = new BackgroundMap[Background::heightNum];
	}

	SpriteFrameCache *cache = SpriteFrameCache::getInstance();

	SpriteFrame *grassBackground = SpriteFrame::create("grass.png", Rect(0, 0, 100, 100));
	cache->addSpriteFrame(grassBackground, "GRASS");

	SpriteFrame *mudBackground = SpriteFrame::create("mud.png", Rect(0, 0, 100, 100));
	cache->addSpriteFrame(mudBackground, "MUD");

	setInitChecker(true);
}

void BackgroundMap::changeBackgroundImage(int style)
{
	SpriteFrameCache *cache = SpriteFrameCache::getInstance();
	Sprite *backgroundSprite = getSprite();
	switch (style)
	{
	case GRASS:
	{
		SpriteFrame *frame = cache->spriteFrameByName("GRASS");
		backgroundSprite->setTexture(frame->getTexture());
		break;
	}
	case MUD:
	{
		SpriteFrame *frame = cache->spriteFrameByName("MUD");
		backgroundSprite->setTexture(frame->getTexture());
		break;
	}
	}
}

void BackgroundMap::setSpritePosition(int x, int y)
{
	Sprite *bgSprite = getSprite();
	bgSprite->setPosition(Point(Background::widthSize * x + Background::heightSize / 2, 
		Background::heightSize * y + Background::heightSize / 2));
}
