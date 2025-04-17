using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BD RID: 957
	public class LevelManager : NetworkSingleton<LevelManager>
	{
		// Token: 0x06004A67 RID: 19047 RVA: 0x00168E24 File Offset: 0x00167024
		// Note: this type is marked as 'beforefieldinit'.
		static LevelManager()
		{
			Il2CppClassPointerStore<LevelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "LevelManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager>.NativeClassPtr);
			LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "TIERS_PER_RANK");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MIN");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MAX");
			LevelManager.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Rank>k__BackingField");
			LevelManager.NativeFieldInfoPtr_rankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "rankCount");
			LevelManager.NativeFieldInfoPtr__Tier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Tier>k__BackingField");
			LevelManager.NativeFieldInfoPtr__XP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<XP>k__BackingField");
			LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<TotalXP>k__BackingField");
			LevelManager.NativeFieldInfoPtr_onRankUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "onRankUp");
			LevelManager.NativeFieldInfoPtr_Unlockables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "Unlockables");
			LevelManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "loader");
			LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672522);
			LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672523);
			LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672524);
			LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672525);
			LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672526);
			LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672527);
			LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672528);
			LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672529);
			LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672530);
			LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672531);
			LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672532);
			LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672533);
			LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672534);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672535);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672536);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672537);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672538);
			LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672539);
			LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672540);
			LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672541);
			LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672542);
			LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672543);
			LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672544);
			LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672545);
			LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672546);
			LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672547);
			LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672548);
			LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672549);
			LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672550);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672551);
			LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672552);
			LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672553);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672554);
			LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672555);
			LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672556);
			LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672557);
			LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672558);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672559);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672560);
			LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672561);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672562);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672563);
			LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672564);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672565);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672566);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672567);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672568);
			LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672569);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672570);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672571);
			LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672572);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672573);
			LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672574);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672575);
			LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672576);
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004A68 RID: 19048 RVA: 0x001693E0 File Offset: 0x001675E0
		// (set) Token: 0x06004A69 RID: 19049 RVA: 0x0016941C File Offset: 0x0016761C
		public unsafe ERank Rank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004A6A RID: 19050 RVA: 0x0016945C File Offset: 0x0016765C
		// (set) Token: 0x06004A6B RID: 19051 RVA: 0x00169498 File Offset: 0x00167698
		public unsafe int Tier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06004A6C RID: 19052 RVA: 0x001694D8 File Offset: 0x001676D8
		// (set) Token: 0x06004A6D RID: 19053 RVA: 0x00169514 File Offset: 0x00167714
		public unsafe int XP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004A6E RID: 19054 RVA: 0x00169554 File Offset: 0x00167754
		// (set) Token: 0x06004A6F RID: 19055 RVA: 0x00169590 File Offset: 0x00167790
		public unsafe int TotalXP
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60909, RefRangeEnd = 60949, XrefRangeStart = 60909, XrefRangeEnd = 60949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004A70 RID: 19056 RVA: 0x001695D0 File Offset: 0x001677D0
		public unsafe float XPToNextTier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163937, XrefRangeEnd = 163939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x0016960C File Offset: 0x0016780C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163939, XrefRangeEnd = 163941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x00169644 File Offset: 0x00167844
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163941, XrefRangeEnd = 163943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x0016967C File Offset: 0x0016787C
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x001696BC File Offset: 0x001678BC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x001696F8 File Offset: 0x001678F8
		// (set) Token: 0x06004A76 RID: 19062 RVA: 0x00169738 File Offset: 0x00167938
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x0016977C File Offset: 0x0016797C
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x001697BC File Offset: 0x001679BC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x00169800 File Offset: 0x00167A00
		// (set) Token: 0x06004A7A RID: 19066 RVA: 0x0016983C File Offset: 0x00167A3C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x0016987C File Offset: 0x00167A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163943, XrefRangeEnd = 163958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x001698B8 File Offset: 0x00167AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163958, XrefRangeEnd = 163961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001698F4 File Offset: 0x00167AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163961, XrefRangeEnd = 163963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x00169944 File Offset: 0x00167B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163963, XrefRangeEnd = 163969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x00169980 File Offset: 0x00167B80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 163989, RefRangeEnd = 163999, XrefRangeStart = 163969, XrefRangeEnd = 163989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x001699C0 File Offset: 0x00167BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163999, XrefRangeEnd = 164019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXPLocal(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00169A00 File Offset: 0x00167C00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164072, RefRangeEnd = 164075, XrefRangeStart = 164019, XrefRangeEnd = 164072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x00169A7C File Offset: 0x00167C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164075, XrefRangeEnd = 164095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTierNetworked(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00169AC8 File Offset: 0x00167CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164095, XrefRangeEnd = 164097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00169AFC File Offset: 0x00167CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164097, XrefRangeEnd = 164101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00169B40 File Offset: 0x00167D40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164101, RefRangeEnd = 164106, XrefRangeStart = 164101, XrefRangeEnd = 164101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00169B7C File Offset: 0x00167D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164140, RefRangeEnd = 164142, XrefRangeStart = 164106, XrefRangeEnd = 164140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnlockable(Unlockable unlockable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00169BC0 File Offset: 0x00167DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164161, RefRangeEnd = 164162, XrefRangeStart = 164142, XrefRangeEnd = 164161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalXPForRank(FullRank fullrank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fullrank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00169C0C File Offset: 0x00167E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164182, RefRangeEnd = 164183, XrefRangeStart = 164162, XrefRangeEnd = 164182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank(int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00169C58 File Offset: 0x00167E58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 164186, RefRangeEnd = 164192, XrefRangeStart = 164183, XrefRangeEnd = 164186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXPForTier(ERank rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00169CA4 File Offset: 0x00167EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164193, RefRangeEnd = 164194, XrefRangeStart = 164192, XrefRangeEnd = 164193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetOrderLimitMultiplier(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00169CE4 File Offset: 0x00167EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164194, RefRangeEnd = 164195, XrefRangeStart = 164194, XrefRangeEnd = 164194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRankOrderLimitMultiplier(ERank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00169D24 File Offset: 0x00167F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164195, XrefRangeEnd = 164222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00169D60 File Offset: 0x00167F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164222, XrefRangeEnd = 164257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00169D9C File Offset: 0x00167F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164257, XrefRangeEnd = 164260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00169DD8 File Offset: 0x00167FD8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00169E14 File Offset: 0x00168014
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 163989, RefRangeEnd = 163999, XrefRangeStart = 163989, XrefRangeEnd = 163999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00169E54 File Offset: 0x00168054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00169E94 File Offset: 0x00168094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164260, XrefRangeEnd = 164274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00169EF8 File Offset: 0x001680F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00169F38 File Offset: 0x00168138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164325, RefRangeEnd = 164326, XrefRangeStart = 164274, XrefRangeEnd = 164325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00169F78 File Offset: 0x00168178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164326, XrefRangeEnd = 164330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00169FC8 File Offset: 0x001681C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164330, XrefRangeEnd = 164355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x0016A044 File Offset: 0x00168244
		[CallerCount(0)]
		public unsafe void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x0016A0C0 File Offset: 0x001682C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164355, XrefRangeEnd = 164364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x0016A110 File Offset: 0x00168310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164364, XrefRangeEnd = 164380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x0016A18C File Offset: 0x0016838C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164380, XrefRangeEnd = 164389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x0016A1DC File Offset: 0x001683DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x0016A228 File Offset: 0x00168428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164389, XrefRangeEnd = 164402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x0016A274 File Offset: 0x00168474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164402, XrefRangeEnd = 164418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x0016A2C4 File Offset: 0x001684C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164418, XrefRangeEnd = 164432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00023E00 File Offset: 0x00022000
		public LevelManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x0016A300 File Offset: 0x00168500
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x00023E09 File Offset: 0x00022009
		public unsafe static int TIERS_PER_RANK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&value));
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x0016A31C File Offset: 0x0016851C
		// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x00023E17 File Offset: 0x00022017
		public unsafe static int XP_PER_TIER_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x0016A338 File Offset: 0x00168538
		// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x00023E25 File Offset: 0x00022025
		public unsafe static int XP_PER_TIER_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x0016A354 File Offset: 0x00168554
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x00023E33 File Offset: 0x00022033
		public unsafe ERank _Rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField)) = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x0016A37C File Offset: 0x0016857C
		// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x00023E4E File Offset: 0x0002204E
		public unsafe int rankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount)) = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x0016A3A4 File Offset: 0x001685A4
		// (set) Token: 0x06004AAB RID: 19115 RVA: 0x00023E69 File Offset: 0x00022069
		public unsafe int _Tier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x0016A3CC File Offset: 0x001685CC
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x00023E84 File Offset: 0x00022084
		public unsafe int _XP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField)) = value;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x0016A3F4 File Offset: 0x001685F4
		// (set) Token: 0x06004AAF RID: 19119 RVA: 0x00023E9F File Offset: 0x0002209F
		public unsafe int _TotalXP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField)) = value;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x0016A41C File Offset: 0x0016861C
		// (set) Token: 0x06004AB1 RID: 19121 RVA: 0x00023EBA File Offset: 0x000220BA
		public unsafe Action<FullRank, FullRank> onRankUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FullRank, FullRank>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x0016A44C File Offset: 0x0016864C
		// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x00023ED9 File Offset: 0x000220D9
		public unsafe Dictionary<FullRank, List<Unlockable>> Unlockables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FullRank, List<Unlockable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x0016A47C File Offset: 0x0016867C
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x00023EF8 File Offset: 0x000220F8
		public unsafe RankLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x0016A4AC File Offset: 0x001686AC
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x00023F17 File Offset: 0x00022117
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x0016A4DC File Offset: 0x001686DC
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x00023F36 File Offset: 0x00022136
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x0016A50C File Offset: 0x0016870C
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x00023F55 File Offset: 0x00022155
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x0016A534 File Offset: 0x00168734
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x00023F70 File Offset: 0x00022170
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x0016A55C File Offset: 0x0016875C
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00023F8B File Offset: 0x0002218B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeFieldInfoPtr_TIERS_PER_RANK;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MIN;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MAX;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeFieldInfoPtr_rankCount;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeFieldInfoPtr__Tier_k__BackingField;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeFieldInfoPtr__XP_k__BackingField;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeFieldInfoPtr__TotalXP_k__BackingField;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeFieldInfoPtr_onRankUp;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeFieldInfoPtr_Unlockables;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_ERank_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_get_Tier_Public_get_Int32_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr_get_XP_Public_get_Int32_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTier_Private_Void_0;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_0;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0;

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000987 RID: 2439
		[ObfuscatedName("ScheduleOne.Levelling.LevelManager+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Object
		{
			// Token: 0x0600CA42 RID: 51778 RVA: 0x0030EA64 File Offset: 0x0030CC64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr);
				LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, "unlockable");
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672577);
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672578);
			}

			// Token: 0x0600CA43 RID: 51779 RVA: 0x0030EACC File Offset: 0x0030CCCC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA44 RID: 51780 RVA: 0x0030EB08 File Offset: 0x0030CD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163933, XrefRangeEnd = 163937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddUnlockable_b__0(Unlockable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA45 RID: 51781 RVA: 0x0006256C File Offset: 0x0006076C
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F08 RID: 16136
			// (get) Token: 0x0600CA46 RID: 51782 RVA: 0x0030EB58 File Offset: 0x0030CD58
			// (set) Token: 0x0600CA47 RID: 51783 RVA: 0x00062575 File Offset: 0x00060775
			public unsafe Unlockable unlockable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Unlockable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088D0 RID: 35024
			private static readonly IntPtr NativeFieldInfoPtr_unlockable;

			// Token: 0x040088D1 RID: 35025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088D2 RID: 35026
			private static readonly IntPtr NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0;
		}
	}
}
