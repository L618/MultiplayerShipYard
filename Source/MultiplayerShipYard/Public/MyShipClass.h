// bv01d7@gmail.com

#pragma once

#include "CoreMinimal.h"


FString name = "X";
FString vClass = "X"; 
uint16 cubeSize = 512;
uint8 maxX = 1;
uint8 maxY = 1;
uint8 maxZ = 1;
uint8 ctrX = 0;
uint8 ctrY = 0;
uint8 ctrZ = 0;
uint32 index = 0;
uint8 totLength = 0;
uint8 totWidth = 0;
uint8 totHeight = 0;
uint32 totWeight = 0;
//power system pointer (reactor)
//data system pointer (computer)
//lift system pointer (intership transport)

/**
 * 
 */
class MULTIPLAYERSHIPYARD_API MyShipClass
{
public:
	MyShipClass();
	~MyShipClass();
};
