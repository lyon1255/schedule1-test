using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000184 RID: 388
	public class VariableDatabase : NetworkSingleton<VariableDatabase>
	{
		// Token: 0x06001ED3 RID: 7891 RVA: 0x000D0600 File Offset: 0x000CE800
		// Note: this type is marked as 'beforefieldinit'.
		static VariableDatabase()
		{
			Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr);
			VariableDatabase.NativeFieldInfoPtr_VariableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "VariableList");
			VariableDatabase.NativeFieldInfoPtr_VariableDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "VariableDict");
			VariableDatabase.NativeFieldInfoPtr_playerVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "playerVariables");
			VariableDatabase.NativeFieldInfoPtr_Creators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "Creators");
			VariableDatabase.NativeFieldInfoPtr_ItemsToTrackAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "ItemsToTrackAcquire");
			VariableDatabase.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "loader");
			VariableDatabase.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			VariableDatabase.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			VariableDatabase.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "<HasChanged>k__BackingField");
			VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted");
			VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted");
			VariableDatabase.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666773);
			VariableDatabase.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666774);
			VariableDatabase.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666775);
			VariableDatabase.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666776);
			VariableDatabase.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666777);
			VariableDatabase.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666778);
			VariableDatabase.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666779);
			VariableDatabase.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666780);
			VariableDatabase.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666781);
			VariableDatabase.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666782);
			VariableDatabase.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666783);
			VariableDatabase.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666784);
			VariableDatabase.NativeMethodInfoPtr_CreateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666785);
			VariableDatabase.NativeMethodInfoPtr_CreatePlayerVariables_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666786);
			VariableDatabase.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666787);
			VariableDatabase.NativeMethodInfoPtr_CreateVariable_Public_Void_String_EVariableType_String_Boolean_EVariableMode_Player_EVariableReplicationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666788);
			VariableDatabase.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666789);
			VariableDatabase.NativeMethodInfoPtr_SendValue_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666790);
			VariableDatabase.NativeMethodInfoPtr_ReceiveValue_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666791);
			VariableDatabase.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666792);
			VariableDatabase.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666793);
			VariableDatabase.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666794);
			VariableDatabase.NativeMethodInfoPtr_PrintAllVariables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666795);
			VariableDatabase.NativeMethodInfoPtr_PrintVariableValue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666796);
			VariableDatabase.NativeMethodInfoPtr_NotifyItemAcquired_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666797);
			VariableDatabase.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666798);
			VariableDatabase.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666799);
			VariableDatabase.NativeMethodInfoPtr_Load_Public_Void_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666800);
			VariableDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666801);
			VariableDatabase.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666802);
			VariableDatabase.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666803);
			VariableDatabase.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666804);
			VariableDatabase.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666805);
			VariableDatabase.NativeMethodInfoPtr_RpcLogic___SendValue_3895153758_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666806);
			VariableDatabase.NativeMethodInfoPtr_RpcReader___Server_SendValue_3895153758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666807);
			VariableDatabase.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666808);
			VariableDatabase.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666809);
			VariableDatabase.NativeMethodInfoPtr_RpcReader___Observers_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666810);
			VariableDatabase.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666811);
			VariableDatabase.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666812);
			VariableDatabase.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr, 100666813);
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000D0A40 File Offset: 0x000CEC40
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107416, XrefRangeEnd = 107418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000D0A78 File Offset: 0x000CEC78
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107418, XrefRangeEnd = 107420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x000D0AB0 File Offset: 0x000CECB0
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000D0AF0 File Offset: 0x000CECF0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x000D0B2C File Offset: 0x000CED2C
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x000D0B6C File Offset: 0x000CED6C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107420, XrefRangeEnd = 107421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x000D0BB0 File Offset: 0x000CEDB0
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x000D0BF0 File Offset: 0x000CEDF0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107421, XrefRangeEnd = 107422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x000D0C34 File Offset: 0x000CEE34
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x000D0C70 File Offset: 0x000CEE70
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000D0CB0 File Offset: 0x000CEEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107422, XrefRangeEnd = 107423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000D0CEC File Offset: 0x000CEEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107423, XrefRangeEnd = 107429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000D0D28 File Offset: 0x000CEF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107443, RefRangeEnd = 107444, XrefRangeStart = 107429, XrefRangeEnd = 107443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_CreateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000D0D5C File Offset: 0x000CEF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107446, RefRangeEnd = 107447, XrefRangeStart = 107444, XrefRangeEnd = 107446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePlayerVariables(Player owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_CreatePlayerVariables_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000D0DA0 File Offset: 0x000CEFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107447, XrefRangeEnd = 107456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000D0DF0 File Offset: 0x000CEFF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107473, RefRangeEnd = 107475, XrefRangeStart = 107456, XrefRangeEnd = 107473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateVariable(string name, VariableDatabase.EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_CreateVariable_Public_Void_String_EVariableType_String_Boolean_EVariableMode_Player_EVariableReplicationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000D0E90 File Offset: 0x000CF090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107475, XrefRangeEnd = 107498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVariable(BaseVariable variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000D0ED4 File Offset: 0x000CF0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107498, XrefRangeEnd = 107500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValue(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_SendValue_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000D0F3C File Offset: 0x000CF13C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107533, RefRangeEnd = 107536, XrefRangeStart = 107500, XrefRangeEnd = 107533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_ReceiveValue_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000D0FA4 File Offset: 0x000CF1A4
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 107552, RefRangeEnd = 107652, XrefRangeStart = 107536, XrefRangeEnd = 107552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVariableValue(string variableName, string value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000D1008 File Offset: 0x000CF208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 107668, RefRangeEnd = 107672, XrefRangeStart = 107652, XrefRangeEnd = 107668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable GetVariable(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVariable>(intPtr3) : null;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000D1058 File Offset: 0x000CF258
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 107691, RefRangeEnd = 107707, XrefRangeStart = 107672, XrefRangeEnd = 107691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000D10A4 File Offset: 0x000CF2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107707, XrefRangeEnd = 107738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintAllVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_PrintAllVariables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000D10D8 File Offset: 0x000CF2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107738, XrefRangeEnd = 107763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintVariableValue(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_PrintVariableValue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000D111C File Offset: 0x000CF31C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107778, RefRangeEnd = 107780, XrefRangeStart = 107763, XrefRangeEnd = 107778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyItemAcquired(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_NotifyItemAcquired_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000D116C File Offset: 0x000CF36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107780, XrefRangeEnd = 107782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000D11B0 File Offset: 0x000CF3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107782, XrefRangeEnd = 107830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000D120C File Offset: 0x000CF40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107855, RefRangeEnd = 107856, XrefRangeStart = 107830, XrefRangeEnd = 107855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(VariableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_Load_Public_Void_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000D1250 File Offset: 0x000CF450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107856, XrefRangeEnd = 107895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000D128C File Offset: 0x000CF48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107895, XrefRangeEnd = 107918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000D12C8 File Offset: 0x000CF4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107918, XrefRangeEnd = 107921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000D1304 File Offset: 0x000CF504
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000D1340 File Offset: 0x000CF540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107951, RefRangeEnd = 107952, XrefRangeStart = 107921, XrefRangeEnd = 107951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000D13A8 File Offset: 0x000CF5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107952, XrefRangeEnd = 107953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcLogic___SendValue_3895153758_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000D1410 File Offset: 0x000CF610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107953, XrefRangeEnd = 107959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcReader___Server_SendValue_3895153758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000D1474 File Offset: 0x000CF674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107959, XrefRangeEnd = 107979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000D14DC File Offset: 0x000CF6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107986, RefRangeEnd = 107988, XrefRangeStart = 107979, XrefRangeEnd = 107986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000D1544 File Offset: 0x000CF744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107988, XrefRangeEnd = 107992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcReader___Observers_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000D1594 File Offset: 0x000CF794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107992, XrefRangeEnd = 108003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000D15FC File Offset: 0x000CF7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108003, XrefRangeEnd = 108008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableDatabase.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000D164C File Offset: 0x000CF84C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108045, RefRangeEnd = 108046, XrefRangeStart = 108008, XrefRangeEnd = 108045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableDatabase.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000115F9 File Offset: 0x0000F7F9
		public VariableDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x000D1688 File Offset: 0x000CF888
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00011602 File Offset: 0x0000F802
		public unsafe List<BaseVariable> VariableList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_VariableList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_VariableList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000D16B8 File Offset: 0x000CF8B8
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00011621 File Offset: 0x0000F821
		public unsafe Dictionary<string, BaseVariable> VariableDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_VariableDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BaseVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_VariableDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000D16E8 File Offset: 0x000CF8E8
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00011640 File Offset: 0x0000F840
		public unsafe List<string> playerVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_playerVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_playerVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x000D1718 File Offset: 0x000CF918
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0001165F File Offset: 0x0000F85F
		public unsafe Il2CppReferenceArray<VariableCreator> Creators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_Creators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableCreator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_Creators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000D1748 File Offset: 0x000CF948
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0001167E File Offset: 0x0000F87E
		public unsafe Il2CppReferenceArray<StorableItemDefinition> ItemsToTrackAcquire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_ItemsToTrackAcquire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorableItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_ItemsToTrackAcquire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000D1778 File Offset: 0x000CF978
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0001169D File Offset: 0x0000F89D
		public unsafe VariablesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VariablesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000D17A8 File Offset: 0x000CF9A8
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x000116BC File Offset: 0x0000F8BC
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000D17D8 File Offset: 0x000CF9D8
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x000116DB File Offset: 0x0000F8DB
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000D1808 File Offset: 0x000CFA08
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x000116FA File Offset: 0x0000F8FA
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000D1830 File Offset: 0x000CFA30
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00011715 File Offset: 0x0000F915
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000D1858 File Offset: 0x000CFA58
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00011730 File Offset: 0x0000F930
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableDatabase.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr_VariableList;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr_VariableDict;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_playerVariables;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_Creators;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_ItemsToTrackAcquire;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_CreateVariables_Private_Void_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerVariables_Public_Void_Player_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_CreateVariable_Public_Void_String_EVariableType_String_Boolean_EVariableMode_Player_EVariableReplicationMode_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_SendValue_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveValue_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_PrintAllVariables_Public_Void_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_PrintVariableValue_Public_Void_String_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_NotifyItemAcquired_Public_Void_String_Int32_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_VariableData_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendValue_3895153758_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendValue_3895153758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008B0 RID: 2224
		[OriginalName("Assembly-CSharp.dll", "", "EVariableType")]
		public enum EVariableType
		{
			// Token: 0x04008438 RID: 33848
			Bool,
			// Token: 0x04008439 RID: 33849
			Number
		}

		// Token: 0x020008B1 RID: 2225
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x0400843A RID: 33850
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VariableDatabase.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<VariableDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
