// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/GameMode.h"
#include "ServerTestGameMode.generated.h"

/**
 * 
 */
UCLASS()
class SERVERTEST_API AServerTestGameMode : public AGameMode
{
	GENERATED_BODY()
	
public:
	void BeginPlay() override;
	
	
};
