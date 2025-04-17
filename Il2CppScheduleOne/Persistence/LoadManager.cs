using System;
using Il2CppFishNet.Transporting;
using Il2CppFishNet.Transporting.Yak;
using Il2CppFishySteamworks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.ItemLoaders;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021C RID: 540
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x06002CB7 RID: 11447 RVA: 0x000FE8A8 File Offset: 0x000FCAA8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadManager()
		{
			Il2CppClassPointerStore<LoadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager>.NativeClassPtr);
			LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOADS_PER_FRAME");
			LoadManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "DEBUG");
			LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOAD_ERROR_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NETWORK_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_LoadHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LoadHistory");
			LoadManager.NativeFieldInfoPtr_SaveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "SaveGames");
			LoadManager.NativeFieldInfoPtr_LastPlayedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LastPlayedGame");
			LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsLoading>k__BackingField");
			LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<TimeSinceGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<DebugMode>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadStatus>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadedGameFolderPath>k__BackingField");
			LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<ActiveSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<StoredSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr_loadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "loadRequests");
			LoadManager.NativeFieldInfoPtr_ItemLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ItemLoaders");
			LoadManager.NativeFieldInfoPtr_ObjectLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ObjectLoaders");
			LoadManager.NativeFieldInfoPtr_NPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NPCLoaders");
			LoadManager.NativeFieldInfoPtr_onPreSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreSceneChange");
			LoadManager.NativeFieldInfoPtr_onPreLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreLoad");
			LoadManager.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onLoadComplete");
			LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onSaveInfoLoaded");
			LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668347);
			LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668348);
			LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668349);
			LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668350);
			LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668351);
			LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668352);
			LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668353);
			LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668354);
			LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668355);
			LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668356);
			LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668357);
			LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668358);
			LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668359);
			LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668360);
			LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668361);
			LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668362);
			LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668363);
			LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668364);
			LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668365);
			LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668366);
			LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668367);
			LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668368);
			LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668369);
			LoadManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668370);
			LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668371);
			LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668372);
			LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668373);
			LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668374);
			LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668375);
			LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668376);
			LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668377);
			LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668378);
			LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668379);
			LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668380);
			LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668381);
			LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668382);
			LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668383);
			LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668384);
			LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668385);
			LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668386);
			LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668388);
			LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668389);
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000FEDEC File Offset: 0x000FCFEC
		public unsafe string DefaultTutorialSaveFolder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 125434, RefRangeEnd = 125436, XrefRangeStart = 125424, XrefRangeEnd = 125434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000FEE24 File Offset: 0x000FD024
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x000FEE60 File Offset: 0x000FD060
		public unsafe bool IsGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000FEEA0 File Offset: 0x000FD0A0
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x000FEEDC File Offset: 0x000FD0DC
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000FEF1C File Offset: 0x000FD11C
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x000FEF58 File Offset: 0x000FD158
		public unsafe float TimeSinceGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106207, RefRangeEnd = 106209, XrefRangeStart = 106207, XrefRangeEnd = 106209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000FEF98 File Offset: 0x000FD198
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x000FEFD4 File Offset: 0x000FD1D4
		public unsafe bool DebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000FF014 File Offset: 0x000FD214
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000FF050 File Offset: 0x000FD250
		public unsafe LoadManager.ELoadStatus LoadStatus
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45633, RefRangeEnd = 45634, XrefRangeStart = 45633, XrefRangeEnd = 45634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000FF090 File Offset: 0x000FD290
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x000FF0C8 File Offset: 0x000FD2C8
		public unsafe string LoadedGameFolderPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000FF10C File Offset: 0x000FD30C
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000FF14C File Offset: 0x000FD34C
		public unsafe SaveInfo ActiveSaveInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000FF190 File Offset: 0x000FD390
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x000FF1D0 File Offset: 0x000FD3D0
		public unsafe SaveInfo StoredSaveInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000FF214 File Offset: 0x000FD414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125436, XrefRangeEnd = 125439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000FF250 File Offset: 0x000FD450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125439, XrefRangeEnd = 125557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000FF28C File Offset: 0x000FD48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125607, RefRangeEnd = 125608, XrefRangeStart = 125557, XrefRangeEnd = 125607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bananas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000FF2C0 File Offset: 0x000FD4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125608, XrefRangeEnd = 125652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeItemLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000FF2F4 File Offset: 0x000FD4F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125728, RefRangeEnd = 125729, XrefRangeStart = 125652, XrefRangeEnd = 125728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeObjectLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000FF328 File Offset: 0x000FD528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125729, XrefRangeEnd = 125753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeNPCLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000FF35C File Offset: 0x000FD55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125753, XrefRangeEnd = 125794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000FF390 File Offset: 0x000FD590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125794, XrefRangeEnd = 125800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000FF3D4 File Offset: 0x000FD5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125800, XrefRangeEnd = 125804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000FF418 File Offset: 0x000FD618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125804, XrefRangeEnd = 125825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader GetItemLoader(string itemType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000FF468 File Offset: 0x000FD668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125825, XrefRangeEnd = 125846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader GetObjectLoader(string objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000FF4B8 File Offset: 0x000FD6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125867, RefRangeEnd = 125868, XrefRangeStart = 125846, XrefRangeEnd = 125867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader GetNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000FF508 File Offset: 0x000FD708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125875, RefRangeEnd = 125876, XrefRangeStart = 125868, XrefRangeEnd = 125875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLoadStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000FF540 File Offset: 0x000FD740
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125895, RefRangeEnd = 125899, XrefRangeStart = 125876, XrefRangeEnd = 125895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(SaveInfo info, bool allowLoadStacking = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLoadStacking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000FF590 File Offset: 0x000FD790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125918, RefRangeEnd = 125919, XrefRangeStart = 125899, XrefRangeEnd = 125918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTutorialAsClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000FF5C4 File Offset: 0x000FD7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125939, RefRangeEnd = 125940, XrefRangeStart = 125919, XrefRangeEnd = 125939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000FF608 File Offset: 0x000FD808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125940, XrefRangeEnd = 125946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoadErrorAutosubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000FF63C File Offset: 0x000FD83C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125946, RefRangeEnd = 125948, XrefRangeStart = 125946, XrefRangeEnd = 125946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitingForHostLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000FF670 File Offset: 0x000FD870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125948, XrefRangeEnd = 125955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLastSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000FF6A4 File Offset: 0x000FD8A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126030, RefRangeEnd = 126033, XrefRangeStart = 125955, XrefRangeEnd = 126030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000FF6D8 File Offset: 0x000FD8D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 126093, RefRangeEnd = 126100, XrefRangeStart = 126033, XrefRangeEnd = 126093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoLoadSave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainMenuPopup);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preventLeaveLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000FF73C File Offset: 0x000FD93C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126292, RefRangeEnd = 126294, XrefRangeStart = 126100, XrefRangeEnd = 126292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSaveInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000FF770 File Offset: 0x000FD970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126294, XrefRangeEnd = 126328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000FF7AC File Offset: 0x000FD9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126328, XrefRangeEnd = 126354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000FF7D4 File Offset: 0x000FD9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126354, XrefRangeEnd = 126359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000180E3 File Offset: 0x000162E3
		public LoadManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000FF814 File Offset: 0x000FDA14
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x000180EC File Offset: 0x000162EC
		public unsafe static int LOADS_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000FF830 File Offset: 0x000FDA30
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x000180FA File Offset: 0x000162FA
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000FF84C File Offset: 0x000FDA4C
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x00018108 File Offset: 0x00016308
		public unsafe static float LOAD_ERROR_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000FF868 File Offset: 0x000FDA68
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00018116 File Offset: 0x00016316
		public unsafe static float NETWORK_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000FF884 File Offset: 0x000FDA84
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x00018124 File Offset: 0x00016324
		public unsafe static List<string> LoadHistory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LoadHistory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LoadHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x000FF8AC File Offset: 0x000FDAAC
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x00018136 File Offset: 0x00016336
		public unsafe static Il2CppReferenceArray<SaveInfo> SaveGames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_SaveGames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SaveInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_SaveGames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000FF8D4 File Offset: 0x000FDAD4
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x00018148 File Offset: 0x00016348
		public unsafe static SaveInfo LastPlayedGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000FF8FC File Offset: 0x000FDAFC
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x0001815A File Offset: 0x0001635A
		public unsafe bool _IsGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000FF924 File Offset: 0x000FDB24
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00018175 File Offset: 0x00016375
		public unsafe bool _IsLoading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000FF94C File Offset: 0x000FDB4C
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x00018190 File Offset: 0x00016390
		public unsafe float _TimeSinceGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000FF974 File Offset: 0x000FDB74
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x000181AB File Offset: 0x000163AB
		public unsafe bool _DebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000FF99C File Offset: 0x000FDB9C
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000181C6 File Offset: 0x000163C6
		public unsafe LoadManager.ELoadStatus _LoadStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000FF9C4 File Offset: 0x000FDBC4
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x000181E1 File Offset: 0x000163E1
		public unsafe string _LoadedGameFolderPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000FF9EC File Offset: 0x000FDBEC
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00018200 File Offset: 0x00016400
		public unsafe SaveInfo _ActiveSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000FFA1C File Offset: 0x000FDC1C
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x0001821F File Offset: 0x0001641F
		public unsafe SaveInfo _StoredSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000FFA4C File Offset: 0x000FDC4C
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x0001823E File Offset: 0x0001643E
		public unsafe List<LoadRequest> loadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoadRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x000FFA7C File Offset: 0x000FDC7C
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x0001825D File Offset: 0x0001645D
		public unsafe List<ItemLoader> ItemLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000FFAAC File Offset: 0x000FDCAC
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x0001827C File Offset: 0x0001647C
		public unsafe List<BuildableItemLoader> ObjectLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x000FFADC File Offset: 0x000FDCDC
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x0001829B File Offset: 0x0001649B
		public unsafe List<NPCLoader> NPCLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000FFB0C File Offset: 0x000FDD0C
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x000182BA File Offset: 0x000164BA
		public unsafe UnityEvent onPreSceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000FFB3C File Offset: 0x000FDD3C
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x000182D9 File Offset: 0x000164D9
		public unsafe UnityEvent onPreLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000FFB6C File Offset: 0x000FDD6C
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x000182F8 File Offset: 0x000164F8
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000FFB9C File Offset: 0x000FDD9C
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x00018317 File Offset: 0x00016517
		public unsafe UnityEvent onSaveInfoLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_LOADS_PER_FRAME;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_NETWORK_TIMEOUT;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_LoadHistory;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr_SaveGames;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedGame;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeFieldInfoPtr__IsGameLoaded_k__BackingField;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr__IsLoading_k__BackingField;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr__DebugMode_k__BackingField;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr__LoadStatus_k__BackingField;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr__StoredSaveInfo_k__BackingField;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeFieldInfoPtr_loadRequests;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeFieldInfoPtr_ItemLoaders;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeFieldInfoPtr_ObjectLoaders;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeFieldInfoPtr_NPCLoaders;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeFieldInfoPtr_onPreSceneChange;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeFieldInfoPtr_onPreLoad;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr_onSaveInfoLoaded;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_Bananas_Private_Void_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadStatusText_Public_String_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_LoadLastSave_Public_Void_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008EB RID: 2283
		[OriginalName("Assembly-CSharp.dll", "", "ELoadStatus")]
		public enum ELoadStatus
		{
			// Token: 0x04008566 RID: 34150
			None,
			// Token: 0x04008567 RID: 34151
			LoadingScene,
			// Token: 0x04008568 RID: 34152
			Initializing,
			// Token: 0x04008569 RID: 34153
			LoadingData,
			// Token: 0x0400856A RID: 34154
			SpawningPlayer,
			// Token: 0x0400856B RID: 34155
			WaitingForHost
		}

		// Token: 0x020008EC RID: 2284
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<<StartLoadErrorAutosubmit>g__Wait|66_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C4BD RID: 50365 RVA: 0x002FE720 File Offset: 0x002FC920
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique()
			{
				Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<<StartLoadErrorAutosubmit>g__Wait|66_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<t>5__2");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668390);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668391);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668392);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668393);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668394);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668395);
			}

			// Token: 0x0600C4BE RID: 50366 RVA: 0x002FE814 File Offset: 0x002FCA14
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4BF RID: 50367 RVA: 0x002FE85C File Offset: 0x002FCA5C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4C0 RID: 50368 RVA: 0x002FE890 File Offset: 0x002FCA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124556, XrefRangeEnd = 124569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D6D RID: 15725
			// (get) Token: 0x0600C4C1 RID: 50369 RVA: 0x002FE8CC File Offset: 0x002FCACC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4C2 RID: 50370 RVA: 0x002FE90C File Offset: 0x002FCB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124569, XrefRangeEnd = 124574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D6E RID: 15726
			// (get) Token: 0x0600C4C3 RID: 50371 RVA: 0x002FE940 File Offset: 0x002FCB40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4C4 RID: 50372 RVA: 0x0005FBE5 File Offset: 0x0005DDE5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D69 RID: 15721
			// (get) Token: 0x0600C4C5 RID: 50373 RVA: 0x002FE980 File Offset: 0x002FCB80
			// (set) Token: 0x0600C4C6 RID: 50374 RVA: 0x0005FBEE File Offset: 0x0005DDEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D6A RID: 15722
			// (get) Token: 0x0600C4C7 RID: 50375 RVA: 0x002FE9A8 File Offset: 0x002FCBA8
			// (set) Token: 0x0600C4C8 RID: 50376 RVA: 0x0005FC09 File Offset: 0x0005DE09
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D6B RID: 15723
			// (get) Token: 0x0600C4C9 RID: 50377 RVA: 0x002FE9D8 File Offset: 0x002FCBD8
			// (set) Token: 0x0600C4CA RID: 50378 RVA: 0x0005FC28 File Offset: 0x0005DE28
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D6C RID: 15724
			// (get) Token: 0x0600C4CB RID: 50379 RVA: 0x002FEA08 File Offset: 0x002FCC08
			// (set) Token: 0x0600C4CC RID: 50380 RVA: 0x0005FC47 File Offset: 0x0005DE47
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x0400856C RID: 34156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400856D RID: 34157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400856E RID: 34158
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400856F RID: 34159
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x04008570 RID: 34160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008571 RID: 34161
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008572 RID: 34162
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008573 RID: 34163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008574 RID: 34164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008575 RID: 34165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008ED RID: 2285
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C4CD RID: 50381 RVA: 0x002FEA30 File Offset: 0x002FCC30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr);
				LoadManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9");
				LoadManager.__c.NativeFieldInfoPtr___9__63_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_5");
				LoadManager.__c.NativeFieldInfoPtr___9__63_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_1");
				LoadManager.__c.NativeFieldInfoPtr___9__63_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_2");
				LoadManager.__c.NativeFieldInfoPtr___9__64_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_2");
				LoadManager.__c.NativeFieldInfoPtr___9__64_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_3");
				LoadManager.__c.NativeFieldInfoPtr___9__64_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_4");
				LoadManager.__c.NativeFieldInfoPtr___9__65_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_2");
				LoadManager.__c.NativeFieldInfoPtr___9__65_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_3");
				LoadManager.__c.NativeFieldInfoPtr___9__65_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_4");
				LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668397);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668398);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668399);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668400);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668401);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668402);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668403);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668404);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668405);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668406);
			}

			// Token: 0x0600C4CE RID: 50382 RVA: 0x002FEBEC File Offset: 0x002FCDEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4CF RID: 50383 RVA: 0x002FEC28 File Offset: 0x002FCE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124574, XrefRangeEnd = 124575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D0 RID: 50384 RVA: 0x002FEC64 File Offset: 0x002FCE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124575, XrefRangeEnd = 124578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D1 RID: 50385 RVA: 0x002FECA0 File Offset: 0x002FCEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124578, XrefRangeEnd = 124586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D2 RID: 50386 RVA: 0x002FECDC File Offset: 0x002FCEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D3 RID: 50387 RVA: 0x002FED18 File Offset: 0x002FCF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D4 RID: 50388 RVA: 0x002FED54 File Offset: 0x002FCF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124586, XrefRangeEnd = 124594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D5 RID: 50389 RVA: 0x002FED90 File Offset: 0x002FCF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124594, XrefRangeEnd = 124602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D6 RID: 50390 RVA: 0x002FEDCC File Offset: 0x002FCFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124602, XrefRangeEnd = 124610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D7 RID: 50391 RVA: 0x002FEE08 File Offset: 0x002FD008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124610, XrefRangeEnd = 124614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4D8 RID: 50392 RVA: 0x0005FC62 File Offset: 0x0005DE62
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D6F RID: 15727
			// (get) Token: 0x0600C4D9 RID: 50393 RVA: 0x002FEE44 File Offset: 0x002FD044
			// (set) Token: 0x0600C4DA RID: 50394 RVA: 0x0005FC6B File Offset: 0x0005DE6B
			public unsafe static LoadManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D70 RID: 15728
			// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x002FEE6C File Offset: 0x002FD06C
			// (set) Token: 0x0600C4DC RID: 50396 RVA: 0x0005FC7D File Offset: 0x0005DE7D
			public unsafe static Func<bool> __9__63_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x0600C4DD RID: 50397 RVA: 0x002FEE94 File Offset: 0x002FD094
			// (set) Token: 0x0600C4DE RID: 50398 RVA: 0x0005FC8F File Offset: 0x0005DE8F
			public unsafe static Func<bool> __9__63_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D72 RID: 15730
			// (get) Token: 0x0600C4DF RID: 50399 RVA: 0x002FEEBC File Offset: 0x002FD0BC
			// (set) Token: 0x0600C4E0 RID: 50400 RVA: 0x0005FCA1 File Offset: 0x0005DEA1
			public unsafe static Func<bool> __9__63_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D73 RID: 15731
			// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x002FEEE4 File Offset: 0x002FD0E4
			// (set) Token: 0x0600C4E2 RID: 50402 RVA: 0x0005FCB3 File Offset: 0x0005DEB3
			public unsafe static Func<bool> __9__64_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D74 RID: 15732
			// (get) Token: 0x0600C4E3 RID: 50403 RVA: 0x002FEF0C File Offset: 0x002FD10C
			// (set) Token: 0x0600C4E4 RID: 50404 RVA: 0x0005FCC5 File Offset: 0x0005DEC5
			public unsafe static Func<bool> __9__64_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D75 RID: 15733
			// (get) Token: 0x0600C4E5 RID: 50405 RVA: 0x002FEF34 File Offset: 0x002FD134
			// (set) Token: 0x0600C4E6 RID: 50406 RVA: 0x0005FCD7 File Offset: 0x0005DED7
			public unsafe static Func<bool> __9__64_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D76 RID: 15734
			// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x002FEF5C File Offset: 0x002FD15C
			// (set) Token: 0x0600C4E8 RID: 50408 RVA: 0x0005FCE9 File Offset: 0x0005DEE9
			public unsafe static Func<bool> __9__65_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D77 RID: 15735
			// (get) Token: 0x0600C4E9 RID: 50409 RVA: 0x002FEF84 File Offset: 0x002FD184
			// (set) Token: 0x0600C4EA RID: 50410 RVA: 0x0005FCFB File Offset: 0x0005DEFB
			public unsafe static Func<bool> __9__65_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D78 RID: 15736
			// (get) Token: 0x0600C4EB RID: 50411 RVA: 0x002FEFAC File Offset: 0x002FD1AC
			// (set) Token: 0x0600C4EC RID: 50412 RVA: 0x0005FD0D File Offset: 0x0005DF0D
			public unsafe static Func<bool> __9__65_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008576 RID: 34166
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008577 RID: 34167
			private static readonly IntPtr NativeFieldInfoPtr___9__63_5;

			// Token: 0x04008578 RID: 34168
			private static readonly IntPtr NativeFieldInfoPtr___9__63_1;

			// Token: 0x04008579 RID: 34169
			private static readonly IntPtr NativeFieldInfoPtr___9__63_2;

			// Token: 0x0400857A RID: 34170
			private static readonly IntPtr NativeFieldInfoPtr___9__64_2;

			// Token: 0x0400857B RID: 34171
			private static readonly IntPtr NativeFieldInfoPtr___9__64_3;

			// Token: 0x0400857C RID: 34172
			private static readonly IntPtr NativeFieldInfoPtr___9__64_4;

			// Token: 0x0400857D RID: 34173
			private static readonly IntPtr NativeFieldInfoPtr___9__65_2;

			// Token: 0x0400857E RID: 34174
			private static readonly IntPtr NativeFieldInfoPtr___9__65_3;

			// Token: 0x0400857F RID: 34175
			private static readonly IntPtr NativeFieldInfoPtr___9__65_4;

			// Token: 0x04008580 RID: 34176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008581 RID: 34177
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0;

			// Token: 0x04008582 RID: 34178
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0;

			// Token: 0x04008583 RID: 34179
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0;

			// Token: 0x04008584 RID: 34180
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0;

			// Token: 0x04008585 RID: 34181
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0;

			// Token: 0x04008586 RID: 34182
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0;

			// Token: 0x04008587 RID: 34183
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0;

			// Token: 0x04008588 RID: 34184
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0;

			// Token: 0x04008589 RID: 34185
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0;
		}

		// Token: 0x020008EE RID: 2286
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C4ED RID: 50413 RVA: 0x002FEFD4 File Offset: 0x002FD1D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, "itemType");
				LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, 100668407);
				LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, 100668408);
			}

			// Token: 0x0600C4EE RID: 50414 RVA: 0x002FF03C File Offset: 0x002FD23C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4EF RID: 50415 RVA: 0x002FF078 File Offset: 0x002FD278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124614, XrefRangeEnd = 124616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetItemLoader_b__0(ItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4F0 RID: 50416 RVA: 0x0005FD1F File Offset: 0x0005DF1F
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D79 RID: 15737
			// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x002FF0C8 File Offset: 0x002FD2C8
			// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x0005FD28 File Offset: 0x0005DF28
			public unsafe string itemType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400858A RID: 34186
			private static readonly IntPtr NativeFieldInfoPtr_itemType;

			// Token: 0x0400858B RID: 34187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400858C RID: 34188
			private static readonly IntPtr NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0;
		}

		// Token: 0x020008EF RID: 2287
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C4F3 RID: 50419 RVA: 0x002FF0F0 File Offset: 0x002FD2F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, "objectType");
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668409);
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668410);
			}

			// Token: 0x0600C4F4 RID: 50420 RVA: 0x002FF158 File Offset: 0x002FD358
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4F5 RID: 50421 RVA: 0x002FF194 File Offset: 0x002FD394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124616, XrefRangeEnd = 124618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetObjectLoader_b__0(BuildableItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4F6 RID: 50422 RVA: 0x0005FD47 File Offset: 0x0005DF47
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D7A RID: 15738
			// (get) Token: 0x0600C4F7 RID: 50423 RVA: 0x002FF1E4 File Offset: 0x002FD3E4
			// (set) Token: 0x0600C4F8 RID: 50424 RVA: 0x0005FD50 File Offset: 0x0005DF50
			public unsafe string objectType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400858D RID: 34189
			private static readonly IntPtr NativeFieldInfoPtr_objectType;

			// Token: 0x0400858E RID: 34190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400858F RID: 34191
			private static readonly IntPtr NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0;
		}

		// Token: 0x020008F0 RID: 2288
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C4F9 RID: 50425 RVA: 0x002FF20C File Offset: 0x002FD40C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668411);
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668412);
			}

			// Token: 0x0600C4FA RID: 50426 RVA: 0x002FF274 File Offset: 0x002FD474
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4FB RID: 50427 RVA: 0x002FF2B0 File Offset: 0x002FD4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetNPCLoader_b__0(NPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4FC RID: 50428 RVA: 0x0005FD6F File Offset: 0x0005DF6F
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D7B RID: 15739
			// (get) Token: 0x0600C4FD RID: 50429 RVA: 0x002FF300 File Offset: 0x002FD500
			// (set) Token: 0x0600C4FE RID: 50430 RVA: 0x0005FD78 File Offset: 0x0005DF78
			public unsafe string npcType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008590 RID: 34192
			private static readonly IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x04008591 RID: 34193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008592 RID: 34194
			private static readonly IntPtr NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0;
		}

		// Token: 0x020008F1 RID: 2289
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C4FF RID: 50431 RVA: 0x002FF328 File Offset: 0x002FD528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "info");
				LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668413);
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668414);
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668415);
			}

			// Token: 0x0600C500 RID: 50432 RVA: 0x002FF3B8 File Offset: 0x002FD5B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C501 RID: 50433 RVA: 0x002FF3F4 File Offset: 0x002FD5F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124918, XrefRangeEnd = 124923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C502 RID: 50434 RVA: 0x002FF434 File Offset: 0x002FD634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124923, XrefRangeEnd = 124928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C503 RID: 50435 RVA: 0x0005FD97 File Offset: 0x0005DF97
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D7C RID: 15740
			// (get) Token: 0x0600C504 RID: 50436 RVA: 0x002FF474 File Offset: 0x002FD674
			// (set) Token: 0x0600C505 RID: 50437 RVA: 0x0005FDA0 File Offset: 0x0005DFA0
			public unsafe SaveInfo info
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7D RID: 15741
			// (get) Token: 0x0600C506 RID: 50438 RVA: 0x002FF4A4 File Offset: 0x002FD6A4
			// (set) Token: 0x0600C507 RID: 50439 RVA: 0x0005FDBF File Offset: 0x0005DFBF
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008593 RID: 34195
			private static readonly IntPtr NativeFieldInfoPtr_info;

			// Token: 0x04008594 RID: 34196
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008595 RID: 34197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008596 RID: 34198
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008597 RID: 34199
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C35 RID: 3125
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0+<<StartGame>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E175 RID: 57717 RVA: 0x0034FD68 File Offset: 0x0034DF68
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<<StartGame>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<playingTutorial>5__2");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__3");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<yak>5__4");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668416);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668417);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668418);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668419);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668420);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668421);
				}

				// Token: 0x0600E176 RID: 57718 RVA: 0x0034FE84 File Offset: 0x0034E084
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E177 RID: 57719 RVA: 0x0034FECC File Offset: 0x0034E0CC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E178 RID: 57720 RVA: 0x0034FF00 File Offset: 0x0034E100
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124618, XrefRangeEnd = 124889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045E1 RID: 17889
				// (get) Token: 0x0600E179 RID: 57721 RVA: 0x0034FF3C File Offset: 0x0034E13C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E17A RID: 57722 RVA: 0x0034FF7C File Offset: 0x0034E17C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124889, XrefRangeEnd = 124894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045E2 RID: 17890
				// (get) Token: 0x0600E17B RID: 57723 RVA: 0x0034FFB0 File Offset: 0x0034E1B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E17C RID: 57724 RVA: 0x0006DEA2 File Offset: 0x0006C0A2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045DB RID: 17883
				// (get) Token: 0x0600E17D RID: 57725 RVA: 0x0034FFF0 File Offset: 0x0034E1F0
				// (set) Token: 0x0600E17E RID: 57726 RVA: 0x0006DEAB File Offset: 0x0006C0AB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045DC RID: 17884
				// (get) Token: 0x0600E17F RID: 57727 RVA: 0x00350018 File Offset: 0x0034E218
				// (set) Token: 0x0600E180 RID: 57728 RVA: 0x0006DEC6 File Offset: 0x0006C0C6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045DD RID: 17885
				// (get) Token: 0x0600E181 RID: 57729 RVA: 0x00350048 File Offset: 0x0034E248
				// (set) Token: 0x0600E182 RID: 57730 RVA: 0x0006DEE5 File Offset: 0x0006C0E5
				public unsafe LoadManager.__c__DisplayClass63_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass63_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045DE RID: 17886
				// (get) Token: 0x0600E183 RID: 57731 RVA: 0x00350078 File Offset: 0x0034E278
				// (set) Token: 0x0600E184 RID: 57732 RVA: 0x0006DF04 File Offset: 0x0006C104
				public unsafe bool _playingTutorial_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2)) = value;
					}
				}

				// Token: 0x170045DF RID: 17887
				// (get) Token: 0x0600E185 RID: 57733 RVA: 0x003500A0 File Offset: 0x0034E2A0
				// (set) Token: 0x0600E186 RID: 57734 RVA: 0x0006DF1F File Offset: 0x0006C11F
				public unsafe AsyncOperation _asyncLoad_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045E0 RID: 17888
				// (get) Token: 0x0600E187 RID: 57735 RVA: 0x003500D0 File Offset: 0x0034E2D0
				// (set) Token: 0x0600E188 RID: 57736 RVA: 0x0006DF3E File Offset: 0x0006C13E
				public unsafe Yak _yak_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096F4 RID: 38644
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096F5 RID: 38645
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096F6 RID: 38646
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096F7 RID: 38647
				private static readonly IntPtr NativeFieldInfoPtr__playingTutorial_5__2;

				// Token: 0x040096F8 RID: 38648
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__3;

				// Token: 0x040096F9 RID: 38649
				private static readonly IntPtr NativeFieldInfoPtr__yak_5__4;

				// Token: 0x040096FA RID: 38650
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096FB RID: 38651
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096FC RID: 38652
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096FD RID: 38653
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096FE RID: 38654
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096FF RID: 38655
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C36 RID: 3126
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0+<<StartGame>g__Load|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E189 RID: 57737 RVA: 0x00350100 File Offset: 0x0034E300
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<<StartGame>g__Load|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668422);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668423);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668424);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668425);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668426);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668427);
				}

				// Token: 0x0600E18A RID: 57738 RVA: 0x003501E0 File Offset: 0x0034E3E0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E18B RID: 57739 RVA: 0x00350228 File Offset: 0x0034E428
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E18C RID: 57740 RVA: 0x0035025C File Offset: 0x0034E45C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124894, XrefRangeEnd = 124913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045E6 RID: 17894
				// (get) Token: 0x0600E18D RID: 57741 RVA: 0x00350298 File Offset: 0x0034E498
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E18E RID: 57742 RVA: 0x003502D8 File Offset: 0x0034E4D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124913, XrefRangeEnd = 124918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045E7 RID: 17895
				// (get) Token: 0x0600E18F RID: 57743 RVA: 0x0035030C File Offset: 0x0034E50C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E190 RID: 57744 RVA: 0x0006DF5D File Offset: 0x0006C15D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045E3 RID: 17891
				// (get) Token: 0x0600E191 RID: 57745 RVA: 0x0035034C File Offset: 0x0034E54C
				// (set) Token: 0x0600E192 RID: 57746 RVA: 0x0006DF66 File Offset: 0x0006C166
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045E4 RID: 17892
				// (get) Token: 0x0600E193 RID: 57747 RVA: 0x00350374 File Offset: 0x0034E574
				// (set) Token: 0x0600E194 RID: 57748 RVA: 0x0006DF81 File Offset: 0x0006C181
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045E5 RID: 17893
				// (get) Token: 0x0600E195 RID: 57749 RVA: 0x003503A4 File Offset: 0x0034E5A4
				// (set) Token: 0x0600E196 RID: 57750 RVA: 0x0006DFA0 File Offset: 0x0006C1A0
				public unsafe LoadManager.__c__DisplayClass63_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass63_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009700 RID: 38656
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009701 RID: 38657
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009702 RID: 38658
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009703 RID: 38659
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009704 RID: 38660
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009705 RID: 38661
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009706 RID: 38662
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009707 RID: 38663
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009708 RID: 38664
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F2 RID: 2290
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_1")]
		public sealed class __c__DisplayClass63_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C508 RID: 50440 RVA: 0x002FF4D4 File Offset: 0x002FD6D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass63_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, "fishy");
				LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, "port");
				LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, 100668428);
				LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, 100668429);
			}

			// Token: 0x0600C509 RID: 50441 RVA: 0x002FF550 File Offset: 0x002FD750
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C50A RID: 50442 RVA: 0x002FF58C File Offset: 0x002FD78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124928, XrefRangeEnd = 124968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ServerConnectionStateArgs_PDM_0(ServerConnectionStateArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref args;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C50B RID: 50443 RVA: 0x0005FDDE File Offset: 0x0005DFDE
			public __c__DisplayClass63_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D7E RID: 15742
			// (get) Token: 0x0600C50C RID: 50444 RVA: 0x002FF5CC File Offset: 0x002FD7CC
			// (set) Token: 0x0600C50D RID: 50445 RVA: 0x0005FDE7 File Offset: 0x0005DFE7
			public unsafe FishySteamworks fishy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishySteamworks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7F RID: 15743
			// (get) Token: 0x0600C50E RID: 50446 RVA: 0x002FF5FC File Offset: 0x002FD7FC
			// (set) Token: 0x0600C50F RID: 50447 RVA: 0x0005FE06 File Offset: 0x0005E006
			public unsafe ushort port
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port)) = value;
				}
			}

			// Token: 0x04008598 RID: 34200
			private static readonly IntPtr NativeFieldInfoPtr_fishy;

			// Token: 0x04008599 RID: 34201
			private static readonly IntPtr NativeFieldInfoPtr_port;

			// Token: 0x0400859A RID: 34202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400859B RID: 34203
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0;
		}

		// Token: 0x020008F3 RID: 2291
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C510 RID: 50448 RVA: 0x002FF624 File Offset: 0x002FD824
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668430);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668431);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668432);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668433);
			}

			// Token: 0x0600C511 RID: 50449 RVA: 0x002FF6C8 File Offset: 0x002FD8C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C512 RID: 50450 RVA: 0x002FF704 File Offset: 0x002FD904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125185, XrefRangeEnd = 125190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C513 RID: 50451 RVA: 0x002FF744 File Offset: 0x002FD944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125190, XrefRangeEnd = 125192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C514 RID: 50452 RVA: 0x002FF780 File Offset: 0x002FD980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125192, XrefRangeEnd = 125197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C515 RID: 50453 RVA: 0x0005FE21 File Offset: 0x0005E021
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D80 RID: 15744
			// (get) Token: 0x0600C516 RID: 50454 RVA: 0x002FF7C0 File Offset: 0x002FD9C0
			// (set) Token: 0x0600C517 RID: 50455 RVA: 0x0005FE2A File Offset: 0x0005E02A
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003D81 RID: 15745
			// (get) Token: 0x0600C518 RID: 50456 RVA: 0x002FF7E8 File Offset: 0x002FD9E8
			// (set) Token: 0x0600C519 RID: 50457 RVA: 0x0005FE45 File Offset: 0x0005E045
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400859C RID: 34204
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x0400859D RID: 34205
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400859E RID: 34206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400859F RID: 34207
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040085A0 RID: 34208
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0;

			// Token: 0x040085A1 RID: 34209
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C37 RID: 3127
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0+<<LoadTutorialAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E197 RID: 57751 RVA: 0x003503D4 File Offset: 0x0034E5D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<yak>5__3");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668434);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668435);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668436);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668437);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668438);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668439);
				}

				// Token: 0x0600E198 RID: 57752 RVA: 0x003504DC File Offset: 0x0034E6DC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E199 RID: 57753 RVA: 0x00350524 File Offset: 0x0034E724
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E19A RID: 57754 RVA: 0x00350558 File Offset: 0x0034E758
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124968, XrefRangeEnd = 125156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045ED RID: 17901
				// (get) Token: 0x0600E19B RID: 57755 RVA: 0x00350594 File Offset: 0x0034E794
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E19C RID: 57756 RVA: 0x003505D4 File Offset: 0x0034E7D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125156, XrefRangeEnd = 125161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045EE RID: 17902
				// (get) Token: 0x0600E19D RID: 57757 RVA: 0x00350608 File Offset: 0x0034E808
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E19E RID: 57758 RVA: 0x0006DFBF File Offset: 0x0006C1BF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045E8 RID: 17896
				// (get) Token: 0x0600E19F RID: 57759 RVA: 0x00350648 File Offset: 0x0034E848
				// (set) Token: 0x0600E1A0 RID: 57760 RVA: 0x0006DFC8 File Offset: 0x0006C1C8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045E9 RID: 17897
				// (get) Token: 0x0600E1A1 RID: 57761 RVA: 0x00350670 File Offset: 0x0034E870
				// (set) Token: 0x0600E1A2 RID: 57762 RVA: 0x0006DFE3 File Offset: 0x0006C1E3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045EA RID: 17898
				// (get) Token: 0x0600E1A3 RID: 57763 RVA: 0x003506A0 File Offset: 0x0034E8A0
				// (set) Token: 0x0600E1A4 RID: 57764 RVA: 0x0006E002 File Offset: 0x0006C202
				public unsafe LoadManager.__c__DisplayClass64_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass64_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045EB RID: 17899
				// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x003506D0 File Offset: 0x0034E8D0
				// (set) Token: 0x0600E1A6 RID: 57766 RVA: 0x0006E021 File Offset: 0x0006C221
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045EC RID: 17900
				// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x00350700 File Offset: 0x0034E900
				// (set) Token: 0x0600E1A8 RID: 57768 RVA: 0x0006E040 File Offset: 0x0006C240
				public unsafe Yak _yak_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009709 RID: 38665
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400970A RID: 38666
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400970B RID: 38667
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400970C RID: 38668
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400970D RID: 38669
				private static readonly IntPtr NativeFieldInfoPtr__yak_5__3;

				// Token: 0x0400970E RID: 38670
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400970F RID: 38671
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009710 RID: 38672
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009711 RID: 38673
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009712 RID: 38674
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009713 RID: 38675
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C38 RID: 3128
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0+<<LoadTutorialAsClient>g__Load|5>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1A9 RID: 57769 RVA: 0x00350730 File Offset: 0x0034E930
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__Load|5>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668440);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668441);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668442);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668443);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668444);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668445);
				}

				// Token: 0x0600E1AA RID: 57770 RVA: 0x00350810 File Offset: 0x0034EA10
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1AB RID: 57771 RVA: 0x00350858 File Offset: 0x0034EA58
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1AC RID: 57772 RVA: 0x0035088C File Offset: 0x0034EA8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125161, XrefRangeEnd = 125180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045F2 RID: 17906
				// (get) Token: 0x0600E1AD RID: 57773 RVA: 0x003508C8 File Offset: 0x0034EAC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1AE RID: 57774 RVA: 0x00350908 File Offset: 0x0034EB08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125180, XrefRangeEnd = 125185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045F3 RID: 17907
				// (get) Token: 0x0600E1AF RID: 57775 RVA: 0x0035093C File Offset: 0x0034EB3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1B0 RID: 57776 RVA: 0x0006E05F File Offset: 0x0006C25F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045EF RID: 17903
				// (get) Token: 0x0600E1B1 RID: 57777 RVA: 0x0035097C File Offset: 0x0034EB7C
				// (set) Token: 0x0600E1B2 RID: 57778 RVA: 0x0006E068 File Offset: 0x0006C268
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045F0 RID: 17904
				// (get) Token: 0x0600E1B3 RID: 57779 RVA: 0x003509A4 File Offset: 0x0034EBA4
				// (set) Token: 0x0600E1B4 RID: 57780 RVA: 0x0006E083 File Offset: 0x0006C283
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F1 RID: 17905
				// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x003509D4 File Offset: 0x0034EBD4
				// (set) Token: 0x0600E1B6 RID: 57782 RVA: 0x0006E0A2 File Offset: 0x0006C2A2
				public unsafe LoadManager.__c__DisplayClass64_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass64_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009714 RID: 38676
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009715 RID: 38677
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009716 RID: 38678
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009717 RID: 38679
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009718 RID: 38680
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009719 RID: 38681
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400971A RID: 38682
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400971B RID: 38683
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400971C RID: 38684
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F4 RID: 2292
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C51A RID: 50458 RVA: 0x002FF818 File Offset: 0x002FDA18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "steamId64");
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668446);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668447);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668448);
			}

			// Token: 0x0600C51B RID: 50459 RVA: 0x002FF8BC File Offset: 0x002FDABC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C51C RID: 50460 RVA: 0x002FF8F8 File Offset: 0x002FDAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125367, XrefRangeEnd = 125372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C51D RID: 50461 RVA: 0x002FF938 File Offset: 0x002FDB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125372, XrefRangeEnd = 125374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C51E RID: 50462 RVA: 0x0005FE64 File Offset: 0x0005E064
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D82 RID: 15746
			// (get) Token: 0x0600C51F RID: 50463 RVA: 0x002FF974 File Offset: 0x002FDB74
			// (set) Token: 0x0600C520 RID: 50464 RVA: 0x0005FE6D File Offset: 0x0005E06D
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003D83 RID: 15747
			// (get) Token: 0x0600C521 RID: 50465 RVA: 0x002FF99C File Offset: 0x002FDB9C
			// (set) Token: 0x0600C522 RID: 50466 RVA: 0x0005FE88 File Offset: 0x0005E088
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D84 RID: 15748
			// (get) Token: 0x0600C523 RID: 50467 RVA: 0x002FF9CC File Offset: 0x002FDBCC
			// (set) Token: 0x0600C524 RID: 50468 RVA: 0x0005FEA7 File Offset: 0x0005E0A7
			public unsafe string steamId64
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040085A2 RID: 34210
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040085A3 RID: 34211
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085A4 RID: 34212
			private static readonly IntPtr NativeFieldInfoPtr_steamId64;

			// Token: 0x040085A5 RID: 34213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085A6 RID: 34214
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040085A7 RID: 34215
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C39 RID: 3129
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0+<<LoadAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1B7 RID: 57783 RVA: 0x00350A04 File Offset: 0x0034EC04
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<<LoadAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668449);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668450);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668451);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668452);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668453);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668454);
				}

				// Token: 0x0600E1B8 RID: 57784 RVA: 0x00350AE4 File Offset: 0x0034ECE4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1B9 RID: 57785 RVA: 0x00350B2C File Offset: 0x0034ED2C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1BA RID: 57786 RVA: 0x00350B60 File Offset: 0x0034ED60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125197, XrefRangeEnd = 125362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045F7 RID: 17911
				// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x00350B9C File Offset: 0x0034ED9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1BC RID: 57788 RVA: 0x00350BDC File Offset: 0x0034EDDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125362, XrefRangeEnd = 125367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045F8 RID: 17912
				// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x00350C10 File Offset: 0x0034EE10
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1BE RID: 57790 RVA: 0x0006E0C1 File Offset: 0x0006C2C1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045F4 RID: 17908
				// (get) Token: 0x0600E1BF RID: 57791 RVA: 0x00350C50 File Offset: 0x0034EE50
				// (set) Token: 0x0600E1C0 RID: 57792 RVA: 0x0006E0CA File Offset: 0x0006C2CA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045F5 RID: 17909
				// (get) Token: 0x0600E1C1 RID: 57793 RVA: 0x00350C78 File Offset: 0x0034EE78
				// (set) Token: 0x0600E1C2 RID: 57794 RVA: 0x0006E0E5 File Offset: 0x0006C2E5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F6 RID: 17910
				// (get) Token: 0x0600E1C3 RID: 57795 RVA: 0x00350CA8 File Offset: 0x0034EEA8
				// (set) Token: 0x0600E1C4 RID: 57796 RVA: 0x0006E104 File Offset: 0x0006C304
				public unsafe LoadManager.__c__DisplayClass65_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass65_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400971D RID: 38685
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400971E RID: 38686
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400971F RID: 38687
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009720 RID: 38688
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009721 RID: 38689
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009722 RID: 38690
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009723 RID: 38691
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009724 RID: 38692
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009725 RID: 38693
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F5 RID: 2293
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C525 RID: 50469 RVA: 0x002FF9F4 File Offset: 0x002FDBF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "autoLoadSave");
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "mainMenuPopup");
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668455);
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668456);
			}

			// Token: 0x0600C526 RID: 50470 RVA: 0x002FFA84 File Offset: 0x002FDC84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C527 RID: 50471 RVA: 0x002FFAC0 File Offset: 0x002FDCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125415, XrefRangeEnd = 125420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C528 RID: 50472 RVA: 0x0005FEC6 File Offset: 0x0005E0C6
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x0600C529 RID: 50473 RVA: 0x002FFB00 File Offset: 0x002FDD00
			// (set) Token: 0x0600C52A RID: 50474 RVA: 0x0005FECF File Offset: 0x0005E0CF
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x0600C52B RID: 50475 RVA: 0x002FFB30 File Offset: 0x002FDD30
			// (set) Token: 0x0600C52C RID: 50476 RVA: 0x0005FEEE File Offset: 0x0005E0EE
			public unsafe SaveInfo autoLoadSave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D87 RID: 15751
			// (get) Token: 0x0600C52D RID: 50477 RVA: 0x002FFB60 File Offset: 0x002FDD60
			// (set) Token: 0x0600C52E RID: 50478 RVA: 0x0005FF0D File Offset: 0x0005E10D
			public unsafe MainMenuPopup.Data mainMenuPopup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPopup.Data>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085A8 RID: 34216
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085A9 RID: 34217
			private static readonly IntPtr NativeFieldInfoPtr_autoLoadSave;

			// Token: 0x040085AA RID: 34218
			private static readonly IntPtr NativeFieldInfoPtr_mainMenuPopup;

			// Token: 0x040085AB RID: 34219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085AC RID: 34220
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3A RID: 3130
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_0+<<ExitToMenu>g__Load|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1C5 RID: 57797 RVA: 0x00350CD8 File Offset: 0x0034EED8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "<<ExitToMenu>g__Load|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668457);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668458);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668459);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668460);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668461);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668462);
				}

				// Token: 0x0600E1C6 RID: 57798 RVA: 0x00350DCC File Offset: 0x0034EFCC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1C7 RID: 57799 RVA: 0x00350E14 File Offset: 0x0034F014
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1C8 RID: 57800 RVA: 0x00350E48 File Offset: 0x0034F048
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125374, XrefRangeEnd = 125410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045FD RID: 17917
				// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x00350E84 File Offset: 0x0034F084
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1CA RID: 57802 RVA: 0x00350EC4 File Offset: 0x0034F0C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125410, XrefRangeEnd = 125415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045FE RID: 17918
				// (get) Token: 0x0600E1CB RID: 57803 RVA: 0x00350EF8 File Offset: 0x0034F0F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1CC RID: 57804 RVA: 0x0006E123 File Offset: 0x0006C323
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045F9 RID: 17913
				// (get) Token: 0x0600E1CD RID: 57805 RVA: 0x00350F38 File Offset: 0x0034F138
				// (set) Token: 0x0600E1CE RID: 57806 RVA: 0x0006E12C File Offset: 0x0006C32C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045FA RID: 17914
				// (get) Token: 0x0600E1CF RID: 57807 RVA: 0x00350F60 File Offset: 0x0034F160
				// (set) Token: 0x0600E1D0 RID: 57808 RVA: 0x0006E147 File Offset: 0x0006C347
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045FB RID: 17915
				// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x00350F90 File Offset: 0x0034F190
				// (set) Token: 0x0600E1D2 RID: 57810 RVA: 0x0006E166 File Offset: 0x0006C366
				public unsafe LoadManager.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045FC RID: 17916
				// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x00350FC0 File Offset: 0x0034F1C0
				// (set) Token: 0x0600E1D4 RID: 57812 RVA: 0x0006E185 File Offset: 0x0006C385
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009726 RID: 38694
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009727 RID: 38695
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009728 RID: 38696
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009729 RID: 38697
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400972A RID: 38698
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400972B RID: 38699
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400972C RID: 38700
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400972D RID: 38701
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400972E RID: 38702
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400972F RID: 38703
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F6 RID: 2294
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C52F RID: 50479 RVA: 0x002FFB90 File Offset: 0x002FDD90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, "timeOnWaitStart");
				LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, "maxWait");
				LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, 100668463);
				LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, 100668464);
			}

			// Token: 0x0600C530 RID: 50480 RVA: 0x002FFC0C File Offset: 0x002FDE0C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C531 RID: 50481 RVA: 0x002FFC48 File Offset: 0x002FDE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125420, XrefRangeEnd = 125424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExitToMenu_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C532 RID: 50482 RVA: 0x0005FF2C File Offset: 0x0005E12C
			public __c__DisplayClass70_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x0600C533 RID: 50483 RVA: 0x002FFC84 File Offset: 0x002FDE84
			// (set) Token: 0x0600C534 RID: 50484 RVA: 0x0005FF35 File Offset: 0x0005E135
			public unsafe float timeOnWaitStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart)) = value;
				}
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x0600C535 RID: 50485 RVA: 0x002FFCAC File Offset: 0x002FDEAC
			// (set) Token: 0x0600C536 RID: 50486 RVA: 0x0005FF50 File Offset: 0x0005E150
			public unsafe float maxWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait)) = value;
				}
			}

			// Token: 0x040085AD RID: 34221
			private static readonly IntPtr NativeFieldInfoPtr_timeOnWaitStart;

			// Token: 0x040085AE RID: 34222
			private static readonly IntPtr NativeFieldInfoPtr_maxWait;

			// Token: 0x040085AF RID: 34223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085B0 RID: 34224
			private static readonly IntPtr NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0;
		}
	}
}
