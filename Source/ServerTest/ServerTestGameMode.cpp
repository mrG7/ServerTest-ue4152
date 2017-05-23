// Fill out your copyright notice in the Description page of Project Settings.

#include "ServerTest.h"
#include "ServerTestGameMode.h"

void AServerTestGameMode::BeginPlay()
{
	Super::BeginPlay();

	TArray<int32> TestArray;
	int32 Crash = TestArray[0];
}