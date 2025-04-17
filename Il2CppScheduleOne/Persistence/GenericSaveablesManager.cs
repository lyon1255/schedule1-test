using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000216 RID: 534
	public class GenericSaveablesManager : Singleton<GenericSaveablesManager>
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x000FD4B4 File Offset: 0x000FB6B4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesManager()
		{
			Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "GenericSaveablesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr);
			GenericSaveablesManager.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "Saveables");
			GenericSaveablesManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "loader");
			GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			GenericSaveablesManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			GenericSaveablesManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668297);
			GenericSaveablesManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668298);
			GenericSaveablesManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668299);
			GenericSaveablesManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668300);
			GenericSaveablesManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668301);
			GenericSaveablesManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668302);
			GenericSaveablesManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668303);
			GenericSaveablesManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668304);
			GenericSaveablesManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668305);
			GenericSaveablesManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668306);
			GenericSaveablesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668307);
			GenericSaveablesManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668308);
			GenericSaveablesManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_IGenericSaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668309);
			GenericSaveablesManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668310);
			GenericSaveablesManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668311);
			GenericSaveablesManager.NativeMethodInfoPtr_LoadSaveable_Public_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668312);
			GenericSaveablesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, 100668313);
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000FD69C File Offset: 0x000FB89C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123996, XrefRangeEnd = 123998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000FD6D4 File Offset: 0x000FB8D4
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123998, XrefRangeEnd = 124000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000FD70C File Offset: 0x000FB90C
		public unsafe virtual Loader Loader
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000FD74C File Offset: 0x000FB94C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x000FD788 File Offset: 0x000FB988
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x000FD7C8 File Offset: 0x000FB9C8
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000FD80C File Offset: 0x000FBA0C
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x000FD84C File Offset: 0x000FBA4C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000FD890 File Offset: 0x000FBA90
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x000FD8CC File Offset: 0x000FBACC
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000FD90C File Offset: 0x000FBB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124000, XrefRangeEnd = 124003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000FD948 File Offset: 0x000FBB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124003, XrefRangeEnd = 124009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000FD984 File Offset: 0x000FBB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124009, XrefRangeEnd = 124015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSaveable(IGenericSaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_IGenericSaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000FD9C8 File Offset: 0x000FBBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124015, XrefRangeEnd = 124017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000FDA0C File Offset: 0x000FBC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124017, XrefRangeEnd = 124060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000FDA68 File Offset: 0x000FBC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124084, RefRangeEnd = 124085, XrefRangeStart = 124060, XrefRangeEnd = 124084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSaveable(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr_LoadSaveable_Public_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000FDAAC File Offset: 0x000FBCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124085, XrefRangeEnd = 124112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00017FA3 File Offset: 0x000161A3
		public GenericSaveablesManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000FDAE8 File Offset: 0x000FBCE8
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00017FAC File Offset: 0x000161AC
		public unsafe List<IGenericSaveable> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGenericSaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000FDB18 File Offset: 0x000FBD18
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00017FCB File Offset: 0x000161CB
		public unsafe GenericSaveablesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSaveablesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000FDB48 File Offset: 0x000FBD48
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00017FEA File Offset: 0x000161EA
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000FDB78 File Offset: 0x000FBD78
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x00018009 File Offset: 0x00016209
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000FDBA8 File Offset: 0x000FBDA8
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x00018028 File Offset: 0x00016228
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSaveable_Public_Void_IGenericSaveable_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_LoadSaveable_Public_Void_GenericSaveData_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008EA RID: 2282
		[ObfuscatedName("ScheduleOne.Persistence.GenericSaveablesManager+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Object
		{
			// Token: 0x0600C4B7 RID: 50359 RVA: 0x002FE604 File Offset: 0x002FC804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveablesManager>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr);
				GenericSaveablesManager.__c__DisplayClass27_0.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr, "guid");
				GenericSaveablesManager.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr, 100668314);
				GenericSaveablesManager.__c__DisplayClass27_0.NativeMethodInfoPtr__LoadSaveable_b__0_Internal_Boolean_IGenericSaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr, 100668315);
			}

			// Token: 0x0600C4B8 RID: 50360 RVA: 0x002FE66C File Offset: 0x002FC86C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesManager.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4B9 RID: 50361 RVA: 0x002FE6A8 File Offset: 0x002FC8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123992, XrefRangeEnd = 123996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadSaveable_b__0(IGenericSaveable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesManager.__c__DisplayClass27_0.NativeMethodInfoPtr__LoadSaveable_b__0_Internal_Boolean_IGenericSaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4BA RID: 50362 RVA: 0x0005FBC1 File Offset: 0x0005DDC1
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D68 RID: 15720
			// (get) Token: 0x0600C4BB RID: 50363 RVA: 0x002FE6F8 File Offset: 0x002FC8F8
			// (set) Token: 0x0600C4BC RID: 50364 RVA: 0x0005FBCA File Offset: 0x0005DDCA
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.__c__DisplayClass27_0.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesManager.__c__DisplayClass27_0.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x04008562 RID: 34146
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04008563 RID: 34147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008564 RID: 34148
			private static readonly IntPtr NativeMethodInfoPtr__LoadSaveable_b__0_Internal_Boolean_IGenericSaveable_0;
		}
	}
}
