using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts.Health;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Skating;
using Il2CppScheduleOne.Stealth;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.Variables;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E1 RID: 993
	public class Player : NetworkBehaviour
	{
		// Token: 0x06004CBE RID: 19646 RVA: 0x00170620 File Offset: 0x0016E820
		// Note: this type is marked as 'beforefieldinit'.
		static Player()
		{
			Il2CppClassPointerStore<Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "Player");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player>.NativeClassPtr);
			Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "OWNER_PLAYER_CODE");
			Player.NativeFieldInfoPtr_CapColDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapColDefaultHeight");
			Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "objectsTemporarilyOwnedByPlayer");
			Player.NativeFieldInfoPtr_onLocalPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onLocalPlayerSpawned");
			Player.NativeFieldInfoPtr_onPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerSpawned");
			Player.NativeFieldInfoPtr_onPlayerDespawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerDespawned");
			Player.NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Local");
			Player.NativeFieldInfoPtr_PlayerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerList");
			Player.NativeFieldInfoPtr_LocalGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalGameObject");
			Player.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Avatar");
			Player.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Anim");
			Player.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VelocityCalculator");
			Player.NativeFieldInfoPtr_EyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "EyePosition");
			Player.NativeFieldInfoPtr_TestAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "TestAvatarSettings");
			Player.NativeFieldInfoPtr_VisualState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VisualState");
			Player.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Visibility");
			Player.NativeFieldInfoPtr_CapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapCol");
			Player.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PoI");
			Player.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Health");
			Player.NativeFieldInfoPtr_CrimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrimeData");
			Player.NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Energy");
			Player.NativeFieldInfoPtr_MimicCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "MimicCamera");
			Player.NativeFieldInfoPtr_FootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "FootstepDetector");
			Player.NativeFieldInfoPtr_LocalFootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalFootstepDetector");
			Player.NativeFieldInfoPtr_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CharacterController");
			Player.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PunchSound");
			Player.NativeFieldInfoPtr_ThirdPersonFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ThirdPersonFlashlight");
			Player.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NameLabel");
			Player.NativeFieldInfoPtr_Clothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Clothing");
			Player.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "GroundDetectionMask");
			Player.NativeFieldInfoPtr_AvatarOffset_Standing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Standing");
			Player.NativeFieldInfoPtr_AvatarOffset_Crouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Crouched");
			Player.NativeFieldInfoPtr_WalkingMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "WalkingMapCurve");
			Player.NativeFieldInfoPtr_CrouchWalkMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrouchWalkMapCurve");
			Player.NativeFieldInfoPtr__PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerName>k__BackingField");
			Player.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Connection");
			Player.NativeFieldInfoPtr__PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerCode>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentVehicle>k__BackingField");
			Player.NativeFieldInfoPtr_onEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onEnterVehicle");
			Player.NativeFieldInfoPtr_onExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onExitVehicle");
			Player.NativeFieldInfoPtr_LastDrivenVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LastDrivenVehicle");
			Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceVehicleExit>k__BackingField");
			Player.NativeFieldInfoPtr__Crouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Crouched>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBed>k__BackingField");
			Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsReadyToSleep>k__BackingField");
			Player.NativeFieldInfoPtr__IsSkating_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSkating>k__BackingField");
			Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
			Player.NativeFieldInfoPtr_onSkateboardMounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardMounted");
			Player.NativeFieldInfoPtr_onSkateboardDismounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardDismounted");
			Player.NativeFieldInfoPtr__IsSleeping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSleeping>k__BackingField");
			Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsRagdolled>k__BackingField");
			Player.NativeFieldInfoPtr__IsArrested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsArrested>k__BackingField");
			Player.NativeFieldInfoPtr__IsTased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsTased>k__BackingField");
			Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsUnconscious>k__BackingField");
			Player.NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Scale>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LastVisitedProperty>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBusiness>k__BackingField");
			Player.NativeFieldInfoPtr_HasCompletedIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "HasCompletedIntro");
			Player.NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraPosition>k__BackingField");
			Player.NativeFieldInfoPtr__CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraRotation>k__BackingField");
			Player.NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Inventory");
			Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentAvatarSettings>k__BackingField");
			Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ConsumedProduct>k__BackingField");
			Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceProductConsumed>k__BackingField");
			Player.NativeFieldInfoPtr_DebugAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "DebugAvatarSettings");
			Player.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "loader");
			Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Player.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<HasChanged>k__BackingField");
			Player.NativeFieldInfoPtr_onRagdoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdoll");
			Player.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdollEnd");
			Player.NativeFieldInfoPtr_onArrested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onArrested");
			Player.NativeFieldInfoPtr_onFreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onFreed");
			Player.NativeFieldInfoPtr_onTased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTased");
			Player.NativeFieldInfoPtr_onTasedEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTasedEnd");
			Player.NativeFieldInfoPtr_onPassedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassedOut");
			Player.NativeFieldInfoPtr_onPassOutRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassOutRecovery");
			Player.NativeFieldInfoPtr_PlayerVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerVariables");
			Player.NativeFieldInfoPtr_VariableDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VariableDict");
			Player.NativeFieldInfoPtr_standingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "standingScale");
			Player.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "timeAirborne");
			Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<avatarVisibleToLocalPlayer>k__BackingField");
			Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerDataRetrieveReturned>k__BackingField");
			Player.NativeFieldInfoPtr_taseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "taseCoroutine");
			Player.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ragdollForceComponents");
			Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerSaveRequestReturned>k__BackingField");
			Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerInitializedOverNetwork>k__BackingField");
			Player.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "impactHistory");
			Player.NativeFieldInfoPtr__Paranoid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Paranoid>k__BackingField");
			Player.NativeFieldInfoPtr__Sneaky_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Sneaky>k__BackingField");
			Player.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Disoriented>k__BackingField");
			Player.NativeFieldInfoPtr__Seizure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Seizure>k__BackingField");
			Player.NativeFieldInfoPtr_seizureRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "seizureRotations");
			Player.NativeFieldInfoPtr__Slippery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Slippery>k__BackingField");
			Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Schizophrenic>k__BackingField");
			Player.NativeFieldInfoPtr_equippableMessageIDHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "equippableMessageIDHistory");
			Player.NativeFieldInfoPtr_lerpScaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "lerpScaleRoutine");
			Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerName>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerCode>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentVehicle>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentBed>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<IsReadyToSleep>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraPosition>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraRotation>k__BackingField");
			Player.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
			Player.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
			Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672768);
			Player.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672769);
			Player.NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672770);
			Player.NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672771);
			Player.NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672772);
			Player.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672773);
			Player.NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672774);
			Player.NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672775);
			Player.NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672776);
			Player.NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672777);
			Player.NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672778);
			Player.NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672779);
			Player.NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672780);
			Player.NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672781);
			Player.NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672782);
			Player.NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672783);
			Player.NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672784);
			Player.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672785);
			Player.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672786);
			Player.NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672787);
			Player.NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672788);
			Player.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672789);
			Player.NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672790);
			Player.NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672791);
			Player.NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672792);
			Player.NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672793);
			Player.NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672794);
			Player.NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672795);
			Player.NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672796);
			Player.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672797);
			Player.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672798);
			Player.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672799);
			Player.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672800);
			Player.NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672801);
			Player.NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672802);
			Player.NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672803);
			Player.NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672804);
			Player.NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672805);
			Player.NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672806);
			Player.NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672807);
			Player.NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672808);
			Player.NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672809);
			Player.NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672810);
			Player.NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672811);
			Player.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672812);
			Player.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672813);
			Player.NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672814);
			Player.NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672815);
			Player.NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672816);
			Player.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672817);
			Player.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672818);
			Player.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672819);
			Player.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672820);
			Player.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672821);
			Player.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672822);
			Player.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672823);
			Player.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672824);
			Player.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672825);
			Player.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672826);
			Player.NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672827);
			Player.NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672828);
			Player.NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672829);
			Player.NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672830);
			Player.NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672831);
			Player.NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672832);
			Player.NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672833);
			Player.NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672834);
			Player.NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672835);
			Player.NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672836);
			Player.NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672837);
			Player.NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672838);
			Player.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672839);
			Player.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672840);
			Player.NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672841);
			Player.NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672842);
			Player.NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672843);
			Player.NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672844);
			Player.NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672845);
			Player.NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672846);
			Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672847);
			Player.NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672848);
			Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672849);
			Player.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672850);
			Player.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672851);
			Player.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672852);
			Player.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672853);
			Player.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672854);
			Player.NativeMethodInfoPtr_PlayerLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672855);
			Player.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672856);
			Player.NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672857);
			Player.NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672858);
			Player.NativeMethodInfoPtr_HostExitedGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672859);
			Player.NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672860);
			Player.NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672861);
			Player.NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672862);
			Player.NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672863);
			Player.NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672864);
			Player.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672865);
			Player.NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672866);
			Player.NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672867);
			Player.NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672868);
			Player.NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672869);
			Player.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672870);
			Player.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672871);
			Player.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672872);
			Player.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672873);
			Player.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672874);
			Player.NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672875);
			Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672876);
			Player.NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672877);
			Player.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672878);
			Player.NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672879);
			Player.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672880);
			Player.NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672881);
			Player.NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672882);
			Player.NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672883);
			Player.NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672884);
			Player.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672885);
			Player.NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672886);
			Player.NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672887);
			Player.NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672888);
			Player.NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672889);
			Player.NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672890);
			Player.NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672891);
			Player.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672892);
			Player.NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672893);
			Player.NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672894);
			Player.NativeMethodInfoPtr_Activate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672895);
			Player.NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672896);
			Player.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672897);
			Player.NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672898);
			Player.NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672899);
			Player.NativeMethodInfoPtr_SendPunch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672900);
			Player.NativeMethodInfoPtr_Punch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672901);
			Player.NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672902);
			Player.NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672903);
			Player.NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672904);
			Player.NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672905);
			Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672906);
			Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672907);
			Player.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672908);
			Player.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672909);
			Player.NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672910);
			Player.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672911);
			Player.NativeMethodInfoPtr_GetInventoryString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672912);
			Player.NativeMethodInfoPtr_GetAppearanceString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672913);
			Player.NativeMethodInfoPtr_GetClothingString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672914);
			Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672915);
			Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672916);
			Player.NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672917);
			Player.NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672918);
			Player.NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672919);
			Player.NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672920);
			Player.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672921);
			Player.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672922);
			Player.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672923);
			Player.NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672924);
			Player.NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672925);
			Player.NativeMethodInfoPtr_Arrest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672926);
			Player.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672927);
			Player.NativeMethodInfoPtr_SendPassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672928);
			Player.NativeMethodInfoPtr_PassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672929);
			Player.NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672930);
			Player.NativeMethodInfoPtr_PassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672931);
			Player.NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672932);
			Player.NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672933);
			Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672934);
			Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672935);
			Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672936);
			Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672937);
			Player.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672938);
			Player.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672939);
			Player.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672940);
			Player.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672941);
			Player.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672942);
			Player.NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672943);
			Player.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672944);
			Player.NativeMethodInfoPtr_Taze_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672945);
			Player.NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672946);
			Player.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672947);
			Player.NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672948);
			Player.NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672949);
			Player.NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672950);
			Player.NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672951);
			Player.NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672952);
			Player.NativeMethodInfoPtr_DismountSkateboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672953);
			Player.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672954);
			Player.NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672955);
			Player.NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672956);
			Player.NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672957);
			Player.NativeMethodInfoPtr_ClearProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672958);
			Player.NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672959);
			Player.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672960);
			Player.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672961);
			Player.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672962);
			Player.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672963);
			Player.NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672964);
			Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672965);
			Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672966);
			Player.NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672967);
			Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672968);
			Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672970);
			Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672971);
			Player.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672972);
			Player.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672973);
			Player.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672974);
			Player.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672975);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672976);
			Player.NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672977);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672978);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672979);
			Player.NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672980);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672981);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672982);
			Player.NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672983);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672984);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672985);
			Player.NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672986);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672987);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672988);
			Player.NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672989);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672990);
			Player.NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672991);
			Player.NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672992);
			Player.NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672993);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672994);
			Player.NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672995);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672996);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672997);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672998);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100672999);
			Player.NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673000);
			Player.NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673001);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673002);
			Player.NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673003);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673004);
			Player.NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673005);
			Player.NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673006);
			Player.NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673007);
			Player.NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673008);
			Player.NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673009);
			Player.NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673010);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673011);
			Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673012);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673013);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673014);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673015);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673016);
			Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673017);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673018);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673019);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673020);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673021);
			Player.NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673022);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673023);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673024);
			Player.NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673025);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673026);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673027);
			Player.NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673028);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673029);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673030);
			Player.NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673031);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673032);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673033);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673034);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673035);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673036);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673037);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673038);
			Player.NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673039);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673040);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673041);
			Player.NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673042);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673043);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673044);
			Player.NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673045);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673046);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673047);
			Player.NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673048);
			Player.NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673049);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673050);
			Player.NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673051);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673052);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673053);
			Player.NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673054);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673055);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673056);
			Player.NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673057);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673058);
			Player.NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673059);
			Player.NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673060);
			Player.NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673061);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673062);
			Player.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673063);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673064);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673065);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673066);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673067);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673068);
			Player.NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673069);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673070);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673071);
			Player.NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673072);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673073);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673074);
			Player.NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673075);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673076);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673077);
			Player.NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673078);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673079);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673080);
			Player.NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673081);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673082);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673083);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673084);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673085);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673086);
			Player.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673087);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673088);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673089);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673090);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673091);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673092);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673093);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673094);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673095);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673096);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673097);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673098);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673099);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673100);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673101);
			Player.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673102);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673103);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673104);
			Player.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673105);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673106);
			Player.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673107);
			Player.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673108);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673109);
			Player.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673110);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673111);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673112);
			Player.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673113);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673114);
			Player.NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673115);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673116);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673117);
			Player.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673118);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673119);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673120);
			Player.NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673121);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673122);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673123);
			Player.NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673124);
			Player.NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673125);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673126);
			Player.NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673127);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673128);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673129);
			Player.NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673130);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673131);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673132);
			Player.NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673133);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673134);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673135);
			Player.NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673136);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673137);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673138);
			Player.NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673139);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673140);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673141);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673142);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673143);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673144);
			Player.NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673145);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673146);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673147);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673148);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673149);
			Player.NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673150);
			Player.NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673151);
			Player.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673152);
			Player.NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673153);
			Player.NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673154);
			Player.NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673155);
			Player.NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673156);
			Player.NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673157);
			Player.NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673158);
			Player.NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673159);
			Player.NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673160);
			Player.NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673161);
			Player.NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673162);
			Player.NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673163);
			Player.NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673164);
			Player.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673165);
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x00172DB0 File Offset: 0x00170FB0
		public unsafe bool IsLocalPlayer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 166166, RefRangeEnd = 166179, XrefRangeStart = 166165, XrefRangeEnd = 166166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x00172DEC File Offset: 0x00170FEC
		// (set) Token: 0x06004CC1 RID: 19649 RVA: 0x00172E24 File Offset: 0x00171024
		public unsafe string PlayerName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166179, RefRangeEnd = 166194, XrefRangeStart = 166179, XrefRangeEnd = 166179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 166202, RefRangeEnd = 166204, XrefRangeStart = 166194, XrefRangeEnd = 166202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x00172E68 File Offset: 0x00171068
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x00172EA0 File Offset: 0x001710A0
		public unsafe string PlayerCode
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 166221, RefRangeEnd = 166225, XrefRangeStart = 166213, XrefRangeEnd = 166221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x00172EE4 File Offset: 0x001710E4
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x00172F24 File Offset: 0x00171124
		public unsafe NetworkObject CurrentVehicle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 166225, RefRangeEnd = 166239, XrefRangeStart = 166225, XrefRangeEnd = 166225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 166272, RefRangeEnd = 166275, XrefRangeStart = 166239, XrefRangeEnd = 166272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00172F68 File Offset: 0x00171168
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x00172FA4 File Offset: 0x001711A4
		public unsafe float TimeSinceVehicleExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x00172FE4 File Offset: 0x001711E4
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x00173020 File Offset: 0x00171220
		public unsafe bool Crouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166275, RefRangeEnd = 166276, XrefRangeStart = 166275, XrefRangeEnd = 166275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x00173060 File Offset: 0x00171260
		// (set) Token: 0x06004CCB RID: 19659 RVA: 0x001730A0 File Offset: 0x001712A0
		public unsafe NetworkObject CurrentBed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 166305, RefRangeEnd = 166307, XrefRangeStart = 166276, XrefRangeEnd = 166305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06004CCC RID: 19660 RVA: 0x001730E4 File Offset: 0x001712E4
		// (set) Token: 0x06004CCD RID: 19661 RVA: 0x00173120 File Offset: 0x00171320
		public unsafe bool IsReadyToSleep
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 166307, RefRangeEnd = 166310, XrefRangeStart = 166307, XrefRangeEnd = 166307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 166317, RefRangeEnd = 166319, XrefRangeStart = 166310, XrefRangeEnd = 166317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x00173160 File Offset: 0x00171360
		// (set) Token: 0x06004CCF RID: 19663 RVA: 0x0017319C File Offset: 0x0017139C
		public unsafe bool IsSkating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166348, RefRangeEnd = 166349, XrefRangeStart = 166319, XrefRangeEnd = 166348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x001731DC File Offset: 0x001713DC
		// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x0017321C File Offset: 0x0017141C
		public unsafe Skateboard ActiveSkateboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x00173260 File Offset: 0x00171460
		// (set) Token: 0x06004CD3 RID: 19667 RVA: 0x0017329C File Offset: 0x0017149C
		public unsafe bool IsSleeping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x001732DC File Offset: 0x001714DC
		// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x00173318 File Offset: 0x00171518
		public unsafe bool IsRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x00173358 File Offset: 0x00171558
		// (set) Token: 0x06004CD7 RID: 19671 RVA: 0x00173394 File Offset: 0x00171594
		public unsafe bool IsArrested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x001733D4 File Offset: 0x001715D4
		// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x00173410 File Offset: 0x00171610
		public unsafe bool IsTased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x00173450 File Offset: 0x00171650
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x0017348C File Offset: 0x0017168C
		public unsafe bool IsUnconscious
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x001734CC File Offset: 0x001716CC
		// (set) Token: 0x06004CDD RID: 19677 RVA: 0x00173508 File Offset: 0x00171708
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x00173548 File Offset: 0x00171748
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x00173588 File Offset: 0x00171788
		public unsafe Property CurrentProperty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166349, RefRangeEnd = 166350, XrefRangeStart = 166349, XrefRangeEnd = 166349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166350, XrefRangeEnd = 166351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x001735CC File Offset: 0x001717CC
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x0017360C File Offset: 0x0017180C
		public unsafe Property LastVisitedProperty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 166351, RefRangeEnd = 166355, XrefRangeStart = 166351, XrefRangeEnd = 166351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166355, XrefRangeEnd = 166356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00173650 File Offset: 0x00171850
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x00173690 File Offset: 0x00171890
		public unsafe Business CurrentBusiness
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Business>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166371, XrefRangeEnd = 166372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x001736D4 File Offset: 0x001718D4
		public unsafe Vector3 PlayerBasePosition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 166377, RefRangeEnd = 166379, XrefRangeStart = 166372, XrefRangeEnd = 166377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x00173710 File Offset: 0x00171910
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0017374C File Offset: 0x0017194C
		public unsafe Vector3 CameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166379, XrefRangeEnd = 166380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0017378C File Offset: 0x0017198C
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x001737C8 File Offset: 0x001719C8
		public unsafe Quaternion CameraRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166380, XrefRangeEnd = 166409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x00173808 File Offset: 0x00171A08
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x00173848 File Offset: 0x00171A48
		public unsafe BasicAvatarSettings CurrentAvatarSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166409, XrefRangeEnd = 166410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x0017388C File Offset: 0x00171A8C
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x001738CC File Offset: 0x00171ACC
		public unsafe ProductItemInstance ConsumedProduct
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166410, XrefRangeEnd = 166411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x00173910 File Offset: 0x00171B10
		// (set) Token: 0x06004CEE RID: 19694 RVA: 0x0017394C File Offset: 0x00171B4C
		public unsafe int TimeSinceProductConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x0017398C File Offset: 0x00171B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166411, XrefRangeEnd = 166412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDebugAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x001739C0 File Offset: 0x00171BC0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 166417, RefRangeEnd = 166422, XrefRangeStart = 166412, XrefRangeEnd = 166417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x001739F8 File Offset: 0x00171BF8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166422, XrefRangeEnd = 166424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x00173A30 File Offset: 0x00171C30
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x00173A70 File Offset: 0x00171C70
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x00173AAC File Offset: 0x00171CAC
		// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x00173AEC File Offset: 0x00171CEC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166424, XrefRangeEnd = 166425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x00173B30 File Offset: 0x00171D30
		// (set) Token: 0x06004CF7 RID: 19703 RVA: 0x00173B70 File Offset: 0x00171D70
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166425, XrefRangeEnd = 166426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x00173BB4 File Offset: 0x00171DB4
		// (set) Token: 0x06004CF9 RID: 19705 RVA: 0x00173BF0 File Offset: 0x00171DF0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00173C30 File Offset: 0x00171E30
		// (set) Token: 0x06004CFB RID: 19707 RVA: 0x00173C6C File Offset: 0x00171E6C
		public unsafe bool avatarVisibleToLocalPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x00173CAC File Offset: 0x00171EAC
		// (set) Token: 0x06004CFD RID: 19709 RVA: 0x00173CE8 File Offset: 0x00171EE8
		public unsafe bool playerDataRetrieveReturned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x00173D28 File Offset: 0x00171F28
		// (set) Token: 0x06004CFF RID: 19711 RVA: 0x00173D64 File Offset: 0x00171F64
		public unsafe bool playerSaveRequestReturned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x00173DA4 File Offset: 0x00171FA4
		// (set) Token: 0x06004D01 RID: 19713 RVA: 0x00173DE0 File Offset: 0x00171FE0
		public unsafe bool PlayerInitializedOverNetwork
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x00173E20 File Offset: 0x00172020
		// (set) Token: 0x06004D03 RID: 19715 RVA: 0x00173E5C File Offset: 0x0017205C
		public unsafe bool Paranoid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x00173E9C File Offset: 0x0017209C
		// (set) Token: 0x06004D05 RID: 19717 RVA: 0x00173ED8 File Offset: 0x001720D8
		public unsafe bool Sneaky
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x00173F18 File Offset: 0x00172118
		// (set) Token: 0x06004D07 RID: 19719 RVA: 0x00173F54 File Offset: 0x00172154
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00173F94 File Offset: 0x00172194
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x00173FD0 File Offset: 0x001721D0
		public unsafe bool Seizure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00174010 File Offset: 0x00172210
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x0017404C File Offset: 0x0017224C
		public unsafe bool Slippery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06004D0C RID: 19724 RVA: 0x0017408C File Offset: 0x0017228C
		// (set) Token: 0x06004D0D RID: 19725 RVA: 0x001740C8 File Offset: 0x001722C8
		public unsafe bool Schizophrenic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00174108 File Offset: 0x00172308
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 166443, RefRangeEnd = 166452, XrefRangeStart = 166426, XrefRangeEnd = 166443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetPlayer(NetworkConnection conn)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x0017414C File Offset: 0x0017234C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166490, RefRangeEnd = 166492, XrefRangeStart = 166452, XrefRangeEnd = 166490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeArrestedOrDead;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeSleeping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x0017419C File Offset: 0x0017239C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166511, RefRangeEnd = 166512, XrefRangeStart = 166492, XrefRangeEnd = 166511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetPlayer(string playerCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x001741E0 File Offset: 0x001723E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166512, XrefRangeEnd = 166513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x0017421C File Offset: 0x0017241C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166513, XrefRangeEnd = 166519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x00174258 File Offset: 0x00172458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166519, XrefRangeEnd = 166554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00174294 File Offset: 0x00172494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166554, XrefRangeEnd = 166590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x001742D0 File Offset: 0x001724D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166590, XrefRangeEnd = 166762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x0017430C File Offset: 0x0017250C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166866, RefRangeEnd = 166868, XrefRangeStart = 166762, XrefRangeEnd = 166866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayerLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00174340 File Offset: 0x00172540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166868, XrefRangeEnd = 166891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x00174390 File Offset: 0x00172590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166912, RefRangeEnd = 166914, XrefRangeStart = 166891, XrefRangeEnd = 166912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSavePlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x001743C4 File Offset: 0x001725C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166945, RefRangeEnd = 166946, XrefRangeStart = 166914, XrefRangeEnd = 166945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnSaveRequest(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successful;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x00174414 File Offset: 0x00172614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166967, RefRangeEnd = 166968, XrefRangeStart = 166946, XrefRangeEnd = 166967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HostExitedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_HostExitedGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00174448 File Offset: 0x00172648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166968, XrefRangeEnd = 166998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClientConnectionStateChanged(ClientConnectionStateArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00174488 File Offset: 0x00172688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166998, XrefRangeEnd = 167000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerNameData(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x001744D8 File Offset: 0x001726D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167000, XrefRangeEnd = 167019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestPlayerData(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x0017451C File Offset: 0x0017271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167019, XrefRangeEnd = 167051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00174550 File Offset: 0x00172750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167101, RefRangeEnd = 167103, XrefRangeStart = 167051, XrefRangeEnd = 167101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x001745F0 File Offset: 0x001727F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167134, RefRangeEnd = 167137, XrefRangeStart = 167103, XrefRangeEnd = 167134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00174630 File Offset: 0x00172830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167181, RefRangeEnd = 167183, XrefRangeStart = 167137, XrefRangeEnd = 167181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00174698 File Offset: 0x00172898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167205, RefRangeEnd = 167207, XrefRangeStart = 167183, XrefRangeEnd = 167205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlashlightOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001746D8 File Offset: 0x001728D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167205, RefRangeEnd = 167207, XrefRangeStart = 167205, XrefRangeEnd = 167207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlashlightOnNetworked(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00174718 File Offset: 0x00172918
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167231, RefRangeEnd = 167234, XrefRangeStart = 167207, XrefRangeEnd = 167231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00174758 File Offset: 0x00172958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167234, XrefRangeEnd = 167243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00174794 File Offset: 0x00172994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167243, XrefRangeEnd = 167253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x001747D0 File Offset: 0x001729D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167253, XrefRangeEnd = 167305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x0017480C File Offset: 0x00172A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167305, XrefRangeEnd = 167309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x00174848 File Offset: 0x00172A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167309, XrefRangeEnd = 167382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00174884 File Offset: 0x00172A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167382, XrefRangeEnd = 167431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCurrentProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001748B8 File Offset: 0x00172AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167431, XrefRangeEnd = 167432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x001748EC File Offset: 0x00172AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167490, RefRangeEnd = 167491, XrefRangeStart = 167432, XrefRangeEnd = 167490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMovementVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00174920 File Offset: 0x00172B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167503, RefRangeEnd = 167505, XrefRangeStart = 167491, XrefRangeEnd = 167503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0017496C File Offset: 0x00172B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167523, RefRangeEnd = 167524, XrefRangeStart = 167505, XrefRangeEnd = 167523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayJumpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001749A0 File Offset: 0x00172BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167543, RefRangeEnd = 167545, XrefRangeStart = 167524, XrefRangeEnd = 167543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x001749DC File Offset: 0x00172BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167567, RefRangeEnd = 167568, XrefRangeStart = 167545, XrefRangeEnd = 167567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00174A1C File Offset: 0x00172C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166275, RefRangeEnd = 166276, XrefRangeStart = 166275, XrefRangeEnd = 166276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouchedLocal(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00174A5C File Offset: 0x00172C5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167578, RefRangeEnd = 167582, XrefRangeStart = 167568, XrefRangeEnd = 167578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCrouched(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00174AAC File Offset: 0x00172CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167582, XrefRangeEnd = 167615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00174AF0 File Offset: 0x00172CF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167637, RefRangeEnd = 167640, XrefRangeStart = 167615, XrefRangeEnd = 167637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x00174B34 File Offset: 0x00172D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167640, XrefRangeEnd = 167659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible_Networked(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00174B74 File Offset: 0x00172D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167674, RefRangeEnd = 167675, XrefRangeStart = 167659, XrefRangeEnd = 167674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00174BB8 File Offset: 0x00172DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167716, RefRangeEnd = 167717, XrefRangeStart = 167675, XrefRangeEnd = 167716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00174BFC File Offset: 0x00172DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167717, XrefRangeEnd = 167742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreDestroyClientObjects(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x00174C40 File Offset: 0x00172E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167742, XrefRangeEnd = 167763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldVeh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newVeh);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00174CA4 File Offset: 0x00172EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167786, RefRangeEnd = 167787, XrefRangeStart = 167763, XrefRangeEnd = 167786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAllPlayersReadyToSleep()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00174CD4 File Offset: 0x00172ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167787, XrefRangeEnd = 167788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00174D08 File Offset: 0x00172F08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167810, RefRangeEnd = 167813, XrefRangeStart = 167788, XrefRangeEnd = 167810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReadyToSleep(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00174D48 File Offset: 0x00172F48
		[CallerCount(0)]
		public unsafe void SleepEnd(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSlept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00174D88 File Offset: 0x00172F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167837, RefRangeEnd = 167838, XrefRangeStart = 167813, XrefRangeEnd = 167837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Activate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Activate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00174DB0 File Offset: 0x00172FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167860, RefRangeEnd = 167862, XrefRangeStart = 167838, XrefRangeEnd = 167860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deactivate(bool freeMouse)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref freeMouse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x00174DE4 File Offset: 0x00172FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167901, RefRangeEnd = 167904, XrefRangeStart = 167862, XrefRangeEnd = 167901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00174E18 File Offset: 0x00173018
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167914, RefRangeEnd = 167918, XrefRangeStart = 167904, XrefRangeEnd = 167914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibleToLocalPlayer(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00174E58 File Offset: 0x00173058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167918, XrefRangeEnd = 167940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCode(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00174E9C File Offset: 0x0017309C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167968, RefRangeEnd = 167969, XrefRangeStart = 167940, XrefRangeEnd = 167968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPunch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPunch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00174ED0 File Offset: 0x001730D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167969, XrefRangeEnd = 167987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Punch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00174F04 File Offset: 0x00173104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167987, XrefRangeEnd = 168020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkIntroCompleted(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00174F48 File Offset: 0x00173148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168047, RefRangeEnd = 168049, XrefRangeStart = 168020, XrefRangeEnd = 168047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance_Visible;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance_Invisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00174FB0 File Offset: 0x001731B0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 168088, RefRangeEnd = 168106, XrefRangeStart = 168049, XrefRangeEnd = 168088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetClosestPlayer(Vector3 point, out float distance, List<Player> exclude = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exclude);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00175010 File Offset: 0x00173210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168109, RefRangeEnd = 168110, XrefRangeStart = 168106, XrefRangeEnd = 168109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapsuleColliderHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00175050 File Offset: 0x00173250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168110, RefRangeEnd = 168111, XrefRangeStart = 168110, XrefRangeEnd = 168110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00175090 File Offset: 0x00173290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168125, RefRangeEnd = 168127, XrefRangeStart = 168111, XrefRangeEnd = 168125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x001750DC File Offset: 0x001732DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168127, XrefRangeEnd = 168133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x00175118 File Offset: 0x00173318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168133, XrefRangeEnd = 168142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x0017515C File Offset: 0x0017335C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168150, RefRangeEnd = 168152, XrefRangeStart = 168142, XrefRangeEnd = 168150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr3) : null;
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x0017519C File Offset: 0x0017339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168152, XrefRangeEnd = 168229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x001751F8 File Offset: 0x001733F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168229, XrefRangeEnd = 168238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInventoryString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetInventoryString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x00175230 File Offset: 0x00173430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168238, XrefRangeEnd = 168244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAppearanceString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetAppearanceString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00175268 File Offset: 0x00173468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168253, RefRangeEnd = 168255, XrefRangeStart = 168244, XrefRangeEnd = 168253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClothingString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetClothingString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x001752A0 File Offset: 0x001734A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168255, XrefRangeEnd = 168310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PlayerData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x00175300 File Offset: 0x00173500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168310, XrefRangeEnd = 168319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PlayerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00175350 File Offset: 0x00173550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168319, XrefRangeEnd = 168348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadInventory(string contentsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x001753A0 File Offset: 0x001735A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168348, XrefRangeEnd = 168360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadAppearance(string appearanceString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x001753F0 File Offset: 0x001735F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168360, XrefRangeEnd = 168380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadClothing(string contentsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x00175440 File Offset: 0x00173640
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 168395, RefRangeEnd = 168399, XrefRangeStart = 168380, XrefRangeEnd = 168395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdolled(bool ragdolled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ragdolled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00175480 File Offset: 0x00173680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168399, XrefRangeEnd = 168420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x001754D0 File Offset: 0x001736D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168420, XrefRangeEnd = 168442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00175520 File Offset: 0x00173720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168442, XrefRangeEnd = 168443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00175588 File Offset: 0x00173788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168443, XrefRangeEnd = 168496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x001755C4 File Offset: 0x001737C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168496, XrefRangeEnd = 168514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRevived()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00175600 File Offset: 0x00173800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168535, RefRangeEnd = 168537, XrefRangeStart = 168514, XrefRangeEnd = 168535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Arrest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Arrest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00175634 File Offset: 0x00173834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168593, RefRangeEnd = 168595, XrefRangeStart = 168537, XrefRangeEnd = 168593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00175668 File Offset: 0x00173868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168595, XrefRangeEnd = 168627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPassOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x0017569C File Offset: 0x0017389C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168648, RefRangeEnd = 168650, XrefRangeStart = 168627, XrefRangeEnd = 168648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x001756D0 File Offset: 0x001738D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168682, RefRangeEnd = 168683, XrefRangeStart = 168650, XrefRangeEnd = 168682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPassOutRecovery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00175704 File Offset: 0x00173904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168704, RefRangeEnd = 168706, XrefRangeStart = 168683, XrefRangeEnd = 168704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassOutRecovery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00175738 File Offset: 0x00173938
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 168728, RefRangeEnd = 168734, XrefRangeStart = 168706, XrefRangeEnd = 168728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippable_Networked(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x0017577C File Offset: 0x0017397C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168755, RefRangeEnd = 168757, XrefRangeStart = 168734, XrefRangeEnd = 168755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable_Networked(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x001757C0 File Offset: 0x001739C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168759, RefRangeEnd = 168760, XrefRangeStart = 168757, XrefRangeEnd = 168759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00175810 File Offset: 0x00173A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168784, RefRangeEnd = 168786, XrefRangeStart = 168760, XrefRangeEnd = 168784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00175860 File Offset: 0x00173A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168788, RefRangeEnd = 168789, XrefRangeStart = 168786, XrefRangeEnd = 168788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x001758C0 File Offset: 0x00173AC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168815, RefRangeEnd = 168818, XrefRangeStart = 168789, XrefRangeEnd = 168815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00175920 File Offset: 0x00173B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168851, RefRangeEnd = 168854, XrefRangeStart = 168818, XrefRangeEnd = 168851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00175964 File Offset: 0x00173B64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168864, RefRangeEnd = 168867, XrefRangeStart = 168854, XrefRangeEnd = 168864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001759B8 File Offset: 0x00173BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168867, XrefRangeEnd = 168869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x001759FC File Offset: 0x00173BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168869, XrefRangeEnd = 168879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00175A50 File Offset: 0x00173C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168879, XrefRangeEnd = 168881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00175A94 File Offset: 0x00173C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168883, RefRangeEnd = 168886, XrefRangeStart = 168881, XrefRangeEnd = 168883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAnimationBool(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00175AE4 File Offset: 0x00173CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168909, RefRangeEnd = 168911, XrefRangeStart = 168886, XrefRangeEnd = 168909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationBool(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00175B34 File Offset: 0x00173D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168929, RefRangeEnd = 168930, XrefRangeStart = 168911, XrefRangeEnd = 168929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Taze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Taze_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00175B68 File Offset: 0x00173D68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 168933, RefRangeEnd = 168937, XrefRangeStart = 168930, XrefRangeEnd = 168933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryItem(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00175BB8 File Offset: 0x00173DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168937, XrefRangeEnd = 168939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00175BFC File Offset: 0x00173DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168972, RefRangeEnd = 168973, XrefRangeStart = 168939, XrefRangeEnd = 168972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAppearance(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00175C40 File Offset: 0x00173E40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 168996, RefRangeEnd = 169003, XrefRangeStart = 168973, XrefRangeEnd = 168996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refreshClothing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00175C90 File Offset: 0x00173E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169078, RefRangeEnd = 169079, XrefRangeStart = 169003, XrefRangeEnd = 169078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MountSkateboard(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00175CD4 File Offset: 0x00173ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169112, RefRangeEnd = 169114, XrefRangeStart = 169079, XrefRangeEnd = 169112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMountedSkateboard(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00175D18 File Offset: 0x00173F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169136, RefRangeEnd = 169138, XrefRangeStart = 169114, XrefRangeEnd = 169136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMountedSkateboard(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00175D5C File Offset: 0x00173F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169183, RefRangeEnd = 169184, XrefRangeStart = 169138, XrefRangeEnd = 169183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DismountSkateboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DismountSkateboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00175D90 File Offset: 0x00173F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169207, RefRangeEnd = 169209, XrefRangeStart = 169184, XrefRangeEnd = 169207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x00175DD4 File Offset: 0x00173FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169209, XrefRangeEnd = 169228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00175E18 File Offset: 0x00174018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169228, XrefRangeEnd = 169247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00175E5C File Offset: 0x0017405C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169247, XrefRangeEnd = 169250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProductInternal(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00175EA0 File Offset: 0x001740A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169251, RefRangeEnd = 169252, XrefRangeStart = 169250, XrefRangeEnd = 169251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ClearProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00175ED4 File Offset: 0x001740D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169298, RefRangeEnd = 169299, XrefRangeStart = 169252, XrefRangeEnd = 169298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePlayerVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00175F08 File Offset: 0x00174108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169299, XrefRangeEnd = 169311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable GetVariable(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVariable>(intPtr3) : null;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00175F58 File Offset: 0x00174158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169311, XrefRangeEnd = 169326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00175FA4 File Offset: 0x001741A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169338, RefRangeEnd = 169339, XrefRangeStart = 169326, XrefRangeEnd = 169338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVariableValue(string variableName, string value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x00176008 File Offset: 0x00174208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169363, RefRangeEnd = 169364, XrefRangeStart = 169339, XrefRangeEnd = 169363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVariable(BaseVariable variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x0017604C File Offset: 0x0017424C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169388, RefRangeEnd = 169389, XrefRangeStart = 169364, XrefRangeEnd = 169388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValue(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendToOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x001760B0 File Offset: 0x001742B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169389, XrefRangeEnd = 169400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00176118 File Offset: 0x00174318
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169415, RefRangeEnd = 169418, XrefRangeStart = 169400, XrefRangeEnd = 169415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveValue(string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x0017616C File Offset: 0x0017436C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169440, RefRangeEnd = 169442, XrefRangeStart = 169418, XrefRangeEnd = 169440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVariable(VariableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x001761B0 File Offset: 0x001743B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169442, XrefRangeEnd = 169551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x001761EC File Offset: 0x001743EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169551, XrefRangeEnd = 169557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RecalculateCurrentProperty_b__248_0(Property x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x0017623C File Offset: 0x0017443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RecalculateCurrentProperty_b__248_1(Business x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x0017628C File Offset: 0x0017448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169557, XrefRangeEnd = 169562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x001762CC File Offset: 0x001744CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169562, XrefRangeEnd = 169999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00176308 File Offset: 0x00174508
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00176344 File Offset: 0x00174544
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00176380 File Offset: 0x00174580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169999, XrefRangeEnd = 170028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x001763C4 File Offset: 0x001745C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170036, RefRangeEnd = 170038, XrefRangeStart = 170028, XrefRangeEnd = 170036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00176408 File Offset: 0x00174608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170038, XrefRangeEnd = 170043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x0017646C File Offset: 0x0017466C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166305, RefRangeEnd = 166307, XrefRangeStart = 166305, XrefRangeEnd = 166307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x001764B0 File Offset: 0x001746B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170043, XrefRangeEnd = 170051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x001764F4 File Offset: 0x001746F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170051, XrefRangeEnd = 170062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00176558 File Offset: 0x00174758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166348, RefRangeEnd = 166349, XrefRangeStart = 166348, XrefRangeEnd = 166349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00176598 File Offset: 0x00174798
		[CallerCount(0)]
		public unsafe void RpcLogic___set_IsSkating_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x001765D8 File Offset: 0x001747D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170062, XrefRangeEnd = 170064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x0017663C File Offset: 0x0017483C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170095, RefRangeEnd = 170097, XrefRangeStart = 170064, XrefRangeEnd = 170095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x0017667C File Offset: 0x0017487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170097, XrefRangeEnd = 170104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x001766BC File Offset: 0x001748BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170104, XrefRangeEnd = 170116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00176720 File Offset: 0x00174920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00176760 File Offset: 0x00174960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170116, XrefRangeEnd = 170123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x001767A0 File Offset: 0x001749A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170123, XrefRangeEnd = 170134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00176804 File Offset: 0x00174A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170134, XrefRangeEnd = 170152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00176838 File Offset: 0x00174A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170166, RefRangeEnd = 170168, XrefRangeStart = 170152, XrefRangeEnd = 170166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSavePlayer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x0017686C File Offset: 0x00174A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170168, XrefRangeEnd = 170171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001768D0 File Offset: 0x00174AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170171, XrefRangeEnd = 170190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successful;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00176920 File Offset: 0x00174B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170201, RefRangeEnd = 170203, XrefRangeStart = 170190, XrefRangeEnd = 170201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successful;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00176970 File Offset: 0x00174B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170203, XrefRangeEnd = 170205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x001769C0 File Offset: 0x00174BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170205, XrefRangeEnd = 170224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successful;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00176A10 File Offset: 0x00174C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170224, XrefRangeEnd = 170227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00176A60 File Offset: 0x00174C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170227, XrefRangeEnd = 170245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_HostExitedGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00176A94 File Offset: 0x00174C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170271, RefRangeEnd = 170274, XrefRangeStart = 170245, XrefRangeEnd = 170271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___HostExitedGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00176AC8 File Offset: 0x00174CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170274, XrefRangeEnd = 170277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00176B18 File Offset: 0x00174D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170308, RefRangeEnd = 170310, XrefRangeStart = 170277, XrefRangeEnd = 170308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00176B68 File Offset: 0x00174D68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170329, RefRangeEnd = 170332, XrefRangeStart = 170310, XrefRangeEnd = 170329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00176BB8 File Offset: 0x00174DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170332, XrefRangeEnd = 170338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00176C1C File Offset: 0x00174E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00176C60 File Offset: 0x00174E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170364, RefRangeEnd = 170365, XrefRangeStart = 170338, XrefRangeEnd = 170364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00176CA4 File Offset: 0x00174EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170365, XrefRangeEnd = 170368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00176D08 File Offset: 0x00174F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170368, XrefRangeEnd = 170396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkPlayerInitialized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00176D3C File Offset: 0x00174F3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170403, RefRangeEnd = 170406, XrefRangeStart = 170396, XrefRangeEnd = 170403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkPlayerInitialized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00176D70 File Offset: 0x00174F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170406, XrefRangeEnd = 170410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkPlayerInitialized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00176DD4 File Offset: 0x00174FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170410, XrefRangeEnd = 170433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00176E74 File Offset: 0x00175074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170448, RefRangeEnd = 170451, XrefRangeStart = 170433, XrefRangeEnd = 170448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00176F14 File Offset: 0x00175114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170451, XrefRangeEnd = 170459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00176F64 File Offset: 0x00175164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170459, XrefRangeEnd = 170473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00177004 File Offset: 0x00175204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170473, XrefRangeEnd = 170481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00177054 File Offset: 0x00175254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170481, XrefRangeEnd = 170501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x001770BC File Offset: 0x001752BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170513, RefRangeEnd = 170516, XrefRangeStart = 170501, XrefRangeEnd = 170513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00177124 File Offset: 0x00175324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170516, XrefRangeEnd = 170521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00177174 File Offset: 0x00175374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170521, XrefRangeEnd = 170532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x001771DC File Offset: 0x001753DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170532, XrefRangeEnd = 170537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x0017722C File Offset: 0x0017542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170537, XrefRangeEnd = 170556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x0017726C File Offset: 0x0017546C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167231, RefRangeEnd = 167234, XrefRangeStart = 167231, XrefRangeEnd = 167234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x001772AC File Offset: 0x001754AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170556, XrefRangeEnd = 170559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlashlightOnNetworked_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00177310 File Offset: 0x00175510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170559, XrefRangeEnd = 170578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00177350 File Offset: 0x00175550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170583, RefRangeEnd = 170584, XrefRangeStart = 170578, XrefRangeEnd = 170583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetFlashlightOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00177390 File Offset: 0x00175590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170584, XrefRangeEnd = 170587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetFlashlightOn_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x001773E0 File Offset: 0x001755E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167523, RefRangeEnd = 167524, XrefRangeStart = 167523, XrefRangeEnd = 167524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x00177414 File Offset: 0x00175614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170587, XrefRangeEnd = 170589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayJumpAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00177448 File Offset: 0x00175648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170589, XrefRangeEnd = 170591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x00177498 File Offset: 0x00175698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170591, XrefRangeEnd = 170610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x001774D8 File Offset: 0x001756D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170610, XrefRangeEnd = 170611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x00177518 File Offset: 0x00175718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170611, XrefRangeEnd = 170614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x0017757C File Offset: 0x0017577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170614, XrefRangeEnd = 170633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x001775CC File Offset: 0x001757CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170633, XrefRangeEnd = 170635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x0017761C File Offset: 0x0017581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170635, XrefRangeEnd = 170639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x0017766C File Offset: 0x0017586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170639, XrefRangeEnd = 170658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x001776BC File Offset: 0x001758BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170658, XrefRangeEnd = 170662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x0017770C File Offset: 0x0017590C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170662, XrefRangeEnd = 170691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00177750 File Offset: 0x00175950
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167637, RefRangeEnd = 167640, XrefRangeStart = 167637, XrefRangeEnd = 167640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x00177794 File Offset: 0x00175994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170691, XrefRangeEnd = 170696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x001777F8 File Offset: 0x001759F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170696, XrefRangeEnd = 170715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x0017783C File Offset: 0x00175A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170722, RefRangeEnd = 170725, XrefRangeStart = 170715, XrefRangeEnd = 170722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00177880 File Offset: 0x00175A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170725, XrefRangeEnd = 170729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x001778D0 File Offset: 0x00175AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00177910 File Offset: 0x00175B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170729, XrefRangeEnd = 170732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00177950 File Offset: 0x00175B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170732, XrefRangeEnd = 170735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x001779A0 File Offset: 0x00175BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170735, XrefRangeEnd = 170754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x001779E0 File Offset: 0x00175BE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166317, RefRangeEnd = 166319, XrefRangeStart = 166317, XrefRangeEnd = 166319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00177A20 File Offset: 0x00175C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170754, XrefRangeEnd = 170757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x00177A84 File Offset: 0x00175C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170757, XrefRangeEnd = 170776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x00177AC8 File Offset: 0x00175CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170776, XrefRangeEnd = 170777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerCode_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x00177B0C File Offset: 0x00175D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170777, XrefRangeEnd = 170781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerCode_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x00177B5C File Offset: 0x00175D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167968, RefRangeEnd = 167969, XrefRangeStart = 167968, XrefRangeEnd = 167969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPunch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x00177B90 File Offset: 0x00175D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPunch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x00177BC4 File Offset: 0x00175DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170781, XrefRangeEnd = 170800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x00177C28 File Offset: 0x00175E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Punch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x00177C5C File Offset: 0x00175E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170800, XrefRangeEnd = 170804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Punch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x00177C90 File Offset: 0x00175E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170804, XrefRangeEnd = 170809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00177CE0 File Offset: 0x00175EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170809, XrefRangeEnd = 170838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00177D24 File Offset: 0x00175F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170846, RefRangeEnd = 170848, XrefRangeStart = 170838, XrefRangeEnd = 170846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x00177D68 File Offset: 0x00175F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170848, XrefRangeEnd = 170853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00177DCC File Offset: 0x00175FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170853, XrefRangeEnd = 170872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x00177E10 File Offset: 0x00176010
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00177E60 File Offset: 0x00176060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170872, XrefRangeEnd = 170875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00177EC4 File Offset: 0x001760C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170875, XrefRangeEnd = 170894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00177F08 File Offset: 0x00176108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170909, RefRangeEnd = 170911, XrefRangeStart = 170894, XrefRangeEnd = 170909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00177F58 File Offset: 0x00176158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170911, XrefRangeEnd = 170915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00177FA8 File Offset: 0x001761A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170915, XrefRangeEnd = 170933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Arrest_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00177FDC File Offset: 0x001761DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170958, RefRangeEnd = 170960, XrefRangeStart = 170933, XrefRangeEnd = 170958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Arrest_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00178010 File Offset: 0x00176210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170960, XrefRangeEnd = 170963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Arrest_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00178060 File Offset: 0x00176260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170963, XrefRangeEnd = 170991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00178094 File Offset: 0x00176294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168648, RefRangeEnd = 168650, XrefRangeStart = 168648, XrefRangeEnd = 168650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x001780C8 File Offset: 0x001762C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170991, XrefRangeEnd = 170995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x0017812C File Offset: 0x0017632C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170995, XrefRangeEnd = 171013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00178160 File Offset: 0x00176360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171036, RefRangeEnd = 171039, XrefRangeStart = 171013, XrefRangeEnd = 171036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00178194 File Offset: 0x00176394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171039, XrefRangeEnd = 171042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x001781E4 File Offset: 0x001763E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171042, XrefRangeEnd = 171070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00178218 File Offset: 0x00176418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168704, RefRangeEnd = 168706, XrefRangeStart = 168704, XrefRangeEnd = 168706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x0017824C File Offset: 0x0017644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171070, XrefRangeEnd = 171074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x001782B0 File Offset: 0x001764B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171074, XrefRangeEnd = 171092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x001782E4 File Offset: 0x001764E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171115, RefRangeEnd = 171118, XrefRangeStart = 171092, XrefRangeEnd = 171115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00178318 File Offset: 0x00176518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171118, XrefRangeEnd = 171121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00178368 File Offset: 0x00176568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171121, XrefRangeEnd = 171140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x001783AC File Offset: 0x001765AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168755, RefRangeEnd = 168757, XrefRangeStart = 168755, XrefRangeEnd = 168757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x001783F0 File Offset: 0x001765F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171140, XrefRangeEnd = 171144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00178454 File Offset: 0x00176654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171144, XrefRangeEnd = 171163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00178498 File Offset: 0x00176698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171163, XrefRangeEnd = 171164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x001784DC File Offset: 0x001766DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171164, XrefRangeEnd = 171167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x0017852C File Offset: 0x0017672C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171198, RefRangeEnd = 171199, XrefRangeStart = 171167, XrefRangeEnd = 171198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x0017857C File Offset: 0x0017677C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168784, RefRangeEnd = 168786, XrefRangeStart = 168784, XrefRangeEnd = 168786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x001785CC File Offset: 0x001767CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171199, XrefRangeEnd = 171206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x00178630 File Offset: 0x00176830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171206, XrefRangeEnd = 171227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x00178680 File Offset: 0x00176880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171234, RefRangeEnd = 171237, XrefRangeStart = 171227, XrefRangeEnd = 171234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x001786D0 File Offset: 0x001768D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171237, XrefRangeEnd = 171243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x00178720 File Offset: 0x00176920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171260, RefRangeEnd = 171261, XrefRangeStart = 171243, XrefRangeEnd = 171260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x00178780 File Offset: 0x00176980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171261, XrefRangeEnd = 171262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x001787E0 File Offset: 0x001769E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171262, XrefRangeEnd = 171272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00178844 File Offset: 0x00176A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171272, XrefRangeEnd = 171287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x001788A4 File Offset: 0x00176AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171297, RefRangeEnd = 171299, XrefRangeStart = 171287, XrefRangeEnd = 171297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receipt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x00178904 File Offset: 0x00176B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171299, XrefRangeEnd = 171308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00178954 File Offset: 0x00176B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171308, XrefRangeEnd = 171337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x00178998 File Offset: 0x00176B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171337, XrefRangeEnd = 171338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x001789DC File Offset: 0x00176BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171338, XrefRangeEnd = 171343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x00178A40 File Offset: 0x00176C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171343, XrefRangeEnd = 171362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x00178A94 File Offset: 0x00176C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171362, XrefRangeEnd = 171364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x00178AE8 File Offset: 0x00176CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171364, XrefRangeEnd = 171368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x00178B38 File Offset: 0x00176D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171368, XrefRangeEnd = 171387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x00178B8C File Offset: 0x00176D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171387, XrefRangeEnd = 171391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00178BDC File Offset: 0x00176DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171391, XrefRangeEnd = 171410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00178C30 File Offset: 0x00176E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171410, XrefRangeEnd = 171412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00178C84 File Offset: 0x00176E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171412, XrefRangeEnd = 171416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00178CD4 File Offset: 0x00176ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171416, XrefRangeEnd = 171435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00178D28 File Offset: 0x00176F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171435, XrefRangeEnd = 171439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00178D78 File Offset: 0x00176F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171469, RefRangeEnd = 171470, XrefRangeStart = 171439, XrefRangeEnd = 171469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00178DC8 File Offset: 0x00176FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168909, RefRangeEnd = 168911, XrefRangeStart = 168909, XrefRangeEnd = 168911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00178E18 File Offset: 0x00177018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171470, XrefRangeEnd = 171475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00178E7C File Offset: 0x0017707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171475, XrefRangeEnd = 171495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00178ECC File Offset: 0x001770CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171495, XrefRangeEnd = 171497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00178F1C File Offset: 0x0017711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171497, XrefRangeEnd = 171501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00178F6C File Offset: 0x0017716C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168929, RefRangeEnd = 168930, XrefRangeStart = 168929, XrefRangeEnd = 168930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Taze_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x00178FA0 File Offset: 0x001771A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171501, XrefRangeEnd = 171511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Taze_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00178FD4 File Offset: 0x001771D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171511, XrefRangeEnd = 171521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00179024 File Offset: 0x00177224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171552, RefRangeEnd = 171553, XrefRangeStart = 171521, XrefRangeEnd = 171552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00179074 File Offset: 0x00177274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171553, XrefRangeEnd = 171555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x001790C4 File Offset: 0x001772C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171555, XrefRangeEnd = 171561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00179128 File Offset: 0x00177328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171561, XrefRangeEnd = 171590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x0017916C File Offset: 0x0017736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171590, XrefRangeEnd = 171591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x001791B0 File Offset: 0x001773B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171591, XrefRangeEnd = 171596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00179214 File Offset: 0x00177414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171596, XrefRangeEnd = 171616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refreshClothing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x00179264 File Offset: 0x00177464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171622, RefRangeEnd = 171624, XrefRangeStart = 171616, XrefRangeEnd = 171622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refreshClothing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x001792B4 File Offset: 0x001774B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171624, XrefRangeEnd = 171628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00179304 File Offset: 0x00177504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171628, XrefRangeEnd = 171657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00179348 File Offset: 0x00177548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169136, RefRangeEnd = 169138, XrefRangeStart = 169136, XrefRangeEnd = 169138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x0017938C File Offset: 0x0017758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171657, XrefRangeEnd = 171662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x001793F0 File Offset: 0x001775F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171662, XrefRangeEnd = 171681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00179434 File Offset: 0x00177634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171704, RefRangeEnd = 171707, XrefRangeStart = 171681, XrefRangeEnd = 171704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00179478 File Offset: 0x00177678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171707, XrefRangeEnd = 171711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x001794C8 File Offset: 0x001776C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0017950C File Offset: 0x0017770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00179550 File Offset: 0x00177750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171711, XrefRangeEnd = 171723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x001795B4 File Offset: 0x001777B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x001795F8 File Offset: 0x001777F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171723, XrefRangeEnd = 171726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0017963C File Offset: 0x0017783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171726, XrefRangeEnd = 171731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x0017968C File Offset: 0x0017788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171731, XrefRangeEnd = 171743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendToOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x001796F0 File Offset: 0x001778F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171767, RefRangeEnd = 171769, XrefRangeStart = 171743, XrefRangeEnd = 171767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendToOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x00179754 File Offset: 0x00177954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171769, XrefRangeEnd = 171774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x001797B8 File Offset: 0x001779B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00179820 File Offset: 0x00177A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171774, XrefRangeEnd = 171775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00179888 File Offset: 0x00177A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171775, XrefRangeEnd = 171780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x001798D8 File Offset: 0x00177AD8
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x00179910 File Offset: 0x00177B10
		public unsafe string SyncAccessor_<PlayerName>k__BackingField
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166179, RefRangeEnd = 166194, XrefRangeStart = 166179, XrefRangeEnd = 166194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171789, RefRangeEnd = 171790, XrefRangeStart = 171780, XrefRangeEnd = 171789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00179960 File Offset: 0x00177B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171790, XrefRangeEnd = 171798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_PlayerScripts_Player(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004E3F RID: 20031 RVA: 0x001799D4 File Offset: 0x00177BD4
		// (set) Token: 0x06004E40 RID: 20032 RVA: 0x00179A0C File Offset: 0x00177C0C
		public unsafe string SyncAccessor_<PlayerCode>k__BackingField
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171798, XrefRangeEnd = 171807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004E41 RID: 20033 RVA: 0x00179A5C File Offset: 0x00177C5C
		// (set) Token: 0x06004E42 RID: 20034 RVA: 0x00179A9C File Offset: 0x00177C9C
		public unsafe NetworkObject SyncAccessor_<CurrentVehicle>k__BackingField
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 166225, RefRangeEnd = 166239, XrefRangeStart = 166225, XrefRangeEnd = 166239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171807, XrefRangeEnd = 171816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x00179AEC File Offset: 0x00177CEC
		// (set) Token: 0x06004E44 RID: 20036 RVA: 0x00179B2C File Offset: 0x00177D2C
		public unsafe NetworkObject SyncAccessor_<CurrentBed>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171816, XrefRangeEnd = 171825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x00179B7C File Offset: 0x00177D7C
		// (set) Token: 0x06004E46 RID: 20038 RVA: 0x00179BB8 File Offset: 0x00177DB8
		public unsafe bool SyncAccessor_<IsReadyToSleep>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 166307, RefRangeEnd = 166310, XrefRangeStart = 166307, XrefRangeEnd = 166310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171825, XrefRangeEnd = 171833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x00179C04 File Offset: 0x00177E04
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x00179C40 File Offset: 0x00177E40
		public unsafe Vector3 SyncAccessor_<CameraPosition>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171833, XrefRangeEnd = 171841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x00179C8C File Offset: 0x00177E8C
		// (set) Token: 0x06004E4A RID: 20042 RVA: 0x00179CC8 File Offset: 0x00177EC8
		public unsafe Quaternion SyncAccessor_<CameraRotation>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171841, XrefRangeEnd = 171849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00179D14 File Offset: 0x00177F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171950, RefRangeEnd = 171951, XrefRangeStart = 171849, XrefRangeEnd = 171950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00024E94 File Offset: 0x00023094
		public Player(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004E4D RID: 20045 RVA: 0x00179D50 File Offset: 0x00177F50
		// (set) Token: 0x06004E4E RID: 20046 RVA: 0x00024E9D File Offset: 0x0002309D
		public unsafe static string OWNER_PLAYER_CODE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x00179D70 File Offset: 0x00177F70
		// (set) Token: 0x06004E50 RID: 20048 RVA: 0x00024EAF File Offset: 0x000230AF
		public unsafe static float CapColDefaultHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_CapColDefaultHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_CapColDefaultHeight, (void*)(&value));
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x00179D8C File Offset: 0x00177F8C
		// (set) Token: 0x06004E52 RID: 20050 RVA: 0x00024EBD File Offset: 0x000230BD
		public unsafe List<NetworkObject> objectsTemporarilyOwnedByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x00179DBC File Offset: 0x00177FBC
		// (set) Token: 0x06004E54 RID: 20052 RVA: 0x00024EDC File Offset: 0x000230DC
		public unsafe static Action onLocalPlayerSpawned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onLocalPlayerSpawned, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onLocalPlayerSpawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x00179DE4 File Offset: 0x00177FE4
		// (set) Token: 0x06004E56 RID: 20054 RVA: 0x00024EEE File Offset: 0x000230EE
		public unsafe static Action<Player> onPlayerSpawned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onPlayerSpawned, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onPlayerSpawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x00179E0C File Offset: 0x0017800C
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x00024F00 File Offset: 0x00023100
		public unsafe static Action<Player> onPlayerDespawned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onPlayerDespawned, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onPlayerDespawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x00179E34 File Offset: 0x00178034
		// (set) Token: 0x06004E5A RID: 20058 RVA: 0x00024F12 File Offset: 0x00023112
		public unsafe static Player Local
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_Local, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_Local, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x00179E5C File Offset: 0x0017805C
		// (set) Token: 0x06004E5C RID: 20060 RVA: 0x00024F24 File Offset: 0x00023124
		public unsafe static List<Player> PlayerList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_PlayerList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_PlayerList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06004E5D RID: 20061 RVA: 0x00179E84 File Offset: 0x00178084
		// (set) Token: 0x06004E5E RID: 20062 RVA: 0x00024F36 File Offset: 0x00023136
		public unsafe GameObject LocalGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06004E5F RID: 20063 RVA: 0x00179EB4 File Offset: 0x001780B4
		// (set) Token: 0x06004E60 RID: 20064 RVA: 0x00024F55 File Offset: 0x00023155
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x00179EE4 File Offset: 0x001780E4
		// (set) Token: 0x06004E62 RID: 20066 RVA: 0x00024F74 File Offset: 0x00023174
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x00179F14 File Offset: 0x00178114
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x00024F93 File Offset: 0x00023193
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x00179F44 File Offset: 0x00178144
		// (set) Token: 0x06004E66 RID: 20070 RVA: 0x00024FB2 File Offset: 0x000231B2
		public unsafe Vector3 EyePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_EyePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_EyePosition)) = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x00179F6C File Offset: 0x0017816C
		// (set) Token: 0x06004E68 RID: 20072 RVA: 0x00024FCD File Offset: 0x000231CD
		public unsafe AvatarSettings TestAvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_TestAvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_TestAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x00179F9C File Offset: 0x0017819C
		// (set) Token: 0x06004E6A RID: 20074 RVA: 0x00024FEC File Offset: 0x000231EC
		public unsafe PlayerVisualState VisualState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VisualState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VisualState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x00179FCC File Offset: 0x001781CC
		// (set) Token: 0x06004E6C RID: 20076 RVA: 0x0002500B File Offset: 0x0002320B
		public unsafe PlayerVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Visibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Visibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x00179FFC File Offset: 0x001781FC
		// (set) Token: 0x06004E6E RID: 20078 RVA: 0x0002502A File Offset: 0x0002322A
		public unsafe CapsuleCollider CapCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CapCol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CapCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x0017A02C File Offset: 0x0017822C
		// (set) Token: 0x06004E70 RID: 20080 RVA: 0x00025049 File Offset: 0x00023249
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x0017A05C File Offset: 0x0017825C
		// (set) Token: 0x06004E72 RID: 20082 RVA: 0x00025068 File Offset: 0x00023268
		public unsafe PlayerHealth Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Health);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerHealth>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Health), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x0017A08C File Offset: 0x0017828C
		// (set) Token: 0x06004E74 RID: 20084 RVA: 0x00025087 File Offset: 0x00023287
		public unsafe PlayerCrimeData CrimeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrimeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCrimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x0017A0BC File Offset: 0x001782BC
		// (set) Token: 0x06004E76 RID: 20086 RVA: 0x000250A6 File Offset: 0x000232A6
		public unsafe PlayerEnergy Energy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Energy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEnergy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Energy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06004E77 RID: 20087 RVA: 0x0017A0EC File Offset: 0x001782EC
		// (set) Token: 0x06004E78 RID: 20088 RVA: 0x000250C5 File Offset: 0x000232C5
		public unsafe Transform MimicCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_MimicCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_MimicCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06004E79 RID: 20089 RVA: 0x0017A11C File Offset: 0x0017831C
		// (set) Token: 0x06004E7A RID: 20090 RVA: 0x000250E4 File Offset: 0x000232E4
		public unsafe AvatarFootstepDetector FootstepDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_FootstepDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarFootstepDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_FootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06004E7B RID: 20091 RVA: 0x0017A14C File Offset: 0x0017834C
		// (set) Token: 0x06004E7C RID: 20092 RVA: 0x00025103 File Offset: 0x00023303
		public unsafe LocalPlayerFootstepGenerator LocalFootstepDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalFootstepDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayerFootstepGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalFootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06004E7D RID: 20093 RVA: 0x0017A17C File Offset: 0x0017837C
		// (set) Token: 0x06004E7E RID: 20094 RVA: 0x00025122 File Offset: 0x00023322
		public unsafe CharacterController CharacterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CharacterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06004E7F RID: 20095 RVA: 0x0017A1AC File Offset: 0x001783AC
		// (set) Token: 0x06004E80 RID: 20096 RVA: 0x00025141 File Offset: 0x00023341
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PunchSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x0017A1DC File Offset: 0x001783DC
		// (set) Token: 0x06004E82 RID: 20098 RVA: 0x00025160 File Offset: 0x00023360
		public unsafe OptimizedLight ThirdPersonFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ThirdPersonFlashlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ThirdPersonFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x0017A20C File Offset: 0x0017840C
		// (set) Token: 0x06004E84 RID: 20100 RVA: 0x0002517F File Offset: 0x0002337F
		public unsafe WorldspaceDialogueRenderer NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06004E85 RID: 20101 RVA: 0x0017A23C File Offset: 0x0017843C
		// (set) Token: 0x06004E86 RID: 20102 RVA: 0x0002519E File Offset: 0x0002339E
		public unsafe PlayerClothing Clothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Clothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerClothing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Clothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x0017A26C File Offset: 0x0017846C
		// (set) Token: 0x06004E88 RID: 20104 RVA: 0x000251BD File Offset: 0x000233BD
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x0017A294 File Offset: 0x00178494
		// (set) Token: 0x06004E8A RID: 20106 RVA: 0x000251D8 File Offset: 0x000233D8
		public unsafe float AvatarOffset_Standing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Standing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Standing)) = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x0017A2BC File Offset: 0x001784BC
		// (set) Token: 0x06004E8C RID: 20108 RVA: 0x000251F3 File Offset: 0x000233F3
		public unsafe float AvatarOffset_Crouched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Crouched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Crouched)) = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x0017A2E4 File Offset: 0x001784E4
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0002520E File Offset: 0x0002340E
		public unsafe AnimationCurve WalkingMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_WalkingMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_WalkingMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0017A314 File Offset: 0x00178514
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0002522D File Offset: 0x0002342D
		public unsafe AnimationCurve CrouchWalkMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrouchWalkMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrouchWalkMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x0017A344 File Offset: 0x00178544
		// (set) Token: 0x06004E92 RID: 20114 RVA: 0x0002524C File Offset: 0x0002344C
		public unsafe string _PlayerName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x0017A36C File Offset: 0x0017856C
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x0002526B File Offset: 0x0002346B
		public unsafe NetworkConnection Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x0017A39C File Offset: 0x0017859C
		// (set) Token: 0x06004E96 RID: 20118 RVA: 0x0002528A File Offset: 0x0002348A
		public unsafe string _PlayerCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerCode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x0017A3C4 File Offset: 0x001785C4
		// (set) Token: 0x06004E98 RID: 20120 RVA: 0x000252A9 File Offset: 0x000234A9
		public unsafe NetworkObject _CurrentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x0017A3F4 File Offset: 0x001785F4
		// (set) Token: 0x06004E9A RID: 20122 RVA: 0x000252C8 File Offset: 0x000234C8
		public unsafe Player.VehicleEvent onEnterVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onEnterVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.VehicleEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x0017A424 File Offset: 0x00178624
		// (set) Token: 0x06004E9C RID: 20124 RVA: 0x000252E7 File Offset: 0x000234E7
		public unsafe Player.VehicleTransformEvent onExitVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onExitVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.VehicleTransformEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x0017A454 File Offset: 0x00178654
		// (set) Token: 0x06004E9E RID: 20126 RVA: 0x00025306 File Offset: 0x00023506
		public unsafe LandVehicle LastDrivenVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LastDrivenVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LastDrivenVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004E9F RID: 20127 RVA: 0x0017A484 File Offset: 0x00178684
		// (set) Token: 0x06004EA0 RID: 20128 RVA: 0x00025325 File Offset: 0x00023525
		public unsafe float _TimeSinceVehicleExit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x0017A4AC File Offset: 0x001786AC
		// (set) Token: 0x06004EA2 RID: 20130 RVA: 0x00025340 File Offset: 0x00023540
		public unsafe bool _Crouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Crouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Crouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x0017A4D4 File Offset: 0x001786D4
		// (set) Token: 0x06004EA4 RID: 20132 RVA: 0x0002535B File Offset: 0x0002355B
		public unsafe NetworkObject _CurrentBed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x0017A504 File Offset: 0x00178704
		// (set) Token: 0x06004EA6 RID: 20134 RVA: 0x0002537A File Offset: 0x0002357A
		public unsafe bool _IsReadyToSleep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField)) = value;
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004EA7 RID: 20135 RVA: 0x0017A52C File Offset: 0x0017872C
		// (set) Token: 0x06004EA8 RID: 20136 RVA: 0x00025395 File Offset: 0x00023595
		public unsafe bool _IsSkating_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSkating_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSkating_k__BackingField)) = value;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x0017A554 File Offset: 0x00178754
		// (set) Token: 0x06004EAA RID: 20138 RVA: 0x000253B0 File Offset: 0x000235B0
		public unsafe Skateboard _ActiveSkateboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004EAB RID: 20139 RVA: 0x0017A584 File Offset: 0x00178784
		// (set) Token: 0x06004EAC RID: 20140 RVA: 0x000253CF File Offset: 0x000235CF
		public unsafe Action<Skateboard> onSkateboardMounted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardMounted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Skateboard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardMounted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x0017A5B4 File Offset: 0x001787B4
		// (set) Token: 0x06004EAE RID: 20142 RVA: 0x000253EE File Offset: 0x000235EE
		public unsafe Action onSkateboardDismounted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardDismounted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardDismounted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x0017A5E4 File Offset: 0x001787E4
		// (set) Token: 0x06004EB0 RID: 20144 RVA: 0x0002540D File Offset: 0x0002360D
		public unsafe bool _IsSleeping_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSleeping_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSleeping_k__BackingField)) = value;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x0017A60C File Offset: 0x0017880C
		// (set) Token: 0x06004EB2 RID: 20146 RVA: 0x00025428 File Offset: 0x00023628
		public unsafe bool _IsRagdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x0017A634 File Offset: 0x00178834
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x00025443 File Offset: 0x00023643
		public unsafe bool _IsArrested_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsArrested_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsArrested_k__BackingField)) = value;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x0017A65C File Offset: 0x0017885C
		// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x0002545E File Offset: 0x0002365E
		public unsafe bool _IsTased_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsTased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsTased_k__BackingField)) = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x0017A684 File Offset: 0x00178884
		// (set) Token: 0x06004EB8 RID: 20152 RVA: 0x00025479 File Offset: 0x00023679
		public unsafe bool _IsUnconscious_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField)) = value;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x0017A6AC File Offset: 0x001788AC
		// (set) Token: 0x06004EBA RID: 20154 RVA: 0x00025494 File Offset: 0x00023694
		public unsafe float _Scale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Scale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Scale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x0017A6D4 File Offset: 0x001788D4
		// (set) Token: 0x06004EBC RID: 20156 RVA: 0x000254AF File Offset: 0x000236AF
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x0017A704 File Offset: 0x00178904
		// (set) Token: 0x06004EBE RID: 20158 RVA: 0x000254CE File Offset: 0x000236CE
		public unsafe Property _LastVisitedProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x0017A734 File Offset: 0x00178934
		// (set) Token: 0x06004EC0 RID: 20160 RVA: 0x000254ED File Offset: 0x000236ED
		public unsafe Business _CurrentBusiness_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x0017A764 File Offset: 0x00178964
		// (set) Token: 0x06004EC2 RID: 20162 RVA: 0x0002550C File Offset: 0x0002370C
		public unsafe bool HasCompletedIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_HasCompletedIntro);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_HasCompletedIntro)) = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x0017A78C File Offset: 0x0017898C
		// (set) Token: 0x06004EC4 RID: 20164 RVA: 0x00025527 File Offset: 0x00023727
		public unsafe Vector3 _CameraPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x0017A7B4 File Offset: 0x001789B4
		// (set) Token: 0x06004EC6 RID: 20166 RVA: 0x00025542 File Offset: 0x00023742
		public unsafe Quaternion _CameraRotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x0017A7DC File Offset: 0x001789DC
		// (set) Token: 0x06004EC8 RID: 20168 RVA: 0x0002555D File Offset: 0x0002375D
		public unsafe Il2CppReferenceArray<ItemSlot> Inventory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Inventory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004EC9 RID: 20169 RVA: 0x0017A80C File Offset: 0x00178A0C
		// (set) Token: 0x06004ECA RID: 20170 RVA: 0x0002557C File Offset: 0x0002377C
		public unsafe BasicAvatarSettings _CurrentAvatarSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x0017A83C File Offset: 0x00178A3C
		// (set) Token: 0x06004ECC RID: 20172 RVA: 0x0002559B File Offset: 0x0002379B
		public unsafe ProductItemInstance _ConsumedProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x0017A86C File Offset: 0x00178A6C
		// (set) Token: 0x06004ECE RID: 20174 RVA: 0x000255BA File Offset: 0x000237BA
		public unsafe int _TimeSinceProductConsumed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x0017A894 File Offset: 0x00178A94
		// (set) Token: 0x06004ED0 RID: 20176 RVA: 0x000255D5 File Offset: 0x000237D5
		public unsafe BasicAvatarSettings DebugAvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_DebugAvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_DebugAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004ED1 RID: 20177 RVA: 0x0017A8C4 File Offset: 0x00178AC4
		// (set) Token: 0x06004ED2 RID: 20178 RVA: 0x000255F4 File Offset: 0x000237F4
		public unsafe PlayerLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x0017A8F4 File Offset: 0x00178AF4
		// (set) Token: 0x06004ED4 RID: 20180 RVA: 0x00025613 File Offset: 0x00023813
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x0017A924 File Offset: 0x00178B24
		// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x00025632 File Offset: 0x00023832
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x0017A954 File Offset: 0x00178B54
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x00025651 File Offset: 0x00023851
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x0017A97C File Offset: 0x00178B7C
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x0002566C File Offset: 0x0002386C
		public unsafe UnityEvent onRagdoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x0017A9AC File Offset: 0x00178BAC
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x0002568B File Offset: 0x0002388B
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdollEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x0017A9DC File Offset: 0x00178BDC
		// (set) Token: 0x06004EDE RID: 20190 RVA: 0x000256AA File Offset: 0x000238AA
		public unsafe UnityEvent onArrested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onArrested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onArrested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x0017AA0C File Offset: 0x00178C0C
		// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x000256C9 File Offset: 0x000238C9
		public unsafe UnityEvent onFreed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onFreed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onFreed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x0017AA3C File Offset: 0x00178C3C
		// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x000256E8 File Offset: 0x000238E8
		public unsafe UnityEvent onTased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x0017AA6C File Offset: 0x00178C6C
		// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x00025707 File Offset: 0x00023907
		public unsafe UnityEvent onTasedEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTasedEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTasedEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x0017AA9C File Offset: 0x00178C9C
		// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x00025726 File Offset: 0x00023926
		public unsafe UnityEvent onPassedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x0017AACC File Offset: 0x00178CCC
		// (set) Token: 0x06004EE8 RID: 20200 RVA: 0x00025745 File Offset: 0x00023945
		public unsafe UnityEvent onPassOutRecovery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassOutRecovery);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassOutRecovery), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x0017AAFC File Offset: 0x00178CFC
		// (set) Token: 0x06004EEA RID: 20202 RVA: 0x00025764 File Offset: 0x00023964
		public unsafe List<BaseVariable> PlayerVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PlayerVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PlayerVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x0017AB2C File Offset: 0x00178D2C
		// (set) Token: 0x06004EEC RID: 20204 RVA: 0x00025783 File Offset: 0x00023983
		public unsafe Dictionary<string, BaseVariable> VariableDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VariableDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BaseVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VariableDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004EED RID: 20205 RVA: 0x0017AB5C File Offset: 0x00178D5C
		// (set) Token: 0x06004EEE RID: 20206 RVA: 0x000257A2 File Offset: 0x000239A2
		public unsafe float standingScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_standingScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_standingScale)) = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004EEF RID: 20207 RVA: 0x0017AB84 File Offset: 0x00178D84
		// (set) Token: 0x06004EF0 RID: 20208 RVA: 0x000257BD File Offset: 0x000239BD
		public unsafe float timeAirborne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004EF1 RID: 20209 RVA: 0x0017ABAC File Offset: 0x00178DAC
		// (set) Token: 0x06004EF2 RID: 20210 RVA: 0x000257D8 File Offset: 0x000239D8
		public unsafe bool _avatarVisibleToLocalPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField)) = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x0017ABD4 File Offset: 0x00178DD4
		// (set) Token: 0x06004EF4 RID: 20212 RVA: 0x000257F3 File Offset: 0x000239F3
		public unsafe bool _playerDataRetrieveReturned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField)) = value;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x0017ABFC File Offset: 0x00178DFC
		// (set) Token: 0x06004EF6 RID: 20214 RVA: 0x0002580E File Offset: 0x00023A0E
		public unsafe Coroutine taseCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_taseCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_taseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x0017AC2C File Offset: 0x00178E2C
		// (set) Token: 0x06004EF8 RID: 20216 RVA: 0x0002582D File Offset: 0x00023A2D
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ragdollForceComponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x0017AC5C File Offset: 0x00178E5C
		// (set) Token: 0x06004EFA RID: 20218 RVA: 0x0002584C File Offset: 0x00023A4C
		public unsafe bool _playerSaveRequestReturned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField)) = value;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x0017AC84 File Offset: 0x00178E84
		// (set) Token: 0x06004EFC RID: 20220 RVA: 0x00025867 File Offset: 0x00023A67
		public unsafe bool _PlayerInitializedOverNetwork_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField)) = value;
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x0017ACAC File Offset: 0x00178EAC
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x00025882 File Offset: 0x00023A82
		public unsafe List<int> impactHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_impactHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x0017ACDC File Offset: 0x00178EDC
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x000258A1 File Offset: 0x00023AA1
		public unsafe bool _Paranoid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Paranoid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Paranoid_k__BackingField)) = value;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x0017AD04 File Offset: 0x00178F04
		// (set) Token: 0x06004F02 RID: 20226 RVA: 0x000258BC File Offset: 0x00023ABC
		public unsafe bool _Sneaky_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Sneaky_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Sneaky_k__BackingField)) = value;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x0017AD2C File Offset: 0x00178F2C
		// (set) Token: 0x06004F04 RID: 20228 RVA: 0x000258D7 File Offset: 0x00023AD7
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x0017AD54 File Offset: 0x00178F54
		// (set) Token: 0x06004F06 RID: 20230 RVA: 0x000258F2 File Offset: 0x00023AF2
		public unsafe bool _Seizure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Seizure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Seizure_k__BackingField)) = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x0017AD7C File Offset: 0x00178F7C
		// (set) Token: 0x06004F08 RID: 20232 RVA: 0x0002590D File Offset: 0x00023B0D
		public unsafe List<Quaternion> seizureRotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_seizureRotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_seizureRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x0017ADAC File Offset: 0x00178FAC
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x0002592C File Offset: 0x00023B2C
		public unsafe bool _Slippery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Slippery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Slippery_k__BackingField)) = value;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x0017ADD4 File Offset: 0x00178FD4
		// (set) Token: 0x06004F0C RID: 20236 RVA: 0x00025947 File Offset: 0x00023B47
		public unsafe bool _Schizophrenic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField)) = value;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x0017ADFC File Offset: 0x00178FFC
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x00025962 File Offset: 0x00023B62
		public unsafe List<int> equippableMessageIDHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_equippableMessageIDHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_equippableMessageIDHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0017AE2C File Offset: 0x0017902C
		// (set) Token: 0x06004F10 RID: 20240 RVA: 0x00025981 File Offset: 0x00023B81
		public unsafe Coroutine lerpScaleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lerpScaleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lerpScaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x0017AE5C File Offset: 0x0017905C
		// (set) Token: 0x06004F12 RID: 20242 RVA: 0x000259A0 File Offset: 0x00023BA0
		public unsafe SyncVar<string> syncVar____PlayerName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x0017AE8C File Offset: 0x0017908C
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x000259BF File Offset: 0x00023BBF
		public unsafe SyncVar<string> syncVar____PlayerCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x0017AEBC File Offset: 0x001790BC
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x000259DE File Offset: 0x00023BDE
		public unsafe SyncVar<NetworkObject> syncVar____CurrentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x0017AEEC File Offset: 0x001790EC
		// (set) Token: 0x06004F18 RID: 20248 RVA: 0x000259FD File Offset: 0x00023BFD
		public unsafe SyncVar<NetworkObject> syncVar____CurrentBed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06004F19 RID: 20249 RVA: 0x0017AF1C File Offset: 0x0017911C
		// (set) Token: 0x06004F1A RID: 20250 RVA: 0x00025A1C File Offset: 0x00023C1C
		public unsafe SyncVar<bool> syncVar____IsReadyToSleep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0017AF4C File Offset: 0x0017914C
		// (set) Token: 0x06004F1C RID: 20252 RVA: 0x00025A3B File Offset: 0x00023C3B
		public unsafe SyncVar<Vector3> syncVar____CameraPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x0017AF7C File Offset: 0x0017917C
		// (set) Token: 0x06004F1E RID: 20254 RVA: 0x00025A5A File Offset: 0x00023C5A
		public unsafe SyncVar<Quaternion> syncVar____CameraRotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0017AFAC File Offset: 0x001791AC
		// (set) Token: 0x06004F20 RID: 20256 RVA: 0x00025A79 File Offset: 0x00023C79
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x0017AFD4 File Offset: 0x001791D4
		// (set) Token: 0x06004F22 RID: 20258 RVA: 0x00025A94 File Offset: 0x00023C94
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeFieldInfoPtr_OWNER_PLAYER_CODE;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeFieldInfoPtr_CapColDefaultHeight;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerSpawned;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerSpawned;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerDespawned;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeFieldInfoPtr_Local;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeFieldInfoPtr_PlayerList;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeFieldInfoPtr_LocalGameObject;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeFieldInfoPtr_EyePosition;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeFieldInfoPtr_TestAvatarSettings;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeFieldInfoPtr_VisualState;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeFieldInfoPtr_CapCol;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeFieldInfoPtr_CrimeData;

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeFieldInfoPtr_Energy;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeFieldInfoPtr_MimicCamera;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeFieldInfoPtr_FootstepDetector;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeFieldInfoPtr_LocalFootstepDetector;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeFieldInfoPtr_CharacterController;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeFieldInfoPtr_ThirdPersonFlashlight;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeFieldInfoPtr_Clothing;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeFieldInfoPtr_AvatarOffset_Standing;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeFieldInfoPtr_AvatarOffset_Crouched;

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeFieldInfoPtr_WalkingMapCurve;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeFieldInfoPtr_CrouchWalkMapCurve;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeFieldInfoPtr__PlayerName_k__BackingField;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeFieldInfoPtr__PlayerCode_k__BackingField;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeFieldInfoPtr__CurrentVehicle_k__BackingField;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeFieldInfoPtr_onEnterVehicle;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeFieldInfoPtr_onExitVehicle;

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr_LastDrivenVehicle;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeFieldInfoPtr__Crouched_k__BackingField;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBed_k__BackingField;

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeFieldInfoPtr__IsReadyToSleep_k__BackingField;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeFieldInfoPtr__IsSkating_k__BackingField;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeFieldInfoPtr_onSkateboardMounted;

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeFieldInfoPtr_onSkateboardDismounted;

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeFieldInfoPtr__IsSleeping_k__BackingField;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeFieldInfoPtr__IsRagdolled_k__BackingField;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeFieldInfoPtr__IsArrested_k__BackingField;

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeFieldInfoPtr__IsTased_k__BackingField;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeFieldInfoPtr__IsUnconscious_k__BackingField;

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x040033E4 RID: 13284
		private static readonly IntPtr NativeFieldInfoPtr__LastVisitedProperty_k__BackingField;

		// Token: 0x040033E5 RID: 13285
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBusiness_k__BackingField;

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeFieldInfoPtr_HasCompletedIntro;

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeFieldInfoPtr__CameraRotation_k__BackingField;

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeFieldInfoPtr_Inventory;

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField;

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeFieldInfoPtr__ConsumedProduct_k__BackingField;

		// Token: 0x040033EC RID: 13292
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField;

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeFieldInfoPtr_DebugAvatarSettings;

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeFieldInfoPtr_onRagdoll;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeFieldInfoPtr_onArrested;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeFieldInfoPtr_onFreed;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeFieldInfoPtr_onTased;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeFieldInfoPtr_onTasedEnd;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeFieldInfoPtr_onPassedOut;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeFieldInfoPtr_onPassOutRecovery;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeFieldInfoPtr_PlayerVariables;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeFieldInfoPtr_VariableDict;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeFieldInfoPtr_standingScale;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeFieldInfoPtr_taseCoroutine;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeFieldInfoPtr__Paranoid_k__BackingField;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeFieldInfoPtr__Sneaky_k__BackingField;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeFieldInfoPtr__Seizure_k__BackingField;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeFieldInfoPtr_seizureRotations;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeFieldInfoPtr__Slippery_k__BackingField;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeFieldInfoPtr__Schizophrenic_k__BackingField;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeFieldInfoPtr_equippableMessageIDHistory;

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeFieldInfoPtr_lerpScaleRoutine;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField;

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0;

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerName_Public_get_String_0;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0;

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0;

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0;

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0;

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400343F RID: 13375
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0;

		// Token: 0x04003440 RID: 13376
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0;

		// Token: 0x04003441 RID: 13377
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0;

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0;

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0;

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0;

		// Token: 0x0400345A RID: 13402
		private static readonly IntPtr NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0;

		// Token: 0x0400345B RID: 13403
		private static readonly IntPtr NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0;

		// Token: 0x0400345C RID: 13404
		private static readonly IntPtr NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0;

		// Token: 0x0400345D RID: 13405
		private static readonly IntPtr NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0;

		// Token: 0x0400345E RID: 13406
		private static readonly IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x0400345F RID: 13407
		private static readonly IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x04003460 RID: 13408
		private static readonly IntPtr NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0;

		// Token: 0x04003461 RID: 13409
		private static readonly IntPtr NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0;

		// Token: 0x04003462 RID: 13410
		private static readonly IntPtr NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0;

		// Token: 0x04003463 RID: 13411
		private static readonly IntPtr NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0;

		// Token: 0x04003464 RID: 13412
		private static readonly IntPtr NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0;

		// Token: 0x04003465 RID: 13413
		private static readonly IntPtr NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0;

		// Token: 0x04003466 RID: 13414
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0;

		// Token: 0x04003467 RID: 13415
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0;

		// Token: 0x04003468 RID: 13416
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0;

		// Token: 0x04003469 RID: 13417
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400346A RID: 13418
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400346B RID: 13419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x0400346C RID: 13420
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x0400346D RID: 13421
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400346E RID: 13422
		private static readonly IntPtr NativeMethodInfoPtr_PlayerLoaded_Private_Void_0;

		// Token: 0x0400346F RID: 13423
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003470 RID: 13424
		private static readonly IntPtr NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0;

		// Token: 0x04003471 RID: 13425
		private static readonly IntPtr NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003472 RID: 13426
		private static readonly IntPtr NativeMethodInfoPtr_HostExitedGame_Public_Void_0;

		// Token: 0x04003473 RID: 13427
		private static readonly IntPtr NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0;

		// Token: 0x04003474 RID: 13428
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0;

		// Token: 0x04003475 RID: 13429
		private static readonly IntPtr NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0;

		// Token: 0x04003476 RID: 13430
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0;

		// Token: 0x04003477 RID: 13431
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04003478 RID: 13432
		private static readonly IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x04003479 RID: 13433
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400347A RID: 13434
		private static readonly IntPtr NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0;

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0;

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0;

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0;

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0;

		// Token: 0x04003490 RID: 13456
		private static readonly IntPtr NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0;

		// Token: 0x04003491 RID: 13457
		private static readonly IntPtr NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04003492 RID: 13458
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0;

		// Token: 0x04003493 RID: 13459
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0;

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Static_Void_0;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0;

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeMethodInfoPtr_SendPunch_Public_Void_0;

		// Token: 0x0400349C RID: 13468
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Private_Void_0;

		// Token: 0x0400349D RID: 13469
		private static readonly IntPtr NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400349E RID: 13470
		private static readonly IntPtr NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0;

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeMethodInfoPtr_GetInventoryString_Public_String_0;

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceString_Public_String_0;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeMethodInfoPtr_GetClothingString_Public_String_0;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0;

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0;

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeMethodInfoPtr_Arrest_Public_Void_0;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeMethodInfoPtr_SendPassOut_Public_Void_0;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeMethodInfoPtr_PassOut_Public_Void_0;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeMethodInfoPtr_PassOutRecovery_Public_Void_0;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeMethodInfoPtr_Taze_Public_Void_0;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0;

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeMethodInfoPtr_DismountSkateboard_Public_Void_0;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeMethodInfoPtr_ClearProduct_Public_Void_0;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0;

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_0_Private_Single_Property_0;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__248_1_Private_Single_Business_0;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003514 RID: 13588
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003515 RID: 13589
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003516 RID: 13590
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0;

		// Token: 0x0400351A RID: 13594
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0;

		// Token: 0x0400351B RID: 13595
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400351C RID: 13596
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400351D RID: 13597
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0;

		// Token: 0x0400351E RID: 13598
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003521 RID: 13601
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003522 RID: 13602
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003523 RID: 13603
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003524 RID: 13604
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

		// Token: 0x04003525 RID: 13605
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

		// Token: 0x04003526 RID: 13606
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003527 RID: 13607
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

		// Token: 0x04003528 RID: 13608
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

		// Token: 0x04003529 RID: 13609
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400352A RID: 13610
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400352B RID: 13611
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400352C RID: 13612
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400352D RID: 13613
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400352E RID: 13614
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0;

		// Token: 0x0400352F RID: 13615
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003530 RID: 13616
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0;

		// Token: 0x04003531 RID: 13617
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0;

		// Token: 0x04003532 RID: 13618
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003533 RID: 13619
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0;

		// Token: 0x04003534 RID: 13620
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0;

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003539 RID: 13625
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400353A RID: 13626
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400353B RID: 13627
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400353C RID: 13628
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0;

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003542 RID: 13634
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0;

		// Token: 0x04003543 RID: 13635
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0;

		// Token: 0x04003544 RID: 13636
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003545 RID: 13637
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0;

		// Token: 0x04003546 RID: 13638
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0;

		// Token: 0x04003547 RID: 13639
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003548 RID: 13640
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0;

		// Token: 0x04003549 RID: 13641
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0;

		// Token: 0x0400354A RID: 13642
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400354B RID: 13643
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0;

		// Token: 0x0400354C RID: 13644
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0;

		// Token: 0x0400354D RID: 13645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400354E RID: 13646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0;

		// Token: 0x0400354F RID: 13647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0;

		// Token: 0x04003550 RID: 13648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003551 RID: 13649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003552 RID: 13650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0;

		// Token: 0x04003553 RID: 13651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003554 RID: 13652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003555 RID: 13653
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003556 RID: 13654
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003557 RID: 13655
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04003558 RID: 13656
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0;

		// Token: 0x04003559 RID: 13657
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400355A RID: 13658
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x0400355B RID: 13659
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x0400355C RID: 13660
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400355D RID: 13661
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x0400355E RID: 13662
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0;

		// Token: 0x0400355F RID: 13663
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003560 RID: 13664
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x04003561 RID: 13665
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x04003562 RID: 13666
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003563 RID: 13667
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0;

		// Token: 0x04003564 RID: 13668
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0;

		// Token: 0x04003565 RID: 13669
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003566 RID: 13670
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003567 RID: 13671
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x04003568 RID: 13672
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003569 RID: 13673
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400356A RID: 13674
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400356B RID: 13675
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400356C RID: 13676
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x0400356D RID: 13677
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400356E RID: 13678
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400356F RID: 13679
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003570 RID: 13680
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04003571 RID: 13681
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04003572 RID: 13682
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003573 RID: 13683
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04003574 RID: 13684
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04003575 RID: 13685
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003576 RID: 13686
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0;

		// Token: 0x04003577 RID: 13687
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0;

		// Token: 0x04003578 RID: 13688
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003579 RID: 13689
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0;

		// Token: 0x0400357A RID: 13690
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0;

		// Token: 0x0400357B RID: 13691
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400357C RID: 13692
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400357D RID: 13693
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0;

		// Token: 0x0400357E RID: 13694
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400357F RID: 13695
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04003580 RID: 13696
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04003581 RID: 13697
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003582 RID: 13698
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003583 RID: 13699
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003584 RID: 13700
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003585 RID: 13701
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003586 RID: 13702
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003587 RID: 13703
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003588 RID: 13704
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04003589 RID: 13705
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400358A RID: 13706
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400358B RID: 13707
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0;

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04003599 RID: 13721
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0;

		// Token: 0x0400359E RID: 13726
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x0400359F RID: 13727
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x040035A0 RID: 13728
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x040035A1 RID: 13729
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0;

		// Token: 0x040035A2 RID: 13730
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0;

		// Token: 0x040035A3 RID: 13731
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200098E RID: 2446
		public sealed class VehicleEvent : MulticastDelegate
		{
			// Token: 0x0600CA68 RID: 51816 RVA: 0x0030F0DC File Offset: 0x0030D2DC
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleEvent()
			{
				Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleEvent");
				Player.VehicleEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673166);
				Player.VehicleEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673167);
				Player.VehicleEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673168);
				Player.VehicleEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673169);
			}

			// Token: 0x0600CA69 RID: 51817 RVA: 0x0030F150 File Offset: 0x0030D350
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6A RID: 51818 RVA: 0x0030F1AC File Offset: 0x0030D3AC
			[CallerCount(0)]
			public unsafe void Invoke(LandVehicle vehicle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6B RID: 51819 RVA: 0x0030F1F0 File Offset: 0x0030D3F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(LandVehicle vehicle, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA6C RID: 51820 RVA: 0x0030F264 File Offset: 0x0030D464
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA6D RID: 51821 RVA: 0x00062673 File Offset: 0x00060873
			public VehicleEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA6E RID: 51822 RVA: 0x0006267C File Offset: 0x0006087C
			public static implicit operator Player.VehicleEvent(Action<LandVehicle> A_0)
			{
				return DelegateSupport.ConvertDelegate<Player.VehicleEvent>(A_0);
			}

			// Token: 0x0600CA6F RID: 51823 RVA: 0x00062684 File Offset: 0x00060884
			public static Player.VehicleEvent operator +(Player.VehicleEvent A_0, Player.VehicleEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Player.VehicleEvent>();
			}

			// Token: 0x0600CA70 RID: 51824 RVA: 0x00062692 File Offset: 0x00060892
			public static Player.VehicleEvent operator -(Player.VehicleEvent A_0, Player.VehicleEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Player.VehicleEvent>();
				}
				return result;
			}

			// Token: 0x040088ED RID: 35053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088EE RID: 35054
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0;

			// Token: 0x040088EF RID: 35055
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0;

			// Token: 0x040088F0 RID: 35056
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200098F RID: 2447
		public sealed class VehicleTransformEvent : MulticastDelegate
		{
			// Token: 0x0600CA71 RID: 51825 RVA: 0x0030F2A8 File Offset: 0x0030D4A8
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleTransformEvent()
			{
				Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleTransformEvent");
				Player.VehicleTransformEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673170);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673171);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673172);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673173);
			}

			// Token: 0x0600CA72 RID: 51826 RVA: 0x0030F31C File Offset: 0x0030D51C
			[CallerCount(177)]
			[CachedScanResults(RefRangeStart = 165953, RefRangeEnd = 166130, XrefRangeStart = 165944, XrefRangeEnd = 165953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleTransformEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA73 RID: 51827 RVA: 0x0030F378 File Offset: 0x0030D578
			[CallerCount(0)]
			public unsafe void Invoke(LandVehicle vehicle, Transform exitPoint)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA74 RID: 51828 RVA: 0x0030F3CC File Offset: 0x0030D5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(LandVehicle vehicle, Transform exitPoint, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA75 RID: 51829 RVA: 0x0030F454 File Offset: 0x0030D654
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA76 RID: 51830 RVA: 0x000626A3 File Offset: 0x000608A3
			public VehicleTransformEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA77 RID: 51831 RVA: 0x000626AC File Offset: 0x000608AC
			public static implicit operator Player.VehicleTransformEvent(Action<LandVehicle, Transform> A_0)
			{
				return DelegateSupport.ConvertDelegate<Player.VehicleTransformEvent>(A_0);
			}

			// Token: 0x0600CA78 RID: 51832 RVA: 0x000626B4 File Offset: 0x000608B4
			public static Player.VehicleTransformEvent operator +(Player.VehicleTransformEvent A_0, Player.VehicleTransformEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Player.VehicleTransformEvent>();
			}

			// Token: 0x0600CA79 RID: 51833 RVA: 0x000626C2 File Offset: 0x000608C2
			public static Player.VehicleTransformEvent operator -(Player.VehicleTransformEvent A_0, Player.VehicleTransformEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Player.VehicleTransformEvent>();
				}
				return result;
			}

			// Token: 0x040088F1 RID: 35057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088F2 RID: 35058
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0;

			// Token: 0x040088F3 RID: 35059
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0;

			// Token: 0x040088F4 RID: 35060
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000990 RID: 2448
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<<Taze>g__Tase|319_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CA7A RID: 51834 RVA: 0x0030F498 File Offset: 0x0030D698
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
			{
				Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<<Taze>g__Tase|319_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673174);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673175);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673176);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673177);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673178);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673179);
			}

			// Token: 0x0600CA7B RID: 51835 RVA: 0x0030F578 File Offset: 0x0030D778
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA7C RID: 51836 RVA: 0x0030F5C0 File Offset: 0x0030D7C0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA7D RID: 51837 RVA: 0x0030F5F4 File Offset: 0x0030D7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166130, XrefRangeEnd = 166136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F12 RID: 16146
			// (get) Token: 0x0600CA7E RID: 51838 RVA: 0x0030F630 File Offset: 0x0030D830
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA7F RID: 51839 RVA: 0x0030F670 File Offset: 0x0030D870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166136, XrefRangeEnd = 166141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F13 RID: 16147
			// (get) Token: 0x0600CA80 RID: 51840 RVA: 0x0030F6A4 File Offset: 0x0030D8A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA81 RID: 51841 RVA: 0x000626D3 File Offset: 0x000608D3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F0F RID: 16143
			// (get) Token: 0x0600CA82 RID: 51842 RVA: 0x0030F6E4 File Offset: 0x0030D8E4
			// (set) Token: 0x0600CA83 RID: 51843 RVA: 0x000626DC File Offset: 0x000608DC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F10 RID: 16144
			// (get) Token: 0x0600CA84 RID: 51844 RVA: 0x0030F70C File Offset: 0x0030D90C
			// (set) Token: 0x0600CA85 RID: 51845 RVA: 0x000626F7 File Offset: 0x000608F7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F11 RID: 16145
			// (get) Token: 0x0600CA86 RID: 51846 RVA: 0x0030F73C File Offset: 0x0030D93C
			// (set) Token: 0x0600CA87 RID: 51847 RVA: 0x00062716 File Offset: 0x00060916
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088F5 RID: 35061
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088F6 RID: 35062
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088F7 RID: 35063
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088F8 RID: 35064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088F9 RID: 35065
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088FA RID: 35066
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088FB RID: 35067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088FC RID: 35068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088FD RID: 35069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000991 RID: 2449
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass222_0")]
		public sealed class __c__DisplayClass222_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA88 RID: 51848 RVA: 0x0030F76C File Offset: 0x0030D96C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass222_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass222_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr);
				Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, "playerCode");
				Player.__c__DisplayClass222_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, 100673180);
				Player.__c__DisplayClass222_0.NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, 100673181);
			}

			// Token: 0x0600CA89 RID: 51849 RVA: 0x0030F7D4 File Offset: 0x0030D9D4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass222_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass222_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA8A RID: 51850 RVA: 0x0030F810 File Offset: 0x0030DA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166141, XrefRangeEnd = 166144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPlayer_b__0(Player x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass222_0.NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA8B RID: 51851 RVA: 0x00062735 File Offset: 0x00060935
			public __c__DisplayClass222_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F14 RID: 16148
			// (get) Token: 0x0600CA8C RID: 51852 RVA: 0x0030F860 File Offset: 0x0030DA60
			// (set) Token: 0x0600CA8D RID: 51853 RVA: 0x0006273E File Offset: 0x0006093E
			public unsafe string playerCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088FE RID: 35070
			private static readonly IntPtr NativeFieldInfoPtr_playerCode;

			// Token: 0x040088FF RID: 35071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008900 RID: 35072
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0;
		}

		// Token: 0x02000992 RID: 2450
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass277_0")]
		public sealed class __c__DisplayClass277_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA8E RID: 51854 RVA: 0x0030F888 File Offset: 0x0030DA88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass277_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass277_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr);
				Player.__c__DisplayClass277_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr, "point");
				Player.__c__DisplayClass277_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr, 100673182);
				Player.__c__DisplayClass277_0.NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr, 100673183);
			}

			// Token: 0x0600CA8F RID: 51855 RVA: 0x0030F8F0 File Offset: 0x0030DAF0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass277_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass277_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass277_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA90 RID: 51856 RVA: 0x0030F92C File Offset: 0x0030DB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166144, XrefRangeEnd = 166145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestPlayer_b__0(Player x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass277_0.NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA91 RID: 51857 RVA: 0x0006275D File Offset: 0x0006095D
			public __c__DisplayClass277_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F15 RID: 16149
			// (get) Token: 0x0600CA92 RID: 51858 RVA: 0x0030F97C File Offset: 0x0030DB7C
			// (set) Token: 0x0600CA93 RID: 51859 RVA: 0x00062766 File Offset: 0x00060966
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass277_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass277_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x04008901 RID: 35073
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008902 RID: 35074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008903 RID: 35075
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0;
		}

		// Token: 0x02000993 RID: 2451
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass281_0")]
		public sealed class __c__DisplayClass281_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA94 RID: 51860 RVA: 0x0030F9A4 File Offset: 0x0030DBA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass281_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass281_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr);
				Player.__c__DisplayClass281_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, "<>4__this");
				Player.__c__DisplayClass281_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, "startScale");
				Player.__c__DisplayClass281_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, "scale");
				Player.__c__DisplayClass281_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, "lerpTime");
				Player.__c__DisplayClass281_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, 100673184);
				Player.__c__DisplayClass281_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, 100673185);
			}

			// Token: 0x0600CA95 RID: 51861 RVA: 0x0030FA48 File Offset: 0x0030DC48
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass281_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA96 RID: 51862 RVA: 0x0030FA84 File Offset: 0x0030DC84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166164, RefRangeEnd = 166165, XrefRangeStart = 166159, XrefRangeEnd = 166164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CA97 RID: 51863 RVA: 0x00062781 File Offset: 0x00060981
			public __c__DisplayClass281_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F16 RID: 16150
			// (get) Token: 0x0600CA98 RID: 51864 RVA: 0x0030FAC4 File Offset: 0x0030DCC4
			// (set) Token: 0x0600CA99 RID: 51865 RVA: 0x0006278A File Offset: 0x0006098A
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F17 RID: 16151
			// (get) Token: 0x0600CA9A RID: 51866 RVA: 0x0030FAF4 File Offset: 0x0030DCF4
			// (set) Token: 0x0600CA9B RID: 51867 RVA: 0x000627A9 File Offset: 0x000609A9
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17003F18 RID: 16152
			// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x0030FB1C File Offset: 0x0030DD1C
			// (set) Token: 0x0600CA9D RID: 51869 RVA: 0x000627C4 File Offset: 0x000609C4
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17003F19 RID: 16153
			// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x0030FB44 File Offset: 0x0030DD44
			// (set) Token: 0x0600CA9F RID: 51871 RVA: 0x000627DF File Offset: 0x000609DF
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x04008904 RID: 35076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008905 RID: 35077
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04008906 RID: 35078
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04008907 RID: 35079
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008908 RID: 35080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008909 RID: 35081
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C43 RID: 3139
			[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass281_0+<<SetScale>g__LerpScale|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E251 RID: 57937 RVA: 0x00352808 File Offset: 0x00350A08
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player.__c__DisplayClass281_0>.NativeClassPtr, "<<SetScale>g__LerpScale|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673186);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673187);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673188);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673189);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673190);
					Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673191);
				}

				// Token: 0x0600E252 RID: 57938 RVA: 0x003528FC File Offset: 0x00350AFC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E253 RID: 57939 RVA: 0x00352944 File Offset: 0x00350B44
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E254 RID: 57940 RVA: 0x00352978 File Offset: 0x00350B78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166145, XrefRangeEnd = 166154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004631 RID: 17969
				// (get) Token: 0x0600E255 RID: 57941 RVA: 0x003529B4 File Offset: 0x00350BB4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E256 RID: 57942 RVA: 0x003529F4 File Offset: 0x00350BF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166154, XrefRangeEnd = 166159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004632 RID: 17970
				// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00352A28 File Offset: 0x00350C28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E258 RID: 57944 RVA: 0x0006E55E File Offset: 0x0006C75E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700462D RID: 17965
				// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00352A68 File Offset: 0x00350C68
				// (set) Token: 0x0600E25A RID: 57946 RVA: 0x0006E567 File Offset: 0x0006C767
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700462E RID: 17966
				// (get) Token: 0x0600E25B RID: 57947 RVA: 0x00352A90 File Offset: 0x00350C90
				// (set) Token: 0x0600E25C RID: 57948 RVA: 0x0006E582 File Offset: 0x0006C782
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700462F RID: 17967
				// (get) Token: 0x0600E25D RID: 57949 RVA: 0x00352AC0 File Offset: 0x00350CC0
				// (set) Token: 0x0600E25E RID: 57950 RVA: 0x0006E5A1 File Offset: 0x0006C7A1
				public unsafe Player.__c__DisplayClass281_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.__c__DisplayClass281_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004630 RID: 17968
				// (get) Token: 0x0600E25F RID: 57951 RVA: 0x00352AF0 File Offset: 0x00350CF0
				// (set) Token: 0x0600E260 RID: 57952 RVA: 0x0006E5C0 File Offset: 0x0006C7C0
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass281_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400977E RID: 38782
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400977F RID: 38783
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009780 RID: 38784
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009781 RID: 38785
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009782 RID: 38786
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009783 RID: 38787
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009784 RID: 38788
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009785 RID: 38789
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009786 RID: 38790
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009787 RID: 38791
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000994 RID: 2452
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x0400890A RID: 35082
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Player.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<Player>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
