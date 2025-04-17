using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.AI.Navigation;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E7 RID: 999
	public class PlayerManager : Singleton<PlayerManager>
	{
		// Token: 0x06005130 RID: 20784 RVA: 0x0018250C File Offset: 0x0018070C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerManager()
		{
			Il2CppClassPointerStore<PlayerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr);
			PlayerManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loader");
			PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerData");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerDataPaths");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerFileNames");
			PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "PlayerRecoverySurface");
			PlayerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673486);
			PlayerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673487);
			PlayerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673488);
			PlayerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673489);
			PlayerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673490);
			PlayerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673491);
			PlayerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673492);
			PlayerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673493);
			PlayerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673494);
			PlayerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673495);
			PlayerManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673496);
			PlayerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673497);
			PlayerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673498);
			PlayerManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673499);
			PlayerManager.NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673500);
			PlayerManager.NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673501);
			PlayerManager.NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673502);
			PlayerManager.NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673503);
			PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673504);
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06005131 RID: 20785 RVA: 0x00182758 File Offset: 0x00180958
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176261, XrefRangeEnd = 176263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x00182790 File Offset: 0x00180990
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176263, XrefRangeEnd = 176265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06005133 RID: 20787 RVA: 0x001827C8 File Offset: 0x001809C8
		public unsafe virtual Loader Loader
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x00182808 File Offset: 0x00180A08
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06005135 RID: 20789 RVA: 0x00182844 File Offset: 0x00180A44
		// (set) Token: 0x06005136 RID: 20790 RVA: 0x00182884 File Offset: 0x00180A84
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x001828C8 File Offset: 0x00180AC8
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x00182908 File Offset: 0x00180B08
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x0018294C File Offset: 0x00180B4C
		// (set) Token: 0x0600513A RID: 20794 RVA: 0x00182988 File Offset: 0x00180B88
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x001829C8 File Offset: 0x00180BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176265, XrefRangeEnd = 176268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00182A04 File Offset: 0x00180C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176268, XrefRangeEnd = 176274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00182A40 File Offset: 0x00180C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176274, XrefRangeEnd = 176276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00182A84 File Offset: 0x00180C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176276, XrefRangeEnd = 176366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00182AE0 File Offset: 0x00180CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176422, RefRangeEnd = 176423, XrefRangeStart = 176366, XrefRangeEnd = 176422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00182B24 File Offset: 0x00180D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176479, RefRangeEnd = 176480, XrefRangeStart = 176423, XrefRangeEnd = 176479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPlayer(PlayerData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00182B78 File Offset: 0x00180D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176480, XrefRangeEnd = 176519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllPlayerFilesLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x00182BAC File Offset: 0x00180DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176623, RefRangeEnd = 176624, XrefRangeStart = 176519, XrefRangeEnd = 176623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out Il2CppReferenceArray<VariableData> variables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = 0;
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			data = ((intPtr8 == 0) ? null : new PlayerData(intPtr8));
			inventoryString = IL2CPP.Il2CppStringToManaged(intPtr2);
			appearanceString = IL2CPP.Il2CppStringToManaged(intPtr3);
			clothingString = IL2CPP.Il2CppStringToManaged(intPtr4);
			IntPtr intPtr9 = intPtr5;
			variables = ((intPtr9 == 0) ? null : new Il2CppReferenceArray<VariableData>(intPtr9));
			return *IL2CPP.il2cpp_object_unbox(intPtr6);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00182C94 File Offset: 0x00180E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176624, XrefRangeEnd = 176661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0002696A File Offset: 0x00024B6A
		public PlayerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06005145 RID: 20805 RVA: 0x00182CD0 File Offset: 0x00180ED0
		// (set) Token: 0x06005146 RID: 20806 RVA: 0x00026973 File Offset: 0x00024B73
		public unsafe PlayersLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayersLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x00182D00 File Offset: 0x00180F00
		// (set) Token: 0x06005148 RID: 20808 RVA: 0x00026992 File Offset: 0x00024B92
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06005149 RID: 20809 RVA: 0x00182D30 File Offset: 0x00180F30
		// (set) Token: 0x0600514A RID: 20810 RVA: 0x000269B1 File Offset: 0x00024BB1
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x00182D60 File Offset: 0x00180F60
		// (set) Token: 0x0600514C RID: 20812 RVA: 0x000269D0 File Offset: 0x00024BD0
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x00182D88 File Offset: 0x00180F88
		// (set) Token: 0x0600514E RID: 20814 RVA: 0x000269EB File Offset: 0x00024BEB
		public unsafe List<PlayerData> loadedPlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x0600514F RID: 20815 RVA: 0x00182DB8 File Offset: 0x00180FB8
		// (set) Token: 0x06005150 RID: 20816 RVA: 0x00026A0A File Offset: 0x00024C0A
		public unsafe List<string> loadedPlayerDataPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x00182DE8 File Offset: 0x00180FE8
		// (set) Token: 0x06005152 RID: 20818 RVA: 0x00026A29 File Offset: 0x00024C29
		public unsafe List<string> loadedPlayerFileNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x00182E18 File Offset: 0x00181018
		// (set) Token: 0x06005154 RID: 20820 RVA: 0x00026A48 File Offset: 0x00024C48
		public unsafe NavMeshSurface PlayerRecoverySurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshSurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeFieldInfoPtr_loadedPlayerData;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeFieldInfoPtr_loadedPlayerDataPaths;

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeFieldInfoPtr_loadedPlayerFileNames;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRecoverySurface;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003726 RID: 14118
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003727 RID: 14119
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003728 RID: 14120
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003729 RID: 14121
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400372A RID: 14122
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400372B RID: 14123
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400372C RID: 14124
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400372D RID: 14125
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400372E RID: 14126
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400372F RID: 14127
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003730 RID: 14128
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003731 RID: 14129
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04003732 RID: 14130
		private static readonly IntPtr NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0;

		// Token: 0x04003733 RID: 14131
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0;

		// Token: 0x04003734 RID: 14132
		private static readonly IntPtr NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0;

		// Token: 0x04003735 RID: 14133
		private static readonly IntPtr NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04003736 RID: 14134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009A3 RID: 2467
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Object
		{
			// Token: 0x0600CB43 RID: 52035 RVA: 0x00311644 File Offset: 0x0030F844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, "i");
				PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, 100673505);
				PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, 100673506);
			}

			// Token: 0x0600CB44 RID: 52036 RVA: 0x003116AC File Offset: 0x0030F8AC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB45 RID: 52037 RVA: 0x003116E8 File Offset: 0x0030F8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176243, XrefRangeEnd = 176253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _WriteData_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB46 RID: 52038 RVA: 0x00062DD5 File Offset: 0x00060FD5
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F54 RID: 16212
			// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x00311738 File Offset: 0x0030F938
			// (set) Token: 0x0600CB48 RID: 52040 RVA: 0x00062DDE File Offset: 0x00060FDE
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x0400896D RID: 35181
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400896E RID: 35182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400896F RID: 35183
			private static readonly IntPtr NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0;
		}

		// Token: 0x020009A4 RID: 2468
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x0600CB49 RID: 52041 RVA: 0x00311760 File Offset: 0x0030F960
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, "player");
				PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, 100673507);
				PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, 100673508);
			}

			// Token: 0x0600CB4A RID: 52042 RVA: 0x003117C8 File Offset: 0x0030F9C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB4B RID: 52043 RVA: 0x00311804 File Offset: 0x0030FA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176253, XrefRangeEnd = 176256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SavePlayer_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB4C RID: 52044 RVA: 0x00062DF9 File Offset: 0x00060FF9
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F55 RID: 16213
			// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x00311854 File Offset: 0x0030FA54
			// (set) Token: 0x0600CB4E RID: 52046 RVA: 0x00062E02 File Offset: 0x00061002
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008970 RID: 35184
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04008971 RID: 35185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008972 RID: 35186
			private static readonly IntPtr NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0;
		}

		// Token: 0x020009A5 RID: 2469
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x0600CB4F RID: 52047 RVA: 0x00311884 File Offset: 0x0030FA84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, "data");
				PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, 100673509);
				PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, 100673510);
			}

			// Token: 0x0600CB50 RID: 52048 RVA: 0x003118EC File Offset: 0x0030FAEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB51 RID: 52049 RVA: 0x00311928 File Offset: 0x0030FB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176256, XrefRangeEnd = 176259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlayer_b__0(Player Player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB52 RID: 52050 RVA: 0x00062E21 File Offset: 0x00061021
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F56 RID: 16214
			// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x00311978 File Offset: 0x0030FB78
			// (set) Token: 0x0600CB54 RID: 52052 RVA: 0x00062E2A File Offset: 0x0006102A
			public unsafe PlayerData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008973 RID: 35187
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008974 RID: 35188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008975 RID: 35189
			private static readonly IntPtr NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0;
		}

		// Token: 0x020009A6 RID: 2470
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Object
		{
			// Token: 0x0600CB55 RID: 52053 RVA: 0x003119A8 File Offset: 0x0030FBA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, "playerCode");
				PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, 100673511);
				PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, 100673512);
			}

			// Token: 0x0600CB56 RID: 52054 RVA: 0x00311A10 File Offset: 0x0030FC10
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB57 RID: 52055 RVA: 0x00311A4C File Offset: 0x0030FC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176259, XrefRangeEnd = 176261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetPlayerData_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB58 RID: 52056 RVA: 0x00062E49 File Offset: 0x00061049
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F57 RID: 16215
			// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00311A9C File Offset: 0x0030FC9C
			// (set) Token: 0x0600CB5A RID: 52058 RVA: 0x00062E52 File Offset: 0x00061052
			public unsafe string playerCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008976 RID: 35190
			private static readonly IntPtr NativeFieldInfoPtr_playerCode;

			// Token: 0x04008977 RID: 35191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008978 RID: 35192
			private static readonly IntPtr NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0;
		}
	}
}
