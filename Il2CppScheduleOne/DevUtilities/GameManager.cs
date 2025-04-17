using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000454 RID: 1108
	public class GameManager : NetworkSingleton<GameManager>
	{
		// Token: 0x06006039 RID: 24633 RVA: 0x001B85F4 File Offset: 0x001B67F4
		// Note: this type is marked as 'beforefieldinit'.
		static GameManager()
		{
			Il2CppClassPointerStore<GameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager>.NativeClassPtr);
			GameManager.NativeFieldInfoPtr_IS_DEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "IS_DEMO");
			GameManager.NativeFieldInfoPtr_IS_BETA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "IS_BETA");
			GameManager.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "seed");
			GameManager.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "OrganisationName");
			GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<OrganisationLogo>k__BackingField");
			GameManager.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Settings");
			GameManager.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "SpawnPoint");
			GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NoHomeRespawnPoint");
			GameManager.NativeFieldInfoPtr_Temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Temp");
			GameManager.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "onSettingsLoaded");
			GameManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "loader");
			GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			GameManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted");
			GameManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted");
			GameManager.NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675545);
			GameManager.NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675546);
			GameManager.NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675547);
			GameManager.NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675548);
			GameManager.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675549);
			GameManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675550);
			GameManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675551);
			GameManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675552);
			GameManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675553);
			GameManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675554);
			GameManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675555);
			GameManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675556);
			GameManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675557);
			GameManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675558);
			GameManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675559);
			GameManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675560);
			GameManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675561);
			GameManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675562);
			GameManager.NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675563);
			GameManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675564);
			GameManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675565);
			GameManager.NativeMethodInfoPtr_Load_Public_Void_GameData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675566);
			GameManager.NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675567);
			GameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675568);
			GameManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675569);
			GameManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675570);
			GameManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675571);
			GameManager.NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675572);
			GameManager.NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675573);
			GameManager.NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675574);
			GameManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675575);
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x0600603A RID: 24634 RVA: 0x001B89D0 File Offset: 0x001B6BD0
		public unsafe static bool IS_TUTORIAL
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 198893, RefRangeEnd = 198928, XrefRangeStart = 198885, XrefRangeEnd = 198893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x001B8A00 File Offset: 0x001B6C00
		public unsafe static int Seed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198928, XrefRangeEnd = 198936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x0600603C RID: 24636 RVA: 0x001B8A30 File Offset: 0x001B6C30
		// (set) Token: 0x0600603D RID: 24637 RVA: 0x001B8A70 File Offset: 0x001B6C70
		public unsafe Sprite OrganisationLogo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x001B8AB4 File Offset: 0x001B6CB4
		public unsafe bool IsTutorial
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 198944, RefRangeEnd = 198965, XrefRangeStart = 198936, XrefRangeEnd = 198944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x001B8AF0 File Offset: 0x001B6CF0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198965, XrefRangeEnd = 198967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x001B8B28 File Offset: 0x001B6D28
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198967, XrefRangeEnd = 198969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x001B8B60 File Offset: 0x001B6D60
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x001B8BA0 File Offset: 0x001B6DA0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x001B8BDC File Offset: 0x001B6DDC
		// (set) Token: 0x06006044 RID: 24644 RVA: 0x001B8C1C File Offset: 0x001B6E1C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x001B8C60 File Offset: 0x001B6E60
		// (set) Token: 0x06006046 RID: 24646 RVA: 0x001B8CA0 File Offset: 0x001B6EA0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x001B8CE4 File Offset: 0x001B6EE4
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x001B8D20 File Offset: 0x001B6F20
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x001B8D60 File Offset: 0x001B6F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198969, XrefRangeEnd = 198973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x001B8D9C File Offset: 0x001B6F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198973, XrefRangeEnd = 198976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x001B8DD8 File Offset: 0x001B6FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198976, XrefRangeEnd = 198992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x001B8E28 File Offset: 0x001B7028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198992, XrefRangeEnd = 199011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameData(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x001B8E7C File Offset: 0x001B707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199011, XrefRangeEnd = 199017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x001B8EB8 File Offset: 0x001B70B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199017, XrefRangeEnd = 199022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x001B8EFC File Offset: 0x001B70FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199025, RefRangeEnd = 199026, XrefRangeStart = 199022, XrefRangeEnd = 199025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(GameData data, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_Load_Public_Void_GameData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x001B8F50 File Offset: 0x001B7150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199064, RefRangeEnd = 199065, XrefRangeStart = 199026, XrefRangeEnd = 199064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTutorial(bool natural)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref natural;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x001B8F90 File Offset: 0x001B7190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199065, XrefRangeEnd = 199108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x001B8FCC File Offset: 0x001B71CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199108, XrefRangeEnd = 199118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x001B9008 File Offset: 0x001B7208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199118, XrefRangeEnd = 199121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x001B9044 File Offset: 0x001B7244
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x001B9080 File Offset: 0x001B7280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x001B90D4 File Offset: 0x001B72D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199121, XrefRangeEnd = 199124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x001B9128 File Offset: 0x001B7328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199124, XrefRangeEnd = 199130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x001B9178 File Offset: 0x001B7378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199130, XrefRangeEnd = 199134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x0002D7CD File Offset: 0x0002B9CD
		public GameManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x001B91B4 File Offset: 0x001B73B4
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x0002D7D6 File Offset: 0x0002B9D6
		public unsafe static bool IS_DEMO
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_IS_DEMO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_IS_DEMO, (void*)(&value));
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x001B91D0 File Offset: 0x001B73D0
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
		public unsafe static bool IS_BETA
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_IS_BETA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_IS_BETA, (void*)(&value));
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x001B91EC File Offset: 0x001B73EC
		// (set) Token: 0x0600605F RID: 24671 RVA: 0x0002D7F2 File Offset: 0x0002B9F2
		public unsafe int seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_seed)) = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x001B9214 File Offset: 0x001B7414
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x0002D80D File Offset: 0x0002BA0D
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x001B923C File Offset: 0x001B743C
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x0002D82C File Offset: 0x0002BA2C
		public unsafe Sprite _OrganisationLogo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x001B926C File Offset: 0x001B746C
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x0002D84B File Offset: 0x0002BA4B
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x001B929C File Offset: 0x001B749C
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x0002D86A File Offset: 0x0002BA6A
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x001B92CC File Offset: 0x001B74CC
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x0002D889 File Offset: 0x0002BA89
		public unsafe Transform NoHomeRespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600606A RID: 24682 RVA: 0x001B92FC File Offset: 0x001B74FC
		// (set) Token: 0x0600606B RID: 24683 RVA: 0x0002D8A8 File Offset: 0x0002BAA8
		public unsafe Transform Temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x001B932C File Offset: 0x001B752C
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x0002D8C7 File Offset: 0x0002BAC7
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_onSettingsLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x001B935C File Offset: 0x001B755C
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x0002D8E6 File Offset: 0x0002BAE6
		public unsafe GameDataLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x001B938C File Offset: 0x001B758C
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x0002D905 File Offset: 0x0002BB05
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x001B93BC File Offset: 0x001B75BC
		// (set) Token: 0x06006073 RID: 24691 RVA: 0x0002D924 File Offset: 0x0002BB24
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x001B93EC File Offset: 0x001B75EC
		// (set) Token: 0x06006075 RID: 24693 RVA: 0x0002D943 File Offset: 0x0002BB43
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x001B9414 File Offset: 0x001B7614
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x0002D95E File Offset: 0x0002BB5E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x001B943C File Offset: 0x001B763C
		// (set) Token: 0x06006079 RID: 24697 RVA: 0x0002D979 File Offset: 0x0002BB79
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040041B0 RID: 16816
		private static readonly IntPtr NativeFieldInfoPtr_IS_DEMO;

		// Token: 0x040041B1 RID: 16817
		private static readonly IntPtr NativeFieldInfoPtr_IS_BETA;

		// Token: 0x040041B2 RID: 16818
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x040041B3 RID: 16819
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x040041B4 RID: 16820
		private static readonly IntPtr NativeFieldInfoPtr__OrganisationLogo_k__BackingField;

		// Token: 0x040041B5 RID: 16821
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x040041B6 RID: 16822
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x040041B7 RID: 16823
		private static readonly IntPtr NativeFieldInfoPtr_NoHomeRespawnPoint;

		// Token: 0x040041B8 RID: 16824
		private static readonly IntPtr NativeFieldInfoPtr_Temp;

		// Token: 0x040041B9 RID: 16825
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x040041BA RID: 16826
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040041BB RID: 16827
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040041BC RID: 16828
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040041BD RID: 16829
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040041BE RID: 16830
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040041BF RID: 16831
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040041C0 RID: 16832
		private static readonly IntPtr NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0;

		// Token: 0x040041C1 RID: 16833
		private static readonly IntPtr NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0;

		// Token: 0x040041C2 RID: 16834
		private static readonly IntPtr NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0;

		// Token: 0x040041C3 RID: 16835
		private static readonly IntPtr NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0;

		// Token: 0x040041C4 RID: 16836
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0;

		// Token: 0x040041C5 RID: 16837
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040041C6 RID: 16838
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040041C7 RID: 16839
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040041C8 RID: 16840
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040041C9 RID: 16841
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040041CA RID: 16842
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040041CB RID: 16843
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040041CC RID: 16844
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040041CD RID: 16845
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040041CE RID: 16846
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040041CF RID: 16847
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040041D0 RID: 16848
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040041D1 RID: 16849
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040041D2 RID: 16850
		private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0;

		// Token: 0x040041D3 RID: 16851
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040041D4 RID: 16852
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040041D5 RID: 16853
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_GameData_String_0;

		// Token: 0x040041D6 RID: 16854
		private static readonly IntPtr NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0;

		// Token: 0x040041D7 RID: 16855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040041D8 RID: 16856
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040041D9 RID: 16857
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040041DA RID: 16858
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040041DB RID: 16859
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0;

		// Token: 0x040041DC RID: 16860
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0;

		// Token: 0x040041DD RID: 16861
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041DE RID: 16862
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
