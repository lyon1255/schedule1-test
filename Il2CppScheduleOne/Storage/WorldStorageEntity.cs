using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000581 RID: 1409
	public class WorldStorageEntity : StorageEntity
	{
		// Token: 0x06007BFD RID: 31741 RVA: 0x00215604 File Offset: 0x00213804
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntity()
		{
			Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "WorldStorageEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr);
			WorldStorageEntity.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "All");
			WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<GUID>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "BakedGUID");
			WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<HasChanged>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted");
			WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted");
			WorldStorageEntity.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678841);
			WorldStorageEntity.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678842);
			WorldStorageEntity.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678843);
			WorldStorageEntity.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678844);
			WorldStorageEntity.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678845);
			WorldStorageEntity.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678846);
			WorldStorageEntity.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678847);
			WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678848);
			WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678849);
			WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678850);
			WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678851);
			WorldStorageEntity.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678852);
			WorldStorageEntity.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678853);
			WorldStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678854);
			WorldStorageEntity.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678855);
			WorldStorageEntity.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678856);
			WorldStorageEntity.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678857);
			WorldStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678858);
			WorldStorageEntity.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678859);
			WorldStorageEntity.NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678860);
			WorldStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678861);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678863);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678864);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678865);
			WorldStorageEntity.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100678866);
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x002158C8 File Offset: 0x00213AC8
		// (set) Token: 0x06007BFF RID: 31743 RVA: 0x00215904 File Offset: 0x00213B04
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00215944 File Offset: 0x00213B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236986, XrefRangeEnd = 236989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x06007C01 RID: 31745 RVA: 0x00215978 File Offset: 0x00213B78
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236989, XrefRangeEnd = 236994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x06007C02 RID: 31746 RVA: 0x002159B0 File Offset: 0x00213BB0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236999, RefRangeEnd = 237000, XrefRangeStart = 236994, XrefRangeEnd = 236999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x002159E8 File Offset: 0x00213BE8
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x00215A28 File Offset: 0x00213C28
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x00215A64 File Offset: 0x00213C64
		// (set) Token: 0x06007C06 RID: 31750 RVA: 0x00215AA4 File Offset: 0x00213CA4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237000, XrefRangeEnd = 237001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x00215AE8 File Offset: 0x00213CE8
		// (set) Token: 0x06007C08 RID: 31752 RVA: 0x00215B28 File Offset: 0x00213D28
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237001, XrefRangeEnd = 237002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x00215B6C File Offset: 0x00213D6C
		// (set) Token: 0x06007C0A RID: 31754 RVA: 0x00215BA8 File Offset: 0x00213DA8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00215BE8 File Offset: 0x00213DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237002, XrefRangeEnd = 237003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x00215C24 File Offset: 0x00213E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237003, XrefRangeEnd = 237009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x00215C60 File Offset: 0x00213E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237009, XrefRangeEnd = 237013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x00215CA0 File Offset: 0x00213EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237013, XrefRangeEnd = 237014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x00215CE8 File Offset: 0x00213EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237014, XrefRangeEnd = 237023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x00215D2C File Offset: 0x00213F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237023, XrefRangeEnd = 237029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(WorldStorageEntityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x00215D7C File Offset: 0x00213F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237029, XrefRangeEnd = 237030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x00215DB8 File Offset: 0x00213FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237030, XrefRangeEnd = 237055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x00215DF4 File Offset: 0x00213FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237055, XrefRangeEnd = 237056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x00215E30 File Offset: 0x00214030
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x00215E6C File Offset: 0x0021406C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x00215EA8 File Offset: 0x002140A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237095, RefRangeEnd = 237096, XrefRangeStart = 237056, XrefRangeEnd = 237095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x0003AD5D File Offset: 0x00038F5D
		public WorldStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x00215EE4 File Offset: 0x002140E4
		// (set) Token: 0x06007C19 RID: 31769 RVA: 0x0003AD66 File Offset: 0x00038F66
		public unsafe static List<WorldStorageEntity> All
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldStorageEntity.NativeFieldInfoPtr_All, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldStorageEntity.NativeFieldInfoPtr_All, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06007C1A RID: 31770 RVA: 0x00215F0C File Offset: 0x0021410C
		// (set) Token: 0x06007C1B RID: 31771 RVA: 0x0003AD78 File Offset: 0x00038F78
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x00215F34 File Offset: 0x00214134
		// (set) Token: 0x06007C1D RID: 31773 RVA: 0x0003AD93 File Offset: 0x00038F93
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06007C1E RID: 31774 RVA: 0x00215F5C File Offset: 0x0021415C
		// (set) Token: 0x06007C1F RID: 31775 RVA: 0x0003ADB2 File Offset: 0x00038FB2
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x00215F8C File Offset: 0x0021418C
		// (set) Token: 0x06007C21 RID: 31777 RVA: 0x0003ADD1 File Offset: 0x00038FD1
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x00215FBC File Offset: 0x002141BC
		// (set) Token: 0x06007C23 RID: 31779 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06007C24 RID: 31780 RVA: 0x00215FE4 File Offset: 0x002141E4
		// (set) Token: 0x06007C25 RID: 31781 RVA: 0x0003AE0B File Offset: 0x0003900B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06007C26 RID: 31782 RVA: 0x0021600C File Offset: 0x0021420C
		// (set) Token: 0x06007C27 RID: 31783 RVA: 0x0003AE26 File Offset: 0x00039026
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400546D RID: 21613
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x0400546E RID: 21614
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400546F RID: 21615
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04005470 RID: 21616
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04005471 RID: 21617
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04005472 RID: 21618
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04005473 RID: 21619
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005474 RID: 21620
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005475 RID: 21621
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04005476 RID: 21622
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04005477 RID: 21623
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04005478 RID: 21624
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005479 RID: 21625
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400547A RID: 21626
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400547B RID: 21627
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400547C RID: 21628
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400547D RID: 21629
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400547E RID: 21630
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400547F RID: 21631
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005480 RID: 21632
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005481 RID: 21633
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04005482 RID: 21634
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005483 RID: 21635
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04005484 RID: 21636
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005485 RID: 21637
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04005486 RID: 21638
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04005487 RID: 21639
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0;

		// Token: 0x04005488 RID: 21640
		private static readonly IntPtr NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1;

		// Token: 0x04005489 RID: 21641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400548A RID: 21642
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400548B RID: 21643
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400548C RID: 21644
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400548D RID: 21645
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
