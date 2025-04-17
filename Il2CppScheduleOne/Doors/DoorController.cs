using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000423 RID: 1059
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x06005CF9 RID: 23801 RVA: 0x001ADBBC File Offset: 0x001ABDBC
		// Note: this type is marked as 'beforefieldinit'.
		static DoorController()
		{
			Il2CppClassPointerStore<DoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorController>.NativeClassPtr);
			DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "DISTANT_PLAYER_THRESHOLD");
			DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<IsOpen>k__BackingField");
			DoorController.NativeFieldInfoPtr_PlayerAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerAccess");
			DoorController.NativeFieldInfoPtr_AutoOpenForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoOpenForPlayer");
			DoorController.NativeFieldInfoPtr_InteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorIntObjs");
			DoorController.NativeFieldInfoPtr_ExteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorIntObjs");
			DoorController.NativeFieldInfoPtr_PlayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerBlocker");
			DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_AutoCloseOnSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnSleep");
			DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnDistantPlayer");
			DoorController.NativeFieldInfoPtr_OpenableByNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "OpenableByNPCs");
			DoorController.NativeFieldInfoPtr_ReturnToOriginalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ReturnToOriginalTime");
			DoorController.NativeFieldInfoPtr_onDoorOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorOpened");
			DoorController.NativeFieldInfoPtr_onDoorClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorClosed");
			DoorController.NativeFieldInfoPtr_lastOpenSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "lastOpenSide");
			DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<openedByNPC>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSinceNPCSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr_autoOpenedForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "autoOpenedForPlayer");
			DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<playerDetectedSinceOpened>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSincePlayerSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeInCurrentState>k__BackingField");
			DoorController.NativeFieldInfoPtr_noAccessErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "noAccessErrorMessage");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675149);
			DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675150);
			DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675151);
			DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675152);
			DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675153);
			DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675154);
			DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675155);
			DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675156);
			DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675157);
			DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675158);
			DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675159);
			DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675160);
			DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675161);
			DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675162);
			DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675163);
			DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675164);
			DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675165);
			DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675166);
			DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675167);
			DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675168);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675169);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675170);
			DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675171);
			DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675172);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675173);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675174);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675175);
			DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675176);
			DoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675177);
			DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675178);
			DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675179);
			DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675180);
			DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675181);
			DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675182);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675183);
			DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675184);
			DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675185);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675186);
			DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675187);
			DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675188);
			DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675189);
			DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675190);
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x001AE128 File Offset: 0x001AC328
		// (set) Token: 0x06005CFB RID: 23803 RVA: 0x001AE164 File Offset: 0x001AC364
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x001AE1A4 File Offset: 0x001AC3A4
		// (set) Token: 0x06005CFD RID: 23805 RVA: 0x001AE1E0 File Offset: 0x001AC3E0
		public unsafe bool openedByNPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06005CFE RID: 23806 RVA: 0x001AE220 File Offset: 0x001AC420
		// (set) Token: 0x06005CFF RID: 23807 RVA: 0x001AE25C File Offset: 0x001AC45C
		public unsafe float timeSinceNPCSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x001AE29C File Offset: 0x001AC49C
		// (set) Token: 0x06005D01 RID: 23809 RVA: 0x001AE2D8 File Offset: 0x001AC4D8
		public unsafe bool playerDetectedSinceOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06005D02 RID: 23810 RVA: 0x001AE318 File Offset: 0x001AC518
		// (set) Token: 0x06005D03 RID: 23811 RVA: 0x001AE354 File Offset: 0x001AC554
		public unsafe float timeSincePlayerSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06005D04 RID: 23812 RVA: 0x001AE394 File Offset: 0x001AC594
		// (set) Token: 0x06005D05 RID: 23813 RVA: 0x001AE3D0 File Offset: 0x001AC5D0
		public unsafe float timeInCurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x001AE410 File Offset: 0x001AC610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195587, RefRangeEnd = 195589, XrefRangeStart = 195586, XrefRangeEnd = 195587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x001AE44C File Offset: 0x001AC64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195589, XrefRangeEnd = 195605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x001AE488 File Offset: 0x001AC688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195605, XrefRangeEnd = 195611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x001AE4C4 File Offset: 0x001AC6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195611, XrefRangeEnd = 195613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x001AE514 File Offset: 0x001AC714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195613, XrefRangeEnd = 195625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x001AE550 File Offset: 0x001AC750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195625, XrefRangeEnd = 195631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x001AE58C File Offset: 0x001AC78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195631, XrefRangeEnd = 195643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x001AE5C8 File Offset: 0x001AC7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195643, XrefRangeEnd = 195649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x001AE604 File Offset: 0x001AC804
		[CallerCount(0)]
		public unsafe bool CanPlayerAccess(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x001AE650 File Offset: 0x001AC850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195650, RefRangeEnd = 195651, XrefRangeStart = 195649, XrefRangeEnd = 195650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x001AE6C0 File Offset: 0x001AC8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195651, XrefRangeEnd = 195654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x001AE70C File Offset: 0x001AC90C
		[CallerCount(0)]
		public unsafe virtual void PlayerVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x001AE758 File Offset: 0x001AC958
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195678, RefRangeEnd = 195684, XrefRangeStart = 195654, XrefRangeEnd = 195678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x001AE7B4 File Offset: 0x001AC9B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195727, RefRangeEnd = 195732, XrefRangeStart = 195684, XrefRangeEnd = 195727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x001AE814 File Offset: 0x001ACA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195732, XrefRangeEnd = 195737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x001AE86C File Offset: 0x001ACA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195737, XrefRangeEnd = 195745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckAutoCloseForDistantPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x001AE8A8 File Offset: 0x001ACAA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195749, RefRangeEnd = 195750, XrefRangeStart = 195745, XrefRangeEnd = 195749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x001AE8E4 File Offset: 0x001ACAE4
		[CallerCount(0)]
		public unsafe void _Start_b__42_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x001AE918 File Offset: 0x001ACB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195770, RefRangeEnd = 195771, XrefRangeStart = 195750, XrefRangeEnd = 195770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x001AE954 File Offset: 0x001ACB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112829, RefRangeEnd = 112830, XrefRangeStart = 112829, XrefRangeEnd = 112830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x001AE990 File Offset: 0x001ACB90
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x001AE9CC File Offset: 0x001ACBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195771, XrefRangeEnd = 195783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x001AEA28 File Offset: 0x001ACC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195783, XrefRangeEnd = 195784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x001AEA84 File Offset: 0x001ACC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195784, XrefRangeEnd = 195788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x001AEAE8 File Offset: 0x001ACCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195788, XrefRangeEnd = 195808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x001AEB48 File Offset: 0x001ACD48
		[CallerCount(0)]
		public unsafe void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x001AEBA8 File Offset: 0x001ACDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195808, XrefRangeEnd = 195811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x001AEBF8 File Offset: 0x001ACDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195811, XrefRangeEnd = 195822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x001AEC58 File Offset: 0x001ACE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195822, XrefRangeEnd = 195825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x001AECA8 File Offset: 0x001ACEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195865, RefRangeEnd = 195866, XrefRangeStart = 195825, XrefRangeEnd = 195865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0002BCF0 File Offset: 0x00029EF0
		public DoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x001AECE4 File Offset: 0x001ACEE4
		// (set) Token: 0x06005D26 RID: 23846 RVA: 0x0002BCF9 File Offset: 0x00029EF9
		public unsafe static float DISTANT_PLAYER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06005D27 RID: 23847 RVA: 0x001AED00 File Offset: 0x001ACF00
		// (set) Token: 0x06005D28 RID: 23848 RVA: 0x0002BD07 File Offset: 0x00029F07
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x001AED28 File Offset: 0x001ACF28
		// (set) Token: 0x06005D2A RID: 23850 RVA: 0x0002BD22 File Offset: 0x00029F22
		public unsafe EDoorAccess PlayerAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess)) = value;
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x001AED50 File Offset: 0x001ACF50
		// (set) Token: 0x06005D2C RID: 23852 RVA: 0x0002BD3D File Offset: 0x00029F3D
		public unsafe bool AutoOpenForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer)) = value;
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x001AED78 File Offset: 0x001ACF78
		// (set) Token: 0x06005D2E RID: 23854 RVA: 0x0002BD58 File Offset: 0x00029F58
		public unsafe Il2CppReferenceArray<InteractableObject> InteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06005D2F RID: 23855 RVA: 0x001AEDA8 File Offset: 0x001ACFA8
		// (set) Token: 0x06005D30 RID: 23856 RVA: 0x0002BD77 File Offset: 0x00029F77
		public unsafe Il2CppReferenceArray<InteractableObject> ExteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06005D31 RID: 23857 RVA: 0x001AEDD8 File Offset: 0x001ACFD8
		// (set) Token: 0x06005D32 RID: 23858 RVA: 0x0002BD96 File Offset: 0x00029F96
		public unsafe BoxCollider PlayerBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06005D33 RID: 23859 RVA: 0x001AEE08 File Offset: 0x001AD008
		// (set) Token: 0x06005D34 RID: 23860 RVA: 0x0002BDB5 File Offset: 0x00029FB5
		public unsafe Animation InteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06005D35 RID: 23861 RVA: 0x001AEE38 File Offset: 0x001AD038
		// (set) Token: 0x06005D36 RID: 23862 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		public unsafe Animation ExteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x001AEE68 File Offset: 0x001AD068
		// (set) Token: 0x06005D38 RID: 23864 RVA: 0x0002BDF3 File Offset: 0x00029FF3
		public unsafe bool AutoCloseOnSleep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep)) = value;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x001AEE90 File Offset: 0x001AD090
		// (set) Token: 0x06005D3A RID: 23866 RVA: 0x0002BE0E File Offset: 0x0002A00E
		public unsafe bool AutoCloseOnDistantPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer)) = value;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x001AEEB8 File Offset: 0x001AD0B8
		// (set) Token: 0x06005D3C RID: 23868 RVA: 0x0002BE29 File Offset: 0x0002A029
		public unsafe bool OpenableByNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs)) = value;
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x001AEEE0 File Offset: 0x001AD0E0
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x0002BE44 File Offset: 0x0002A044
		public unsafe float ReturnToOriginalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime)) = value;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x001AEF08 File Offset: 0x001AD108
		// (set) Token: 0x06005D40 RID: 23872 RVA: 0x0002BE5F File Offset: 0x0002A05F
		public unsafe UnityEvent<EDoorSide> onDoorOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDoorSide>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x001AEF38 File Offset: 0x001AD138
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x0002BE7E File Offset: 0x0002A07E
		public unsafe UnityEvent onDoorClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001AEF68 File Offset: 0x001AD168
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x0002BE9D File Offset: 0x0002A09D
		public unsafe EDoorSide lastOpenSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide)) = value;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001AEF90 File Offset: 0x001AD190
		// (set) Token: 0x06005D46 RID: 23878 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		public unsafe bool _openedByNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x001AEFB8 File Offset: 0x001AD1B8
		// (set) Token: 0x06005D48 RID: 23880 RVA: 0x0002BED3 File Offset: 0x0002A0D3
		public unsafe float _timeSinceNPCSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06005D49 RID: 23881 RVA: 0x001AEFE0 File Offset: 0x001AD1E0
		// (set) Token: 0x06005D4A RID: 23882 RVA: 0x0002BEEE File Offset: 0x0002A0EE
		public unsafe bool autoOpenedForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer)) = value;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06005D4B RID: 23883 RVA: 0x001AF008 File Offset: 0x001AD208
		// (set) Token: 0x06005D4C RID: 23884 RVA: 0x0002BF09 File Offset: 0x0002A109
		public unsafe bool _playerDetectedSinceOpened_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x001AF030 File Offset: 0x001AD230
		// (set) Token: 0x06005D4E RID: 23886 RVA: 0x0002BF24 File Offset: 0x0002A124
		public unsafe float _timeSincePlayerSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06005D4F RID: 23887 RVA: 0x001AF058 File Offset: 0x001AD258
		// (set) Token: 0x06005D50 RID: 23888 RVA: 0x0002BF3F File Offset: 0x0002A13F
		public unsafe float _timeInCurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06005D51 RID: 23889 RVA: 0x001AF080 File Offset: 0x001AD280
		// (set) Token: 0x06005D52 RID: 23890 RVA: 0x0002BF5A File Offset: 0x0002A15A
		public unsafe string noAccessErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06005D53 RID: 23891 RVA: 0x001AF0A8 File Offset: 0x001AD2A8
		// (set) Token: 0x06005D54 RID: 23892 RVA: 0x0002BF79 File Offset: 0x0002A179
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06005D55 RID: 23893 RVA: 0x001AF0D0 File Offset: 0x001AD2D0
		// (set) Token: 0x06005D56 RID: 23894 RVA: 0x0002BF94 File Offset: 0x0002A194
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003FA3 RID: 16291
		private static readonly IntPtr NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD;

		// Token: 0x04003FA4 RID: 16292
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04003FA5 RID: 16293
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccess;

		// Token: 0x04003FA6 RID: 16294
		private static readonly IntPtr NativeFieldInfoPtr_AutoOpenForPlayer;

		// Token: 0x04003FA7 RID: 16295
		private static readonly IntPtr NativeFieldInfoPtr_InteriorIntObjs;

		// Token: 0x04003FA8 RID: 16296
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorIntObjs;

		// Token: 0x04003FA9 RID: 16297
		private static readonly IntPtr NativeFieldInfoPtr_PlayerBlocker;

		// Token: 0x04003FAA RID: 16298
		private static readonly IntPtr NativeFieldInfoPtr_InteriorDoorHandleAnimation;

		// Token: 0x04003FAB RID: 16299
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorDoorHandleAnimation;

		// Token: 0x04003FAC RID: 16300
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnSleep;

		// Token: 0x04003FAD RID: 16301
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnDistantPlayer;

		// Token: 0x04003FAE RID: 16302
		private static readonly IntPtr NativeFieldInfoPtr_OpenableByNPCs;

		// Token: 0x04003FAF RID: 16303
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToOriginalTime;

		// Token: 0x04003FB0 RID: 16304
		private static readonly IntPtr NativeFieldInfoPtr_onDoorOpened;

		// Token: 0x04003FB1 RID: 16305
		private static readonly IntPtr NativeFieldInfoPtr_onDoorClosed;

		// Token: 0x04003FB2 RID: 16306
		private static readonly IntPtr NativeFieldInfoPtr_lastOpenSide;

		// Token: 0x04003FB3 RID: 16307
		private static readonly IntPtr NativeFieldInfoPtr__openedByNPC_k__BackingField;

		// Token: 0x04003FB4 RID: 16308
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField;

		// Token: 0x04003FB5 RID: 16309
		private static readonly IntPtr NativeFieldInfoPtr_autoOpenedForPlayer;

		// Token: 0x04003FB6 RID: 16310
		private static readonly IntPtr NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField;

		// Token: 0x04003FB7 RID: 16311
		private static readonly IntPtr NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField;

		// Token: 0x04003FB8 RID: 16312
		private static readonly IntPtr NativeFieldInfoPtr__timeInCurrentState_k__BackingField;

		// Token: 0x04003FB9 RID: 16313
		private static readonly IntPtr NativeFieldInfoPtr_noAccessErrorMessage;

		// Token: 0x04003FBA RID: 16314
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003FBB RID: 16315
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003FBC RID: 16316
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003FBD RID: 16317
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04003FBE RID: 16318
		private static readonly IntPtr NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0;

		// Token: 0x04003FBF RID: 16319
		private static readonly IntPtr NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0;

		// Token: 0x04003FC0 RID: 16320
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0;

		// Token: 0x04003FC1 RID: 16321
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0;

		// Token: 0x04003FC2 RID: 16322
		private static readonly IntPtr NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0;

		// Token: 0x04003FC3 RID: 16323
		private static readonly IntPtr NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0;

		// Token: 0x04003FC4 RID: 16324
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0;

		// Token: 0x04003FC5 RID: 16325
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0;

		// Token: 0x04003FC6 RID: 16326
		private static readonly IntPtr NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0;

		// Token: 0x04003FC7 RID: 16327
		private static readonly IntPtr NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0;

		// Token: 0x04003FC8 RID: 16328
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003FC9 RID: 16329
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04003FCA RID: 16330
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04003FCB RID: 16331
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003FCC RID: 16332
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003FCD RID: 16333
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003FCE RID: 16334
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003FCF RID: 16335
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003FD0 RID: 16336
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0;

		// Token: 0x04003FD1 RID: 16337
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04003FD2 RID: 16338
		private static readonly IntPtr NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003FD3 RID: 16339
		private static readonly IntPtr NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FD6 RID: 16342
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0;

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__42_0_Private_Void_0;

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FE4 RID: 16356
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
