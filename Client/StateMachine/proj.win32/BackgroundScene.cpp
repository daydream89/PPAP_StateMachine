
#include "BackgroundScene.h"
#include "SimpleAudioEngine.h"

USING_NS_CC;

Scene* BackgroundScene::createScene()
{
	return BackgroundScene::create();
}

// Print useful error message instead of segfaulting when files are not there.
static void problemLoading(const char* filename)
{
	printf("Error while loading: %s\n", filename);
	printf("Depending on how you compiled you might have to add 'Resources/' in front of filenames in HelloWorldScene.cpp\n");
}

// on "init" you need to initialize your instance
bool BackgroundScene::init()
{
	//////////////////////////////
	// 1. super init first
	if (!Scene::init())
	{
		return false;
	}

	auto visibleSize = Director::getInstance()->getVisibleSize();
	Vec2 origin = Director::getInstance()->getVisibleOrigin();


	/////////////////////////////
	// 2. add a menu item with "X" image, which is clicked to quit the program
	//    you may modify it.

	// add a "close" icon to exit the progress. it's an autorelease object
	auto closeItem = MenuItemImage::create(
		"CloseNormal.png",
		"CloseSelected.png",
		CC_CALLBACK_1(BackgroundScene::menuCloseCallback, this));

	if (closeItem == nullptr ||
		closeItem->getContentSize().width <= 0 ||
		closeItem->getContentSize().height <= 0)
	{
		problemLoading("'CloseNormal.png' and 'CloseSelected.png'");
	}
	else
	{
		float x = origin.x + visibleSize.width - closeItem->getContentSize().width / 2;
		float y = origin.y + closeItem->getContentSize().height / 2;
		closeItem->setPosition(Vec2(x, y));
	}

	SpriteFrameCache *cache = SpriteFrameCache::getInstance();

	SpriteFrame *bgSprite = SpriteFrame::create("bg.png", Rect(0, 0, 100, 100));
	cache->addSpriteFrame(bgSprite, "bg");

	Sprite *bg1 = Sprite::createWithSpriteFrameName("bg");
	Sprite *bg[10][10];
	bg1->setPosition(Point(0, 0));
	this->addChild(bg1);
	int xPos, yPos;
	for (int height = 0; height < 8; height++) {
		for (int width = 0; width < 10; width++) {
			bg[height][width] = Sprite::createWithSpriteFrameName("bg");
			bg[height][width]->setPosition(Point(100 * width + 50, 100 * height + 50));
			this->addChild(bg[height][width]);
		}
	}


	// create menu, it's an autorelease object
	auto menu = Menu::create(closeItem, NULL);
	menu->setPosition(Vec2::ZERO);
	this->addChild(menu, 1);

	/////////////////////////////
	// 3. add your codes below...

	// add a label shows "Hello World"
	// create and initialize a label
#if 0
	auto label = Label::createWithTTF("Hello World", "fonts/Marker Felt.ttf", 24);
	if (label == nullptr)
	{
		problemLoading("'fonts/Marker Felt.ttf'");
	}
	else
	{
		// position the label on the center of the screen
		label->setPosition(Vec2(origin.x + visibleSize.width / 2,
			origin.y + visibleSize.height - label->getContentSize().height));

		// add the label as a child to this layer
		this->addChild(label, 1);
	}

	// add "HelloWorld" splash screen"
	auto sprite = Sprite::create("HelloWorld.png");
	if (sprite == nullptr)
	{
		problemLoading("'HelloWorld.png'");
	}
	else
	{
		// position the sprite on the center of the screen
		sprite->setPosition(Vec2(visibleSize.width / 2 + origin.x, visibleSize.height / 2 + origin.y));

		// add the sprite as a child to this layer
		this->addChild(sprite, 0);
	}
#endif

	return true;
}
int BackgroundMap::max_width = 10;
int BackgroundMap::max_height = 8;
int BackgroundMap::bg_width = 100;
int BackgroundMap::bg_height = 100;
	static int bg_num;
class BackgroundMap
{
private:
	static int max_width;
	static int max_height;
	static int bg_width;
	static int bg_height;
	static int bg_num;
	int x;
	int y;
	int style;
	Sprite *bgSprite;
public:
	BackgroundMap(int x, int y, int style);
	void BackgroundInit(void);
	void ChangeBackgroundImage(int style);
};
BackgroundMap::BackgroundMap(int x, int y, int style)
{

}


void BackgroundScene::menuCloseCallback(Ref* pSender)
{
	//Close the cocos2d-x game scene and quit the application
	Director::getInstance()->end();

	/*To navigate back to native iOS screen(if present) without quitting the application  ,do not use Director::getInstance()->end() as given above,instead trigger a custom event created in RootViewController.mm as below*/

	//EventCustom customEndEvent("game_scene_close_event");
	//_eventDispatcher->dispatchEvent(&customEndEvent);


}
